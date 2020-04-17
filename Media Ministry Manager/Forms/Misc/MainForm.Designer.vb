<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.btn_placeOrder = New System.Windows.Forms.Button()
        Me.btn_ShowOrders = New System.Windows.Forms.Button()
        Me.btn_ProductManagement = New System.Windows.Forms.Button()
        Me.btn_CustomerManagement = New System.Windows.Forms.Button()
        Me.ss_Queries = New System.Windows.Forms.StatusStrip()
        Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tss_Progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.bw_CreateUploader = New System.ComponentModel.BackgroundWorker()
        Me.btn_EmailMinistry = New System.Windows.Forms.Button()
        Me.bw_UpdateJar = New System.ComponentModel.BackgroundWorker()
        Me.pnl_MainForm = New System.Windows.Forms.Panel()
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
        Me.wb_Updater = New System.Windows.Forms.WebBrowser()
        Me.tctl_Max = New System.Windows.Forms.TabControl()
        Me.Customer_Manager = New System.Windows.Forms.TabPage()
        Me.dgv_Customers = New System.Windows.Forms.DataGridView()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHIPPINGSTREETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHIPPINGCITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHIPPINGSTATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHIPPINGZIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONENUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PREFERREDPAYMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOINDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersBinding = New System.Windows.Forms.BindingSource(Me.components)
        Me.Media_MinistryDataSet = New Media_Ministry.Media_MinistryDataSet()
        Me.Order_Manager = New System.Windows.Forms.TabPage()
        Me.dgv_Orders = New System.Windows.Forms.DataGridView()
        Me.ORDERNUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONENUMBERDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDERSUMMARYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventory_Manager = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ITEMINDEXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INSTOCKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVENTORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Email_Ministry = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILLISTENERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnl_Buttons = New System.Windows.Forms.Panel()
        Me.bw_Grow = New System.ComponentModel.BackgroundWorker()
        Me.bw_Shrink = New System.ComponentModel.BackgroundWorker()
        Me.CUSTOMERSTable = New Media_Ministry.Media_MinistryDataSetTableAdapters.CUSTOMERSTableAdapter()
        Me.INVENTORYTableAdapter = New Media_Ministry.Media_MinistryDataSetTableAdapters.INVENTORYTableAdapter()
        Me.EMAIL_LISTENERSTableAdapter = New Media_Ministry.Media_MinistryDataSetTableAdapters.EMAIL_LISTENERSTableAdapter()
        Me.ORDER_SUMMARYTableAdapter = New Media_Ministry.Media_MinistryDataSetTableAdapters.ORDER_SUMMARYTableAdapter()
        Me.pnl_Max = New System.Windows.Forms.Panel()
        Me.ss_Queries.SuspendLayout()
        Me.pnl_MainForm.SuspendLayout()
        Me.mnstr_Strip.SuspendLayout()
        Me.tctl_Max.SuspendLayout()
        Me.Customer_Manager.SuspendLayout()
        CType(Me.dgv_Customers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBinding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Media_MinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Order_Manager.SuspendLayout()
        CType(Me.dgv_Orders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERSUMMARYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Inventory_Manager.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Email_Ministry.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMAILLISTENERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Buttons.SuspendLayout()
        Me.pnl_Max.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_placeOrder
        '
        Me.btn_placeOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_placeOrder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_placeOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_placeOrder.Location = New System.Drawing.Point(85, 108)
        Me.btn_placeOrder.Name = "btn_placeOrder"
        Me.btn_placeOrder.Size = New System.Drawing.Size(226, 43)
        Me.btn_placeOrder.TabIndex = 2
        Me.btn_placeOrder.Text = "Place an Order"
        Me.btn_placeOrder.UseVisualStyleBackColor = True
        '
        'btn_ShowOrders
        '
        Me.btn_ShowOrders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ShowOrders.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_ShowOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ShowOrders.Location = New System.Drawing.Point(85, 183)
        Me.btn_ShowOrders.Name = "btn_ShowOrders"
        Me.btn_ShowOrders.Size = New System.Drawing.Size(226, 43)
        Me.btn_ShowOrders.TabIndex = 3
        Me.btn_ShowOrders.Text = "Show Orders"
        Me.btn_ShowOrders.UseVisualStyleBackColor = True
        '
        'btn_ProductManagement
        '
        Me.btn_ProductManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ProductManagement.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_ProductManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ProductManagement.Location = New System.Drawing.Point(85, 258)
        Me.btn_ProductManagement.Name = "btn_ProductManagement"
        Me.btn_ProductManagement.Size = New System.Drawing.Size(226, 43)
        Me.btn_ProductManagement.TabIndex = 4
        Me.btn_ProductManagement.Text = "Product Management"
        Me.btn_ProductManagement.UseVisualStyleBackColor = True
        '
        'btn_CustomerManagement
        '
        Me.btn_CustomerManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CustomerManagement.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_CustomerManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CustomerManagement.Location = New System.Drawing.Point(85, 33)
        Me.btn_CustomerManagement.Name = "btn_CustomerManagement"
        Me.btn_CustomerManagement.Size = New System.Drawing.Size(226, 43)
        Me.btn_CustomerManagement.TabIndex = 1
        Me.btn_CustomerManagement.Text = "Customer Management"
        Me.btn_CustomerManagement.UseVisualStyleBackColor = True
        '
        'ss_Queries
        '
        Me.ss_Queries.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback, Me.tss_Progress})
        Me.ss_Queries.Location = New System.Drawing.Point(0, 391)
        Me.ss_Queries.Name = "ss_Queries"
        Me.ss_Queries.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ss_Queries.Size = New System.Drawing.Size(397, 22)
        Me.ss_Queries.TabIndex = 0
        '
        'tss_Feedback
        '
        Me.tss_Feedback.Name = "tss_Feedback"
        Me.tss_Feedback.Size = New System.Drawing.Size(151, 17)
        Me.tss_Feedback.Text = "What would you like to do?"
        '
        'tss_Progress
        '
        Me.tss_Progress.Margin = New System.Windows.Forms.Padding(50, 3, 1, 3)
        Me.tss_Progress.Name = "tss_Progress"
        Me.tss_Progress.Size = New System.Drawing.Size(100, 16)
        Me.tss_Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'btn_EmailMinistry
        '
        Me.btn_EmailMinistry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_EmailMinistry.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_EmailMinistry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_EmailMinistry.Location = New System.Drawing.Point(85, 333)
        Me.btn_EmailMinistry.Name = "btn_EmailMinistry"
        Me.btn_EmailMinistry.Size = New System.Drawing.Size(226, 43)
        Me.btn_EmailMinistry.TabIndex = 5
        Me.btn_EmailMinistry.Text = "Email Ministry"
        Me.btn_EmailMinistry.UseVisualStyleBackColor = True
        '
        'bw_UpdateJar
        '
        Me.bw_UpdateJar.WorkerReportsProgress = True
        '
        'pnl_MainForm
        '
        Me.pnl_MainForm.BackColor = System.Drawing.Color.Transparent
        Me.pnl_MainForm.BackgroundImage = Global.Media_Ministry.My.Resources.Resources.Media_Ministry_Logo
        Me.pnl_MainForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl_MainForm.Controls.Add(Me.mnstr_Strip)
        Me.pnl_MainForm.Controls.Add(Me.pnl_Buttons)
        Me.pnl_MainForm.Controls.Add(Me.wb_Updater)
        Me.pnl_MainForm.Controls.Add(Me.pnl_Max)
        Me.pnl_MainForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_MainForm.Location = New System.Drawing.Point(0, 0)
        Me.pnl_MainForm.Name = "pnl_MainForm"
        Me.pnl_MainForm.Size = New System.Drawing.Size(397, 413)
        Me.pnl_MainForm.TabIndex = 0
        '
        'mnstr_Strip
        '
        Me.mnstr_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.mnstr_Strip.Location = New System.Drawing.Point(0, 0)
        Me.mnstr_Strip.Name = "mnstr_Strip"
        Me.mnstr_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnstr_Strip.Size = New System.Drawing.Size(397, 24)
        Me.mnstr_Strip.TabIndex = 0
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
        Me.LogoutToolStripMenuItem.Image = Global.Media_Ministry.My.Resources.Resources.logout_button
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
        'wb_Updater
        '
        Me.wb_Updater.Location = New System.Drawing.Point(340, 335)
        Me.wb_Updater.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb_Updater.Name = "wb_Updater"
        Me.wb_Updater.Size = New System.Drawing.Size(45, 36)
        Me.wb_Updater.TabIndex = 6
        Me.wb_Updater.Visible = False
        '
        'tctl_Max
        '
        Me.tctl_Max.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tctl_Max.Controls.Add(Me.Customer_Manager)
        Me.tctl_Max.Controls.Add(Me.Order_Manager)
        Me.tctl_Max.Controls.Add(Me.Inventory_Manager)
        Me.tctl_Max.Controls.Add(Me.Email_Ministry)
        Me.tctl_Max.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tctl_Max.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tctl_Max.HotTrack = True
        Me.tctl_Max.Location = New System.Drawing.Point(0, 0)
        Me.tctl_Max.Multiline = True
        Me.tctl_Max.Name = "tctl_Max"
        Me.tctl_Max.SelectedIndex = 0
        Me.tctl_Max.Size = New System.Drawing.Size(1366, 667)
        Me.tctl_Max.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tctl_Max.TabIndex = 7
        '
        'Customer_Manager
        '
        Me.Customer_Manager.Controls.Add(Me.dgv_Customers)
        Me.Customer_Manager.Location = New System.Drawing.Point(4, 32)
        Me.Customer_Manager.Name = "Customer_Manager"
        Me.Customer_Manager.Padding = New System.Windows.Forms.Padding(3)
        Me.Customer_Manager.Size = New System.Drawing.Size(1358, 631)
        Me.Customer_Manager.TabIndex = 0
        Me.Customer_Manager.Text = "Customers"
        Me.Customer_Manager.UseVisualStyleBackColor = True
        '
        'dgv_Customers
        '
        Me.dgv_Customers.AutoGenerateColumns = False
        Me.dgv_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Customers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Customers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Customers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Customers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.SHIPPINGSTREETDataGridViewTextBoxColumn, Me.SHIPPINGCITYDataGridViewTextBoxColumn, Me.SHIPPINGSTATEDataGridViewTextBoxColumn, Me.SHIPPINGZIPDataGridViewTextBoxColumn, Me.PHONENUMBERDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.PREFERREDPAYMENTDataGridViewTextBoxColumn, Me.JOINDATEDataGridViewTextBoxColumn})
        Me.dgv_Customers.DataSource = Me.CustomersBinding
        Me.dgv_Customers.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgv_Customers.Location = New System.Drawing.Point(3, 3)
        Me.dgv_Customers.Name = "dgv_Customers"
        Me.dgv_Customers.Size = New System.Drawing.Size(1148, 625)
        Me.dgv_Customers.TabIndex = 0
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
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
        Me.SHIPPINGSTATEDataGridViewTextBoxColumn.HeaderText = "State"
        Me.SHIPPINGSTATEDataGridViewTextBoxColumn.MaxInputLength = 2
        Me.SHIPPINGSTATEDataGridViewTextBoxColumn.Name = "SHIPPINGSTATEDataGridViewTextBoxColumn"
        '
        'SHIPPINGZIPDataGridViewTextBoxColumn
        '
        Me.SHIPPINGZIPDataGridViewTextBoxColumn.DataPropertyName = "SHIPPING_ZIP"
        Me.SHIPPINGZIPDataGridViewTextBoxColumn.HeaderText = "ZIP Code"
        Me.SHIPPINGZIPDataGridViewTextBoxColumn.MaxInputLength = 5
        Me.SHIPPINGZIPDataGridViewTextBoxColumn.Name = "SHIPPINGZIPDataGridViewTextBoxColumn"
        '
        'PHONENUMBERDataGridViewTextBoxColumn
        '
        Me.PHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE_NUMBER"
        Me.PHONENUMBERDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PHONENUMBERDataGridViewTextBoxColumn.MaxInputLength = 12
        Me.PHONENUMBERDataGridViewTextBoxColumn.Name = "PHONENUMBERDataGridViewTextBoxColumn"
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "Email Address"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        '
        'PREFERREDPAYMENTDataGridViewTextBoxColumn
        '
        Me.PREFERREDPAYMENTDataGridViewTextBoxColumn.DataPropertyName = "PREFERRED_PAYMENT"
        Me.PREFERREDPAYMENTDataGridViewTextBoxColumn.HeaderText = "Payment Type"
        Me.PREFERREDPAYMENTDataGridViewTextBoxColumn.Name = "PREFERREDPAYMENTDataGridViewTextBoxColumn"
        '
        'JOINDATEDataGridViewTextBoxColumn
        '
        Me.JOINDATEDataGridViewTextBoxColumn.DataPropertyName = "JOIN_DATE"
        Me.JOINDATEDataGridViewTextBoxColumn.HeaderText = "Join Date"
        Me.JOINDATEDataGridViewTextBoxColumn.Name = "JOINDATEDataGridViewTextBoxColumn"
        Me.JOINDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomersBinding
        '
        Me.CustomersBinding.DataMember = "CUSTOMERS"
        Me.CustomersBinding.DataSource = Me.Media_MinistryDataSet
        '
        'Media_MinistryDataSet
        '
        Me.Media_MinistryDataSet.DataSetName = "Media_MinistryDataSet"
        Me.Media_MinistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Order_Manager
        '
        Me.Order_Manager.Controls.Add(Me.dgv_Orders)
        Me.Order_Manager.Location = New System.Drawing.Point(4, 32)
        Me.Order_Manager.Name = "Order_Manager"
        Me.Order_Manager.Size = New System.Drawing.Size(1358, 631)
        Me.Order_Manager.TabIndex = 2
        Me.Order_Manager.Text = "Orders"
        Me.Order_Manager.UseVisualStyleBackColor = True
        '
        'dgv_Orders
        '
        Me.dgv_Orders.AutoGenerateColumns = False
        Me.dgv_Orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Orders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ORDERNUMBERDataGridViewTextBoxColumn, Me.PHONENUMBERDataGridViewTextBoxColumn1, Me.ITEMDataGridViewTextBoxColumn1, Me.QUANTITYDataGridViewTextBoxColumn})
        Me.dgv_Orders.DataSource = Me.ORDERSUMMARYBindingSource
        Me.dgv_Orders.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgv_Orders.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Orders.Name = "dgv_Orders"
        Me.dgv_Orders.Size = New System.Drawing.Size(435, 631)
        Me.dgv_Orders.TabIndex = 0
        '
        'ORDERNUMBERDataGridViewTextBoxColumn
        '
        Me.ORDERNUMBERDataGridViewTextBoxColumn.DataPropertyName = "ORDER_NUMBER"
        Me.ORDERNUMBERDataGridViewTextBoxColumn.HeaderText = "ORDER_NUMBER"
        Me.ORDERNUMBERDataGridViewTextBoxColumn.Name = "ORDERNUMBERDataGridViewTextBoxColumn"
        Me.ORDERNUMBERDataGridViewTextBoxColumn.Width = 172
        '
        'PHONENUMBERDataGridViewTextBoxColumn1
        '
        Me.PHONENUMBERDataGridViewTextBoxColumn1.DataPropertyName = "PHONE_NUMBER"
        Me.PHONENUMBERDataGridViewTextBoxColumn1.HeaderText = "PHONE_NUMBER"
        Me.PHONENUMBERDataGridViewTextBoxColumn1.Name = "PHONENUMBERDataGridViewTextBoxColumn1"
        Me.PHONENUMBERDataGridViewTextBoxColumn1.Width = 169
        '
        'ITEMDataGridViewTextBoxColumn1
        '
        Me.ITEMDataGridViewTextBoxColumn1.DataPropertyName = "ITEM"
        Me.ITEMDataGridViewTextBoxColumn1.HeaderText = "ITEM"
        Me.ITEMDataGridViewTextBoxColumn1.Name = "ITEMDataGridViewTextBoxColumn1"
        Me.ITEMDataGridViewTextBoxColumn1.Width = 72
        '
        'QUANTITYDataGridViewTextBoxColumn
        '
        Me.QUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.Name = "QUANTITYDataGridViewTextBoxColumn"
        Me.QUANTITYDataGridViewTextBoxColumn.Width = 114
        '
        'ORDERSUMMARYBindingSource
        '
        Me.ORDERSUMMARYBindingSource.DataMember = "ORDER_SUMMARY"
        Me.ORDERSUMMARYBindingSource.DataSource = Me.Media_MinistryDataSet
        '
        'Inventory_Manager
        '
        Me.Inventory_Manager.Controls.Add(Me.DataGridView2)
        Me.Inventory_Manager.Location = New System.Drawing.Point(4, 32)
        Me.Inventory_Manager.Name = "Inventory_Manager"
        Me.Inventory_Manager.Padding = New System.Windows.Forms.Padding(3)
        Me.Inventory_Manager.Size = New System.Drawing.Size(1358, 631)
        Me.Inventory_Manager.TabIndex = 1
        Me.Inventory_Manager.Text = "Inventory"
        Me.Inventory_Manager.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEMINDEXDataGridViewTextBoxColumn, Me.ITEMDataGridViewTextBoxColumn, Me.INSTOCKDataGridViewTextBoxColumn, Me.PRICEDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.INVENTORYBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataGridView2.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(443, 625)
        Me.DataGridView2.TabIndex = 0
        '
        'ITEMINDEXDataGridViewTextBoxColumn
        '
        Me.ITEMINDEXDataGridViewTextBoxColumn.DataPropertyName = "ITEM_INDEX"
        Me.ITEMINDEXDataGridViewTextBoxColumn.HeaderText = "ITEM_INDEX"
        Me.ITEMINDEXDataGridViewTextBoxColumn.Name = "ITEMINDEXDataGridViewTextBoxColumn"
        '
        'ITEMDataGridViewTextBoxColumn
        '
        Me.ITEMDataGridViewTextBoxColumn.DataPropertyName = "ITEM"
        Me.ITEMDataGridViewTextBoxColumn.HeaderText = "ITEM"
        Me.ITEMDataGridViewTextBoxColumn.Name = "ITEMDataGridViewTextBoxColumn"
        '
        'INSTOCKDataGridViewTextBoxColumn
        '
        Me.INSTOCKDataGridViewTextBoxColumn.DataPropertyName = "IN_STOCK"
        Me.INSTOCKDataGridViewTextBoxColumn.HeaderText = "IN_STOCK"
        Me.INSTOCKDataGridViewTextBoxColumn.Name = "INSTOCKDataGridViewTextBoxColumn"
        '
        'PRICEDataGridViewTextBoxColumn
        '
        Me.PRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE"
        Me.PRICEDataGridViewTextBoxColumn.HeaderText = "PRICE"
        Me.PRICEDataGridViewTextBoxColumn.Name = "PRICEDataGridViewTextBoxColumn"
        '
        'INVENTORYBindingSource
        '
        Me.INVENTORYBindingSource.DataMember = "INVENTORY"
        Me.INVENTORYBindingSource.DataSource = Me.Media_MinistryDataSet
        '
        'Email_Ministry
        '
        Me.Email_Ministry.Controls.Add(Me.DataGridView3)
        Me.Email_Ministry.Location = New System.Drawing.Point(4, 32)
        Me.Email_Ministry.Name = "Email_Ministry"
        Me.Email_Ministry.Size = New System.Drawing.Size(1358, 631)
        Me.Email_Ministry.TabIndex = 3
        Me.Email_Ministry.Text = "Email Ministry"
        Me.Email_Ministry.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NAMEDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn1})
        Me.DataGridView3.DataSource = Me.EMAILLISTENERSBindingSource
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataGridView3.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(627, 631)
        Me.DataGridView3.TabIndex = 0
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        '
        'EMAILDataGridViewTextBoxColumn1
        '
        Me.EMAILDataGridViewTextBoxColumn1.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn1.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn1.Name = "EMAILDataGridViewTextBoxColumn1"
        '
        'EMAILLISTENERSBindingSource
        '
        Me.EMAILLISTENERSBindingSource.DataMember = "EMAIL_LISTENERS"
        Me.EMAILLISTENERSBindingSource.DataSource = Me.Media_MinistryDataSet
        '
        'pnl_Buttons
        '
        Me.pnl_Buttons.Controls.Add(Me.btn_ProductManagement)
        Me.pnl_Buttons.Controls.Add(Me.btn_placeOrder)
        Me.pnl_Buttons.Controls.Add(Me.btn_ShowOrders)
        Me.pnl_Buttons.Controls.Add(Me.btn_EmailMinistry)
        Me.pnl_Buttons.Controls.Add(Me.btn_CustomerManagement)
        Me.pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_Buttons.Location = New System.Drawing.Point(0, 0)
        Me.pnl_Buttons.Name = "pnl_Buttons"
        Me.pnl_Buttons.Size = New System.Drawing.Size(397, 413)
        Me.pnl_Buttons.TabIndex = 8
        '
        'bw_Grow
        '
        '
        'bw_Shrink
        '
        '
        'CUSTOMERSTable
        '
        Me.CUSTOMERSTable.ClearBeforeFill = True
        '
        'INVENTORYTableAdapter
        '
        Me.INVENTORYTableAdapter.ClearBeforeFill = True
        '
        'EMAIL_LISTENERSTableAdapter
        '
        Me.EMAIL_LISTENERSTableAdapter.ClearBeforeFill = True
        '
        'ORDER_SUMMARYTableAdapter
        '
        Me.ORDER_SUMMARYTableAdapter.ClearBeforeFill = True
        '
        'pnl_Max
        '
        Me.pnl_Max.Controls.Add(Me.tctl_Max)
        Me.pnl_Max.Location = New System.Drawing.Point(0, 23)
        Me.pnl_Max.Name = "pnl_Max"
        Me.pnl_Max.Size = New System.Drawing.Size(1366, 667)
        Me.pnl_Max.TabIndex = 6
        Me.pnl_Max.Visible = False
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Media_Ministry.My.Resources.Resources.Media_Ministry_Logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(397, 413)
        Me.Controls.Add(Me.ss_Queries)
        Me.Controls.Add(Me.pnl_MainForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnstr_Strip
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.ss_Queries.ResumeLayout(False)
        Me.ss_Queries.PerformLayout()
        Me.pnl_MainForm.ResumeLayout(False)
        Me.pnl_MainForm.PerformLayout()
        Me.mnstr_Strip.ResumeLayout(False)
        Me.mnstr_Strip.PerformLayout()
        Me.tctl_Max.ResumeLayout(False)
        Me.Customer_Manager.ResumeLayout(False)
        CType(Me.dgv_Customers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBinding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Media_MinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Order_Manager.ResumeLayout(False)
        CType(Me.dgv_Orders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERSUMMARYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Inventory_Manager.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Email_Ministry.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMAILLISTENERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Buttons.ResumeLayout(False)
        Me.pnl_Max.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_placeOrder As Button
    Friend WithEvents btn_ShowOrders As Button
    Friend WithEvents btn_ProductManagement As Button
    Friend WithEvents btn_CustomerManagement As Button
    Friend WithEvents ss_Queries As StatusStrip
    Friend WithEvents tss_Feedback As ToolStripStatusLabel
    Friend WithEvents bw_CreateUploader As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_EmailMinistry As Button
    Friend WithEvents bw_UpdateJar As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnl_MainForm As Panel
    Friend WithEvents mnstr_Strip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListenerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListenerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents wb_Updater As WebBrowser
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListenersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tctl_Max As TabControl
    Friend WithEvents Customer_Manager As TabPage
    Friend WithEvents Inventory_Manager As TabPage
    Friend WithEvents Order_Manager As TabPage
    Friend WithEvents Email_Ministry As TabPage
    Friend WithEvents bw_Grow As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_Shrink As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgv_Customers As DataGridView
    Friend WithEvents Media_MinistryDataSet As Media_MinistryDataSet
    Friend WithEvents CustomersBinding As BindingSource
    Friend WithEvents CUSTOMERSTable As Media_MinistryDataSetTableAdapters.CUSTOMERSTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents INVENTORYBindingSource As BindingSource
    Friend WithEvents INVENTORYTableAdapter As Media_MinistryDataSetTableAdapters.INVENTORYTableAdapter
    Friend WithEvents ITEMINDEXDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INSTOCKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents EMAILLISTENERSBindingSource As BindingSource
    Friend WithEvents EMAIL_LISTENERSTableAdapter As Media_MinistryDataSetTableAdapters.EMAIL_LISTENERSTableAdapter
    Friend WithEvents NAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents dgv_Orders As DataGridView
    Friend WithEvents ORDERSUMMARYBindingSource As BindingSource
    Friend WithEvents ORDER_SUMMARYTableAdapter As Media_MinistryDataSetTableAdapters.ORDER_SUMMARYTableAdapter
    Friend WithEvents ORDERNUMBERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PHONENUMBERDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ITEMDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SHIPPINGSTREETDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SHIPPINGCITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SHIPPINGSTATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SHIPPINGZIPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PHONENUMBERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PREFERREDPAYMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JOINDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tss_Progress As ToolStripProgressBar
    Friend WithEvents pnl_Buttons As Panel
    Friend WithEvents pnl_Max As Panel
End Class
