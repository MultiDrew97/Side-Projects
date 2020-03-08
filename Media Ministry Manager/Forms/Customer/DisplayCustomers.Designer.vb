<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DisplayCustomers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DisplayCustomers))
        Me.CustomersTableAdapter = New Media_Ministry.Media_MinistryDataSetTableAdapters.CUSTOMERSTableAdapter()
        Me.dgv_Customers = New System.Windows.Forms.DataGridView()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONENUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHIPPINGSTREETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHIPPINGCITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHIPPINGSTATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHIPPINGZIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PREFERREDPAYMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOINDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Media_MinistryDataSet = New Media_Ministry.Media_MinistryDataSet()
        Me.ss_CustomerView = New System.Windows.Forms.StatusStrip()
        Me.tss_CustomersView = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_UpdatePhone = New System.Windows.Forms.Button()
        Me.btn_AddNewCustomer = New System.Windows.Forms.Button()
        CType(Me.dgv_Customers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Media_MinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ss_CustomerView.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'dgv_Customers
        '
        Me.dgv_Customers.AllowUserToAddRows = False
        Me.dgv_Customers.AutoGenerateColumns = False
        Me.dgv_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Customers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.PHONENUMBERDataGridViewTextBoxColumn, Me.SHIPPINGSTREETDataGridViewTextBoxColumn, Me.SHIPPINGCITYDataGridViewTextBoxColumn, Me.SHIPPINGSTATEDataGridViewTextBoxColumn, Me.SHIPPINGZIPDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.PREFERREDPAYMENTDataGridViewTextBoxColumn, Me.JOINDATEDataGridViewTextBoxColumn})
        Me.dgv_Customers.DataSource = Me.CUSTOMERSBindingSource
        Me.dgv_Customers.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv_Customers.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Customers.Name = "dgv_Customers"
        Me.dgv_Customers.Size = New System.Drawing.Size(1013, 455)
        Me.dgv_Customers.TabIndex = 0
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        Me.LASTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PHONENUMBERDataGridViewTextBoxColumn
        '
        Me.PHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE_NUMBER"
        Me.PHONENUMBERDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PHONENUMBERDataGridViewTextBoxColumn.Name = "PHONENUMBERDataGridViewTextBoxColumn"
        Me.PHONENUMBERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SHIPPINGSTREETDataGridViewTextBoxColumn
        '
        Me.SHIPPINGSTREETDataGridViewTextBoxColumn.DataPropertyName = "SHIPPING_STREET"
        Me.SHIPPINGSTREETDataGridViewTextBoxColumn.HeaderText = "Street"
        Me.SHIPPINGSTREETDataGridViewTextBoxColumn.Name = "SHIPPINGSTREETDataGridViewTextBoxColumn"
        '
        'SHIPPINGCITYDataGridViewTextBoxColumn
        '
        Me.SHIPPINGCITYDataGridViewTextBoxColumn.DataPropertyName = "SHIPPING_CITY"
        Me.SHIPPINGCITYDataGridViewTextBoxColumn.HeaderText = "City"
        Me.SHIPPINGCITYDataGridViewTextBoxColumn.Name = "SHIPPINGCITYDataGridViewTextBoxColumn"
        '
        'SHIPPINGSTATEDataGridViewTextBoxColumn
        '
        Me.SHIPPINGSTATEDataGridViewTextBoxColumn.DataPropertyName = "SHIPPING_STATE"
        Me.SHIPPINGSTATEDataGridViewTextBoxColumn.HeaderText = "ST"
        Me.SHIPPINGSTATEDataGridViewTextBoxColumn.Name = "SHIPPINGSTATEDataGridViewTextBoxColumn"
        '
        'SHIPPINGZIPDataGridViewTextBoxColumn
        '
        Me.SHIPPINGZIPDataGridViewTextBoxColumn.DataPropertyName = "SHIPPING_ZIP"
        Me.SHIPPINGZIPDataGridViewTextBoxColumn.HeaderText = "Zip"
        Me.SHIPPINGZIPDataGridViewTextBoxColumn.Name = "SHIPPINGZIPDataGridViewTextBoxColumn"
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "E-Mail"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        '
        'PREFERREDPAYMENTDataGridViewTextBoxColumn
        '
        Me.PREFERREDPAYMENTDataGridViewTextBoxColumn.DataPropertyName = "PREFERRED_PAYMENT"
        Me.PREFERREDPAYMENTDataGridViewTextBoxColumn.HeaderText = "Payment Preference"
        Me.PREFERREDPAYMENTDataGridViewTextBoxColumn.Name = "PREFERREDPAYMENTDataGridViewTextBoxColumn"
        '
        'JOINDATEDataGridViewTextBoxColumn
        '
        Me.JOINDATEDataGridViewTextBoxColumn.DataPropertyName = "JOIN_DATE"
        Me.JOINDATEDataGridViewTextBoxColumn.HeaderText = "Join Date"
        Me.JOINDATEDataGridViewTextBoxColumn.Name = "JOINDATEDataGridViewTextBoxColumn"
        Me.JOINDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CUSTOMERSBindingSource
        '
        Me.CUSTOMERSBindingSource.DataMember = "CUSTOMERS"
        Me.CUSTOMERSBindingSource.DataSource = Me.Media_MinistryDataSet
        '
        'Media_MinistryDataSet
        '
        Me.Media_MinistryDataSet.DataSetName = "Media_MinistryDataSet"
        Me.Media_MinistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ss_CustomerView
        '
        Me.ss_CustomerView.BackColor = System.Drawing.SystemColors.Control
        Me.ss_CustomerView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ss_CustomerView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_CustomersView})
        Me.ss_CustomerView.Location = New System.Drawing.Point(0, 570)
        Me.ss_CustomerView.Name = "ss_CustomerView"
        Me.ss_CustomerView.Size = New System.Drawing.Size(1013, 22)
        Me.ss_CustomerView.TabIndex = 3
        '
        'tss_CustomersView
        '
        Me.tss_CustomersView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tss_CustomersView.Name = "tss_CustomersView"
        Me.tss_CustomersView.Size = New System.Drawing.Size(170, 17)
        Me.tss_CustomersView.Text = "Here are the current customers"
        '
        'btn_UpdatePhone
        '
        Me.btn_UpdatePhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UpdatePhone.Location = New System.Drawing.Point(106, 480)
        Me.btn_UpdatePhone.Name = "btn_UpdatePhone"
        Me.btn_UpdatePhone.Size = New System.Drawing.Size(270, 65)
        Me.btn_UpdatePhone.TabIndex = 4
        Me.btn_UpdatePhone.Text = "Update Phone Number"
        Me.btn_UpdatePhone.UseVisualStyleBackColor = True
        '
        'btn_AddNewCustomer
        '
        Me.btn_AddNewCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddNewCustomer.Location = New System.Drawing.Point(636, 480)
        Me.btn_AddNewCustomer.Name = "btn_AddNewCustomer"
        Me.btn_AddNewCustomer.Size = New System.Drawing.Size(270, 65)
        Me.btn_AddNewCustomer.TabIndex = 1
        Me.btn_AddNewCustomer.Text = "Add New Customer"
        Me.btn_AddNewCustomer.UseVisualStyleBackColor = True
        '
        'frm_DisplayCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1013, 592)
        Me.Controls.Add(Me.btn_UpdatePhone)
        Me.Controls.Add(Me.ss_CustomerView)
        Me.Controls.Add(Me.btn_AddNewCustomer)
        Me.Controls.Add(Me.dgv_Customers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_DisplayCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        CType(Me.dgv_Customers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Media_MinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ss_CustomerView.ResumeLayout(False)
        Me.ss_CustomerView.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomersTableAdapter As Media_MinistryDataSetTableAdapters.CUSTOMERSTableAdapter
    Friend WithEvents dgv_Customers As DataGridView
    Friend WithEvents CUSTOMERSBindingSource As BindingSource
    Friend WithEvents Media_MinistryDataSet As Media_MinistryDataSet
    Friend WithEvents ss_CustomerView As StatusStrip
    Friend WithEvents tss_CustomersView As ToolStripStatusLabel
    Friend WithEvents btn_UpdatePhone As Button
    Friend WithEvents btn_AddNewCustomer As Button
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PHONENUMBERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SHIPPINGSTREETDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SHIPPINGCITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SHIPPINGSTATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SHIPPINGZIPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PREFERREDPAYMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JOINDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
