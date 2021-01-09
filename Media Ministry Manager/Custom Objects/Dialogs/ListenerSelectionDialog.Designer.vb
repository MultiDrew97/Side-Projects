<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListenerSelectionDialog
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
        Me.dgv_Listeners = New System.Windows.Forms.DataGridView()
        Me.EMAILLISTENERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaMinistryDataSet = New MediaMinistryDataSet()
        Me.chk_AllListeners = New System.Windows.Forms.CheckBox()
        Me.btn_Finish = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.EMAIL_LISTENERSTableAdapter = New MediaMinistryDataSetTableAdapters.EMAIL_LISTENERSTableAdapter()
        Me.bw_RetrieveListeners = New System.ComponentModel.BackgroundWorker()
        Me.Selection = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMAILLISTENERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Listeners
        '
        Me.dgv_Listeners.AllowUserToAddRows = False
        Me.dgv_Listeners.AllowUserToDeleteRows = False
        Me.dgv_Listeners.AllowUserToResizeColumns = False
        Me.dgv_Listeners.AllowUserToResizeRows = False
        Me.dgv_Listeners.AutoGenerateColumns = False
        Me.dgv_Listeners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Listeners.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Listeners.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Selection, Me.NAMEDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn})
        Me.dgv_Listeners.DataSource = Me.EMAILLISTENERSBindingSource
        Me.dgv_Listeners.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgv_Listeners.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Listeners.Margin = New System.Windows.Forms.Padding(6)
        Me.dgv_Listeners.Name = "dgv_Listeners"
        Me.dgv_Listeners.Size = New System.Drawing.Size(470, 487)
        Me.dgv_Listeners.TabIndex = 0
        '
        'EMAILLISTENERSBindingSource
        '
        Me.EMAILLISTENERSBindingSource.DataMember = "EMAIL_LISTENERS"
        Me.EMAILLISTENERSBindingSource.DataSource = Me.MediaMinistryDataSet
        '
        'MediaMinistryDataSet
        '
        Me.MediaMinistryDataSet.DataSetName = "MediaMinistryDataSet"
        Me.MediaMinistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chk_AllListeners
        '
        Me.chk_AllListeners.AutoSize = True
        Me.chk_AllListeners.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_AllListeners.Location = New System.Drawing.Point(558, 417)
        Me.chk_AllListeners.Margin = New System.Windows.Forms.Padding(6)
        Me.chk_AllListeners.Name = "chk_AllListeners"
        Me.chk_AllListeners.Size = New System.Drawing.Size(146, 29)
        Me.chk_AllListeners.TabIndex = 1
        Me.chk_AllListeners.Text = "Send to All"
        Me.chk_AllListeners.UseVisualStyleBackColor = True
        '
        'btn_Finish
        '
        Me.btn_Finish.AutoSize = True
        Me.btn_Finish.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Finish.Location = New System.Drawing.Point(558, 41)
        Me.btn_Finish.Name = "btn_Finish"
        Me.btn_Finish.Size = New System.Drawing.Size(138, 48)
        Me.btn_Finish.TabIndex = 2
        Me.btn_Finish.Text = "Finish"
        Me.btn_Finish.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AutoSize = True
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(558, 106)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(138, 48)
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'EMAIL_LISTENERSTableAdapter
        '
        Me.EMAIL_LISTENERSTableAdapter.ClearBeforeFill = True
        '
        'bw_RetrieveListeners
        '
        '
        'Selection
        '
        Me.Selection.FillWeight = 50.0!
        Me.Selection.HeaderText = ""
        Me.Selection.Name = "Selection"
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        Me.NAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        Me.EMAILDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListenerSelectionDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 487)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Finish)
        Me.Controls.Add(Me.chk_AllListeners)
        Me.Controls.Add(Me.dgv_Listeners)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListenerSelectionDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ListenerSelectionDialog"
        CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMAILLISTENERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Listeners As DataGridView
    Friend WithEvents MediaMinistryDataSet As MediaMinistryDataSet
    Friend WithEvents EMAILLISTENERSBindingSource As BindingSource
    Friend WithEvents EMAIL_LISTENERSTableAdapter As MediaMinistryDataSetTableAdapters.EMAIL_LISTENERSTableAdapter
    Friend WithEvents chk_AllListeners As CheckBox
    Friend WithEvents btn_Finish As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents bw_RetrieveListeners As System.ComponentModel.BackgroundWorker
    Friend WithEvents Selection As DataGridViewCheckBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
