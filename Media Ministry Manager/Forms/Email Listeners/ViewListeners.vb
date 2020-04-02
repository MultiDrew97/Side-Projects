Option Strict On
Imports System.ComponentModel

Public Class ViewListeners
    Public emails As frm_EmailListeners
    Dim db As Database

    ReadOnly totalListeners As String = "Total Listeners: {0}"

    Public Sub New(ByRef db As Database)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.db = db
    End Sub
    Private Sub frm_ViewListeners_Load(sender As Object, e As EventArgs) Handles Me.Load
        customLoad()
    End Sub

    Public Sub customLoad()
        Me.EMAIL_LISTENERSTableAdapter.Fill(Me.Media_MinistryDataSet.EMAIL_LISTENERS)
        dgv_Listeners.Sort(dgv_Listeners.Columns(0), ListSortDirection.Ascending)
        updateTotal()
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim frm_AddListeners As AddListener = New AddListener()
        frm_AddListeners.frm_Emails = Me
        frm_AddListeners.Show()
    End Sub

    Private Sub frm_ViewListeners_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        emails.Show()
    End Sub

    Private Sub dgv_Listeners_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Listeners.UserDeletingRow
        db.removeListener(CType(e.Row.Cells(0).Value, String), CType(e.Row.Cells(1).Value, String))
    End Sub

    Private Sub dgv_Listeners_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Listeners.CellEndEdit
        Dim changed As Integer = e.RowIndex
        Dim name As String = CType(dgv_Listeners.Rows(changed).Cells(0).Value, String)
        Dim email As String = CType(dgv_Listeners.Rows(changed).Cells(0).Value, String)

        db.updateListener(name, email)
    End Sub

    Private Sub updateTotal()
        lbl_Total.Text = String.Format(totalListeners, dgv_Listeners.RowCount())
    End Sub

    Private Sub dgv_Listeners_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dgv_Listeners.UserDeletedRow
        updateTotal()
    End Sub
End Class