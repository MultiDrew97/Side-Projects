Imports System.Runtime.Serialization

Namespace MediaMinistry.Exceptions
    <Serializable>
    Public Class PasswordMisMatchException
        Inherits Exception
        <CLSCompliant(False)>
        Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub

        Protected Sub New(info As SerializationInfo, context As StreamingContext)
            MyBase.New(info, context)
        End Sub

        Sub New()
            MyBase.New()
        End Sub

        Sub New(message As String, innerException As Exception)
            MyBase.New(message, innerException)
        End Sub
    End Class
End Namespace
