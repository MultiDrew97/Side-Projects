Option Strict On
Imports System.Data.SqlClient

Public Class Frm_DisplayOrders
    Private ReadOnly OrdersTable As New CustomData.OrdersDataTable
    Private Orders As ObjectModel.Collection(Of Types.CurrentOrder)
    'TODO: Implement custom table filling for this form
    'TODO: Implement a way to change between current and completed orders
    Private Sub Frm_DisplayOrders_Load(sender As Object, e As EventArgs) Handles Me.Load
        bsOrders.DataSource = OrdersTable
        LoadData()
    End Sub

    Private Sub Frm_DisplayOrders_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim frm As New frm_Main()
        frm.Show()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Btn_Fulfil_Click(sender As Object, e As EventArgs) Handles btn_Complete.Click
        Dim phoneNumber As String
        Dim itemIndex, orderNumber, quantity, index As Integer
        index = 0
        If dgv_Orders.SelectedCells().Count > 0 Then

            'got this idea from these sources
            'how to remove items from the data grid view
            'https://www.youtube.com/watch?v=Yfa1hnpKIzk
            'how to obtain the value from the desired cell from the data grid view
            'https://stackoverflow.com/questions/19721984/how-to-get-cell-value-from-datagridview-in-vb-net
            Do
                If dgv_Orders.Rows(index).Cells(0).Value.Equals("true") Then
                    Using db = New Database(My.Settings.Username, My.Settings.Password)
                        orderNumber = CInt(dgv_Orders.Rows(index).Cells(1).Value.ToString)
                        phoneNumber = dgv_Orders.Rows(index).Cells(2).Value.ToString
                        'itemIndex = db.GetIndexNumber(orderNumber) 'update this to get the item_index number
                        quantity = CInt(dgv_Orders.Rows(index).Cells(4).Value.ToString)
                        Try
                            'db.CompleteOrder(orderNumber)
                            dgv_Orders.Rows.RemoveAt(index)
                        Catch ex As SqlException

                        End Try
                    End Using
                End If
                index += 1
            Loop Until (index >= dgv_Orders.Rows.Count)
        End If
    End Sub

    Private Sub Btn_CancelOrder_Click(sender As Object, e As EventArgs) Handles btn_CancelOrder.Click
        Dim orderNumber, index As Integer
        index = 0
        If dgv_Orders.SelectedCells().Count > 0 Then

            'got this idea from these sources
            'how to remove items from the data grid view
            'https://www.youtube.com/watch?v=Yfa1hnpKIzk
            'how to obtain the value from the desired cell from the data grid view
            'https://stackoverflow.com/questions/19721984/how-to-get-cell-value-from-datagridview-in-vb-net
            Do
                If dgv_Orders.Rows(index).Cells(0).Value.Equals(True) Then
                    Using db = New Database(My.Settings.Username, My.Settings.Password)
                        orderNumber = CInt(dgv_Orders.Rows(index).Cells(1).Value.ToString)
                        Try
                            db.CancelOrder(orderNumber)
                            dgv_Orders.Rows.RemoveAt(index)
                        Catch

                        End Try
                    End Using
                End If
                index += 1
            Loop Until (index >= dgv_Orders.Rows.Count)
        End If
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
            OrdersTable.Rows.Add(row)
        Next
    End Sub
End Class