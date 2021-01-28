Imports System.ComponentModel
Imports System.Threading
Public Class Frm_CustomMessage
    'TODO: Add functionality to select wheter to send this to all listeners or specific listeners
    'TODO: Convert this to a DialogBox
    Private Sub Btn_Send_Click(sender As Object, e As EventArgs) Handles btn_Send.Click
        If FileSelectionDialog.ShowDialog() = DialogResult.OK Then
            If ListenerSelectionDialog.ShowDialog() = DialogResult.OK Then
                SendEmail()
            End If
        End If
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub SendEmail()
        Console.WriteLine(FileSelectionDialog.FileName)
        Console.WriteLine(FileSelectionDialog.FileID)
        For Each item In FileSelectionDialog.Parents
            Console.WriteLine(item)
        Next
        For Each listener In ListenerSelectionDialog.Listeners
            Console.WriteLine(listener.Name)
            Console.WriteLine(listener.EmailAddress.Address)
        Next
        'Using emailer As New Sender
        '    emailer.Create(New MimeKit.MailboxAddress("Andrew Randle", "arandlemiller97@yahoo.com"), txt_MessageSubject.Text, rtb_MessageBody.Rtf)
        'End Using
    End Sub
End Class