Option Strict On
Namespace Types
    Public Class Address
        Public Property Street As String
        Public Property City As String
        Public Property State As String
        Public Property ZipCode As String

        Public Sub New(street As String, city As String, state As String, zip As String)
            Me.Street = street
            Me.City = city
            Me.State = state
            Me.ZipCode = zip
        End Sub

        Public Overrides Function ToString() As String
            Return String.Format("{0}{4}{1}, {2} {3}", Me.Street, Me.City, Me.State, Me.ZipCode, vbLf)
        End Function
    End Class
End Namespace
