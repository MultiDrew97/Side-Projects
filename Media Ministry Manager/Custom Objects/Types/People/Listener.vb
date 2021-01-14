Option Strict On
Imports MimeKit

Namespace Types
    <CLSCompliant(False)>
    Public Class Listener
        Inherits Person
        Public Property EmailAddress As MailboxAddress

        Public Sub New(firstName As String, lastName As String, email As String)
            MyBase.New(firstName, lastName)
            Me.EmailAddress = MailboxAddress.Parse(email)
        End Sub

        Public Sub New(firstName As String, lastName As String)
            MyBase.New(firstName, lastName)
            Me.EmailAddress = Nothing
        End Sub

        Shared Function Parse(name As String) As String()
            'Parse the name given into seperate first and last name parts and return the string array with supplied name
            Dim nameParts As String()
            nameParts = name.Split(" "c)

            If nameParts.Length = 3 Then
                nameParts(1) &= " " & nameParts(2)
            ElseIf nameParts.Length = 1 Then
                nameParts(1) = Nothing
            ElseIf nameParts.Length = 0 Then
                nameParts(0) = Nothing
                nameParts(1) = Nothing
            End If

            Return nameParts
        End Function
    End Class
End Namespace