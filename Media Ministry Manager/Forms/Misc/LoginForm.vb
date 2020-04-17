Option Strict On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frm_Login
    ReadOnly _dbConnection As SqlConnectionStringBuilder = New SqlConnectionStringBuilder(My.Settings.masterConnectionString)

    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.KeepLoggedIn Then
            txt_Username.Text = My.Settings.Username
            txt_Password.Text = My.Settings.Password
            'txt_Username.Text = Environment.GetEnvironmentVariable("MediaUsername")
            'txt_Password.Text = Environment.GetEnvironmentVariable("MediaPassword")
            btn_LogIn.PerformClick()
        End If
    End Sub

    Private Sub btn_LogIn_Click(sender As Object, e As EventArgs) Handles btn_LogIn.Click
        Try
            _dbConnection.Password = txt_Password.Text
            _dbConnection.UserID = txt_Username.Text

            Dim db = New Database(_dbConnection)

            Dim mainForm = New frm_Main(db)
            Environment.SetEnvironmentVariable("updated", "False")
            mainForm.Show()
            bw_SaveSettings.RunWorkerAsync()
        Catch ex As SqlException
            tss_UserFeedback.Text = "Username/Password was inccorect. Please try again."
            tss_UserFeedback.ForeColor = Color.Red
            Console.WriteLine(ex.Message)
            txt_Password.Clear()
        End Try
    End Sub

    Private Sub reset()
        chk_KeepLoggedIn.Checked = False
        txt_Username.Clear()
        txt_Password.Clear()
        tss_UserFeedback.Text = "Please enter your log-in information"
        tss_UserFeedback.ForeColor = Color.Black
        txt_Username.Focus()
    End Sub

    Private Sub bw_SaveSettings_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_SaveSettings.DoWork
        My.Settings.KeepLoggedIn = chk_KeepLoggedIn.Checked
        My.Settings.Username = txt_Username.Text
        My.Settings.Password = txt_Password.Text
        'Environment.SetEnvironmentVariable("MediaUsername", txt_Username.Text)
        'Environment.SetEnvironmentVariable("MediaPassword", txt_Password.Text)

        My.Settings.Save()
    End Sub

    Private Sub bw_SaveSettings_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_SaveSettings.RunWorkerCompleted
        Me.Hide()
        reset()
    End Sub

    Private Sub txt_Password_GotFocus(sender As Object, e As EventArgs) Handles txt_Password.GotFocus
        'highlight the password textbox
        txt_Password.Select(0, txt_Password.TextLength)
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

    'Private Function checkCreds() As Boolean
    '    Try
    '        Dim db As Database = New Database(txt_Username.Text, txt_Password.Text)
    '        db.Close()
    '        Return True
    '    Catch e As SqlException
    '        tss_UserFeedback.Text = "Username/Password was inccorect. Please try again."
    '        tss_UserFeedback.ForeColor = Color.Red
    '        Console.WriteLine(e.Message)
    '        txt_Password.Text = ""
    '        txt_Password.Focus()
    '        Return False
    '    End Try
    'End Function

    'creating a login for a user in the database
    'CREATE USER [NAME] WITH PASSWORD = [PASSWORD]

    'granting permissions in database
    'GRANT [PERMISSION-NAME] ON [OBJECT-NAME] TO [USER/ROLE-TYPE]

    'chaging the passwords
    'ALTER USER [USER] WITH PASSWORD = [NEW-PASSWORD]
End Class