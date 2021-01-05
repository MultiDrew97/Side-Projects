Option Strict On

Imports System.ComponentModel
Imports MediaMinistry.SendingEmails
Imports MediaMinistry.Helpers

Public Class Frm_EmailListeners
    ReadOnly shareLink As String = "https://drive.google.com/file/d/{0}/view?usp=sharing"
    Private fileID As String = Nothing
    ReadOnly emailerLocation As String = Application.StartupPath & "\sender.jar"



    Private Structure Sizes

        'Window Sizes
        Shared [Default] As New Size(842, 240)

        Shared Max As New Size(1382, 744)
    End Structure

    Private Structure Locations

        'upload button locations
        Shared UploadDefault As New Point(20, 13)

        'Send button locations
        Shared SendDefault As New Point(20, 71)

        'View button Locations
        Shared ViewDefault As New Point(20, 129)

        'Folder combo locations
        Shared FolderDefault As New Point(389, 55)

        'File text locations
        Shared FileDefault As New Point(389, 114)

        'new folder button locations
        Shared FolderAddDefault As New Point(762, 57)

        'find file button
        Shared BrowseDefault As New Point(762, 114)

        'folder label locations
        Shared FolderLabelDefault As New Point(293, 55)

        'file label locations
        Shared FileLabelDefault As New Point(314, 114)

    End Structure

    Private Structure MinisLocations
        Shared upload As New Point(20, 13)
        Shared sending As New Point(20, 71)
        Shared view As New Point(20, 129)
        Shared folders As New Point(389, 68)
        Shared file As New Point(389, 127)
        Shared group As New Point(389, 13)
        Shared ministry As New Point(65, 19)
        Shared live As New Point(196, 19)
    End Structure

    Private Structure LiveLocations
        Shared upload As New Point()
        Shared sending As New Point()
        Shared view As New Point()
        Shared folders As New Point()
        Shared file As New Point()
        Shared group As New Point()
        Shared ministry As New Point()
        Shared live As New Point()
    End Structure

    Private Structure MinisSizes
        Shared form As New Size(842, 240)
    End Structure

    Structure LiveSizes
        Shared form As New Size(900, 800)
    End Structure

    Private Sub Btn_Upload_Click(sender As Object, e As EventArgs) Handles btn_Upload.Click
        Dim upload As New Frm_Upload
        upload.Show()
    End Sub

    Private Sub Frm_EmailListeners_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim main As New frm_Main()
        main.Show()
    End Sub

    Private Sub Frm_EmailListeners_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        If Frm_Main.IsDisposed Then
            Close()
        End If
    End Sub

    Private Sub Btn_SendEmails_Click(sender As Object, e As EventArgs) Handles btn_SendEmails.Click
        'tss_Feedback.ForeColor = Color.Black
        'If fileID IsNot Nothing Then
        '    tss_Feedback.Text = "Sending emails to listeners..."
        '    Dim sending As Process = Process.Start(emailerLocation, String.Format("{0} {1} {2}", My.Settings.Username, My.Settings.Password, String.Format(shareLink, fileID)))

        'TODO: Move this into a background worker to not freeze the app while sending

        'Dim listeners As ObjectModel.Collection(Of Listener)
        'If cbx_Files.SelectedItem IsNot Nothing Then
        '    Using uploader As New DriveUploader()
        '        fileID = uploader.getFileID(CType(cbx_Files.SelectedItem, String))
        '    End Using
        '    If fileID IsNot Nothing Then
        '        Using db As New Database(My.Settings.Username, My.Settings.Password)
        '            listeners = db.RetrieveListeners()
        '            Using emailer As New Sender()
        '                tss_Feedback.Text = "Sending Emails..."
        '                For Each listener As Listener In listeners
        '                    emailer.Send(emailer.Create(MimeKit.MailboxAddress.Parse(listener.Email), "Sunday Morning Message", String.Format(My.Resources.newSermon, listener.Name, String.Format(shareLink, fileID))))
        '                Next
        '            End Using
        '            tss_Feedback.Text = "All emails have been sent"
        '        End Using
        '    End If
        'End If

        Dim send As New frm_SendEmails()
        send.Show()
    End Sub

    Private Sub Btn_ViewListeners_Click(sender As Object, e As EventArgs) Handles btn_ViewListeners.Click
        Dim frm_ViewListeners As frm_ViewListeners = New frm_ViewListeners With {.sendingForm = Me}
        frm_ViewListeners.Show()
        Me.Hide()
    End Sub



    Private Sub Frm_EmailListeners_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.Size = Sizes.Max Then
            MaxChanges()
        Else
            DefaultChanges()
        End If
    End Sub

    Private Sub MaxChanges()

    End Sub

    Private Sub DefaultChanges()
        'Locations
        'btn_Upload.Location = Locations.UploadDefault
        btn_SendEmails.Location = Locations.SendDefault
        btn_ViewListeners.Location = Locations.ViewDefault
    End Sub
End Class
