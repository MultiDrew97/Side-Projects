Option Strict On

Imports System.Data.SqlClient

Public Class Frm_DisplayCustomers
    Private Property OldPhone As String
    Private Property Customers As ObjectModel.Collection(Of Types.Customer)
    Private Property CustomerTable As DataTable

    Private Sub Display_Customers_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'MediaMinistryDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
        'Me.CUSTOMERSTableAdapter.Fill(Me.MediaMinistryDataSet.CUSTOMERS)
        dgv_Customers.AutoGenerateColumns = False
        refresh()
        GenerateTable()
        bsCustomers.DataSource = CustomerTable
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs)
        'update customer information that was entered
        Dim index, updateCount As Integer
        Dim firstName, lastName, newPhone, street, city, state, zip, email As String
        Dim failedUpdate As Boolean

        updateCount = 0
        failedUpdate = False

        If dgv_Customers.SelectedCells().Count > 0 Then
            'got this idea from these sources
            'how to remove items from the data grid view
            'https://www.youtube.com/watch?v=Yfa1hnpKIzk
            'how to obtain the value from the desired cell from the data grid view
            'https://stackoverflow.com/questions/19721984/how-to-get-cell-value-from-datagridview-in-vb-net

            Do
                If dgv_Customers.Rows(index).Cells(0).Value.Equals(True) Then
                    Using db = New Database(My.Settings.Username, My.Settings.Password)
                        firstName = dgv_Customers.Rows(index).Cells(0).Value.ToString
                        lastName = dgv_Customers.Rows(index).Cells(1).Value.ToString
                        newPhone = dgv_Customers.Rows(index).Cells(2).Value.ToString
                        street = dgv_Customers.Rows(index).Cells(3).Value.ToString
                        city = dgv_Customers.Rows(index).Cells(4).Value.ToString
                        state = dgv_Customers.Rows(index).Cells(5).Value.ToString
                        zip = dgv_Customers.Rows(index).Cells(6).Value.ToString
                        email = dgv_Customers.Rows(index).Cells(7).Value.ToString

                        Try
                            db.UpdateCustomerInfo(firstName, lastName, newPhone, street, city, state, zip, email, OldPhone)
                            updateCount += 1
                        Catch ex As SqlException
                            failedUpdate = True
                        End Try
                    End Using
                End If

                index += 1
            Loop Until (index >= dgv_Customers.Rows.Count)
        End If

        If failedUpdate Then
            tss_CustomersView.ForeColor = Color.Red
            tss_CustomersView.Text = "Some people's informtion was not updated. Please try again."
        ElseIf updateCount > 1 Then
            tss_CustomersView.ForeColor = SystemColors.WindowText
            tss_CustomersView.Text = String.Format("{0} people's informtion was updated", updateCount)
        ElseIf updateCount = 1 Then
            tss_CustomersView.ForeColor = SystemColors.WindowText
            tss_CustomersView.Text = String.Format("{0} person's information was updated", updateCount)
        End If
    End Sub

    Private Sub Frm_DisplayCustomers_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'TODOL Uncomment when finished
        'Dim main As New frm_Main()
        'main.Show()
    End Sub

    Private Sub Btn_UpdatePhone_Click(sender As Object, e As EventArgs) Handles btn_UpdatePhone.Click
        'Dim updateNumber = New frm_UpdatePhoneNumber
        'updateNumber.Show()
    End Sub

    Private Sub Btn_AddNewCustomer_Click(sender As Object, e As EventArgs) Handles btn_AddNewCustomer.Click
        Dim addForm = New frm_AddNewCustomer With {.Opener = Me}
        addForm.Show()
    End Sub

    Private Sub Dgv_Customers_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Customers.UserDeletingRow
        'TODO: Figure out why deletion no longer works with dynamic data source
        Console.WriteLine("Deleting row {0}", e.Row.DataBoundItem.ToString())

        If (Not e.Row.IsNewRow) Then
            If MessageBox.Show("Are you sure you want to delete this row?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Using db As New Database
                    db.RemovePerson(CType(e.Row.Cells(2).Value, String))
                End Using
            End If
        End If
    End Sub

    Public Overrides Sub refresh()
        'This line of code loads data into the 'Media_MinistryDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
        'Me.CustomersTableAdapter.Fill(Me.MediaMinistryDataSet.CUSTOMERS)
        'TODO: Remove this for the final product
        Using db As New Database
            Customers = db.GetCustomers()
        End Using

        'dgv_Customers.Columns(3).DataPropertyName = "Address.Street"
        'dgv_Customers.Columns(4).DataPropertyName = "Address.City"
        'dgv_Customers.Columns(5).DataPropertyName = "Address.State"
        'dgv_Customers.Columns(6).DataPropertyName = "Address.ZipCode"
        'dgv_Customers.Columns(7).DataPropertyName = "EmailAddress.Address"
    End Sub

    Private Sub Dgv_Customers_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Customers.CellEndEdit
        'get values from table

        Dim firstName As String = CType(dgv_Customers.Rows(e.RowIndex).Cells(0).Value, String)
        Dim lastName As String = CType(dgv_Customers.Rows(e.RowIndex).Cells(1).Value, String)
        Dim phone As String = CType(dgv_Customers.Rows(e.RowIndex).Cells(2).Value, String)
        Dim street As String = CType(dgv_Customers.Rows(e.RowIndex).Cells(3).Value, String)
        Dim city As String = CType(dgv_Customers.Rows(e.RowIndex).Cells(4).Value, String)
        Dim state As String = CType(dgv_Customers.Rows(e.RowIndex).Cells(5).Value, String)
        Dim zip As String = CType(dgv_Customers.Rows(e.RowIndex).Cells(6).Value, String)
        Dim email As String = CType(dgv_Customers.Rows(e.RowIndex).Cells(7).Value, String)
        Dim customer As New Types.Customer(firstName, lastName, street, city, state, zip, phone, email)

        'Using db = New Database(My.Settings.Username, My.Settings.Password)
        '    db.UpdateCustomerInfo(customer, OldPhone)
        'End Using
    End Sub

    Private Sub Dgv_Customers_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgv_Customers.CellBeginEdit
        OldPhone = CStr(dgv_Customers.Rows(e.RowIndex).Cells(2).Value)
    End Sub

    Private Sub GenerateTable()
        CustomerTable = New DataTable("Customers")

        GenerateColumns()
        FillDataTable()
    End Sub

    Private Sub GenerateColumns()
        CustomerTable.Columns.AddRange({
            New DataColumn("FirstName", Type.GetType("System.String")),
            New DataColumn("LastName", Type.GetType("System.String")),
            New DataColumn("Street", Type.GetType("System.String")),
            New DataColumn("City", Type.GetType("System.String")),
            New DataColumn("State", Type.GetType("System.String")),
            New DataColumn("ZipCode", Type.GetType("System.String")),
            New DataColumn("PhoneNumber", Type.GetType("System.String")),
            New DataColumn("Email", Type.GetType("System.String")),
            New DataColumn("JoinDate", Type.GetType("System.String"))
        })
    End Sub

    Private Sub FillDataTable()
        Dim row As DataRow
        For Each customer As Types.Customer In Customers
            row = CustomerTable.NewRow
            row("FirstName") = customer.FirstName
            row("LastName") = customer.LastName
            row("Street") = customer.Address.Street
            row("City") = customer.Address.City
            row("State") = customer.Address.State
            row("ZipCode") = customer.Address.ZipCode
            row("PhoneNumber") = customer.PhoneNumber
            row("Email") = customer.EmailAddress.Address
            row("JoinDate") = customer.JoinDate.ToString().Substring(0, 9)
            CustomerTable.Rows.Add(row)
        Next
    End Sub

    Private Sub dgv_Customers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Customers.CellContentClick
        If e.ColumnIndex = 0 Then
            dgv_Customers.Rows(e.RowIndex).Cells(1).Selected = True
            dgv_Customers.BeginEdit(False)
        End If
    End Sub
End Class