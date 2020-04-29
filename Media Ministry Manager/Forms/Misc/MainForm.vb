Option Strict On

Imports System.ComponentModel
Imports System.IO
Imports Media_Ministry.Utils
Imports System.Text.RegularExpressions.Regex
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.FileIO

Public Class frm_Main
    Dim db As Database
    Dim uploader As DriveUploader
    ReadOnly emailerLocation As String = Application.StartupPath & "\sender.jar"
    Dim first As Boolean = True
    ReadOnly emailPattern As String = "^[a-zA-Z0-9_!#$%&’*+/=?`{|}~^.-]+@[a-zA-Z0-9.-]+$"
    ReadOnly totalTemplate As String = "Total {0}: {1}"

    Structure WindowSizes
        Shared normal As New Size(413, 452)
        Shared max As New Size(1382, 744)
        'tctl_Max size = 1366, 667
    End Structure

    Private Sub MediaMinistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub

    Private Sub MediaMinistry_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        If My.Settings.KeepLoggedIn Then
            frm_Login.Close()
        Else
            frm_Login.Show()
        End If
    End Sub

    Private Sub btn_placeOrder_Click(sender As Object, e As EventArgs) Handles btn_placeOrder.Click
        Dim frm_PlaceOrder As New frm_PlaceOrder(Me)
        frm_PlaceOrder.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ProductManagement_Click(sender As Object, e As EventArgs) Handles btn_ProductManagement.Click
        Dim inventory As New frm_ViewInventory(Me)
        inventory.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ShowOrders_Click(sender As Object, e As EventArgs) Handles btn_ShowOrders.Click
        Dim ordersView As New frm_DisplayOrders(Me)
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
        Dim displayCustomers = New frm_DisplayCustomers(Me)
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
    End Sub

    Private Sub frm_Main_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Not first Then
            'Dim controlsArray As Control() = {btn_CustomerManagement, btn_placeOrder, btn_ShowOrders, btn_ProductManagement, btn_EmailMinistry, tctl_Max}

            If Me.Size = WindowSizes.max Then
                Grow()
            Else
                Shrink()
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        My.Settings.Username = My.MySettings.Default.Username
        My.Settings.Password = My.MySettings.Default.Password
        My.Settings.KeepLoggedIn = My.MySettings.Default.KeepLoggedIn
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
        frm_Login.Close()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim frm_AddCustomer As New frm_AddNewCustomer(Me)
        frm_AddCustomer.Show()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        Dim frm_AddProduct As New frm_AddNewProduct(Me)
        frm_AddProduct.Show()
    End Sub

    Private Sub ListenerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListenerToolStripMenuItem.Click
        Dim frm_AddListener As New frm_AddListener()
        frm_AddListener.Show()
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Dim customers As New frm_DisplayCustomers(Me)
        customers.Show()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        Dim products As New frm_ViewInventory(Me)
        products.Show()
    End Sub

    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        Dim orders As New frm_DisplayOrders(Me)
        orders.Show()
    End Sub

    Private Sub ListenersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListenersToolStripMenuItem.Click
        Dim listeners As New frm_ViewListeners() With {.sendingForm = Me}
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

        loadTables()
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
        'Hide normal size button options
        pnl_Buttons.Hide()

        'show max size menu options
        pnl_Max.Show()

        loadTables()
    End Sub

    Private Sub Shrink()
        'show normal size buttons options
        pnl_Buttons.Show()

        'hide max size menu options
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

    Private Sub ListenerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListenerToolStripMenuItem1.Click
        'TODO: Add Find Listener Functionality
    End Sub

    Private Sub bw_UpdateJar_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bw_UpdateJar.ProgressChanged
        tss_Progress.Value = e.ProgressPercentage
    End Sub

    Private Sub bw_UpdateJar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_UpdateJar.RunWorkerCompleted
        tss_Progress.Value = 0
    End Sub

    Private Sub EmailerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailerToolStripMenuItem.Click
        bw_UpdateJar.RunWorkerAsync(emailerLocation)
    End Sub

    'the sub that will run the update check
    Private Sub MediaMinistryManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediaMinistryManagerToolStripMenuItem.Click
        bw_UpdateApp.RunWorkerAsync()
    End Sub
