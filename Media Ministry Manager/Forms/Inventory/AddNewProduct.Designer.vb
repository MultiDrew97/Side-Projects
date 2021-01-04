<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AddNewProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AddNewProduct))
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.lbl_ProductName = New System.Windows.Forms.Label()
        Me.lbl_InStock = New System.Windows.Forms.Label()
        Me.txt_ProductName = New System.Windows.Forms.TextBox()
        Me.txt_Price = New System.Windows.Forms.TextBox()
        Me.nud_Stock = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Price = New System.Windows.Forms.Label()
        Me.ss_AddItem = New System.Windows.Forms.StatusStrip()
        Me.tss_AddProduct = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ep_EmptyFields = New System.Windows.Forms.ErrorProvider(Me.components)
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
        CType(Me.nud_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ss_AddItem.SuspendLayout()
        CType(Me.ep_EmptyFields, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnstr_Strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btn_Cancel.Location = New System.Drawing.Point(18, 225)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(144, 53)
        Me.btn_Cancel.TabIndex = 7
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btn_Add.Location = New System.Drawing.Point(214, 225)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(144, 53)
        Me.btn_Add.TabIndex = 6
        Me.btn_Add.Text = "Add Product"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'lbl_ProductName
        '
        Me.lbl_ProductName.AutoSize = True
        Me.lbl_ProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_ProductName.Location = New System.Drawing.Point(80, 29)
        Me.lbl_ProductName.Name = "lbl_ProductName"
        Me.lbl_ProductName.Size = New System.Drawing.Size(89, 15)
        Me.lbl_ProductName.TabIndex = 0
        Me.lbl_ProductName.Text = "Product Name:"
        '
        'lbl_InStock
        '
        Me.lbl_InStock.AutoSize = True
        Me.lbl_InStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_InStock.Location = New System.Drawing.Point(146, 98)
        Me.lbl_InStock.Name = "lbl_InStock"
        Me.lbl_InStock.Size = New System.Drawing.Size(53, 15)
        Me.lbl_InStock.TabIndex = 2
        Me.lbl_InStock.Text = "In Stock:"
        '
        'txt_ProductName
        '
        Me.txt_ProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_ProductName.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_ProductName.Location = New System.Drawing.Point(83, 46)
        Me.txt_ProductName.Name = "txt_ProductName"
        Me.txt_ProductName.Size = New System.Drawing.Size(213, 32)
        Me.txt_ProductName.TabIndex = 1
        Me.txt_ProductName.Text = "Product Name"
        '
        'txt_Price
        '
        Me.txt_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_Price.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_Price.Location = New System.Drawing.Point(83, 173)
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.Size = New System.Drawing.Size(213, 32)
        Me.txt_Price.TabIndex = 5
        Me.txt_Price.Text = "$0.00"
        '
        'nud_Stock
        '
        Me.nud_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.nud_Stock.Location = New System.Drawing.Point(149, 116)
        Me.nud_Stock.Name = "nud_Stock"
        Me.nud_Stock.Size = New System.Drawing.Size(80, 32)
        Me.nud_Stock.TabIndex = 3
        '
        'lbl_Price
        '
        Me.lbl_Price.AutoSize = True
        Me.lbl_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_Price.Location = New System.Drawing.Point(80, 155)
        Me.lbl_Price.Name = "lbl_Price"
        Me.lbl_Price.Size = New System.Drawing.Size(38, 15)
        Me.lbl_Price.TabIndex = 4
        Me.lbl_Price.Text = "Price:"
        '
        'ss_AddItem
        '
        Me.ss_AddItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_AddProduct})
        Me.ss_AddItem.Location = New System.Drawing.Point(0, 284)
        Me.ss_AddItem.Name = "ss_AddItem"
        Me.ss_AddItem.Size = New System.Drawing.Size(377, 22)
        Me.ss_AddItem.TabIndex = 8
        '
        'tss_AddProduct
        '
        Me.tss_AddProduct.Name = "tss_AddProduct"
        Me.tss_AddProduct.Size = New System.Drawing.Size(231, 17)
        Me.tss_AddProduct.Text = "Enter the information for the new product."
        '
        'ep_EmptyFields
        '
        Me.ep_EmptyFields.ContainerControl = Me
        '
        'mnstr_Strip
        '
        Me.mnstr_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.mnstr_Strip.Location = New System.Drawing.Point(0, 0)
        Me.mnstr_Strip.Name = "mnstr_Strip"
        Me.mnstr_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnstr_Strip.Size = New System.Drawing.Size(377, 24)
        Me.mnstr_Strip.TabIndex = 9
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
        'frm_AddNewProduct
        '
        Me.AcceptButton = Me.btn_Add
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(377, 306)
        Me.Controls.Add(Me.ss_AddItem)
        Me.Controls.Add(Me.nud_Stock)
        Me.Controls.Add(Me.txt_Price)
        Me.Controls.Add(Me.txt_ProductName)
        Me.Controls.Add(Me.lbl_Price)
        Me.Controls.Add(Me.lbl_InStock)
        Me.Controls.Add(Me.lbl_ProductName)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.mnstr_Strip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frm_AddNewProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry"
        CType(Me.nud_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ss_AddItem.ResumeLayout(False)
        Me.ss_AddItem.PerformLayout()
        CType(Me.ep_EmptyFields, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnstr_Strip.ResumeLayout(False)
        Me.mnstr_Strip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Add As Button
    Friend WithEvents lbl_ProductName As Label
    Friend WithEvents lbl_InStock As Label
    Friend WithEvents txt_ProductName As TextBox
    Friend WithEvents txt_Price As TextBox
    Friend WithEvents nud_Stock As NumericUpDown
    Friend WithEvents lbl_Price As Label
    Friend WithEvents ss_AddItem As StatusStrip
    Friend WithEvents tss_AddProduct As ToolStripStatusLabel
    Friend WithEvents ep_EmptyFields As ErrorProvider
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
