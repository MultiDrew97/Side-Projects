Option Strict On
Public Class frm_UpdateInventory
    Private inventoryViewForm As Frm_ViewInventory
    Private selectedIndex As Integer

    Public Sub New(ByRef viewForm As Frm_ViewInventory)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        inventoryViewForm = viewForm
    End Sub

    Private Sub btn_ConfirmUpdate_Click(sender As Object, e As EventArgs) Handles btn_ConfirmUpdate.Click
        Dim item = cbx_Items.SelectedText
        Dim additional = CInt(nud_Stock.Value)
        Dim price As Decimal
        Decimal.TryParse("0" & txt_Price.Text.Substring(1), price)
        Try
            Using db As New Database(My.Settings.Username, My.Settings.Password)
                db.UpdateInventory(item, additional, price, cbx_Items.SelectedIndex)
            End Using
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
        'This line of code loads data into the 'Media_MinistryDataSet.INVENTORY' table. You can move, or remove it, as needed.
        Me.INVENTORYTableAdapter.Fill(Me.MediaMinistryDataSet.INVENTORY)
        cbx_Items.SelectedIndex = selectedIndex
    End Sub

    Private Sub Cbx_Items_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Items.SelectedIndexChanged
        Dim inventory = INVENTORYTableAdapter.GetData

        If cbx_Items.SelectedIndex > 0 Then
            nud_Stock.Value = CType(inventory.Rows.Item(cbx_Items.SelectedIndex).Item(2), Int32)
        End If
    End Sub

    Private Sub txt_Price_GotFocus(sender As Object, e As EventArgs) Handles txt_Price.GotFocus
        If txt_Price.Text.Equals("$0.00") Then
            txt_Price.Text = ""
            txt_Price.ForeColor = SystemColors.WindowText
        Else
            txt_Price.SelectAll()
        End If
    End Sub

    Private Sub txt_Price_LostFocus(sender As Object, e As EventArgs) Handles txt_Price.LostFocus
        If String.IsNullOrEmpty(txt_Price.Text) Then
            txt_Price.Text = "$0.00"
            txt_Price.ForeColor = SystemColors.ControlLight
        Else
            txt_Price.Text = String.Format("0" & txt_Price.Text, "Currency")
        End If
    End Sub
End Class