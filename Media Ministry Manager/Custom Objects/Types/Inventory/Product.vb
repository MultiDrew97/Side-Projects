Option Strict On
Namespace Types
    Public Class Product
        Inherits Item
        Public Property Stock As Integer
        Public Property Price As Double
        Public Property Available As Boolean

        Public Sub New(id As Integer, name As String, stock As Integer, price As Double, available As Boolean)
            MyBase.New(id, name)
            Me.Stock = stock
            Me.Price = price
            Me.Available = available
        End Sub
    End Class
End Namespace