Imports System.ComponentModel

Public Class frm_Upload
    Private Sub Frm_EmailListeners_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        'found how to add this here: https://stackoverflow.com/questions/11686631/drag-drop-and-get-file-path-in-vb-net
        If e.Data.GetDataPresent("FileDrop", True) Then
            ofd_SelectAudio.FileName = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)
            If ofd_SelectAudio.CheckFileExists Then
                ofd_SelectAudio_FileOk(sender, New CancelEventArgs)
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

    Private Sub ofd_SelectAudio_FileOk(sender As Object, e As CancelEventArgs) Handles ofd_SelectAudio.FileOk

    End Sub
End Class