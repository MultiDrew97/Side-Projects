Option Strict On
Imports System.IO
Imports System.Text
Imports SendEmailsApplication
Imports SendEmailsGmailApplication
Imports NeoSmart.Utils
Imports encoder = NeoSmart.Utils.UrlBase64
Public Class frm_EmailListeners
    Dim emailSender As SendEmails
    Dim emailGmail As SendEmailsGmail

    Dim frm_main As frm_Main
    Sub New(ByRef frm_main As frm_Main)
        InitializeComponent()

        Me.frm_main = frm_main
        Me.Show()
    End Sub

    Private Sub btn_SendEmail_Click(sender As Object, e As EventArgs) Handles btn_SendEmail.Click
        'ofd_SelectAudio.ShowDialog()
        emailGmail.Send()
    End Sub

    Private Async Sub ofd_SelectAudio_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofd_SelectAudio.FileOk
        'do something

        'Dim myProcess As Process = Process.Start("C:\Users\arand\source\repos\MultiDrew97\Side-Projects\SendEmails\obj\Debug\netcoreapp3.1\SendEmailsApplication.exe")

        'myProcess.WaitForExit(100)

        'If Not myProcess.HasExited Then
        '    myProcess.Kill()
        'End If

        'Threading.Thread.Sleep(1)
        'Console.WriteLine("SendEmail ended:" & myProcess.ExitTime & Environment.NewLine & "Exit Code: " & myProcess.ExitCode)

        'If Await emailSender.SendEmail() Then

        '    Me.Close()
        '    frm_main.Show()
        'End If

        Dim temp = ofd_SelectAudio.FileName.Split(CType("\\", Char))
        Dim encoded = encoder.Encode(File.ReadAllBytes(ofd_SelectAudio.FileName), PaddingPolicy.Preserve)


        'attachment( filename, encodedContent )
        Dim attachment As String() = {temp(temp.Length - 1), encoded}

        'recipient( email, name )
        'Dim recipient As String() = {"st-3-47zulj5oc4@glockapps.com", "Andrew"}
        Dim recipient As String() = {"randlewaam@jacks.sfasu.edu", "Andrew"}


        'Console.WriteLine(String.Format("Email: {0}{4}Name: {1}{4}{4}Attachment Name: {2}{4}Encoded Contents: {3}", recipient(0), recipient(1), attachment(0), attachment(1), vbNewLine))

        'If Await emailSender.Sender(recipient, attachment) Then
        '    Me.Close()
        '    frm_main.Show()
        'End If

        emailGmail.send()

    End Sub

    Private Sub frm_EmailListeners_Load(sender As Object, e As EventArgs) Handles Me.Load
        emailSender = New SendEmails(My.Settings.PublicKey, My.Settings.PrivateKey)
        emailGmail = New SendEmailsGmail()
    End Sub
End Class