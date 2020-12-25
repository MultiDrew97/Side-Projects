Imports MimeKit

Namespace Types
    Public Class Customer
        Inherits Person

        Public Property PhoneNumber() As String
        Public Property Address() As Address
        Public Property EmailAddress() As MailboxAddress
        Public Property JoinDate() As Date

        Public Sub New(firstName As String, lastName As String, phone As String, street As String, city As String, state As String, zip As String, email As String, joinDate As String)
            MyBase.New(firstName, lastName)
            Me.PhoneNumber = phone
            Me.Address = New Address(street, city, state, zip)
            Me.EmailAddress = MailboxAddress.Parse(email)
            Me.JoinDate = Date.Parse(joinDate)
        End Sub
    End Class
End Namespace
