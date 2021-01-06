<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ViewListeners
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ViewListeners))
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.dgv_Listeners = New System.Windows.Forms.DataGridView()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.lbl_SearchLabel = New System.Windows.Forms.Label()
        Me.txt_SearchBox = New System.Windows.Forms.TextBox()
        Me.btn_Advanced = New System.Windows.Forms.Button()
        Me.cbx_Column = New System.Windows.Forms.ComboBox()
        Me.txt_NameSearch = New System.Windows.Forms.TextBox()
        Me.txt_EmailSearch = New System.Windows.Forms.TextBox()
        Me.lbl_NameSearch = New System.Windows.Forms.Label()
        Me.lbl_EmailSearch = New System.Windows.Forms.Label()
        Me.gbx_AdvancedSearch = New System.Windows.Forms.GroupBox()
        Me.btn_AdvancedSearch = New System.Windows.Forms.Button()
        Me.btn_AdvancedCancel = New System.Windows.Forms.Button()
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
        Me.MediaMinistryDataSet = New MediaMinistryDataSet()
        Me.EMAILLISTENERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMAIL_LISTENERSTableAdapter = New MediaMinistryDataSetTableAdapters.EMAIL_LISTENERSTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_AdvancedSearch.SuspendLayout()
        Me.mnstr_Strip.SuspendLayout()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMAILLISTENERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Add
        '
        Me.btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Add.Location = New System.Drawing.Point(665, 331)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(169, 39)
        Me.btn_Add.TabIndex = 1
        Me.btn_Add.Text = "Add Listener"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'dgv_Listeners
        '
        Me.dgv_Listeners.AllowUserToAddRows = False
        Me.dgv_Listeners.AutoGenerateColumns = False
        Me.dgv_Listeners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Listeners.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_Listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Listeners.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgv_Listeners.DataSource = Me.EMAILLISTENERSBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Listeners.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Listeners.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgv_Listeners.Location = New System.Drawing.Point(0, 24)
        Me.dgv_Listeners.Name = "dgv_Listeners"
        Me.dgv_Listeners.Size = New System.Drawing.Size(613, 426)
        Me.dgv_Listeners.TabIndex = 0
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(660, 373)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(183, 25)
        Me.lbl_Total.TabIndex = 2
        Me.lbl_Total.Text = "Total Listeners: "
        '
        'btn_Search
        '
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Search.Location = New System.Drawing.Point(781, 123)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(100, 33)
        Me.btn_Search.TabIndex = 3
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'lbl_SearchLabel
        '
        Me.lbl_SearchLabel.AutoSize = True
        Me.lbl_SearchLabel.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_SearchLabel.Location = New System.Drawing.Point(619, 75)
        Me.lbl_SearchLabel.Name = "lbl_SearchLabel"
        Me.lbl_SearchLabel.Size = New System.Drawing.Size(93, 25)
        Me.lbl_SearchLabel.TabIndex = 4
        Me.lbl_SearchLabel.Text = "Search:"
        '
        'txt_SearchBox
        '
        Me.txt_SearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txt_SearchBox.Location = New System.Drawing.Point(712, 75)
        Me.txt_SearchBox.Name = "txt_SearchBox"
        Me.txt_SearchBox.Size = New System.Drawing.Size(269, 31)
        Me.txt_SearchBox.TabIndex = 5
        '
        'btn_Advanced
        '
        Me.btn_Advanced.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Advanced.Location = New System.Drawing.Point(1199, 151)
        Me.btn_Advanced.Name = "btn_Advanced"
        Me.btn_Advanced.Size = New System.Drawing.Size(132, 33)
        Me.btn_Advanced.TabIndex = 6
        Me.btn_Advanced.Text = "Advanced"
        Me.btn_Advanced.UseVisualStyleBackColor = True
        Me.btn_Advanced.Visible = False
        '
        'cbx_Column
        '
        Me.cbx_Column.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.cbx_Column.FormattingEnabled = True
        Me.cbx_Column.Items.AddRange(New Object() {"NAME", "EMAIL", "Name", "Email Address"})
        Me.cbx_Column.Location = New System.Drawing.Point(745, 36)
        Me.cbx_Column.Name = "cbx_Column"
        Me.cbx_Column.Size = New System.Drawing.Size(192, 33)
        Me.cbx_Column.TabIndex = 7
        '
        'txt_NameSearch
        '
        Me.txt_NameSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txt_NameSearch.Location = New System.Drawing.Point(24, 60)
        Me.txt_NameSearch.Name = "txt_NameSearch"
        Me.txt_NameSearch.Size = New System.Drawing.Size(356, 31)
        Me.txt_NameSearch.TabIndex = 8
        '
        'txt_EmailSearch
        '
        Me.txt_EmailSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txt_EmailSearch.Location = New System.Drawing.Point(24, 140)
        Me.txt_EmailSearch.Name = "txt_EmailSearch"
        Me.txt_EmailSearch.Size = New System.Drawing.Size(356, 31)
        Me.txt_EmailSearch.TabIndex = 9
        '
        'lbl_NameSearch
        '
        Me.lbl_NameSearch.AutoSize = True
        Me.lbl_NameSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_NameSearch.Location = New System.Drawing.Point(19, 32)
        Me.lbl_NameSearch.Name = "lbl_NameSearch"
        Me.lbl_NameSearch.Size = New System.Drawing.Size(79, 25)
        Me.lbl_NameSearch.TabIndex = 10
        Me.lbl_NameSearch.Text = "Name:"
        '
        'lbl_EmailSearch
        '
        Me.lbl_EmailSearch.AutoSize = True
        Me.lbl_EmailSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_EmailSearch.Location = New System.Drawing.Point(19, 112)
        Me.lbl_EmailSearch.Name = "lbl_EmailSearch"
        Me.lbl_EmailSearch.Size = New System.Drawing.Size(170, 25)
        Me.lbl_EmailSearch.TabIndex = 11
        Me.lbl_EmailSearch.Text = "Email Address:"
        '
        'gbx_AdvancedSearch
        '
        Me.gbx_AdvancedSearch.BackColor = System.Drawing.Color.Gray
        Me.gbx_AdvancedSearch.Controls.Add(Me.btn_AdvancedSearch)
        Me.gbx_AdvancedSearch.Controls.Add(Me.btn_AdvancedCancel)
        Me.gbx_AdvancedSearch.Controls.Add(Me.txt_EmailSearch)
        Me.gbx_AdvancedSearch.Controls.Add(Me.lbl_EmailSearch)
        Me.gbx_AdvancedSearch.Controls.Add(Me.txt_NameSearch)
        Me.gbx_AdvancedSearch.Controls.Add(Me.lbl_NameSearch)
        Me.gbx_AdvancedSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.gbx_AdvancedSearch.Location = New System.Drawing.Point(968, 63)
        Me.gbx_AdvancedSearch.Name = "gbx_AdvancedSearch"
        Me.gbx_AdvancedSearch.Size = New System.Drawing.Size(386, 243)
        Me.gbx_AdvancedSearch.TabIndex = 12
        Me.gbx_AdvancedSearch.TabStop = False
        Me.gbx_AdvancedSearch.Text = "Advanced Search"
        Me.gbx_AdvancedSearch.Visible = False
        '
        'btn_AdvancedSearch
        '
        Me.btn_AdvancedSearch.Location = New System.Drawing.Point(231, 187)
        Me.btn_AdvancedSearch.Name = "btn_AdvancedSearch"
        Me.btn_AdvancedSearch.Size = New System.Drawing.Size(95, 35)
        Me.btn_AdvancedSearch.TabIndex = 13
        Me.btn_AdvancedSearch.Text = "Search"
        Me.btn_AdvancedSearch.UseVisualStyleBackColor = True
        '
        'btn_AdvancedCancel
        '
        Me.btn_AdvancedCancel.Location = New System.Drawing.Point(74, 187)
        Me.btn_AdvancedCancel.Name = "btn_AdvancedCancel"
        Me.btn_AdvancedCancel.Size = New System.Drawing.Size(99, 35)
        Me.btn_AdvancedCancel.TabIndex = 12
        Me.btn_AdvancedCancel.Text = "Cancel"
        Me.btn_AdvancedCancel.UseVisualStyleBackColor = True
        '
        'mnstr_Strip
        '
        Me.mnstr_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.mnstr_Strip.Location = New System.Drawing.Point(0, 0)
        Me.mnstr_Strip.Name = "mnstr_Strip"
        Me.mnstr_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnstr_Strip.Size = New System.Drawing.Size(998, 24)
        Me.mnstr_Strip.TabIndex = 13
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
        'MediaMinistryDataSet
        '
        Me.MediaMinistryDataSet.DataSetName = "MediaMinistryDataSet"
        Me.MediaMinistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMAILLISTENERSBindingSource
        '
        Me.EMAILLISTENERSBindingSource.DataMember = "EMAIL_LISTENERS"
        Me.EMAILLISTENERSBindingSource.DataSource = Me.MediaMinistryDataSet
        '
        'EMAIL_LISTENERSTableAdapter
        '
        Me.EMAIL_LISTENERSTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NAME"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NAME"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EMAIL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "EMAIL"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frm_ViewListeners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MediaMinistry.My.Resources.Resources.Media_Ministry_Logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(998, 450)
        Me.Controls.Add(Me.cbx_Column)
        Me.Controls.Add(Me.btn_Advanced)
        Me.Controls.Add(Me.txt_SearchBox)
        Me.Controls.Add(Me.lbl_SearchLabel)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.dgv_Listeners)
        Me.Controls.Add(Me.gbx_AdvancedSearch)
        Me.Controls.Add(Me.mnstr_Strip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_ViewListeners"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_AdvancedSearch.ResumeLayout(False)
        Me.gbx_AdvancedSearch.PerformLayout()
        Me.mnstr_Strip.ResumeLayout(False)
        Me.mnstr_Strip.PerformLayout()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMAILLISTENERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Add As Button
    Friend WithEvents dgv_Listeners As DataGridView
    Friend WithEvents NAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lbl_Total As Label
    Friend WithEvents btn_Search As Button
    Friend WithEvents lbl_SearchLabel As Label
    Friend WithEvents txt_SearchBox As TextBox
    Friend WithEvents btn_Advanced As Button
    Friend WithEvents cbx_Column As ComboBox
    Friend WithEvents txt_NameSearch As TextBox
    Friend WithEvents txt_EmailSearch As TextBox
    Friend WithEvents lbl_NameSearch As Label
    Friend WithEvents lbl_EmailSearch As Label
    Friend WithEvents gbx_AdvancedSearch As GroupBox
    Friend WithEvents btn_AdvancedSearch As Button
    Friend WithEvents btn_AdvancedCancel As Button
    Friend WithEvents NAMEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
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
    Friend WithEvents MediaMinistryDataSet As MediaMinistryDataSet
    Friend WithEvents EMAILLISTENERSBindingSource As BindingSource
    Friend WithEvents EMAIL_LISTENERSTableAdapter As MediaMinistryDataSetTableAdapters.EMAIL_LISTENERSTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
