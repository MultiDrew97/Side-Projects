Option Strict On

Imports System.ComponentModel
Imports System.IO
Imports Media_Ministry.SendingEmails

Public Class frm_Main
    Dim db As Database
    Dim uploader As DriveUploader
    ReadOnly emailerLocation As String = Application.StartupPath & "\sender.jar"
    Dim first As Boolean = True

    Structure WindowSizes
        Shared normal As New Size(413, 452)
        Shared max As New Size(1382, 744)
        'tctl_Max size = 1366, 667
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
        reset()
    End Sub

    Private Sub MediaMinistry_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        db.Close()
        If My.Settings.KeepLoggedIn Then
            frm_Login.Close()
        Else
            frm_Login.Show()
            'Environment.SetEnvironmentVariable("MediaUsername", "")
            'Environment.SetEnvironmentVariable("MediaPassword", "")
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

    Private Sub btn_EmailMinistry_Click(sender As Object, e As EventArgs) Handles btn_EmailMinistry.Click
        'create a email listeners form in the background
        tss_Feedback.Text = "Initializing Google Drive Uploader..."
        Dim emailListeners As New frm_EmailListeners() With {.frm_main = Me, .uploader = New DriveUploader()}
        emailListeners.Show()
        Me.Hide()
        reset()
    End Sub

    Private Sub bw_UpdateJar_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_UpdateJar.DoWork
        If Not CBool(Environment.GetEnvironmentVariable("updated")) Then
            If File.Exists(CType(e.Argument, String)) Then
                File.Delete(CType(e.Argument, String))
            End If
            bw_UpdateJar.ReportProgress(33)
            Using out As New BinaryWriter(New FileStream(CType(e.Argument, String), FileMode.Create, FileAccess.Write))
                out.Write(My.Resources.sender)
            End Using
            bw_UpdateJar.ReportProgress(67)
            If Not File.Exists(CType(e.Argument, String)) Then
                Throw New Exception("Sender was not found or was not copied correctly. Contact your developer.")
            End If
            bw_UpdateJar.ReportProgress(100)

            Environment.SetEnvironmentVariable("updated", "True")
        End If
    End Sub

    Private Sub frm_Main_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Not first Then
            'Dim controlsArray As Control() = {btn_CustomerManagement, btn_placeOrder, btn_ShowOrders, btn_ProductManagement, btn_EmailMinistry, tctl_Max}

            If Me.Size = WindowSizes.max Then
                Grow()
                'bw_Grow.RunWorkerAsync(controlsArray)
            Else
                Shrink()
                'bw_Shrink.RunWorkerAsync(controlsArray)
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        My.Settings.Username = MySettings.Default.Username
        My.Settings.Password = MySettings.Default.Password
        My.Settings.KeepLoggedIn = MySettings.Default.KeepLoggedIn
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
        frm_Login.Close()
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

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Dim customers As New frm_DisplayCustomers(db, Me)
        customers.Show()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        Dim products As New frm_ViewInventory(db, Me)
        products.Show()
    End Sub

    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        Dim orders As New frm_DisplayOrders(db, Me)
        orders.Show()
    End Sub

    Private Sub ListenersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListenersToolStripMenuItem.Click
        Dim listeners As New frm_ViewListeners(db) With {.sendingForm = Me}
        listeners.Show()
    End Sub

    Private Sub bw_Grow_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_Grow.DoWork
        'Convert the argument parameter into the object array to then hide and show the proper controls
        Dim bwControls As Control() = CType(e.Argument, Control())

        'Hide normal size menu buttons
        bwControls(0).Hide()
        bwControls(1).Hide()
        bwControls(2).Hide()
        bwControls(3).Hide()
        bwControls(4).Hide()

        'show max size menu options
        bwControls(5).Show()

        'TODO: This line of code loads data into the 'Media_MinistryDataSet.ORDER_SUMMARY' table. You can move, or remove it, as needed.
        Me.ORDER_SUMMARYTableAdapter.Fill(Me.Media_MinistryDataSet.ORDER_SUMMARY)
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.EMAIL_LISTENERS' table. You can move, or remove it, as needed.
        Me.EMAIL_LISTENERSTableAdapter.Fill(Me.Media_MinistryDataSet.EMAIL_LISTENERS)
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.INVENTORY' table. You can move, or remove it, as needed.
        Me.INVENTORYTableAdapter.Fill(Me.Media_MinistryDataSet.INVENTORY)
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
        Me.CUSTOMERSTable.Fill(Me.Media_MinistryDataSet.CUSTOMERS)
    End Sub

    Private Sub bw_Shrink_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_Shrink.DoWork
        'Convert the argument parameter into the object array to then hide and show the proper controls
        Dim bwControls As Control() = CType(e.Argument, Control())

        'show normal size menu buttons
        bwControls(0).Show()
        bwControls(1).Show()
        bwControls(2).Show()
        bwControls(3).Show()
        bwControls(4).Show()

        'hide max size menu options
        bwControls(5).Hide()
    End Sub

    Private Sub Grow()
        'Hide normal size menu buttons
        'btn_CustomerManagement.Hide()
        'btn_placeOrder.Hide()
        'btn_ShowOrders.Hide()
        'btn_ProductManagement.Hide()
        'btn_EmailMinistry.Hide()
        pnl_Buttons.Hide()

        'show max size menu options
        'tctl_Max.Show()
        pnl_Max.Show()

        'TODO: This line of code loads data into the 'Media_MinistryDataSet.ORDER_SUMMARY' table. You can move, or remove it, as needed.
        Me.ORDER_SUMMARYTableAdapter.Fill(Me.Media_MinistryDataSet.ORDER_SUMMARY)
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.EMAIL_LISTENERS' table. You can move, or remove it, as needed.
        Me.EMAIL_LISTENERSTableAdapter.Fill(Me.Media_MinistryDataSet.EMAIL_LISTENERS)
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.INVENTORY' table. You can move, or remove it, as needed.
        Me.INVENTORYTableAdapter.Fill(Me.Media_MinistryDataSet.INVENTORY)
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
        Me.CUSTOMERSTable.Fill(Me.Media_MinistryDataSet.CUSTOMERS)
    End Sub

    Private Sub Shrink()
        'show normal size menu buttons
        'btn_CustomerManagement.Show()
        'btn_placeOrder.Show()
        'btn_ShowOrders.Show()
        'btn_ProductManagement.Show()
        'btn_EmailMinistry.Show()
        pnl_Buttons.Show()

        'hide max size menu options
        'tctl_Max.Hide()
        pnl_Max.Hide()
    End Sub
    Private Sub frm_Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'keep things from firing on the initial load
        first = False
        tss_Progress.Value = 0
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

    Private Sub bw_UpdateJar_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bw_UpdateJar.ProgressChanged
        tss_Progress.Value = e.ProgressPercentage
    End Sub
End Class








'this is the function that will be used to update the application when I figure out the installer project
'Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
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
'End Sub