Option Strict On

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports MediaMinistry.Helpers
Imports MediaMinistry.MediaMinistry.Exceptions

Public Class Frm_CreateUser
    ReadOnly db As Database
    ReadOnly _connection As SqlConnectionStringBuilder = New SqlConnectionStringBuilder(My.Settings.masterConnectionString)

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Btn_Create_Click(sender As Object, e As EventArgs) Handles btn_Create.Click
        Try
            If PasswordCheck() Then
                'Console.WriteLine(adminUser)
                Dim username As String = InputBox("Enter admin username", "Admin Login")
                Dim password As String = InputBox("Enter admin password", "Admin Login")
                Dim adminInfo As AdminSignIn = New AdminSignIn()
                adminInfo.Show()

                Do Until My.Settings.AdminInfoRecieved
                    Console.WriteLine("Waiting for admin information")
                    Utils.Wait(1)
                Loop

                _connection.UserID = My.Settings.AdminUser
                _connection.Password = My.Settings.AdminPass

                Using db As New Database(_connection)
                    db.CreateUser(txt_Username.Text, txt_Password.Text)
                End Using

                bw_ClearAdminInfo.RunWorkerAsync()
            Else
                Throw New PasswordMisMatchException(String.Format("Password: {0}\nConfirm{1}", txt_Password.Text, txt_ConfirmPassword.Text))
            End If
        Catch exception As SqlException
            Console.WriteLine("Could not create user: " & exception.Message)
        Catch passException As PasswordMisMatchException
            tss_UserFeedback.Text = "Passwords did not match try again"
            tss_UserFeedback.ForeColor = Color.Red
            Console.WriteLine("Passwords didn't match: " & passException.Message)
        End Try
    End Sub

    Private Sub Frm_CreateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _connection.InitialCatalog = "master"
    End Sub

    Private Sub Bw_LoadDatabase_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_ClearAdminInfo.DoWork
        My.Settings.AdminUser = ""
        My.Settings.AdminPass = ""
        My.Settings.AdminInfoRecieved = False
        My.Settings.Save()
    End Sub

    Private Function PasswordCheck() As Boolean
        Return txt_Password.Text.Equals(txt_ConfirmPassword.Text)
    End Function

    Private Sub Frm_CreateUser_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim opened As Boolean = False

        For Each form As Form In My.Application.OpenForms
            If form.Name.Equals("frm_login", StringComparison.OrdinalIgnoreCase) Then
                form.Show()
                opened = True
                Exit For
            End If
        Next
        If Not opened Then
            Dim frm As New Frm_Login()
            frm.Show()
        End If
    End Sub

    Private Sub Bw_LoadDatabase_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_ClearAdminInfo.RunWorkerCompleted
        Me.Close()
    End Sub

End Class