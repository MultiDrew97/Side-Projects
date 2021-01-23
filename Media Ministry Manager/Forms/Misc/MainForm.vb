Option Strict On

Imports System.ComponentModel
Imports System.IO
Imports MediaMinistry.Helpers

Public Class frm_Main
    ReadOnly emailerLocation As String = Application.StartupPath & "\sender.jar"
    Dim firstTime As Boolean = True

    Structure WindowSizes
        Shared normal As New Size(413, 452)
        Shared max As New Size(1382, 744)
    End Structure

    Private Sub MediaMinistry_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        If My.Application.OpenForms.Count = 1 And Not My.Settings.KeepLoggedIn Then
            Dim login As New Frm_Login()
            login.Show()
        End If
    End Sub

    Private Sub btn_placeOrder_Click(sender As Object, e As EventArgs) Handles btn_placeOrder.Click
        PlaceOrderDialog.ShowDialog()
    End Sub

    Private Sub btn_ProductManagement_Click(sender As Object, e As EventArgs) Handles btn_ProductManagement.Click
        Dim inventory As New Frm_ViewInventory
        inventory.Show()
        Me.Close()
    End Sub

    Private Sub btn_ShowOrders_Click(sender As Object, e As EventArgs) Handles btn_ShowOrders.Click
        Dim ordersView = New Frm_DisplayOrders With {.mainForm = Me}
        ordersView.Show()
        Me.Close()
    End Sub

    Private Sub btn_CustomerManagement_Click(sender As Object, e As EventArgs) Handles btn_CustomerManagement.Click
        Dim displayCustomers = New Frm_DisplayCustomers
        displayCustomers.Show()
        Me.Close()
    End Sub

    Private Sub reset()
        tss_Feedback.Text = "What would you like to do?"
        tss_Feedback.ForeColor = SystemColors.WindowText
    End Sub

    Private Sub btn_EmailMinistry_Click(sender As Object, e As EventArgs) Handles btn_EmailMinistry.Click
        If EmailListenersDialog.ShowDialog = DialogResult.OK Then
            Dim form As Form
            Select Case EmailListenersDialog.SelectedItem
                Case "Send"
                    form = New frm_SendEmails
                Case "Upload"
                    form = New Frm_Upload
                Case "View"
                    form = New Frm_ViewListeners
            End Select

            form.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Frm_Main_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Dim size As String

        If Me.Size = WindowSizes.max Then
            size = "b"
        Else
            size = "s"
        End If

        If Not firstTime Then
            bw_ChangedSizes.RunWorkerAsync(size)
        Else
            firstTime = False
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

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Utils.CloseOpenForms()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
        AddCustomerDialog.ShowDialog()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProductToolStripMenuItem.Click
        AddProductDialog.ShowDialog()
    End Sub

    Private Sub ListenerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewListenerToolStripMenuItem.Click
        AddListenerDialog.Show()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
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

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCustomersToolStripMenuItem.Click
        Dim customers As New Frm_DisplayCustomers
        customers.Show()
        Me.Close()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProductsToolStripMenuItem.Click
        Dim products As New Frm_ViewInventory
        products.Show()
        Me.Close()
    End Sub

    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewOrdersToolStripMenuItem.Click
        Dim orders As New Frm_DisplayOrders With {.mainForm = Me}
        orders.Show()
        Me.Close()
    End Sub

    Private Sub ListenersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewListenersToolStripMenuItem.Click
        Dim listeners As New Frm_ViewListeners
        listeners.Show()
        Me.Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim settings As New Frm_Settings()
        settings.Show()
        Me.Hide()
    End Sub

    Private Sub Bw_ChangedSizes_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_ChangedSizes.DoWork
        Select Case CStr(e.Argument)
            Case "b"
                Invoke(
                    Sub()
                        GrowToMax()
                    End Sub
                )
            Case "s"
                Invoke(
                    Sub()
                        BackToNormal()
                    End Sub
                )
        End Select

    End Sub
End Class
