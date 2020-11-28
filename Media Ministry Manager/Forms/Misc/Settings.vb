Imports System.IO
Imports System.Threading
Imports MediaMinistry.Helpers
Imports MediaMinistry.SendingEmails

Public Class Frm_Settings
    Private Const currentUser = "Current User: {0}"
    Private cts As CancellationTokenSource
    Private Sub Frm_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load settings from settings file to display to user
        Me.Font = My.Settings.CurrentFont
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

        'Retrieve the Google Drive Info being used by the user
        If Directory.Exists(Application.StartupPath & "\Gmail Token") Then
            Using emailer As New Sender(cts.Token)
                lbl_CurrentGmail.Text = String.Format(currentUser, emailer.Info.EmailAddress)
                btn_Gmail.Text = "Unlink Google Drive"
            End Using
        Else
            lbl_CurrentGmail.Text = String.Format(currentUser, "Unlinked")
            btn_Gmail.Text = "Link Google Drive"
        End If
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
                'Load the settings of the application
                Me.Invoke(
                    Sub()
                        fd_FontSelector.Font = My.Settings.CurrentFont
                        Fd_FontSelector_Apply(sender, e)
                    End Sub
                )
            Case "s"
                'Save the settings that have been changed by the user
                My.Settings.CurrentFont = fd_FontSelector.Font
                My.Settings.Save()
            Case "d"
                'Restore the defaults of the application
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
                bw_Service.CancelAsync()
                btn_GoogleDrive.Text = "Link Google Drive"
            End If
        ElseIf btn_GoogleDrive.Text = "Link Google Drive" Then
            btn_GoogleDrive.Text = "Cancel"
            bw_Service.RunWorkerAsync("d")
        End If
    End Sub

    Private Sub btn_Gmail_Click(sender As Object, e As EventArgs) Handles btn_Gmail.Click
        If btn_Gmail.Text = "Unlink Gmail" Then
            Try
                Directory.Delete(Application.StartupPath & "\Gmail Token", True)
                btn_Gmail.Text = "Link Google Drive"
                lbl_CurrentGmail.Text = String.Format(currentUser, "Unlinked")
            Catch ex As DirectoryNotFoundException

            Catch ex As UnauthorizedAccessException

            Catch ex As PathTooLongException

            End Try
        ElseIf btn_GoogleDrive.Text = "Cancel" Then
            If cts IsNot Nothing Then
                cts.Cancel()
                bw_Service.CancelAsync()
                btn_Gmail.Text = "Link Gmail"
            End If
        ElseIf btn_GoogleDrive.Text = "Link Gmail" Then
            btn_Gmail.Text = "Cancel"
            bw_Service.RunWorkerAsync("m")
        End If
    End Sub

    Private Sub bw_Service_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_Service.DoWork
        cts = New CancellationTokenSource()
        Dim service As Service
        Select Case CType(e.Argument, String)
            Case "d"
                Try
                    service = New DriveUploader(cts.Token)
                    Invoke(
                        Sub()
                            btn_GoogleDrive.Text = "Unlink Google Drive"
                            lbl_CurrentDrive.Text = String.Format(currentUser, service.Info.EmailAddress)
                        End Sub
                    )
                Catch ex As OperationCanceledException
                    Console.WriteLine("Canceled Exception")
                Catch ex As AggregateException
                    Console.WriteLine("Aggregate Exception")
                End Try

            Case "m"
                Try
                    service = New Sender(cts.Token)
                    Invoke(
                        Sub()
                            btn_Gmail.Text = "Unlink Gmail"
                            lbl_CurrentGmail.Text = String.Format(currentUser, service.Info.EmailAddress)
                        End Sub
                    )
                Catch ex As OperationCanceledException
                    Console.WriteLine("Canceled Exception")
                Catch ex As AggregateException
                    Console.WriteLine("Aggregate Exception")
                End Try
        End Select
    End Sub
End Class