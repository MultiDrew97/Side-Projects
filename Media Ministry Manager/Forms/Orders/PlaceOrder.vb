Option Strict On
Imports System.Data.SqlClient

Public Class Frm_PlaceOrder
    Private ReadOnly _db As Database
    Private ReadOnly mainForm As Frm_Main

    Public Sub New(database As Database, ByRef mainForm As Frm_Main)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _db = database
        Me.mainForm = mainForm
    End Sub

    Private Sub Frm_PlaceOrder_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Dim frm As New Frm_Main()
        'frm.Show()
    End Sub

    Private Sub Frm_PlaceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'These lines of code loads data into the 'Media_MinistryDataSet.INVENTORY' table and 'Media_MinistryDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
        INVENTORYTableAdapter.Fill(MediaMinistryDataSet.INVENTORY)
        CUSTOMERSTableAdapter.Fill(MediaMinistryDataSet.CUSTOMERS)
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Btn_AddOrder_Click(sender As Object, e As EventArgs) Handles btn_AddOrder.Click
        Try
            _db.AddOrder(cbx_PhoneNumber.Text, cbx_ItemName.SelectedIndex, CType(nud_Quantity.Value, Integer))
            tss_AddOrder.ForeColor = SystemColors.WindowText
            tss_AddOrder.Text = "The order was successfully added for " & cbx_FirstName.Text
        Catch ex As SqlException
            tss_AddOrder.Text = "The order could not be added. Please try again"
            tss_AddOrder.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub Cbx_FirstName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_FirstName.SelectedIndexChanged
        If Not cbx_FirstName.SelectedIndex.Equals(cbx_PhoneNumber.SelectedIndex) Then
            cbx_PhoneNumber.SelectedIndex = cbx_FirstName.SelectedIndex
        End If
    End Sub

    Private Sub Cbx_PhoneNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_PhoneNumber.SelectedIndexChanged
        If Not cbx_FirstName.SelectedIndex.Equals(cbx_PhoneNumber.SelectedIndex) Then
            cbx_FirstName.SelectedIndex = cbx_PhoneNumber.SelectedIndex
        End If
    End Sub

    'Private Sub wait(ByVal seconds As Integer)
    '    'found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

    '    For i As Integer = 0 To seconds * 100
    '        System.Threading.Thread.Sleep(10)
    '        Application.DoEvents()
    '    Next
    'End Sub
End Class