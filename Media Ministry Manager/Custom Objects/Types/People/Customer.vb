Namespace Types
    Public Class Customer
        Inherits Person
        Private Const EmailPattern As String = "^[a-zA-Z0-9_!#$%&’*+/=?`{|}~^.-]+@[a-zA-Z0-9.-]+$"
        Public Property PhoneNumber As String
        Public Property Address As Address
        Public Property EmailAddress As MimeKit.MailboxAddress
        Public Property JoinDate As Date

        Public Sub New(firstName As String, lastName As String, street As String, city As String, state As String, zip As String, phone As String, email As String, Optional joinDate As String = "")
            MyBase.New(firstName, lastName)
            Me.PhoneNumber = phone
            Me.Address = New Address(street, city, state, zip)
            If ValidEmail(email) Then
                Me.EmailAddress = New MimeKit.MailboxAddress(Name, email)
            Else
                'TODO: DO I throw an error here? Or let the customer be created without an email?
            End If

            If Not String.IsNullOrEmpty(joinDate) Then
                Me.JoinDate = Date.Parse(joinDate)
            End If
        End Sub

        Private Function ValidEmail(email As String) As Boolean
            Return Text.RegularExpressions.Regex.IsMatch(email, EmailPattern)
        End Function
    End Class
End Namespace
