Option Strict On
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frm_CreateUser
    Dim db As Database
    ReadOnly _connection As SqlConnectionStringBuilder = New SqlConnectionStringBuilder(My.Settings.masterConnectionString)
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_Create_Click(sender As Object, e As EventArgs) Handles btn_Create.Click
        Try
            If passwordCheck() Then
                'Dim adminUser = InputBox("Enter admin username", "Enter admin password")

                'Console.WriteLine(adminUser)
                'Dim adminPassword = InputBox("Enter admin")
                Dim adminInfo As AdminSignIn = New AdminSignIn()
                adminInfo.Show()

                Do Until My.Settings.AdminInfoRecieved
                    Console.WriteLine("Waiting for admin information")
                    wait(1)
                Loop

                _connection.UserID = My.Settings.AdminUser
                _connection.Password = My.Settings.AdminPass
                db.CreateUser(txt_Username.Text, txt_Password.Text)

                bw_ClearAdminInfo.RunWorkerAsync()
            Else
                Throw New Exception(String.Format("Password: {0}\nConfirm{1}", txt_Password.Text, txt_ConfirmPassword.Text))
            End If
        Catch exception As SqlException
            Console.WriteLine("Could not create user: " & exception.Message)
        Catch passwordException As Exception
            tss_UserFeedback.Text = "Passwords did not match try again"
            tss_UserFeedback.ForeColor = Color.Red
            Console.WriteLine("Passwords didn't match: " & passwordException.Message)
        End Try
    End Sub

    Private Sub frm_CreateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _connection.InitialCatalog = "master"
    End Sub

    Private Sub bw_LoadDatabase_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_ClearAdminInfo.DoWork
        My.Settings.AdminUser = ""
        My.Settings.AdminPass = ""
        My.Settings.AdminInfoRecieved = False
        My.Settings.Save()
    End Sub

    Private Function passwordCheck() As Boolean
        Return txt_Password.Text.Equals(txt_ConfirmPassword.Text)
    End Function

    Private Sub frm_CreateUser_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If db IsNot Nothing Then
            'if there is a connection open, then close it
            db.Close()
        End If

        frm_Login.Show()
    End Sub

    Private Sub wait(ByVal seconds As Integer)
        'found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub bw_LoadDatabase_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_ClearAdminInfo.RunWorkerCompleted
        Me.Close()
    End Sub
End Class