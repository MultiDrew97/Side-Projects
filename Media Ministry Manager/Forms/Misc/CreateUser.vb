Option Strict On

#Region "Imports"
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Media_Ministry.Utils
#End Region

Public Class frm_CreateUser

#Region "Globals"
    ReadOnly _conn As SqlConnectionStringBuilder = New SqlConnectionStringBuilder(My.Settings.masterConnection)
#End Region

#Region "Form Subs"
    Private Sub frm_CreateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _conn.InitialCatalog = "master"
    End Sub

    Private Sub frm_CreateUser_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frm_Login.Show()
    End Sub
#End Region

#Region "Buttons"
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

                _conn.UserID = My.Settings.AdminUser
                _conn.Password = My.Settings.AdminPass

                Using db = New Database(_conn)
                    db.CreateUser(txt_Username.Text, txt_Password.Text)
                End Using

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
#End Region

#Region "Background Workers"
    Private Sub bw_ClearAdminInfo_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_ClearAdminInfo.DoWork
        My.Settings.AdminUser = ""
        My.Settings.AdminPass = ""
        My.Settings.AdminInfoRecieved = False
        My.Settings.Save()
    End Sub

    Private Sub bw_ClearAdminInfo_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_ClearAdminInfo.RunWorkerCompleted
        Me.Close()
    End Sub
#End Region

#Region "Utils"
    Private Function passwordCheck() As Boolean
        Return txt_Password.Text.Equals(txt_ConfirmPassword.Text)
    End Function

    Private Sub wait(ByVal seconds As Integer)
        'found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
#End Region
End Class