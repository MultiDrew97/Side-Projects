Option Strict On
Namespace Types
    Public Class CompletedOrder
        Inherits Order

        Public Property FulfilledDate() As Date

        Public Sub New(customer As Customer, product As Product, ordered As Date, completed As Date)
            MyBase.New(customer, product, ordered)
            Me.FulfilledDate = completed
        End Sub
    End Class
End Namespace