#Region "Table Loaders"
    Private Sub loadTables()
        loadOrder()
        loadEmail()
        loadInventory()
        loadCustomer()
    End Sub

    Private Sub loadOrder()
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.ORDER_SUMMARY' table. You can move, or remove it, as needed.
        Me.ORDER_SUMMARYTableAdapter.Fill(Me.Media_MinistryDataSet.ORDER_SUMMARY)
        For index As Integer = 0 To (dgv_Orders.Rows.Count - 1)
            dgv_Orders.Rows(index).Cells(0).Value = False
        Next
    End Sub

    Private Sub loadEmail()
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.EMAIL_LISTENERS' table. You can move, or remove it, as needed.
        Me.EMAIL_LISTENERSTableAdapter.Fill(Me.Media_MinistryDataSet.EMAIL_LISTENERS)
        lbl_TotalListeners.Text = String.Format(totalTemplate, "Listeners", dgv_Listeners.RowCount())
    End Sub

    Private Sub loadInventory()
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.INVENTORY' table. You can move, or remove it, as needed.
        Me.INVENTORYTableAdapter.Fill(Me.Media_MinistryDataSet.INVENTORY)
    End Sub

    Private Sub loadCustomer()
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.Media_MinistryDataSet.CUSTOMERS)
        lbl_TotalCustomers.Text = String.Format(totalTemplate, "Listeners", dgv_Customers.RowCount())
    End Sub
#End Region
    Private Sub bw_UpdateApp_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_UpdateApp.DoWork
        'Dim updateMSILocation As String = "https://sppbc.hopto.org/Manager%20Installer/MediaMinistryManagerSetup.msi"
        'Dim updateEXELocation As String = "https://sppbc.hopto.org/Manager%20Installer/setup.exe"
        'Dim version As String = "https://sppbc.hopto.org/Manager%20Installer/version.txt"

        'Dim request As HttpWebRequest = WebRequest.CreateHttp(version)
        'Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
        'bw_UpdateApp.ReportProgress(33)
        'Dim newestVersion As String = New StreamReader(response.GetResponseStream).ReadToEnd()

        'If Not newestVersion.Contains(Application.ProductVersion) Then
        '   bw_UpdateApp.ReportProgress(67) 
        '   wb_Updater.Navigate(updateLocation)
        'End If

        'bw_UpdateApp.ReportProgress(100)
    End Sub
