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


Namespace GoogleAPI
    Public Class Sender
        Inherits Service
        Implements IDisposable
        Private ReadOnly Scopes As String() = {GmailService.Scope.GmailSend}
        Private ReadOnly ApplicationName As String = "Media Ministry Manager"
        Private Property Service As GmailService

        Overrides ReadOnly Property Info As Object
            Get
                Try
                    Return Service.Users.GetProfile("me").Execute()
                Catch ex As Google.GoogleApiException
                    Console.WriteLine(ex.StackTrace)
                End Try

                Return Nothing
            End Get
        End Property

        Sub New(Optional ct As CancellationToken = Nothing)
            Dim credPath As String = "Gmail Token"
            Dim credential As UserCredential
            Using stream As New MemoryStream(My.Resources.credentials)
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, Scopes, "user", ct, New FileDataStore(credPath, True)).Result

                Service = New GmailService(New BaseClientService.Initializer() With {.HttpClientInitializer = credential, .ApplicationName = ApplicationName})
            End Using
        End Sub

        Sub Dispose() Implements IDisposable.Dispose

        End Sub

        Function Create([to] As MailboxAddress, subject As String, body As String, Optional from As String = "me", Optional text As Boolean = False) As MimeMessage
            Dim sender, recipient As New Collection(Of InternetAddress)

            Dim email As New MimeMessage() With {
                .Sender = MailboxAddress.Parse(from),
                .Subject = subject
            }

            If text Then
                email.Body = New TextPart("plain") With {
                    .Text = body
                }
            Else
                email.Body = New TextPart("html") With {
                .Text = body
            }
            End If

            email.To.Add([to])

            Return email
        End Function

        Function CreateWithEmail(emailContent As MimeMessage) As Message
            Dim buffer As ByteArrayOutputStream = New ByteArrayOutputStream()
            emailContent.WriteTo(buffer)
            Dim bytes As Byte() = buffer.ToByteArray()
            Dim encodedEmail As String = UrlBase64.Encode(bytes)
            'Dim message As New Message With {
            '    .Raw = encodedEmail
            '}

            Return New Message With {
                .Raw = encodedEmail
            }
        End Function

        Function CreateWithAttachment([to] As MailboxAddress, subject As String, body As String, files As String(), Optional from As String = "me", Optional text As Boolean = False) As MimeMessage
            Dim email As New MimeMessage() With {
                .Sender = New MailboxAddress(from, from),
                .Subject = subject
            }

            email.To.Add([to])
            Dim mimeBodyPart As MimePart
            If text Then
                mimeBodyPart = New TextPart("plain") With {
                    .Text = body
                }
            Else
                mimeBodyPart = New TextPart("html") With {
                    .Text = body
                }
            End If

            'mimeBodyPart.setContent(bodyText, "text/plain")

            Dim multipart As New Multipart From {
                mimeBodyPart
            }

            Dim attachments As New AttachmentCollection()

            For Each file As String In files
                attachments.Add(file)
            Next

            'Dim source As javax.activation.DataSource = New FileDataSource(File)

            'mimeBodyPart.setDataHandler(New DataHandler(source))
            'mimeBodyPart.setFileName(file.getName())

            For Each attachment As MimeEntity In attachments
                multipart.Add(attachment)
            Next


            email.Body = multipart

            Return email

        End Function
        Function Send(emailContent As MimeMessage, Optional userId As String = "me") As Message
            Dim message As Message = CreateWithEmail(emailContent)

            Return Service.Users().Messages().Send(message, userId).Execute()
        End Function
    End Class
End Namespace
