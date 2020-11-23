<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ViewInventory
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
        Me.dgv_Inventory = New System.Windows.Forms.DataGridView()
        Me.INVENTORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaMinistryDataSet = New MediaMinistryDataSet()
        Me.INVENTORYTableAdapter = New MediaMinistryDataSetTableAdapters.INVENTORYTableAdapter()
        Me.btn_AddProduct = New System.Windows.Forms.Button()
        Me.ITEMINDEXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INSTOCKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_Inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Inventory
        '
        Me.dgv_Inventory.AllowUserToAddRows = False
        Me.dgv_Inventory.AutoGenerateColumns = False
        Me.dgv_Inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Inventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEMINDEXDataGridViewTextBoxColumn, Me.ITEMDataGridViewTextBoxColumn, Me.INSTOCKDataGridViewTextBoxColumn, Me.PRICEDataGridViewTextBoxColumn})
        Me.dgv_Inventory.DataSource = Me.INVENTORYBindingSource
        Me.dgv_Inventory.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgv_Inventory.Location = New System.Drawing.Point(162, 0)
        Me.dgv_Inventory.Name = "dgv_Inventory"
        Me.dgv_Inventory.Size = New System.Drawing.Size(443, 450)
        Me.dgv_Inventory.TabIndex = 0
        '
        'INVENTORYBindingSource
        '
        Me.INVENTORYBindingSource.DataMember = "INVENTORY"
        Me.INVENTORYBindingSource.DataSource = Me.MediaMinistryDataSet
        '
        'Media_MinistryDataSet
        '
        Me.MediaMinistryDataSet.DataSetName = "Media_MinistryDataSet"
        Me.MediaMinistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INVENTORYTableAdapter
        '
        Me.INVENTORYTableAdapter.ClearBeforeFill = True
        '
        'btn_AddProduct
        '
        Me.btn_AddProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddProduct.Location = New System.Drawing.Point(22, 31)
        Me.btn_AddProduct.Name = "btn_AddProduct"
        Me.btn_AddProduct.Size = New System.Drawing.Size(119, 85)
        Me.btn_AddProduct.TabIndex = 3
        Me.btn_AddProduct.Text = "Add New Product"
        Me.btn_AddProduct.UseVisualStyleBackColor = True
        '
        'ITEMINDEXDataGridViewTextBoxColumn
        '
        Me.ITEMINDEXDataGridViewTextBoxColumn.DataPropertyName = "ITEM_INDEX"
        Me.ITEMINDEXDataGridViewTextBoxColumn.HeaderText = "ITEM_INDEX"
        Me.ITEMINDEXDataGridViewTextBoxColumn.Name = "ITEMINDEXDataGridViewTextBoxColumn"
        Me.ITEMINDEXDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMDataGridViewTextBoxColumn
        '
        Me.ITEMDataGridViewTextBoxColumn.DataPropertyName = "ITEM"
        Me.ITEMDataGridViewTextBoxColumn.HeaderText = "ITEM"
        Me.ITEMDataGridViewTextBoxColumn.Name = "ITEMDataGridViewTextBoxColumn"
        '
        'INSTOCKDataGridViewTextBoxColumn
        '
        Me.INSTOCKDataGridViewTextBoxColumn.DataPropertyName = "IN_STOCK"
        Me.INSTOCKDataGridViewTextBoxColumn.HeaderText = "IN_STOCK"
        Me.INSTOCKDataGridViewTextBoxColumn.Name = "INSTOCKDataGridViewTextBoxColumn"
        '
        'PRICEDataGridViewTextBoxColumn
        '
        Me.PRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE"
        Me.PRICEDataGridViewTextBoxColumn.HeaderText = "PRICE"
        Me.PRICEDataGridViewTextBoxColumn.Name = "PRICEDataGridViewTextBoxColumn"
        '
        'frm_ViewInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(605, 450)
        Me.Controls.Add(Me.btn_AddProduct)
        Me.Controls.Add(Me.dgv_Inventory)
        Me.MaximizeBox = False
        Me.Name = "frm_ViewInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry"
        CType(Me.dgv_Inventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_Inventory As DataGridView
    Friend WithEvents INVENTORYBindingSource As BindingSource
    Friend WithEvents INVENTORYTableAdapter As MediaMinistryDataSetTableAdapters.INVENTORYTableAdapter
    Friend WithEvents btn_AddProduct As Button
    Friend WithEvents MediaMinistryDataSet As MediaMinistryDataSet
    Friend WithEvents ITEMINDEXDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INSTOCKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
