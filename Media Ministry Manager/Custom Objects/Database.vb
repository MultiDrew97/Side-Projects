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

    Public Sub RemoveListener(id As Integer)
        RemoveListener(New SqlParameter("ListenerID", id))
    End Sub

    Public Sub RemoveListener(parameter As SqlParameter)
        myCmd.Parameters.Add(parameter)

        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = "RemoveListener"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub UpdateListener(id As Integer, column As String, value As String)
        Dim command As String = String.Format("{0} = {1}", column, value)

        myCmd.CommandText = String.Format("UPDATE EmailListeners SET {0} WHERE ListenerID = {0}", command, id)
    End Sub

    Public Sub UpdateListener(listener As Listener, current As String)
        myCmd.CommandText = String.Format("update email_listeners set name='{0}', email='{1}' where email='{2}'", listener.Name, listener.EmailAddress.Address, current)

        myCmd.ExecuteNonQuery()
    End Sub

    'Public Sub UpdateCustomerInfo(customer As Customer)
    '    UpdateCustomerInfo(customer.Id, customer.FirstName, customer.LastName, customer.PhoneNumber, customer.Address.Street, customer.Address.City, customer.Address.State, customer.Address.ZipCode, customer.EmailAddress.Address)
    'End Sub

    'Public Sub UpdateCustomerInfo(id As Integer, firstName As String, lastName As String, newPhone As String, addrStreet As String, addrCity As String, addrState As String, addrZip As String, email As String)
    '    myCmd.CommandText = String.Format("UPDATE CUSTOMERS
    '                                            SET FirstName= '{0}', LAST_NAME = '{1}', PHONE_NUMBER = '{2}',
    '                                            SHIPPING_STREET = '{3}', SHIPPING_CITY = '{4}', SHIPPING_STATE = '{5}', SHIPPING_ZIP = '{6}',
    '                                            EMAIL = '{7}'
    '                                            WHERE CustomerID = {8}",
    '                                        firstName, lastName, newPhone, addrStreet, addrCity, addrState, addrZip, email, id)
    '    myCmd.ExecuteNonQuery()
    'End Sub

    Public Sub UpdateCustomer(id As Integer, column As String, value As String)
        Dim command As String = String.Format("{0} = {1}", column, value)

        myCmd.CommandText = String.Format("UPDATE CUSTOMERS
                                            SET {0}
                                            WHERE CustomerID = {1}", command, id)

        myCmd.ExecuteNonQuery()
    End Sub

    Public Function GetProductInfo(id As Integer) As Product
        myCmd.CommandText = String.Format("SELECT ItemName, Stock, Price, Available FROM INVENTORY WHERE ItemID = {0}", id)

        Using myReader = myCmd.ExecuteReader
            Do While myReader.Read
                Return New Product(id, myReader.GetString(1), myReader.GetInt32(2), CDec(myReader.GetSqlMoney(3)), myReader.GetBoolean(4))
            Loop
        End Using

        Return Nothing
    End Function

    Public Sub ChangeAvailability(itemID As Integer, value As Boolean)
        Dim bitValue As Integer = If(value, 1, 0)
        myCmd.CommandText = String.Format("UPDATE Inventory SET Available = {0} WHERE ItemID = {1}", bitValue, itemID)
        myCmd.ExecuteNonQuery()
    End Sub

    Public Function GetProducts() As Collection(Of Product)
        Dim products As New Collection(Of Product)

        myCmd.CommandText = "SELECT ItemID, ItemName, Stock, Price, Available FROM Inventory"

        Using myReader = myCmd.ExecuteReader
            Do While myReader.Read
                products.Add(New Product(myReader.GetInt32(0), myReader.GetString(1), myReader.GetInt32(2), CDec(myReader.GetSqlMoney(3)), myReader.GetBoolean(4)))
            Loop
        End Using

        Return products
    End Function

    Public Sub RemoveCustomer(id As Integer)
        myCmd.CommandText = String.Format("DELETE FROM CUSTOMERS WHERE CustomerID = {0}", id)

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub AddNewProduct(product As Product)
        AddNewProduct(product.Name, product.Stock, product.Price)
    End Sub

    Public Sub AddNewProduct(itemName As String, stock As Integer, price As Double)
        myCmd.CommandText = String.Format("INSERT INTO INVENTORY(ItemName, Stock, Price, Available) VALUES ('{0}', {1}, {2}, 1)", itemName, stock, price)

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub UpdateInventory(id As Integer, column As String, value As String)
        Dim command As String

        If Not (column.Equals("Stock") Or column.Equals("Price")) Then
            command = String.Format("{0} = '{1}'", column, value)
        Else
            command = String.Format("{0} = {1}", column, value)
        End If

        myCmd.CommandText = String.Format("UPDATE INVENTORY SET {0} WHERE ItemID = {1}", command, id)

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub RemoveProduct(itemID As Integer)
        myCmd.CommandText = String.Format("UPDATE Inventory SET Available = 0 WHERE ItemID = {0}", itemID)
        myCmd.ExecuteNonQuery()
    End Sub

    Public Function GetCurrentOrders() As Collection(Of CurrentOrder)
        Dim orders As New Collection(Of CurrentOrder)

        'create view to use with
        myCmd.CommandText = "SELECT OrderID, CustomerID, ItemID, Quantity, OrderTotal, OrderDate
                             FROM ORDERS"

        Using myReader = myCmd.ExecuteReader()
            Do While myReader.Read()
                orders.Add(New CurrentOrder(myReader.GetInt32(0), myReader.GetInt32(1), myReader.GetInt32(2), myReader.GetInt32(3), CDec(myReader.GetSqlMoney(4)), myReader.GetDateTime(5)))
            Loop
        End Using

        For orderNumber As Integer = 0 To orders.Count - 1
            myCmd.CommandText = String.Format("SELECT * FROM Customers WHERE CustomerID = {0}", orders(orderNumber).Customer.Id)
            Using myReader = myCmd.ExecuteReader
                Do While myReader.Read
                    orders(orderNumber).Customer.FirstName = myReader.GetString(1)
                    orders(orderNumber).Customer.LastName = myReader.GetString(2)
                    orders(orderNumber).Customer.Address.Street = myReader.GetString(3)
                    orders(orderNumber).Customer.Address.City = myReader.GetString(4)
                    orders(orderNumber).Customer.Address.State = myReader.GetString(5)
                    orders(orderNumber).Customer.Address.ZipCode = myReader.GetString(6)
                    orders(orderNumber).Customer.PhoneNumber = myReader.GetString(7)
                    orders(orderNumber).Customer.EmailAddress = New MimeKit.MailboxAddress(orders(orderNumber).Customer.Name, myReader.GetString(8))
                    orders(orderNumber).Customer.JoinDate = Date.Parse(myReader.GetString(9))
                Loop
            End Using

            myCmd.CommandText = String.Format("SELECT * FROM INVENTORY WHERE ItemID = {0}", orders(orderNumber).Item.Id)
            Using myReader = myCmd.ExecuteReader
                Do While myReader.Read
                    orders(orderNumber).Item.Name = myReader.GetString(1)
                    orders(orderNumber).Item.Stock = myReader.GetInt32(2)
                    orders(orderNumber).Item.Price = CDec(myReader.GetSqlMoney(3))
                Loop
            End Using
        Next

        Return orders
    End Function

    Public Function GetCompletedOrders() As Collection(Of CompletedOrder)
        Dim orders As New Collection(Of CompletedOrder)

        'create view to use with
        myCmd.CommandText = "SELECT OrderID, CustomerID, ItemID, Quantity, OrderTotal, OrderDate, CompletedDate
                             FROM CompletedOrders"

        Using myReader = myCmd.ExecuteReader()
            Do While myReader.Read()
                orders.Add(New CompletedOrder(myReader.GetInt32(0), myReader.GetInt32(1), myReader.GetInt32(2), myReader.GetInt32(3), CDec(myReader.GetSqlMoney(4)), myReader.GetDateTime(5), myReader.GetDateTime(6)))
            Loop
        End Using

        Return orders
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

    Public Sub AddOrder(customerID As Integer, itemID As Integer, quantity As Integer)
        'insert the order into the ORDERS table
        myCmd.CommandText = "AddOrder"
        myCmd.CommandType = CommandType.StoredProcedure

        myCmd.Parameters.Item(0).Value = customerID
        myCmd.Parameters.Item(1).Value = itemID
        myCmd.Parameters.Item(2).Value = quantity

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

    Public Sub CancelOrder(orderID As Integer)
        myCmd.CommandText = "CancelOrder"
        myCmd.CommandType = CommandType.StoredProcedure

        myCmd.Parameters.AddWithValue("OrderID", orderID)

        myCmd.ExecuteNonQuery()
    End Sub

    Public Sub CompleteOrder(orderID As Integer)
        'TODO: Turn this into a stored procedure
        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = "CompleteOrder"

        myCmd.ExecuteNonQuery()
    End Sub

    Public Function GetListeners() As Collection(Of Listener)
        Dim listeners As New Collection(Of Listener)
        Dim parts As String()
        myCmd.CommandText = "SELECT * FROM EmailListeners"

        Using myReader = myCmd.ExecuteReader()
            Do While myReader.Read()
                parts = Listener.ParseName(myReader.GetString(0))
                listeners.Add(New Listener(myReader.GetInt32(2), parts(0), parts(1), myReader.GetString(1)))
            Loop
        End Using

        Return listeners
    End Function

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