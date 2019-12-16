Option Strict On
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frm_ChangePassword
    Dim db As Database
    ReadOnly _connection As SqlConnectionStringBuilder = New SqlConnectionStringBuilder()
    Private Sub btn_ChangePassword_Click(sender As Object, e As EventArgs) Handles btn_ChangePassword.Click
        Try
            If passwordCheck() Then
                Dim adminUser = InputBox("Enter admin username", "Enter admin password")

                Console.WriteLine(adminUser)
                Dim adminPassword = InputBox("Enter admin")


                _connection.UserID = adminUser
                _connection.Password = adminPassword
                db.ChangePassword(txt_Username.Text, txt_Password.Text)
                Me.Close()
            Else
                Throw New Exception(String.Format("Password: {0}\nConfirm: {1}",
                                                  txt_Password.Text, txt_ConfirmPassword.Text))
            End If
        Catch ex As SqlException
            Console.WriteLine("Failed to update user password: " & ex.Message)
        Catch passEx As Exception
            tss_UserFeedback.Text = "Passwords did not match try again"
            tss_UserFeedback.ForeColor = Color.Red
            Console.WriteLine("Passwords did not match: " & passEx.Message)
        End Try
    End Sub

    Private Sub frm_ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bw_LoadDatabase.RunWorkerAsync()
    End Sub

    Private Sub bw_LoadDatabase_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_LoadDatabase.DoWork
        _connection.PersistSecurityInfo = My.Settings.PersistSecurityInfo
        _connection.DataSource = My.Settings.DataSource
        _connection.InitialCatalog = My.Settings.InitalCatalog
    End Sub

    Private Function passwordCheck() As Boolean
        Return txt_Password.Text.Equals(txt_ConfirmPassword.Text)
    End Function

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_ChangePassword_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        db.Close()
        frm_Login.Show()
    End Sub
End Class