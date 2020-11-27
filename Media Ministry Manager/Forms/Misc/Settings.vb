Imports System.IO
Imports System.Threading
Imports MediaMinistry.Helpers
Imports MediaMinistry.SendingEmails

Public Class Frm_Settings
    Private Const currentUser = "Current User: {0}"
    Private cts As CancellationTokenSource
    Private Sub Frm_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load settings from settings file to display to user
        bw_Settings.RunWorkerAsync("l")

        cts = New CancellationTokenSource()

        'Retrieve the Google Drive Info being used by the user
        If Directory.Exists(Application.StartupPath & "\Drive Token") Then
            Using uploader As New DriveUploader(cts.Token)
                lbl_CurrentDrive.Text = String.Format(currentUser, uploader.Info.EmailAddress)
                btn_GoogleDrive.Text = "Unlink Google Drive"
            End Using
        Else
            lbl_CurrentDrive.Text = String.Format(currentUser, "Unlinked")
            btn_GoogleDrive.Text = "Link Google Drive"
        End If

        'TODO: Figure out how to access Sender Token folder
        lbl_CurrentGmail.Text = String.Format(currentUser, "Unlinked")

        File.Exists(Application.StartupPath & "\Resources\sender.jar")
    End Sub

    Private Sub Btn_Default_Click(sender As Object, e As EventArgs) Handles btn_Default.Click
        bw_Settings.RunWorkerAsync("d")
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        bw_Settings.RunWorkerAsync("s")
    End Sub

    Private Sub Btn_SelectFont_Click(sender As Object, e As EventArgs) Handles btn_ChangeFont.Click
        fd_FontSelector.ShowDialog()
    End Sub

    Private Sub Fd_FontSelector_Apply(sender As Object, e As EventArgs) Handles fd_FontSelector.Apply
        txt_CurrentFont.Text = fd_FontSelector.Font.Name
        nud_FontSize.Value = CDec(fd_FontSelector.Font.Size)
        chk_Bold.Checked = fd_FontSelector.Font.Bold
    End Sub

    Private Sub Bw_Settings_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_Settings.DoWork
        Select Case CType(e.Argument, String)
            Case "l"
                'TODO: Load the settings of the application
                Me.Invoke(
                    Sub()
                        fd_FontSelector.Font = My.Settings.CurrentFont
                        Fd_FontSelector_Apply(sender, e)
                    End Sub
                )
            Case "s"
                'TODO: Save the settings that have been changed by the user
                My.Settings.CurrentFont = fd_FontSelector.Font
                My.Settings.Save()
            Case "d"
                'TODO: Restore the defaults of the application
                My.Settings.CurrentFont = MySettings.Default.DefaultFont
                Invoke(
                    Sub()
                        fd_FontSelector.Font = My.Settings.CurrentFont
                        Fd_FontSelector_Apply(sender, e)
                    End Sub
                )
                My.Settings.Save()
        End Select
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Utils.CloseOpenForms()
    End Sub

    Private Sub btn_GoogleDrive_Click(sender As Object, e As EventArgs) Handles btn_GoogleDrive.Click
        If btn_GoogleDrive.Text = "Unlink Google Drive" Then
            Try
                Directory.Delete(Application.StartupPath & "\Drive Token", True)
                btn_GoogleDrive.Text = "Link Google Drive"
                lbl_CurrentDrive.Text = String.Format(currentUser, "Unlinked")
            Catch ex As DirectoryNotFoundException

            Catch ex As UnauthorizedAccessException

            Catch ex As PathTooLongException

            End Try
        ElseIf btn_GoogleDrive.Text = "Cancel" Then
            If cts IsNot Nothing Then
                cts.Cancel()
                bw_Uploader.CancelAsync()
                btn_GoogleDrive.Text = "Link Google Drive"
            End If
        ElseIf btn_GoogleDrive.Text = "Link Google Drive" Then
            btn_GoogleDrive.Text = "Cancel"
            bw_Uploader.RunWorkerAsync()
        End If
    End Sub

    Private Sub CancelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelToolStripMenuItem.Click

    End Sub

    Private Sub bw_Uploader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_Uploader.DoWork
        cts = New CancellationTokenSource()
        Try
            Dim uploader As New DriveUploader(cts.Token)
            Invoke(
                Sub()
                    btn_GoogleDrive.Text = "Unlink Google Drive"
                    lbl_CurrentDrive.Text = String.Format(currentUser, uploader.Info.EmailAddress)
                End Sub
            )
        Catch ex As OperationCanceledException
            Console.WriteLine("Canceled Exception")
        Catch ex As AggregateException
            Console.WriteLine("Aggregate Exception")
        End Try
    End Sub

    Private Sub btn_Gmail_Click(sender As Object, e As EventArgs) Handles btn_Gmail.Click
        If btn_Gmail.Text = "Unlink Google Drive" Then
            Try
                Directory.Delete(Application.StartupPath & "\Drive Token", True)
                btn_Gmail.Text = "Link Google Drive"
                lbl_CurrentGmail.Text = String.Format(currentUser, "Unlinked")
            Catch ex As DirectoryNotFoundException

            Catch ex As UnauthorizedAccessException

            Catch ex As PathTooLongException

            End Try
        ElseIf btn_Gmail.Text = "Cancel" Then
            If cts IsNot Nothing Then
                cts.Cancel()
                bw_Gmail.CancelAsync()
                btn_Gmail.Text = "Link Google Drive"
            End If
        ElseIf btn_GoogleDrive.Text = "Link Google Drive" Then
            btn_Gmail.Text = "Cancel"
            bw_Gmail.RunWorkerAsync()
        End If
    End Sub

    Private Sub bw_Gmail_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_Gmail.DoWork
        cts = New CancellationTokenSource()
        Try
            Dim emailer As New Sender(cts.Token)
            Invoke(
                Sub()
                    btn_Gmail.Text = "Unlink Google Drive"
                    lbl_CurrentGmail.Text = String.Format(currentUser, emailer.Info.EmailAddress)
                End Sub
            )
        Catch ex As OperationCanceledException
            Console.WriteLine("Canceled Exception")
        Catch ex As AggregateException
            Console.WriteLine("Aggregate Exception")
        End Try
    End Sub
End Class