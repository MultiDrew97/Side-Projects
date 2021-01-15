Option Strict On

Imports MediaMinistry.SendingEmails

Public Class frm_Folder
    Private Sub btn_CreateFolder_Click(sender As Object, e As EventArgs) Handles btn_CreateFolder.Click
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

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        My.Settings.AdminInfoRecieved = True
        Me.Close()
    End Sub

    Private Sub ReloadFolders()
        For Each form As Form In My.Application.OpenForms
            If form.Name.Equals("Frm_EmailListeners", StringComparison.OrdinalIgnoreCase) Then
                CType(form, Frm_EmailListeners).LoadFolders()
                Exit For
            End If
        Next
    End Sub
End Class
