Option Strict On
Public Class frm_UpdateInventory
    Private db As Database
    Private inventoryViewForm As frm_ViewInventory
    Private selectedIndex As Integer

    Public Sub New(ByRef database As Database, ByRef viewForm As frm_ViewInventory)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        db = database
        inventoryViewForm = viewForm
    End Sub

    Public Sub New(ByRef database As Database, ByRef viewForm As frm_ViewInventory, ByRef index As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        db = database
        inventoryViewForm = viewForm

        selectedIndex = index
    End Sub

    Private Sub btn_ConfirmUpdate_Click(sender As Object, e As EventArgs) Handles btn_ConfirmUpdate.Click
        Dim itemIndex = cbx_Items.SelectedIndex
        Dim additional = CInt(nud_Stock.Value)

        Try
            db.UpdateInventory(itemIndex, additional)
            tss_AddStock.ForeColor = SystemColors.WindowText
            tss_AddStock.Text = "Stock has been updated for the product"
        Catch
            tss_AddStock.ForeColor = Color.Red
            tss_AddStock.Text = "Could not update the stock for that product. Please try again."
        End Try
    End Sub

    Private Sub btn_CancelUpdate_Click(sender As Object, e As EventArgs) Handles btn_CancelUpdate.Click
        Me.Close()
    End Sub

    Private Sub frm_UpdateInventory_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        inventoryViewForm.customLoad()
        inventoryViewForm.Show()
    End Sub

    Private Sub frm_UpdateInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.INVENTORY' table. You can move, or remove it, as needed.
        Me.INVENTORYTableAdapter.Fill(Me.Media_MinistryDataSet.INVENTORY)
        cbx_Items.SelectedIndex = selectedIndex
    End Sub

    Private Sub Cbx_Items_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Items.SelectedIndexChanged
        Dim inventory = INVENTORYTableAdapter.GetData

        If cbx_Items.SelectedIndex > 0 Then
            nud_Stock.Value = CType(inventory.Rows.Item(cbx_Items.SelectedIndex).Item(2), Int32)
        End If
    End Sub
End Class