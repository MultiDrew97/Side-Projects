Option Strict On

Imports System.Data.SqlClient

Public Class Frm_DisplayCustomers
    Private Property Customers As ObjectModel.Collection(Of Types.Customer)
    Private Property CustomersTable As DataTable

    Private Sub Display_Customers_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgv_Customers.AutoGenerateColumns = False
        GenerateTable()
        refresh()
    End Sub

    Private Sub Frm_DisplayCustomers_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'TODO: Uncomment when finished
        'Dim main As New frm_Main()
        'main.Show()
    End Sub

    Private Sub Btn_AddNewCustomer_Click(sender As Object, e As EventArgs) Handles btn_AddNewCustomer.Click
        Dim addForm = New frm_AddNewCustomer With {.Opener = Me}
        addForm.Show()
    End Sub

    Private Sub Dgv_Customers_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Customers.UserDeletingRow
        If (Not e.Row.IsNewRow) Then
            If MessageBox.Show("Are you sure you want to delete this row?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim id As Integer = CInt(CustomersTable.Rows(e.Row.Index)("CustomerID"))
                Console.WriteLine(id)
                'Using db As New Database
                '    db.RemoveCustomer(CType(e.Row.Cells(2).Value, String))
                'End Using
            End If
        End If
    End Sub

    Public Overrides Sub refresh()
        'This line of code loads data into the 'Media_MinistryDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
        'Me.CustomersTableAdapter.Fill(Me.MediaMinistryDataSet.CUSTOMERS)
        Using db As New Database
            Customers = db.GetCustomers()
        End Using

        FillDataTable()

        bsCustomers.DataSource = CustomersTable
    End Sub

    Private Sub Dgv_Customers_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Customers.CellEndEdit
        'get values from table
        Dim columnNames, newValues As New ObjectModel.Collection(Of String)

        columnNames.Add(dgv_Customers.Columns(e.ColumnIndex).DataPropertyName)
        newValues.Add(CStr(dgv_Customers.Rows(e.RowIndex).Cells(e.ColumnIndex).Value))

        'Dim customer As Types.Customer = Types.Customer.Parse(CustomersTable.Rows(e.RowIndex).ItemArray)
        'Console.WriteLine(customer.ToString)

        Using db = New Database
            db.UpdateCustomer(CInt(CustomersTable.Rows(e.RowIndex)("CustomerID")), columnNames, newValues)
        End Using
    End Sub

    Private Sub GenerateTable()
        CustomersTable = New DataTable("Customers")

        GenerateColumns()
    End Sub

    Private Sub GenerateColumns()
        CustomersTable.Columns.AddRange({
            New DataColumn("CustomerID", Type.GetType("System.Int32")),
            New DataColumn("FirstName", Type.GetType("System.String")),
            New DataColumn("LastName", Type.GetType("System.String")),
            New DataColumn("Street", Type.GetType("System.String")),
            New DataColumn("City", Type.GetType("System.String")),
            New DataColumn("State", Type.GetType("System.String")),
            New DataColumn("ZipCode", Type.GetType("System.String")),
            New DataColumn("PhoneNumber", Type.GetType("System.String")),
            New DataColumn("EmailAddress", Type.GetType("System.String")),
            New DataColumn("JoinDate", Type.GetType("System.String"))
        })
    End Sub

    Private Sub FillDataTable()
        Dim row As DataRow

        CustomersTable.Clear()

        For Each customer As Types.Customer In Customers
            row = CustomersTable.NewRow
            row("CustomerID") = customer.Id
            row("FirstName") = customer.FirstName
            row("LastName") = customer.LastName
            row("Street") = customer.Address.Street
            row("City") = customer.Address.City
            row("State") = customer.Address.State
            row("ZipCode") = customer.Address.ZipCode
            row("PhoneNumber") = customer.PhoneNumber
            row("EmailAddress") = customer.EmailAddress.Address
            row("JoinDate") = customer.JoinDate.ToString().Substring(0, 9)
            CustomersTable.Rows.Add(row)
        Next
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles tsm_Refresh.Click
        refresh()
    End Sub
End Class