Option Strict On

#Region "Imports"
Imports System.Data.SqlClient
Imports Media_Ministry.Utils
#End Region

Public Class AdminSignIn
#Region "Globals"

#End Region

#Region "Buttons"
    Private Sub btn_ShowPassword_Click(sender As Object, e As EventArgs) Handles btn_ShowPassword.Click
        If txt_Password.UseSystemPasswordChar Then
            txt_Password.UseSystemPasswordChar = False
        Else
            txt_Password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            If txt_Username.Text <> "" Then
                My.Settings.AdminUser = txt_Username.Text

                If txt_Password.Text <> "" Then
                    My.Settings.AdminPass = txt_Password.Text

                    If checkCreds(txt_Username.Text, txt_Password.Text) Then
                        My.Settings.AdminInfoRecieved = True
                        Me.Close()
                    End If
                Else
                    tss_Info.Text = "Please enter the password"
                    tss_Info.ForeColor = Color.Red
                    Throw New Exception("Password was left empty")
                End If
            Else
                tss_Info.Text = "Please enter the username"
                tss_Info.ForeColor = Color.Red
                Throw New Exception("Username was left empty")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
#End Region

#Region "Utils"
    Private Function checkCreds(username As String, password As String) As Boolean
        Try
            Using db = New Database(username, password)
            End Using

            Return True
        Catch e As SqlException
            Console.WriteLine(e.Message)
            Return False
        End Try
    End Function
#End Region
End Class