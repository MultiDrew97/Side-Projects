Option Strict On

Imports System.Text.RegularExpressions.Regex

Public Class frm_AddNewCustomer
    Property Opener As Form
    Private phonePattern As String = "(\d{3})-\d{3}-\d{4}"
    'Private phoneParenPattern As String = "(\d{3})-\d{3}-\d{4}"

    Private Sub frm_PlaceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub

    Private Sub Btn_AddNewCustomer_Click(sender As Object, e As EventArgs) Handles btn_AddNewCustomer.Click
        Dim fName, lName, addrStreet, addrCity, addrState, addrZip, phone, payment, email As String

        If (validText()) Then
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

            email = If(txt_Email.Text.Equals("E-Mail"), "", txt_Email.Text)
            payment = If(cbx_PaymentType.SelectedText.Equals("Select One..."), "", cbx_PaymentType.SelectedText)

            Try
                Using db As New Database(My.Settings.Username, My.Settings.Password)
                    db.AddNewCustomer(fName, lName, addrStreet, addrCity, addrState, addrZip, phone, email, payment)
                End Using

                Me.Close()
            Catch ex As SqlException
                Console.WriteLine(ex.Message)
                tss_AddCustomer.ForeColor = Color.Red
                tss_AddCustomer.Text = "This person might already be in the system. Please try again."
            End Try
        End If
    End Sub

    Private Sub reset()
        txt_FirstName.Text = "First Name"
        txt_LastName.Text = "Last Name"
        txt_Street.Text = "Street"
        txt_City.Text = "City"
        cbx_State.Text = ""
        txt_Zip.Text = "Zip"
        txt_PhoneNumber.Text = "Phone Number"
        txt_Email.Text = "E-Mail"
        cbx_PaymentType.Text = "Select One..."
        txt_FirstName.ForeColor = SystemColors.ControlLight
        txt_LastName.ForeColor = SystemColors.ControlLight
        txt_Street.ForeColor = SystemColors.ControlLight
        txt_City.ForeColor = SystemColors.ControlLight
        txt_Zip.ForeColor = SystemColors.ControlLight
        txt_PhoneNumber.ForeColor = SystemColors.ControlLight
        txt_Email.ForeColor = SystemColors.ControlLight
    End Sub

    Private Sub frm_AddNewCustomer_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Try
            CType(Opener, frm_DisplayCustomers).refresh()
        Catch ex As ApplicationException
        Finally
            Opener.Show()
        End Try
    End Sub

    Private Sub txt_FirstName_GotFocus(sender As Object, e As EventArgs) Handles txt_FirstName.GotFocus
        If (txt_FirstName.Text.Equals("First Name")) Then
            ep_EmptyFields.Clear()
            txt_FirstName.Text = ""
            txt_FirstName.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub txt_FirstName_LostFocus(sender As Object, e As EventArgs) Handles txt_FirstName.LostFocus
        If (txt_FirstName.Text.Equals("") Or txt_FirstName.Text.Equals(" ")) Then
            ep_EmptyFields.SetError(txt_FirstName, "Enter a First Name for the person")
            txt_FirstName.Text = "First Name"
            txt_FirstName.ForeColor = SystemColors.ControlLight
        End If
    End Sub

    Private Sub txt_LastName_GotFocus(sender As Object, e As EventArgs) Handles txt_LastName.GotFocus
        If (txt_LastName.Text.Equals("Last Name")) Then
            ep_EmptyFields.Clear()
            txt_LastName.Text = ""
            txt_LastName.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub txt_LastName_LostFocus(sender As Object, e As EventArgs) Handles txt_LastName.LostFocus
        If (txt_LastName.Text.Equals("") Or txt_LastName.Text.Equals(" ")) Then
            ep_EmptyFields.SetError(txt_LastName, "Enter a Last Name for the person")
            txt_LastName.Text = "Last Name"
            txt_LastName.ForeColor = SystemColors.ControlLight
        End If
    End Sub

    Private Sub txt_Street_GotFocus(sender As Object, e As EventArgs) Handles txt_Street.GotFocus
        If (txt_Street.Text.Equals("Street")) Then
            txt_Street.Text = ""
            txt_Street.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub txt_Street_LostFocus(sender As Object, e As EventArgs) Handles txt_Street.LostFocus
        If (txt_Street.Text.Equals("") Or txt_Street.Text.Equals(" ")) Then
            txt_Street.Text = "Street"
            txt_Street.ForeColor = SystemColors.ControlLight
        End If
    End Sub

    Private Sub txt_City_GotFocus(sender As Object, e As EventArgs) Handles txt_City.GotFocus
        If (txt_City.Text.Equals("City")) Then
            txt_City.Text = ""
            txt_City.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub txt_City_LostFocus(sender As Object, e As EventArgs) Handles txt_City.LostFocus
        If (txt_City.Text.Equals("") Or txt_City.Text.Equals(" ")) Then
            txt_City.Text = "City"
            txt_City.ForeColor = SystemColors.ControlLight
        End If
    End Sub

    Private Sub txt_Zip_GotFocus(sender As Object, e As EventArgs) Handles txt_Zip.GotFocus
        If (txt_Zip.Text.Equals("Zip")) Then
            txt_Zip.Text = ""
            txt_Zip.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub txt_Zip_LostFocus(sender As Object, e As EventArgs) Handles txt_Zip.LostFocus
        If (txt_Zip.Text.Equals("") Or txt_Zip.Text.Equals(" ")) Then
            txt_Zip.Text = "Zip"
            txt_Zip.ForeColor = SystemColors.ControlLight
        End If
    End Sub

    Private Sub txt_PhoneNumber_GotFocus(sender As Object, e As EventArgs) Handles txt_PhoneNumber.GotFocus
        ep_EmptyFields.Clear()
        If (txt_PhoneNumber.Text.Equals("Phone Number")) Then
            txt_PhoneNumber.Text = ""
            txt_PhoneNumber.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub txt_PhoneNumber_LostFocus(sender As Object, e As EventArgs) Handles txt_PhoneNumber.LostFocus
        If (txt_PhoneNumber.Text.Equals("") Or txt_PhoneNumber.Text.Equals(" ")) Then
            ep_EmptyFields.SetError(txt_PhoneNumber, "Enter a phone number for the person")
            txt_PhoneNumber.Text = "Phone Number"
            txt_PhoneNumber.ForeColor = SystemColors.ControlLight
        End If
    End Sub

    Private Sub txt_Email_GotFocus(sender As Object, e As EventArgs) Handles txt_Email.GotFocus
        If (txt_Email.Text.Equals("E-Mail")) Then
            txt_Email.Text = ""
            txt_Email.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub txt_Email_LostFocus(sender As Object, e As EventArgs) Handles txt_Email.LostFocus
        If (txt_Email.Text.Equals("") Or txt_Email.Text.Equals(" ")) Then
            txt_Email.Text = "E-Mail"
            txt_Email.ForeColor = SystemColors.ControlLight
        End If
    End Sub

    Private Function validText() As Boolean
        If ((txt_FirstName.Text.Equals("First Name") Or txt_LastName.Text.Equals("Last Name") Or
            txt_PhoneNumber.Text.Equals("Phone Number")) And IsMatch(txt_PhoneNumber.Text, phonePattern)) Then
            tss_AddCustomer.ForeColor = Color.Red
            tss_AddCustomer.Text = "Please enter the required information for the person"
            Return False
        Else
            Return True
        End If
        '(IsMatch(txt_PhoneNumber.Text, phonePattern) Or IsMatch(txt_PhoneNumber.Text, phoneParenPattern))
    End Function

    'Private Function isUniquePerson(phoneNumber As String, fName As String, lName As String) As Boolean
    '    Dim table As String
    '    table = db.GetOrders(phoneNumber, fName, lName)
    '    Console.WriteLine(Not table.Equals(""))
    '    Return table.Equals("")
    'End Function

    Private Sub txt_FirstName_TextChanged(sender As Object, e As EventArgs) Handles txt_FirstName.TextChanged
        If (Not txt_FirstName.Text.Equals("First Name")) Then
            txt_FirstName.Text = txt_FirstName.Text.ToUpper
            txt_FirstName.SelectionStart = txt_FirstName.Text.Length + 1
        End If
    End Sub

    Private Sub txt_LastName_TextChanged(sender As Object, e As EventArgs) Handles txt_LastName.TextChanged
        If (Not txt_LastName.Text.Equals("Last Name")) Then
            txt_LastName.Text = txt_LastName.Text.ToUpper
            txt_LastName.SelectionStart = txt_LastName.Text.Length + 1
        End If
    End Sub

    Private Sub txt_Street_TextChanged(sender As Object, e As EventArgs) Handles txt_Street.TextChanged
        If (Not txt_Street.Text.Equals("Street")) Then
            txt_Street.Text = txt_Street.Text.ToUpper
            txt_Street.SelectionStart = txt_Street.Text.Length + 1
        End If
    End Sub

    Private Sub txt_City_TextChanged(sender As Object, e As EventArgs) Handles txt_City.TextChanged
        If (Not txt_City.Text.Equals("City")) Then
            txt_City.Text = txt_City.Text.ToUpper
            txt_City.SelectionStart = txt_City.Text.Length + 1
        End If
    End Sub

    Private Sub cbx_State_TextChanged(sender As Object, e As EventArgs) Handles cbx_State.TextChanged
        cbx_State.Text = cbx_State.Text.ToUpper
        cbx_State.SelectionStart = cbx_State.Text.Length + 1
    End Sub

    Private Sub txt_Email_TextChanged(sender As Object, e As EventArgs) Handles txt_Email.TextChanged
        If (Not txt_Email.Text.Equals("E-Mail")) Then
            txt_Email.Text = txt_Email.Text.ToUpper
            txt_Email.SelectionStart = txt_Email.Text.Length + 1
        End If
    End Sub

End Class