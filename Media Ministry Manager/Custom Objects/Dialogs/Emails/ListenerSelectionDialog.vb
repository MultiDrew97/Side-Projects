Option Strict On

Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports MediaMinistry.Types

Public Class ListenerSelectionDialog
    Shared Property Listeners As New Collection(Of Listener)
    Private ListenerList As Collection(Of Listener)
    Private ReadOnly ListenersTable As New CustomData.ListenersDataTable
    Private column As String

    Private Sub ListenerSelectionDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Add a search function to easily find specific listeners
        bsListeners.DataSource = ListenersTable
        cbx_Column.SelectedIndex = 0
        bw_RetrieveListeners.RunWorkerAsync()
    End Sub

    Public Overrides Sub Refresh()
        Listeners.Clear()
        FillTable()
    End Sub

    Private Sub btn_Finish_Click(sender As Object, e As EventArgs) Handles btn_Finish.Click
        For Each row As DataGridViewRow In dgv_Listeners.Rows
            If CBool(row.Cells(0).Value) = True Then
                Listeners.Add(Listener.Parse(ListenersTable.Rows(row.Index).ItemArray()))
            End If
        Next

        If Listeners.Count >= 1 Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            Me.DialogResult = DialogResult.Retry
            Me.Close()
        End If
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
            ListenerList = db.GetListeners()
        End Using
    End Sub

    Private Sub FillTable()
        Try
            Dim row As DataRow

            For Each listener In ListenerList
                row = ListenersTable.NewRow
                row("ListenerID") = listener.Id
                row("Name") = listener.Name
                row("EmailAddress") = listener.EmailAddress.Address
                ListenersTable.Rows.Add(row)
            Next
        Catch ex As ConstraintException

        End Try
    End Sub

    Private Sub bw_RetrieveListeners_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_RetrieveListeners.RunWorkerCompleted
        Refresh()
    End Sub

    Private Sub cbx_Column_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Column.SelectedIndexChanged
        txt_Search.Text = ""
        column = If(cbx_Column.SelectedItem.ToString.Equals("Email Address"), "EmailAddress", "Name")
    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        bsListeners.Filter = String.Format("{0} like '%{1}%'", column, txt_Search.Text)
    End Sub
End Class
