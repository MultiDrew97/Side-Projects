Imports System.Threading
Imports MediaMinistry.GoogleAPI

'TODO: Convert to Dialog Box

Public Class Frm_CustomMessage

    Dim fileSelector As FileSelectionDialog
    Dim listenerSelector As ListenerSelectionDialog
    'TODO: Add functionality to select wheter to send this to all listeners or specific listeners
    Private Sub Btn_Send_Click(sender As Object, e As EventArgs) Handles btn_Send.Click
        If fileSelector.ShowDialog() = DialogResult.OK Then
            If listenerSelector.ShowDialog() = DialogResult.OK Then
                SendEmail()
            End If
        End If
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub SendEmail()
        Using emailer As New Sender
            For Each listener In listenerSelector.Listeners
                emailer.Send(emailer.Create(New MimeKit.MailboxAddress(listener.Name, listener.Email), txt_MessageSubject.Text, rtb_MessageBody.Rtf))
            Next
        End Using
    End Sub

    Private Sub Frm_CustomMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fileSelector = New FileSelectionDialog()
        listenerSelector = New ListenerSelectionDialog()
    End Sub
End Class