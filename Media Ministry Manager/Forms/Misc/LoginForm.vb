Option Strict On

#Region "Imports"
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Media_Ministry.Utils
#End Region

Public Class frm_Login
#Region "Globals"
    ReadOnly _dbConnection As SqlConnectionStringBuilder = New SqlConnectionStringBuilder(My.Settings.Default.masterConnection)
#End Region

#Region "Form Subs"
    Private Sub frm_Login_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'If My.Settings.KeepLoggedIn Then
        '    txt_Username.Text = My.Settings.Username
        '    txt_Password.Text = My.Settings.Password
        '    chk_KeepLoggedIn.Checked = My.Settings.KeepLoggedIn
        '    btn_LogIn.PerformClick()
        'End If

        If My.Settings.KeepLoggedIn Then
            btn_LogIn.PerformClick()
        End If
    End Sub

    Private Sub frm_Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Item("masterConnection") = "Data Source=mediaministry.database.windows.net;Initial Catalog=""Media Ministry"";Persist Security Info=True;Encrypt=True;"
    End Sub

    Private Sub reset()
        chk_KeepLoggedIn.Checked = False
        txt_Username.Clear()
        txt_Password.Clear()
        tss_UserFeedback.Text = "Please enter your log-in information"
        tss_UserFeedback.ForeColor = Color.Black
        txt_Username.Focus()
    End Sub
#End Region

#Region "Buttons"
    Private Sub btn_LogIn_Click(sender As Object, e As EventArgs) Handles btn_LogIn.Click
        Try
            _dbConnection.Password = txt_Password.Text
            _dbConnection.UserID = txt_Username.Text

            Using db = New Database(_dbConnection)
            End Using

            Dim mainForm = New frm_Main()
            mainForm.Show()

            bw_SaveSettings.RunWorkerAsync()
        Catch ex As SqlException
            tss_UserFeedback.Text = "Username/Password was inccorect. Please try again."
            tss_UserFeedback.ForeColor = Color.Red
            Console.WriteLine(ex.Message)
            txt_Password.Clear()
        End Try
    End Sub

    Private Sub btn_CreateUser_Click(sender As Object, e As EventArgs) Handles btn_CreateUser.Click
        Dim newUser = New frm_CreateUser()
        newUser.Show()
        Me.Hide()
        reset()
    End Sub

    Private Sub btn_ChangePassword_Click(sender As Object, e As EventArgs) Handles btn_ChangePassword.Click
        Dim changePassword = New frm_ChangePassword()
        changePassword.Show()
        Me.Hide()
        reset()
    End Sub
#End Region

#Region "Background Worker"
    Private Sub bw_SaveSettings_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_SaveSettings.DoWork
        My.Settings.KeepLoggedIn = chk_KeepLoggedIn.Checked
        My.Settings.Username = txt_Username.Text
        My.Settings.Password = txt_Password.Text

        My.Settings.Save()
    End Sub

    Private Sub bw_SaveSettings_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_SaveSettings.RunWorkerCompleted
        Me.Hide()
        reset()
    End Sub
#End Region

#Region "Text Boxes"
    Private Sub txt_Password_GotFocus(sender As Object, e As EventArgs) Handles txt_Password.GotFocus
        'highlight the password textbox
        txt_Password.Select(0, txt_Password.TextLength)
    End Sub
#End Region

    'creating a login for a user in the database
    'CREATE USER [NAME] WITH PASSWORD = [PASSWORD]

    'granting permissions in database
    'GRANT [PERMISSION-NAME] ON [OBJECT-NAME] TO [USER/ROLE-TYPE]

    'chaging the passwords
    'ALTER USER [USER] WITH PASSWORD = [NEW-PASSWORD]
End Class