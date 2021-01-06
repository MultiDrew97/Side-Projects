Option Strict On
Namespace Types
    Public Class Product
        Inherits Item
        Public Property Stock() As Integer
        Public Property Price() As Double

        Public Sub New(name As String, stock As Integer, price As Double)
            MyBase.New(name)
            Me.Stock = stock
            Me.Price = price
        End Sub
    End Class
End Namespace