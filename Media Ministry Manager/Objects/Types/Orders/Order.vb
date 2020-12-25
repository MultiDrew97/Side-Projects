Option Strict On
Namespace Types
    Public Class Order
        Public Property Customer() As Customer
        Public Property Product() As Product
        Public Property OrderDate As Date

        Public Sub New(customer As Customer, product As Product, ordered As Date)
            Me.Customer = customer
            Me.Product = product
            Me.OrderDate = ordered
        End Sub
    End Class
End Namespace