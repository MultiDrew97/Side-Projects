Imports MediaMinistry.MediaMinistry

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_DisplayOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_DisplayOrders))
        Me.dgv_Orders = New System.Windows.Forms.DataGridView()
        Me.Selection = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ORDERNUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONENUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDERSUMMARYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaMinistryDataSet = New MediaMinistryDataSet()
        Me.ORDER_SUMMARYTableAdapter = New MediaMinistryDataSetTableAdapters.ORDER_SUMMARYTableAdapter()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Fulfil = New System.Windows.Forms.Button()
        Me.btn_UpdateOrder = New System.Windows.Forms.Button()
        Me.btn_CancelOrder = New System.Windows.Forms.Button()
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
        CType(Me.dgv_Orders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERSUMMARYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnstr_Strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_Orders
        '
        Me.dgv_Orders.AllowUserToAddRows = False
        Me.dgv_Orders.AllowUserToDeleteRows = False
        Me.dgv_Orders.AutoGenerateColumns = False
        Me.dgv_Orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Orders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Selection, Me.ORDERNUMBERDataGridViewTextBoxColumn, Me.PHONENUMBERDataGridViewTextBoxColumn, Me.ITEMDataGridViewTextBoxColumn, Me.QUANTITYDataGridViewTextBoxColumn})
        Me.dgv_Orders.DataSource = Me.ORDERSUMMARYBindingSource
        Me.dgv_Orders.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgv_Orders.Location = New System.Drawing.Point(157, 0)
        Me.dgv_Orders.MultiSelect = False
        Me.dgv_Orders.Name = "dgv_Orders"
        Me.dgv_Orders.Size = New System.Drawing.Size(643, 450)
        Me.dgv_Orders.TabIndex = 0
        '
        'Selection
        '
        Me.Selection.FalseValue = "false"
        Me.Selection.FillWeight = 126.9036!
        Me.Selection.HeaderText = ""
        Me.Selection.Name = "Selection"
        Me.Selection.TrueValue = "true"
        '
        'ORDERNUMBERDataGridViewTextBoxColumn
        '
        Me.ORDERNUMBERDataGridViewTextBoxColumn.DataPropertyName = "ORDER_NUMBER"
        Me.ORDERNUMBERDataGridViewTextBoxColumn.HeaderText = "ORDER_NUMBER"
        Me.ORDERNUMBERDataGridViewTextBoxColumn.Name = "ORDERNUMBERDataGridViewTextBoxColumn"
        '
        'PHONENUMBERDataGridViewTextBoxColumn
        '
        Me.PHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE_NUMBER"
        Me.PHONENUMBERDataGridViewTextBoxColumn.HeaderText = "PHONE_NUMBER"
        Me.PHONENUMBERDataGridViewTextBoxColumn.Name = "PHONENUMBERDataGridViewTextBoxColumn"
        '
        'ITEMDataGridViewTextBoxColumn
        '
        Me.ITEMDataGridViewTextBoxColumn.DataPropertyName = "ITEM"
        Me.ITEMDataGridViewTextBoxColumn.HeaderText = "ITEM"
        Me.ITEMDataGridViewTextBoxColumn.Name = "ITEMDataGridViewTextBoxColumn"
        '
        'QUANTITYDataGridViewTextBoxColumn
        '
        Me.QUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.Name = "QUANTITYDataGridViewTextBoxColumn"
        '
        'ORDERSUMMARYBindingSource
        '
        Me.ORDERSUMMARYBindingSource.DataMember = "ORDER_SUMMARY"
        Me.ORDERSUMMARYBindingSource.DataSource = Me.MediaMinistryDataSet
        '
        'MediaMinistryDataSet
        '
        Me.MediaMinistryDataSet.DataSetName = "Media_MinistryDataSet"
        Me.MediaMinistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ORDER_SUMMARYTableAdapter
        '
        Me.ORDER_SUMMARYTableAdapter.ClearBeforeFill = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(12, 344)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(128, 63)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Fulfil
        '
        Me.btn_Fulfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Fulfil.Location = New System.Drawing.Point(12, 25)
        Me.btn_Fulfil.Name = "btn_Fulfil"
        Me.btn_Fulfil.Size = New System.Drawing.Size(128, 63)
        Me.btn_Fulfil.TabIndex = 1
        Me.btn_Fulfil.Text = "Complete Order(s)"
        Me.btn_Fulfil.UseVisualStyleBackColor = True
        '
        'btn_UpdateOrder
        '
        Me.btn_UpdateOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_UpdateOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UpdateOrder.Location = New System.Drawing.Point(12, 124)
        Me.btn_UpdateOrder.Name = "btn_UpdateOrder"
        Me.btn_UpdateOrder.Size = New System.Drawing.Size(128, 63)
        Me.btn_UpdateOrder.TabIndex = 1
        Me.btn_UpdateOrder.Text = "Update Order(s)"
        Me.btn_UpdateOrder.UseVisualStyleBackColor = True
        '
        'btn_CancelOrder
        '
        Me.btn_CancelOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_CancelOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CancelOrder.Location = New System.Drawing.Point(12, 240)
        Me.btn_CancelOrder.Name = "btn_CancelOrder"
        Me.btn_CancelOrder.Size = New System.Drawing.Size(128, 63)
        Me.btn_CancelOrder.TabIndex = 1
        Me.btn_CancelOrder.Text = "Cancel Order(s)"
        Me.btn_CancelOrder.UseVisualStyleBackColor = True
        '
        'mnstr_Strip
        '
        Me.mnstr_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.mnstr_Strip.Location = New System.Drawing.Point(0, 0)
        Me.mnstr_Strip.Name = "mnstr_Strip"
        Me.mnstr_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnstr_Strip.Size = New System.Drawing.Size(157, 24)
        Me.mnstr_Strip.TabIndex = 2
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
        'Frm_DisplayOrders
        '
        Me.AcceptButton = Me.btn_Fulfil
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mnstr_Strip)
        Me.Controls.Add(Me.btn_Fulfil)
        Me.Controls.Add(Me.btn_UpdateOrder)
        Me.Controls.Add(Me.btn_CancelOrder)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.dgv_Orders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_DisplayOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        CType(Me.dgv_Orders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERSUMMARYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnstr_Strip.ResumeLayout(False)
        Me.mnstr_Strip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Orders As DataGridView
    Friend WithEvents ORDERSUMMARYBindingSource As BindingSource
    Friend WithEvents ORDER_SUMMARYTableAdapter As MediaMinistryDataSetTableAdapters.ORDER_SUMMARYTableAdapter
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Fulfil As Button
    Friend WithEvents btn_UpdateOrder As Button
    Friend WithEvents btn_CancelOrder As Button
    Friend WithEvents Selection As DataGridViewCheckBoxColumn
    Friend WithEvents MediaMinistryDataSet As MediaMinistryDataSet
    Friend WithEvents ORDERNUMBERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PHONENUMBERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
