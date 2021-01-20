Option Strict On

Imports MediaMinistry.GoogleAPI

Public Class FileSelectionDialog
    Shared Property FileName As String
    Shared Property FileID As String
    Shared Property Parents As IList(Of String)

    Private Sub Btn_Select_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Ok.Click
        If cbx_File.SelectedIndex > -1 Then
            Using uploader As New DriveUploader
                Dim file = uploader.GetFileInfo(CType(cbx_File.SelectedItem, String), CType(cbx_Folder.SelectedItem, String))
                FileName = file.Name
                FileID = file.Id
                Parents = file.Parents
            End Using

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("A file must be selected. Please try again.", "File Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Cancel.Click
        FileName = Nothing
        FileID = Nothing
        Parents = Nothing
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Cbx_Folder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Folder.SelectedIndexChanged
        Using uploader As New DriveUploader()
            cbx_File.DataSource = uploader.GetFiles(CType(cbx_Folder.SelectedItem, String))
        End Using
    End Sub

    Private Sub FileSelectionDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using uploader As New DriveUploader()
            cbx_Folder.DataSource = uploader.GetFolders
        End Using
    End Sub
End Class
