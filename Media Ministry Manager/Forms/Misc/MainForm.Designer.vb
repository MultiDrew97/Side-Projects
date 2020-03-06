<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.btn_placeOrder = New System.Windows.Forms.Button()
        Me.btn_ShowOrders = New System.Windows.Forms.Button()
        Me.btn_ProductManagement = New System.Windows.Forms.Button()
        Me.tt_ControlInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_AddNewCustomer = New System.Windows.Forms.Button()
        Me.ss_Queries = New System.Windows.Forms.StatusStrip()
        Me.tss_DatabaseQueries = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_LogOut = New System.Windows.Forms.Button()
        Me.bw_Database = New System.ComponentModel.BackgroundWorker()
        Me.INVENTORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Media_MinistryDataSet = New Media_Ministry.Media_MinistryDataSet()
        Me.INVENTORYTableAdapter = New Media_Ministry.Media_MinistryDataSetTableAdapters.INVENTORYTableAdapter()
        Me.CUSTOMERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUSTOMERSTableAdapter = New Media_Ministry.Media_MinistryDataSetTableAdapters.CUSTOMERSTableAdapter()
        Me.btn_EmailMinistry = New System.Windows.Forms.Button()
        Me.ss_Queries.SuspendLayout()
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Media_MinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_placeOrder
        '
        Me.btn_placeOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_placeOrder.Location = New System.Drawing.Point(92, 88)
        Me.btn_placeOrder.Name = "btn_placeOrder"
        Me.btn_placeOrder.Size = New System.Drawing.Size(179, 50)
        Me.btn_placeOrder.TabIndex = 2
        Me.btn_placeOrder.Text = "Place an Order"
        Me.btn_placeOrder.UseVisualStyleBackColor = True
        '
        'btn_ShowOrders
        '
        Me.btn_ShowOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ShowOrders.Location = New System.Drawing.Point(92, 163)
        Me.btn_ShowOrders.Name = "btn_ShowOrders"
        Me.btn_ShowOrders.Size = New System.Drawing.Size(179, 50)
        Me.btn_ShowOrders.TabIndex = 3
        Me.btn_ShowOrders.Text = "Show Orders"
        Me.btn_ShowOrders.UseVisualStyleBackColor = True
        '
        'btn_ProductManagement
        '
        Me.btn_ProductManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ProductManagement.Location = New System.Drawing.Point(92, 238)
        Me.btn_ProductManagement.Name = "btn_ProductManagement"
        Me.btn_ProductManagement.Size = New System.Drawing.Size(179, 50)
        Me.btn_ProductManagement.TabIndex = 4
        Me.btn_ProductManagement.Text = "Product Management"
        Me.btn_ProductManagement.UseVisualStyleBackColor = True
        '
        'btn_AddNewCustomer
        '
        Me.btn_AddNewCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddNewCustomer.Location = New System.Drawing.Point(92, 13)
        Me.btn_AddNewCustomer.Name = "btn_AddNewCustomer"
        Me.btn_AddNewCustomer.Size = New System.Drawing.Size(179, 50)
        Me.btn_AddNewCustomer.TabIndex = 1
        Me.btn_AddNewCustomer.Text = "Customer Management"
        Me.btn_AddNewCustomer.UseVisualStyleBackColor = True
        '
        'ss_Queries
        '
        Me.ss_Queries.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_DatabaseQueries})
        Me.ss_Queries.Location = New System.Drawing.Point(0, 391)
        Me.ss_Queries.Name = "ss_Queries"
        Me.ss_Queries.Size = New System.Drawing.Size(397, 22)
        Me.ss_Queries.TabIndex = 0
        '
        'tss_DatabaseQueries
        '
        Me.tss_DatabaseQueries.Name = "tss_DatabaseQueries"
        Me.tss_DatabaseQueries.Size = New System.Drawing.Size(151, 17)
        Me.tss_DatabaseQueries.Text = "What would you like to do?"
        '
        'btn_LogOut
        '
        Me.btn_LogOut.BackColor = System.Drawing.Color.Transparent
        Me.btn_LogOut.BackgroundImage = Global.Media_Ministry.My.Resources.Resources.logout_button
        Me.btn_LogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_LogOut.Location = New System.Drawing.Point(331, 12)
        Me.btn_LogOut.Name = "btn_LogOut"
        Me.btn_LogOut.Size = New System.Drawing.Size(26, 24)
        Me.btn_LogOut.TabIndex = 6
        Me.btn_LogOut.UseVisualStyleBackColor = False
        '
        'bw_Database
        '
        '
        'INVENTORYBindingSource
        '
        Me.INVENTORYBindingSource.DataMember = "INVENTORY"
        Me.INVENTORYBindingSource.DataSource = Me.Media_MinistryDataSet
        '
        'Media_MinistryDataSet
        '
        Me.Media_MinistryDataSet.DataSetName = "Media_MinistryDataSet"
        Me.Media_MinistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INVENTORYTableAdapter
        '
        Me.INVENTORYTableAdapter.ClearBeforeFill = True
        '
        'CUSTOMERSBindingSource
        '
        Me.CUSTOMERSBindingSource.DataMember = "CUSTOMERS"
        Me.CUSTOMERSBindingSource.DataSource = Me.Media_MinistryDataSet
        '
        'CUSTOMERSTableAdapter
        '
        Me.CUSTOMERSTableAdapter.ClearBeforeFill = True
        '
        'btn_EmailMinistry
        '
        Me.btn_EmailMinistry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_EmailMinistry.Location = New System.Drawing.Point(92, 313)
        Me.btn_EmailMinistry.Name = "btn_EmailMinistry"
        Me.btn_EmailMinistry.Size = New System.Drawing.Size(179, 50)
        Me.btn_EmailMinistry.TabIndex = 5
        Me.btn_EmailMinistry.Text = "Email Ministry"
        Me.btn_EmailMinistry.UseVisualStyleBackColor = True
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Media_Ministry.My.Resources.Resources.Media_Ministry_Manage_Image
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(397, 413)
        Me.Controls.Add(Me.btn_EmailMinistry)
        Me.Controls.Add(Me.btn_LogOut)
        Me.Controls.Add(Me.ss_Queries)
        Me.Controls.Add(Me.btn_AddNewCustomer)
        Me.Controls.Add(Me.btn_ProductManagement)
        Me.Controls.Add(Me.btn_placeOrder)
        Me.Controls.Add(Me.btn_ShowOrders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry"
        Me.ss_Queries.ResumeLayout(False)
        Me.ss_Queries.PerformLayout()
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Media_MinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_placeOrder As Button
    Friend WithEvents btn_ShowOrders As Button
    Friend WithEvents btn_ProductManagement As Button
    Friend WithEvents tt_ControlInfo As ToolTip
    Friend WithEvents btn_AddNewCustomer As Button
    Friend WithEvents ss_Queries As StatusStrip
    Friend WithEvents tss_DatabaseQueries As ToolStripStatusLabel
    Friend WithEvents Media_MinistryDataSet As Media_MinistryDataSet
    Friend WithEvents INVENTORYBindingSource As BindingSource
    Friend WithEvents INVENTORYTableAdapter As Media_MinistryDataSetTableAdapters.INVENTORYTableAdapter
    Friend WithEvents CUSTOMERSBindingSource As BindingSource
    Friend WithEvents CUSTOMERSTableAdapter As Media_MinistryDataSetTableAdapters.CUSTOMERSTableAdapter
    Friend WithEvents btn_LogOut As Button
    Friend WithEvents bw_Database As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_EmailMinistry As Button
End Class
