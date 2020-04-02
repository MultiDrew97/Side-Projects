Option Strict On

Imports Media_Ministry.SendingEmails
Public Class Folder
    Dim uploader As DriveUploader
    Public Sub New(uploader As DriveUploader)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.uploader = uploader
    End Sub
    Private Sub btn_CreateFolder_Click(sender As Object, e As EventArgs) Handles btn_CreateFolder.Click
        Dim temp As String = uploader.createFolder(txt_FolderName.Text)

        If temp IsNot Nothing Then
            My.Settings.AdminInfoRecieved = True
            Me.Close()
        Else
            tss_Feedback.Text = "Failed to create folder. Try Again."
            tss_Feedback.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        My.Settings.AdminInfoRecieved = True
        Me.Close()
    End Sub
End Class