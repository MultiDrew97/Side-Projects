<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_UpdateInventory
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
        Me.btn_CancelUpdate = New System.Windows.Forms.Button()
        Me.btn_ConfirmUpdate = New System.Windows.Forms.Button()
        Me.lbl_ItemSelect = New System.Windows.Forms.Label()
        Me.cbx_Items = New System.Windows.Forms.ComboBox()
        Me.INVENTORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaMinistryDataSet = New MediaMinistryDataSet()
        Me.lbl_Stock = New System.Windows.Forms.Label()
        Me.nud_Stock = New System.Windows.Forms.NumericUpDown()
        Me.ss_AddStock = New System.Windows.Forms.StatusStrip()
        Me.tss_AddStock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tt_Help = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_Price = New System.Windows.Forms.TextBox()
        Me.INVENTORYTableAdapter = New MediaMinistryDataSetTableAdapters.INVENTORYTableAdapter()
        Me.lbl_Price = New System.Windows.Forms.Label()
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ss_AddStock.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_CancelUpdate
        '
        Me.btn_CancelUpdate.AutoSize = True
        Me.btn_CancelUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_CancelUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CancelUpdate.Location = New System.Drawing.Point(220, 258)
        Me.btn_CancelUpdate.Name = "btn_CancelUpdate"
        Me.btn_CancelUpdate.Size = New System.Drawing.Size(95, 35)
        Me.btn_CancelUpdate.TabIndex = 20
        Me.btn_CancelUpdate.Text = "Cancel"
        Me.btn_CancelUpdate.UseVisualStyleBackColor = True
        '
        'btn_ConfirmUpdate
        '
        Me.btn_ConfirmUpdate.AutoSize = True
        Me.btn_ConfirmUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_ConfirmUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ConfirmUpdate.Location = New System.Drawing.Point(35, 258)
        Me.btn_ConfirmUpdate.Name = "btn_ConfirmUpdate"
        Me.btn_ConfirmUpdate.Size = New System.Drawing.Size(163, 35)
        Me.btn_ConfirmUpdate.TabIndex = 19
        Me.btn_ConfirmUpdate.Text = "Update Stock"
        Me.btn_ConfirmUpdate.UseVisualStyleBackColor = True
        '
        'lbl_ItemSelect
        '
        Me.lbl_ItemSelect.AutoSize = True
        Me.lbl_ItemSelect.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ItemSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ItemSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_ItemSelect.Location = New System.Drawing.Point(58, 10)
        Me.lbl_ItemSelect.Name = "lbl_ItemSelect"
        Me.lbl_ItemSelect.Size = New System.Drawing.Size(60, 15)
        Me.lbl_ItemSelect.TabIndex = 15
        Me.lbl_ItemSelect.Text = "Product:"
        '
        'cbx_Items
        '
        Me.cbx_Items.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbx_Items.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_Items.DataSource = Me.INVENTORYBindingSource
        Me.cbx_Items.DisplayMember = "ITEM"
        Me.cbx_Items.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cbx_Items.FormattingEnabled = True
        Me.cbx_Items.Location = New System.Drawing.Point(61, 28)
        Me.cbx_Items.Name = "cbx_Items"
        Me.cbx_Items.Size = New System.Drawing.Size(231, 33)
        Me.cbx_Items.TabIndex = 16
        Me.tt_Help.SetToolTip(Me.cbx_Items, "Select the product that was made")
        Me.cbx_Items.ValueMember = "ITEM"
        '
        'INVENTORYBindingSource
        '
        Me.INVENTORYBindingSource.DataMember = "INVENTORY"
        Me.INVENTORYBindingSource.DataSource = Me.MediaMinistryDataSet
        '
        'MediaMinistryDataSet
        '
        Me.MediaMinistryDataSet.DataSetName = "Media_MinistryDataSet"
        Me.MediaMinistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_Stock
        '
        Me.lbl_Stock.AutoSize = True
        Me.lbl_Stock.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Stock.Location = New System.Drawing.Point(93, 94)
        Me.lbl_Stock.Name = "lbl_Stock"
        Me.lbl_Stock.Size = New System.Drawing.Size(97, 15)
        Me.lbl_Stock.TabIndex = 17
        Me.lbl_Stock.Text = "Current Stock:"
        '
        'nud_Stock
        '
        Me.nud_Stock.AutoSize = True
        Me.nud_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.nud_Stock.Location = New System.Drawing.Point(96, 112)
        Me.nud_Stock.Name = "nud_Stock"
        Me.nud_Stock.Size = New System.Drawing.Size(162, 32)
        Me.nud_Stock.TabIndex = 18
        Me.nud_Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tt_Help.SetToolTip(Me.nud_Stock, "Enter the current stock of product")
        '
        'ss_AddStock
        '
        Me.ss_AddStock.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_AddStock})
        Me.ss_AddStock.Location = New System.Drawing.Point(0, 311)
        Me.ss_AddStock.Name = "ss_AddStock"
        Me.ss_AddStock.Size = New System.Drawing.Size(350, 22)
        Me.ss_AddStock.TabIndex = 21
        '
        'tss_AddStock
        '
        Me.tss_AddStock.Name = "tss_AddStock"
        Me.tss_AddStock.Size = New System.Drawing.Size(126, 17)
        Me.tss_AddStock.Text = "How many was made?"
        '
        'txt_Price
        '
        Me.txt_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Price.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_Price.Location = New System.Drawing.Point(104, 182)
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.Size = New System.Drawing.Size(145, 31)
        Me.txt_Price.TabIndex = 22
        Me.txt_Price.Text = "$0.00"
        Me.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tt_Help.SetToolTip(Me.txt_Price, "The Current price of the item")
        '
        'INVENTORYTableAdapter
        '
        Me.INVENTORYTableAdapter.ClearBeforeFill = True
        '
        'lbl_Price
        '
        Me.lbl_Price.AutoSize = True
        Me.lbl_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Price.Location = New System.Drawing.Point(101, 164)
        Me.lbl_Price.Name = "lbl_Price"
        Me.lbl_Price.Size = New System.Drawing.Size(44, 15)
        Me.lbl_Price.TabIndex = 23
        Me.lbl_Price.Text = "Price:"
        '
        'frm_UpdateInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 333)
        Me.Controls.Add(Me.lbl_Price)
        Me.Controls.Add(Me.txt_Price)
        Me.Controls.Add(Me.ss_AddStock)
        Me.Controls.Add(Me.btn_CancelUpdate)
        Me.Controls.Add(Me.btn_ConfirmUpdate)
        Me.Controls.Add(Me.lbl_ItemSelect)
        Me.Controls.Add(Me.cbx_Items)
        Me.Controls.Add(Me.lbl_Stock)
        Me.Controls.Add(Me.nud_Stock)
        Me.Name = "frm_UpdateInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry"
        CType(Me.INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ss_AddStock.ResumeLayout(False)
        Me.ss_AddStock.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_CancelUpdate As Button
    Friend WithEvents btn_ConfirmUpdate As Button
    Friend WithEvents lbl_ItemSelect As Label
    Friend WithEvents cbx_Items As ComboBox
    Friend WithEvents tt_Help As ToolTip
    Friend WithEvents lbl_Stock As Label
    Friend WithEvents nud_Stock As NumericUpDown
    Friend WithEvents ss_AddStock As StatusStrip
    Friend WithEvents tss_AddStock As ToolStripStatusLabel
    Friend WithEvents INVENTORYBindingSource As BindingSource
    Friend WithEvents INVENTORYTableAdapter As MediaMinistryDataSetTableAdapters.INVENTORYTableAdapter
    Friend WithEvents MediaMinistryDataSet As MediaMinistryDataSet
    Friend WithEvents txt_Price As TextBox
    Friend WithEvents lbl_Price As Label
End Class
