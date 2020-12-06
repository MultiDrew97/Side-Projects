Option Strict On

Imports System.ComponentModel
Imports System.IO
<<<<<<< HEAD
Imports MediaMinistry.Helpers
Imports MediaMinistry.SendingEmails
=======
Imports Media_Ministry.SendingEmails
>>>>>>> master

Public Class frm_Main
    Dim uploader As DriveUploader
    ReadOnly emailerLocation As String = Application.StartupPath & "\sender.jar"

    Structure WindowSizes
        Shared normal As New Size(413, 452)
        Shared max As New Size(1382, 744)
    End Structure

<<<<<<< HEAD
    'Public Sub New() 'ByRef database As Database)

    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.
    '    'db = Database
    '    If Not bw_UpdateJar.IsBusy Then
    '        bw_UpdateJar.RunWorkerAsync(emailerLocation)
    '    End If
    'End Sub
=======
    Private Sub MediaMinistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()

        If Not bw_UpdateJar.IsBusy Then
            bw_UpdateJar.RunWorkerAsync(emailerLocation)
        End If
    End Sub
>>>>>>> master

    Private Sub MediaMinistry_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
<<<<<<< HEAD
        If My.Application.OpenForms.Count = 1 And Not My.Settings.KeepLoggedIn Then
            Dim login As New Frm_Login()
            login.Show()
=======
        If My.Settings.KeepLoggedIn Then
            frm_Login.Close()
        Else
            frm_Login.Show()
>>>>>>> master
        End If
    End Sub

    Private Sub btn_placeOrder_Click(sender As Object, e As EventArgs) Handles btn_placeOrder.Click
        Dim frm_PlaceOrder As frm_PlaceOrder = New frm_PlaceOrder With {.mainForm = Me}
        frm_PlaceOrder.Show()
    End Sub

<<<<<<< HEAD
    Private Sub Btn_ProductManagement_Click(sender As Object, e As EventArgs) Handles btn_ProductManagement.Click
        Dim inventory As frm_ViewInventory = New frm_ViewInventory(Me)
=======
    Private Sub btn_ProductManagement_Click(sender As Object, e As EventArgs) Handles btn_ProductManagement.Click
        Dim inventory As frm_ViewInventory = New frm_ViewInventory With {.mainForm = Me}
>>>>>>> master
        inventory.Show()
        Me.Close()
    End Sub

    Private Sub btn_ShowOrders_Click(sender As Object, e As EventArgs) Handles btn_ShowOrders.Click
        Dim ordersView = New frm_DisplayOrders With {.mainForm = Me}
        ordersView.Show()
<<<<<<< HEAD
        Me.Close()
=======
        Me.Hide()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs)
        reset()
    End Sub

    Private Sub btn_CancelUpdate_Click(sender As Object, e As EventArgs)
        reset()
>>>>>>> master
    End Sub

    Private Sub btn_CustomerManagement_Click(sender As Object, e As EventArgs) Handles btn_CustomerManagement.Click
        Dim displayCustomers = New frm_DisplayCustomers With {.mainForm = Me}
        displayCustomers.Show()
        Me.Close()
    End Sub

    Private Sub reset()
        tss_Feedback.Text = "What would you like to do?"
        tss_Feedback.ForeColor = SystemColors.WindowText
    End Sub

    Private Sub btn_EmailMinistry_Click(sender As Object, e As EventArgs) Handles btn_EmailMinistry.Click
        'create a email listeners form in the background
        tss_Feedback.Text = "Initializing Google Drive Uploader..."
<<<<<<< HEAD
        Dim emailListeners As New Frm_EmailListeners()
        emailListeners.Show()
        Me.Close()
    End Sub

    Private Sub Bw_UpdateJar_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_UpdateJar.DoWork
        'Using out As New BinaryWriter(New FileStream(CType(e.Argument, String), FileMode.OpenOrCreate, FileAccess.Write))
        '    out.Write(My.Resources.sender)
        'End Using

        'If Not ValidateSender(CType(e.Argument, String)) Then
        '    Throw New FileNotFoundException("Sender was not found or was not copied correctly. Contact your developer.")
        'End If
=======
        Dim emailListeners As New frm_EmailListeners() With {.frm_main = Me, .uploader = New DriveUploader()}
        emailListeners.Show()
        Me.Hide()
        reset()
    End Sub

    Private Sub bw_UpdateJar_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_UpdateJar.DoWork
        Using out As New BinaryWriter(New FileStream(CType(e.Argument, String), FileMode.OpenOrCreate, FileAccess.Write))
            out.Write(My.Resources.sender)
        End Using

        If Not validateSender(CType(e.Argument, String)) Then
            Throw New Exception("Sender was not found or was not copied correctly. Contact your developer.")
        End If
>>>>>>> master
    End Sub

    Private Sub frm_Main_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.Size = WindowSizes.max Then
            growToMax()
        Else
            backToNormal()
        End If
    End Sub

    Private Sub growToMax()
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

    Private Sub backToNormal()
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
<<<<<<< HEAD
        Utils.CloseOpenForms()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim frm_AddCustomer As New frm_AddNewCustomer With {.Opener = Me}
=======
        Me.Close()
        frm_Login.Close()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim frm_AddCustomer As New frm_AddNewCustomer With {.sendingForm = Me}
>>>>>>> master
        frm_AddCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
<<<<<<< HEAD
        Dim frm_AddProduct As New frm_AddNewProduct()
=======
        Dim frm_AddProduct As New frm_AddNewProduct With {.sendingForm = Me}
>>>>>>> master
        frm_AddProduct.Show()
        Me.Hide()
    End Sub

    Private Sub ListenerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListenerToolStripMenuItem.Click
        Dim frm_AddListener As New frm_AddListener()
        frm_AddListener.Show()
        Me.Hide()
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

    Private Function validateSender(path As String) As Boolean
        Return File.Exists(path)
    End Function

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        'Dim updateLocation As String = "https://sppbc.hopto.org/Manager%20Installer/MediaMinistryManagerSetup.msi"
        'Dim updateCheck As String = "https://sppbc.hopto.org/Manager%20Installer/version.txt"

        'Dim request As HttpWebRequest = WebRequest.CreateHttp(updateCheck)
        'Dim responce As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

        'Dim sr As StreamReader = New StreamReader(responce.GetResponseStream)

        'Dim latestVersion As String = sr.ReadToEnd()
        'Dim currentVersion As String = Application.ProductVersion

        'If Not latestVersion.Contains(currentVersion) Then
        '    wb_Updater.Navigate(updateLocation)
        'End If
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Dim customers As New frm_DisplayCustomers With {.mainForm = Me}
        customers.Show()
        Me.Close()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
<<<<<<< HEAD
        Dim products As New frm_ViewInventory(Me)
=======
        Dim products As New frm_ViewInventory With {.mainForm = Me}
>>>>>>> master
        products.Show()
        Me.Close()
    End Sub

    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        Dim orders As New frm_DisplayOrders With {.mainForm = Me}
        orders.Show()
        Me.Close()
    End Sub

    Private Sub ListenersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListenersToolStripMenuItem.Click
        Dim listeners As New frm_ViewListeners With {.sendingForm = Me}
        listeners.Show()
        Me.Close()
    End Sub
<<<<<<< HEAD

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim frm_Settings As New Frm_Settings()
        frm_Settings.Show()
        Me.Hide()
    End Sub
=======
>>>>>>> master
End Class
