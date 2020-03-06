Option Strict On

Imports System.ComponentModel
Imports Media_Ministry.SendingEmails

Public Class frm_EmailListeners
    Dim uploader As DriveUploader
    'Dim emailer As EmailSender
    Dim frm_main As frm_Main
    ReadOnly shareLink As String = "https://drive.google.com/file/d/{0}/view?usp=sharing"

    Sub New(ByRef frm_main As frm_Main, ByRef uploader As DriveUploader) ', ByRef emailer As EmailSender)
        InitializeComponent()

        Me.frm_main = frm_main
        Me.uploader = uploader
        'Me.emailer = emailer
        Me.Show()
    End Sub

    Private Sub btn_Upload_Click(sender As Object, e As EventArgs) Handles btn_Upload.Click
        Dim arguments As Object() = {cbx_Folders.SelectedItem, tss_Feedback}
        tss_Feedback.ForeColor = Color.Black
        bw_Upload.RunWorkerAsync(arguments)
    End Sub

    Private Sub ofd_SelectAudio_FileOk(sender As Object, e As CancelEventArgs) Handles ofd_SelectAudio.FileOk
        txt_FileLocation.Text = ofd_SelectAudio.SafeFileName
    End Sub

    Private Sub frm_EmailListeners_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbx_Folders.DataSource = uploader.getFolders()
    End Sub

    Private Sub btn_Browse_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
        ofd_SelectAudio.ShowDialog()
    End Sub
    Private Sub bw_Upload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_Upload.DoWork
        'uploader.setPermissions(New Database("arandlemiller97", "AMrw2697").RetrieveListeners(), uploader.findFile("test.txt"))
        Dim tss As ToolStripStatusLabel = CType(CType(e.Argument, Object())(1), ToolStripStatusLabel)
        Dim folderName As String = CType(CType(e.Argument, Object())(0), String)

        Dim link As String = String.Format(shareLink, uploader.upload(ofd_SelectAudio.FileName, folderName, tss))
        Dim emailer As String = Application.StartupPath & "\Resources\sender.jar"
        'Get the listeners from the database and send out the share link
        Dim sending As Process = Process.Start(emailer, String.Format("{0} {1} {2}", My.Settings.Username, My.Settings.Password, link))

        sending.WaitForExit()

        Console.WriteLine(sending.ExitCode)
    End Sub

    Private Sub btn_AddFolder_Click(sender As Object, e As EventArgs) Handles btn_AddFolder.Click
        Dim frm_Folder As frm_Folder = New frm_Folder(uploader)
        frm_Folder.Show()

        Do Until My.Settings.AdminInfoRecieved
            Console.WriteLine("Waiting for admin information")
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

    Private Sub bw_Upload_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_Upload.RunWorkerCompleted
        tss_Feedback.Text = "Please select the file to be uploaded and the folder to upload to"
        txt_FileLocation.Text = ""
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
End Class