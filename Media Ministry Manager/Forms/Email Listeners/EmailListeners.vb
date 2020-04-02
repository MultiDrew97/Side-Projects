Option Strict On

Imports System.ComponentModel
Imports Media_Ministry.SendingEmails

Public Class frm_EmailListeners
    Public uploader As DriveUploader
    Public frm_main As frm_Main
    ReadOnly shareLink As String = "https://drive.google.com/file/d/{0}/view?usp=sharing"
    Private fileID As String = Nothing
    ReadOnly emailer As String = Application.StartupPath & "\sender.jar"

    Structure MinisLocations
        Shared upload As New Point(20, 13)
        Shared sending As New Point(20, 71)
        Shared view As New Point(20, 129)
        Shared folders As New Point(389, 68)
        Shared file As New Point(389, 127)
        Shared group As New Point(389, 13)
        Shared ministry As New Point(65, 19)
        Shared live As New Point(196, 19)
    End Structure

    Structure LiveLocations
        Shared upload As New Point()
        Shared sending As New Point()
        Shared view As New Point()
        Shared folders As New Point()
        Shared file As New Point()
        Shared group As New Point()
        Shared ministry As New Point()
        Shared live As New Point()
    End Structure

    Structure MinisSizes
        Shared form As New Size(842, 240)
    End Structure

    Structure LiveSizes
        Shared form As New Size(900, 800)
    End Structure

    Private Sub btn_Upload_Click(sender As Object, e As EventArgs) Handles btn_Upload.Click
        tss_Feedback.ForeColor = Color.Black
        bw_Upload.RunWorkerAsync({cbx_Folders.SelectedItem, tss_Feedback})
    End Sub

    Private Sub ofd_SelectAudio_FileOk(sender As Object, e As CancelEventArgs) Handles ofd_SelectAudio.FileOk
        txt_FileLocation.Text = ofd_SelectAudio.SafeFileName
    End Sub

    Private Sub frm_EmailListeners_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            cbx_Folders.DataSource = uploader.getFolders()
        Catch ex As NullReferenceException
            If cbx_Folders Is Nothing Then
                MessageBox.Show("Combo Box was null.")
            ElseIf uploader Is Nothing Then
                MessageBox.Show("Drive uploader was null.")
            End If
        End Try
    End Sub

    Private Sub btn_Browse_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
        ofd_SelectAudio.ShowDialog()
    End Sub
    Private Sub bw_Upload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_Upload.DoWork
        If Not String.IsNullOrEmpty(txt_FileLocation.Text) Then
            Dim tss As ToolStripStatusLabel = CType(CType(e.Argument, Object())(1), ToolStripStatusLabel)
            Dim folderName As String = CType(CType(e.Argument, Object())(0), String)

            fileID = uploader.upload(ofd_SelectAudio.FileName, folderName, tss)
            tss_Feedback.Text = "Please select the file to be uploaded and the folder to upload to or Send the last one to your listeners"
        Else
            tss_Feedback.Text = "You have to select a file first..."
        End If
    End Sub

    Private Sub btn_AddFolder_Click(sender As Object, e As EventArgs) Handles btn_AddFolder.Click
        Dim frm_Folder As Folder = New Folder(uploader)
        frm_Folder.Show()

        Do Until My.Settings.AdminInfoRecieved
            wait(1)
        Loop

        cbx_Folders.DataSource = uploader.getFolders()

        My.Settings.AdminInfoRecieved = False
        My.Settings.Save()
    End Sub

    Private Sub wait(ByVal seconds As Integer)
        'found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub frm_EmailListeners_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not frm_main.IsDisposed Then
            frm_main.Show()
        End If
    End Sub

    Private Sub frm_EmailListeners_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        If frm_main.IsDisposed Then
            Close()
        End If
    End Sub

    Private Sub btn_SendEmails_Click(sender As Object, e As EventArgs) Handles btn_SendEmails.Click
        If fileID IsNot Nothing Then
            tss_Feedback.Text = "Sending emails to listeners..."
            Dim sending As Process = Process.Start(emailer, String.Format("{0} {1} {2}", My.Settings.Username, My.Settings.Password, String.Format(shareLink, fileID)))

            sending.WaitForExit()

            If sending.ExitCode = 0 Then
                txt_FileLocation.Text = ""
                tss_Feedback.Text = "All emails sent successfully..."
            End If
        Else
            tss_Feedback.Text = "You have to upload something first..."
        End If
    End Sub

    Private Sub btn_ViewListeners_Click(sender As Object, e As EventArgs) Handles btn_ViewListeners.Click
        Dim frm_ViewListeners As ViewListeners = New ViewListeners(New Database(My.Settings.Username, My.Settings.Password))
        frm_ViewListeners.emails = Me
        frm_ViewListeners.Show()
        Me.Hide()
    End Sub

    Private Sub frm_EmailListeners_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        'found how to add this here: https://stackoverflow.com/questions/11686631/drag-drop-and-get-file-path-in-vb-net
        If e.Data.GetDataPresent("FileDrop", True) Then
            ofd_SelectAudio.FileName = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)
            ofd_SelectAudio_FileOk(sender, New CancelEventArgs)
            'txt_FileLocation.Text = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)
        End If
    End Sub

    Private Sub frm_EmailListeners_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        'found how to add this here: https://stackoverflow.com/questions/11686631/drag-drop-and-get-file-path-in-vb-net
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub rdo_EmailMinistry_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_EmailMinistry.CheckedChanged
        If rdo_EmailMinistry.Checked Then
            normal()
        End If
    End Sub

    Private Sub rdo_GoingLive_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_GoingLive.CheckedChanged
        If rdo_GoingLive.Checked Then
            goLive()
        End If
    End Sub

    Sub normal()
        Me.Size = MinisSizes.form
    End Sub

    Sub goLive()
        Me.Size = LiveSizes.form
    End Sub
End Class