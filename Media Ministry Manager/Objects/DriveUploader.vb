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

Namespace SendingEmails
    Public Class DriveUploader
        Implements IDisposable

        'If modifying these scopes, delete your previously saved credentials
        'at ~/.credentials/drive-dotnet-quickstart.json
        Private ReadOnly Scopes As String() = {DriveService.Scope.Drive}

        Private ReadOnly ApplicationName As String = "Drive Uploader"
        'Private permissions As New List(Of Permission)()
        Private tss As ToolStripStatusLabel
        Private Property Service As DriveService

        ReadOnly Property Info As User
            Get
                Dim getAbout = Service.About.Get()
                getAbout.Fields = "user(displayName, emailAddress)"
                Return getAbout.Execute().User
            End Get
        End Property

        Sub New(ct As CancellationToken)
            Dim credential As UserCredential

            'Using reader As New MemoryStream(My.Resources.credentials)
            'The file token.json stores the user's access and refresh tokens, and is created
            'automatically when the authorization flow completes for the first time.
            Dim credPath = "Drive Token"
            Dim secrets As New ClientSecrets() With {
                .ClientId = Encoding.Unicode.GetString(UrlBase64.Decode(Environment.GetEnvironmentVariable("stuff1"))),
                .ClientSecret = Encoding.Unicode.GetString(UrlBase64.Decode(Environment.GetEnvironmentVariable("stuff2")))
            }

            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(secrets, Scopes, "user", ct, New FileDataStore(credPath, True)).Result

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

        Function Upload(fileName As String, ByVal folderName As String, toolStrip As ToolStripStatusLabel) As String
            Me.tss = toolStrip
            Dim parents As New List(Of String) From {
                GetFolderID(folderName)
            }

            Dim uploadName As String = fileName.Split(CType("\\", Char()))(fileName.Split(CType("\\", Char())).Length - 1).Split(CType(".", Char()))(0) + " " + DateTime.UtcNow.ToString("MM/dd/yyyy")

            Dim fileMetadata As New Data.File With {
                .Name = uploadName,
                .Parents = parents
            }

            Dim request As FilesResource.CreateMediaUpload

            Using reader As New FileStream(fileName, FileMode.Open)
                request = Service.Files.Create(fileMetadata, reader, MimeTypes.GetMimeType(fileName))
                request.Fields = "id"
                toolStrip.Text = String.Format("Uploading the file to the drive in folder: {0}...", folderName)
                request.Upload()
            End Using

            Dim file = request.ResponseBody

            If (file IsNot Nothing) Then
                toolStrip.Text = String.Format("File Uploaded:\n\tID: {0}\n\tName: {1}", file.Id, file.Name)
                SetPermissions(file.Id)
                Console.WriteLine("ID: {0}", file.Id)
                Return file.Id
            Else
                toolStrip.Text = "Upload failed"
                toolStrip.ForeColor = Color.Red
                Return Nothing
            End If
        End Function

        Function CreateFolder(folderName As String) As String
            Dim folderID = GetFolderID(folderName)

            If (Not String.IsNullOrEmpty(folderID)) Then
                Return folderID
            Else
                Console.WriteLine("No folder found with that name")
                Dim fileMetadata As New Data.File With {
                    .Name = folderName,
                    .MimeType = "application/vnd.google-apps.folder"
                }

                Dim request = Service.Files.Create(fileMetadata)

                request.Fields = "id"
                Dim folder As Data.File = request.Execute()

                Console.WriteLine("Folder ID: " + folder.Id)
                Return folder.Id
            End If
        End Function

        Function GetFolderID(ByVal name As String) As String

            Dim pageToken As String = Nothing
            Do

                Service.Files.List().Q = "mimeType='application/vnd.google-apps.folder'"
                Service.Files.List().Spaces = "drive"
                Service.Files.List().Fields = "nextPageToken, files(id, name)"
                Service.Files.List().PageToken = pageToken

                Dim result As FileList = Service.Files.List().Execute()

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
            Dim pageToken As String = Nothing
            Do

                Service.Files.List().Q = "mimeType='text/plain'"
                Service.Files.List().Spaces = "drive"
                Service.Files.List().Fields = "nextPageToken, files(id, name)"
                Service.Files.List().PageToken = pageToken

                Dim result As FileList = Service.Files.List().Execute()

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

        Shared Function RetrieveEmails() As Collection(Of Listener)
            Dim listeners As New Collection(Of Listener)

            Using db = New Database(My.Settings.Username, My.Settings.Password)
                listeners = db.RetrieveListeners()
            End Using

            Return listeners
        End Function

        Public ReadOnly Property GetFolders As Collection(Of String)
            Get
                Dim folders As New Collection(Of String)
                Dim pageToken As String = Nothing

                Do

                    Service.Files.List().Q = "mimeType='application/vnd.google-apps.folder'"
                    Service.Files.List().Spaces = "drive"
                    Service.Files.List().Fields = "nextPageToken, files(id, name)"
                    Service.Files.List().PageToken = pageToken

                    Dim result As FileList = Service.Files.List().Execute()

                    For Each folder As Data.File In result.Files
                        If folder.MimeType.Equals("application/vnd.google-apps.folder") Then
                            folders.Add(folder.Name)
                        End If
                    Next

                    pageToken = result.NextPageToken
                Loop While (pageToken IsNot Nothing)

                'folders.Sort()

                Return folders
            End Get
        End Property
    End Class

End Namespace