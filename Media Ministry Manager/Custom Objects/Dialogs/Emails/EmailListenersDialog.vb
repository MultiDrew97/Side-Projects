Option Strict On

Public Class EmailListenersDialog
    ReadOnly shareLink As String = "https://drive.google.com/file/d/{0}/view?usp=sharing"
    Private fileID As String = Nothing
    Shared Property SelectedItem As String

    Private Sub Btn_Upload_Click(sender As Object, e As EventArgs) Handles btn_Upload.Click
        'Dim upload As New Frm_Upload
        'upload.Show()
        SelectedItem = "Upload"
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    'Private Sub Frm_EmailListeners_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    '    Dim main As New frm_Main()
    '    main.Show()
    'End Sub

    Private Sub Btn_SendEmails_Click(sender As Object, e As EventArgs) Handles btn_SendEmails.Click
        'Dim send As New frm_SendEmails()
        'send.Show()
        SelectedItem = "Send"
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Btn_ViewListeners_Click(sender As Object, e As EventArgs) Handles btn_ViewListeners.Click
        'Dim listeners As New Frm_ViewListeners
        'listeners.Show()
        SelectedItem = "View"
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub EmailListenersDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelectedItem = ""
    End Sub
End Class
