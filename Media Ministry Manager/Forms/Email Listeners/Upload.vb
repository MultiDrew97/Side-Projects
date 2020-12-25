Imports System.ComponentModel
Imports MediaMinistry.GoogleAPI

Public Class Frm_Upload
    Private Sub Frm_EmailListeners_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        'found how to add this here: https://stackoverflow.com/questions/11686631/drag-drop-and-get-file-path-in-vb-net
        If e.Data.GetDataPresent("FileDrop", True) Then
            ofd_SelectAudio.FileName = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)
            If ofd_SelectAudio.CheckFileExists Then
                Ofd_SelectAudio_FileOk(sender, New CancelEventArgs)
                'txt_FileLocation.Text = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)
            End If
        End If
    End Sub

    Private Sub Frm_EmailListeners_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        'found how to add this here: https://stackoverflow.com/questions/11686631/drag-drop-and-get-file-path-in-vb-net
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Ofd_SelectAudio_FileOk(sender As Object, e As CancelEventArgs) Handles ofd_SelectAudio.FileOk
        txt_FileLocation.Text = ofd_SelectAudio.SafeFileName
    End Sub

    Private Sub Btn_Browse_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
        ofd_SelectAudio.ShowDialog()
    End Sub

    Private Sub Btn_AddFolder_Click(sender As Object, e As EventArgs) Handles btn_AddFolder.Click
        Dim form As New frm_Folder()
        form.Show()
    End Sub

    Private Sub Btn_Upload_Click(sender As Object, e As EventArgs) Handles btn_Upload.Click
        Using uploader As New DriveUploader()
            Dim parents As New List(Of String) From {uploader.GetFolderID(CType(cbx_Folders.SelectedItem, String))}

            If chk_Custom.Checked And Not String.IsNullOrWhiteSpace(txt_CustomName.Text) Then
                uploader.Upload(ofd_SelectAudio.FileName, parents, txt_CustomName.Text)
            Else
                uploader.Upload(ofd_SelectAudio.FileName, parents)
            End If
        End Using
    End Sub

    Private Sub Chk_Custom_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Custom.CheckedChanged
        'TODO: Make it so that the form changes the locations of the combo box and txt field pairs when changed
        txt_CustomName.Visible = chk_Custom.Checked
        lbl_CustomName.Visible = chk_Custom.Checked
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Frm_Upload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using uploader As New DriveUploader
            cbx_Folders.DataSource = uploader.GetFolders()
        End Using
    End Sub
End Class