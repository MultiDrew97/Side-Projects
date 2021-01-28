Option Strict On

Public Class Frm_DisplayCustomers
    Private Property Customers As ObjectModel.Collection(Of Types.Customer)
    Private Property CustomersTable As New CustomData.CustomersDataTable

    Private Sub Display_Customers_Load(sender As Object, e As EventArgs) Handles Me.Load
        bsCustomers.DataSource = CustomersTable
        Refresh()
    End Sub

    Private Sub Frm_DisplayCustomers_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim main As New Frm_Main()
        main.Show()
    End Sub

    Private Sub Btn_AddNewCustomer_Click(sender As Object, e As EventArgs) Handles btn_AddNewCustomer.Click
        If AddCustomerDialog.ShowDialog() = DialogResult.OK Then
            refresh()
        End If
    End Sub

    Private Sub Dgv_Customers_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Customers.UserDeletingRow
        If MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim id As Integer = CInt(CType(dgv_Customers.Rows(e.Row.Index).DataBoundItem, DataRowView)("CustomerID"))
            Console.WriteLine(id)
            Using db As New Database
                db.RemoveCustomer(id)
            End Using
        Else
            e.Cancel = True
        End If
    End Sub

    Public Overrides Sub Refresh() Handles tsm_Refresh.Click
        Using db As New Database
            Customers = db.GetCustomers()
        End Using

        FillDataTable()
    End Sub

    Private Sub Dgv_Customers_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Customers.CellEndEdit
        'get values from table
        Dim column As String = dgv_Customers.Columns(e.ColumnIndex).DataPropertyName
        Dim value As String = CStr(dgv_Customers.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        Dim customerID As Integer = CInt(CustomersTable.Rows(e.RowIndex)("CustomerID"))

        Using db As New Database
            db.UpdateCustomer(customerID, column, value)
        End Using
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
            row("JoinDate") = customer.JoinDate
            CustomersTable.Rows.Add(row)
        Next
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        For Each row As DataGridViewRow In dgv_Customers.SelectedRows
            If row.Selected Then
                Dgv_Customers_UserDeletingRow(sender, New DataGridViewRowCancelEventArgs(row))
            End If
        Next
    End Sub

    Private Sub Dgv_Customers_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_Customers.MouseDown
        For Each cell As DataGridViewCell In dgv_Customers.SelectedCells
            cell.Selected = False
        Next

        If e.Button = MouseButtons.Right Then
            Dim info As DataGridView.HitTestInfo = dgv_Customers.HitTest(e.X, e.Y)
            RemoveToolStripMenuItem.Enabled = info.RowIndex > -1
            If info.RowIndex > -1 Then
                dgv_Customers.Rows(info.RowIndex).Selected = True
            End If
        End If
    End Sub
End Class