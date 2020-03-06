Option Strict On

Public Class frm_Main
    Dim db As Database
    Dim uploader As SendingEmails.DriveUploader
    'Dim emailer As SendingEmailsCS.EmailSender

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
            My.Settings.Username = ""
            My.Settings.Password = ""

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

    Private Sub btn_EmailMinistry_Click(sender As Object, e As EventArgs) Handles btn_EmailMinistry.Click
        'create a email listeners form in the background
        bw_Database.RunWorkerAsync()
    End Sub

    Private Sub bw_Database_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bw_Database.DoWork
        uploader = New SendingEmails.DriveUploader(".\Resources")
        'emailer = New SendingEmailsCS.EmailSender(".\Resources", My.Settings.Username, My.Settings.Password)
    End Sub

    Private Sub bw_Database_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bw_Database.RunWorkerCompleted
        Dim emailListeners = New frm_EmailListeners(Me, uploader) ', emailer)
        Me.Hide()
    End Sub
End Class
