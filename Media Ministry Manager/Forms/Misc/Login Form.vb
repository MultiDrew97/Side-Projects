Option Strict On
Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class frm_Login
    Dim _dbConnection As SqlConnectionStringBuilder

    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()

        _dbConnection = New SqlConnectionStringBuilder

        _dbConnection.DataSource = My.Settings.DataSource
        _dbConnection.InitialCatalog = My.Settings.InitalCatalog
        _dbConnection.PersistSecurityInfo = My.Settings.PersistSecurityInfo
    End Sub

    Private Sub frm_Login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If My.Settings.KeepLoggedIn Then
            _dbConnection.Password = txt_Password.Text
            _dbConnection.UserID = txt_Username.Text

            btn_LogIn.PerformClick()
        End If
    End Sub

    Private Sub btn_LogIn_Click(sender As Object, e As EventArgs) Handles btn_LogIn.Click
        Try
            If My.Settings.KeepLoggedIn Then
                _dbConnection.UserID = My.Settings.Username
                _dbConnection.Password = My.Settings.Password
            Else
                _dbConnection.Password = txt_Password.Text
                _dbConnection.UserID = txt_Username.Text
            End If

            Dim db = New Database(_dbConnection)

            Dim mainForm = New frm_Main(db)
            mainForm.Show()

            bw_SaveSettings.RunWorkerAsync()
        Catch exception As SqlException
            tss_UserFeedback.Text = "Username/Password was inccorect. Please try again."
            tss_UserFeedback.ForeColor = Color.Red
            Console.WriteLine("Failed to connect to database: " & exception.Message)
        End Try
    End Sub

    Private Sub reset()
        txt_Username.Focus()
        txt_Username.Clear()
        txt_Password.Clear()
        tss_UserFeedback.Text = "Please enter your log-in information"
        tss_UserFeedback.ForeColor = Color.Black
        chk_KeepLoggedIn.Checked = False
    End Sub

    Private Sub bw_SaveSettings_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_SaveSettings.DoWork
        If chk_KeepLoggedIn.Checked Then
            My.Settings.KeepLoggedIn = True
            My.Settings.Username = txt_Username.Text
            My.Settings.Password = txt_Password.Text
        End If
    End Sub

    Private Sub bw_SaveSettings_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_SaveSettings.RunWorkerCompleted
        Me.Hide()
        reset()
    End Sub

    Private Sub txt_Password_GotFocus(sender As Object, e As EventArgs) Handles txt_Password.GotFocus, txt_Password.Click
        txt_Password.Select(0, txt_Password.TextLength)
    End Sub

    Private Sub btn_CreateUser_Click(sender As Object, e As EventArgs) Handles btn_CreateUser.Click
        Dim createForm = New frm_CreateUser()
        createForm.show()
        Me.Hide()
    End Sub

    Private Sub btn_ChangePassword_Click(sender As Object, e As EventArgs) Handles btn_ChangePassword.Click
        Dim password = New frm_ChangePassword()
        password.show()
        Me.Hide()
    End Sub


    'creating a login for a user in the database
    'CREATE USER [NAME] WITH PASSWORD = [PASSWORD]

    'granting permissions in database
    'GRANT [PERMISSION-NAME] ON [OBJECT-NAME] TO [USER/ROLE-TYPE]

    'chaging the passwords
    'ALTER USER [USER] WITH PASSWORD = [NEW-PASSWORD]
End Class