Option Strict On

Public Class Frm_ViewInventory
    Private ProductsTable As DataTable
    Private Products As ObjectModel.Collection(Of Types.Product)

    Private Sub ViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh()
    End Sub

    Private Sub Btn_AddProduct_Click(sender As Object, e As EventArgs) Handles btn_AddProduct.Click
        If AddProductDialog.ShowDialog() = DialogResult.OK Then
            Refresh()
        End If
    End Sub

    Private Shadows Sub Refresh()
        LoadData()
        GenerateTable()
        FillTable()

        bsProducts.DataSource = ProductsTable
    End Sub

    Private Sub Frm_ViewInventory_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim frm As New frm_Main()
        frm.Show()
    End Sub

    Private Sub Dgv_Inventory_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Inventory.CellEndEdit
        Dim column As String = dgv_Inventory.Columns(e.ColumnIndex).DataPropertyName
        Dim value As String = CStr(dgv_Inventory.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        Dim itemID As Integer = CInt(ProductsTable.Rows(e.RowIndex)("ItemID"))

        Using db As New Database(My.Settings.Username, My.Settings.Password)
            db.UpdateInventory(itemID, column, value)
        End Using
    End Sub

    Private Sub Dgv_Inventory_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Inventory.UserDeletingRow
        Using db As New Database(My.Settings.Username, My.Settings.Password)
            db.RemoveProduct(e.Row.Index)
        End Using
    End Sub

    Private Sub LoadData()
        Using db As New Database
            Products = db.GetProducts
        End Using
    End Sub

    Private Sub GenerateTable()
        ProductsTable = New DataTable

        GenerateColumns()
    End Sub

    Private Sub GenerateColumns()
        ProductsTable.Columns.AddRange({New DataColumn("ItemID", Type.GetType("System.Int32")), New DataColumn("Name", Type.GetType("System.String")), New DataColumn("Stock", Type.GetType("System.Int32")), New DataColumn("Price", Type.GetType("System.Double"))})
    End Sub

    Private Sub FillTable()
        Dim row As DataRow
        For Each product As Types.Product In Products
            row = ProductsTable.NewRow
            row("ItemID") = product.Id
            row("Name") = product.Name
            row("Stock") = product.Stock
            row("Price") = product.Price
            ProductsTable.Rows.Add(row)
        Next
    End Sub
End Class