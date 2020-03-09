﻿Option Strict On
Public Class frm_ViewInventory
    Private db As Database
    Private mainForm As frm_Main
    Public Sub New(ByRef database As Database, ByRef mainForm As frm_Main)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        db = database
        Me.mainForm = mainForm
    End Sub
    Private Sub ViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customLoad()
    End Sub

    'Private Sub btn_Remove_Click(sender As Object, e As EventArgs) Handles btn_Remove.Click
    '    Dim index, removeCount As Integer

    '    Do
    '        If dgv_Inventory.Rows(index).Cells(0).Value.Equals(True) Then
    '            'itemIndex = CInt(dgv_Inventory.Rows(index).Cells(3).Value.ToString)

    '            Try
    '                db.RemoveProduct(index)
    '                dgv_Inventory.Rows.RemoveAt(index)
    '                index -= 1
    '                removeCount += 1
    '            Catch

    '            End Try
    '        End If

    '        index += 1
    '    Loop Until (index >= dgv_Inventory.Rows.Count)

    '    If removeCount > 1 Then
    '        MsgBox(String.Format("{0} products were removed from the database", removeCount))
    '    ElseIf removeCount = 1 Then
    '        MsgBox(String.Format("{0} product was removed from the database", removeCount))
    '    End If
    'End Sub

    'Private Sub btn_UpdateProductStock_Click(sender As Object, e As EventArgs) Handles btn_UpdateProductStock.Click
    '    Dim updateStock As frm_UpdateInventory = New frm_UpdateInventory(db, Me)
    '    updateStock.Show()
    '    Me.Hide()
    'End Sub

    Private Sub btn_AddProduct_Click(sender As Object, e As EventArgs) Handles btn_AddProduct.Click
        Dim addNewProduct = New frm_AddNewProduct(db, Me)
        addNewProduct.Show()
        Me.Hide()
    End Sub

    Private Sub frm_ViewInventory_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        mainForm.Show()
    End Sub
    Public Sub customLoad()
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.INVENTORY' table. You can move, or remove it, as needed.
        Me.INVENTORYTableAdapter.Fill(Me.Media_MinistryDataSet.INVENTORY)
    End Sub

    Private Sub dgv_Inventory_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Inventory.CellEndEdit
        Dim editedRow As Integer = e.RowIndex
        Dim name As String = CType(dgv_Inventory.Rows(editedRow).Cells(0).Value, String)
        Dim stock As Integer = CType(dgv_Inventory.Rows(editedRow).Cells(1).Value, Integer)
        Dim price As Decimal = CType(dgv_Inventory.Rows(editedRow).Cells(2).Value, Decimal)

        db.UpdateInventory(name, stock, price, editedRow)
    End Sub

    Private Sub dgv_Inventory_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Inventory.UserDeletingRow
        db.RemoveProduct(e.Row.Index)
    End Sub
End Class