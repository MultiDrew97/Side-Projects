Option Strict On

Imports System.ComponentModel
Imports System.IO
Imports MediaMinistry.Helpers

Public Class Frm_Main
    Structure WindowSizes
        Shared normal As New Size(413, 452)
        Shared max As New Size(1382, 744)
    End Structure

    Private Sub MediaMinistry_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        If My.Application.OpenForms.Count = 1 Then
            If Not My.Settings.KeepLoggedIn Then
                Dim login As New Frm_Login()
                login.Show()
            Else
                My.Settings.Save()
            End If
        Else
            For Each form As Form In My.Application.OpenForms
                If Not form.Name.Equals(Me.Name) Then
                    form.Show()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub btn_placeOrder_Click(sender As Object, e As EventArgs) Handles btn_placeOrder.Click
        'TODO: Re-enable this area
        MessageBox.Show("Sorry. This area is currently under reconstruction.", "Minor Inconveniance", MessageBoxButtons.OK)
        'Dim frm_PlaceOrder As frm_PlaceOrder = New frm_PlaceOrder With {.mainForm = Me}
        'frm_PlaceOrder.Show()
    End Sub

    Private Sub btn_ProductManagement_Click(sender As Object, e As EventArgs) Handles btn_ProductManagement.Click
        Dim inventory As Frm_ViewInventory = New Frm_ViewInventory
        inventory.Show()
        Me.Close()
    End Sub

    Private Sub btn_ShowOrders_Click(sender As Object, e As EventArgs) Handles btn_ShowOrders.Click
        'TODO: Re-enable this area
        MessageBox.Show("Sorry. This area is currently under reconstruction.", "Minor Inconveniance", MessageBoxButtons.OK)
        'Dim ordersView = New Frm_DisplayOrders
        'ordersView.Show()
        'Me.Close()
    End Sub

    Private Sub btn_CustomerManagement_Click(sender As Object, e As EventArgs) Handles btn_CustomerManagement.Click
        Dim displayCustomers = New frm_DisplayCustomers
        displayCustomers.Show()
        Me.Close()
    End Sub

    Private Sub reset()
        tss_Feedback.Text = "What would you like to do?"
        tss_Feedback.ForeColor = SystemColors.WindowText
    End Sub

    Private Sub btn_EmailMinistry_Click(sender As Object, e As EventArgs) Handles btn_EmailMinistry.Click
        'create a email listeners form in the background
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

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        My.Settings.Username = ""
        My.Settings.Password = ""
        My.Settings.KeepLoggedIn = False
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Utils.CloseOpenForms()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim frm_AddCustomer As New frm_AddNewCustomer With {.Opener = Me}
        frm_AddCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        Dim frm_AddProduct As New Frm_AddNewProduct() With {.Opener = Me}
        frm_AddProduct.Show()
        Me.Hide()
    End Sub

    Private Sub ListenerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListenerToolStripMenuItem.Click
        Dim frm_AddListener As New Frm_AddListener()
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
        Dim customers As New frm_DisplayCustomers
        customers.Show()
        Me.Close()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        Dim products As New Frm_ViewInventory
        products.Show()
        Me.Close()
    End Sub

    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        Dim orders As New Frm_DisplayOrders
        orders.Show()
        Me.Close()
    End Sub

    Private Sub ListenersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListenersToolStripMenuItem.Click
        Dim listeners As New frm_ViewListeners
        listeners.Show()
        Me.Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim settings As New Frm_Settings()
        settings.Show()
        Me.Hide()
    End Sub
End Class
