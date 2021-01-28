Option Strict On

Public Class Frm_DisplayOrders
    Private ReadOnly OrdersTable As New CustomData.OrdersDataTable
    Private Orders As ObjectModel.Collection(Of Types.CurrentOrder)
    'TODO: Implement a way to change between current and completed orders
    Private Sub Frm_DisplayOrders_Load(sender As Object, e As EventArgs) Handles Me.Load
        bsOrders.DataSource = OrdersTable
        LoadData()
        lbl_NoOrders.Visible = OrdersTable.Rows.Count = 0
    End Sub

    Private Sub Frm_DisplayOrders_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim frm As New frm_Main()
        frm.Show()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Btn_Fulfil_Click(sender As Object, e As EventArgs) Handles btn_Complete.Click
        Dim orderID As Integer

        If dgv_Orders.SelectedRows.Count > 0 Or dgv_Orders.SelectedCells.Count > 0 Then
            For Each row As DataGridViewRow In dgv_Orders.SelectedRows
                Using db = New Database
                    orderID = CInt(CType(row.DataBoundItem, DataRowView)("OrderID"))
                    db.CompleteOrder(orderID)
                    dgv_Orders.Rows.RemoveAt(row.Index)
                End Using
            Next
        Else
            MessageBox.Show("You must select at least 1 order to fulfill it.", "Select an Order", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Btn_ShowCompleted_Click(sender As Object, e As EventArgs) Handles btn_ShowCompleted.Click
        'TODO: Create a new form or dialog box to show completed orders
    End Sub

    Private Sub LoadData()
        Using db As New Database
            Orders = db.GetCurrentOrders
        End Using

        FillTable()
    End Sub

    Private Sub FillTable()
        Dim row As DataRow
        For Each order As Types.CurrentOrder In Orders
            row = OrdersTable.NewRow
            row("OrderID") = order.Id
            row("CustomerName") = order.Customer.Name
            row("ItemName") = order.Item.Name
            row("Quantity") = order.Quantity
            row("OrderDate") = order.OrderDate
            row("OrderTotal") = order.OrderTotal
            OrdersTable.Rows.Add(row)
        Next
    End Sub

    Private Sub Dgv_Orders_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Orders.UserDeletingRow
        If MessageBox.Show("Are you sure you want to cancel this order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Using db As New Database
                Dim orderID As Integer = CInt(CType(e.Row.DataBoundItem, DataRowView)("OrderID"))
                db.CancelOrder(orderID)
            End Using
        Else
            e.Cancel = True
        End If
    End Sub
End Class