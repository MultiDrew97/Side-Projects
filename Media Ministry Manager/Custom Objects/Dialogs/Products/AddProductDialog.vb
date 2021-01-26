﻿Option Strict On

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions.Regex

Public Class AddProductDialog
    Private Sub Frm_AddNewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub

    'Private Sub frm_AddNewProduct_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    '    Try
    '        CType(Opener, frm_ViewInventory).customLoad()
    '    Catch ex As ApplicationException
    '    Finally
    '        Opener.Show()
    '    End Try
    'End Sub

    Private Sub reset()
        txt_ProductName.Text = ""
        nud_Stock.Value = 0
        txt_Price.Text = "$0.00"
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        bw_AddProduct.RunWorkerAsync()
        Me.Hide()
    End Sub

    Private Sub txt_ProductName_GotFocus(sender As Object, e As EventArgs) Handles txt_ProductName.GotFocus
        tss_AddProduct.ForeColor = SystemColors.WindowText
        tss_AddProduct.Text = "Enter the products information."
        If (txt_ProductName.Text.Equals("Product Name")) Then
            txt_ProductName.Text = ""
            txt_ProductName.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub txt_ProductName_LostFocus(sender As Object, e As EventArgs) Handles txt_ProductName.LostFocus
        If (txt_ProductName.Text.Equals("") Or txt_ProductName.Text.Equals(" ")) Then
            ep_EmptyFields.SetError(txt_ProductName, "Enter a name for the product")
            txt_ProductName.Text = "Product Name"
            txt_ProductName.ForeColor = SystemColors.ControlLight
        End If
    End Sub

    Private Sub txt_Price_GotFocus(sender As Object, e As EventArgs) Handles txt_Price.GotFocus
        If (txt_Price.Text.Equals("$0.00")) Then
            txt_Price.Text = ""
            txt_Price.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub txt_Price_LostFocus(sender As Object, e As EventArgs) Handles txt_Price.LostFocus
        If (txt_Price.Text.Equals("") Or Not IsMatch(txt_Price.Text, "\d*.\d*")) Then
            txt_Price.Text = Format("0", "Currency")
            txt_Price.ForeColor = SystemColors.ControlLight
            ep_EmptyFields.SetError(txt_Price, "Set a price for the product.")
        ElseIf (IsMatch(txt_Price.Text, "\d*.\d*")) Then
            txt_Price.Text = Format(txt_Price.Text, "Currency")
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txt_ProductName_TextChanged(sender As Object, e As EventArgs) Handles txt_ProductName.TextChanged
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

    Private Sub Bw_AddProduct_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_AddProduct.DoWork
        Dim name As String
        Dim stock As Integer
        Dim price As Double

        name = txt_ProductName.Text
        stock = CInt(nud_Stock.Value)
        price = Double.Parse("0" & Format(txt_Price.Text, "Standard"))

        Try
            Using db As New Database(My.Settings.Username, My.Settings.Password)
                db.AddNewProduct(name, stock, price)
            End Using
            tss_AddProduct.ForeColor = SystemColors.WindowText
            tss_AddProduct.Text = "Product was successfully added."

            DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As SqlException
            tss_AddProduct.ForeColor = Color.Red
            tss_AddProduct.Text = "Product could not be added. Try again."
        End Try
    End Sub

    'Private Sub txt_Price_TextChanged(sender As Object, e As EventArgs) Handles txt_Price.TextChanged
    '    If (Regex.IsMatch(txt_Price.Text, "\d{1,}.\d{0,2}")) Then
    '        txt_Price.Text = Format(txt_Price.Text.Substring(0, txt_Price.Text.Length - 1), "Currency")
    '    End If
    'End Sub
End Class