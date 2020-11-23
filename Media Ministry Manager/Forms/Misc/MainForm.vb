Option Strict On

Imports System.ComponentModel
Imports System.IO
Imports MediaMinistry.SendingEmails

Public Class Frm_Main
    Dim db As Database
    ReadOnly emailerLocation As String = Application.StartupPath & "\sender.jar"

    Private Structure WindowSizes
        Shared normal As New Size(413, 452)
        Shared max As New Size(1382, 744)
    End Structure

    Public Sub New(ByRef database As Database)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        db = database
        If Not bw_UpdateJar.IsBusy Then
            bw_UpdateJar.RunWorkerAsync(emailerLocation)
        End If
    End Sub

    Private Sub MediaMinistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub MediaMinistry_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        db.Dispose()
        If My.Settings.KeepLoggedIn Then
            Frm_Login.Close()
        Else
            Frm_Login.Show()
        End If
    End Sub

    Private Sub Btn_placeOrder_Click(sender As Object, e As EventArgs) Handles btn_placeOrder.Click
        Dim frm_PlaceOrder As Frm_PlaceOrder = New Frm_PlaceOrder(db, Me)
        frm_PlaceOrder.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_ProductManagement_Click(sender As Object, e As EventArgs) Handles btn_ProductManagement.Click
        Dim inventory As frm_ViewInventory = New frm_ViewInventory(db, Me)
        inventory.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_ShowOrders_Click(sender As Object, e As EventArgs) Handles btn_ShowOrders.Click
        Dim ordersView = New Frm_DisplayOrders(db, Me)
        ordersView.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs)
        Reset()
    End Sub

    Private Sub Btn_CancelUpdate_Click(sender As Object, e As EventArgs)
        Reset()
    End Sub

    Private Sub Btn_CustomerManagement_Click(sender As Object, e As EventArgs) Handles btn_CustomerManagement.Click
        Dim displayCustomers = New frm_DisplayCustomers(db, Me)
        displayCustomers.Show()
        Me.Hide()
    End Sub

    Private Sub Reset()
        tss_Feedback.Text = "What would you like to do?"
        tss_Feedback.ForeColor = SystemColors.WindowText
    End Sub

    Private Sub Btn_EmailMinistry_Click(sender As Object, e As EventArgs) Handles btn_EmailMinistry.Click
        'create a email listeners form in the background
        tss_Feedback.Text = "Initializing Google Drive Uploader..."
        Dim emailListeners As New Frm_EmailListeners() With {.Frm_Main = Me, .Uploader = New DriveUploader()}
        emailListeners.Show()
        Me.Hide()
        Reset()
    End Sub

    Private Sub Bw_UpdateJar_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_UpdateJar.DoWork
        Using out As New BinaryWriter(New FileStream(CType(e.Argument, String), FileMode.OpenOrCreate, FileAccess.Write))
            out.Write(My.Resources.sender)
        End Using

        If Not ValidateSender(CType(e.Argument, String)) Then
            Throw New FileNotFoundException("Sender was not found or was not copied correctly. Contact your developer.")
        End If
    End Sub

    Private Sub Frm_Main_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.Size = WindowSizes.max Then
            GrowToMax()
        Else
            BackToNormal()
        End If
    End Sub

    Private Sub GrowToMax()
        'Hide normal size menu buttons
        btn_CustomerManagement.Hide()
        btn_placeOrder.Hide()
        btn_ShowOrders.Hide()
        btn_ProductManagement.Hide()
        btn_EmailMinistry.Hide()

        'show max size menu options
        'tctl_MaxOption.Show()

        'tctl size
        '1366, 667
    End Sub

    Private Sub BackToNormal()
        'show normal size menu buttons
        btn_CustomerManagement.Show()
        btn_placeOrder.Show()
        btn_ShowOrders.Show()
        btn_ProductManagement.Show()
        btn_EmailMinistry.Show()

        'hide max size menu options
        'tctl_MaxOption.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        My.Settings.Username = ""
        My.Settings.Password = ""
        My.Settings.KeepLoggedIn = False
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
        Frm_Login.Close()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim frm_AddCustomer As New frm_AddNewCustomer(db, Me)
        frm_AddCustomer.Show()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        Dim frm_AddProduct As New frm_AddNewProduct(db, Me)
        frm_AddProduct.Show()
    End Sub

    Private Sub ListenerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListenerToolStripMenuItem.Click
        Dim frm_AddListener As New frm_AddListener()
        frm_AddListener.Show()
    End Sub

    Private Sub CustomerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem1.Click
        'TODO: Add Find Customer Functionality
    End Sub

    Private Sub ProductToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem1.Click
        'TODO: Add Find Product Functionality
    End Sub

    Private Sub ListenerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListenerToolStripMenuItem1.Click
        'TODO: Add Find Listener Functionality
    End Sub

    Shared Function ValidateSender(path As String) As Boolean
        Return File.Exists(path)
    End Function

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        'Dim updateLocation As String = "https://sppbc.hopto.org/Manager%20Installer/MediaMinistryManagerSetup.msi"
        'Dim updateCheck As String = "https://sppbc.hopto.org/Manager%20Installer/version.txt"

        'Dim request As HttpWebRequest = WebRequest.CreateHttp(updateCheck)
        'Dim responce As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

        'Dim sr As StreamReader = New StreamReader(responce.GetResponseStream)

        'Dim newestVersion As String = sr.ReadToEnd()
        'Dim currentVersion As String = Application.ProductVersion

        'If Not newestVersion.Contains(currentVersion) Then
        '    wb_Updater.Navigate(updateLocation)
        'End If
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Dim customers As New frm_DisplayCustomers(db, Me)
        customers.Show()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        Dim products As New frm_ViewInventory(db, Me)
        products.Show()
    End Sub

    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        Dim orders As New Frm_DisplayOrders(db, Me)
        orders.Show()
    End Sub

    Private Sub ListenersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListenersToolStripMenuItem.Click
        Dim listeners As New Frm_ViewListeners(db) With {.SentFrom = Me}
        listeners.Show()
    End Sub
End Class
