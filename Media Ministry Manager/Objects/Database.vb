Option Strict On

'needed for database work
'got the database set up information from here
'https://support.microsoft.com/en-us/help/308656/how-to-open-a-sql-server-database-by-using-the-sql-server-net-data-pro
Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports MediaMinistry.SendingEmails

Public Class Database
    Implements IDisposable
    Private ReadOnly myConn As SqlConnection
    Private ReadOnly myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Public Sub New(connectionString As SqlConnectionStringBuilder)
        'Connect to the database that I have createed for Media Ministry
        myConn = New SqlConnection(connectionString.ConnectionString)
        'create the command object that will be used for queriying the server
        myCmd = myConn.CreateCommand
        'open the connection
        myConn.Open()
    End Sub

    Public Sub New(connection As SqlConnection)
        'Connect to other database server with given connection
        myConn = connection
        myCmd = myConn.CreateCommand
        myConn.Open()
    End Sub

    Public Sub New(username As String, password As String)
        Dim connectionString = New SqlConnectionStringBuilder(My.Settings.masterConnectionString) With {
            .UserID = username,
            .Password = password
        }

        myConn = New SqlConnection(connectionString.ConnectionString)
        myCmd = myConn.CreateCommand
        myConn.Open()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        'close connection
        If (myReader IsNot Nothing) Then
            'if the reader is still open, close it
            myReader.Close()
        End If

        myConn.Close()
        'myConn.Dispose()
    End Sub

    Public Sub CreateUser(username As String, password As String)
        myCmd.Parameters.AddWithValue("Username", username)
        myCmd.Parameters.AddWithValue("Password", password)
        myCmd.CommandText = "CREATE USER @Username WITH PASSWORD = @Password"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub ChangePassword(username As String, password As String)
        myCmd.Parameters.AddWithValue("Username", username)
        myCmd.Parameters.AddWithValue("Password", password)
        myCmd.CommandText = "ALTER LOGIN @Username WITH PASSWORD = @Password"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub DeleteUser(username As String)
        myCmd.Parameters.AddWithValue("Username", username)
        myCmd.CommandText = "DROP USER @Username"
        'TODO: Implement removing logins
    End Sub

    Public Sub AddNewCustomer(
                       fName As String, lName As String,
                       addrStreet As String, addrCity As String, addrState As String, addrZip As String,
                       phoneNumber As String, email As String, paymentPreference As String)

        'used string.format due to enormous query strings and concatination, allowing for easy expansion
        'SELECT CONVERT(VARCHAR(10), getdate(), 101) is a query found online that gets just the date of getdate().
        'source = https://tableplus.io/blog/2018/09/ms-sql-server-how-to-get-date-only-from-datetime-value.html

        'Style	How it’s displayed
        '101    mm/dd/yyyy
        '102    yyyy.mm.dd
        '103    dd/mm/yyyy
        '104    dd.mm.yyyy
        '105    dd-mm-yyyy
        '110    mm-dd-yyyy
        '111    yyyy/mm/dd
        '106    dd mon yyyy
        '107    Mon dd, yyyy

        'date string that holds the command to get the date for when the person joined
        'Dim dateString = "SELECT CONVERT(VARCHAR(10), GETDATE(), 111)"
        myCmd.Parameters.AddRange({New SqlParameter("FirstName", fName), New SqlParameter("LastName", lName), New SqlParameter("Street", addrStreet), New SqlParameter("City", addrCity), New SqlParameter("State", addrState), New SqlParameter("Zip", addrZip), New SqlParameter("Email", email), New SqlParameter("Payment", paymentPreference), New SqlParameter("PhoneNumber", phoneNumber), New SqlParameter("JoinDate", "SELECT CONVERT(VARCHAR(10), GETDATE(), 111)")})

        myCmd.CommandText = "INSERT INTO CUSTOMERS VALUES (@FirstName, @LastName, @Street, @City, @State, @Zip, @PhoneNumber, @Email, @Payment, (@JoinDate))"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub AddListener(name As String, email As String)
        AddListener({New SqlParameter("Name", name), New SqlParameter("Email", email)})
    End Sub

    Public Sub AddListener(paramerters As SqlParameter())
        myCmd.Parameters.AddRange(paramerters)
        myCmd.CommandText = "INSERT INTO EMAIL_LISTENERS VALUES (@Name, @Email)"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub RemoveListener(name As String, email As String)
        RemoveListener({New SqlParameter("Name", name), New SqlParameter("Email", email)})
    End Sub

    Public Sub RemoveListener(parameters As SqlParameter())
        myCmd.Parameters.AddRange(parameters)

        myCmd.CommandText = "DELETE FROM EMAIL_LISTENERS WHERE EMAIL = @Email"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub UpdateListener(name As String, email As String, oldEmail As String)
        UpdateListener({New SqlParameter("Name", name), New SqlParameter("Email", email), New SqlParameter("OldEmail", oldEmail)})
    End Sub

    Public Sub UpdateListener(parameters As SqlParameter())
        myCmd.Parameters.AddRange(parameters)

        myCmd.CommandText = "UPDATE EMAIL_LISTENERS SET NAME=@Name, EMAIL=@Email WHERE EMAIL=@OldEmail"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub UpdateCustomerInfo(addrStreet As String, addrCity As String, addrState As String, addrZip As String, email As String, payment As String, phoneNumber As String)
        Dim params As SqlParameter() = {New SqlParameter("Street", addrStreet), New SqlParameter("City", addrCity), New SqlParameter("State", addrState), New SqlParameter("Zip", addrZip), New SqlParameter("Email", email), New SqlParameter("Payment", payment), New SqlParameter("PhoneNumber", phoneNumber)}
        myCmd.Parameters.AddRange(params)
        myCmd.CommandText = "UPDATE CUSTOMERS
                             SET SHIPPING_STREET = @Street, SHIPPING_CITY = @City, SHIPPING_STATE = @State, SHIPPING_ZIP = @Zip, EMAIL = @Email, PREFERRED_PAYMENT = @Payment
                             WHERE PHONE_NUMBER = @PhoneNumber"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub UpdatePhone(newPhoneNumber As String, oldPhoneNumber As String)
        myCmd.Parameters.AddRange({New SqlParameter("OldNumber", oldPhoneNumber), New SqlParameter("NewNumber", newPhoneNumber)})

        myCmd.CommandText = "UPDATE CUSTOMERS SET PHONE_NUMBER = @NewNumber WHERE PHONE_NUMBER = @OldNumber"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub RemovePerson(phone As String)
        myCmd.Parameters.AddWithValue("PhoneNumber", phone)

        myCmd.CommandText = "DELETE FROM CUSTOMERS WHERE PHONE_NUMBER = @PhoneNumber"

        myCmd.ExecuteNonQuery()

        'Return results

        'SUBSTRACT ORDER NUMBERS FROM INVENTORY
        'myCmd.CommandText = String.Format("UPDATE INVENTORY
        '                                    SET IN_STOCK = IN_STOCK - (SELECT SUM(ITEM_COUNT) FROM WHERE ITEM_INDEX = INVENTORY.ITEM_INDEX AND PHONE_NUMBER = '{0}')",
        '                                    phone)

        ''REMOVE THE ORDER FROM THE TABLES
        'myCmd.CommandText = String.Format("DELETE FROM ORDERS WHERE PHONE_NUMBER = '{0}'", phone)
        'myReader = myCmd.ExecuteReader()

        'Do While myReader.Read()
        '    results = results & myReader.GetString(0) & vbTab & myReader.GetString(1) & vbLf
        'Loop

        'myReader.Close()

        'Return results
    End Sub

    Public Sub AddNewProduct(itemName As String, stock As Integer, price As Decimal)
        myCmd.Parameters.AddRange({New SqlParameter("Item", itemName), New SqlParameter("Stock", stock), New SqlParameter("Price", price)})

        myCmd.CommandText = "INSERT INTO INVENTORY VALUES (@Item, @Stock, @Price)"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub UpdateInventory(name As String, currentStock As Integer, price As Decimal, itemIndex As Integer)
        myCmd.Parameters.AddRange({New SqlParameter("Item", name), New SqlParameter("Stock", currentStock), New SqlParameter("Price", price), New SqlParameter("Index", itemIndex)})

        myCmd.CommandText = "UPDATE INVENTORY SET ITEM = @Item, IN_STOCK = @Stock, PRICE = @Price WHERE ITEM_INDEX = @Index"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub RemoveProduct(itemIndex As Integer)
        myCmd.Parameters.AddWithValue("Index", itemIndex)

        myCmd.CommandText = "DELETE FROM INVENTORY WHERE ITEM_INDEX = @Index"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Function GetOrders() As String
        results = ""
        'create view to use with
        myCmd.CommandText = "CREATE VIEW ORDER_SUMMARY AS
                             SELECT ORDERS.ORDER_NUMBER, PHONE_NUMBER, ITEM, QUANTITY
                             FROM ORDERS, ORDER_COUNTS, INVENTORY
                             WHERE ORDERS.ORDER_NUMBER = ORDER_COUNTS.ORDER_NUMBER AND ORDER_COUNTS.ITEM_INDEX = INVENTORY.ITEM_INDEX"

        myCmd.ExecuteNonQuery()

        myCmd.CommandText = "SELECT * FROM ORDER_SUMMARY"
        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            results = results & myReader.GetInt32(0) & vbTab & myReader.GetString(1) & vbTab & myReader.GetString(2) & vbTab & myReader.GetInt32(3) & vbLf
        Loop

        myReader.Close()

        Return results
    End Function

    Public Function GetCustomerInfo(phoneNumber As String) As String
        results = ""
        myCmd.Parameters.AddWithValue("PhoneNumber", phoneNumber)
        myCmd.CommandText = "SELECT * FROM CUSTOMERS WHERE PHONE_NUMBER = @PhoneNumber"
        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            results = results & myReader.GetString(0) & vbTab & myReader.GetString(1) &
                                myReader.GetString(2) & vbTab & myReader.GetString(3) &
                                myReader.GetString(4) & vbTab & myReader.GetString(5) &
                                myReader.GetString(6) & vbTab & myReader.GetString(7) &
                                myReader.GetString(8) & vbTab & myReader.GetString(9) & vbLf
        Loop

        myReader.Close()

        Return results
    End Function

    Public Function GetOrders(phoneNumber As String) As String
        results = ""
        myCmd.Parameters.AddWithValue("PhoneNumber", phoneNumber)

        myCmd.CommandText = "SELECT ORDERS.ORDER_NUMBER, PHONE_NUMBER, ITEM, QUANTITY
                             FROM ORDERS, ORDER_COUNTS, INVENTORY
                             WHERE ORDERS.ORDER_NUMBER = ORDER_COUNTS.ORDER_NUMBER AND ORDER_COUNTS.ITEM_INDEX = INVENTORY.ITEM_INDEX AND PHONE_NUMBER = @PhoneNumber"
        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            results = results & myReader.GetInt32(0) & vbTab & myReader.GetString(1) & vbTab & myReader.GetString(2) & vbTab & myReader.GetInt32(3) & vbLf
        Loop

        myReader.Close()

        Return results
    End Function

    Public Function GetIndexNumber(orderNumber As Integer) As Integer
        Dim itemIndex As Integer

        myCmd.Parameters.AddWithValue("OrderNumber", orderNumber)

        myCmd.CommandText = "SELECT ITEM_INDEX
                             FROM ORDER_COUNTS
                             WHERE ORDER_NUMBER = @OrderNumber"

        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            itemIndex = myReader.GetInt32(0)
        Loop

        myReader.Close()

        Return itemIndex
    End Function

    'TODO: Turn this into a procedure as well
    Public Sub AddOrder(phoneNumber As String, itemIndex As Integer, quantity As Integer)
        'Dim maxOrder = FindMax("ORDER_NUMBER", "ORDERS", "COMPLETED_ORDERS")
        'Dim maxCount = FindMax("ORDER_INDEX", "ORDER_COUNTS", "COMPLETED_ORDER_COUNTS")

        myCmd.Parameters.AddRange({New SqlParameter("PhoneNumber", phoneNumber), New SqlParameter("Index", itemIndex), New SqlParameter("Quantity", quantity)})
        'insert the order into the ORDERS table
        'Dim orderNumber = Max("ORDER_NUMBER", "ORDERS")
        'Dim completedNumber = Max("ORDER_NUMBER", "COMPLETED_ORDERS")

        'If (orderNumber > completedNumber) Then
        '    maxOrder = orderNumber
        'Else
        '    maxOrder = completedNumber
        'End If

        'Dim orderIndex = Max("ORDER_INDEX", "ORDER_COUNTS")
        'Dim completedCounts = Max("ORDER_INDEX", "COMPLETED_ORDER_COUNTS")

        'If (orderNumber > completedNumber) Then
        '    maxCount = orderNumber
        'Else
        '    maxCount = completedNumber
        'End If

        'myCmd.CommandText = String.Format("INSERT INTO ORDERS VALUES ({0}, '{1}')",
        '                                    orderNumber, phoneNumber)

        'TODO: Remove the need to find the max number and add auto incrementation to the orders and order_counts tables
        'myCmd.CommandText = String.Format("INSERT INTO ORDERS VALUES ({0}, @PhoneNumber){2}
        '                                   INSERT INTO ORDER_COUNTS VALUES ({1}, {0}, @Index, @Quantity)",
        '                                    maxOrder + 1, maxCount + 1, vbLf)
        'myCmd.ExecuteNonQuery()

        ''insert the order counts into the ORDER_COUNTS table
        'myCmd.CommandText = String.Format("INSERT INTO ORDER_COUNTS VALUES ({0}, {1}, {2}, {3})",
        '                                  orderIndex, orderNumber, itemIndex, quantity)

        'myReader = myCmd.ExecuteReader()

        'Do While myReader.Read()
        '    results = results & myReader.GetString(0) & vbTab & myReader.GetString(1) & vbLf
        'Loop

        'myReader.Close()
    End Sub

    'Public Function AddShipment(phoneNumber As String, itemIndex As Integer, quantity As Integer) As String
    '    results = ""
    '    myCmd.CommandText = String.Format("INSERT INTO ORDER_COUNTS VALUES ('{0}', {1}, {2})", phoneNumber, itemIndex, quantity)

    '    myReader = myCmd.ExecuteReader()

    '    Do While myReader.Read()
    '        results = results & myReader.GetString(0) & vbTab & myReader.GetString(1) & vbLf
    '    Loop

    '    myReader.Close()

    '    Return results
    'End Function

    Public Sub UpdateOrder(orderNumber As Integer, quantity As Integer)
        myCmd.Parameters.AddRange({New SqlParameter("OrderNumber", orderNumber), New SqlParameter("Quantity", quantity)})

        myCmd.CommandText = "UPDATE ORDER_COUNTS SET QUANTITY = @Quantity WHERE ORDER_NUMBER = @OrderNumber"

        myCmd.ExecuteNonQuery()
    End Sub

    Private Function FindOrderIndex(orderNumber As Integer) As Integer
        Dim index As Integer

        myCmd.Parameters.AddWithValue("OrderNumber", orderNumber)

        myCmd.CommandText = "SELECT ORDER_INDEX FROM ORDER_COUNTS WHERE ORDER_NUMBER = @OrderNumber"

        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            index = myReader.GetInt32(0)
        Loop

        myReader.Close()

        Return index
    End Function

    Public Sub CancelOrder(orderNumber As Integer)
        myCmd.Parameters.AddWithValue("OrderNumber", orderNumber)

        myCmd.CommandText = "DELETE ORDERS WHERE ORDER_NUMBER = @OrderNumber"

        myCmd.ExecuteNonQuery()
    End Sub

    'TODO: May not even need this later
    'Public Function Count(column As String, table As String) As Integer
    '    Dim total = 0
    '    myCmd.Parameters.AddRange({New SqlParameter("Column", column), New SqlParameter("Table", table)})
    '    myCmd.CommandText = "SELECT COUNT(@Column) FROM @Table"
    '    myReader = myCmd.ExecuteReader()

    '    Do While myReader.Read()
    '        total = myReader.GetInt32(0)
    '    Loop

    '    myReader.Close()

    '    Return total
    'End Function

    Public Function Max(column As String, table As String) As Integer
        Dim maxValue As Integer

        myCmd.Parameters.AddRange({New SqlParameter("Column", column), New SqlParameter("Table", table)})

        myCmd.CommandText = "SELECT MAX(@Column) FROM @Table"

        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            Try
                maxValue = myReader.GetInt32(0)
            Catch ex As SqlException
                maxValue = 0
            End Try
        Loop

        myReader.Close()

        Return maxValue
    End Function

    'Private Function FindMax(column As String, table As String, table2 As String) As Integer
    '    Dim maxNum As Integer

    '    Dim num1 = Max(column, table)
    '    Dim num2 = Max(column, table2)

    '    If (num1 > num2) Then
    '        maxNum = num1
    '    Else
    '        maxNum = num2
    '    End If

    '    Return maxNum
    'End Function

    'TODO: Create Procedure for this action
    Public Sub FulfilOrder(orderNumber As Integer, phoneNumber As String, itemIndex As Integer, quantity As Integer)
        Dim orderIndex = FindOrderIndex(orderNumber)

        myCmd.Parameters.AddRange({New SqlParameter("PhoneNumber", phoneNumber), New SqlParameter("OrderIndex", orderIndex), New SqlParameter("ItemIndex", itemIndex), New SqlParameter("Quantity", quantity)})

        myCmd.CommandText = String.Format("UPDATE INVENTORY SET IN_STOCK = IN_STOCK - @Quantity WHERE ITEM_INDEX = @ItemIndex{0}
                                           INSERT INTO COMPLETED_ORDERS VALUES (@OrderNumber, @PhoneNumber){0}
                                           INSERT INTO COMPLETED_ORDER_COUNTS VALUES (@OrderIndex, @OrderNumber, @ItemIndex, @Quantity){0}
                                           DELETE ORDER_COUNTS WHERE ORDER_NUMBER = @OrderNumber{0}
                                           DELETE ORDERS WHERE ORDER_NUMBER = @OrderNumber",
                                           vbLf)
        myCmd.ExecuteNonQuery()
    End Sub

    Public Function RetrieveListeners() As Collection(Of Listener)
        Dim listeners As New Collection(Of Listener)

        myCmd.CommandText = "SELECT * FROM EMAIL_LISTENERS"

        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            listeners.Add(New Listener(myReader.GetString(0), myReader.GetString(1)))
        Loop

        Return listeners
    End Function

    'Public Function Search(queryString As String) As String()
    '    myCmd.CommandText = queryString
    '    myReader = myCmd.ExecuteReader()
    '    Dim result As String() = {}

    '    result(0) = myReader.GetString(0)
    '    result(1) = myReader.GetString(1)

    '    Return result
    'End Function

    'Public Function UniqueRecord(tableName As String, column As String, value As Integer) As Boolean
    '    results = ""
    '    myCmd.CommandText = String.Format("SELECT * FROM {0} WHERE {1} = {2}", tableName, column, value)
    '    Try
    '        myReader = myCmd.ExecuteReader()

    '        Do While myReader.Read()
    '            results = results & myReader.GetString(0) & vbTab & myReader.GetString(1) & vbLf
    '        Loop
    '    Catch
    '        MsgBox("Something went wrong. That information doesn't seem to exist.")
    '    End Try

    '    myReader.Close()

    '    Return results.Equals("")
    'End Function

    'Public Function UniqueRecord(tableName As String, column As String, value As Integer, phoneNumber As String) As Boolean
    '    results = ""
    '    myCmd.CommandText = String.Format("SELECT * FROM {0} WHERE {1} = {2} AND PHONE_NUMBER = '{3}'", tableName, column, value, phoneNumber)
    '    Try
    '        myReader = myCmd.ExecuteReader()

    '        Do While myReader.Read()
    '            results = results & myReader.GetString(0) & vbTab & myReader.GetString(1) & vbLf
    '        Loop
    '    Catch
    '        MsgBox("Something went wrong. That information doesn't seem to exist.")
    '    Finally
    '        myReader.Close()
    '    End Try

    '    Return results.Equals("")
    'End Function
End Class