Option Strict On

Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Gmail.v1
Imports Google.Apis.Gmail.v1.Data
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports javax.activation
Imports MimeKit
Imports NeoSmart.Utils
Imports NPOI.POIFS.NIO
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
        Private Scopes As String() = {GmailService.Scope.GmailSend}
        Private ReadOnly ApplicationName As String = "Gmail API .NET Quickstart"
        Private Property credential As UserCredential
        Private Property Service As GmailService

        Sub New()
            Dim credPath As String = "Gmail Token"
            Using stream As New FileStream("C:\Users\arand\source\repos\MultiDrew97\Media-Ministry-Manager\Media Ministry Manager\Resources\credentials.json", FileMode.Open, FileAccess.Read)
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, Scopes, "user", CancellationToken.None, New FileDataStore(credPath, True)).Result
                Console.WriteLine("Credential file saved to: " + credPath)
                Service = New GmailService(New BaseClientService.Initializer() With {
                                           .HttpClientInitializer = credential,
                                           .ApplicationName = ApplicationName
                                           }
                                          )
            End Using
        End Sub

        Function Create([to] As String, subject As String, body As String, Optional from As String = "me") As MimeMessage
            Dim sender, recipient As New Collection(Of InternetAddress)
            sender.Add(New MailboxAddress(from))
            recipient.Add(New MailboxAddress([to]))

            Return New MimeMessage(sender, recipient, subject, New TextPart() With {.Text = body})
        End Function

        Function CreateWithEmail(emailContent As MimeMessage) As Message
            Dim buffer As ByteArrayOutputStream = New ByteArrayOutputStream()
            emailContent.WriteTo(buffer)
            Dim bytes As Byte() = buffer.ToByteArray()
            Dim encodedEmail As String = UrlBase64.Encode(bytes)
            Dim message As New Message()
            message.Raw = encodedEmail
            Return message
        End Function

        Function CreateWithAttachment([to] As String, subject As String, body As String, fileNames As String, Optional from As String = "me") As MimeMessage
            Dim email As New MimeMessage() With {
                .Sender = New MailboxAddress(from),
                .Subject = subject,
                .Body = New TextPart() With {
                    .Text = body
                }
            }

            email.To.Add(New MailboxAddress([to]))

            Dim mimeBodyPart As MimePart = New TextPart() With {
                .Text = body
            }

            'mimeBodyPart.setContent(bodyText, "text/plain")

            Dim multipart As New Multipart()
            multipart.Add(mimeBodyPart)

            Dim files As String() = fileNames.Split(";"c)
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
