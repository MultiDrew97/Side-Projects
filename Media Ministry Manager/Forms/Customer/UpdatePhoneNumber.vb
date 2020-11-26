Option Strict On

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frm_UpdatePhoneNumber
    Private validNumberFormat As String = "\d{3}-\d{3}-\d{4}"
    Property display As frm_DisplayCustomers

    Private Sub UpdatePhoneNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
        Me.CUSTOMERSTableAdapter.Fill(Me.Media_MinistryDataSet.CUSTOMERS)

    End Sub

    Private Sub btn_UpdatePhone_Click(sender As Object, e As EventArgs) Handles btn_UpdatePhone.Click
        If (validNumber()) Then
            Dim newNumber = txt_NewNumber.Text
            Dim oldNumber = cbx_FirstName.Text

            Try
                Using db = New Database(My.Settings.Username, My.Settings.Password)
                    db.UpdatePhone(newNumber, oldNumber)
                    tss_UpdatePhone.Text = String.Format("{0}'s number has been updated", cbx_FirstName.SelectedItem)
                End Using
            Catch exception As SqlException
                tss_UpdatePhone.ForeColor = Color.Red
                tss_UpdatePhone.Text = "Number could not be updated. Please try again."
                Console.WriteLine("Failed to update phone number: " & exception.Message)
            End Try
        Else
            tss_UpdatePhone.ForeColor = Color.Red
            tss_UpdatePhone.Text = "The new number is not in the correct format. Please try again."
        End If
    End Sub

    Private Sub UpdatePhoneNumber_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        display.refresh()
        display.Show()
    End Sub

    Private Sub txt_NewNumber_GotFocus(sender As Object, e As EventArgs) Handles txt_NewNumber.GotFocus
        If txt_NewNumber.Text.Equals("New Number") Then
            txt_NewNumber.Text = ""
            txt_NewNumber.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub txt_NewNumber_LostFocus(sender As Object, e As EventArgs) Handles txt_NewNumber.LostFocus
        If (txt_NewNumber.Text.Equals("") Or txt_NewNumber.Text.Equals(" ")) Then
            txt_NewNumber.ForeColor = SystemColors.ControlLight
            txt_NewNumber.Text = "New Number"
        End If
    End Sub

    Public Function validNumber() As Boolean
        Return Regex.IsMatch(txt_NewNumber.Text, validNumberFormat)
    End Function

    Private Sub cbx_FirstName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_FirstName.SelectedIndexChanged
        If Not cbx_OldNumber.SelectedIndex.Equals(cbx_FirstName.SelectedIndex) Then
            cbx_OldNumber.SelectedIndex = cbx_FirstName.SelectedIndex
        End If
    End Sub

    Private Sub cbx_OldNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_OldNumber.SelectedIndexChanged
        If Not cbx_OldNumber.SelectedIndex.Equals(cbx_FirstName.SelectedIndex) Then
            cbx_FirstName.SelectedIndex = cbx_OldNumber.SelectedIndex
        End If
    End Sub

End Class