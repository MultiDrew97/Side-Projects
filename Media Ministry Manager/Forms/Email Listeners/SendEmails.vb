Imports System.ComponentModel
Imports MediaMinistry.GoogleAPI
Imports MediaMinistry.Types
Imports MediaMinistry.Helpers
Imports MimeKit
Imports System.Collections.ObjectModel

Public Class frm_SendEmails
    Private ReadOnly shareLink As String = "https://drive.google.com/file/d/{0}/view?usp=sharing"
    Private fileID As String = Nothing
    Private listeners As Collection(Of Listener)
    Private closable As Boolean = False

    Private Sub Frm_EmailListeners_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadFolders()
    End Sub

    Private Sub Btn_AddFolder_Click(sender As Object, e As EventArgs)
        Dim frm_Folder As frm_Folder = New frm_Folder
        frm_Folder.Show()

        Do Until My.Settings.AdminInfoRecieved
            Utils.Wait(1)
        Loop

        Using uploader As New DriveUploader()
            cbx_Folders.DataSource = uploader.GetFolders()
        End Using

        My.Settings.AdminInfoRecieved = False
    End Sub

    Private Sub Btn_UploadFile_Click(sender As Object, e As EventArgs) Handles btn_UploadFile.Click
        Dim form As New Frm_Upload()
        form.Show()
    End Sub

    Private Sub Cbx_Folders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Folders.SelectedIndexChanged
        Using uploader As New DriveUploader
            cbx_Files.DataSource = uploader.GetFiles(CType(cbx_Folders.SelectedValue, String))
        End Using
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
        Dim subject, body As String
        Dim content As MimeMessage



        If chk_DefaultMessage.Checked Then
            'set subject to default one
            subject = "Sunday Morning Message"
        Else
            'open custom message form then set subject and body to custom message
            Dim custom As New Frm_CustomMessage()
            custom.Show()

            While Not My.Settings.AdminInfoRecieved
                Utils.Wait(1)
            End While

            'TODO: Cancel running the background worker here if dialog box was cancelled out of

            subject = My.Settings.customMessageSubject

            My.Settings.AdminInfoRecieved = False
        End If

        If Not bw_SendEmails.CancellationPending Then
            Using emailer As New Sender()
                'content = emailer.Create(New MailboxAddress("Andrew Randle-Warren", "arandlemiller97@yahoo.com"), "Test Email", "Test Email")
                'emailer.Send(content)
                For Each listener As Listener In listeners
                    If chk_DefaultMessage.Checked Then
                        'String.Format(shareLink, fileID)
                        body = String.Format(My.Resources.newSermon, listener.Name, "https://www.google.com")
                    Else
                        body = String.Format(My.Settings.customMessageBody, listener.Name)
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
        If closable Then
            MessageBox.Show("All emails have been sent.", "Email Ministry", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub Bw_GetFileID_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_GetFileID.DoWork
        Invoke(
            Sub()
                Using uploader As New DriveUploader()
                    fileID = uploader.FindFile(CType(cbx_Files.SelectedItem, String))
                End Using
            End Sub
        )
    End Sub

    Sub LoadFolders()
        Using uploader As New DriveUploader()
            cbx_Folders.DataSource = uploader.GetFolders()
        End Using
    End Sub
End Class