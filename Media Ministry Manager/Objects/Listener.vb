Option Strict On

Namespace SendingEmails
    Public Structure Listener
        Public Property name As String
        Public Property email As String

        Sub New(ByVal name As String, ByVal email As String)
            Me.name = name
            Me.email = email
        End Sub
    End Structure
End Namespace
