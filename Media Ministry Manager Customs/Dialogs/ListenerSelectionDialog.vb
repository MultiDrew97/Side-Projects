Option Strict On

Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports MediaMinistry.Types

Public Class ListenerSelectionDialog
    Public Property Listeners As Collection(Of Listener)

    Private Sub ListenerSelectionDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MediaMinistryDataSet.EMAIL_LISTENERS' table. You can move, or remove it, as needed.
        Me.EMAIL_LISTENERSTableAdapter.Fill(Me.MediaMinistryDataSet.EMAIL_LISTENERS)
        'TODO: Add same refactor as DisplayCustomers form
        Listeners.Clear()
    End Sub

    Private Sub btn_Finish_Click(sender As Object, e As EventArgs) Handles btn_Finish.Click
        Dim parts As String()
        For Each row As DataGridViewRow In dgv_Listeners.Rows
            If CBool(row.Cells(0).Value) = True Then
                parts = Listener.ParseName(CStr(row.Cells(1).Value))

                'TODO: Fix this later
                Listeners.Add(New Listener(0, parts(0), parts(1), CStr(row.Cells(2).Value)))
            End If
        Next

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub chk_AllListeners_CheckedChanged(sender As Object, e As EventArgs) Handles chk_AllListeners.CheckedChanged
        bw_RetrieveListeners.RunWorkerAsync()
    End Sub

    Private Sub bw_RetrieveListeners_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_RetrieveListeners.DoWork
        Using db As New Database()
            Listeners = db.GetListeners()
        End Using
    End Sub
End Class