#Region "Email Listeners Tab"
    Private Sub rdo_Single_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Single.CheckedChanged
        If rdo_Single.Checked Then
            gbx_NewListener.Text = "Add Listener"
            btn_AddListener.Text = "Add Listener"

            lbl_ListenerList.Hide()
            txt_FilePath.Hide()
            btn_Browse.Hide()

            lbl_Name.Show()
            txt_Name.Show()
            lbl_Email.Show()
            txt_Email.Show()
        End If
    End Sub

    Private Sub rdo_Multiple_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Multiple.CheckedChanged
        If rdo_Multiple.Checked Then
            gbx_NewListener.Text = "Add Listeners"
            btn_AddListener.Text = "Add Listeners"

            lbl_ListenerList.Show()
            txt_FilePath.Show()
            btn_Browse.Show()

            lbl_Name.Hide()
            txt_Name.Hide()
            lbl_Email.Hide()
            txt_Email.Hide()
        End If
    End Sub

    Private Sub btn_AddListener_Click(sender As Object, e As EventArgs) Handles btn_AddListener.Click
        addListener()
        loadEmail()
    End Sub

    Private Sub addListener()
        Using db = New Database(My.Settings.Username, My.Settings.Password)
            If rdo_Single.Checked Then
                If Not String.IsNullOrWhiteSpace(txt_Email.Text) And Not String.IsNullOrWhiteSpace(txt_Name.Text) Then
                    If IsMatch(txt_Email.Text, emailPattern) Then
                        Try
                            db.AddListener(txt_Name.Text, txt_Email.Text)
                            tss_Feedback.ForeColor = Color.Black
                            tss_Feedback.Text = String.Format("{0} has been added successfully...", txt_Name.Text)
                            sendEmail()
                        Catch ex As SqlException
                            tss_Feedback.ForeColor = Color.Red
                            tss_Feedback.Text = "Listener might already be in the system. Please try again."
                        End Try
                    Else
                        tss_Feedback.Text = "The email is not in a supported format (username@domain.com)..."
                        tss_Feedback.ForeColor = Color.Red
                    End If
                Else
                    tss_Feedback.Text = "No name or email was present"
                    txt_Name.Focus()
                End If
            ElseIf rdo_Multiple.Checked Then
                If Not String.IsNullOrWhiteSpace(txt_FilePath.Text) And Path.GetExtension(txt_FilePath.Text).Equals(".csv") Then
                    Dim fields(2) As String
                    Dim counter As Integer = 0
                    Dim successCount As Integer = 0
                    Dim failCount As Integer = 0
                    Dim newListeners As Listener()
                    'Dim fout As StreamWriter = New StreamWriter(ofd_ListenerList.FileName & "\..\Failed Additions.csv")

                    Using fin As TextFieldParser = New TextFieldParser(ofd_ListenerList.FileName)
                        fin.TextFieldType = FieldType.Delimited
                        fin.SetDelimiters(",")

                        Using fout As StreamWriter = New StreamWriter(ofd_ListenerList.FileName & "\..\Failed Additions.csv")

                            While (Not fin.EndOfData)
                                counter = 0
                                For Each field As String In fin.ReadFields()
                                    fields(counter) = field
                                    counter += 1
                                Next

                                If IsMatch(fields(1), emailPattern) Then
                                    Try
                                        db.AddListener(fields(0), fields(1))
                                        newListeners(successCount) = New Listener(fields(0), fields(1))
                                        successCount += 1
                                    Catch ex As SqlException
                                        fout.WriteLineAsync(String.Format("{0},{1} #{2}", fields(0), fields(1), ex.Message))
                                        failCount += 1
                                    End Try
                                Else
                                    fout.WriteLineAsync(String.Format("{0},{1} # Email does not match email pattern (johndoe@domain.ext)", fields(0), fields(1)))
                                    failCount += 1
                                End If
                            End While
                        End Using
                    End Using

                    tss_Feedback.Text = String.Format("{0} listeners were added successfully...", successCount)
                    Try
                        loadEmail()
                        sendEmails(newListeners)
                    Catch
                    Finally
                        wait(2)
                    End Try

                    If (failCount > 0) Then
                        tss_Feedback.ForeColor = Color.Red
                        tss_Feedback.Text = "Check the FailedAdditions.csv file in the locaiton to see failed additions."
                    Else
                        tss_Feedback.ForeColor = Color.Black
                        tss_Feedback.Text = "All emails were imported successfully..."
                    End If
                Else
                    tss_Feedback.ForeColor = Color.Red
                    tss_Feedback.Text = "You have to select a .csv file..."
                End If
            End If
        End Using
    End Sub

    Private Sub wait(ByVal seconds As Integer)
        'found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub sendEmails(listeners As Listener())
        'send the emails to the new listeners
        Dim sending As Process
        For Each listener As Listener In listeners
            'send the email
            sending = Process.Start("cmd", String.Format("/C java -jar sender.jar -n {0} {1}", listener.name, listener.email))

            sending.WaitForExit()

            If Not sending.ExitCode = 0 Then
                tss_Feedback.ForeColor = Color.Red
                tss_Feedback.Text = "Something went wrong sending the emails. Please try again"
                Return
            End If
        Next
    End Sub

    Private Sub sendEmail()
        'send the email
        Dim sending = Process.Start("cmd", String.Format("/C java -jar sender.jar -n {0} {1}", txt_Name.Text, txt_Email.Text))

        sending.WaitForExit()

        If Not sending.ExitCode = 0 Then
            tss_Feedback.ForeColor = Color.Red
            tss_Feedback.Text = "Something went wrong sending the emails. Please try again"
        End If
    End Sub
#End Region

