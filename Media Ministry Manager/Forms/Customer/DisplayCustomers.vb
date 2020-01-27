Option Strict On
Imports System.Data.SqlClient
Public Class frm_DisplayCustomers
    Private db As Database
    Private mainForm As frm_Main

    Public Sub New(ByRef database As Database, ByRef mainForm As frm_Main)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        db = database
        Me.mainForm = mainForm
    End Sub

    Private Sub Display_Customers_Load(sender As Object, e As EventArgs) Handles Me.Load
        customLoad()
    End Sub

    Public Sub customLoad()
        Me.CustomersTableAdapter.Fill(Me.Media_MinistryDataSet.CUSTOMERS)
        For index As Integer = 0 To (dgv_Customers.Rows.Count - 1)
            dgv_Customers.Rows(index).Cells(0).Value = False
        Next
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
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

    Private Sub btn_Remove_Click(sender As Object, e As EventArgs) Handles btn_Remove.Click
        'remove the person from the customer list
        Dim index, removeCount As Integer
        Dim phone As String
        Do
            If dgv_Customers.Rows(index).Cells(0).Value.Equals(True) Then
                phone = dgv_Customers.Rows(index).Cells(3).Value.ToString

                Try
                    db.RemovePerson(phone)
                    dgv_Customers.Rows.RemoveAt(index)
                    removeCount += 1
                Catch
                    tss_CustomersView.Text = "Some people could not be removed. Please try again."
                End Try
            End If

            index += 1
        Loop Until (index >= dgv_Customers.Rows.Count)

        If removeCount > 1 Then
            tss_CustomersView.Text = String.Format("{0} people were removed from the database", removeCount)
        ElseIf removeCount = 1 Then
            tss_CustomersView.Text = "1 person was removed from the database"
        End If
    End Sub

    Private Sub frm_DisplayCustomers_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        mainForm.Show()
    End Sub

    Private Sub btn_UpdatePhone_Click(sender As Object, e As EventArgs) Handles btn_UpdatePhone.Click
        Dim updateNumber = New frm_UpdatePhoneNumber(db, Me)
        updateNumber.Show()
        Me.Hide()
    End Sub

    Private Sub frm_DisplayCustomers_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Me.CustomersTableAdapter.Fill(Me.Media_MinistryDataSet.CUSTOMERS)
    End Sub

    Private Sub btn_AddNewCustomer_Click(sender As Object, e As EventArgs) Handles btn_AddNewCustomer.Click
        Dim addForm = New frm_AddNewCustomer(db, Me)
        addForm.Show()
        Me.Hide()
    End Sub
End Class