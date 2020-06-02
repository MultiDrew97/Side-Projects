Option Strict On

#Region "Imports"
Imports System.IO
Imports System.Threading
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Drive.v3
Imports Google.Apis.Drive.v3.Data
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports MimeKit
#End Region

Namespace Utils
    Public Class DriveUploader
#Region "Variables"
        'If modifying these scopes, delete your previously saved credentials
        'at ~/.credentials/drive-dotnet-quickstart.json
        Private ReadOnly Scopes As String() = {DriveService.Scope.Drive}

        Private ReadOnly ApplicationName As String = "Drive Uploader"
        Private permissions As New List(Of Permission)()
        Private service As DriveService
        Private db As Database
#End Region

#Region "Constructor"
        Sub New()
            Dim credential As UserCredential

            Using reader As New MemoryStream(My.Resources.credentials)
                'The file token.json stores the user's access and refresh tokens, and is created
                'automatically when the authorization flow completes for the first time.
                Dim credPath = "Drive Token"
                Dim secrets As GoogleClientSecrets = New GoogleClientSecrets().Load(reader)

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                            secrets.Secrets,
                            Scopes,
                            "user",
                            CancellationToken.None,
                            New FileDataStore(credPath, True)).Result
            End Using

            'Create Drive API service.
            service = New DriveService(New BaseClientService.Initializer() With {
                    .HttpClientInitializer = credential,
                    .ApplicationName = ApplicationName
                        }
                    )
        End Sub
#End Region

#Region "Uploading"
        Function upload(fileName As String, ByVal folderName As String, tss As ToolStripStatusLabel) As String
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
                setPermissions(file.Id, tss)
                Console.WriteLine("ID: {0}", file.Id)
                Return file.Id
            Else
                tss.Text = "Upload failed"
                tss.ForeColor = Color.Red
                Return Nothing
            End If
        End Function
#End Region

#Region "Folders"
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

        Function getFolderID(ByVal folderName As String) As String

            Dim pageToken As String = Nothing
            Dim folderSearch As FilesResource.ListRequest
            Do
                folderSearch = service.Files.List()
                folderSearch.Q = "mimeType='application/vnd.google-apps.folder'"
                folderSearch.Spaces = "drive"
                folderSearch.Fields = "nextPageToken, files(id, name)"
                folderSearch.PageToken = pageToken

                Dim result As FileList = folderSearch.Execute()

                For Each files As Data.File In result.Files
                    If (files.Name.Equals(folderName)) Then
                        Return files.Id
                    End If
                Next
                pageToken = result.NextPageToken
            Loop While (pageToken IsNot Nothing)

            Return Nothing
        End Function

        Public Function getFolders() As List(Of String)
            Dim folders As List(Of String) = New List(Of String)
            Dim pageToken As String = Nothing
            Dim folderSearch As FilesResource.ListRequest

            Do
                folderSearch = service.Files.List()
                folderSearch.Q = "mimeType='application/vnd.google-apps.folder'"
                folderSearch.Spaces = "drive"
                folderSearch.Fields = "nextPageToken, files(id, name)"
                folderSearch.PageToken = pageToken

                Dim result As FileList = folderSearch.Execute()

                For Each folder As Data.File In result.Files
                    'If folder.MimeType.Equals("application/vnd.google-apps.folder") Then
                    folders.Add(folder.Name)
                    'End If
                Next

                pageToken = result.NextPageToken
            Loop While (pageToken IsNot Nothing)

            folders.Sort()

            Return folders
        End Function
#End Region

#Region "Files"
        Function getFileID(ByVal fileName As String, folderName As String) As String
            Dim pageToken As String = Nothing
            Dim fileSearch As FilesResource.ListRequest
            Dim folderID = getFolderID(folderName)
            Do
                fileSearch = service.Files.List()
                fileSearch.Q = String.Format("name='{0}' and '{1}' in parents", fileName, folderID)
                fileSearch.Spaces = "drive"
                fileSearch.Fields = "nextPageToken, files(id, name)"
                fileSearch.PageToken = pageToken

                Dim result As FileList = fileSearch.Execute()

                For Each files As Data.File In result.Files
                    If files.Name.Equals(fileName) Then
                        Return files.Id
                    End If
                Next
                pageToken = result.NextPageToken
            Loop While (pageToken IsNot Nothing)

            Return Nothing
        End Function

        Function loadFiles(folderName As String) As List(Of String)
            Dim pageToken As String = Nothing
            Dim folderID = getFolderID(folderName)
            Dim files As New List(Of String)
            Dim fileSearch As FilesResource.ListRequest
            Do
                fileSearch = service.Files.List()
                fileSearch.Q = String.Format("mimeType!='application/vnd.google-apps.folder' and '{0}' in parents", folderID)
                fileSearch.Spaces = "drive"
                fileSearch.Fields = "nextPageToken, files(id, name, parents)"
                fileSearch.PageToken = pageToken

                Dim result As FileList = fileSearch.Execute

                For Each file In result.Files
                    files.Add(file.Name)
                Next

                pageToken = result.NextPageToken
            Loop While (pageToken IsNot Nothing)

            Return files
        End Function
#End Region

#Region "Permissions"
        Sub setPermissions(ByVal fileID As String, tss As ToolStripStatusLabel)
            Dim request As PermissionsResource.CreateRequest

            tss.Text = String.Format("Setting permissions for FileID: {0}", fileID)

            request = service.Permissions.Create(createPermission(), fileID)

            request.Execute()
        End Sub

        Function createPermission() As Permission

            Dim temp As New Permission()

            'temp.EmailAddress = email
            temp.Role = "reader"
            temp.Type = "anyone"

            Return temp
        End Function
#End Region
    End Class
End Namespace