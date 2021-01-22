Option Strict On

Imports System.ComponentModel
Imports MediaMinistry.Types.Listener

Public Class Frm_ViewListeners
    Private ListenersTable As New CustomData.ListenersDataTable
    Private FiltersTable As New DataTable

    ReadOnly totalListeners As String = "Total Listeners: {0}"
    Private ListenersData As ObjectModel.Collection(Of Types.Listener)

    Structure Sizes

        'window sizes
        Shared max As New Size(1382, 744)

        Shared [Default] As New Size(1014, 489)

        'dgv sizes
        Shared DefaultDGV As New Size(737, 503)

        Shared dgvMax As New Size(957, 705)
    End Structure

    Structure Locations

        'add button locations
        Shared AddDefault As New Point(792, 344)

        Shared maxAdd As New Point(1093, 555)

        'count label locations
        Shared CountDefault As New Point(787, 386)

        Shared maxCount As New Point(1088, 616)

        'search box locations
        Shared SearchBoxDefault As New Point(27, 72)

        Shared SearchBoxMax As New Point(1062, 82)

        'column combo box locations
        Shared ColumnBoxDefault As New Point(60, 33)

        Shared ColumnBoxMax As New Point(1139, 21)

        'search button locations
        Shared SearchDefault As New Point(781, 123)

        Shared SearchMax As New Point(1093, 151)
    End Structure

    Private Sub Frm_ViewListeners_Load(sender As Object, e As EventArgs) Handles Me.Load
        bsListeners.DataSource = ListenersTable
        bsFilters.DataSource = FiltersTable
        FiltersTable.Columns.AddRange({New DataColumn("ColumnPlain", GetType(String)), New DataColumn("Column", GetType(String))})
        cbx_Column.DisplayMember = "ColumnPlain"
        Refresh()
    End Sub

    Private Shadows Sub Refresh()
        GetData()
        LoadData()
        dgv_Listeners.Sort(dgv_Listeners.Columns(0), ListSortDirection.Ascending)
        cbx_Column.SelectedIndex = 0
        updateTotal()
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If AddListenerDialog.ShowDialog() = DialogResult.OK Then
            Refresh()
        End If
    End Sub

    Private Sub Frm_ViewListeners_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim frm As New frm_Main
        frm.Show()
    End Sub

    Private Sub Dgv_Listeners_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Listeners.UserDeletingRow
        Using db = New Database
            db.RemoveListener(CInt(CType(e.Row.DataBoundItem, DataRowView)("ListenerID")))
        End Using
    End Sub

    Private Sub dgv_Listeners_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Listeners.CellEndEdit
        Dim column As String = CStr(dgv_Listeners.Columns(e.ColumnIndex).DataPropertyName)
        Dim value As String = CStr(dgv_Listeners.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        Dim listenerID As Integer = CInt(CType(dgv_Listeners.Rows(e.RowIndex).DataBoundItem, DataRowView)("ListenerID"))

        Using db As New Database
            'db.UpdateListener(listenerID, column, value)
        End Using
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

    Private Sub btn_Search_Click(sender As Object, e As EventArgs)
        Dim criteria = txt_SearchBox.Text
        Dim column = cbx_Column.SelectedText
        Dim queryString As String = String.Format("SELECT * FROM EMAIL_LISTENERS WHERE {0} LIKE '%{1}%", column, criteria)

        'db.search(queryString)
        'If cbx_Column.SelectedText = "Email" Then
        '    Console.WriteLine("EMAIL")

        '    'EMAIL_LISTENERSTableAdapter.Fill(Media_MinistryDataSet.EMAIL_LISTENERS.FindByEMAIL(criteria))
        'Else
        '    Console.WriteLine("NAME")
        'End If
    End Sub

    Private Sub btn_Advanced_Click(sender As Object, e As EventArgs) Handles btn_Advanced.Click
        'lbl_EmailSearch.Show()
        'lbl_NameSearch.Show()
        'txt_NameSearch.Show()
        'txt_EmailSearch.Show()
        gbx_AdvancedSearch.Show()
        txt_SearchBox.Hide()
        gbx_Search.Hide()
        btn_Advanced.Hide()
        cbx_Column.Hide()
    End Sub

    Private Sub MaxChanges()
        'Change Locations
        txt_SearchBox.Location = Locations.SearchBoxMax
        cbx_Column.Location = Locations.ColumnBoxMax
        lbl_Total.Location = Locations.maxCount
        btn_Add.Location = Locations.maxAdd

        'Change Visibilities
        btn_Advanced.Show()

        'Change Sizes
        dgv_Listeners.Size = Sizes.dgvMax
    End Sub

    Private Sub DefaultChanges()
        'Change Locations
        txt_SearchBox.Location = Locations.SearchBoxDefault
        cbx_Column.Location = Locations.ColumnBoxDefault
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
        gbx_Search.Show()
        btn_Advanced.Show()
        cbx_Column.Show()
    End Sub

    Private Sub GetData()
        Using db As New Database
            ListenersData = db.GetListeners
        End Using
    End Sub

    Private Sub LoadData()
        Dim row As DataRow

        For Each listener As Types.Listener In ListenersData
            row = ListenersTable.NewRow
            row("ListenerID") = listener.Id
            row("Name") = listener.Name
            row("EmailAddress") = listener.EmailAddress.Address
            ListenersTable.Rows.Add(row)
        Next

        row = FiltersTable.NewRow
        row("ColumnPlain") = "Name"
        row("Column") = "Name"
        FiltersTable.Rows.Add(row)
        row = FiltersTable.NewRow
        row("ColumnPlain") = "Email Address"
        row("Column") = "EmailAddress"
        FiltersTable.Rows.Add(row)
    End Sub

    Private Sub txt_SearchBox_TextChanged(sender As Object, e As EventArgs) Handles txt_SearchBox.TextChanged
        bsListeners.Filter = String.Format("{0} like '%{1}%'", CType(cbx_Column.SelectedItem, DataRowView)("Column"), txt_SearchBox.Text)
    End Sub
End Class
