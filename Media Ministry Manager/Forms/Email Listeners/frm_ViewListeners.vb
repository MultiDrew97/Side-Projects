Option Strict On

Imports System.ComponentModel

Public Class frm_ViewListeners
    Public emails As frm_EmailListeners
    Dim db As Database
    ReadOnly totalListeners As String = "Total Listeners: {0}"

    Structure Sizes

        'window sizes
        Shared max As New Size(1382, 744)

        Shared [Default] As New Size(1014, 489)

        'dgv sizes
        Shared DefaultDGV As New Size(613, 450)

        Shared dgvMax As New Size(957, 705)
    End Structure

    Structure Locations

        'add button locations
        Shared AddDefault As New Point(712, 319)

        Shared maxAdd As New Point(1093, 555)

        'count label locations
        Shared CountDefault As New Point(707, 389)

        Shared maxCount As New Point(1088, 616)

        'search box locations
        Shared SearchBoxDefault As New Point(712, 75)

        Shared SearchBoxMax As New Point(1062, 82)

        'search label locations
        Shared SearchLabelDefault As New Point(619, 75)

        Shared SearchLabelMax As New Point(963, 85)

        'column combo box locations
        Shared ColumnBoxDefault As New Point(730, 12)

        Shared ColumnBoxMax As New Point(1139, 21)

        'search button locations
        Shared SearchDefault As New Point(781, 123)

        Shared SearchMax As New Point(1093, 151)
    End Structure

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
        Dim frm_AddListeners As frm_AddListener = New frm_AddListener()
        frm_AddListeners.frm_Emails = Me
        frm_AddListeners.Show()
    End Sub

    Private Sub frm_ViewListeners_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            emails.Show()
        Catch

        End Try
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

    Private Sub frm_ViewListeners_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.Size = Sizes.max Then
            MaxChanges()
        Else
            DefaultChanges()
        End If
    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        Dim criteria = txt_SearchBox.Text
        Dim area = cbx_Column.SelectedText
    End Sub

    Private Sub btn_Advanced_Click(sender As Object, e As EventArgs) Handles btn_Advanced.Click
        'lbl_EmailSearch.Show()
        'lbl_NameSearch.Show()
        'txt_NameSearch.Show()
        'txt_EmailSearch.Show()
        gbx_AdvancedSearch.Show()
        txt_SearchBox.Hide()
        lbl_SearchLabel.Hide()
        btn_Advanced.Hide()
        cbx_Column.Hide()
        btn_Search.Hide()
    End Sub

    Private Sub MaxChanges()
        'Change Locations
        txt_SearchBox.Location = Locations.SearchBoxMax
        cbx_Column.Location = Locations.ColumnBoxMax
        lbl_SearchLabel.Location = Locations.SearchLabelMax
        lbl_Total.Location = Locations.maxCount
        btn_Add.Location = Locations.maxAdd
        btn_Search.Location = Locations.SearchMax

        'Change Visibilities
        btn_Advanced.Show()

        'Change Sizes
        dgv_Listeners.Size = Sizes.dgvMax
    End Sub

    Private Sub DefaultChanges()
        'Change Locations
        txt_SearchBox.Location = Locations.SearchBoxDefault
        cbx_Column.Location = Locations.ColumnBoxDefault
        lbl_SearchLabel.Location = Locations.SearchLabelDefault
        lbl_Total.Location = Locations.CountDefault
        btn_Add.Location = Locations.AddDefault

        'Change Visibilities
        txt_SearchBox.Show()
        cbx_Column.Show()
        btn_Advanced.Hide()
        gbx_AdvancedSearch.Hide()

        'Change Sizes
        dgv_Listeners.Size = Sizes.DefaultDGV
    End Sub

    Private Sub btn_AdvancedCancel_Click(sender As Object, e As EventArgs) Handles btn_AdvancedCancel.Click
        gbx_AdvancedSearch.Hide()
        txt_SearchBox.Show()
        lbl_SearchLabel.Show()
        btn_Advanced.Show()
        cbx_Column.Show()
        btn_Search.Show()
    End Sub

End Class