#Region "Customer Tab"
    Private Sub btn_AddCustomer_Click(sender As Object, e As EventArgs) Handles btn_AddCustomer.Click
        Dim frmAddCustomer As New frm_AddNewCustomer(Me)
        frmAddCustomer.Show()
    End Sub
#End Region

#Region "Orders Tab"
    Private Sub btn_CreateOrder_Click(sender As Object, e As EventArgs) Handles btn_CreateOrder.Click
        Try
            Using db As New Database(My.Settings.Username, My.Settings.Password)
                db.AddOrder(cbx_OrderPhone.SelectedText, cbx_OrderProduct.SelectedIndex, CInt(nud_Quantity.Value))
                tss_Feedback.ForeColor = SystemColors.WindowText
                tss_Feedback.Text = "The order was successfully added for " & cbx_OrderName.Text
                loadOrder()
            End Using
        Catch
            tss_Feedback.Text = "The order could not be added. Please try again"
            tss_Feedback.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub cbx_FirstName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_OrderName.SelectedIndexChanged
        If Not cbx_OrderName.SelectedIndex.Equals(cbx_OrderPhone.SelectedIndex) Then
            cbx_OrderPhone.SelectedIndex = cbx_OrderName.SelectedIndex
        End If
    End Sub

    Private Sub cbx_PhoneNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_OrderPhone.SelectedIndexChanged
        If Not cbx_OrderName.SelectedIndex.Equals(cbx_OrderPhone.SelectedIndex) Then
            cbx_OrderName.SelectedIndex = cbx_OrderPhone.SelectedIndex
        End If
    End Sub

    Private Sub btn_OrderCancel_Click(sender As Object, e As EventArgs) Handles btn_OrderCancel.Click
        Dim orderNumber, index As Integer

        If dgv_Orders.SelectedCells().Count > 0 Then

            'got this idea from these sources
            'how to remove items from the data grid view
            'https://www.youtube.com/watch?v=Yfa1hnpKIzk
            'how to obtain the value from the desired cell from the data grid view
            'https://stackoverflow.com/questions/19721984/how-to-get-cell-value-from-datagridview-in-vb-net
            Do
                If dgv_Orders.Rows(index).Cells(0).Value.Equals(True) Then
                    orderNumber = CInt(dgv_Orders.Rows(index).Cells(1).Value.ToString)
                    Try
                        db.CancelOrder(orderNumber)
                        dgv_Orders.Rows.RemoveAt(index)
                    Catch
                        tss_Feedback.ForeColor = Color.Red
                        tss_Feedback.Text = "Failed to cancel the order(s). Please try again..."
                    End Try
                End If
                index += 1
            Loop Until (index >= dgv_Orders.Rows.Count)
        End If
    End Sub

    Private Sub btn_OrderComplete_Click(sender As Object, e As EventArgs) Handles btn_OrderComplete.Click
        Dim phoneNumber As String
        Dim itemIndex, orderNumber, quantity, index As Integer
        If dgv_Orders.SelectedCells().Count > 0 Then

            'got this idea from these sources
            'how to remove items from the data grid view
            'https://www.youtube.com/watch?v=Yfa1hnpKIzk
            'how to obtain the value from the desired cell from the data grid view
            'https://stackoverflow.com/questions/19721984/how-to-get-cell-value-from-datagridview-in-vb-net
            Do
                If dgv_Orders.Rows(index).Cells(0).Value.Equals(True) Then
                    orderNumber = CInt(dgv_Orders.Rows(index).Cells(1).Value.ToString)
                    phoneNumber = dgv_Orders.Rows(index).Cells(2).Value.ToString
                    itemIndex = db.GetIndexNumber(orderNumber) 'update this to get the item_index number
                    quantity = CInt(dgv_Orders.Rows(index).Cells(4).Value.ToString)
                    Try
                        db.FulfilOrder(orderNumber, phoneNumber, itemIndex, quantity)
                        dgv_Orders.Rows.RemoveAt(index)
                    Catch
                        tss_Feedback.ForeColor = Color.Red
                        tss_Feedback.Text = "Failed to complete the order(s). Please try again..."
                    End Try
                End If
                index += 1
            Loop Until (index >= dgv_Orders.Rows.Count)
        End If
    End Sub
#End Region
End Class