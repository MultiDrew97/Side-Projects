<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_DisplayCustomers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DisplayCustomers))
        Me.CustomersTableAdapter = New MediaMinistryDataSetTableAdapters.CUSTOMERSTableAdapter()
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
        Me.MediaMinistryDataSet = New MediaMinistryDataSet()
        Me.ss_CustomerView = New System.Windows.Forms.StatusStrip()
        Me.tss_CustomersView = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_UpdatePhone = New System.Windows.Forms.Button()
        Me.btn_AddNewCustomer = New System.Windows.Forms.Button()
        Me.mnstr_Strip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListenerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListenerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListenersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv_Customers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ss_CustomerView.SuspendLayout()
        Me.mnstr_Strip.SuspendLayout()
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
        Me.dgv_Customers.Location = New System.Drawing.Point(0, 24)
        Me.dgv_Customers.Name = "dgv_Customers"
        Me.dgv_Customers.Size = New System.Drawing.Size(1109, 381)
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
        Me.CUSTOMERSBindingSource.DataSource = Me.MediaMinistryDataSet
        '
        'MediaMinistryDataSet
        '
        Me.MediaMinistryDataSet.DataSetName = "Media_MinistryDataSet"
        Me.MediaMinistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ss_CustomerView
        '
        Me.ss_CustomerView.BackColor = System.Drawing.SystemColors.Control
        Me.ss_CustomerView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ss_CustomerView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_CustomersView})
        Me.ss_CustomerView.Location = New System.Drawing.Point(0, 518)
        Me.ss_CustomerView.Name = "ss_CustomerView"
        Me.ss_CustomerView.Size = New System.Drawing.Size(1109, 22)
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
        Me.btn_UpdatePhone.Location = New System.Drawing.Point(156, 431)
        Me.btn_UpdatePhone.Name = "btn_UpdatePhone"
        Me.btn_UpdatePhone.Size = New System.Drawing.Size(270, 65)
        Me.btn_UpdatePhone.TabIndex = 4
        Me.btn_UpdatePhone.Text = "Update Phone Number"
        Me.btn_UpdatePhone.UseVisualStyleBackColor = True
        '
        'btn_AddNewCustomer
        '
        Me.btn_AddNewCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddNewCustomer.Location = New System.Drawing.Point(686, 431)
        Me.btn_AddNewCustomer.Name = "btn_AddNewCustomer"
        Me.btn_AddNewCustomer.Size = New System.Drawing.Size(270, 65)
        Me.btn_AddNewCustomer.TabIndex = 1
        Me.btn_AddNewCustomer.Text = "Add New Customer"
        Me.btn_AddNewCustomer.UseVisualStyleBackColor = True
        '
        'mnstr_Strip
        '
        Me.mnstr_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.mnstr_Strip.Location = New System.Drawing.Point(0, 0)
        Me.mnstr_Strip.Name = "mnstr_Strip"
        Me.mnstr_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnstr_Strip.Size = New System.Drawing.Size(1109, 24)
        Me.mnstr_Strip.TabIndex = 5
        Me.mnstr_Strip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.toolStripSeparator1, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.ProductToolStripMenuItem, Me.ListenerToolStripMenuItem})
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.NewToolStripMenuItem.Text = "&New..."
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ProductToolStripMenuItem.Text = "Product"
        '
        'ListenerToolStripMenuItem
        '
        Me.ListenerToolStripMenuItem.Name = "ListenerToolStripMenuItem"
        Me.ListenerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ListenerToolStripMenuItem.Text = "Listener"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(109, 6)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.MediaMinistry.My.Resources.Resources.logout_button
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "&Logout"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem1.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem1, Me.ProductToolStripMenuItem1, Me.ListenerToolStripMenuItem1})
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.CustomizeToolStripMenuItem.Text = "Find..."
        '
        'CustomerToolStripMenuItem1
        '
        Me.CustomerToolStripMenuItem1.Name = "CustomerToolStripMenuItem1"
        Me.CustomerToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem1.Text = "Customer"
        '
        'ProductToolStripMenuItem1
        '
        Me.ProductToolStripMenuItem1.Name = "ProductToolStripMenuItem1"
        Me.ProductToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.ProductToolStripMenuItem1.Text = "Product"
        '
        'ListenerToolStripMenuItem1
        '
        Me.ListenerToolStripMenuItem1.Name = "ListenerToolStripMenuItem1"
        Me.ListenerToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.ListenerToolStripMenuItem1.Text = "Listener"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.OptionsToolStripMenuItem.Text = "Update"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomersToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.ListenersToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'ListenersToolStripMenuItem
        '
        Me.ListenersToolStripMenuItem.Name = "ListenersToolStripMenuItem"
        Me.ListenersToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ListenersToolStripMenuItem.Text = "Listeners"
        '
        'frm_DisplayCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1109, 540)
        Me.Controls.Add(Me.dgv_Customers)
        Me.Controls.Add(Me.btn_UpdatePhone)
        Me.Controls.Add(Me.ss_CustomerView)
        Me.Controls.Add(Me.btn_AddNewCustomer)
        Me.Controls.Add(Me.mnstr_Strip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_DisplayCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        CType(Me.dgv_Customers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ss_CustomerView.ResumeLayout(False)
        Me.ss_CustomerView.PerformLayout()
        Me.mnstr_Strip.ResumeLayout(False)
        Me.mnstr_Strip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomersTableAdapter As MediaMinistryDataSetTableAdapters.CUSTOMERSTableAdapter
    Friend WithEvents dgv_Customers As DataGridView
    Friend WithEvents CUSTOMERSBindingSource As BindingSource
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
    Friend WithEvents MediaMinistryDataSet As MediaMinistryDataSet
    Friend WithEvents mnstr_Strip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListenerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListenerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListenersToolStripMenuItem As ToolStripMenuItem
End Class
