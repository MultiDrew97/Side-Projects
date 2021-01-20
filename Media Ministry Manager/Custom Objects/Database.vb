Option Strict On

'needed for database work
'got the database set up information from here
'https://support.microsoft.com/en-us/help/308656/how-to-open-a-sql-server-database-by-using-the-sql-server-net-data-pro
Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports MediaMinistry.Types

'TODO: Potentially turn this into a proper component
Public Class Database
    Implements IDisposable

    Private ReadOnly myConn As SqlConnection
    Private ReadOnly myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Public Sub New()
        Me.New(My.Settings.Username, My.Settings.Password)
    End Sub

    Public Sub New(username As String, password As String)
        Me.New(New SqlConnectionStringBuilder(My.Resources.databaseConnection) With {
        .UserID = username,
        .Password = password
    })
    End Sub

    Public Sub New(connectionString As SqlConnectionStringBuilder)
        Me.New(New SqlConnection(connectionString.ConnectionString))
    End Sub

    Public Sub New(connection As SqlConnection)
        'Connect to the database that I have createed for Media Ministry
        myConn = connection
        'create the command object that will be used for queriying the server
        myCmd = myConn.CreateCommand
        'open the connection
        myConn.Open()
    End Sub

    Private Sub Close() Implements IDisposable.Dispose
        'close connection
        If (myReader IsNot Nothing) Then
            'if the reader is still open, close it
            myReader.Close()
        End If

        myConn.Close()
        myConn.Dispose()
    End Sub

    Public Sub CreateUser(username As String, password As String)
        myCmd.CommandText = String.Format("CREATE USER {0} WITH PASSWORD = '{1}'", username, password)

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub ChangePassword(username As String, password As String)
        myCmd.CommandText = String.Format("ALTER LOGIN {0} WITH PASSWORD = '{1}'", username, password)

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub DeleteUser(username As String)
        myCmd.CommandText = String.Format("DROP USER {0}", username)
        'TODO: Implement removing logins
    End Sub

    Public Sub AddNewCustomer(
                   fName As String, lName As String,
                   addrStreet As String, addrCity As String, addrState As String, addrZip As String,
                   phoneNumber As String, email As String)

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
        AddCustomer({New SqlParameter("FirstName", fName), New SqlParameter("LastName", lName), New SqlParameter("Street", addrStreet), New SqlParameter("City", addrCity), New SqlParameter("State", addrState), New SqlParameter("Zip", addrZip), New SqlParameter("Phone", phoneNumber), New SqlParameter("Email", email)})
    End Sub

    Private Sub AddCustomer(parameters As SqlParameter())
        myCmd.Parameters.AddRange(parameters)

        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = "AddCustomer"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub AddListener(listener As Listener)
        AddListener(listener.Name, listener.EmailAddress.Address)
    End Sub

    Public Sub AddListener(name As String, email As String)
        AddListener({New SqlParameter("Name", name), New SqlParameter("Email", email)})
    End Sub

    Private Sub AddListener(paramerters As SqlParameter())
        myCmd.Parameters.AddRange(paramerters)

        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = "AddListener"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub RemoveListener(email As String)
        RemoveListener(New SqlParameter("Email", email))
    End Sub

    Public Sub RemoveListener(parameter As SqlParameter)
        myCmd.Parameters.Add(parameter)

        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = "RemoveListener"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub UpdateListener(id As Integer, name As String, newEmail As String, currentEmail As String)
        Dim parts As String() = Listener.ParseName(name)
        UpdateListener(New Listener(id, parts(0), parts(1), newEmail), currentEmail)
    End Sub

    Public Sub UpdateListener(listener As Listener, current As String)
        myCmd.CommandText = String.Format("update email_listeners set name='{0}', email='{1}' where email='{2}'", listener.Name, listener.EmailAddress.Address, current)

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub UpdateCustomerInfo(customer As Customer)
        UpdateCustomerInfo(customer.Id, customer.FirstName, customer.LastName, customer.PhoneNumber, customer.Address.Street, customer.Address.City, customer.Address.State, customer.Address.ZipCode, customer.EmailAddress.Address)
    End Sub

    Public Sub UpdateCustomerInfo(id As Integer, firstName As String, lastName As String, newPhone As String, addrStreet As String, addrCity As String, addrState As String, addrZip As String, email As String)
        results = ""
        myCmd.CommandText = String.Format("UPDATE CUSTOMERS
                                                SET FirstName= '{0}', LAST_NAME = '{1}', PHONE_NUMBER = '{2}',
                                                SHIPPING_STREET = '{3}', SHIPPING_CITY = '{4}', SHIPPING_STATE = '{5}', SHIPPING_ZIP = '{6}',
                                                EMAIL = '{7}'
                                                WHERE CustomerID = {8}",
                                            firstName, lastName, newPhone, addrStreet, addrCity, addrState, addrZip, email, id)
        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub UpdateCustomer(id As Integer, columns As Collection(Of String), values As Collection(Of String))
        Dim command As String = ""

        For i = 0 To columns.Count - 1
            command &= columns(i) & " = '" & values(i) & "'"
            If Not i = columns.Count - 1 Then
                command &= ", "
            End If
        Next

        myCmd.CommandText = String.Format("UPDATE CUSTOMERS
                                            SET {0}
                                            WHERE CustomerID = {1}", command, id)

        myCmd.ExecuteNonQuery()
    End Sub

    Public Function GetProductInfo(id As Integer) As Product
        myCmd.CommandText = String.Format("SELECT * FROM INVENTORY WHERE ItemID = {0}", id)

        Using myReader = myCmd.ExecuteReader
            Do While myReader.Read
                Return New Product(id, myReader.GetString(1), myReader.GetInt32(2), CDec(myReader.GetSqlMoney(3)))
            Loop
        End Using

        Return Nothing
    End Function

    Public Function GetProducts() As Collection(Of Product)
        Dim products As New Collection(Of Product)

        myCmd.CommandText = "SELECT * FROM INVENTORY"

        Using myReader = myCmd.ExecuteReader
            Do While myReader.Read
                products.Add(New Product(myReader.GetInt32(0), myReader.GetString(1), myReader.GetInt32(2), CDec(myReader.GetSqlMoney(3))))
            Loop
        End Using

        Return products
    End Function

    Public Sub UpdatePhone(newPhone As String, oldPhone As String)
        myCmd.CommandText = String.Format("UPDATE CUSTOMERS
                                                SET PHONE_NUMBER = '{0}'
                                                WHERE PHONE_NUMBER = '{1}'",
                                            newPhone, oldPhone)
        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub RemoveCustomer(id As Integer)
        myCmd.CommandText = String.Format("DELETE FROM CUSTOMERS WHERE CustomerID = {0}", id)

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

    Public Sub AddNewProduct(product As Product)
        AddNewProduct(product.Name, product.Stock, product.Price)
    End Sub

    Public Sub AddNewProduct(itemName As String, stock As Integer, price As Double)
        myCmd.CommandText = String.Format("INSERT INTO INVENTORY VALUES ('{1}', {2}, {3})", itemName, stock, price)

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub UpdateInventory(id As Integer, columns As Collection(Of String), values As Collection(Of String))
        Dim command As String = ""

        For i = 0 To columns.Count - 1

            If Not (columns(i).Equals("Stock") Or columns(i).Equals("Price")) Then
                command &= columns(i) & " = '" & values(i) & "'"
            Else
                command &= columns(i) & " = " & values(i)
            End If
            If Not i = columns.Count - 1 Then
                command &= ", "
            End If
        Next

        myCmd.CommandText = String.Format("UPDATE INVENTORY SET {0} WHERE ItemID = {1}", command, id)

        'myCmd.ExecuteNonQuery()
    End Sub

    Public Sub RemoveProduct(itemIndex As Integer)
        myCmd.CommandText = String.Format("DELETE FROM INVENTORY WHERE ITEM_INDEX = {0}{1}
                                           UPDATE INVENTORY SET ITEM_INDEX = ITEM_INDEX - 1 WHERE ITEM_INDEX > {0}",
                                       itemIndex, vbLf)
        myCmd.ExecuteNonQuery()
    End Sub

    Public Function GetOrders() As String
        results = ""
        'create view to use with
        myCmd.CommandText = "CREATE VIEW ORDER_SUMMARY AS
                             SELECT ORDERS.ORDER_NUMBER, PHONE_NUMBER, ITEM, QUANTITY
                             FROM ORDERS, ORDER_COUNTS, INVENTORY
                             WHERE ORDERS.ORDER_NUMBER = ORDER_COUNTS.ORDER_NUMBER AND ORDER_COUNTS.ITEM_INDEX = INVENTORY.ITEM_INDEX"

        myReader = myCmd.ExecuteReader()
        myReader.Close()

        myCmd.CommandText = "SELECT * FROM ORDER_SUMMARY"
        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            results = results & myReader.GetInt32(0) & vbTab & myReader.GetString(1) & vbTab & myReader.GetString(2) & vbTab & myReader.GetInt32(3) & vbLf
        Loop

        myReader.Close()

        Return results
    End Function

    'Public Function GetCustomerInfo(phoneNumber As String) As String
    '    results = ""
    '    myCmd.CommandText = String.Format("SELECT * FROM CUSTOMERS WHERE PHONE_NUMBER = '{0}'", phoneNumber)
    '    myReader = myCmd.ExecuteReader()

    '    Do While myReader.Read()
    '        results = results & myReader.GetString(0) & vbTab & myReader.GetString(1) &
    '                            myReader.GetString(2) & vbTab & myReader.GetString(3) &
    '                            myReader.GetString(4) & vbTab & myReader.GetString(5) &
    '                            myReader.GetString(6) & vbTab & myReader.GetString(7) &
    '                            myReader.GetString(8) & vbTab & vbLf
    '    Loop

    '    myReader.Close()

    '    Return results
    'End Function

    Public Function GetCustomers() As Collection(Of Customer)
        Dim customers As New Collection(Of Customer)

        myCmd.CommandText = "SELECT * FROM CUSTOMERS"

        Using myReader = myCmd.ExecuteReader
            Do While myReader.Read()
                customers.Add(New Customer(myReader.GetInt32(9), myReader.GetString(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3), myReader.GetString(4), myReader.GetString(5), myReader.GetString(6), myReader.GetString(7), myReader.GetString(8)))
            Loop
        End Using

        Return customers
    End Function

    Public Function GetCustomerInfo(id As Integer) As Customer
        myCmd.CommandText = String.Format("SELECT * FROM CUSTOMERS WHERE CustomerID = {0}", id)
        myReader = myCmd.ExecuteReader()

        Using myReader = myCmd.ExecuteReader
            Do While myReader.Read()
                Return New Customer(id, myReader.GetString(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3), myReader.GetString(4), myReader.GetString(5), myReader.GetString(6), myReader.GetString(7), myReader.GetString(8))
                Exit Do
            Loop
        End Using

        Return Nothing
    End Function

    Public Function GetOrders(phoneNumber As String) As String
        results = ""

        myCmd.CommandText = String.Format("SELECT ORDERS.ORDER_NUMBER, PHONE_NUMBER, ITEM, QUANTITY
                                            FROM ORDERS, ORDER_COUNTS, INVENTORY
                                            WHERE ORDERS.ORDER_NUMBER = ORDER_COUNTS.ORDER_NUMBER AND ORDER_COUNTS.ITEM_INDEX = INVENTORY.ITEM_INDEX AND PHONE_NUMBER = '{0}'",
                                      phoneNumber)
        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            results = results & myReader.GetInt32(0) & vbTab & myReader.GetString(1) & vbTab & myReader.GetString(2) & vbTab & myReader.GetInt32(3) & vbLf
        Loop

        myReader.Close()

        Return results
    End Function

    Public Function GetIndexNumber(orderNumber As Integer) As Integer
        Dim itemIndex As Integer

        myCmd.CommandText = String.Format("SELECT ITEM_INDEX
                                           FROM ORDER_COUNTS
                                           WHERE ORDER_NUMBER = {0}",
                                       orderNumber)
        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            itemIndex = myReader.GetInt32(0)
        Loop

        myReader.Close()

        Return itemIndex
    End Function

    Public Sub AddOrder(customerID As Integer, itemID As Integer, quantity As Integer)
        'insert the order into the ORDERS table

        myCmd.CommandText = String.Format("INSERT INTO ORDERS VALUES ({0}, {1}, {2})", customerID, itemID, quantity)
        myCmd.ExecuteNonQuery()

        ''insert the order counts into the ORDER_COUNTS table
        'myCmd.CommandText = String.Format("INSERT INTO ORDER_COUNTS VALUES ({0}, {1}, {2}, {3})",
        '                                  orderIndex, orderNumber, itemIndex, quantity)

        'myReader = myCmd.ExecuteReader()

        'Do While myReader.Read()
        '    results = results & myReader.GetString(0) & vbTab & myReader.GetString(1) & vbLf
        'Loop

        'myReader.Close()
    End Sub

    Public Sub UpdateOrder(orderNumber As Integer, quantity As Integer)
        myCmd.CommandText = String.Format("UPDATE ORDER_COUNTS SET QUANTITY = {0} WHERE ORDER_NUMBER = {1}", quantity, orderNumber)

        myCmd.ExecuteNonQuery()
    End Sub

    Private Function FindOrderIndex(orderNumber As Integer) As Integer
        Dim index As Integer

        myCmd.CommandText = String.Format("SELECT ORDER_INDEX FROM ORDER_COUNTS WHERE ORDER_NUMBER = {0}", orderNumber)

        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            index = myReader.GetInt32(0)
        Loop

        myReader.Close()

        Return index
    End Function

    Public Sub CancelOrder(orderNumber As Integer)
        myCmd.CommandText = String.Format("DELETE ORDERS WHERE ORDER_NUMBER = {0}", orderNumber)

        myCmd.ExecuteNonQuery()
    End Sub

    Public Function Count(column As String, table As String) As Integer
        Dim total = 0
        myCmd.CommandText = String.Format("SELECT COUNT({0}) FROM {1}", column, table)
        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            total = myReader.GetInt32(0)
        Loop

        myReader.Close()

        Return total
    End Function

    Public Function Max(column As String, table As String) As Integer
        Dim maxValue As Integer

        myCmd.CommandText = String.Format("SELECT MAX({0}) FROM {1}", column, table)
        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            Try
                maxValue = myReader.GetInt32(0)
            Catch
                maxValue = 0
            End Try
        Loop

        myReader.Close()

        Return maxValue
    End Function

    Private Function FindMax(column As String, table As String, table2 As String) As Integer
        Dim maxNum As Integer

        Dim num1 = Max(column, table)
        Dim num2 = Max(column, table2)

        If (num1 > num2) Then
            maxNum = num1
        Else
            maxNum = num2
        End If

        Return maxNum
    End Function

    Public Sub FulfilOrder(orderID As Integer)
        'TODO: Turn this into a stored procedure
        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = "FulFillOrder"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Function GetListeners() As Collection(Of Listener)
        Dim listeners As New Collection(Of Listener)
        Dim parts As String()
        myCmd.CommandText = "SELECT * FROM EmailListeners"

        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            parts = Listener.ParseName(myReader.GetString(0))
            listeners.Add(New Listener(myReader.GetInt32(2), parts(0), parts(1), myReader.GetString(1)))
            'listener = Listener.Parse(myReader.GetString(0))
            'listener.EmailAddress = MimeKit.MailboxAddress.Parse(myReader.GetString(1))
            'listeners.Add(listener)
        Loop

        Return listeners
    End Function

    Public Function Search(queryString As String) As String()
        myCmd.CommandText = queryString
        myReader = myCmd.ExecuteReader()
        Dim result(1) As String

        result(0) = myReader.GetString(0)
        result(1) = myReader.GetString(1)

        Return result
    End Function

    Private Sub Open()
        'open the connection
        myConn.Open()
    End Sub

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
'End Namespace