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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.btn_placeOrder = New System.Windows.Forms.Button()
        Me.btn_ShowOrders = New System.Windows.Forms.Button()
        Me.btn_ProductManagement = New System.Windows.Forms.Button()
        Me.btn_CustomerManagement = New System.Windows.Forms.Button()
        Me.ss_Queries = New System.Windows.Forms.StatusStrip()
        Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bw_ChangedSizes = New System.ComponentModel.BackgroundWorker()
        Me.btn_EmailMinistry = New System.Windows.Forms.Button()
        Me.bw_UpdateJar = New System.ComponentModel.BackgroundWorker()
        Me.pnl_Controls = New System.Windows.Forms.Panel()
        Me.wb_Updater = New System.Windows.Forms.WebBrowser()
        Me.mnstr_Strip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewListenerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewListenersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ss_Queries.SuspendLayout()
        Me.pnl_Controls.SuspendLayout()
        Me.mnstr_Strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_placeOrder
        '
        Me.btn_placeOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_placeOrder.Location = New System.Drawing.Point(85, 110)
        Me.btn_placeOrder.Name = "btn_placeOrder"
        Me.btn_placeOrder.Size = New System.Drawing.Size(226, 43)
        Me.btn_placeOrder.TabIndex = 2
        Me.btn_placeOrder.Text = "Place an Order"
        Me.btn_placeOrder.UseVisualStyleBackColor = True
        '
        'btn_ShowOrders
        '
        Me.btn_ShowOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ShowOrders.Location = New System.Drawing.Point(85, 185)
        Me.btn_ShowOrders.Name = "btn_ShowOrders"
        Me.btn_ShowOrders.Size = New System.Drawing.Size(226, 43)
        Me.btn_ShowOrders.TabIndex = 3
        Me.btn_ShowOrders.Text = "Show Orders"
        Me.btn_ShowOrders.UseVisualStyleBackColor = True
        '
        'btn_ProductManagement
        '
        Me.btn_ProductManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ProductManagement.Location = New System.Drawing.Point(85, 260)
        Me.btn_ProductManagement.Name = "btn_ProductManagement"
        Me.btn_ProductManagement.Size = New System.Drawing.Size(226, 43)
        Me.btn_ProductManagement.TabIndex = 4
        Me.btn_ProductManagement.Text = "Product Management"
        Me.btn_ProductManagement.UseVisualStyleBackColor = True
        '
        'btn_CustomerManagement
        '
        Me.btn_CustomerManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CustomerManagement.Location = New System.Drawing.Point(85, 35)
        Me.btn_CustomerManagement.Name = "btn_CustomerManagement"
        Me.btn_CustomerManagement.Size = New System.Drawing.Size(226, 43)
        Me.btn_CustomerManagement.TabIndex = 1
        Me.btn_CustomerManagement.Text = "Customer Management"
        Me.btn_CustomerManagement.UseVisualStyleBackColor = True
        '
        'ss_Queries
        '
        Me.ss_Queries.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback})
        Me.ss_Queries.Location = New System.Drawing.Point(0, 391)
        Me.ss_Queries.Name = "ss_Queries"
        Me.ss_Queries.Size = New System.Drawing.Size(397, 22)
        Me.ss_Queries.TabIndex = 0
        '
        'tss_Feedback
        '
        Me.tss_Feedback.Name = "tss_Feedback"
        Me.tss_Feedback.Size = New System.Drawing.Size(151, 17)
        Me.tss_Feedback.Text = "What would you like to do?"
        '
        'bw_ChangedSizes
        '
        '
        'btn_EmailMinistry
        '
        Me.btn_EmailMinistry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_EmailMinistry.Location = New System.Drawing.Point(85, 335)
        Me.btn_EmailMinistry.Name = "btn_EmailMinistry"
        Me.btn_EmailMinistry.Size = New System.Drawing.Size(226, 43)
        Me.btn_EmailMinistry.TabIndex = 5
        Me.btn_EmailMinistry.Text = "Email Ministry"
        Me.btn_EmailMinistry.UseVisualStyleBackColor = True
        '
        'pnl_Controls
        '
        Me.pnl_Controls.BackColor = System.Drawing.Color.Transparent
        Me.pnl_Controls.BackgroundImage = Global.MediaMinistry.My.Resources.Resources.Media_Ministry_Logo
        Me.pnl_Controls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl_Controls.Controls.Add(Me.wb_Updater)
        Me.pnl_Controls.Controls.Add(Me.btn_EmailMinistry)
        Me.pnl_Controls.Controls.Add(Me.mnstr_Strip)
        Me.pnl_Controls.Controls.Add(Me.btn_CustomerManagement)
        Me.pnl_Controls.Controls.Add(Me.btn_ShowOrders)
        Me.pnl_Controls.Controls.Add(Me.btn_placeOrder)
        Me.pnl_Controls.Controls.Add(Me.btn_ProductManagement)
        Me.pnl_Controls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_Controls.Location = New System.Drawing.Point(0, 0)
        Me.pnl_Controls.Name = "pnl_Controls"
        Me.pnl_Controls.Size = New System.Drawing.Size(397, 413)
        Me.pnl_Controls.TabIndex = 0
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
        'mnstr_Strip
        '
        Me.mnstr_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.mnstr_Strip.Location = New System.Drawing.Point(0, 0)
        Me.mnstr_Strip.Name = "mnstr_Strip"
        Me.mnstr_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnstr_Strip.Size = New System.Drawing.Size(397, 24)
        Me.mnstr_Strip.TabIndex = 0
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.toolStripSeparator1, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCustomerToolStripMenuItem, Me.NewProductToolStripMenuItem, Me.NewListenerToolStripMenuItem})
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewToolStripMenuItem.Text = "&New..."
        '
        'NewCustomerToolStripMenuItem
        '
        Me.NewCustomerToolStripMenuItem.Name = "NewCustomerToolStripMenuItem"
        Me.NewCustomerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewCustomerToolStripMenuItem.Text = "Customer"
        '
        'NewProductToolStripMenuItem
        '
        Me.NewProductToolStripMenuItem.Name = "NewProductToolStripMenuItem"
        Me.NewProductToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewProductToolStripMenuItem.Text = "Product"
        '
        'NewListenerToolStripMenuItem
        '
        Me.NewListenerToolStripMenuItem.Name = "NewListenerToolStripMenuItem"
        Me.NewListenerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewListenerToolStripMenuItem.Text = "Listener"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.MediaMinistry.My.Resources.Resources.logout_button
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogoutToolStripMenuItem.Text = "&Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewCustomersToolStripMenuItem, Me.ViewOrdersToolStripMenuItem, Me.ViewProductsToolStripMenuItem, Me.ViewListenersToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'ViewCustomersToolStripMenuItem
        '
        Me.ViewCustomersToolStripMenuItem.Name = "ViewCustomersToolStripMenuItem"
        Me.ViewCustomersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewCustomersToolStripMenuItem.Text = "Customers"
        '
        'ViewOrdersToolStripMenuItem
        '
        Me.ViewOrdersToolStripMenuItem.Name = "ViewOrdersToolStripMenuItem"
        Me.ViewOrdersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewOrdersToolStripMenuItem.Text = "Orders"
        '
        'ViewProductsToolStripMenuItem
        '
        Me.ViewProductsToolStripMenuItem.Name = "ViewProductsToolStripMenuItem"
        Me.ViewProductsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewProductsToolStripMenuItem.Text = "Products"
        '
        'ViewListenersToolStripMenuItem
        '
        Me.ViewListenersToolStripMenuItem.Name = "ViewListenersToolStripMenuItem"
        Me.ViewListenersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewListenersToolStripMenuItem.Text = "Listeners"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(397, 413)
        Me.Controls.Add(Me.ss_Queries)
        Me.Controls.Add(Me.pnl_Controls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnstr_Strip
        Me.MaximizeBox = False
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.ss_Queries.ResumeLayout(False)
        Me.ss_Queries.PerformLayout()
        Me.pnl_Controls.ResumeLayout(False)
        Me.pnl_Controls.PerformLayout()
        Me.mnstr_Strip.ResumeLayout(False)
        Me.mnstr_Strip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_placeOrder As Button
    Friend WithEvents btn_ShowOrders As Button
    Friend WithEvents btn_ProductManagement As Button
    Friend WithEvents btn_CustomerManagement As Button
    Friend WithEvents ss_Queries As StatusStrip
    Friend WithEvents tss_Feedback As ToolStripStatusLabel
    Friend WithEvents MediaMinistryDataSet As MediaMinistryDataSet
    Friend WithEvents INVENTORYBindingSource As BindingSource
    Friend WithEvents INVENTORYTableAdapter As MediaMinistryDataSetTableAdapters.INVENTORYTableAdapter
    Friend WithEvents CUSTOMERSBindingSource As BindingSource
    Friend WithEvents CUSTOMERSTableAdapter As MediaMinistryDataSetTableAdapters.CUSTOMERSTableAdapter
    Friend WithEvents bw_ChangedSizes As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_EmailMinistry As Button
    Friend WithEvents bw_UpdateJar As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnl_Controls As Panel
    Friend WithEvents mnstr_Strip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewListenerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents wb_Updater As WebBrowser
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewOrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewListenersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
End Class
