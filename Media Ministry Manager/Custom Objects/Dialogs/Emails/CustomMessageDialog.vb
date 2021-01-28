Option Strict On

Public Class CustomMessageDialog
    Public Property Subject As String
    Public Property Body As String
    Private Sub Btn_Send_Click(sender As Object, e As EventArgs) Handles btn_UseMessage.Click
        Subject = txt_MessageSubject.Text
        Body = rtb_MessageBody.Text
        DialogResult = DialogResult.OK
        Me.Close()

        'If ChooseFile() = DialogResult.OK Then
        '    Dim result As DialogResult = ChooseListeners()
        '    If result = DialogResult.OK Then

        '    ElseIf result = DialogResult.Cancel Or result = DialogResult.No Then
        '        MessageBox.Show("Email messages will not be sent.", "Emailing Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        DialogResult = result
        '        Me.Close()
        '    End If
        'End If
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    'Private Sub SendEmails()
    '    Console.WriteLine(FileSelectionDialog.FileName)
    '    Console.WriteLine(FileSelectionDialog.FileID)
    '    For Each item In FileSelectionDialog.Parents
    '        Console.WriteLine(item)
    '    Next
    '    For Each listener In ListenerSelectionDialog.Listeners
    '        Console.WriteLine(listener.Name)
    '        Console.WriteLine(listener.EmailAddress.Address)
    '    Next
    '    'Using emailer As New Sender
    '    '    emailer.Create(New MimeKit.MailboxAddress("Andrew Randle", "arandlemiller97@yahoo.com"), txt_MessageSubject.Text, rtb_MessageBody.Rtf)
    '    'End Using

    '    DialogResult = DialogResult.OK
    '    Me.Close()
    'End Sub

    'Private Function ChooseFile() As DialogResult
    '    Return FileSelectionDialog.ShowDialog()
    'End Function

    'Private Function ChooseListeners() As DialogResult
    '    Dim result As DialogResult

    '    Do Until (result = DialogResult.OK) Or (result = DialogResult.No) Or (result = DialogResult.Cancel)
    '        result = ListenerSelectionDialog.ShowDialog()
    '        If result = DialogResult.Retry Then
    '            result = MessageBox.Show("Would you like to select a listener?", "No Listeners Selected", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '        End If
    '    Loop

    '    Return result
    'End Function
End Class