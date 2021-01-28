Imports System.ComponentModel
Imports MediaMinistry.Types
Imports MediaMinistry.Helpers
Imports MimeKit
Imports System.Collections.ObjectModel

Public Class Frm_SendEmails
    Private ReadOnly shareLink As String = "https://drive.google.com/file/d/{0}/view?usp=sharing"
    Private fileID As String = Nothing
    Private listeners As Collection(Of Listener)
    Private closable As Boolean = False

    Private Sub Frm_EmailListeners_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadFolders()
    End Sub

    Private Sub Btn_UploadFile_Click(sender As Object, e As EventArgs) Handles btn_UploadFile.Click
        If DriveUploadDialog.ShowDialog = DialogResult.OK Then
            LoadFiles()
        End If
    End Sub

    Private Sub Cbx_Folders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Folders.SelectedIndexChanged
        LoadFiles()
    End Sub

    Private Sub Btn_SendEmails_Click(sender As Object, e As EventArgs) Handles btn_SendEmails.Click
        bw_GetFileID.RunWorkerAsync()
        bw_LoadListeners.RunWorkerAsync()
    End Sub

    Private Sub Bw_LoadListeners_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_LoadListeners.DoWork
        Using db As New Database()
            listeners = db.GetListeners()
        End Using
    End Sub

    Private Sub Bw_LoadListeners_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_LoadListeners.RunWorkerCompleted
        bw_SendEmails.RunWorkerAsync()
    End Sub

    Private Sub Bw_SendEmails_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_SendEmails.DoWork
        Dim subject = "", body As String
        Dim content As MimeMessage

        If chk_DefaultMessage.Checked Then
            'set subject to default one
            subject = "Sunday Morning Message"
        Else
            'open custom message form then set subject and body to custom message
            If CustomMessageDialog.ShowDialog() = DialogResult.OK Then
                subject = CustomMessageDialog.Subject
            Else
                e.Cancel = True
            End If

            'While Not My.Settings.AdminInfoRecieved
            '    Utils.Wait(1)
            'End While
        End If

        If Not bw_SendEmails.CancellationPending Then
            Using emailer As New GoogleAPI.Sender()
                'content = emailer.Create(New MailboxAddress("Andrew Randle-Warren", "arandlemiller97@yahoo.com"), "Test Email", "Test Email")
                'emailer.Send(content)
                For Each listener As Listener In listeners
                    If chk_DefaultMessage.Checked Then
                        'String.Format(shareLink, fileID)
                        body = String.Format(My.Resources.newSermon, listener.Name, String.Format(shareLink, fileID))
                    Else
                        body = String.Format(My.Resources.customMessageTemplate, listener.Name, CustomMessageDialog.Body)
                    End If

                    If listener.EmailAddress.Address.Equals("arandlemiller97@yahoo.com") Then
                        content = emailer.Create(listener.EmailAddress, subject, body)
                        emailer.Send(content)
                    End If
                Next
            End Using
        End If
    End Sub

    Private Sub Frm_SendEmails_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If bw_SendEmails.IsBusy Or bw_LoadListeners.IsBusy Then
            Console.WriteLine("Background Worker still running")
            e.Cancel = True
            Me.Hide()
            closable = True
        End If
    End Sub

    Private Sub Bw_SendEmails_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_SendEmails.RunWorkerCompleted
        MessageBox.Show("All emails have been sent.", "Email Ministry", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If closable Then
            Me.Close()
        End If
    End Sub

    Private Sub Bw_GetFileID_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_GetFileID.DoWork
        'Invoke(
        'Sub()
        Using uploader As New GoogleAPI.DriveUploader()
            fileID = uploader.FindFile(CType(cbx_Files.SelectedItem, String))
        End Using
        'End Sub
        ')
    End Sub

    Sub LoadFolders()
        Using uploader As New GoogleAPI.DriveUploader()
            cbx_Folders.DataSource = uploader.GetFolders()
        End Using
    End Sub

    Private Sub LoadFiles()
        Using uploader As New GoogleAPI.DriveUploader
            cbx_Files.DataSource = uploader.GetFiles(CType(cbx_Folders.SelectedValue, String))
        End Using
    End Sub

    Private Sub Btn_AddFolder_Click(sender As Object, e As EventArgs) Handles btn_AddFolder.Click
        If FolderCreationDialog.ShowDialog = DialogResult.OK Then
            If MessageBox.Show("Would you like to upload a file to this new folder?", "Upload New File?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If DriveUploadDialog.ShowDialog = DialogResult.OK Then
                    LoadFiles()
                End If
            Else
                LoadFolders()
            End If
        End If
    End Sub
End Class