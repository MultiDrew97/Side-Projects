<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_ViewInventory
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
        Me.dgv_Inventory = New System.Windows.Forms.DataGridView()
        Me.btn_AddProduct = New System.Windows.Forms.Button()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MediaMinistryDataSet = New MediaMinistryDataSet()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVENTORYTableAdapter = New MediaMinistryDataSetTableAdapters.INVENTORYTableAdapter()
        Me.ItemNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_Inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Inventory
        '
        Me.dgv_Inventory.AllowUserToAddRows = False
        Me.dgv_Inventory.AutoGenerateColumns = False
        Me.dgv_Inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Inventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemNameDataGridViewTextBoxColumn1, Me.StockDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn1})
        Me.dgv_Inventory.DataSource = Me.InventoryBindingSource
        Me.dgv_Inventory.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgv_Inventory.Location = New System.Drawing.Point(162, 0)
        Me.dgv_Inventory.Name = "dgv_Inventory"
        Me.dgv_Inventory.Size = New System.Drawing.Size(443, 450)
        Me.dgv_Inventory.TabIndex = 0
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
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Current Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        '
        'MediaMinistryDataSet
        '
        Me.MediaMinistryDataSet.DataSetName = "MediaMinistryDataSet"
        Me.MediaMinistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.MediaMinistryDataSet
        '
        'INVENTORYTableAdapter
        '
        Me.INVENTORYTableAdapter.ClearBeforeFill = True
        '
        'ItemNameDataGridViewTextBoxColumn1
        '
        Me.ItemNameDataGridViewTextBoxColumn1.DataPropertyName = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.ItemNameDataGridViewTextBoxColumn1.Name = "ItemNameDataGridViewTextBoxColumn1"
        '
        'StockDataGridViewTextBoxColumn1
        '
        Me.StockDataGridViewTextBoxColumn1.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn1.HeaderText = "Current Stock"
        Me.StockDataGridViewTextBoxColumn1.Name = "StockDataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Current Price"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
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
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_Inventory As DataGridView
    Friend WithEvents btn_AddProduct As Button
    Friend WithEvents ITEMINDEXDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INSTOCKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MediaMinistryDataSet As MediaMinistryDataSet
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents INVENTORYTableAdapter As MediaMinistryDataSetTableAdapters.INVENTORYTableAdapter
    Friend WithEvents ItemNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
