Option Strict On

Imports System.Data.SqlClient

Public Class frm_DisplayCustomers
    Property MainForm As frm_Main

    Private Sub Display_Customers_Load(sender As Object, e As EventArgs) Handles Me.Load
        refresh()
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs)
        'update customer information that was entered
        Dim index, updateCount As Integer
        Dim street, city, state, zip, phone, email, payment As String
        Dim failedUpdate As Boolean

        updateCount = 0
        failedUpdate = False

        If dgv_Customers.SelectedCells().Count > 0 Then
            'got this idea from these sources
            'how to remove items from the data grid view
            'https://www.youtube.com/watch?v=Yfa1hnpKIzk
            'how to obtain the value from the desired cell from the data grid view
            'https://stackoverflow.com/questions/19721984/how-to-get-cell-value-from-datagridview-in-vb-net

            Do
                If dgv_Customers.Rows(index).Cells(0).Value.Equals(True) Then
                    Using db = New Database(My.Settings.Username, My.Settings.Password)
                        street = dgv_Customers.Rows(index).Cells(4).Value.ToString
                        city = dgv_Customers.Rows(index).Cells(5).Value.ToString
                        state = dgv_Customers.Rows(index).Cells(6).Value.ToString
                        zip = dgv_Customers.Rows(index).Cells(7).Value.ToString
                        phone = dgv_Customers.Rows(index).Cells(3).Value.ToString
                        email = dgv_Customers.Rows(index).Cells(8).Value.ToString
                        payment = dgv_Customers.Rows(index).Cells(9).Value.ToString

                        Try
                            db.UpdateCustomerInfo(street, city, state, zip, email, payment, phone)
                            updateCount += 1
                        Catch ex As SqlException
                            failedUpdate = True
                        End Try
                    End Using
                End If

                index += 1
            Loop Until (index >= dgv_Customers.Rows.Count)
        End If

        If failedUpdate Then
            tss_CustomersView.ForeColor = Color.Red
            tss_CustomersView.Text = "Some people's informtion was not updated. Please try again."
        ElseIf updateCount > 1 Then
            tss_CustomersView.ForeColor = SystemColors.WindowText
            tss_CustomersView.Text = String.Format("{0} people's informtion was updated", updateCount)
        ElseIf updateCount = 1 Then
            tss_CustomersView.ForeColor = SystemColors.WindowText
            tss_CustomersView.Text = String.Format("{0} person's information was updated", updateCount)
        End If
    End Sub

    Private Sub Frm_DisplayCustomers_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim main As New frm_Main()
        main.Show()
    End Sub

    Private Sub Btn_UpdatePhone_Click(sender As Object, e As EventArgs) Handles btn_UpdatePhone.Click
        Dim updateNumber = New frm_UpdatePhoneNumber
        updateNumber.Show()
    End Sub

    Private Sub Btn_AddNewCustomer_Click(sender As Object, e As EventArgs) Handles btn_AddNewCustomer.Click
        Dim addForm = New frm_AddNewCustomer With {.Opener = Me}
        addForm.Show()
    End Sub

    Private Sub Dgv_Customers_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Customers.UserDeletingRow
        Using db As New Database(My.Settings.Username, My.Settings.Password)
            db.RemovePerson(CType(e.Row.Cells(2).Value, String))
        End Using
    End Sub

    Public Overrides Sub refresh()
        'This line of code loads data into the 'Media_MinistryDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.MediaMinistryDataSet.CUSTOMERS)
    End Sub

    Private Sub Dgv_Customers_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Customers.CellEndEdit
        Dim changedRow As Integer = e.RowIndex

        'get values from table
        Dim phone As String = CType(dgv_Customers.Rows(changedRow).Cells(2).Value, String)
        Dim street As String = CType(dgv_Customers.Rows(changedRow).Cells(3).Value, String)
        Dim city As String = CType(dgv_Customers.Rows(changedRow).Cells(4).Value, String)
        Dim state As String = CType(dgv_Customers.Rows(changedRow).Cells(5).Value, String)
        Dim zip As String = CType(dgv_Customers.Rows(changedRow).Cells(6).Value, String)
        Dim email As String = CType(dgv_Customers.Rows(changedRow).Cells(7).Value, String)
        Dim payment As String = CType(dgv_Customers.Rows(changedRow).Cells(8).Value, String)

        Using db = New Database(My.Settings.Username, My.Settings.Password)
            db.UpdateCustomerInfo(street, city, state, zip, email, payment, phone)
        End Using
    End Sub

End Class