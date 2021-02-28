Option Strict On

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class AddCustomerDialog
    Private Const PhonePattern As String = "\d{3}-\d{3}-\d{4}"
    Private Const EmailPattern As String = "^[a-zA-Z0-9_!#$%&’*+/=?`{|}~^.-]+@[a-zA-Z0-9.-]+$"
    Private Const PhoneParenPattern As String = "(\d{3}) \d{3}-\d{4}"

    Private Sub Frm_PlaceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub Btn_AddNewCustomer_Click(sender As Object, e As EventArgs) Handles btn_AddNewCustomer.Click
        bw_AddCustomer.RunWorkerAsync()
        'Me.Hide()
    End Sub

    Private Sub Reset()
        txt_FirstName.Text = "First Name"
        txt_LastName.Text = "Last Name"
        txt_Street.Text = "Street"
        txt_City.Text = "City"
        cbx_State.Text = ""
        txt_Zip.Text = "Zip"
        txt_PhoneNumber.Text = "Phone Number"
        txt_Email.Text = "E-Mail"
        txt_FirstName.ForeColor = SystemColors.ControlLight
        txt_LastName.ForeColor = SystemColors.ControlLight
        txt_Street.ForeColor = SystemColors.ControlLight
        txt_City.ForeColor = SystemColors.ControlLight
        txt_Zip.ForeColor = SystemColors.ControlLight
        txt_PhoneNumber.ForeColor = SystemColors.ControlLight
        txt_Email.ForeColor = SystemColors.ControlLight
    End Sub

    Private Sub Txt_FirstName_GotFocus(sender As Object, e As EventArgs) Handles txt_FirstName.GotFocus
        If (txt_FirstName.Text.Equals("First Name")) Then
            ep_EmptyFields.Clear()
            txt_FirstName.Text = ""
            txt_FirstName.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub Txt_FirstName_LostFocus(sender As Object, e As EventArgs) Handles txt_FirstName.LostFocus
        If (txt_FirstName.Text.Equals("") Or txt_FirstName.Text.Equals(" ")) Then
            ep_EmptyFields.SetError(txt_FirstName, "Enter a First Name for the person")
            txt_FirstName.Text = "First Name"
            txt_FirstName.ForeColor = SystemColors.ControlLight
        End If
    End Sub

    Private Sub Txt_LastName_GotFocus(sender As Object, e As EventArgs) Handles txt_LastName.GotFocus
        If (txt_LastName.Text.Equals("Last Name")) Then
            ep_EmptyFields.Clear()
            txt_LastName.Text = ""
            txt_LastName.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub Txt_LastName_LostFocus(sender As Object, e As EventArgs) Handles txt_LastName.LostFocus
        If (txt_LastName.Text.Equals("") Or txt_LastName.Text.Equals(" ")) Then
            ep_EmptyFields.SetError(txt_LastName, "Enter a Last Name for the person")
            txt_LastName.Text = "Last Name"
            txt_LastName.ForeColor = SystemColors.ControlLight
        End If
    End Sub

    Private Sub Txt_Street_GotFocus(sender As Object, e As EventArgs) Handles txt_Street.GotFocus
        If (txt_Street.Text.Equals("Street")) Then
            txt_Street.Text = ""
            txt_Street.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub Txt_Street_LostFocus(sender As Object, e As EventArgs) Handles txt_Street.LostFocus
        If (txt_Street.Text.Equals("") Or txt_Street.Text.Equals(" ")) Then
            txt_Street.Text = "Street"
            txt_Street.ForeColor = SystemColors.ControlLight
        End If
    End Sub

    Private Sub Txt_City_GotFocus(sender As Object, e As EventArgs) Handles txt_City.GotFocus
        If (txt_City.Text.Equals("City")) Then
            txt_City.Text = ""
            txt_City.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub Txt_City_LostFocus(sender As Object, e As EventArgs) Handles txt_City.LostFocus
        If (txt_City.Text.Equals("") Or txt_City.Text.Equals(" ")) Then
            txt_City.Text = "City"
            txt_City.ForeColor = SystemColors.ControlLight
        End If
    End Sub

    Private Sub Txt_Zip_GotFocus(sender As Object, e As EventArgs) Handles txt_Zip.GotFocus
        If (txt_Zip.Text.Equals("Zip")) Then
            txt_Zip.Text = ""
            txt_Zip.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub Txt_Zip_LostFocus(sender As Object, e As EventArgs) Handles txt_Zip.LostFocus
        If (txt_Zip.Text.Equals("") Or txt_Zip.Text.Equals(" ")) Then
            txt_Zip.Text = "Zip"
            txt_Zip.ForeColor = SystemColors.ControlLight
        End If
    End Sub

    Private Sub Txt_PhoneNumber_GotFocus(sender As Object, e As EventArgs) Handles txt_PhoneNumber.GotFocus
        ep_EmptyFields.Clear()
        If (txt_PhoneNumber.Text.Equals("Phone Number")) Then
            txt_PhoneNumber.Text = ""
            txt_PhoneNumber.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub Txt_PhoneNumber_LostFocus(sender As Object, e As EventArgs) Handles txt_PhoneNumber.LostFocus
        If (txt_PhoneNumber.Text.Equals("") Or txt_PhoneNumber.Text.Equals(" ")) Then
            ep_EmptyFields.SetError(txt_PhoneNumber, "Enter a phone number for the person")
            txt_PhoneNumber.Text = "Phone Number"
            txt_PhoneNumber.ForeColor = SystemColors.ControlLight
        End If
    End Sub

    Private Sub Txt_Email_GotFocus(sender As Object, e As EventArgs) Handles txt_Email.GotFocus
        If (txt_Email.Text.Equals("E-Mail")) Then
            txt_Email.Text = ""
            txt_Email.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub Txt_Email_LostFocus(sender As Object, e As EventArgs) Handles txt_Email.LostFocus
        If (txt_Email.Text.Equals("") Or txt_Email.Text.Equals(" ")) Then
            txt_Email.Text = "E-Mail"
            txt_Email.ForeColor = SystemColors.ControlLight
        End If
    End Sub

    Private Function ValidText() As Boolean
        If ((txt_FirstName.Text.Equals("First Name") Or txt_LastName.Text.Equals("Last Name") Or
            txt_PhoneNumber.Text.Equals("Phone Number")) And (Regex.IsMatch(txt_PhoneNumber.Text, PhonePattern) Or Regex.IsMatch(txt_PhoneNumber.Text, PhoneParenPattern))) Then
            tss_AddCustomer.ForeColor = Color.Red
            tss_AddCustomer.Text = "Please enter the required information for the person"
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Txt_FirstName_TextChanged(sender As Object, e As EventArgs) Handles txt_FirstName.TextChanged
        If (Not txt_FirstName.Text.Equals("First Name")) Then
            txt_FirstName.Text = txt_FirstName.Text.ToUpper
            txt_FirstName.SelectionStart = txt_FirstName.Text.Length + 1
        End If
    End Sub

    Private Sub Txt_LastName_TextChanged(sender As Object, e As EventArgs) Handles txt_LastName.TextChanged
        If (Not txt_LastName.Text.Equals("Last Name")) Then
            txt_LastName.Text = txt_LastName.Text.ToUpper
            txt_LastName.SelectionStart = txt_LastName.Text.Length + 1
        End If
    End Sub

    Private Sub Txt_Street_TextChanged(sender As Object, e As EventArgs) Handles txt_Street.TextChanged
        If (Not txt_Street.Text.Equals("Street")) Then
            txt_Street.Text = txt_Street.Text.ToUpper
            txt_Street.SelectionStart = txt_Street.Text.Length + 1
        End If
    End Sub

    Private Sub Txt_City_TextChanged(sender As Object, e As EventArgs) Handles txt_City.TextChanged
        If (Not txt_City.Text.Equals("City")) Then
            txt_City.Text = txt_City.Text.ToUpper
            txt_City.SelectionStart = txt_City.Text.Length + 1
        End If
    End Sub

    Private Sub Cbx_State_TextChanged(sender As Object, e As EventArgs) Handles cbx_State.TextChanged
        cbx_State.Text = cbx_State.Text.ToUpper
        cbx_State.SelectionStart = cbx_State.Text.Length + 1
    End Sub

    Private Sub Txt_Email_TextChanged(sender As Object, e As EventArgs) Handles txt_Email.TextChanged
        If (Not txt_Email.Text.Equals("E-Mail")) Then
            txt_Email.Text = txt_Email.Text.ToUpper
            txt_Email.SelectionStart = txt_Email.Text.Length + 1
        End If
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Bw_AddCustomer_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_AddCustomer.DoWork
        Dim fName, lName, addrStreet, addrCity, addrState, addrZip, phone, email As String

        If (ValidText()) Then
            'Get the required text fields
            fName = txt_FirstName.Text
            lName = txt_LastName.Text
            phone = txt_PhoneNumber.Text

            If (txt_Street.Text.Equals("Street") Or txt_City.Text.Equals("City") Or txt_Zip.Text.Equals("Zip")) Then
                addrStreet = ""
                addrCity = ""
                addrState = ""
                addrZip = ""
            Else
                addrStreet = txt_Street.Text
                addrCity = txt_City.Text
                addrState = cbx_State.Text
                addrZip = txt_Zip.Text
            End If

            If Regex.IsMatch(txt_Email.Text, EmailPattern) Then
                email = txt_Email.Text
            Else
                email = ""
            End If

            Try
                Using db As New Database
                    db.AddNewCustomer(fName, lName, addrStreet, addrCity, addrState, addrZip, phone, email)
                End Using

                DialogResult = DialogResult.OK
            Catch ex As SqlException
                DialogResult = DialogResult.Retry
                Console.WriteLine(ex.Message)
                tss_AddCustomer.ForeColor = Color.Red
                tss_AddCustomer.Text = "This person might already be in the system. Please try again."
            End Try
        End If
    End Sub

    Private Sub Bw_AddCustomer_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_AddCustomer.RunWorkerCompleted
        If DialogResult = DialogResult.OK Then
            Me.Close()
        End If
    End Sub
End Class