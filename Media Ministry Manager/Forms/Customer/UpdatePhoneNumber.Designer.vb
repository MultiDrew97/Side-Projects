<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_UpdatePhoneNumber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_UpdatePhoneNumber))
        Me.cbx_FirstName = New System.Windows.Forms.ComboBox()
        Me.CUSTOMERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaMinistryDataSet = New MediaMinistry.MediaMinistryDataSet()
        Me.lbl_FirstName = New System.Windows.Forms.Label()
        Me.txt_NewNumber = New System.Windows.Forms.TextBox()
        Me.btn_UpdatePhone = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CUSTOMERSTableAdapter = New MediaMinistry.MediaMinistryDataSetTableAdapters.CUSTOMERSTableAdapter()
        Me.ss_UpdatePhone = New System.Windows.Forms.StatusStrip()
        Me.tss_UpdatePhone = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_OldNumber = New System.Windows.Forms.Label()
        Me.cbx_OldNumber = New System.Windows.Forms.ComboBox()
        CType(Me.CUSTOMERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ss_UpdatePhone.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbx_FirstName
        '
        Me.cbx_FirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbx_FirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_FirstName.DataSource = Me.CUSTOMERSBindingSource
        Me.cbx_FirstName.DisplayMember = "FIRST_NAME"
        Me.cbx_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_FirstName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbx_FirstName.FormattingEnabled = True
        Me.cbx_FirstName.Location = New System.Drawing.Point(97, 50)
        Me.cbx_FirstName.Name = "cbx_FirstName"
        Me.cbx_FirstName.Size = New System.Drawing.Size(198, 33)
        Me.cbx_FirstName.TabIndex = 0
        '
        'CUSTOMERSBindingSource
        '
        Me.CUSTOMERSBindingSource.DataMember = "CUSTOMERS"
        Me.CUSTOMERSBindingSource.DataSource = Me.MediaMinistryDataSet
        '
        'Media_MinistryDataSet
        '
        Me.MediaMinistryDataSet.DataSetName = "Media_MinistryDataSet"
        Me.MediaMinistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_FirstName
        '
        Me.lbl_FirstName.AutoSize = True
        Me.lbl_FirstName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FirstName.Location = New System.Drawing.Point(92, 34)
        Me.lbl_FirstName.Name = "lbl_FirstName"
        Me.lbl_FirstName.Size = New System.Drawing.Size(70, 15)
        Me.lbl_FirstName.TabIndex = 1
        Me.lbl_FirstName.Text = "First Name:"
        '
        'txt_NewNumber
        '
        Me.txt_NewNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NewNumber.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_NewNumber.Location = New System.Drawing.Point(97, 196)
        Me.txt_NewNumber.MaxLength = 12
        Me.txt_NewNumber.Name = "txt_NewNumber"
        Me.txt_NewNumber.Size = New System.Drawing.Size(198, 31)
        Me.txt_NewNumber.TabIndex = 2
        Me.txt_NewNumber.Text = "New Number"
        '
        'btn_UpdatePhone
        '
        Me.btn_UpdatePhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UpdatePhone.Location = New System.Drawing.Point(108, 251)
        Me.btn_UpdatePhone.Name = "btn_UpdatePhone"
        Me.btn_UpdatePhone.Size = New System.Drawing.Size(176, 68)
        Me.btn_UpdatePhone.TabIndex = 3
        Me.btn_UpdatePhone.Text = "Update Phone Number"
        Me.btn_UpdatePhone.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Number:"
        '
        'CUSTOMERSTableAdapter
        '
        Me.CUSTOMERSTableAdapter.ClearBeforeFill = True
        '
        'ss_UpdatePhone
        '
        Me.ss_UpdatePhone.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_UpdatePhone})
        Me.ss_UpdatePhone.Location = New System.Drawing.Point(0, 337)
        Me.ss_UpdatePhone.Name = "ss_UpdatePhone"
        Me.ss_UpdatePhone.Size = New System.Drawing.Size(386, 22)
        Me.ss_UpdatePhone.TabIndex = 4
        '
        'tss_UpdatePhone
        '
        Me.tss_UpdatePhone.Name = "tss_UpdatePhone"
        Me.tss_UpdatePhone.Size = New System.Drawing.Size(244, 17)
        Me.tss_UpdatePhone.Text = "Select person, then enter new phone number"
        '
        'lbl_OldNumber
        '
        Me.lbl_OldNumber.AutoSize = True
        Me.lbl_OldNumber.BackColor = System.Drawing.Color.Transparent
        Me.lbl_OldNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_OldNumber.Location = New System.Drawing.Point(94, 101)
        Me.lbl_OldNumber.Name = "lbl_OldNumber"
        Me.lbl_OldNumber.Size = New System.Drawing.Size(77, 15)
        Me.lbl_OldNumber.TabIndex = 6
        Me.lbl_OldNumber.Text = "Old Number:"
        '
        'cbx_OldNumber
        '
        Me.cbx_OldNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbx_OldNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_OldNumber.DataSource = Me.CUSTOMERSBindingSource
        Me.cbx_OldNumber.DisplayMember = "PHONE_NUMBER"
        Me.cbx_OldNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_OldNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbx_OldNumber.FormattingEnabled = True
        Me.cbx_OldNumber.Location = New System.Drawing.Point(97, 117)
        Me.cbx_OldNumber.Name = "cbx_OldNumber"
        Me.cbx_OldNumber.Size = New System.Drawing.Size(198, 33)
        Me.cbx_OldNumber.TabIndex = 5
        '
        'frm_UpdatePhoneNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 359)
        Me.Controls.Add(Me.lbl_OldNumber)
        Me.Controls.Add(Me.cbx_OldNumber)
        Me.Controls.Add(Me.ss_UpdatePhone)
        Me.Controls.Add(Me.btn_UpdatePhone)
        Me.Controls.Add(Me.txt_NewNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_FirstName)
        Me.Controls.Add(Me.cbx_FirstName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_UpdatePhoneNumber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        CType(Me.CUSTOMERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaMinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ss_UpdatePhone.ResumeLayout(False)
        Me.ss_UpdatePhone.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbx_FirstName As ComboBox
    Friend WithEvents lbl_FirstName As Label
    Friend WithEvents txt_NewNumber As TextBox
    Friend WithEvents btn_UpdatePhone As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CUSTOMERSBindingSource As BindingSource
    Friend WithEvents CUSTOMERSTableAdapter As MediaMinistry.MediaMinistryDataSetTableAdapters.CUSTOMERSTableAdapter
    Friend WithEvents ss_UpdatePhone As StatusStrip
    Friend WithEvents tss_UpdatePhone As ToolStripStatusLabel
    Friend WithEvents lbl_OldNumber As Label
    Friend WithEvents cbx_OldNumber As ComboBox
    Friend WithEvents MediaMinistryDataSet As MediaMinistry.MediaMinistryDataSet
End Class
