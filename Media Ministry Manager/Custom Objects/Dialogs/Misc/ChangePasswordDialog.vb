Option Strict On

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports MediaMinistry.Helpers
Imports MediaMinistry.MediaMinistry.Exceptions

Public Class Frm_ChangePassword
    ReadOnly _connection As SqlConnectionStringBuilder = New SqlConnectionStringBuilder(My.Settings.masterConnectionString)

    Private Sub Btn_ChangePassword_Click(sender As Object, e As EventArgs) Handles btn_ChangePassword.Click
        Try
            If PasswordCheck() Then
                Dim adminInfo As AdminDialog = New AdminDialog()
                adminInfo.Show()

                Do Until My.Settings.AdminInfoRecieved
                    Console.WriteLine("Waiting for admin information")
                    Utils.Wait(1)
                Loop

                bw_LoadDatabase.RunWorkerAsync()

                Using db As New Database(_connection)
                    db.ChangePassword(txt_Username.Text, txt_Password.Text)
                End Using

                Console.WriteLine("Successfully Changed Password")
                bw_ResetAdminInfo.RunWorkerAsync()
            Else
                Throw New FormatException(String.Format("Password: {0}\nConfirm: {1}", txt_Password.Text, txt_ConfirmPassword.Text))
            End If
        Catch ex As SqlException
            Console.WriteLine("Failed to update user password: " & ex.Message)
        Catch passEx As PasswordMisMatchException
            tss_UserFeedback.Text = "Passwords did not match try again"
            tss_UserFeedback.ForeColor = Color.Red
            Console.WriteLine("Passwords did not match: " & passEx.Message)
        End Try
    End Sub

    Private Sub Bw_LoadDatabase_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_LoadDatabase.DoWork
        _connection.InitialCatalog = "master"
        _connection.UserID = My.Settings.AdminUser
        _connection.Password = My.Settings.AdminPass
    End Sub

    Private Function PasswordCheck() As Boolean
        Return txt_Password.Text.Equals(txt_ConfirmPassword.Text)
    End Function

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Frm_ChangePassword_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Frm_Login.Show()
    End Sub

    Private Sub Bw_ResetAdminInfo_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_ResetAdminInfo.DoWork
        My.Settings.AdminUser = ""
        My.Settings.AdminPass = ""
        My.Settings.AdminInfoRecieved = False
        My.Settings.Save()
    End Sub

    Private Sub Bw_ResetAdminInfo_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_ResetAdminInfo.RunWorkerCompleted
        Me.Close()
    End Sub

End Class