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
        Me.ListenerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediaMinistryManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListenersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl_Max = New System.Windows.Forms.Panel()
        Me.tctl_Max = New System.Windows.Forms.TabControl()
        Me.Customer_Manager = New System.Windows.Forms.TabPage()
        Me.lbl_TotalCustomers = New System.Windows.Forms.Label()
        Me.btn_AddCustomer = New System.Windows.Forms.Button()
        Me.dgv_Customers = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersBinding = New System.Windows.Forms.BindingSource(Me.components)
        Me.Media_MinistryDataSet = New Media_Ministry.Media_MinistryDataSet()
        Me.Order_Manager = New System.Windows.Forms.TabPage()
        Me.btn_OrderComplete = New System.Windows.Forms.Button()
        Me.btn_OrderCancel = New System.Windows.Forms.Button()
        Me.gbx_NewOrder = New System.Windows.Forms.GroupBox()
        Me.lbl_Quantity = New System.Windows.Forms.Label()
        Me.lbl_OrderProduct = New System.Windows.Forms.Label()
        Me.lbl_OrderPhone = New System.Windows.Forms.Label()
        Me.lbl_OrderName = New System.Windows.Forms.Label()
        Me.nud_Quantity = New System.Windows.Forms.NumericUpDown()
        Me.btn_CreateOrder = New System.Windows.Forms.Button()
        Me.cbx_OrderProduct = New System.Windows.Forms.ComboBox()
        Me.INVENTORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbx_OrderPhone = New System.Windows.Forms.ComboBox()
        Me.cbx_OrderName = New System.Windows.Forms.ComboBox()
        Me.dgv_Orders = New System.Windows.Forms.DataGridView()
        Me.Select_Order = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDERSUMMARYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventory_Manager = New System.Windows.Forms.TabPage()
        Me.gbx_NewProduct = New System.Windows.Forms.GroupBox()
        Me.dgv_Inventory = New System.Windows.Forms.DataGridView()
        Me.Email_Ministry = New System.Windows.Forms.TabPage()
        Me.lbl_TotalListeners = New System.Windows.Forms.Label()
        Me.gbx_NewListener = New System.Windows.Forms.GroupBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.lbl_ListenerList = New System.Windows.Forms.Label()
        Me.btn_Browse = New System.Windows.Forms.Button()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.txt_FilePath = New System.Windows.Forms.TextBox()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.gbx_Options = New System.Windows.Forms.GroupBox()
        Me.rdo_Multiple = New System.Windows.Forms.RadioButton()
        Me.rdo_Single = New System.Windows.Forms.RadioButton()
        Me.btn_AddListener = New System.Windows.Forms.Button()
        Me.dgv_Listeners = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILLISTENERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnl_Buttons = New System.Windows.Forms.Panel()
        Me.bw_Grow = New System.ComponentModel.BackgroundWorker()
        Me.bw_Shrink = New System.ComponentModel.BackgroundWorker()
        Me.bw_UpdateApp = New System.ComponentModel.BackgroundWorker()
        Me.ofd_ListenerList = New System.Windows.Forms.OpenFileDialog()
        Me.CustomersTableAdapter = New Media_Ministry.Media_MinistryDataSetTableAdapters.CUSTOMERSTableAdapter()
        Me.INVENTORYTableAdapter = New Media_Ministry.Media_MinistryDataSetTableAdapters.INVENTORYTableAdapter()
        Me.ORDER_SUMMARYTableAdapter = New Media_Ministry.Media_MinistryDataSetTableAdapters.ORDER_SUMMARYTableAdapter()
        Me.EMAIL_LISTENERSTableAdapter = New Media_Ministry.Media_MinistryDataSetTableAdapters.EMAIL_LISTENERSTableAdapter()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ss_Queries.SuspendLayout()
        Me.pnl_MainForm.SuspendLayout()
        Me.mnstr_Strip.SuspendLayout()
        Me.pnl_Max.SuspendLayout()
        Me.tctl_Max.SuspendLayout()
        Me.Customer_Manager.SuspendLayout()
        CType(Me.dgv_Customers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBinding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Media_MinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Order_Manager.SuspendLayout()
        Me.gbx_NewOrder.SuspendLayout()
        CType(Me.nud_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Orders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERSUMMARYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Inventory_Manager.SuspendLayout()
        CType(Me.dgv_Inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Email_Ministry.SuspendLayout()
        Me.gbx_NewListener.SuspendLayout()
        Me.gbx_Options.SuspendLayout()
        CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMAILLISTENERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Buttons.SuspendLayout()
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
        Me.pnl_MainForm.Controls.Add(Me.pnl_Max)
        Me.pnl_MainForm.Controls.Add(Me.pnl_Buttons)
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
        Me.CustomizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem1, Me.ListenerToolStripMenuItem1})
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.CustomizeToolStripMenuItem.Text = "Find..."
        '
        'CustomerToolStripMenuItem1
        '
        Me.CustomerToolStripMenuItem1.Name = "CustomerToolStripMenuItem1"
        Me.CustomerToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem1.Text = "Customer"
        '
        'ListenerToolStripMenuItem1
        '
        Me.ListenerToolStripMenuItem1.Name = "ListenerToolStripMenuItem1"
        Me.ListenerToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.ListenerToolStripMenuItem1.Text = "Listener"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MediaMinistryManagerToolStripMenuItem, Me.EmailerToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.OptionsToolStripMenuItem.Text = "Update..."
        '
        'MediaMinistryManagerToolStripMenuItem
        '
        Me.MediaMinistryManagerToolStripMenuItem.Name = "MediaMinistryManagerToolStripMenuItem"
        Me.MediaMinistryManagerToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.MediaMinistryManagerToolStripMenuItem.Text = "Media Ministry Manager"
        '
        'EmailerToolStripMenuItem
        '
        Me.EmailerToolStripMenuItem.Name = "EmailerToolStripMenuItem"
        Me.EmailerToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.EmailerToolStripMenuItem.Text = "Emailer"
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
        'pnl_Max
        '
        Me.pnl_Max.Controls.Add(Me.tctl_Max)
        Me.pnl_Max.Location = New System.Drawing.Point(0, 23)
        Me.pnl_Max.Name = "pnl_Max"
        Me.pnl_Max.Size = New System.Drawing.Size(1366, 667)
        Me.pnl_Max.TabIndex = 6
        Me.pnl_Max.Visible = False
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
        Me.Customer_Manager.Controls.Add(Me.lbl_TotalCustomers)
        Me.Customer_Manager.Controls.Add(Me.btn_AddCustomer)
        Me.Customer_Manager.Controls.Add(Me.dgv_Customers)
        Me.Customer_Manager.Location = New System.Drawing.Point(4, 32)
        Me.Customer_Manager.Name = "Customer_Manager"
        Me.Customer_Manager.Padding = New System.Windows.Forms.Padding(3)
        Me.Customer_Manager.Size = New System.Drawing.Size(1358, 631)
        Me.Customer_Manager.TabIndex = 0
        Me.Customer_Manager.Text = "Customers"
        Me.Customer_Manager.UseVisualStyleBackColor = True
        '
        'lbl_TotalCustomers
        '
        Me.lbl_TotalCustomers.AutoSize = True
        Me.lbl_TotalCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_TotalCustomers.Location = New System.Drawing.Point(971, 549)
        Me.lbl_TotalCustomers.Name = "lbl_TotalCustomers"
        Me.lbl_TotalCustomers.Size = New System.Drawing.Size(83, 26)
        Me.lbl_TotalCustomers.TabIndex = 2
        Me.lbl_TotalCustomers.Text = "Label1"
        '
        'btn_AddCustomer
        '
        Me.btn_AddCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_AddCustomer.Location = New System.Drawing.Point(413, 537)
        Me.btn_AddCustomer.Name = "btn_AddCustomer"
        Me.btn_AddCustomer.Size = New System.Drawing.Size(259, 48)
        Me.btn_AddCustomer.TabIndex = 1
        Me.btn_AddCustomer.Text = "Add New Customer"
        Me.btn_AddCustomer.UseVisualStyleBackColor = True
        '
        'dgv_Customers
        '
        Me.dgv_Customers.AllowUserToAddRows = False
        Me.dgv_Customers.AutoGenerateColumns = False
        Me.dgv_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Customers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Customers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Customers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Customers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dgv_Customers.DataSource = Me.CustomersBinding
        Me.dgv_Customers.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv_Customers.Location = New System.Drawing.Point(3, 3)
        Me.dgv_Customers.Name = "dgv_Customers"
        Me.dgv_Customers.Size = New System.Drawing.Size(1352, 502)
        Me.dgv_Customers.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FIRST_NAME"
        Me.DataGridViewTextBoxColumn1.HeaderText = "FIRST_NAME"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LAST_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "LAST_NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SHIPPING_STREET"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SHIPPING_STREET"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SHIPPING_CITY"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SHIPPING_CITY"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SHIPPING_STATE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SHIPPING_STATE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SHIPPING_ZIP"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SHIPPING_ZIP"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PHONE_NUMBER"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PHONE_NUMBER"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "EMAIL"
        Me.DataGridViewTextBoxColumn8.HeaderText = "EMAIL"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PREFERRED_PAYMENT"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PREFERRED_PAYMENT"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "JOIN_DATE"
        Me.DataGridViewTextBoxColumn10.HeaderText = "JOIN_DATE"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'CustomersBinding
        '
        Me.CustomersBinding.DataMember = "CUSTOMERS"
        Me.CustomersBinding.DataSource = Me.Media_MinistryDataSet
        Me.CustomersBinding.Sort = "FIRST_NAME"
        '
        'Media_MinistryDataSet
        '
        Me.Media_MinistryDataSet.DataSetName = "Media_MinistryDataSet"
        Me.Media_MinistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Order_Manager
        '
        Me.Order_Manager.Controls.Add(Me.btn_OrderComplete)
        Me.Order_Manager.Controls.Add(Me.btn_OrderCancel)
        Me.Order_Manager.Controls.Add(Me.gbx_NewOrder)
        Me.Order_Manager.Controls.Add(Me.dgv_Orders)
        Me.Order_Manager.Location = New System.Drawing.Point(4, 32)
        Me.Order_Manager.Name = "Order_Manager"
        Me.Order_Manager.Size = New System.Drawing.Size(1358, 631)
        Me.Order_Manager.TabIndex = 2
        Me.Order_Manager.Text = "Orders"
        Me.Order_Manager.UseVisualStyleBackColor = True
        '
        'btn_OrderComplete
        '
        Me.btn_OrderComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_OrderComplete.Location = New System.Drawing.Point(1104, 462)
        Me.btn_OrderComplete.Name = "btn_OrderComplete"
        Me.btn_OrderComplete.Size = New System.Drawing.Size(151, 69)
        Me.btn_OrderComplete.TabIndex = 3
        Me.btn_OrderComplete.Text = "Complete Order(s)"
        Me.btn_OrderComplete.UseVisualStyleBackColor = True
        '
        'btn_OrderCancel
        '
        Me.btn_OrderCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_OrderCancel.Location = New System.Drawing.Point(827, 462)
        Me.btn_OrderCancel.Name = "btn_OrderCancel"
        Me.btn_OrderCancel.Size = New System.Drawing.Size(151, 69)
        Me.btn_OrderCancel.TabIndex = 2
        Me.btn_OrderCancel.Text = "Cancel Order(s)"
        Me.btn_OrderCancel.UseVisualStyleBackColor = True
        '
        'gbx_NewOrder
        '
        Me.gbx_NewOrder.Controls.Add(Me.lbl_Quantity)
        Me.gbx_NewOrder.Controls.Add(Me.lbl_OrderProduct)
        Me.gbx_NewOrder.Controls.Add(Me.lbl_OrderPhone)
        Me.gbx_NewOrder.Controls.Add(Me.lbl_OrderName)
        Me.gbx_NewOrder.Controls.Add(Me.nud_Quantity)
        Me.gbx_NewOrder.Controls.Add(Me.btn_CreateOrder)
        Me.gbx_NewOrder.Controls.Add(Me.cbx_OrderProduct)
        Me.gbx_NewOrder.Controls.Add(Me.cbx_OrderPhone)
        Me.gbx_NewOrder.Controls.Add(Me.cbx_OrderName)
        Me.gbx_NewOrder.Location = New System.Drawing.Point(714, 3)
        Me.gbx_NewOrder.Name = "gbx_NewOrder"
        Me.gbx_NewOrder.Size = New System.Drawing.Size(636, 353)
        Me.gbx_NewOrder.TabIndex = 1
        Me.gbx_NewOrder.TabStop = False
        Me.gbx_NewOrder.Text = "Create Order"
        '
        'lbl_Quantity
        '
        Me.lbl_Quantity.AutoSize = True
        Me.lbl_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Quantity.Location = New System.Drawing.Point(405, 170)
        Me.lbl_Quantity.Name = "lbl_Quantity"
        Me.lbl_Quantity.Size = New System.Drawing.Size(136, 26)
        Me.lbl_Quantity.TabIndex = 4
        Me.lbl_Quantity.Text = "How Many?"
        '
        'lbl_OrderProduct
        '
        Me.lbl_OrderProduct.AutoSize = True
        Me.lbl_OrderProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_OrderProduct.Location = New System.Drawing.Point(55, 170)
        Me.lbl_OrderProduct.Name = "lbl_OrderProduct"
        Me.lbl_OrderProduct.Size = New System.Drawing.Size(101, 26)
        Me.lbl_OrderProduct.TabIndex = 4
        Me.lbl_OrderProduct.Text = "Product:"
        '
        'lbl_OrderPhone
        '
        Me.lbl_OrderPhone.AutoSize = True
        Me.lbl_OrderPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_OrderPhone.Location = New System.Drawing.Point(328, 56)
        Me.lbl_OrderPhone.Name = "lbl_OrderPhone"
        Me.lbl_OrderPhone.Size = New System.Drawing.Size(178, 26)
        Me.lbl_OrderPhone.TabIndex = 4
        Me.lbl_OrderPhone.Text = "Phone Number:"
        '
        'lbl_OrderName
        '
        Me.lbl_OrderName.AutoSize = True
        Me.lbl_OrderName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_OrderName.Location = New System.Drawing.Point(24, 56)
        Me.lbl_OrderName.Name = "lbl_OrderName"
        Me.lbl_OrderName.Size = New System.Drawing.Size(82, 26)
        Me.lbl_OrderName.TabIndex = 4
        Me.lbl_OrderName.Text = "Name:"
        '
        'nud_Quantity
        '
        Me.nud_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.nud_Quantity.Location = New System.Drawing.Point(410, 200)
        Me.nud_Quantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_Quantity.Name = "nud_Quantity"
        Me.nud_Quantity.Size = New System.Drawing.Size(120, 32)
        Me.nud_Quantity.TabIndex = 3
        Me.nud_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nud_Quantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btn_CreateOrder
        '
        Me.btn_CreateOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_CreateOrder.Location = New System.Drawing.Point(249, 277)
        Me.btn_CreateOrder.Name = "btn_CreateOrder"
        Me.btn_CreateOrder.Size = New System.Drawing.Size(157, 34)
        Me.btn_CreateOrder.TabIndex = 2
        Me.btn_CreateOrder.Text = "Add Order"
        Me.btn_CreateOrder.UseVisualStyleBackColor = True
        '
        'cbx_OrderProduct
        '
        Me.cbx_OrderProduct.DataSource = Me.INVENTORYBindingSource
        Me.cbx_OrderProduct.DisplayMember = "ITEM"
        Me.cbx_OrderProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.cbx_OrderProduct.FormattingEnabled = True
        Me.cbx_OrderProduct.Location = New System.Drawing.Point(60, 199)
        Me.cbx_OrderProduct.Name = "cbx_OrderProduct"
        Me.cbx_OrderProduct.Size = New System.Drawing.Size(288, 33)
        Me.cbx_OrderProduct.TabIndex = 1
        '
        'INVENTORYBindingSource
        '
        Me.INVENTORYBindingSource.DataMember = "INVENTORY"
        Me.INVENTORYBindingSource.DataSource = Me.Media_MinistryDataSet
        '
        'cbx_OrderPhone
        '
        Me.cbx_OrderPhone.DataSource = Me.CustomersBinding
        Me.cbx_OrderPhone.DisplayMember = "PHONE_NUMBER"
        Me.cbx_OrderPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.cbx_OrderPhone.FormattingEnabled = True
        Me.cbx_OrderPhone.Location = New System.Drawing.Point(333, 85)
        Me.cbx_OrderPhone.Name = "cbx_OrderPhone"
        Me.cbx_OrderPhone.Size = New System.Drawing.Size(288, 33)
        Me.cbx_OrderPhone.TabIndex = 0
        '
        'cbx_OrderName
        '
        Me.cbx_OrderName.DataSource = Me.CustomersBinding
        Me.cbx_OrderName.DisplayMember = "FIRST_NAME"
        Me.cbx_OrderName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.cbx_OrderName.FormattingEnabled = True
        Me.cbx_OrderName.Location = New System.Drawing.Point(29, 85)
        Me.cbx_OrderName.Name = "cbx_OrderName"
        Me.cbx_OrderName.Size = New System.Drawing.Size(288, 33)
        Me.cbx_OrderName.TabIndex = 0
        '
        'dgv_Orders
        '
        Me.dgv_Orders.AllowUserToAddRows = False
        Me.dgv_Orders.AllowUserToDeleteRows = False
        Me.dgv_Orders.AutoGenerateColumns = False
        Me.dgv_Orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Orders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Select_Order, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.dgv_Orders.DataSource = Me.ORDERSUMMARYBindingSource
        Me.dgv_Orders.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgv_Orders.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Orders.Name = "dgv_Orders"
        Me.dgv_Orders.Size = New System.Drawing.Size(708, 631)
        Me.dgv_Orders.TabIndex = 0
        '
        'Select_Order
        '
        Me.Select_Order.FillWeight = 76.14214!
        Me.Select_Order.HeaderText = ""
        Me.Select_Order.Name = "Select_Order"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ORDER_NUMBER"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ORDER_NUMBER"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "PHONE_NUMBER"
        Me.DataGridViewTextBoxColumn15.HeaderText = "PHONE_NUMBER"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ITEM"
        Me.DataGridViewTextBoxColumn16.HeaderText = "ITEM"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "QUANTITY"
        Me.DataGridViewTextBoxColumn17.HeaderText = "QUANTITY"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'ORDERSUMMARYBindingSource
        '
        Me.ORDERSUMMARYBindingSource.DataMember = "ORDER_SUMMARY"
        Me.ORDERSUMMARYBindingSource.DataSource = Me.Media_MinistryDataSet
        '
        'Inventory_Manager
        '
        Me.Inventory_Manager.Controls.Add(Me.gbx_NewProduct)
        Me.Inventory_Manager.Controls.Add(Me.dgv_Inventory)
        Me.Inventory_Manager.Location = New System.Drawing.Point(4, 32)
        Me.Inventory_Manager.Name = "Inventory_Manager"
        Me.Inventory_Manager.Padding = New System.Windows.Forms.Padding(3)
        Me.Inventory_Manager.Size = New System.Drawing.Size(1358, 631)
        Me.Inventory_Manager.TabIndex = 1
        Me.Inventory_Manager.Text = "Inventory"
        Me.Inventory_Manager.UseVisualStyleBackColor = True
        '
        'gbx_NewProduct
        '
        Me.gbx_NewProduct.Location = New System.Drawing.Point(718, 6)
        Me.gbx_NewProduct.Name = "gbx_NewProduct"
        Me.gbx_NewProduct.Size = New System.Drawing.Size(200, 100)
        Me.gbx_NewProduct.TabIndex = 1
        Me.gbx_NewProduct.TabStop = False
        Me.gbx_NewProduct.Text = "Create New Product"
        '
        'dgv_Inventory
        '
        Me.dgv_Inventory.AllowUserToAddRows = False
        Me.dgv_Inventory.AutoGenerateColumns = False
        Me.dgv_Inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Inventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.dgv_Inventory.DataSource = Me.INVENTORYBindingSource
        Me.dgv_Inventory.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgv_Inventory.Location = New System.Drawing.Point(3, 3)
        Me.dgv_Inventory.Name = "dgv_Inventory"
        Me.dgv_Inventory.Size = New System.Drawing.Size(662, 625)
        Me.dgv_Inventory.TabIndex = 0
        '
        'Email_Ministry
        '
        Me.Email_Ministry.Controls.Add(Me.lbl_TotalListeners)
        Me.Email_Ministry.Controls.Add(Me.gbx_NewListener)
        Me.Email_Ministry.Controls.Add(Me.dgv_Listeners)
        Me.Email_Ministry.Location = New System.Drawing.Point(4, 32)
        Me.Email_Ministry.Name = "Email_Ministry"
        Me.Email_Ministry.Size = New System.Drawing.Size(1358, 631)
        Me.Email_Ministry.TabIndex = 3
        Me.Email_Ministry.Text = "Email Ministry"
        Me.Email_Ministry.UseVisualStyleBackColor = True
        '
        'lbl_TotalListeners
        '
        Me.lbl_TotalListeners.AutoSize = True
        Me.lbl_TotalListeners.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_TotalListeners.Location = New System.Drawing.Point(871, 535)
        Me.lbl_TotalListeners.Name = "lbl_TotalListeners"
        Me.lbl_TotalListeners.Size = New System.Drawing.Size(211, 26)
        Me.lbl_TotalListeners.TabIndex = 2
        Me.lbl_TotalListeners.Text = "Total Listeners: {0}"
        '
        'gbx_NewListener
        '
        Me.gbx_NewListener.Controls.Add(Me.lbl_Name)
        Me.gbx_NewListener.Controls.Add(Me.lbl_Email)
        Me.gbx_NewListener.Controls.Add(Me.lbl_ListenerList)
        Me.gbx_NewListener.Controls.Add(Me.btn_Browse)
        Me.gbx_NewListener.Controls.Add(Me.txt_Email)
        Me.gbx_NewListener.Controls.Add(Me.txt_FilePath)
        Me.gbx_NewListener.Controls.Add(Me.txt_Name)
        Me.gbx_NewListener.Controls.Add(Me.gbx_Options)
        Me.gbx_NewListener.Controls.Add(Me.btn_AddListener)
        Me.gbx_NewListener.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.gbx_NewListener.Location = New System.Drawing.Point(633, 3)
        Me.gbx_NewListener.Name = "gbx_NewListener"
        Me.gbx_NewListener.Size = New System.Drawing.Size(717, 339)
        Me.gbx_NewListener.TabIndex = 1
        Me.gbx_NewListener.TabStop = False
        Me.gbx_NewListener.Text = "Add Listener"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Name.Location = New System.Drawing.Point(111, 140)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(82, 26)
        Me.lbl_Name.TabIndex = 7
        Me.lbl_Name.Text = "Name:"
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Email.Location = New System.Drawing.Point(113, 184)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(80, 26)
        Me.lbl_Email.TabIndex = 6
        Me.lbl_Email.Text = "Email:"
        '
        'lbl_ListenerList
        '
        Me.lbl_ListenerList.AutoSize = True
        Me.lbl_ListenerList.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ListenerList.Location = New System.Drawing.Point(65, 158)
        Me.lbl_ListenerList.Name = "lbl_ListenerList"
        Me.lbl_ListenerList.Size = New System.Drawing.Size(128, 26)
        Me.lbl_ListenerList.TabIndex = 5
        Me.lbl_ListenerList.Text = "File Name:"
        Me.lbl_ListenerList.Visible = False
        '
        'btn_Browse
        '
        Me.btn_Browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Browse.Location = New System.Drawing.Point(578, 162)
        Me.btn_Browse.Name = "btn_Browse"
        Me.btn_Browse.Size = New System.Drawing.Size(50, 33)
        Me.btn_Browse.TabIndex = 4
        Me.btn_Browse.Text = "..."
        Me.btn_Browse.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Browse.UseVisualStyleBackColor = True
        Me.btn_Browse.Visible = False
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Email.Location = New System.Drawing.Point(199, 184)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(373, 32)
        Me.txt_Email.TabIndex = 3
        '
        'txt_FilePath
        '
        Me.txt_FilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txt_FilePath.Location = New System.Drawing.Point(199, 162)
        Me.txt_FilePath.Name = "txt_FilePath"
        Me.txt_FilePath.Size = New System.Drawing.Size(373, 32)
        Me.txt_FilePath.TabIndex = 3
        Me.txt_FilePath.Visible = False
        '
        'txt_Name
        '
        Me.txt_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Name.Location = New System.Drawing.Point(199, 137)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(373, 32)
        Me.txt_Name.TabIndex = 3
        '
        'gbx_Options
        '
        Me.gbx_Options.Controls.Add(Me.rdo_Multiple)
        Me.gbx_Options.Controls.Add(Me.rdo_Single)
        Me.gbx_Options.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.gbx_Options.Location = New System.Drawing.Point(148, 31)
        Me.gbx_Options.Name = "gbx_Options"
        Me.gbx_Options.Size = New System.Drawing.Size(486, 81)
        Me.gbx_Options.TabIndex = 2
        Me.gbx_Options.TabStop = False
        Me.gbx_Options.Text = "How Many?"
        '
        'rdo_Multiple
        '
        Me.rdo_Multiple.AutoSize = True
        Me.rdo_Multiple.Location = New System.Drawing.Point(217, 36)
        Me.rdo_Multiple.Name = "rdo_Multiple"
        Me.rdo_Multiple.Size = New System.Drawing.Size(217, 30)
        Me.rdo_Multiple.TabIndex = 1
        Me.rdo_Multiple.Text = "Multiple Listeners"
        Me.rdo_Multiple.UseVisualStyleBackColor = True
        '
        'rdo_Single
        '
        Me.rdo_Single.AutoSize = True
        Me.rdo_Single.Checked = True
        Me.rdo_Single.Location = New System.Drawing.Point(25, 36)
        Me.rdo_Single.Name = "rdo_Single"
        Me.rdo_Single.Size = New System.Drawing.Size(166, 30)
        Me.rdo_Single.TabIndex = 1
        Me.rdo_Single.TabStop = True
        Me.rdo_Single.Text = "One Listener"
        Me.rdo_Single.UseVisualStyleBackColor = True
        '
        'btn_AddListener
        '
        Me.btn_AddListener.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_AddListener.Location = New System.Drawing.Point(287, 264)
        Me.btn_AddListener.Name = "btn_AddListener"
        Me.btn_AddListener.Size = New System.Drawing.Size(170, 54)
        Me.btn_AddListener.TabIndex = 0
        Me.btn_AddListener.Text = "Add Listener"
        Me.btn_AddListener.UseVisualStyleBackColor = True
        '
        'dgv_Listeners
        '
        Me.dgv_Listeners.AllowUserToAddRows = False
        Me.dgv_Listeners.AutoGenerateColumns = False
        Me.dgv_Listeners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Listeners.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.dgv_Listeners.DataSource = Me.EMAILLISTENERSBindingSource
        Me.dgv_Listeners.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgv_Listeners.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Listeners.Name = "dgv_Listeners"
        Me.dgv_Listeners.Size = New System.Drawing.Size(627, 631)
        Me.dgv_Listeners.TabIndex = 0
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "NAME"
        Me.DataGridViewTextBoxColumn18.HeaderText = "NAME"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "EMAIL"
        Me.DataGridViewTextBoxColumn19.HeaderText = "EMAIL"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'EMAILLISTENERSBindingSource
        '
        Me.EMAILLISTENERSBindingSource.DataMember = "EMAIL_LISTENERS"
        Me.EMAILLISTENERSBindingSource.DataSource = Me.Media_MinistryDataSet
        Me.EMAILLISTENERSBindingSource.Sort = "NAME"
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
        'bw_UpdateApp
        '
        Me.bw_UpdateApp.WorkerReportsProgress = True
        '
        'ofd_ListenerList
        '
        Me.ofd_ListenerList.Filter = "List (*.csv)|*.csv"
        Me.ofd_ListenerList.Title = "List of Listeners (.csv)"
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'INVENTORYTableAdapter
        '
        Me.INVENTORYTableAdapter.ClearBeforeFill = True
        '
        'ORDER_SUMMARYTableAdapter
        '
        Me.ORDER_SUMMARYTableAdapter.ClearBeforeFill = True
        '
        'EMAIL_LISTENERSTableAdapter
        '
        Me.EMAIL_LISTENERSTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ITEM"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "IN_STOCK"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Current Stock"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PRICE"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Price per Unit"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
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
        Me.pnl_Max.ResumeLayout(False)
        Me.tctl_Max.ResumeLayout(False)
        Me.Customer_Manager.ResumeLayout(False)
        Me.Customer_Manager.PerformLayout()
        CType(Me.dgv_Customers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBinding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Media_MinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Order_Manager.ResumeLayout(False)
        Me.gbx_NewOrder.ResumeLayout(False)
        Me.gbx_NewOrder.PerformLayout()
        CType(Me.nud_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Orders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERSUMMARYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Inventory_Manager.ResumeLayout(False)
        CType(Me.dgv_Inventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Email_Ministry.ResumeLayout(False)
        Me.Email_Ministry.PerformLayout()
        Me.gbx_NewListener.ResumeLayout(False)
        Me.gbx_NewListener.PerformLayout()
        Me.gbx_Options.ResumeLayout(False)
        Me.gbx_Options.PerformLayout()
        CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMAILLISTENERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Buttons.ResumeLayout(False)
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
    Friend WithEvents ListenerToolStripMenuItem1 As ToolStripMenuItem
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
    Friend WithEvents CustomersBinding As BindingSource
    Friend WithEvents dgv_Inventory As DataGridView
    Friend WithEvents INVENTORYBindingSource As BindingSource
    Friend WithEvents dgv_Listeners As DataGridView
    Friend WithEvents EMAILLISTENERSBindingSource As BindingSource
    Friend WithEvents NAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents dgv_Orders As DataGridView
    Friend WithEvents ORDERSUMMARYBindingSource As BindingSource
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
    Friend WithEvents MediaMinistryManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmailerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bw_UpdateApp As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_AddCustomer As Button
    Friend WithEvents gbx_NewOrder As GroupBox
    Friend WithEvents gbx_NewProduct As GroupBox
    Friend WithEvents gbx_NewListener As GroupBox
    Friend WithEvents rdo_Multiple As RadioButton
    Friend WithEvents rdo_Single As RadioButton
    Friend WithEvents btn_AddListener As Button
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents txt_FilePath As TextBox
    Friend WithEvents txt_Name As TextBox
    Friend WithEvents gbx_Options As GroupBox
    Friend WithEvents ofd_ListenerList As OpenFileDialog
    Friend WithEvents lbl_Name As Label
    Friend WithEvents lbl_Email As Label
    Friend WithEvents lbl_ListenerList As Label
    Friend WithEvents btn_Browse As Button
    Friend WithEvents lbl_TotalListeners As Label
    Friend WithEvents lbl_TotalCustomers As Label
    Friend WithEvents ITEMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INSTOCKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lbl_Quantity As Label
    Friend WithEvents lbl_OrderProduct As Label
    Friend WithEvents lbl_OrderName As Label
    Friend WithEvents nud_Quantity As NumericUpDown
    Friend WithEvents btn_CreateOrder As Button
    Friend WithEvents cbx_OrderProduct As ComboBox
    Friend WithEvents cbx_OrderName As ComboBox
    Friend WithEvents lbl_OrderPhone As Label
    Friend WithEvents cbx_OrderPhone As ComboBox
    Friend WithEvents btn_OrderComplete As Button
    Friend WithEvents btn_OrderCancel As Button
    Friend WithEvents Select_Order As DataGridViewCheckBoxColumn
    Friend WithEvents ORDERNUMBERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PHONENUMBERDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ITEMDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Media_MinistryDataSet As Media_MinistryDataSet
    Friend WithEvents CustomersTableAdapter As Media_MinistryDataSetTableAdapters.CUSTOMERSTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents INVENTORYTableAdapter As Media_MinistryDataSetTableAdapters.INVENTORYTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents ORDER_SUMMARYTableAdapter As Media_MinistryDataSetTableAdapters.ORDER_SUMMARYTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL_LISTENERSTableAdapter As Media_MinistryDataSetTableAdapters.EMAIL_LISTENERSTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
End Class
