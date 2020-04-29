Option Strict On

Imports System.ComponentModel
Imports Media_Ministry.Utils
Public Class frm_ViewListeners
    Public sendingForm As Form
    Dim db As Database
    ReadOnly totalListeners As String = "Total Listeners: {0}"
    Private purpose As String
    Private amount As Double
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
        Shared AddDefault As New Point(780, 364)
        Shared maxAdd As New Point(1093, 555)

        'count label locations
        Shared CountDefault As New Point(775, 406)
        Shared maxCount As New Point(1088, 616)

        'search box locations
        Shared SearchBoxDefault As New Point(712, 75)
        Shared SearchBoxMax As New Point(1062, 82)

        'search label locations
        Shared SearchLabelDefault As New Point(619, 75)
        Shared SearchLabelMax As New Point(963, 85)

        'column combo box locations
        Shared ColumnBoxDefault As New Point(757, 12)
        Shared ColumnBoxMax As New Point(1139, 21)

        'search button locations
        Shared SearchDefault As New Point(881, 118)
        Shared SearchMax As New Point(1093, 151)

        'ClearSearch button Locations
        Shared ClearDefault As New Point(705, 118)
        Shared ClearMax As New Point(1122, 200)

        'CreateReceipt button locations
        Shared CreateDefault As New Point(757, 164)
        Shared CreateMax As New Point(1129, 312)

        'PuposeGroup locations
        Shared ReceiptDefault As New Point(670, 164)
        Shared ReceiptMax As New Point(1044, 321)
    End Structure

    Private Sub frm_ViewListeners_Load(sender As Object, e As EventArgs) Handles Me.Load
        customLoad()
    End Sub

    Public Sub customLoad()
        Me.EmaiL_LISTENERSTableAdapter.Fill(Me.Media_MinistryDataSet.EMAIL_LISTENERS)
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
            sendingForm.Show()
        Catch

        End Try
    End Sub

    Private Sub dgv_Listeners_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Listeners.UserDeletingRow
        Using db As New Database(My.Settings.Username, My.Settings.Password)
            db.removeListener(CType(e.Row.Cells(1).Value, String))
        End Using
    End Sub

    Private Sub dgv_Listeners_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Listeners.CellEndEdit
        Dim changed As Integer = e.RowIndex
        Dim name As String = CType(dgv_Listeners.Rows(changed).Cells(0).Value, String)
        Dim email As String = CType(dgv_Listeners.Rows(changed).Cells(0).Value, String)

        Using db As New Database(My.Settings.Username, My.Settings.Password)
            db.updateListener(name, email)
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

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        searchListeners(False)
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
        btn_CancelSearch.Hide()
    End Sub

    Private Sub MaxChanges()
        'Change Locations
        txt_SearchBox.Location = Locations.SearchBoxMax
        cbx_Column.Location = Locations.ColumnBoxMax
        lbl_SearchLabel.Location = Locations.SearchLabelMax
        lbl_Total.Location = Locations.maxCount
        btn_Add.Location = Locations.maxAdd
        btn_Search.Location = Locations.SearchMax
        btn_CancelSearch.Location = Locations.ClearMax
        btn_CreateReceipt.Location = Locations.CreateMax
        gbx_Receipt.Location = Locations.ReceiptMax

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
        btn_CancelSearch.Location = Locations.ClearDefault
        btn_CreateReceipt.Location = Locations.CreateDefault
        gbx_Receipt.Location = Locations.ReceiptDefault

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
        btn_CancelSearch.Show()
    End Sub

    Private Sub btn_CreateReceipt_Click(sender As Object, e As EventArgs) Handles btn_CreateReceipt.Click
        gbx_Receipt.Show()
        btn_CreateReceipt.Hide()
    End Sub

    Private Sub ofd_ReceiptImage_FileOk(sender As Object, e As CancelEventArgs) Handles ofd_ReceiptImage.FileOk
        If nud_Amount.Value > 0 Then
            Dim email As String = CType(dgv_Listeners.SelectedRows(0).Cells(1).Value, String)
            Dim receipt As Process = Process.Start("cmd", String.Format("/C java -jar sender.jar -r {0} {1} ""{2}"" ""{3}""", email, amount, purpose, ofd_ReceiptImage.FileName))
            receipt.WaitForExit()

            If receipt.ExitCode = 0 Then
                gbx_Receipt.Hide()
                btn_CreateReceipt.Show()
            Else
                MessageBox.Show("Couldn't send the receipt")
            End If
        Else
            MessageBox.Show("You have to set a dollar amount...")
        End If
    End Sub

    Private Sub btn_AdvancedSearch_Click(sender As Object, e As EventArgs) Handles btn_AdvancedSearch.Click
        searchListeners(True)
    End Sub

    Private Sub searchListeners(advanced As Boolean)
        Dim criteria(1) As String
        Dim column As String

        If advanced Then
            criteria(0) = "%" & txt_NameSearch.Text & "%"
            criteria(1) = "%" & txt_EmailSearch.Text & "%"
        Else
            If cbx_Column.SelectedIndex >= 0 Then
                column = cbx_Column.SelectedItem.ToString()
                criteria(0) = "%" & txt_SearchBox.Text & "%"
            End If
        End If

        If cbx_Column.SelectedIndex >= 0 Then
            Using db As New Database(My.Settings.Username, My.Settings.Password)
                dgv_Listeners.DataSource = db.searchListeners(advanced, column, criteria)
            End Using
        End If
    End Sub

    Private Sub btn_CancelSearch_Click(sender As Object, e As EventArgs) Handles btn_CancelSearch.Click
        'Me.EmaiL_LISTENERSTableAdapter.Fill(Me.Media_MinistryDataSet.EMAIL_LISTENERS)
        dgv_Listeners.DataSource = EMAILLISTENERSBindingSource
    End Sub

    Private Sub btn_SendReceipt_Click(sender As Object, e As EventArgs) Handles btn_SendReceipt.Click
        If dgv_Listeners.SelectedRows.Count = 1 Then
            ofd_ReceiptImage.ShowDialog()
        Else
            MessageBox.Show("You must select a listener first...")
        End If
    End Sub

    Private Sub rdo_Tithes_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Tithes.CheckedChanged
        If rdo_Tithes.Checked Then
            purpose = "Tithes"
        End If
    End Sub

    Private Sub rdo_Offering_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Offering.CheckedChanged
        If rdo_Offering.Checked Then
            purpose = "Offering"
        End If
    End Sub

    Private Sub rdo_BuildingFund_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_BuildingFund.CheckedChanged
        If rdo_BuildingFund.Checked Then
            purpose = "Building Fund"
        End If
    End Sub

    Private Sub nud_Amount_ValueChanged(sender As Object, e As EventArgs) Handles nud_Amount.ValueChanged
        amount = nud_Amount.Value
    End Sub
End Class
