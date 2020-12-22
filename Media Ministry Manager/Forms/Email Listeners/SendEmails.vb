Imports System.ComponentModel
Imports MediaMinistry.SendingEmails
Imports MediaMinistry.Helpers

Public Class frm_SendEmails
    ReadOnly shareLink As String = "https://drive.google.com/file/d/{0}/view?usp=sharing"
    Private fileID As String = Nothing
    Private Sub Ofd_SelectAudio_FileOk(sender As Object, e As CancelEventArgs)
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
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Private Sub Btn_Browse_Click(sender As Object, e As EventArgs)
        ofd_SelectAudio.ShowDialog()
    End Sub

    Private Sub Btn_AddFolder_Click(sender As Object, e As EventArgs)
        Dim frm_Folder As frm_Folder = New frm_Folder
        frm_Folder.Show()

        Do Until My.Settings.AdminInfoRecieved
            Utils.Wait(1)
        Loop

        Using uploader As New DriveUploader()
            cbx_Folders.DataSource = Uploader.GetFolders()
        End Using

        My.Settings.AdminInfoRecieved = False
        My.Settings.Save()
    End Sub
End Class