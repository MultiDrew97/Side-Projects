Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.Text.RegularExpressions.Regex
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class frm_AddListener
    Public frm_Emails As frm_ViewListeners

    'this regex came from here: https://howtodoinjava.com/regex/java-regex-validate-email-address/
    'any stricter than this and the program won't add emails
    ReadOnly emailPattern As String = "^[a-zA-Z0-9_!#$%&’*+/=?`{|}~^.-]+@[a-zA-Z0-9.-]+$"
    Private Sub reset()
        rdo_Single.Checked = True

        lbl_Name.Visible = True
        txt_Name.Visible = True

        lbl_Email.Visible = True
        txt_Email.Visible = True

        lbl_FilePath.Visible = False
        txt_FilePath.Visible = False
        btn_Search.Visible = False

        btn_Add.Text = "Add Listener"

        txt_Email.Text = ""
        txt_Name.Text = ""
        txt_FilePath.Text = ""

        btn_Add.Size = New Size() With {.Width = 187, .Height = 53}
        btn_Cancel.Size = New Size() With {.Width = 187, .Height = 53}

        tss_Feedback.Text = "Enter the name and email of the new listener"

        Me.AllowDrop = False

        txt_Name.Focus()
    End Sub

    Private Sub rdo_Single_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Single.CheckedChanged
        If rdo_Single.Checked Then
            rdo_Multiple.Checked = False

            reset()
        End If
    End Sub

    Private Sub rdo_Multiple_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Multiple.CheckedChanged
        If rdo_Multiple.Checked Then
            rdo_Single.Checked = False

            lbl_Name.Visible = False
            txt_Name.Visible = False

            lbl_Email.Visible = False
            txt_Email.Visible = False

            lbl_FilePath.Visible = True
            txt_FilePath.Visible = True
            btn_Search.Visible = True

            txt_FilePath.Text = ""

            btn_Add.Text = "Import Listeners"
            btn_Add.Size = New Size() With {.Height = 62, .Width = 187}
            btn_Cancel.Size = New Size() With {.Height = 62, .Width = 187}
            tss_Feedback.Text = "Please select the .csv file that has the new listeners"

            Me.AllowDrop = True
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
        frm_Emails.Show()
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim db As Database = New Database(My.Settings.Username, My.Settings.Password)

        If rdo_Single.Checked Then
            If Not String.IsNullOrWhiteSpace(txt_Email.Text) And Not String.IsNullOrWhiteSpace(txt_Name.Text) Then
                If IsMatch(txt_Email.Text, emailPattern) Then
                    Try
                        db.AddListener(txt_Name.Text, txt_Email.Text)
                        tss_Feedback.ForeColor = Color.Black
                        tss_Feedback.Text = String.Format("{0} has been added successfully...", txt_Name.Text)
                        frm_Emails.customLoad()
                    Catch ex As SqlException
                        tss_Feedback.ForeColor = Color.Red
                        tss_Feedback.Text = "Listener might already be in the system. Please try again."
                    End Try
                Else
                    tss_Feedback.Text = "The email is not in a supported format (username@domain.com)..."
                    tss_Feedback.ForeColor = Color.Red
                End If
            Else
                tss_Feedback.Text = "No name or email was present"
                txt_Name.Focus()
            End If
        ElseIf rdo_Multiple.Checked Then
            If Not String.IsNullOrWhiteSpace(txt_FilePath.Text) And Path.GetExtension(txt_FilePath.Text).Equals(".csv") Then
                Dim fields(2) As String
                Dim counter As Integer = 0
                Dim successCount As Integer = 0
                Dim failCount As Integer = 0
                'Dim fout As StreamWriter = New StreamWriter(ofd_ListenerList.FileName & "\..\Failed Additions.csv")

                Using fin As TextFieldParser = New TextFieldParser(ofd_ListenerList.FileName)
                    fin.TextFieldType = FieldType.Delimited
                    fin.SetDelimiters(",")

                    Using fout As StreamWriter = New StreamWriter(ofd_ListenerList.FileName & "\..\Failed Additions.csv")

                        While (Not fin.EndOfData)
                            counter = 0
                            For Each field As String In fin.ReadFields()
                                fields(counter) = field
                                counter += 1
                            Next

                            If IsMatch(fields(1), emailPattern) Then
                                Try
                                    db.AddListener(fields(0), fields(1))
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
                frm_Emails.customLoad()
                wait(2)

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

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        ofd_ListenerList.ShowDialog()
    End Sub

    Private Sub ofd_ListenerList_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofd_ListenerList.FileOk
        txt_FilePath.Text = ofd_ListenerList.SafeFileName
    End Sub

    Private Sub wait(ByVal seconds As Integer)
        'found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub frm_AddListener_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        'found how to add this here: https://stackoverflow.com/questions/11686631/drag-drop-and-get-file-path-in-vb-net
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub frm_AddListener_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        'found how to add this here: https://stackoverflow.com/questions/11686631/drag-drop-and-get-file-path-in-vb-net
        If e.Data.GetDataPresent("FileDrop", True) Then
            ofd_ListenerList.FileName = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)
            If ofd_ListenerList.CheckFileExists And CorrectExtension(ofd_ListenerList.FileName) Then
                ofd_ListenerList_FileOk(sender, New CancelEventArgs)
                'txt_FilePath.Text = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)
            Else
                tss_Feedback.Text = "The file you selected does not have the correct extension. You need a file with the .csv extension"
            End If
        End If
    End Sub

    Private Function CorrectExtension(filename As String) As Boolean
        Return filename.Split({"."c})(1).Equals("csv")
    End Function
End Class