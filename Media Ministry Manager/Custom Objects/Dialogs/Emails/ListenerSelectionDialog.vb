Option Strict On

Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports MediaMinistry.Types

Public Class ListenerSelectionDialog
    Shared Property Listeners As New Collection(Of Listener)
    Private ListenerList As Collection(Of Listener)
    Private ListenersTable As DataTable

    Private Sub ListenerSelectionDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MediaMinistryDataSet.EMAIL_LISTENERS' table. You can move, or remove it, as needed.
        'Me.EMAIL_LISTENERSTableAdapter.Fill(Me.MediaMinistryDataSet.EMAIL_LISTENERS)
        'TODO: Add a search function to easily find specific listeners
        bw_RetrieveListeners.RunWorkerAsync()
    End Sub

    Public Overrides Sub Refresh()
        Listeners.Clear()
        CreateTable()
    End Sub

    Private Sub btn_Finish_Click(sender As Object, e As EventArgs) Handles btn_Finish.Click
        For Each row As DataGridViewRow In dgv_Listeners.Rows
            If CBool(row.Cells(0).Value) = True Then
                Listeners.Add(Listener.Parse(ListenersTable.Rows(row.Index).ItemArray()))
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
            ListenerList = db.GetListeners()
        End Using
    End Sub

    Private Sub LoadTable()
        ListenersTable.Columns.AddRange({
            New DataColumn("ListenerID", Type.GetType("System.Int32")),
            New DataColumn("Name", Type.GetType("System.String")),
            New DataColumn("EmailAddress", Type.GetType("System.String"))
            })
        FillTable()
    End Sub

    Private Sub CreateTable()
        ListenersTable = New DataTable
        LoadTable()
    End Sub

    Private Sub FillTable()
        Dim row As DataRow

        For Each listener In ListenerList
            row = ListenersTable.NewRow
            row("ListenerID") = listener.Id
            row("Name") = listener.Name
            row("EmailAddress") = listener.EmailAddress.Address
            ListenersTable.Rows.Add(row)
        Next
    End Sub

    Private Sub bw_RetrieveListeners_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_RetrieveListeners.RunWorkerCompleted
        Refresh()
        bsListeners.DataSource = ListenersTable
    End Sub
End Class
