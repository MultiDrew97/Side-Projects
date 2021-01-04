<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AddListener
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_AddListener))
        Me.gbx_Options = New System.Windows.Forms.GroupBox()
        Me.rdo_Single = New System.Windows.Forms.RadioButton()
        Me.rdo_Multiple = New System.Windows.Forms.RadioButton()
        Me.ofd_ListenerList = New System.Windows.Forms.OpenFileDialog()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.lbl_FilePath = New System.Windows.Forms.Label()
        Me.txt_FilePath = New System.Windows.Forms.TextBox()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
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
        Me.gbx_Options.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.mnstr_Strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Options
        '
        Me.gbx_Options.Controls.Add(Me.rdo_Single)
        Me.gbx_Options.Controls.Add(Me.rdo_Multiple)
        Me.gbx_Options.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.gbx_Options.Location = New System.Drawing.Point(22, 43)
        Me.gbx_Options.Name = "gbx_Options"
        Me.gbx_Options.Size = New System.Drawing.Size(244, 147)
        Me.gbx_Options.TabIndex = 0
        Me.gbx_Options.TabStop = False
        Me.gbx_Options.Text = "Options"
        '
        'rdo_Single
        '
        Me.rdo_Single.AutoSize = True
        Me.rdo_Single.Checked = True
        Me.rdo_Single.Location = New System.Drawing.Point(28, 37)
        Me.rdo_Single.Name = "rdo_Single"
        Me.rdo_Single.Size = New System.Drawing.Size(156, 30)
        Me.rdo_Single.TabIndex = 1
        Me.rdo_Single.TabStop = True
        Me.rdo_Single.Text = "One Person"
        Me.rdo_Single.UseVisualStyleBackColor = True
        '
        'rdo_Multiple
        '
        Me.rdo_Multiple.AutoSize = True
        Me.rdo_Multiple.Location = New System.Drawing.Point(28, 88)
        Me.rdo_Multiple.Name = "rdo_Multiple"
        Me.rdo_Multiple.Size = New System.Drawing.Size(194, 30)
        Me.rdo_Multiple.TabIndex = 2
        Me.rdo_Multiple.Text = "Multiple People"
        Me.rdo_Multiple.UseVisualStyleBackColor = True
        '
        'ofd_ListenerList
        '
        Me.ofd_ListenerList.Filter = "List (*.csv)|*.csv"
        Me.ofd_ListenerList.Title = "List of Listeners (.csv)"
        '
        'txt_Name
        '
        Me.txt_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Name.Location = New System.Drawing.Point(371, 81)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(449, 32)
        Me.txt_Name.TabIndex = 1
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Email.Location = New System.Drawing.Point(371, 129)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(449, 32)
        Me.txt_Email.TabIndex = 2
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Name.Location = New System.Drawing.Point(282, 81)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(82, 26)
        Me.lbl_Name.TabIndex = 3
        Me.lbl_Name.Text = "Name:"
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Email.Location = New System.Drawing.Point(282, 129)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(80, 26)
        Me.lbl_Email.TabIndex = 4
        Me.lbl_Email.Text = "Email:"
        '
        'lbl_FilePath
        '
        Me.lbl_FilePath.AutoSize = True
        Me.lbl_FilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_FilePath.Location = New System.Drawing.Point(276, 114)
        Me.lbl_FilePath.Name = "lbl_FilePath"
        Me.lbl_FilePath.Size = New System.Drawing.Size(114, 26)
        Me.lbl_FilePath.TabIndex = 5
        Me.lbl_FilePath.Text = "File Path:"
        '
        'txt_FilePath
        '
        Me.txt_FilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txt_FilePath.Location = New System.Drawing.Point(396, 110)
        Me.txt_FilePath.Name = "txt_FilePath"
        Me.txt_FilePath.ReadOnly = True
        Me.txt_FilePath.Size = New System.Drawing.Size(417, 32)
        Me.txt_FilePath.TabIndex = 6
        '
        'btn_Add
        '
        Me.btn_Add.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Add.Location = New System.Drawing.Point(503, 223)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(187, 53)
        Me.btn_Add.TabIndex = 7
        Me.btn_Add.Text = "Add Listener"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Cancel.Location = New System.Drawing.Point(233, 223)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(187, 53)
        Me.btn_Cancel.TabIndex = 8
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Search
        '
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Search.Location = New System.Drawing.Point(819, 110)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(43, 32)
        Me.btn_Search.TabIndex = 9
        Me.btn_Search.Text = "..."
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 312)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(880, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tss_Feedback
        '
        Me.tss_Feedback.Name = "tss_Feedback"
        Me.tss_Feedback.Size = New System.Drawing.Size(242, 17)
        Me.tss_Feedback.Text = "Enter the name and email of the new listener"
        '
        'mnstr_Strip
        '
        Me.mnstr_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.mnstr_Strip.Location = New System.Drawing.Point(0, 0)
        Me.mnstr_Strip.Name = "mnstr_Strip"
        Me.mnstr_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnstr_Strip.Size = New System.Drawing.Size(880, 24)
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
        'Frm_AddListener
        '
        Me.AcceptButton = Me.btn_Add
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(880, 334)
        Me.Controls.Add(Me.mnstr_Strip)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.txt_FilePath)
        Me.Controls.Add(Me.lbl_FilePath)
        Me.Controls.Add(Me.lbl_Email)
        Me.Controls.Add(Me.lbl_Name)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.gbx_Options)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_AddListener"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.gbx_Options.ResumeLayout(False)
        Me.gbx_Options.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.mnstr_Strip.ResumeLayout(False)
        Me.mnstr_Strip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbx_Options As GroupBox
    Friend WithEvents rdo_Multiple As RadioButton
    Friend WithEvents rdo_Single As RadioButton
    Friend WithEvents ofd_ListenerList As OpenFileDialog
    Friend WithEvents txt_Name As TextBox
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents lbl_Name As Label
    Friend WithEvents lbl_Email As Label
    Friend WithEvents lbl_FilePath As Label
    Friend WithEvents txt_FilePath As TextBox
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Search As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tss_Feedback As ToolStripStatusLabel
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
