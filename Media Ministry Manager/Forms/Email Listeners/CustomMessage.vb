Imports System.Threading
Imports MediaMinistry.SendingEmails
Public Class frm_CustomMessage

    'TODO: Add functionality to select wheter to send this to all listeners or specific listeners
    Private Sub Btn_Send_Click(sender As Object, e As EventArgs) Handles btn_Send.Click
        SendEmail()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub SendEmail()
        Using emailer As New Sender(CancellationToken.None)
            emailer.Create(New MimeKit.MailboxAddress("Andrew Randle", "arandlemiller97@yahoo.com"), txt_MessageSubject.Text, rtb_MessageBody.Rtf)
        End Using
    End Sub
End Class