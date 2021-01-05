Option Strict On

Namespace Types
    Public Class Listener
        Public Property Name As String
        Public Property Email As String

        Sub New(ByVal name As String, ByVal email As String)
            Me.Name = name
            Me.Email = email
        End Sub
    End Class

End Namespace