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

        Shared Function ConvertStateAbbr(abbr As String) As String
            'TODO: Add the other states to this list
            Select Case abbr
                Case "tx", "TX"
                    Return "Texas"
                Case "la", "LA"
                    Return "Louisiana"
                Case Else
                    Return Nothing
            End Select
        End Function

        Shared Sub CloseOpenForms()
            'Close all open windows. Figuring this out will allow me to change from only clearing when primary form closes to when all forms close.
            'improving efficiency in memory management
            Do
                Try
                    My.Application.OpenForms(0).Close()
                Catch ex As InvalidOperationException
                    Console.WriteLine("Form of name {0} falied to close", My.Application.OpenForms(0).Name)
                End Try
            Loop While My.Application.OpenForms.Count > 0
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
