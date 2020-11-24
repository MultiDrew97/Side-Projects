<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DisplayOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_DisplayOrders))
        Me.dgv_Orders = New System.Windows.Forms.DataGridView()
        Me.Selection = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ORDERNUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONENUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDERSUMMARYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaMinistryDataSet = New MediaMinistry.MediaMinistryDataSet()
        Me.ORDER_SUMMARYTableAdapter = New MediaMinistry.MediaMinistryDataSetTableAdapters.ORDER_SUMMARYTableAdapter()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Fulfil = New System.Windows.Forms.Button()
        Me.btn_UpdateOrder = New System.Windows.Forms.Button()
        Me.btn_CancelOrder = New System.Windows.Forms.Button()
        CType(Me.dgv_Orders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERSUMMARYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Orders
        '
        Me.dgv_Orders.AllowUserToAddRows = False
        Me.dgv_Orders.AllowUserToDeleteRows = False
        Me.dgv_Orders.AutoGenerateColumns = False
        Me.dgv_Orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Orders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Selection, Me.ORDERNUMBERDataGridViewTextBoxColumn, Me.PHONENUMBERDataGridViewTextBoxColumn, Me.ITEMDataGridViewTextBoxColumn, Me.QUANTITYDataGridViewTextBoxColumn})
        Me.dgv_Orders.DataSource = Me.ORDERSUMMARYBindingSource
        Me.dgv_Orders.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgv_Orders.Location = New System.Drawing.Point(157, 0)
        Me.dgv_Orders.MultiSelect = False
        Me.dgv_Orders.Name = "dgv_Orders"
        Me.dgv_Orders.Size = New System.Drawing.Size(643, 450)
        Me.dgv_Orders.TabIndex = 0
        '
        'Selection
        '
        Me.Selection.FalseValue = "false"
        Me.Selection.FillWeight = 126.9036!
        Me.Selection.HeaderText = ""
        Me.Selection.Name = "Selection"
        Me.Selection.TrueValue = "true"
        '
        'ORDERNUMBERDataGridViewTextBoxColumn
        '
        Me.ORDERNUMBERDataGridViewTextBoxColumn.DataPropertyName = "ORDER_NUMBER"
        Me.ORDERNUMBERDataGridViewTextBoxColumn.HeaderText = "ORDER_NUMBER"
        Me.ORDERNUMBERDataGridViewTextBoxColumn.Name = "ORDERNUMBERDataGridViewTextBoxColumn"
        '
        'PHONENUMBERDataGridViewTextBoxColumn
        '
        Me.PHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE_NUMBER"
        Me.PHONENUMBERDataGridViewTextBoxColumn.HeaderText = "PHONE_NUMBER"
        Me.PHONENUMBERDataGridViewTextBoxColumn.Name = "PHONENUMBERDataGridViewTextBoxColumn"
        '
        'ITEMDataGridViewTextBoxColumn
        '
        Me.ITEMDataGridViewTextBoxColumn.DataPropertyName = "ITEM"
        Me.ITEMDataGridViewTextBoxColumn.HeaderText = "ITEM"
        Me.ITEMDataGridViewTextBoxColumn.Name = "ITEMDataGridViewTextBoxColumn"
        '
        'QUANTITYDataGridViewTextBoxColumn
        '
        Me.QUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.Name = "QUANTITYDataGridViewTextBoxColumn"
        '
        'ORDERSUMMARYBindingSource
        '
        Me.ORDERSUMMARYBindingSource.DataMember = "ORDER_SUMMARY"
        Me.ORDERSUMMARYBindingSource.DataSource = Me.MediaMinistryDataSet
        '
        'Media_MinistryDataSet
        '
        Me.MediaMinistryDataSet.DataSetName = "Media_MinistryDataSet"
        Me.MediaMinistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ORDER_SUMMARYTableAdapter
        '
        Me.ORDER_SUMMARYTableAdapter.ClearBeforeFill = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(12, 344)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(128, 63)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Fulfil
        '
        Me.btn_Fulfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Fulfil.Location = New System.Drawing.Point(12, 25)
        Me.btn_Fulfil.Name = "btn_Fulfil"
        Me.btn_Fulfil.Size = New System.Drawing.Size(128, 63)
        Me.btn_Fulfil.TabIndex = 1
        Me.btn_Fulfil.Text = "Complete Order(s)"
        Me.btn_Fulfil.UseVisualStyleBackColor = True
        '
        'btn_UpdateOrder
        '
        Me.btn_UpdateOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_UpdateOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UpdateOrder.Location = New System.Drawing.Point(12, 124)
        Me.btn_UpdateOrder.Name = "btn_UpdateOrder"
        Me.btn_UpdateOrder.Size = New System.Drawing.Size(128, 63)
        Me.btn_UpdateOrder.TabIndex = 1
        Me.btn_UpdateOrder.Text = "Update Order(s)"
        Me.btn_UpdateOrder.UseVisualStyleBackColor = True
        '
        'btn_CancelOrder
        '
        Me.btn_CancelOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_CancelOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CancelOrder.Location = New System.Drawing.Point(12, 240)
        Me.btn_CancelOrder.Name = "btn_CancelOrder"
        Me.btn_CancelOrder.Size = New System.Drawing.Size(128, 63)
        Me.btn_CancelOrder.TabIndex = 1
        Me.btn_CancelOrder.Text = "Cancel Order(s)"
        Me.btn_CancelOrder.UseVisualStyleBackColor = True
        '
        'frm_DisplayOrders
        '
        Me.AcceptButton = Me.btn_Fulfil
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Fulfil)
        Me.Controls.Add(Me.btn_UpdateOrder)
        Me.Controls.Add(Me.btn_CancelOrder)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.dgv_Orders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_DisplayOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        CType(Me.dgv_Orders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERSUMMARYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_Orders As DataGridView
    Friend WithEvents ORDERSUMMARYBindingSource As BindingSource
    Friend WithEvents ORDER_SUMMARYTableAdapter As MediaMinistry.MediaMinistryDataSetTableAdapters.ORDER_SUMMARYTableAdapter
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Fulfil As Button
    Friend WithEvents btn_UpdateOrder As Button
    Friend WithEvents btn_CancelOrder As Button
    Friend WithEvents Selection As DataGridViewCheckBoxColumn
    Friend WithEvents MediaMinistryDataSet As MediaMinistry.MediaMinistryDataSet
    Friend WithEvents ORDERNUMBERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PHONENUMBERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
