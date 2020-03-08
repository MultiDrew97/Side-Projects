Option Strict On
Imports System.ComponentModel
Imports System.IO
Imports Media_Ministry.SendingEmails
Public Class frm_Main
    Dim db As Database
    Dim uploader As DriveUploader
    Private emailListeners As frm_EmailListeners
    Public Sub New(ByRef database As Database)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        db = database
        If Not bw_UpdateJar.IsBusy Then
            bw_UpdateJar.RunWorkerAsync(Application.StartupPath & "\sender.jar")
        End If
    End Sub

    Private Sub MediaMinistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim frm_PlaceOrder As frm_PlaceOrder = New frm_PlaceOrder(db, Me)
        frm_PlaceOrder.Show()
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

    Private Sub btn_CustomerManagement_Click(sender As Object, e As EventArgs) Handles btn_CustomerManagement.Click
        Dim displayCustomers = New frm_DisplayCustomers(db, Me)
        displayCustomers.Show()
        Me.Hide()
    End Sub

    Private Sub reset()
        tss_Feedback.Text = "What would you like to do?"
        tss_Feedback.ForeColor = SystemColors.WindowText
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
        tss_Feedback.Text = "Initializing Google Drive Uploader..."
        Dim emailListeners As New frm_EmailListeners() With {.frm_main = Me, .uploader = New DriveUploader()}
        emailListeners.Show()
        Me.Hide()
        reset()
    End Sub

    Private Sub bw_UpdateJar_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_UpdateJar.DoWork
        If Not File.Exists(CType(e.Argument, String)) Then
            Using out As New BinaryWriter(New FileStream(CType(e.Argument, String), FileMode.OpenOrCreate, FileAccess.Write))
                out.Write(My.Resources.sender)
            End Using
        ElseIf Not New FileInfo(CType(e.Argument, String)).Length = My.Resources.sender.Length Then
            Using out As New BinaryWriter(New FileStream(CType(e.Argument, String), FileMode.OpenOrCreate, FileAccess.Write))
                out.Write(My.Resources.sender)
            End Using
        End If
    End Sub
End Class
