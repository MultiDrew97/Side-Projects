Public Class frm_Settings
    Private Sub Frm_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TOD): Load the current settings from the settings file
    End Sub

    Private Sub Btn_Default_Click(sender As Object, e As EventArgs) Handles btn_Default.Click
        'TODO: Implement a restore to default
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        'TODO: Save the settings currently in the settings page to the settings file
    End Sub

    Private Sub Btn_SelectFont_Click(sender As Object, e As EventArgs) Handles btn_SelectFont.Click
        fd_FontSelector.ShowDialog()
    End Sub

    Private Sub Fd_FontSelector_Apply(sender As Object, e As EventArgs) Handles fd_FontSelector.Apply
        txt_CurrentFont.Text = fd_FontSelector.Font.Name
        nud_FontSize.Value = CInt(fd_FontSelector.Font.Size)
    End Sub
End Class