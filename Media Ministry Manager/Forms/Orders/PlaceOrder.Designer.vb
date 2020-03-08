<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_PlaceOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PlaceOrder))
        Me.cbx_ItemName = New System.Windows.Forms.ComboBox()
        Me.INVENTORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Media_MinistryDataSet = New Media_Ministry.Media_MinistryDataSet()
        Me.lbl_ItemName = New System.Windows.Forms.Label()
        Me.ss_AddOrder = New System.Windows.Forms.StatusStrip()
        Me.tss_AddOrder = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cbx_FirstName = New System.Windows.Forms.ComboBox()
        Me.CUSTOMERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_FirstName = New System.Windows.Forms.Label()
        Me.nud_Quantity = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Quantity = New System.Windows.Forms.Label()
        Me.btn_AddOrder = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.cbx_PhoneNumber = New System.Windows.Forms.ComboBox()
        Me.lbl_PhoneNumber = New System.Windows.Forms.Label()
        Me.CUSTOMERSTableAdapter = New Media_Ministry.Media_MinistryDataSetTableAdapters.CUSTOMERSTableAdapter()
        Me.INVENTORYTableAdapter = New Media_Ministry.Media_MinistryDataSetTableAdapters.INVENTORYTableAdapter()
        Me.bw_LoadingData = New System.ComponentModel.BackgroundWorker()
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Media_MinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ss_AddOrder.SuspendLayout()
        CType(Me.CUSTOMERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbx_ItemName
        '
        Me.cbx_ItemName.DataSource = Me.INVENTORYBindingSource
        Me.cbx_ItemName.DisplayMember = "ITEM"
        Me.cbx_ItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cbx_ItemName.FormattingEnabled = True
        Me.cbx_ItemName.Location = New System.Drawing.Point(69, 154)
        Me.cbx_ItemName.Name = "cbx_ItemName"
        Me.cbx_ItemName.Size = New System.Drawing.Size(226, 33)
        Me.cbx_ItemName.TabIndex = 5
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
        'lbl_ItemName
        '
        Me.lbl_ItemName.AutoSize = True
        Me.lbl_ItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_ItemName.Location = New System.Drawing.Point(66, 136)
        Me.lbl_ItemName.Name = "lbl_ItemName"
        Me.lbl_ItemName.Size = New System.Drawing.Size(49, 15)
        Me.lbl_ItemName.TabIndex = 4
        Me.lbl_ItemName.Text = "Product"
        '
        'ss_AddOrder
        '
        Me.ss_AddOrder.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_AddOrder})
        Me.ss_AddOrder.Location = New System.Drawing.Point(0, 306)
        Me.ss_AddOrder.Name = "ss_AddOrder"
        Me.ss_AddOrder.Size = New System.Drawing.Size(503, 22)
        Me.ss_AddOrder.TabIndex = 10
        '
        'tss_AddOrder
        '
        Me.tss_AddOrder.Name = "tss_AddOrder"
        Me.tss_AddOrder.Size = New System.Drawing.Size(187, 17)
        Me.tss_AddOrder.Text = "Add the information for the order."
        '
        'cbx_FirstName
        '
        Me.cbx_FirstName.DataSource = Me.CUSTOMERSBindingSource
        Me.cbx_FirstName.DisplayMember = "FIRST_NAME"
        Me.cbx_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cbx_FirstName.FormattingEnabled = True
        Me.cbx_FirstName.Location = New System.Drawing.Point(51, 66)
        Me.cbx_FirstName.Name = "cbx_FirstName"
        Me.cbx_FirstName.Size = New System.Drawing.Size(191, 33)
        Me.cbx_FirstName.TabIndex = 1
        '
        'CUSTOMERSBindingSource
        '
        Me.CUSTOMERSBindingSource.DataMember = "CUSTOMERS"
        Me.CUSTOMERSBindingSource.DataSource = Me.Media_MinistryDataSet
        '
        'lbl_FirstName
        '
        Me.lbl_FirstName.AutoSize = True
        Me.lbl_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_FirstName.Location = New System.Drawing.Point(48, 49)
        Me.lbl_FirstName.Name = "lbl_FirstName"
        Me.lbl_FirstName.Size = New System.Drawing.Size(67, 15)
        Me.lbl_FirstName.TabIndex = 0
        Me.lbl_FirstName.Text = "First Name"
        '
        'nud_Quantity
        '
        Me.nud_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.nud_Quantity.Location = New System.Drawing.Point(317, 155)
        Me.nud_Quantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_Quantity.Name = "nud_Quantity"
        Me.nud_Quantity.Size = New System.Drawing.Size(120, 32)
        Me.nud_Quantity.TabIndex = 7
        Me.nud_Quantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_Quantity
        '
        Me.lbl_Quantity.AutoSize = True
        Me.lbl_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_Quantity.Location = New System.Drawing.Point(314, 137)
        Me.lbl_Quantity.Name = "lbl_Quantity"
        Me.lbl_Quantity.Size = New System.Drawing.Size(51, 15)
        Me.lbl_Quantity.TabIndex = 6
        Me.lbl_Quantity.Text = "Quantity"
        '
        'btn_AddOrder
        '
        Me.btn_AddOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_AddOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btn_AddOrder.Location = New System.Drawing.Point(284, 228)
        Me.btn_AddOrder.Name = "btn_AddOrder"
        Me.btn_AddOrder.Size = New System.Drawing.Size(122, 51)
        Me.btn_AddOrder.TabIndex = 8
        Me.btn_AddOrder.Text = "Add Order"
        Me.btn_AddOrder.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btn_Cancel.Location = New System.Drawing.Point(96, 228)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(122, 51)
        Me.btn_Cancel.TabIndex = 9
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'cbx_PhoneNumber
        '
        Me.cbx_PhoneNumber.DataSource = Me.CUSTOMERSBindingSource
        Me.cbx_PhoneNumber.DisplayMember = "PHONE_NUMBER"
        Me.cbx_PhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cbx_PhoneNumber.FormattingEnabled = True
        Me.cbx_PhoneNumber.Location = New System.Drawing.Point(264, 66)
        Me.cbx_PhoneNumber.Name = "cbx_PhoneNumber"
        Me.cbx_PhoneNumber.Size = New System.Drawing.Size(191, 33)
        Me.cbx_PhoneNumber.TabIndex = 3
        '
        'lbl_PhoneNumber
        '
        Me.lbl_PhoneNumber.AutoSize = True
        Me.lbl_PhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_PhoneNumber.Location = New System.Drawing.Point(261, 49)
        Me.lbl_PhoneNumber.Name = "lbl_PhoneNumber"
        Me.lbl_PhoneNumber.Size = New System.Drawing.Size(91, 15)
        Me.lbl_PhoneNumber.TabIndex = 2
        Me.lbl_PhoneNumber.Text = "Phone Number"
        '
        'CUSTOMERSTableAdapter
        '
        Me.CUSTOMERSTableAdapter.ClearBeforeFill = True
        '
        'INVENTORYTableAdapter
        '
        Me.INVENTORYTableAdapter.ClearBeforeFill = True
        '
        'frm_PlaceOrder
        '
        Me.AcceptButton = Me.btn_AddOrder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(503, 328)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_AddOrder)
        Me.Controls.Add(Me.lbl_Quantity)
        Me.Controls.Add(Me.nud_Quantity)
        Me.Controls.Add(Me.ss_AddOrder)
        Me.Controls.Add(Me.lbl_PhoneNumber)
        Me.Controls.Add(Me.lbl_FirstName)
        Me.Controls.Add(Me.lbl_ItemName)
        Me.Controls.Add(Me.cbx_PhoneNumber)
        Me.Controls.Add(Me.cbx_FirstName)
        Me.Controls.Add(Me.cbx_ItemName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_PlaceOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Media_MinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ss_AddOrder.ResumeLayout(False)
        Me.ss_AddOrder.PerformLayout()
        CType(Me.CUSTOMERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbx_ItemName As ComboBox
    Friend WithEvents lbl_ItemName As Label
    Friend WithEvents ss_AddOrder As StatusStrip
    Friend WithEvents tss_AddOrder As ToolStripStatusLabel
    Friend WithEvents cbx_FirstName As ComboBox
    Friend WithEvents lbl_FirstName As Label
    Friend WithEvents nud_Quantity As NumericUpDown
    Friend WithEvents lbl_Quantity As Label
    Friend WithEvents btn_AddOrder As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents cbx_PhoneNumber As ComboBox
    Friend WithEvents lbl_PhoneNumber As Label
    Friend WithEvents Media_MinistryDataSet As Media_MinistryDataSet
    Friend WithEvents CUSTOMERSBindingSource As BindingSource
    Friend WithEvents CUSTOMERSTableAdapter As Media_MinistryDataSetTableAdapters.CUSTOMERSTableAdapter
    Friend WithEvents INVENTORYBindingSource As BindingSource
    Friend WithEvents INVENTORYTableAdapter As Media_MinistryDataSetTableAdapters.INVENTORYTableAdapter
    Friend WithEvents bw_LoadingData As System.ComponentModel.BackgroundWorker
End Class
