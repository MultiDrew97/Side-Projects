Option Strict On

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frm_UpdatePhoneNumber
    Private ReadOnly db As Database
    Private ReadOnly validNumberFormat As String = "\d{3}-\d{3}-\d{4}"
    Private ReadOnly display As Frm_DisplayCustomers

    Private Sub UpdatePhoneNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
        Me.CUSTOMERSTableAdapter.Fill(Me.MediaMinistryDataSet.CUSTOMERS)

    End Sub

    Private Sub Btn_UpdatePhone_Click(sender As Object, e As EventArgs) Handles btn_UpdatePhone.Click
        If (ValidNumber()) Then
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
        RefreshCustomers()
    End Sub

    Private Sub Txt_NewNumber_GotFocus(sender As Object, e As EventArgs) Handles txt_NewNumber.GotFocus
        If txt_NewNumber.Text.Equals("New Number") Then
            txt_NewNumber.Text = ""
            txt_NewNumber.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub Txt_NewNumber_LostFocus(sender As Object, e As EventArgs) Handles txt_NewNumber.LostFocus
        If (txt_NewNumber.Text.Equals("") Or txt_NewNumber.Text.Equals(" ")) Then
            txt_NewNumber.ForeColor = SystemColors.ControlLight
            txt_NewNumber.Text = "New Number"
        End If
    End Sub

    Public Function ValidNumber() As Boolean
        Return Regex.IsMatch(txt_NewNumber.Text, validNumberFormat)
    End Function

    Private Sub Cbx_FirstName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_FirstName.SelectedIndexChanged
        If Not cbx_OldNumber.SelectedIndex.Equals(cbx_FirstName.SelectedIndex) Then
            cbx_OldNumber.SelectedIndex = cbx_FirstName.SelectedIndex
        End If
    End Sub

    Private Sub Cbx_OldNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_OldNumber.SelectedIndexChanged
        If Not cbx_OldNumber.SelectedIndex.Equals(cbx_FirstName.SelectedIndex) Then
            cbx_FirstName.SelectedIndex = cbx_OldNumber.SelectedIndex
        End If
    End Sub

    Private Sub RefreshCustomers()
        For Each form As Form In My.Application.OpenForms
            If form.Name.Equals("frm_viewcustomers", StringComparison.OrdinalIgnoreCase) Then
                CType(form, Frm_DisplayCustomers).refresh()
                Exit For
            End If
        Next
    End Sub
End Class