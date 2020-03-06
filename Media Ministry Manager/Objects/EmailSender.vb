Option Strict On

Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Gmail.v1
Imports Google.Apis.Gmail.v1.Data
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports Java.Util
Imports MimeKit
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Namespace SendingEmails
    Public Class EmailSender
        Private Scopes As String() = {GmailService.Scope.GmailSend}
        Private ApplicationName As String = "Email Sender"
        Private Property service() As GmailService


        'Public Sub New(location As String)

        '    Dim credential As UserCredential

        '    Using fin As New FileStream(location & "\credentials.json", FileMode.Open, FileAccess.Read)

        '        'The file token.json stores the user's access and refresh tokens, and is created
        '        'automatically when the authorization flow completes for the first time.
        '        Dim credPath = "token.json"
        '        credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
        '                    GoogleClientSecrets.Load(fin).Secrets,
        '                    Scopes,
        '                    "user",
        '                    CancellationToken.None,
        '                    New FileDataStore(credPath, True)).Result
        '        Console.WriteLine("Credential file saved to: " + credPath)
        '    End Using

        '    'Create Gmail API service.
        '    Dim initializer = New BaseClientService.Initializer()
        '    initializer.HttpClientInitializer = credential
        '    initializer.ApplicationName = ApplicationName

        '    service = New GmailService(initializer)
        'End Sub

        'Public Sub send(ByVal recipient As String, ByVal from As String, ByVal subject As String, ByVal body As String)
        '    Console.WriteLine(String.Format("Sent Email:\n\tTo: %s\n\tFrom: %s\n\tSubject: %s\n\tMessage: %s", recipient, from, subject, body))
        'End Sub

        'Public Function createEmail(ByVal recipient As Listener, ByVal from As String, ByVal subject As String, ByVal bodyText As String) As Message
        '    'Dim props = New Properties()
        '    'Dim sessionInt As Session = Session.getDefaultInstance(props, Nothing)

        '    'Dim temp As Message = New Data.Draft() With {
        '    '    .Message = New Message With {
        '    '    .}}

        '    'Dim temp2 As MailKit.BodyBuilder = New BodyBuilder() With {
        '    '    .TextBody}


        '    'Dim 

        '    'Dim email As MimeMessage = New MimeMessage() With {
        '    '    .Sender = New MailboxAddress(from),
        '    '    .Subject = subject
        '    '}
        '    'email.To.Add(InternetAddress.Parse(recipient.email))
        '    ''email.Body.


        '    'Return email
        'End Function

        'Public Function createMessageWithEmail(emailContent As MimeMessage) As MessagePart
        '    'Dim buffer As BufferedStream = New BufferedStream()
        '    'emailContent.WriteTo(buffer)

        '    'Dim bytes As Byte() = buffer
        'End Function
    End Class
End Namespace
