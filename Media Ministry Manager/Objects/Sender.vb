Option Strict On

Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Gmail.v1
Imports Google.Apis.Gmail.v1.Data
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports MimeKit
Imports NeoSmart.Utils
Imports NPOI.Util
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks


Namespace SendingEmails
    Public Class Sender
        Implements IDisposable
        Private ReadOnly Scopes As String() = {GmailService.Scope.GmailSend}
        Private ReadOnly ApplicationName As String = "Gmail API .NET Quickstart"
        Private Property Credential As UserCredential
        Private Property Service As GmailService

        ReadOnly Property Info As Profile
            Get
                Return Service.Users.GetProfile("me").Execute()
            End Get
        End Property

        Sub New(Optional ct As CancellationToken = Nothing)
            Dim credPath As String = "Gmail Token"
            Using stream As New MemoryStream(My.Resources.credentials)
                Credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, Scopes, "user", CType(IIf(IsNothing(ct), CancellationToken.None, ct), CancellationToken), New FileDataStore(credPath, True)).Result
                Console.WriteLine("Credential file saved to: " + credPath)
                Service = New GmailService(New BaseClientService.Initializer() With {.HttpClientInitializer = Credential, .ApplicationName = ApplicationName})
            End Using
        End Sub

        Sub Dispose() Implements IDisposable.Dispose

        End Sub

        Function Create([to] As MailboxAddress, subject As String, body As String, Optional from As String = "me") As MimeMessage
            Dim email As New MimeMessage() With {
                .Sender = New MailboxAddress(from, from),
                .Subject = subject,
                .Body = New TextPart("html") With {
                    .Text = body
                }
            }

            email.To.Add([to])

            Return email
        End Function

        Function CreateWithEmail(emailContent As MimeMessage) As Message
            Dim buffer As ByteArrayOutputStream = New ByteArrayOutputStream()
            emailContent.WriteTo(buffer)
            Dim bytes As Byte() = buffer.ToByteArray()
            Dim encodedEmail As String = UrlBase64.Encode(bytes)
            Dim message As New Message With {
                .Raw = encodedEmail
            }

            Return message
        End Function

        Function CreateWithAttachment([to] As MailboxAddress, subject As String, body As String, files As String(), Optional from As String = "me") As MimeMessage
            Dim email As New MimeMessage() With {
                .Sender = New MailboxAddress(from, from),
                .Subject = subject
            }

            email.To.Add([to])

            Dim mimeBodyPart As MimePart = New TextPart("html") With {
                .Text = body
            }

            'mimeBodyPart.setContent(bodyText, "text/plain")

            Dim multipart As New Multipart From {
                mimeBodyPart
            }

            Dim attachments As New AttachmentCollection()

            For Each file In files
                attachments.Add(file)
            Next

            'Dim source As javax.activation.DataSource = New FileDataSource(File)

            'mimeBodyPart.setDataHandler(New DataHandler(source))
            'mimeBodyPart.setFileName(file.getName())

            For Each attachment In attachments
                multipart.Add(attachment)
            Next


            email.Body = multipart

            Return email

        End Function
        Function Send(emailContent As MimeMessage, Optional userId As String = "me") As Message
            Dim message As Message = CreateWithEmail(emailContent)
            message = Service.Users().Messages().Send(message, userId).Execute()

            Console.WriteLine("Message id: " + message.Id)
            Return message
        End Function
    End Class
End Namespace
