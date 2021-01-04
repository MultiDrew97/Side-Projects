Imports MediaMinistry.MediaMinistry

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_UpdateInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_UpdateInventory))
        Me.btn_CancelUpdate = New System.Windows.Forms.Button()
        Me.btn_ConfirmUpdate = New System.Windows.Forms.Button()
        Me.lbl_ItemSelect = New System.Windows.Forms.Label()
        Me.cbx_Items = New System.Windows.Forms.ComboBox()
        Me.INVENTORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaMinistryDataSet = New MediaMinistryDataSet()
        Me.lbl_Stock = New System.Windows.Forms.Label()
        Me.nud_Stock = New System.Windows.Forms.NumericUpDown()
        Me.ss_AddStock = New System.Windows.Forms.StatusStrip()
        Me.tss_AddStock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tt_Help = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_Price = New System.Windows.Forms.TextBox()
        Me.INVENTORYTableAdapter = New MediaMinistryDataSetTableAdapters.INVENTORYTableAdapter()
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
        CType(Me.nud_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ss_AddStock.SuspendLayout()
        Me.mnstr_Strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_CancelUpdate
        '
        Me.btn_CancelUpdate.AutoSize = True
        Me.btn_CancelUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_CancelUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CancelUpdate.Location = New System.Drawing.Point(220, 258)
        Me.btn_CancelUpdate.Name = "btn_CancelUpdate"
        Me.btn_CancelUpdate.Size = New System.Drawing.Size(95, 35)
        Me.btn_CancelUpdate.TabIndex = 20
        Me.btn_CancelUpdate.Text = "Cancel"
        Me.btn_CancelUpdate.UseVisualStyleBackColor = True
        '
        'btn_ConfirmUpdate
        '
        Me.btn_ConfirmUpdate.AutoSize = True
        Me.btn_ConfirmUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_ConfirmUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ConfirmUpdate.Location = New System.Drawing.Point(35, 258)
        Me.btn_ConfirmUpdate.Name = "btn_ConfirmUpdate"
        Me.btn_ConfirmUpdate.Size = New System.Drawing.Size(163, 35)
        Me.btn_ConfirmUpdate.TabIndex = 19
        Me.btn_ConfirmUpdate.Text = "Update Stock"
        Me.btn_ConfirmUpdate.UseVisualStyleBackColor = True
        '
        'lbl_ItemSelect
        '
        Me.lbl_ItemSelect.AutoSize = True
        Me.lbl_ItemSelect.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ItemSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ItemSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_ItemSelect.Location = New System.Drawing.Point(58, 33)
        Me.lbl_ItemSelect.Name = "lbl_ItemSelect"
        Me.lbl_ItemSelect.Size = New System.Drawing.Size(60, 15)
        Me.lbl_ItemSelect.TabIndex = 15
        Me.lbl_ItemSelect.Text = "Product:"
        '
        'cbx_Items
        '
        Me.cbx_Items.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbx_Items.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_Items.DataSource = Me.INVENTORYBindingSource
        Me.cbx_Items.DisplayMember = "ITEM"
        Me.cbx_Items.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cbx_Items.FormattingEnabled = True
        Me.cbx_Items.Location = New System.Drawing.Point(61, 51)
        Me.cbx_Items.Name = "cbx_Items"
        Me.cbx_Items.Size = New System.Drawing.Size(231, 33)
        Me.cbx_Items.TabIndex = 16
        Me.tt_Help.SetToolTip(Me.cbx_Items, "Select the product that was made")
        Me.cbx_Items.ValueMember = "ITEM"
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
        'lbl_Stock
        '
        Me.lbl_Stock.AutoSize = True
        Me.lbl_Stock.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Stock.Location = New System.Drawing.Point(93, 94)
        Me.lbl_Stock.Name = "lbl_Stock"
        Me.lbl_Stock.Size = New System.Drawing.Size(97, 15)
        Me.lbl_Stock.TabIndex = 17
        Me.lbl_Stock.Text = "Current Stock:"
        '
        'nud_Stock
        '
        Me.nud_Stock.AutoSize = True
        Me.nud_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.nud_Stock.Location = New System.Drawing.Point(96, 112)
        Me.nud_Stock.Name = "nud_Stock"
        Me.nud_Stock.Size = New System.Drawing.Size(162, 32)
        Me.nud_Stock.TabIndex = 18
        Me.nud_Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tt_Help.SetToolTip(Me.nud_Stock, "Enter the current stock of product")
        '
        'ss_AddStock
        '
        Me.ss_AddStock.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_AddStock})
        Me.ss_AddStock.Location = New System.Drawing.Point(0, 311)
        Me.ss_AddStock.Name = "ss_AddStock"
        Me.ss_AddStock.Size = New System.Drawing.Size(350, 22)
        Me.ss_AddStock.TabIndex = 21
        '
        'tss_AddStock
        '
        Me.tss_AddStock.Name = "tss_AddStock"
        Me.tss_AddStock.Size = New System.Drawing.Size(126, 17)
        Me.tss_AddStock.Text = "How many was made?"
        '
        'txt_Price
        '
        Me.txt_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Price.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_Price.Location = New System.Drawing.Point(104, 182)
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.Size = New System.Drawing.Size(145, 31)
        Me.txt_Price.TabIndex = 22
        Me.txt_Price.Text = "$0.00"
        Me.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tt_Help.SetToolTip(Me.txt_Price, "The Current price of the item")
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
        Me.mnstr_Strip.Size = New System.Drawing.Size(350, 24)
        Me.mnstr_Strip.TabIndex = 22
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
        'lbl_Price
        '
        Me.lbl_Price.AutoSize = True
        Me.lbl_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Price.Location = New System.Drawing.Point(101, 164)
        Me.lbl_Price.Name = "lbl_Price"
        Me.lbl_Price.Size = New System.Drawing.Size(44, 15)
        Me.lbl_Price.TabIndex = 23
        Me.lbl_Price.Text = "Price:"
        '
        'frm_UpdateInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 333)
        Me.Controls.Add(Me.lbl_Price)
        Me.Controls.Add(Me.txt_Price)
        Me.Controls.Add(Me.ss_AddStock)
        Me.Controls.Add(Me.btn_CancelUpdate)
        Me.Controls.Add(Me.btn_ConfirmUpdate)
        Me.Controls.Add(Me.lbl_ItemSelect)
        Me.Controls.Add(Me.cbx_Items)
        Me.Controls.Add(Me.lbl_Stock)
        Me.Controls.Add(Me.nud_Stock)
        Me.Controls.Add(Me.mnstr_Strip)
        Me.Name = "frm_UpdateInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry"
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ss_AddStock.ResumeLayout(False)
        Me.ss_AddStock.PerformLayout()
        Me.mnstr_Strip.ResumeLayout(False)
        Me.mnstr_Strip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_CancelUpdate As Button
    Friend WithEvents btn_ConfirmUpdate As Button
    Friend WithEvents lbl_ItemSelect As Label
    Friend WithEvents cbx_Items As ComboBox
    Friend WithEvents tt_Help As ToolTip
    Friend WithEvents lbl_Stock As Label
    Friend WithEvents nud_Stock As NumericUpDown
    Friend WithEvents ss_AddStock As StatusStrip
    Friend WithEvents tss_AddStock As ToolStripStatusLabel
    Friend WithEvents INVENTORYBindingSource As BindingSource
    Friend WithEvents INVENTORYTableAdapter As MediaMinistryDataSetTableAdapters.INVENTORYTableAdapter
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
    Friend WithEvents txt_Price As TextBox
    Friend WithEvents lbl_Price As Label
End Class
