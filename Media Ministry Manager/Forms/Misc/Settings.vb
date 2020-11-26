Public Class Frm_Settings
    Private Sub Frm_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bw_Settings.RunWorkerAsync("l")
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
        'TODO: Close the entire application
        For Each form As Form In My.Application.OpenForms
            Try
                form.Close()
            Catch ex As Exception
                Console.WriteLine("Form not open")
            End Try
        Next
    End Sub
End Class