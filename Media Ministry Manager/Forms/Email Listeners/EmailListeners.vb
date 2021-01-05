Option Strict On

Imports System.ComponentModel
Imports MediaMinistry.SendingEmails
Imports MediaMinistry.Helpers

Public Class Frm_EmailListeners
    ReadOnly shareLink As String = "https://drive.google.com/file/d/{0}/view?usp=sharing"
    Private fileID As String = Nothing
    ReadOnly emailerLocation As String = Application.StartupPath & "\sender.jar"

    Structure Sizes

        'Window Sizes
        Shared [Default] As New Size(842, 240)

        Shared Max As New Size(1382, 744)
    End Structure

    Structure Locations

        'upload button locations
        Shared UploadDefault As New Point(20, 13)

        'Send button locations
        Shared SendDefault As New Point(20, 71)

        'View button Locations
        Shared ViewDefault As New Point(20, 129)

        'Folder combo locations
        Shared FolderDefault As New Point(389, 55)

        'File text locations
        Shared FileDefault As New Point(389, 114)

        'new folder button locations
        Shared FolderAddDefault As New Point(762, 57)

        'find file button
        Shared BrowseDefault As New Point(762, 114)

        'folder label locations
        Shared FolderLabelDefault As New Point(293, 55)

        'file label locations
        Shared FileLabelDefault As New Point(314, 114)

    End Structure

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

    Private Sub Btn_Upload_Click(sender As Object, e As EventArgs)
        tss_Feedback.ForeColor = Color.Black
        bw_Upload.RunWorkerAsync({cbx_Folders.SelectedItem, tss_Feedback})
    End Sub

    Private Sub Ofd_SelectAudio_FileOk(sender As Object, e As CancelEventArgs) Handles ofd_SelectAudio.FileOk
        txt_FileLocation.Text = ofd_SelectAudio.SafeFileName
    End Sub

    Private Sub Frm_EmailListeners_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Using uploader As New DriveUploader()
                cbx_Folders.DataSource = uploader.GetFolders()
            End Using
        Catch ex As NullReferenceException
            If cbx_Folders Is Nothing Then
                MessageBox.Show("Combo Box was null.")
            End If
        End Try
    End Sub

    Private Sub Btn_Browse_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click

    End Sub

    Private Sub Bw_Upload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_Upload.DoWork
        If Not String.IsNullOrEmpty(txt_FileLocation.Text) Then
            Dim tss As ToolStripStatusLabel = CType(CType(e.Argument, Object())(1), ToolStripStatusLabel)
            Dim folderName As String = CType(CType(e.Argument, Object())(0), String)
            Using uploader As New DriveUploader()
                fileID = uploader.Upload(ofd_SelectAudio.FileName, folderName, tss)
            End Using
            tss_Feedback.Text = "Please select the file to be uploaded and the folder to upload to or Send the last one to your listeners"
        Else
            tss_Feedback.Text = "You have to select a file first..."
        End If
    End Sub

    Private Sub Btn_AddFolder_Click(sender As Object, e As EventArgs) Handles btn_AddFolder.Click
        Dim frm_Folder As frm_Folder = New frm_Folder()
        frm_Folder.Show()

        Do Until My.Settings.AdminInfoRecieved
            Utils.Wait(1)
        Loop

        My.Settings.AdminInfoRecieved = False
        My.Settings.Save()
    End Sub

    Private Sub Frm_EmailListeners_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim main As New frm_Main()
        main.Show()
    End Sub

    Private Sub Frm_EmailListeners_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        If frm_Main.IsDisposed Then
            Close()
        End If
    End Sub

    Private Sub Btn_SendEmails_Click(sender As Object, e As EventArgs) Handles btn_SendEmails.Click
        tss_Feedback.ForeColor = Color.Black
        'If fileID IsNot Nothing Then
        '    tss_Feedback.Text = "Sending emails to listeners..."
        '    Dim sending As Process = Process.Start(emailerLocation, String.Format("{0} {1} {2}", My.Settings.Username, My.Settings.Password, String.Format(shareLink, fileID)))

        '    sending.WaitForExit()

        '    If sending.ExitCode = 0 Then
        '        txt_FileLocation.Text = ""
        '        tss_Feedback.Text = "All emails sent successfully..."
        '    Else
        '        tss_Feedback.Text = "Something went wrong. Try again and if problem persists, contact you developer..."
        '        tss_Feedback.ForeColor = Color.Red
        '    End If
        'Else
        '    tss_Feedback.Text = "You have to upload something first..."
        '    tss_Feedback.ForeColor = Color.Red
        'End If

        'TODO: Move this into a background worker to not freeze the app while sending

        Dim listeners As ObjectModel.Collection(Of Listener)
        If cbx_Files.SelectedItem IsNot Nothing Then
            Using uploader As New DriveUploader()
                fileID = uploader.getFileID(CType(cbx_Files.SelectedItem, String))
            End Using
            If fileID IsNot Nothing Then
                Using db As New Database(My.Settings.Username, My.Settings.Password)
                    listeners = db.RetrieveListeners()
                    Using emailer As New Sender()
                        tss_Feedback.Text = "Sending Emails..."
                        For Each listener As Listener In listeners
                            emailer.Send(emailer.Create(MimeKit.MailboxAddress.Parse(listener.Email), "Sunday Morning Message", String.Format(My.Resources.newSermon, listener.Name, String.Format(shareLink, fileID))))
                        Next
                    End Using
                    tss_Feedback.Text = "All emails have been sent"
                End Using
            End If
        End If
    End Sub

    Private Sub Btn_ViewListeners_Click(sender As Object, e As EventArgs) Handles btn_ViewListeners.Click
        Dim frm_ViewListeners As frm_ViewListeners = New frm_ViewListeners With {.sendingForm = Me}
        frm_ViewListeners.Show()
        Me.Hide()
    End Sub

    Private Sub Frm_EmailListeners_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        'found how to add this here: https://stackoverflow.com/questions/11686631/drag-drop-and-get-file-path-in-vb-net
        If e.Data.GetDataPresent("FileDrop", True) Then
            ofd_SelectAudio.FileName = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)
            If ofd_SelectAudio.CheckFileExists Then
                Ofd_SelectAudio_FileOk(sender, New CancelEventArgs)
                'txt_FileLocation.Text = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)
            End If
        End If
    End Sub

    Private Sub Frm_EmailListeners_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        'found how to add this here: https://stackoverflow.com/questions/11686631/drag-drop-and-get-file-path-in-vb-net
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Frm_EmailListeners_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.Size = Sizes.Max Then
            MaxChanges()
        Else
            DefaultChanges()
        End If
    End Sub

    Private Sub MaxChanges()

    End Sub

    Private Sub DefaultChanges()
        'Locations
        'btn_Upload.Location = Locations.UploadDefault
        btn_SendEmails.Location = Locations.SendDefault
        btn_ViewListeners.Location = Locations.ViewDefault
        lbl_Folder.Location = Locations.FolderLabelDefault
        cbx_Folders.Location = Locations.FolderDefault
        btn_AddFolder.Location = Locations.FolderAddDefault
        lbl_FileLocation.Location = Locations.FileLabelDefault
        txt_FileLocation.Location = Locations.FileDefault
        btn_Browse.Location = Locations.BrowseDefault

    End Sub

    Sub LoadFolders()
        Using uploader As New DriveUploader()
            cbx_Folders.DataSource = uploader.GetFolders()
        End Using
    End Sub

    Private Sub cbx_Folders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Folders.SelectedIndexChanged
        Using uploader As New DriveUploader
            cbx_Files.DataSource = uploader.getFiles(uploader.GetFolderID(CType(cbx_Folders.SelectedItem, String)))
        End Using
    End Sub
End Class
