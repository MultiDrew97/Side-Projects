﻿Option Strict On

Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions.Regex

Public Class frm_AddNewCustomer
    Private _db As Database
    Private sendingForm As Form
    Private phonePattern As String = "(\d{3})-\d{3}-\d{4}"
    'Private phoneParenPattern As String = "(\d{3})-\d{3}-\d{4}"

    Public Sub New(ByRef database As Database, parentForm As Form)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _db = database
        sendingForm = parentForm
    End Sub

    Private Sub frm_PlaceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub

    Private Sub Btn_AddNewCustomer_Click(sender As Object, e As EventArgs) Handles btn_AddNewCustomer.Click
        Dim fName, lName, addrStreet, addrCity, addrState, addrZip, phone, paymentPreference, email As String

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

            If (txt_Email.Text.Equals("E-Mail")) Then
                email = ""
            Else
                email = txt_Email.Text
            End If

            If (cbx_PaymentType.Text.Equals("Select One...")) Then
                paymentPreference = ""
            Else
                paymentPreference = cbx_PaymentType.Text
            End If

            Try
                AddNewCustomer(fName, lName, addrStreet, addrCity, addrState, addrZip, phone, email, paymentPreference)
                Me.Close()
            Catch ex As SqlException
                tss_AddCustomer.ForeColor = Color.Red
                tss_AddCustomer.Text = "This person might already be in the system. Please try again."
            End Try
        End If
    End Sub

    Private Sub AddNewCustomer(fName As String, lName As String,
                         addrStreet As String, addrCity As String, addrState As String, addrZip As String,
                         phoneNumber As String, email As String, paymentPreference As String)

        _db.AddNewCustomer(fName, lName, addrStreet, addrCity, addrState, addrZip, phoneNumber, email, paymentPreference)
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
            CType(sendingForm, frm_DisplayCustomers).refresh()
        Catch ex As ApplicationException
        Finally
            sendingForm.Show()
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
        If (String.IsNullOrEmpty(txt_FirstName.Text)) Then
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
        If (String.IsNullOrEmpty(txt_LastName.Text)) Then
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
        If (String.IsNullOrEmpty(txt_Street.Text)) Then
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
        If (String.IsNullOrEmpty(txt_City.Text)) Then
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
        If (String.IsNullOrEmpty(txt_Zip.Text)) Then
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
        If (String.IsNullOrEmpty(txt_PhoneNumber.Text)) Then
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
        If (String.IsNullOrEmpty(txt_Email.Text)) Then
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

    'Private Sub cbx_State_TextChanged(sender As Object, e As EventArgs) Handles cbx_State.TextChanged
    '    cbx_State.Text = cbx_State.Text.ToUpper
    '    cbx_State.SelectionStart = cbx_State.Text.Length + 1
    'End Sub
End Class