Option Strict On

Namespace Types
    Public Class Listener
        Inherits Person
        Public Property EmailAddress As MimeKit.MailboxAddress

        Public Sub New(listenerID As Integer, firstName As String, lastName As String, Optional email As String = "")
            MyBase.New(listenerID, firstName, lastName)
            Me.EmailAddress = New MimeKit.MailboxAddress(Me.Name, email)
        End Sub

        Shared Function ParseName(name As String) As String()
            'Parse the name given into seperate first and last name parts and return the string array with supplied name
            Dim nameParts As String()
            nameParts = name.Split(" "c)

            If nameParts.Length = 3 Then
                nameParts = {nameParts(0), nameParts(1) & " " & nameParts(2)}
            ElseIf nameParts.Length = 1 Then
                nameParts = {nameParts(0), ""}
            ElseIf nameParts.Length = 0 Then
                nameParts = {"", ""}
            End If

            Return nameParts
        End Function

        Shared Function Parse(arr As Object()) As Listener
            Dim parts As String() = ParseName(CStr(arr(1)))
            Return New Listener(CInt(arr(0)), parts(0), parts(1), CStr(arr(2)))
        End Function
    End Class
End Namespace