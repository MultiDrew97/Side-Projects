Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions.Regex
Imports MediaMinistry.Helpers
Imports MediaMinistry.Types
Imports Microsoft.VisualBasic.FileIO

Public Class Frm_AddListener
    Property Opener() As Form

    'this regex came from here: https://howtodoinjava.com/regex/java-regex-validate-email-address/
    'any stricter than this and the program won't add emails
    ReadOnly emailPattern As String = "^[a-zA-Z0-9_!#$%&’*+/=?`{|}~^.-]+@[a-zA-Z0-9.-]+$"

    Private Sub Reset()
        rdo_Single.Checked = True

        lbl_FirstName.Visible = True
        txt_FirstName.Visible = True

        lbl_Email.Visible = True
        txt_Email.Visible = True

        lbl_FilePath.Visible = False
        txt_FilePath.Visible = False
        btn_Browse.Visible = False
        chk_Headers.Visible = False

        btn_Add.Text = "Add Listener"

        txt_Email.Text = ""
        txt_FirstName.Text = ""
        txt_FilePath.Text = ""

        btn_Add.Size = New Size(187, 53)
        btn_Cancel.Size = btn_Add.Size

        tss_Feedback.Text = "Enter the name and email of the new listener"

        Me.AllowDrop = False

        txt_FirstName.Focus()
    End Sub

    Private Sub Rdo_Single_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Single.CheckedChanged
        If rdo_Single.Checked Then
            rdo_Multiple.Checked = False

            Reset()
        End If
    End Sub

    Private Sub Rdo_Multiple_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Multiple.CheckedChanged
        If rdo_Multiple.Checked Then
            rdo_Single.Checked = False

            lbl_FirstName.Visible = False
            txt_FirstName.Visible = False
            lbl_LastName.Visible = False
            txt_LastName.Visible = False

            lbl_Email.Visible = False
            txt_Email.Visible = False

            lbl_FilePath.Visible = True
            txt_FilePath.Visible = True
            btn_Browse.Visible = True
            chk_Headers.Visible = True

            txt_FilePath.Text = ""

            btn_Add.Text = "Import Listeners"
            btn_Add.Size = New Size(187, 62)
            btn_Cancel.Size = btn_Add.Size 'New Size(187, 62)
            tss_Feedback.Text = "Please select the .csv file that has the new listeners"

            Me.AllowDrop = True
        End If
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
        Try
            CType(Opener, frm_ViewListeners).customLoad()
        Catch ex As ApplicationException

        Finally
            Opener.Show()
        End Try
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click

        If rdo_Single.Checked Then
            If Not String.IsNullOrWhiteSpace(txt_Email.Text) And Not String.IsNullOrWhiteSpace(txt_FirstName.Text) Then
                If IsMatch(txt_Email.Text, emailPattern) Then
                    Try
                        Dim name As String = txt_FirstName.Text

                        If Not String.IsNullOrWhiteSpace(txt_LastName.Text) Then
                            name &= txt_LastName.Text
                        End If

                        'TODO: Convert to be using db instead of an instance of db
                        'db.AddListener(New Listener(txt_FirstName.Text, CType(IIf(String.IsNullOrWhiteSpace(txt_LastName.Text), Nothing, txt_LastName.Text), String), txt_Email.Text))
                        tss_Feedback.ForeColor = Color.Black
                        tss_Feedback.Text = String.Format("{0} has been added successfully...", txt_FirstName.Text)
                        CType(Opener, frm_ViewListeners).customLoad()
                    Catch ex As SqlException
                        tss_Feedback.ForeColor = Color.Red
                        tss_Feedback.Text = "Listener might already be in the system. Please try again."
                    End Try
                Else
                    ep_Required.SetError(txt_Email, "Must be in username@domain.ext format (i.e johndoe@gmail.com)")
                    tss_Feedback.Text = "The email is not in a supported format (username@domain.ext)..."
                    tss_Feedback.ForeColor = Color.Red
                End If
            Else
                If String.IsNullOrWhiteSpace(txt_FirstName.Text) Then
                    ep_Required.SetError(txt_FirstName, "A first name is required for a listener")
                End If

                If String.IsNullOrWhiteSpace(txt_LastName.Text) Then
                    ep_Required.SetError(txt_LastName, "A last name is required for a listener")
                End If

                tss_Feedback.Text = "There were required fields missing"
                tss_Feedback.ForeColor = Color.Red
                txt_FirstName.Focus()
            End If
        Else
            'Adding listeners from a csv file
            If Not String.IsNullOrWhiteSpace(txt_FilePath.Text) And Path.GetExtension(txt_FilePath.Text).Equals(".csv") Then
                Dim fields(1) As String
                Dim successCount As Integer = 0
                Dim failCount As Integer = 0
                Dim currentLine As String()

                Using fin As TextFieldParser = New TextFieldParser(ofd_ListenerList.FileName)
                    fin.TextFieldType = FieldType.Delimited
                    fin.SetDelimiters(",")

                    Using fout As StreamWriter = New StreamWriter(ofd_ListenerList.FileName & "\..\Failed Additions.csv")
                        Dim listener As Listener
                        While (Not fin.EndOfData)
                            currentLine = fin.ReadFields()
                            For i = 0 To 1
                                fields(i) = currentLine(i)
                            Next

                            If IsMatch(fields(1), emailPattern) Then
                                Try
                                    'listener = Listener.Parse(fields(0))
                                    listener.EmailAddress = MimeKit.MailboxAddress.Parse(fields(1))
                                    'TODO: Convert to be using db instead of an instance of db
                                    'db.AddListener(listener)
                                    successCount += 1
                                Catch ex As SqlException
                                    fout.WriteLineAsync(String.Format("{0},{1} #{2}", fields(0), fields(1), ex.Message))
                                    failCount += 1
                                End Try
                            Else
                                fout.WriteLineAsync(String.Format("{0},{1} # Email does not match email pattern (johndoe@domain.ext)", fields(0), fields(1)))
                                failCount += 1
                            End If
                        End While
                    End Using
                End Using

                tss_Feedback.Text = String.Format("{0} listeners were added successfully...", successCount)
                Try
                    CType(Opener, frm_ViewListeners).customLoad()
                Catch ex As SqlException
                Finally
                    Utils.Wait(2)
                End Try

                If (failCount > 0) Then
                    tss_Feedback.ForeColor = Color.Red
                    tss_Feedback.Text = "Check the Faild Additions file in the locaiton to see failed additions."
                Else
                    tss_Feedback.ForeColor = Color.Black
                    tss_Feedback.Text = "All emails were imported successfully..."
                End If
            Else
                tss_Feedback.ForeColor = Color.Red
                tss_Feedback.Text = "You have to select a .csv file..."
            End If
        End If
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
        ofd_ListenerList.ShowDialog()
    End Sub

    Private Sub Ofd_ListenerList_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofd_ListenerList.FileOk
        txt_FilePath.Text = ofd_ListenerList.SafeFileName
    End Sub

    Private Sub Frm_AddListener_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        'found how to add this here: https://stackoverflow.com/questions/11686631/drag-drop-and-get-file-path-in-vb-net
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Frm_AddListener_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        'found how to add this here: https://stackoverflow.com/questions/11686631/drag-drop-and-get-file-path-in-vb-net
        If e.Data.GetDataPresent("FileDrop", True) Then
            ofd_ListenerList.FileName = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)
            If ofd_ListenerList.CheckFileExists And CorrectExtension(ofd_ListenerList.FileName) Then
                Ofd_ListenerList_FileOk(sender, New CancelEventArgs)
                'txt_FilePath.Text = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)
            Else
                tss_Feedback.Text = "The file you selected does not have the correct extension. You need a file with the .csv extension"
            End If
        End If
    End Sub

    Shared Function CorrectExtension(filename As String) As Boolean
        Return filename.Split({"."c})(1).Equals("csv")
    End Function

End Class