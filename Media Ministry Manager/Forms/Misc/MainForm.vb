Option Strict On
Imports Media_Ministry.Database
'Imports System.Threading
Public Class frm_Main
    Dim db As Database

    Public Sub New(ByRef database As Database)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        db = database
    End Sub

    Private Sub MediaMinistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'Media_MinistryDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
        'Me.CUSTOMERSTableAdapter.Fill(Me.Media_MinistryDataSet.CUSTOMERS)
        ''TODO: This line of code loads data into the 'Media_MinistryDataSet.INVENTORY' table. You can move, or remove it, as needed.
        'Me.INVENTORYTableAdapter.Fill(Me.Media_MinistryDataSet.INVENTORY)
        ''TODO: This line of code loads data into the 'Media_MinistryDataSet1.INVENTORY' table. You can move, or remove it, as needed.
        'Me.INVENTORYTableAdapter.Fill(Me.Media_MinistryDataSet.INVENTORY)
        reset()
    End Sub

    Private Sub MediaMinistry_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        db.Close()
        If My.Settings.KeepLoggedIn Then
            frm_Login.Close()
        Else
            frm_Login.Show()
        End If
    End Sub

    Private Sub btn_placeOrder_Click(sender As Object, e As EventArgs) Handles btn_placeOrder.Click
        Dim Order As frm_PlaceOrder = New frm_PlaceOrder(db, Me)
        'bw_Database.RunWorkerAsync(Order)
        Order.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ProductManagement_Click(sender As Object, e As EventArgs) Handles btn_ProductManagement.Click
        Dim inventory As frm_ViewInventory = New frm_ViewInventory(db, Me)
        inventory.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ShowOrders_Click(sender As Object, e As EventArgs) Handles btn_ShowOrders.Click
        Dim ordersView = New frm_DisplayOrders(db, Me)
        ordersView.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs)
        reset()
    End Sub

    Private Sub btn_CancelUpdate_Click(sender As Object, e As EventArgs)
        reset()
    End Sub

    Private Sub btn_AddNewCustomer_Click(sender As Object, e As EventArgs) Handles btn_AddNewCustomer.Click
        Dim displayCustomers = New frm_DisplayCustomers(db, Me)
        displayCustomers.Show()
        Me.Hide()
    End Sub

    Private Sub reset()
        tss_DatabaseQueries.Text = "What would you like to do?"
        tss_DatabaseQueries.ForeColor = SystemColors.WindowText
    End Sub

    Private Sub btn_LogOut_Click(sender As Object, e As EventArgs) Handles btn_LogOut.Click
        My.Settings.Username = ""
        My.Settings.Password = ""
        My.Settings.KeepLoggedIn = False
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'create a email listeners form
        Dim emailListeners = New frm_EmailListeners(Me)
        'frm_EmailListeners.Show()
    End Sub
End Class
