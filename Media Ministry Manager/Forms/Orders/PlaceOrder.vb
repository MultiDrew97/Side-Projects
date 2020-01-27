Option Strict On
Imports System.ComponentModel

Public Class frm_PlaceOrder
    Private ReadOnly _db As Database
    Private firstName, phoneNumber As String
    Private itemIndex, quantity As Integer
    Private mainForm As frm_Main
    Public Sub New(database As Database, ByRef mainForm As frm_Main)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _db = database
        Me.mainForm = mainForm
        bw_LoadingData.RunWorkerAsync()
        wait(1)
    End Sub

    Private Sub frm_PlaceOrder_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        mainForm.Show()
    End Sub

    Private Sub frm_PlaceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'bw_LoadingData.RunWorkerAsync()
        ''TODO: This line of code loads data into the 'Media_MinistryDataSet.INVENTORY' table. You can move, or remove it, as needed.
        'Me.INVENTORYTableAdapter.Fill(Me.Media_MinistryDataSet.INVENTORY)
        ''TODO: This line of code loads data into the 'Media_MinistryDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
        'Me.CUSTOMERSTableAdapter.Fill(Me.Media_MinistryDataSet.CUSTOMERS)
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_AddOrder_Click(sender As Object, e As EventArgs) Handles btn_AddOrder.Click
        phoneNumber = cbx_PhoneNumber.Text
        quantity = CInt(nud_Quantity.Value)
        itemIndex = cbx_ItemName.SelectedIndex

        Try
            _db.AddOrder(phoneNumber, itemIndex, quantity)
            tss_AddOrder.ForeColor = SystemColors.WindowText
            tss_AddOrder.Text = "The order was successfully added for " & cbx_FirstName.Text
        Catch
            tss_AddOrder.Text = "The order could not be added. Please try again"
            tss_AddOrder.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub cbx_FirstName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_FirstName.SelectedIndexChanged
        If Not cbx_FirstName.SelectedIndex.Equals(cbx_PhoneNumber.SelectedIndex) Then
            cbx_PhoneNumber.SelectedIndex = cbx_FirstName.SelectedIndex
        End If
    End Sub

    Private Sub cbx_PhoneNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_PhoneNumber.SelectedIndexChanged
        If Not cbx_FirstName.SelectedIndex.Equals(cbx_PhoneNumber.SelectedIndex) Then
            cbx_FirstName.SelectedIndex = cbx_PhoneNumber.SelectedIndex
        End If
    End Sub

    Private Sub bw_LoadingData_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_LoadingData.DoWork
        Console.WriteLine("Beginning Work")
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.INVENTORY' table. You can move, or remove it, as needed.
        INVENTORYTableAdapter.Fill(Media_MinistryDataSet.INVENTORY)
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
        CUSTOMERSTableAdapter.Fill(Media_MinistryDataSet.CUSTOMERS)
    End Sub

    Private Sub bw_LoadingData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_LoadingData.RunWorkerCompleted
        Console.WriteLine("Done working")
    End Sub

    Private Sub wait(ByVal seconds As Integer)
        'found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
End Class