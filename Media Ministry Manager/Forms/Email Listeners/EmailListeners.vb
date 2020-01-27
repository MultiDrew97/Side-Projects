Option Strict On

Public Class frm_EmailListeners
    Dim frm_main As frm_Main
    Sub New(ByRef frm_main As frm_Main)
        InitializeComponent()

        Me.frm_main = frm_main
        Me.Show()
    End Sub

    Private Sub btn_SendEmail_Click(sender As Object, e As EventArgs) Handles btn_SendEmail.Click
        Console.WriteLine("Starting program")
        Dim myProcess As Process = Process.Start("Program.cs")

        myProcess.WaitForExit(100)

        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If

        Threading.Thread.Sleep(1)
        Console.WriteLine("SendEmail ended:" & myProcess.ExitTime & Environment.NewLine & "Exit Code: " & myProcess.ExitCode)
    End Sub
End Class