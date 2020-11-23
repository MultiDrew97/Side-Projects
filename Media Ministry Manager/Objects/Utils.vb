Namespace Helpers
    Public Structure Utils
        Private ReadOnly Property Value As Boolean
        Shared Sub Wait(ByVal seconds As Integer)
            'found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

            For i As Integer = 0 To seconds * 100
                Threading.Thread.Sleep(10)
                Application.DoEvents()
            Next
        End Sub

        Public Overrides Function Equals(obj As Object) As Boolean
            Return False
        End Function

        Shared Operator =(ByVal fs As Utils, ByVal ss As Utils) As Boolean
            Return fs.Value = ss.Value
        End Operator

        Shared Operator <>(ByVal fs As Utils, ByVal ss As Utils) As Boolean
            Return fs.Value = ss.Value
        End Operator
    End Structure
End Namespace
