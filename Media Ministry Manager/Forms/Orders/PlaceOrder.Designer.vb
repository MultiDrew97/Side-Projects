<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_PlaceOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PlaceOrder))
        Me.cbx_ItemName = New System.Windows.Forms.ComboBox()
        Me.INVENTORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaMinistryDataSet = New MediaMinistryDataSet()
        Me.lbl_ItemName = New System.Windows.Forms.Label()
        Me.ss_AddOrder = New System.Windows.Forms.StatusStrip()
        Me.tss_AddOrder = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cbx_FirstName = New System.Windows.Forms.ComboBox()
        Me.CUSTOMERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_FirstName = New System.Windows.Forms.Label()
        Me.nud_Quantity = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Quantity = New System.Windows.Forms.Label()
        Me.btn_AddOrder = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.cbx_PhoneNumber = New System.Windows.Forms.ComboBox()
        Me.lbl_PhoneNumber = New System.Windows.Forms.Label()
        Me.CUSTOMERSTableAdapter = New MediaMinistryDataSetTableAdapters.CUSTOMERSTableAdapter()
        Me.INVENTORYTableAdapter = New MediaMinistryDataSetTableAdapters.INVENTORYTableAdapter()
        Me.bw_LoadingData = New System.ComponentModel.BackgroundWorker()
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
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ss_AddOrder.SuspendLayout()
        CType(Me.CUSTOMERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnstr_Strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbx_ItemName
        '
        Me.cbx_ItemName.DataSource = Me.INVENTORYBindingSource
        Me.cbx_ItemName.DisplayMember = "ITEM"
        Me.cbx_ItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cbx_ItemName.FormattingEnabled = True
        Me.cbx_ItemName.Location = New System.Drawing.Point(69, 154)
        Me.cbx_ItemName.Name = "cbx_ItemName"
        Me.cbx_ItemName.Size = New System.Drawing.Size(226, 33)
        Me.cbx_ItemName.TabIndex = 5
        '
        'INVENTORYBindingSource
        '
        Me.INVENTORYBindingSource.DataMember = "INVENTORY"
        Me.INVENTORYBindingSource.DataSource = Me.MediaMinistryDataSet
        '
        'MediaMinistryDataSet
        '
        Me.MediaMinistryDataSet.DataSetName = "Media_MinistryDataSet"
        Me.MediaMinistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_ItemName
        '
        Me.lbl_ItemName.AutoSize = True
        Me.lbl_ItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_ItemName.Location = New System.Drawing.Point(66, 136)
        Me.lbl_ItemName.Name = "lbl_ItemName"
        Me.lbl_ItemName.Size = New System.Drawing.Size(49, 15)
        Me.lbl_ItemName.TabIndex = 4
        Me.lbl_ItemName.Text = "Product"
        '
        'ss_AddOrder
        '
        Me.ss_AddOrder.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_AddOrder})
        Me.ss_AddOrder.Location = New System.Drawing.Point(0, 306)
        Me.ss_AddOrder.Name = "ss_AddOrder"
        Me.ss_AddOrder.Size = New System.Drawing.Size(503, 22)
        Me.ss_AddOrder.TabIndex = 10
        '
        'tss_AddOrder
        '
        Me.tss_AddOrder.Name = "tss_AddOrder"
        Me.tss_AddOrder.Size = New System.Drawing.Size(187, 17)
        Me.tss_AddOrder.Text = "Add the information for the order."
        '
        'cbx_FirstName
        '
        Me.cbx_FirstName.DataSource = Me.CUSTOMERSBindingSource
        Me.cbx_FirstName.DisplayMember = "FIRST_NAME"
        Me.cbx_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cbx_FirstName.FormattingEnabled = True
        Me.cbx_FirstName.Location = New System.Drawing.Point(51, 66)
        Me.cbx_FirstName.Name = "cbx_FirstName"
        Me.cbx_FirstName.Size = New System.Drawing.Size(191, 33)
        Me.cbx_FirstName.TabIndex = 1
        '
        'CUSTOMERSBindingSource
        '
        Me.CUSTOMERSBindingSource.DataMember = "CUSTOMERS"
        Me.CUSTOMERSBindingSource.DataSource = Me.MediaMinistryDataSet
        '
        'lbl_FirstName
        '
        Me.lbl_FirstName.AutoSize = True
        Me.lbl_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_FirstName.Location = New System.Drawing.Point(48, 49)
        Me.lbl_FirstName.Name = "lbl_FirstName"
        Me.lbl_FirstName.Size = New System.Drawing.Size(67, 15)
        Me.lbl_FirstName.TabIndex = 0
        Me.lbl_FirstName.Text = "First Name"
        '
        'nud_Quantity
        '
        Me.nud_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.nud_Quantity.Location = New System.Drawing.Point(317, 155)
        Me.nud_Quantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_Quantity.Name = "nud_Quantity"
        Me.nud_Quantity.Size = New System.Drawing.Size(120, 32)
        Me.nud_Quantity.TabIndex = 7
        Me.nud_Quantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_Quantity
        '
        Me.lbl_Quantity.AutoSize = True
        Me.lbl_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_Quantity.Location = New System.Drawing.Point(314, 137)
        Me.lbl_Quantity.Name = "lbl_Quantity"
        Me.lbl_Quantity.Size = New System.Drawing.Size(51, 15)
        Me.lbl_Quantity.TabIndex = 6
        Me.lbl_Quantity.Text = "Quantity"
        '
        'btn_AddOrder
        '
        Me.btn_AddOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_AddOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btn_AddOrder.Location = New System.Drawing.Point(284, 228)
        Me.btn_AddOrder.Name = "btn_AddOrder"
        Me.btn_AddOrder.Size = New System.Drawing.Size(122, 51)
        Me.btn_AddOrder.TabIndex = 8
        Me.btn_AddOrder.Text = "Add Order"
        Me.btn_AddOrder.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btn_Cancel.Location = New System.Drawing.Point(96, 228)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(122, 51)
        Me.btn_Cancel.TabIndex = 9
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'cbx_PhoneNumber
        '
        Me.cbx_PhoneNumber.DataSource = Me.CUSTOMERSBindingSource
        Me.cbx_PhoneNumber.DisplayMember = "PHONE_NUMBER"
        Me.cbx_PhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cbx_PhoneNumber.FormattingEnabled = True
        Me.cbx_PhoneNumber.Location = New System.Drawing.Point(264, 66)
        Me.cbx_PhoneNumber.Name = "cbx_PhoneNumber"
        Me.cbx_PhoneNumber.Size = New System.Drawing.Size(191, 33)
        Me.cbx_PhoneNumber.TabIndex = 3
        '
        'lbl_PhoneNumber
        '
        Me.lbl_PhoneNumber.AutoSize = True
        Me.lbl_PhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_PhoneNumber.Location = New System.Drawing.Point(261, 49)
        Me.lbl_PhoneNumber.Name = "lbl_PhoneNumber"
        Me.lbl_PhoneNumber.Size = New System.Drawing.Size(91, 15)
        Me.lbl_PhoneNumber.TabIndex = 2
        Me.lbl_PhoneNumber.Text = "Phone Number"
        '
        'CUSTOMERSTableAdapter
        '
        Me.CUSTOMERSTableAdapter.ClearBeforeFill = True
        '
        'INVENTORYTableAdapter
        '
        Me.INVENTORYTableAdapter.ClearBeforeFill = True
        '
        'mnstr_Strip
        '
        Me.mnstr_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.mnstr_Strip.Location = New System.Drawing.Point(0, 0)
        Me.mnstr_Strip.Name = "mnstr_Strip"
        Me.mnstr_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnstr_Strip.Size = New System.Drawing.Size(503, 24)
        Me.mnstr_Strip.TabIndex = 11
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
        'Frm_PlaceOrder
        '
        Me.AcceptButton = Me.btn_AddOrder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(503, 328)
        Me.Controls.Add(Me.mnstr_Strip)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_AddOrder)
        Me.Controls.Add(Me.lbl_Quantity)
        Me.Controls.Add(Me.nud_Quantity)
        Me.Controls.Add(Me.ss_AddOrder)
        Me.Controls.Add(Me.lbl_PhoneNumber)
        Me.Controls.Add(Me.lbl_FirstName)
        Me.Controls.Add(Me.lbl_ItemName)
        Me.Controls.Add(Me.cbx_PhoneNumber)
        Me.Controls.Add(Me.cbx_FirstName)
        Me.Controls.Add(Me.cbx_ItemName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_PlaceOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ss_AddOrder.ResumeLayout(False)
        Me.ss_AddOrder.PerformLayout()
        CType(Me.CUSTOMERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnstr_Strip.ResumeLayout(False)
        Me.mnstr_Strip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbx_ItemName As ComboBox
    Friend WithEvents lbl_ItemName As Label
    Friend WithEvents ss_AddOrder As StatusStrip
    Friend WithEvents tss_AddOrder As ToolStripStatusLabel
    Friend WithEvents cbx_FirstName As ComboBox
    Friend WithEvents lbl_FirstName As Label
    Friend WithEvents nud_Quantity As NumericUpDown
    Friend WithEvents lbl_Quantity As Label
    Friend WithEvents btn_AddOrder As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents cbx_PhoneNumber As ComboBox
    Friend WithEvents lbl_PhoneNumber As Label
    Friend WithEvents CUSTOMERSBindingSource As BindingSource
    Friend WithEvents CUSTOMERSTableAdapter As MediaMinistryDataSetTableAdapters.CUSTOMERSTableAdapter
    Friend WithEvents INVENTORYBindingSource As BindingSource
    Friend WithEvents INVENTORYTableAdapter As MediaMinistryDataSetTableAdapters.INVENTORYTableAdapter
    Friend WithEvents bw_LoadingData As System.ComponentModel.BackgroundWorker
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
