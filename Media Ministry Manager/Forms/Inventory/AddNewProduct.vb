Option Strict On

Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions.Regex

Public Class frm_AddNewProduct
    Property Opener() As Form

    Private Sub Frm_AddNewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub Frm_AddNewProduct_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            CType(Opener, frm_ViewInventory).customLoad()
        Catch ex As ApplicationException
        Finally
            Opener.Show()
        End Try
    End Sub

    Private Sub Reset()
        txt_ProductName.Text = ""
        nud_Stock.Value = 0
        txt_Price.Text = "$0.00"
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        btn_Add.Focus()
        Dim name As String
        Dim stock As Integer
        Dim price As Decimal

        name = txt_ProductName.Text
        stock = CInt(nud_Stock.Value)
        price = Decimal.Parse("0" & Format(txt_Price.Text, "Standard"), CultureInfo.CurrentCulture)

        Try
            Using db As New Database(My.Settings.Username, My.Settings.Password)
                db.AddNewProduct(name, stock, price)
            End Using
            tss_AddProduct.ForeColor = SystemColors.WindowText
            tss_AddProduct.Text = "Product was successfully added."
        Catch ex As SqlException
            tss_AddProduct.ForeColor = Color.Red
            tss_AddProduct.Text = "Product could not be added. Try again."
        End Try
    End Sub

    Private Sub Txt_ProductName_GotFocus(sender As Object, e As EventArgs) Handles txt_ProductName.GotFocus
        tss_AddProduct.ForeColor = SystemColors.WindowText
        tss_AddProduct.Text = "Enter the products information."
        If (txt_ProductName.Text.Equals("Product Name")) Then
            txt_ProductName.Text = ""
            txt_ProductName.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub Txt_ProductName_LostFocus(sender As Object, e As EventArgs) Handles txt_ProductName.LostFocus
        If (String.IsNullOrEmpty(txt_ProductName.Text)) Then
            ep_EmptyFields.SetError(txt_ProductName, "Enter a name for the product")
            txt_ProductName.Text = "Product Name"
            txt_ProductName.ForeColor = SystemColors.ControlLight
        End If
    End Sub

    Private Sub Txt_Price_GotFocus(sender As Object, e As EventArgs) Handles txt_Price.GotFocus
        If (txt_Price.Text.Equals("$0.00")) Then
            txt_Price.Text = ""
            txt_Price.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub Txt_Price_LostFocus(sender As Object, e As EventArgs) Handles txt_Price.LostFocus
        If (String.IsNullOrEmpty(txt_Price.Text) Or Not IsMatch(txt_Price.Text, "\d*.\d*")) Then
            txt_Price.Text = Format("0", "Currency")
            txt_Price.ForeColor = SystemColors.ControlLight
            ep_EmptyFields.SetError(txt_Price, "Set a price for the product.")
        ElseIf (IsMatch(txt_Price.Text, "\d*.\d*")) Then
            txt_Price.Text = Format(txt_Price.Text, "Currency")
        End If
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Txt_ProductName_TextChanged(sender As Object, e As EventArgs) Handles txt_ProductName.TextChanged
        If (Not txt_ProductName.Text.Equals("Product Name")) Then
            txt_ProductName.ForeColor = SystemColors.WindowText
            txt_ProductName.Text = txt_ProductName.Text.ToUpper
            txt_ProductName.SelectionStart = txt_ProductName.Text.Length + 1
        End If
    End Sub

    Private Sub Nud_Stock_GotFocus(sender As Object, e As EventArgs) Handles nud_Stock.GotFocus
        nud_Stock.Select()
        nud_Stock.Select(0, nud_Stock.Text.Length)
    End Sub

    'Private Sub Txt_Price_TextChanged(sender As Object, e As EventArgs) Handles txt_Price.TextChanged
    '    If (Regex.IsMatch(txt_Price.Text, "\d{1,}.\d{0,2}")) Then
    '        txt_Price.Text = Format(txt_Price.Text.Substring(0, txt_Price.Text.Length - 1), "Currency")
    '    End If
    'End Sub
End Class