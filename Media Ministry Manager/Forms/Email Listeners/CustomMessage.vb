Imports System.ComponentModel
Imports System.Threading
Imports MediaMinistry.SendingEmails
Public Class frm_CustomMessage

    Dim fileSelector As FileSelectionDialog
    Dim listenerSelector As ListenerSelectionDialog
    'TODO: Add functionality to select wheter to send this to all listeners or specific listeners
    'TODO: Convert this to a DialogBox
    Private Sub Btn_Send_Click(sender As Object, e As EventArgs) Handles btn_Send.Click
        If fileSelector.ShowDialog() = DialogResult.OK Then
            If listenerSelector.ShowDialog() = DialogResult.OK Then
                SendEmail()
            End If
        End If
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click, btn_Send.Click
        Me.Close()
    End Sub

    Private Sub SendEmail()
        Console.WriteLine(fileSelector.FileName)
        Console.WriteLine(fileSelector.FileID)
        For Each item In fileSelector.Parents
            Console.WriteLine(item)
        Next
        For Each listener In listenerSelector.Listeners
            Console.WriteLine(listener.Name)
            Console.WriteLine(listener.EmailAddress.Address)
        Next
        'Using emailer As New Sender(CancellationToken.None)
        '    emailer.Create(New MimeKit.MailboxAddress("Andrew Randle", "arandlemiller97@yahoo.com"), txt_MessageSubject.Text, rtb_MessageBody.Rtf)
        'End Using
    End Sub

    Private Sub Frm_CustomMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fileSelector = New FileSelectionDialog()
        listenerSelector = New ListenerSelectionDialog()
    End Sub
End Class