Option Strict On

Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Text
Imports System.Threading
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Drive.v3
Imports Google.Apis.Drive.v3.Data
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports MimeKit
Imports Org.BouncyCastle.Utilities.Encoders

Namespace GoogleAPI
    Public Class DriveUploader
        Implements IDisposable

        'If modifying these scopes, delete your previously saved credentials
        'at ~/.credentials/drive-dotnet-quickstart.json
        Private ReadOnly Scopes As String() = {DriveService.Scope.Drive}

        Private ReadOnly ApplicationName As String = "Drive Uploader"
        'Private permissions As New List(Of Permission)()
        Private ReadOnly tss As ToolStripStatusLabel
        Private Property Service() As DriveService

        Sub New()
            Dim credential As UserCredential

            'Using reader As New MemoryStream(My.Resources.credentials)
            'The file token.json stores the user's access and refresh tokens, and is created
            'automatically when the authorization flow completes for the first time.
            Dim credPath = "Drive Token"
            Dim secrets As New ClientSecrets() With {
                .ClientId = Encoding.Unicode.GetString(UrlBase64.Decode(Environment.GetEnvironmentVariable("stuff1"))),
                .ClientSecret = Encoding.Unicode.GetString(UrlBase64.Decode(Environment.GetEnvironmentVariable("stuff2")))
            }
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                            secrets,
                            Scopes,
                            "user",
                            CancellationToken.None,
                            New FileDataStore(credPath, True)).Result

            'End Using

            'Create Drive API service.
            Service = New DriveService(New BaseClientService.Initializer() With {
                    .HttpClientInitializer = credential,
                    .ApplicationName = ApplicationName
                        }
                    )
        End Sub

        Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

        Protected Overridable Sub Dispose(ByVal disposing As Boolean)

        End Sub

        Function Upload(fileName As String, parents As List(Of String), Optional uploadName As String = Nothing) As String
            Dim fileMetadata As New Data.File() With {
                .Name = CType(IIf(String.IsNullOrEmpty(uploadName), fileName.Split(CType("\\", Char()))(fileName.Split(CType("\\", Char())).Length - 1).Split(CType(".", Char()))(0) + " " + DateTime.UtcNow.ToString("MM/dd/yyyy"), uploadName), String),
                .Parents = parents
            }

            Dim request As FilesResource.CreateMediaUpload

            Using reader As New FileStream(fileName, FileMode.Open)
                request = Service.Files.Create(fileMetadata, reader, MimeTypes.GetMimeType(fileName))
                request.Fields = "id"
                request.Upload()
            End Using

            If (request.ResponseBody IsNot Nothing) Then
                Return request.ResponseBody.Id
            Else
                Return Nothing
            End If
        End Function

        Function CreateFolder(folderName As String) As String
            Dim folderID = GetFolderID(folderName)

            If (Not String.IsNullOrEmpty(folderID)) Then
                Return folderID
            Else
                Dim fileMetadata As New Data.File With {
                    .Name = folderName,
                    .MimeType = "application/vnd.google-apps.folder"
                }

                Dim request = Service.Files.Create(fileMetadata)

                request.Fields = "id"
                Dim folder As Data.File = request.Execute()

                Return folder.Id
            End If
        End Function

        Function GetFolderID(name As String) As String
            Dim request As FilesResource.ListRequest = Service.Files.List()
            Dim pageToken As String = Nothing
            Do

                request.Q = "mimeType='application/vnd.google-apps.folder'"
                request.Spaces = "drive"
                request.Fields = "nextPageToken, files(id, name)"
                request.PageToken = pageToken

                Dim result As FileList = request.Execute()

                For Each files As Data.File In result.Files
                    If (files.Name.Equals(name)) Then
                        Return files.Id
                    End If
                Next
                pageToken = result.NextPageToken
            Loop While (pageToken IsNot Nothing)

            Return Nothing
        End Function

        Function FindFile(ByVal fileName As String) As String
            Dim request As FilesResource.ListRequest = Service.Files.List()
            Dim pageToken As String = Nothing
            Do

                request.Q = "mimeType!='application/vnd.google-apps.folder'"
                request.Spaces = "drive"
                request.Fields = "nextPageToken, files(id, name)"
                request.PageToken = pageToken

                Dim result As FileList = request.Execute()

                For Each files As Data.File In result.Files
                    If (files.Name.Equals(fileName)) Then
                        Return files.Id
                    End If
                Next
                pageToken = result.NextPageToken
            Loop While (pageToken IsNot Nothing)

            Return Nothing
        End Function

        Sub SetPermissions(ByVal fileID As String)

            Dim request As PermissionsResource.CreateRequest

            tss.Text = String.Format("Setting permissions for FileID: {0}", fileID)

            request = Service.Permissions.Create(CreatePermission(), fileID)
            'request.EmailMessage = String.Format(message, listener.name)
            request.Execute()
        End Sub

        Shared Function CreatePermission() As Permission
            Return New Permission With {
                .Role = "reader",
                .Type = "anyone"
            }
        End Function

        Public ReadOnly Property GetFolders As Collection(Of String)
            Get
                Dim folders As New Collection(Of String)
                Dim pageToken As String = Nothing
                Dim request = Service.Files.List()

                Do

                    request.Q = "mimeType='application/vnd.google-apps.folder'"
                    request.Spaces = "drive"
                    request.Fields = "nextPageToken, files(id, name)"
                    request.PageToken = pageToken

                    Dim result As FileList = request.Execute()

                    For Each folder As Data.File In result.Files
                        folders.Add(folder.Name)
                    Next

                    pageToken = result.NextPageToken
                Loop While (pageToken IsNot Nothing)

                'folders.Sort()

                Return folders
            End Get
        End Property

        Public ReadOnly Property GetFiles(folderName As String) As Collection(Of String)
            Get
                Dim files As New Collection(Of String)
                Dim folderID As String = GetFolderID(folderName)
                Dim pageToken As String = Nothing
                Dim request = Service.Files.List()

                Do

                    request.Q = String.Format("mimeType != 'application/vnd.google-apps.folder' and '{0}' in parents", folderID)
                    request.Spaces = "drive"
                    request.Fields = "nextPageToken, files(id, name, parents)"
                    request.PageToken = pageToken

                    Dim result As FileList = request.Execute()

                    For Each file As Data.File In result.Files
                        files.Add(file.Name)
                    Next

                    pageToken = result.NextPageToken
                Loop While (pageToken IsNot Nothing)

                'folders.Sort()

                Return files
            End Get
        End Property

    End Class

End Namespace