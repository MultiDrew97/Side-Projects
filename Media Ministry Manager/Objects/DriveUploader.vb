Option Strict On

Imports System.IO
Imports System.Text
Imports System.Threading
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Drive.v3
Imports Google.Apis.Drive.v3.Data
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports MimeKit
Imports NeoSmart.Utils

Namespace SendingEmails

    Public Class DriveUploader

        'If modifying these scopes, delete your previously saved credentials
        'at ~/.credentials/drive-dotnet-quickstart.json
        Private ReadOnly Scopes As String() = {DriveService.Scope.Drive}

        Private ReadOnly ApplicationName As String = "Drive Uploader"
        Private permissions As New List(Of Permission)()
        Private tss As ToolStripStatusLabel
        Private Property service() As DriveService
        Private db As Database

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
            service = New DriveService(New BaseClientService.Initializer() With {
                    .HttpClientInitializer = credential,
                    .ApplicationName = ApplicationName
                        }
                    )
        End Sub

        Function upload(fileName As String, ByVal folderName As String, tss As ToolStripStatusLabel) As String
            Me.tss = tss
            Dim parents As IList(Of String) = New List(Of String)
            parents.Add(getFolderID(folderName))

            Dim uploadName As String = fileName.Split(CType("\\", Char()))(fileName.Split(CType("\\", Char())).Length - 1).Split(CType(".", Char()))(0) + " " + DateTime.UtcNow.ToString("MM/dd/yyyy")

            Dim fileMetadata As New Data.File With {
                .Name = uploadName,
                .Parents = parents
            }

            Dim request As FilesResource.CreateMediaUpload

            Using reader As New FileStream(fileName, FileMode.Open)
                request = service.Files.Create(fileMetadata, reader, MimeTypes.GetMimeType(fileName))
                request.Fields = "id"
                tss.Text = String.Format("Uploading the file to the drive in folder: {0}...", folderName)
                request.Upload()
            End Using

            Dim file = request.ResponseBody

            If (file IsNot Nothing) Then
                tss.Text = String.Format("File Uploaded:\n\tID: {0}\n\tName: {1}", file.Id, file.Name)
                setPermissions(file.Id)
                Console.WriteLine("ID: {0}", file.Id)
                Return file.Id
            Else
                tss.Text = "Upload failed"
                tss.ForeColor = Color.Red
                Return Nothing
            End If
        End Function

        Function createFolder(folderName As String) As String
            Dim folderID = getFolderID(folderName)

            If (Not String.IsNullOrEmpty(folderID)) Then
                Return folderID
            Else
                Console.WriteLine("No folder found with that name")
                Dim fileMetadata As New Data.File
                fileMetadata.Name = folderName
                fileMetadata.MimeType = "application/vnd.google-apps.folder"

                Dim request = service.Files.Create(fileMetadata)

                request.Fields = "id"
                Dim folder As Data.File = request.Execute()

                Console.WriteLine("Folder ID: " + folder.Id)
                Return folder.Id
            End If
        End Function

        Function getFolderID(ByVal name As String) As String

            Dim pageToken As String = Nothing
            Do

                service.Files.List().Q = "mimeType='application/vnd.google-apps.folder'"
                service.Files.List().Spaces = "drive"
                service.Files.List().Fields = "nextPageToken, files(id, name)"
                service.Files.List().PageToken = pageToken

                Dim result As FileList = service.Files.List().Execute()

                For Each files As Data.File In result.Files
                    If (files.Name.Equals(name)) Then
                        Return files.Id
                    End If
                Next
                pageToken = result.NextPageToken
            Loop While (pageToken IsNot Nothing)

            Return Nothing
        End Function

        Function findFile(ByVal fileName As String) As String
            Dim pageToken As String = Nothing
            Do

                service.Files.List().Q = "mimeType='text/plain'"
                service.Files.List().Spaces = "drive"
                service.Files.List().Fields = "nextPageToken, files(id, name)"
                service.Files.List().PageToken = pageToken

                Dim result As FileList = service.Files.List().Execute()

                For Each files As Data.File In result.Files
                    If (files.Name.Equals(fileName)) Then
                        Return files.Id
                    End If
                Next
                pageToken = result.NextPageToken
            Loop While (pageToken IsNot Nothing)

            Return Nothing
        End Function

        Sub setPermissions(ByVal fileID As String)

            Dim request As PermissionsResource.CreateRequest

            tss.Text = String.Format("Setting permissions for FileID: {0}", fileID)

            request = service.Permissions.Create(createPermission(), fileID)
            'request.EmailMessage = String.Format(message, listener.name)
            request.Execute()
        End Sub

        Function createPermission() As Permission

            Dim temp As New Permission()

            'temp.EmailAddress = email
            temp.Role = "reader"
            temp.Type = "anyone"

            Return temp
        End Function

        Function retrieveEmails() As List(Of Listener)
            Dim listeners As New List(Of Listener)

            db = New Database(My.Settings.Username, My.Settings.Password)
            listeners = db.RetrieveListeners()

            Return listeners
        End Function

        Public Function getFolders() As List(Of String)
            Dim folders As List(Of String) = New List(Of String)
            Dim pageToken As String = Nothing

            Do

                service.Files.List().Q = "mimeType='application/vnd.google-apps.folder'"
                service.Files.List().Spaces = "drive"
                service.Files.List().Fields = "nextPageToken, files(id, name)"
                service.Files.List().PageToken = pageToken

                Dim result As FileList = service.Files.List().Execute()

                For Each folder As Data.File In result.Files
                    If folder.MimeType.Equals("application/vnd.google-apps.folder") Then
                        folders.Add(folder.Name)
                    End If
                Next

                pageToken = result.NextPageToken
            Loop While (pageToken IsNot Nothing)

            folders.Sort()

            Return folders
        End Function

    End Class

End Namespace