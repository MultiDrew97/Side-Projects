Option Strict On

Imports System.Data.SqlClient

Public Class AdminInfoDialog
    Shared Property Username As String
    Shared Property Password As String


    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            If txt_Username.Text <> "" Then
                Username = txt_Username.Text

                If pf_Password.txtPassword.Text <> "" Then
                    Password = pf_Password.txtPassword.Text

                    If CheckCreds() Then
                        DialogResult = DialogResult.OK
                        Me.Close()
                    Else
                        MessageBox.Show("Credentials were incorrect. Please re-enter them and try again.", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    Throw New MissingFieldException("Password was left empty")
                End If
            Else
                Throw New MissingFieldException("Username was left empty")
            End If
        Catch ex As MissingFieldException
            MessageBox.Show(ex.Message, "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AdminDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Clear()
    End Sub

    Private Function CheckCreds() As Boolean
        Try
            Using db As New Database(Username, Password)
                Return True
            End Using
        Catch ex As SqlException
            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Sub Clear()
        Username = ""
        Password = ""
    End Sub

End Class