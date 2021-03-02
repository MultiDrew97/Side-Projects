Imports System.Windows.Forms

Public Class MasterSettingsDialog
    Private ReadOnly bold As String = "Bolded? {0}"
    Private ReadOnly fontSize As String = "Font Size: {0}pt"
    Private ReadOnly textFont As String = "Font: {0}"

    Private Sub Bw_SaveSettings_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_SaveSettings.DoWork

    End Sub

    Private Sub Bw_LoadSettings_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_LoadSettings.DoWork

    End Sub

    Private Sub Tctl_Sections_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tctl_Sections.SelectedIndexChanged
        If tctl_Sections.SelectedIndex = 0 Then
            'Database Page

        ElseIf tctl_Sections.SelectedIndex = 1 Then
            'Font Page
            'TODO: Get default font info
            ChangeFont("ds")
        End If
    End Sub

    Private Sub Btn_ChangeFont_Click(sender As Object, e As EventArgs) Handles btn_ChangeFont.Click
        Dim result = fd_FontSelector.ShowDialog()

        If result = DialogResult.OK Then
            ChangeFont("fd")
        Else
            fd_FontSelector.Font = My.Settings.DefaultFont
        End If
    End Sub

    Private Sub ChangeFont(type As String)
        'fd: Font from Font Dialog
        Select Case type
            Case "fd"
                lbl_CurrentFont.Text = String.Format(textFont, fd_FontSelector.Font.Name)
                lbl_FontSize.Text = String.Format(fontSize, fd_FontSelector.Font.Size)
                lbl_Bold.Text = String.Format(bold, If(fd_FontSelector.Font.Bold, "Yes", "No"))
            Case "ds"
                lbl_CurrentFont.Text = String.Format(textFont, My.Settings.DefaultFont.Name)
                lbl_FontSize.Text = String.Format(fontSize, My.Settings.DefaultFont.Size)
                lbl_Bold.Text = String.Format(bold, If(My.Settings.DefaultFont.Bold, "Yes", "No"))
        End Select

    End Sub
End Class
