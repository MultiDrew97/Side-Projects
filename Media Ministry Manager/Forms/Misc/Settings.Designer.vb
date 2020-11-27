<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
                cts.Dispose()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Settings))
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Default = New System.Windows.Forms.Button()
        Me.tc_Settings = New System.Windows.Forms.TabControl()
        Me.tp_Fonts = New System.Windows.Forms.TabPage()
        Me.chk_Bold = New System.Windows.Forms.CheckBox()
        Me.btn_ChangeFont = New System.Windows.Forms.Button()
        Me.txt_CurrentFont = New System.Windows.Forms.TextBox()
        Me.lbl_CurrentFont = New System.Windows.Forms.Label()
        Me.lbl_FontSize = New System.Windows.Forms.Label()
        Me.nud_FontSize = New System.Windows.Forms.NumericUpDown()
        Me.tp_LinkedAccounts = New System.Windows.Forms.TabPage()
        Me.lbl_CurrentGmail = New System.Windows.Forms.Label()
        Me.lbl_CurrentDrive = New System.Windows.Forms.Label()
        Me.btn_Gmail = New System.Windows.Forms.Button()
        Me.btn_GoogleDrive = New System.Windows.Forms.Button()
        Me.fd_FontSelector = New System.Windows.Forms.FontDialog()
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
        Me.bw_Settings = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bw_Uploader = New System.ComponentModel.BackgroundWorker()
        Me.bw_Gmail = New System.ComponentModel.BackgroundWorker()
        Me.tc_Settings.SuspendLayout()
        Me.tp_Fonts.SuspendLayout()
        CType(Me.nud_FontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_LinkedAccounts.SuspendLayout()
        Me.mnstr_Strip.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Save
        '
        Me.btn_Save.AutoSize = True
        Me.btn_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(326, 410)
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(72, 36)
        Me.btn_Save.TabIndex = 0
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Default
        '
        Me.btn_Default.AutoSize = True
        Me.btn_Default.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Default.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Default.Location = New System.Drawing.Point(40, 410)
        Me.btn_Default.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_Default.Name = "btn_Default"
        Me.btn_Default.Size = New System.Drawing.Size(208, 36)
        Me.btn_Default.TabIndex = 1
        Me.btn_Default.Text = "Restore to Defaults"
        Me.btn_Default.UseVisualStyleBackColor = True
        '
        'tc_Settings
        '
        Me.tc_Settings.Controls.Add(Me.tp_Fonts)
        Me.tc_Settings.Controls.Add(Me.tp_LinkedAccounts)
        Me.tc_Settings.HotTrack = True
        Me.tc_Settings.Location = New System.Drawing.Point(0, 27)
        Me.tc_Settings.Name = "tc_Settings"
        Me.tc_Settings.SelectedIndex = 0
        Me.tc_Settings.Size = New System.Drawing.Size(484, 350)
        Me.tc_Settings.TabIndex = 2
        '
        'tp_Fonts
        '
        Me.tp_Fonts.BackColor = System.Drawing.Color.Transparent
        Me.tp_Fonts.Controls.Add(Me.chk_Bold)
        Me.tp_Fonts.Controls.Add(Me.btn_ChangeFont)
        Me.tp_Fonts.Controls.Add(Me.txt_CurrentFont)
        Me.tp_Fonts.Controls.Add(Me.lbl_CurrentFont)
        Me.tp_Fonts.Controls.Add(Me.lbl_FontSize)
        Me.tp_Fonts.Controls.Add(Me.nud_FontSize)
        Me.tp_Fonts.Location = New System.Drawing.Point(4, 34)
        Me.tp_Fonts.Name = "tp_Fonts"
        Me.tp_Fonts.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_Fonts.Size = New System.Drawing.Size(476, 312)
        Me.tp_Fonts.TabIndex = 0
        Me.tp_Fonts.Text = "Font Selection"
        '
        'chk_Bold
        '
        Me.chk_Bold.AutoSize = True
        Me.chk_Bold.Enabled = False
        Me.chk_Bold.Location = New System.Drawing.Point(282, 138)
        Me.chk_Bold.Name = "chk_Bold"
        Me.chk_Bold.Size = New System.Drawing.Size(75, 30)
        Me.chk_Bold.TabIndex = 5
        Me.chk_Bold.Text = "Bold"
        Me.chk_Bold.UseVisualStyleBackColor = True
        '
        'btn_ChangeFont
        '
        Me.btn_ChangeFont.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_ChangeFont.AutoSize = True
        Me.btn_ChangeFont.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_ChangeFont.Location = New System.Drawing.Point(122, 230)
        Me.btn_ChangeFont.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_ChangeFont.Name = "btn_ChangeFont"
        Me.btn_ChangeFont.Size = New System.Drawing.Size(232, 36)
        Me.btn_ChangeFont.TabIndex = 4
        Me.btn_ChangeFont.Text = "Change Font Settings"
        Me.btn_ChangeFont.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ChangeFont.UseVisualStyleBackColor = True
        '
        'txt_CurrentFont
        '
        Me.txt_CurrentFont.Location = New System.Drawing.Point(93, 59)
        Me.txt_CurrentFont.Name = "txt_CurrentFont"
        Me.txt_CurrentFont.ReadOnly = True
        Me.txt_CurrentFont.Size = New System.Drawing.Size(296, 32)
        Me.txt_CurrentFont.TabIndex = 3
        '
        'lbl_CurrentFont
        '
        Me.lbl_CurrentFont.AutoSize = True
        Me.lbl_CurrentFont.Location = New System.Drawing.Point(88, 29)
        Me.lbl_CurrentFont.Name = "lbl_CurrentFont"
        Me.lbl_CurrentFont.Size = New System.Drawing.Size(61, 26)
        Me.lbl_CurrentFont.TabIndex = 2
        Me.lbl_CurrentFont.Text = "Font:"
        '
        'lbl_FontSize
        '
        Me.lbl_FontSize.AutoSize = True
        Me.lbl_FontSize.Location = New System.Drawing.Point(119, 109)
        Me.lbl_FontSize.Name = "lbl_FontSize"
        Me.lbl_FontSize.Size = New System.Drawing.Size(110, 26)
        Me.lbl_FontSize.TabIndex = 1
        Me.lbl_FontSize.Text = "Font Size:"
        '
        'nud_FontSize
        '
        Me.nud_FontSize.AutoSize = True
        Me.nud_FontSize.Enabled = False
        Me.nud_FontSize.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.nud_FontSize.Location = New System.Drawing.Point(124, 138)
        Me.nud_FontSize.Name = "nud_FontSize"
        Me.nud_FontSize.ReadOnly = True
        Me.nud_FontSize.Size = New System.Drawing.Size(120, 32)
        Me.nud_FontSize.TabIndex = 0
        Me.nud_FontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tp_LinkedAccounts
        '
        Me.tp_LinkedAccounts.BackColor = System.Drawing.Color.Transparent
        Me.tp_LinkedAccounts.Controls.Add(Me.lbl_CurrentGmail)
        Me.tp_LinkedAccounts.Controls.Add(Me.lbl_CurrentDrive)
        Me.tp_LinkedAccounts.Controls.Add(Me.btn_Gmail)
        Me.tp_LinkedAccounts.Controls.Add(Me.btn_GoogleDrive)
        Me.tp_LinkedAccounts.Location = New System.Drawing.Point(4, 34)
        Me.tp_LinkedAccounts.Name = "tp_LinkedAccounts"
        Me.tp_LinkedAccounts.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_LinkedAccounts.Size = New System.Drawing.Size(476, 312)
        Me.tp_LinkedAccounts.TabIndex = 1
        Me.tp_LinkedAccounts.Text = "Linked Accounts"
        '
        'lbl_CurrentGmail
        '
        Me.lbl_CurrentGmail.AutoSize = True
        Me.lbl_CurrentGmail.Location = New System.Drawing.Point(36, 198)
        Me.lbl_CurrentGmail.Name = "lbl_CurrentGmail"
        Me.lbl_CurrentGmail.Size = New System.Drawing.Size(142, 26)
        Me.lbl_CurrentGmail.TabIndex = 3
        Me.lbl_CurrentGmail.Text = "Current User:"
        '
        'lbl_CurrentDrive
        '
        Me.lbl_CurrentDrive.AutoSize = True
        Me.lbl_CurrentDrive.Location = New System.Drawing.Point(31, 32)
        Me.lbl_CurrentDrive.Name = "lbl_CurrentDrive"
        Me.lbl_CurrentDrive.Size = New System.Drawing.Size(142, 26)
        Me.lbl_CurrentDrive.TabIndex = 2
        Me.lbl_CurrentDrive.Text = "Current User:"
        '
        'btn_Gmail
        '
        Me.btn_Gmail.AutoSize = True
        Me.btn_Gmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Gmail.Location = New System.Drawing.Point(36, 227)
        Me.btn_Gmail.Name = "btn_Gmail"
        Me.btn_Gmail.Size = New System.Drawing.Size(126, 36)
        Me.btn_Gmail.TabIndex = 1
        Me.btn_Gmail.Text = "Link Gmail"
        Me.btn_Gmail.UseVisualStyleBackColor = True
        '
        'btn_GoogleDrive
        '
        Me.btn_GoogleDrive.AutoSize = True
        Me.btn_GoogleDrive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_GoogleDrive.Location = New System.Drawing.Point(36, 75)
        Me.btn_GoogleDrive.Name = "btn_GoogleDrive"
        Me.btn_GoogleDrive.Size = New System.Drawing.Size(195, 36)
        Me.btn_GoogleDrive.TabIndex = 0
        Me.btn_GoogleDrive.Text = "Link Google Drive"
        Me.btn_GoogleDrive.UseVisualStyleBackColor = True
        '
        'fd_FontSelector
        '
        Me.fd_FontSelector.AllowVerticalFonts = False
        Me.fd_FontSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fd_FontSelector.FontMustExist = True
        Me.fd_FontSelector.ScriptsOnly = True
        Me.fd_FontSelector.ShowApply = True
        '
        'mnstr_Strip
        '
        Me.mnstr_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.mnstr_Strip.Location = New System.Drawing.Point(0, 0)
        Me.mnstr_Strip.Name = "mnstr_Strip"
        Me.mnstr_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnstr_Strip.Size = New System.Drawing.Size(484, 24)
        Me.mnstr_Strip.TabIndex = 3
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
        'bw_Settings
        '
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CancelToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(111, 26)
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'bw_Uploader
        '
        Me.bw_Uploader.WorkerSupportsCancellation = True
        '
        'bw_Gmail
        '
        Me.bw_Gmail.WorkerSupportsCancellation = True
        '
        'Frm_Settings
        '
        Me.AcceptButton = Me.btn_Save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.mnstr_Strip)
        Me.Controls.Add(Me.tc_Settings)
        Me.Controls.Add(Me.btn_Default)
        Me.Controls.Add(Me.btn_Save)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 800)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "Frm_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.tc_Settings.ResumeLayout(False)
        Me.tp_Fonts.ResumeLayout(False)
        Me.tp_Fonts.PerformLayout()
        CType(Me.nud_FontSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_LinkedAccounts.ResumeLayout(False)
        Me.tp_LinkedAccounts.PerformLayout()
        Me.mnstr_Strip.ResumeLayout(False)
        Me.mnstr_Strip.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_Default As Button
    Friend WithEvents tc_Settings As TabControl
    Friend WithEvents tp_Fonts As TabPage
    Friend WithEvents tp_LinkedAccounts As TabPage
    Friend WithEvents fd_FontSelector As FontDialog
    Friend WithEvents nud_FontSize As NumericUpDown
    Friend WithEvents btn_ChangeFont As Button
    Friend WithEvents txt_CurrentFont As TextBox
    Friend WithEvents lbl_CurrentFont As Label
    Friend WithEvents lbl_FontSize As Label
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
    Friend WithEvents chk_Bold As CheckBox
    Friend WithEvents bw_Settings As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_Gmail As Button
    Friend WithEvents btn_GoogleDrive As Button
    Friend WithEvents lbl_CurrentDrive As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CancelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_CurrentGmail As Label
    Friend WithEvents bw_Uploader As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_Gmail As System.ComponentModel.BackgroundWorker
End Class
