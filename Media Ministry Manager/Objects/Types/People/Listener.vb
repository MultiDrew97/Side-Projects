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

        Shared Function Parse(name As String) As Listener
            'Parse the name given into seperate first and last name parts and return a new Listener object with supplied name
            Dim nameParts As String()
            nameParts = name.Split(" "c)

            If nameParts.Length = 3 Then
                'TODO: Clean this up later
                nameParts(1) &= " " & nameParts(2)
                Return New Listener(nameParts(0), nameParts(1))
            ElseIf nameParts.Length = 2 Then
                Return New Listener(nameParts(0), nameParts(1))
            ElseIf nameParts.Length = 1 Then
                Return New Listener(nameParts(0), Nothing)
            ElseIf nameParts.Length = 0 Then
                Return New Listener(Nothing, Nothing)
            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace