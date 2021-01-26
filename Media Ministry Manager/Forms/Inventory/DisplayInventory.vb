Option Strict On

Public Class Frm_DisplayInventory
    Private ProductsTable As New CustomData.InventoryDataTable
    Private Products As ObjectModel.Collection(Of Types.Product)

    Private Sub ViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh()
        bsProducts.DataSource = ProductsTable
    End Sub

    Private Sub Btn_AddProduct_Click(sender As Object, e As EventArgs) Handles btn_AddProduct.Click
        If AddProductDialog.ShowDialog() = DialogResult.OK Then
            Refresh()
        End If
    End Sub

    Private Shadows Sub Refresh()
        ProductsTable.Clear()
        LoadData()
        FillTable()
    End Sub

    Private Sub Frm_ViewInventory_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim frm As New frm_Main()
        frm.Show()
    End Sub

    Private Sub Dgv_Inventory_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Inventory.CellEndEdit
        Dim column As String = dgv_Inventory.Columns(e.ColumnIndex).DataPropertyName
        If Not column.Equals("Available") Then
            Dim value As String = CStr(dgv_Inventory.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        Else
            Dim value As Integer = If(dgv_Inventory.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.Equals("Yes"), 1, 0)
        End If

        Dim itemID As Integer = CInt(ProductsTable.Rows(e.RowIndex)("ItemID"))

        Using db As New Database(My.Settings.Username, My.Settings.Password)
            'db.UpdateInventory(itemID, column, value)
        End Using
    End Sub

    Private Sub Dgv_Inventory_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Inventory.UserDeletingRow
        Using db As New Database(My.Settings.Username, My.Settings.Password)
            db.RemoveProduct(e.Row.Index)
        End Using
        e.Cancel = True
    End Sub

    Private Sub LoadData()
        Using db As New Database
            Products = db.GetProducts
        End Using
    End Sub

    Private Sub FillTable()
        Dim row As DataRow
        For Each product As Types.Product In Products
            row = ProductsTable.NewRow
            row("ItemID") = product.Id
            row("ItemName") = product.Name
            row("Stock") = product.Stock
            row("Price") = product.Price
            row("Available") = product.Available
            ProductsTable.Rows.Add(row)
        Next
    End Sub

    Private Sub Chk_ShowUnavailable_CheckedChanged(sender As Object, e As EventArgs) Handles chk_ShowUnavailable.CheckedChanged
        If chk_ShowUnavailable.Checked Then
            bsProducts.Filter = ""
        Else
            bsProducts.Filter = "Available = True"
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Refresh()
    End Sub

    Private Sub Dgv_Inventory_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_Inventory.MouseDown
        For Each row As DataGridViewRow In dgv_Inventory.Rows
            row.Selected = False
        Next

        If e.Button = MouseButtons.Right Then
            Dim info As DataGridView.HitTestInfo = dgv_Inventory.HitTest(e.X, e.Y)
            If info.RowIndex > -1 Then
                dgv_Inventory.Rows(info.RowIndex).Selected = True
                AvailabilityToolStripMenuItem.Enabled = True
            Else
                AvailabilityToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub

    Private Sub AvailabilityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvailabilityToolStripMenuItem.Click
        For Each row As DataGridViewRow In dgv_Inventory.Rows
            If row.Selected Then
                Using db As New Database
                    db.ChangeAvailability(CInt(CType(row.DataBoundItem, DataRowView)("ItemID")), Not CBool(CType(row.DataBoundItem, DataRowView)("Available")))
                End Using

                Refresh()
                Exit For
            End If
        Next
    End Sub
End Class