<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_UpdatePhoneNumber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_UpdatePhoneNumber))
        Me.cbx_FirstName = New System.Windows.Forms.ComboBox()
        Me.CUSTOMERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaMinistryDataSet = New MediaMinistryDataSet()
        Me.lbl_FirstName = New System.Windows.Forms.Label()
        Me.txt_NewNumber = New System.Windows.Forms.TextBox()
        Me.btn_UpdatePhone = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CUSTOMERSTableAdapter = New MediaMinistryDataSetTableAdapters.CUSTOMERSTableAdapter()
        Me.ss_UpdatePhone = New System.Windows.Forms.StatusStrip()
        Me.tss_UpdatePhone = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_OldNumber = New System.Windows.Forms.Label()
        Me.cbx_OldNumber = New System.Windows.Forms.ComboBox()
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
        CType(Me.CUSTOMERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ss_UpdatePhone.SuspendLayout()
        Me.mnstr_Strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbx_FirstName
        '
        Me.cbx_FirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbx_FirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_FirstName.DataSource = Me.CUSTOMERSBindingSource
        Me.cbx_FirstName.DisplayMember = "FIRST_NAME"
        Me.cbx_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_FirstName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbx_FirstName.FormattingEnabled = True
        Me.cbx_FirstName.Location = New System.Drawing.Point(97, 50)
        Me.cbx_FirstName.Name = "cbx_FirstName"
        Me.cbx_FirstName.Size = New System.Drawing.Size(198, 33)
        Me.cbx_FirstName.TabIndex = 0
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
        'lbl_FirstName
        '
        Me.lbl_FirstName.AutoSize = True
        Me.lbl_FirstName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FirstName.Location = New System.Drawing.Point(92, 34)
        Me.lbl_FirstName.Name = "lbl_FirstName"
        Me.lbl_FirstName.Size = New System.Drawing.Size(70, 15)
        Me.lbl_FirstName.TabIndex = 1
        Me.lbl_FirstName.Text = "First Name:"
        '
        'txt_NewNumber
        '
        Me.txt_NewNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NewNumber.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_NewNumber.Location = New System.Drawing.Point(97, 196)
        Me.txt_NewNumber.MaxLength = 12
        Me.txt_NewNumber.Name = "txt_NewNumber"
        Me.txt_NewNumber.Size = New System.Drawing.Size(198, 31)
        Me.txt_NewNumber.TabIndex = 2
        Me.txt_NewNumber.Text = "New Number"
        '
        'btn_UpdatePhone
        '
        Me.btn_UpdatePhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UpdatePhone.Location = New System.Drawing.Point(108, 251)
        Me.btn_UpdatePhone.Name = "btn_UpdatePhone"
        Me.btn_UpdatePhone.Size = New System.Drawing.Size(176, 68)
        Me.btn_UpdatePhone.TabIndex = 3
        Me.btn_UpdatePhone.Text = "Update Phone Number"
        Me.btn_UpdatePhone.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Number:"
        '
        'CUSTOMERSTableAdapter
        '
        Me.CUSTOMERSTableAdapter.ClearBeforeFill = True
        '
        'ss_UpdatePhone
        '
        Me.ss_UpdatePhone.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_UpdatePhone})
        Me.ss_UpdatePhone.Location = New System.Drawing.Point(0, 337)
        Me.ss_UpdatePhone.Name = "ss_UpdatePhone"
        Me.ss_UpdatePhone.Size = New System.Drawing.Size(386, 22)
        Me.ss_UpdatePhone.TabIndex = 4
        '
        'tss_UpdatePhone
        '
        Me.tss_UpdatePhone.Name = "tss_UpdatePhone"
        Me.tss_UpdatePhone.Size = New System.Drawing.Size(244, 17)
        Me.tss_UpdatePhone.Text = "Select person, then enter new phone number"
        '
        'lbl_OldNumber
        '
        Me.lbl_OldNumber.AutoSize = True
        Me.lbl_OldNumber.BackColor = System.Drawing.Color.Transparent
        Me.lbl_OldNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_OldNumber.Location = New System.Drawing.Point(94, 101)
        Me.lbl_OldNumber.Name = "lbl_OldNumber"
        Me.lbl_OldNumber.Size = New System.Drawing.Size(77, 15)
        Me.lbl_OldNumber.TabIndex = 6
        Me.lbl_OldNumber.Text = "Old Number:"
        '
        'cbx_OldNumber
        '
        Me.cbx_OldNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbx_OldNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_OldNumber.DataSource = Me.CUSTOMERSBindingSource
        Me.cbx_OldNumber.DisplayMember = "PHONE_NUMBER"
        Me.cbx_OldNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_OldNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbx_OldNumber.FormattingEnabled = True
        Me.cbx_OldNumber.Location = New System.Drawing.Point(97, 117)
        Me.cbx_OldNumber.Name = "cbx_OldNumber"
        Me.cbx_OldNumber.Size = New System.Drawing.Size(198, 33)
        Me.cbx_OldNumber.TabIndex = 5
        '
        'mnstr_Strip
        '
        Me.mnstr_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.mnstr_Strip.Location = New System.Drawing.Point(0, 0)
        Me.mnstr_Strip.Name = "mnstr_Strip"
        Me.mnstr_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnstr_Strip.Size = New System.Drawing.Size(386, 24)
        Me.mnstr_Strip.TabIndex = 7
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
        'frm_UpdatePhoneNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 359)
        Me.Controls.Add(Me.mnstr_Strip)
        Me.Controls.Add(Me.lbl_OldNumber)
        Me.Controls.Add(Me.cbx_OldNumber)
        Me.Controls.Add(Me.ss_UpdatePhone)
        Me.Controls.Add(Me.btn_UpdatePhone)
        Me.Controls.Add(Me.txt_NewNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_FirstName)
        Me.Controls.Add(Me.cbx_FirstName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_UpdatePhoneNumber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        CType(Me.CUSTOMERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ss_UpdatePhone.ResumeLayout(False)
        Me.ss_UpdatePhone.PerformLayout()
        Me.mnstr_Strip.ResumeLayout(False)
        Me.mnstr_Strip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbx_FirstName As ComboBox
    Friend WithEvents lbl_FirstName As Label
    Friend WithEvents txt_NewNumber As TextBox
    Friend WithEvents btn_UpdatePhone As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CUSTOMERSBindingSource As BindingSource
    Friend WithEvents CUSTOMERSTableAdapter As MediaMinistryDataSetTableAdapters.CUSTOMERSTableAdapter
    Friend WithEvents ss_UpdatePhone As StatusStrip
    Friend WithEvents tss_UpdatePhone As ToolStripStatusLabel
    Friend WithEvents lbl_OldNumber As Label
    Friend WithEvents cbx_OldNumber As ComboBox
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
