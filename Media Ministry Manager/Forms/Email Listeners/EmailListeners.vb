Option Strict On

Imports System.ComponentModel
Imports Media_Ministry.Utils

Public Class frm_EmailListeners
    Public uploader As DriveUploader
    Public frm_main As frm_Main
    ReadOnly shareLink As String = "https://drive.google.com/file/d/{0}/view?usp=sharing"
    Private fileID As String = Nothing
    ReadOnly emailerLocation As String = Application.StartupPath & "\sender.jar"
    Private comm As String
    ReadOnly imageFilter As String = "JPG|*.jpg;*.JPG|PNG|*.png;*.PNG"
    ReadOnly audioFilter As String = "MP3|*.mp3|MP4|*.mp4;*.m4a"
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
        Shared FolderDefault As New Point(389, 18)

        'File text locations
        Shared FileDefault As New Point(389, 114)

        'new folder button locations
        Shared FolderAddDefault As New Point(762, 57)

        'find file button
        Shared BrowseDefault As New Point(762, 114)

        'folder label locations
        Shared FolderLabelDefault As New Point(293, 18)

        'file label locations
        Shared FileLabelUpload As New Point(326, 145)
        Shared FileLabelDefault As New Point(326, 91)
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

    Private Sub btn_Upload_Click(sender As Object, e As EventArgs) Handles btn_Upload.Click
        tss_Feedback.ForeColor = Color.Black
        bw_Upload.RunWorkerAsync({cbx_Folders.SelectedItem, tss_Feedback})
    End Sub

    Private Sub ofd_SelectAudio_FileOk(sender As Object, e As CancelEventArgs) Handles ofd_SelectFile.FileOk
        txt_FileLocation.Text = ofd_SelectFile.SafeFileName
    End Sub

    Private Sub frm_EmailListeners_Load(sender As Object, e As EventArgs) Handles Me.Load
        uploader = New DriveUploader()
        cbx_Folders.DataSource = uploader.getFolders()
    End Sub

    Private Sub btn_Browse_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
        ofd_SelectFile.ShowDialog()
    End Sub

    Private Sub bw_Upload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_Upload.DoWork
        If Not String.IsNullOrEmpty(txt_FileLocation.Text) Then
            btn_CancelUpload.Hide()
            Dim tss As ToolStripStatusLabel = CType(CType(e.Argument, Object())(1), ToolStripStatusLabel)
            Dim folderName As String = CType(CType(e.Argument, Object())(0), String)

            fileID = uploader.upload(ofd_SelectFile.FileName, folderName, tss)
            tss_Feedback.Text = "Please select the file to be uploaded and the folder to upload to or Send the last one to your listeners"
        Else
            tss_Feedback.Text = "You have to select a file first..."
        End If
    End Sub

    Private Sub btn_AddFolder_Click(sender As Object, e As EventArgs) Handles btn_AddFolder.Click
        Dim frm_Folder As frm_Folder = New frm_Folder(uploader)
        frm_Folder.Show()

        Do Until My.Settings.AdminInfoRecieved
            wait(1)
        Loop

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
        tss_Feedback.ForeColor = Color.Black
        tss_Feedback.Text = "Sending emails to listeners..."

        Dim sending As Process = Nothing

        'Select Case comm
        'Case "-s"
        If chk_Attachment.Checked Then
            fileID = uploader.getFileID(cbx_FileList.SelectedItem.ToString, cbx_Folders.SelectedItem.ToString)
            sending = Process.Start("cmd", String.Format("/C java -jar sender.jar {0} {1} {2} {3}", comm, My.Settings.Username, My.Settings.Password, String.Format(shareLink, fileID)))
        Else
            sending = Process.Start("cmd", String.Format("/C java -jar sender.jar {0} {1} {2}", comm, My.Settings.Username, My.Settings.Password))
        End If
        'Case "-r"
        'sending = Process.Start("cmd", String.Format("/C java -jar sender.jar {0} {1} {2}", comm, recipient, ofd_SelectFile.FileName))
        'End Select

        sending.WaitForExit()

        If sending.ExitCode = 0 Then
            txt_FileLocation.Text = ""
            tss_Feedback.Text = "All emails sent successfully..."
        Else
            tss_Feedback.Text = "Something went wrong. Try again and if problem persists, contact your developer..."
            MessageBox.Show("Exit Code: " & sending.ExitCode, "Error")
            tss_Feedback.ForeColor = Color.Red
        End If
        'Else
        'tss_Feedback.Text = "You have to upload something first..."
        'Feedback.ForeColor = Color.Red
        'End If
    End Sub

    Private Sub btn_ViewListeners_Click(sender As Object, e As EventArgs) Handles btn_ViewListeners.Click
        Dim frm_ViewListeners As New frm_ViewListeners() With {.sendingForm = Me}
        frm_ViewListeners.Show()
        Me.Hide()
    End Sub

    Private Sub frm_EmailListeners_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        'found how to add this here: https://stackoverflow.com/questions/11686631/drag-drop-and-get-file-path-in-vb-net
        If e.Data.GetDataPresent("FileDrop", True) Then
            ofd_SelectFile.FileName = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)
            If ofd_SelectFile.CheckFileExists Then
                ofd_SelectAudio_FileOk(sender, New CancelEventArgs)
                'txt_FileLocation.Text = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)
            End If
        End If
    End Sub

    Private Sub frm_EmailListeners_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        'found how to add this here: https://stackoverflow.com/questions/11686631/drag-drop-and-get-file-path-in-vb-net
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    'Private Sub frm_EmailListeners_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
    '    If Me.Size = Sizes.Max Then
    '        MaxChanges()
    '    Else
    '        DefaultChanges()
    '    End If
    'End Sub

    'Private Sub MaxChanges()

    'End Sub

    'Private Sub DefaultChanges()
    '    'Locations
    '    btn_Upload.Location = Locations.UploadDefault
    '    btn_SendEmails.Location = Locations.SendDefault
    '    btn_ViewListeners.Location = Locations.ViewDefault
    '    lbl_Folder.Location = Locations.FolderLabelDefault
    '    cbx_Folders.Location = Locations.FolderDefault
    '    btn_AddFolder.Location = Locations.FolderAddDefault
    '    lbl_FileLocation.Location = Locations.FileLabelDefault
    '    txt_FileLocation.Location = Locations.FileDefault
    '    btn_Browse.Location = Locations.BrowseDefault
    'End Sub

    Private Sub btn_UploadFile_Click(sender As Object, e As EventArgs) Handles btn_UploadFile.Click
        lbl_FileLocation.Location = Locations.FileLabelUpload
        txt_FileLocation.Show()
        btn_Upload.Show()
        btn_Browse.Show()
        btn_CancelUpload.Show()
        chk_Attachment.Hide()
        cbx_FileList.Hide()
        btn_UploadFile.Hide()
    End Sub

    Private Sub rdo_Receipt_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Receipt.CheckedChanged
        If rdo_Receipt.Checked Then
            comm = "-r"
            btn_UploadFile.Hide()
            cbx_FileList.Hide()
            txt_FileLocation.Show()
            btn_Browse.Show()
            chk_Attachment.Hide()
            lbl_FileLocation.Location = Locations.FileLabelUpload
            ofd_SelectFile.Filter = imageFilter
            btn_SendEmails.Text = "Send Receipt"
        End If
    End Sub

    Private Sub rdo_Sermon_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Sermon.CheckedChanged
        If rdo_Sermon.Checked Then
            comm = "-s"
            cbx_FileList.Show()
            btn_UploadFile.Show()
            txt_FileLocation.Hide()
            btn_Browse.Hide()
            chk_Attachment.Show()
            lbl_FileLocation.Location = Locations.FileLabelDefault
            ofd_SelectFile.Filter = audioFilter
        End If
    End Sub

    Private Sub cbx_Folders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Folders.SelectedIndexChanged
        If cbx_FileList.Visible Then
            cbx_FileList.DataSource = Nothing
            loadFiles()
        End If
    End Sub

    Private Sub bw_Upload_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_Upload.RunWorkerCompleted
        cbx_FileList.Show()
        btn_UploadFile.Show()
        chk_Attachment.Show()
        lbl_FileLocation.Location = Locations.FileLabelDefault
        loadFiles()
        txt_FileLocation.Hide()
        btn_Browse.Hide()
        btn_Upload.Hide()
    End Sub

    Private Sub loadFiles()
        cbx_FileList.DataSource = uploader.loadFiles(cbx_Folders.SelectedItem.ToString()).ToArray()
    End Sub

    Private Sub loadFolders()
        cbx_Folders.DataSource = uploader.getFolders()
    End Sub

    'Private Sub chk_Attachment_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Attachment.CheckedChanged
    '    If chk_Attachment.Checked Then
    '        loadFolders()
    '    End If
    'End Sub

    Private Sub btn_CancelUpload_Click(sender As Object, e As EventArgs) Handles btn_CancelUpload.Click
        btn_CancelUpload.Hide()
        cbx_FileList.Show()
        btn_UploadFile.Show()
        chk_Attachment.Show()
        lbl_FileLocation.Location = Locations.FileLabelDefault
        txt_FileLocation.Hide()
        btn_Browse.Hide()
        btn_Upload.Hide()
    End Sub
End Class
