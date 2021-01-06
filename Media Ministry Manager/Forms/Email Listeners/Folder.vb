Option Strict On

Imports System.ComponentModel
Imports MediaMinistry.GoogleAPI

Public Class frm_Folder
    Private Sub Btn_CreateFolder_Click(sender As Object, e As EventArgs) Handles btn_CreateFolder.Click
        Using uploader As New DriveUploader()
            If uploader.CreateFolder(txt_FolderName.Text) IsNot Nothing Then
                ReloadFolders()
                Me.Close()
            Else
                tss_Feedback.Text = "Failed to create folder. Try Again."
                tss_Feedback.ForeColor = Color.Red
            End If
        End Using
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Frm_Folder_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.AdminInfoRecieved = True
    End Sub

    Private Sub ReloadFolders()
        For Each form As Form In My.Application.OpenForms
            If form.Name.Equals("frm_sendemails", StringComparison.OrdinalIgnoreCase) Then
                CType(form, frm_SendEmails).LoadFolders()
                Exit For
            End If
        Next
    End Sub
End Class
