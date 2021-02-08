Option Strict On

Public Class CustomMessageDialog
    Public Property Subject As String
    Public Property Body As String

    Private Sub Btn_Send_Click(sender As Object, e As EventArgs) Handles btn_UseMessage.Click
        Subject = txt_MessageSubject.Text
        Body = rtb_MessageBody.Text
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Reset()
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CustomMessageDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub Reset()
        Subject = ""
        Body = ""
    End Sub
End Class