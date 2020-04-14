<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ViewListeners
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ViewListeners))
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.dgv_Listeners = New System.Windows.Forms.DataGridView()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.lbl_SearchLabel = New System.Windows.Forms.Label()
        Me.txt_SearchBox = New System.Windows.Forms.TextBox()
        Me.btn_Advanced = New System.Windows.Forms.Button()
        Me.cbx_Column = New System.Windows.Forms.ComboBox()
        Me.txt_NameSearch = New System.Windows.Forms.TextBox()
        Me.txt_EmailSearch = New System.Windows.Forms.TextBox()
        Me.lbl_NameSearch = New System.Windows.Forms.Label()
        Me.lbl_EmailSearch = New System.Windows.Forms.Label()
        Me.gbx_AdvancedSearch = New System.Windows.Forms.GroupBox()
        Me.btn_AdvancedSearch = New System.Windows.Forms.Button()
        Me.btn_AdvancedCancel = New System.Windows.Forms.Button()
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILLISTENERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Media_MinistryDataSet = New Media_Ministry.Media_MinistryDataSet()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.lbl_SearchLabel = New System.Windows.Forms.Label()
        Me.txt_SearchBox = New System.Windows.Forms.TextBox()
        Me.btn_Advanced = New System.Windows.Forms.Button()
        Me.cbx_Column = New System.Windows.Forms.ComboBox()
        Me.txt_NameSearch = New System.Windows.Forms.TextBox()
        Me.txt_EmailSearch = New System.Windows.Forms.TextBox()
        Me.lbl_NameSearch = New System.Windows.Forms.Label()
        Me.lbl_EmailSearch = New System.Windows.Forms.Label()
        Me.gbx_AdvancedSearch = New System.Windows.Forms.GroupBox()
        Me.btn_AdvancedSearch = New System.Windows.Forms.Button()
        Me.btn_AdvancedCancel = New System.Windows.Forms.Button()
        CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_AdvancedSearch.SuspendLayout()
        CType(Me.EMAILLISTENERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Media_MinistryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_AdvancedSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Add
        '
        Me.btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Add.Location = New System.Drawing.Point(665, 331)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(169, 39)
        Me.btn_Add.TabIndex = 1
        Me.btn_Add.Text = "Add Listener"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'dgv_Listeners
        '
        Me.dgv_Listeners.AllowUserToAddRows = False
        Me.dgv_Listeners.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv_Listeners.AutoGenerateColumns = False
        Me.dgv_Listeners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Listeners.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_Listeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Listeners.DataSource = Me.EMAILLISTENERSBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Listeners.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Listeners.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Listeners.Name = "dgv_Listeners"
        Me.dgv_Listeners.Size = New System.Drawing.Size(613, 450)
        Me.dgv_Listeners.TabIndex = 0
        '
        'EMAILLISTENERSBindingSource
        '
        Me.EMAILLISTENERSBindingSource.DataSource = Me.Media_MinistryDataSet
        Me.EMAILLISTENERSBindingSource.Position = 0
        '
        'Media_MinistryDataSet
        '
        Me.Media_MinistryDataSet.DataSetName = "Media_MinistryDataSet"
        Me.Media_MinistryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(660, 373)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(183, 25)
        Me.lbl_Total.TabIndex = 2
        Me.lbl_Total.Text = "Total Listeners: "
        '
        'btn_Search
        '
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Search.Location = New System.Drawing.Point(781, 123)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(100, 33)
        Me.btn_Search.TabIndex = 3
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'lbl_SearchLabel
        '
        Me.lbl_SearchLabel.AutoSize = True
        Me.lbl_SearchLabel.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_SearchLabel.Location = New System.Drawing.Point(619, 75)
        Me.lbl_SearchLabel.Name = "lbl_SearchLabel"
        Me.lbl_SearchLabel.Size = New System.Drawing.Size(93, 25)
        Me.lbl_SearchLabel.TabIndex = 4
        Me.lbl_SearchLabel.Text = "Search:"
        '
        'txt_SearchBox
        '
        Me.txt_SearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txt_SearchBox.Location = New System.Drawing.Point(712, 75)
        Me.txt_SearchBox.Name = "txt_SearchBox"
        Me.txt_SearchBox.Size = New System.Drawing.Size(269, 31)
        Me.txt_SearchBox.TabIndex = 5
        '
        'btn_Advanced
        '
        Me.btn_Advanced.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Advanced.Location = New System.Drawing.Point(1199, 151)
        Me.btn_Advanced.Name = "btn_Advanced"
        Me.btn_Advanced.Size = New System.Drawing.Size(132, 33)
        Me.btn_Advanced.TabIndex = 6
        Me.btn_Advanced.Text = "Advanced"
        Me.btn_Advanced.UseVisualStyleBackColor = True
        Me.btn_Advanced.Visible = False
        '
        'cbx_Column
        '
        Me.cbx_Column.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.cbx_Column.FormattingEnabled = True
        Me.cbx_Column.Items.AddRange(New Object() {"NAME", "EMAIL"})
        Me.cbx_Column.Location = New System.Drawing.Point(730, 12)
        Me.cbx_Column.Name = "cbx_Column"
        Me.cbx_Column.Size = New System.Drawing.Size(192, 33)
        Me.cbx_Column.TabIndex = 7
        '
        'txt_NameSearch
        '
        Me.txt_NameSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txt_NameSearch.Location = New System.Drawing.Point(24, 60)
        Me.txt_NameSearch.Name = "txt_NameSearch"
        Me.txt_NameSearch.Size = New System.Drawing.Size(356, 31)
        Me.txt_NameSearch.TabIndex = 8
        '
        'txt_EmailSearch
        '
        Me.txt_EmailSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txt_EmailSearch.Location = New System.Drawing.Point(24, 140)
        Me.txt_EmailSearch.Name = "txt_EmailSearch"
        Me.txt_EmailSearch.Size = New System.Drawing.Size(356, 31)
        Me.txt_EmailSearch.TabIndex = 9
        '
        'lbl_NameSearch
        '
        Me.lbl_NameSearch.AutoSize = True
        Me.lbl_NameSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_NameSearch.Location = New System.Drawing.Point(19, 32)
        Me.lbl_NameSearch.Name = "lbl_NameSearch"
        Me.lbl_NameSearch.Size = New System.Drawing.Size(79, 25)
        Me.lbl_NameSearch.TabIndex = 10
        Me.lbl_NameSearch.Text = "Name:"
        '
        'lbl_EmailSearch
        '
        Me.lbl_EmailSearch.AutoSize = True
        Me.lbl_EmailSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_EmailSearch.Location = New System.Drawing.Point(19, 112)
        Me.lbl_EmailSearch.Name = "lbl_EmailSearch"
        Me.lbl_EmailSearch.Size = New System.Drawing.Size(170, 25)
        Me.lbl_EmailSearch.TabIndex = 11
        Me.lbl_EmailSearch.Text = "Email Address:"
        '
        'gbx_AdvancedSearch
        '
        Me.gbx_AdvancedSearch.BackColor = System.Drawing.Color.Gray
        Me.gbx_AdvancedSearch.Controls.Add(Me.btn_AdvancedSearch)
        Me.gbx_AdvancedSearch.Controls.Add(Me.btn_AdvancedCancel)
        Me.gbx_AdvancedSearch.Controls.Add(Me.txt_EmailSearch)
        Me.gbx_AdvancedSearch.Controls.Add(Me.lbl_EmailSearch)
        Me.gbx_AdvancedSearch.Controls.Add(Me.txt_NameSearch)
        Me.gbx_AdvancedSearch.Controls.Add(Me.lbl_NameSearch)
        Me.gbx_AdvancedSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.gbx_AdvancedSearch.Location = New System.Drawing.Point(968, 63)
        Me.gbx_AdvancedSearch.Name = "gbx_AdvancedSearch"
        Me.gbx_AdvancedSearch.Size = New System.Drawing.Size(386, 243)
        Me.gbx_AdvancedSearch.TabIndex = 12
        Me.gbx_AdvancedSearch.TabStop = False
        Me.gbx_AdvancedSearch.Text = "Advanced Search"
        Me.gbx_AdvancedSearch.Visible = False
        '
        'btn_AdvancedSearch
        '
        Me.btn_AdvancedSearch.Location = New System.Drawing.Point(231, 187)
        Me.btn_AdvancedSearch.Name = "btn_AdvancedSearch"
        Me.btn_AdvancedSearch.Size = New System.Drawing.Size(95, 35)
        Me.btn_AdvancedSearch.TabIndex = 13
        Me.btn_AdvancedSearch.Text = "Search"
        Me.btn_AdvancedSearch.UseVisualStyleBackColor = True
        '
        'btn_AdvancedCancel
        '
        Me.btn_AdvancedCancel.Location = New System.Drawing.Point(74, 187)
        Me.btn_AdvancedCancel.Name = "btn_AdvancedCancel"
        Me.btn_AdvancedCancel.Size = New System.Drawing.Size(99, 35)
        Me.btn_AdvancedCancel.TabIndex = 12
        Me.btn_AdvancedCancel.Text = "Cancel"
        Me.btn_AdvancedCancel.UseVisualStyleBackColor = True
        '
        'btn_Advanced
        '
        Me.btn_Advanced.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Advanced.Location = New System.Drawing.Point(1199, 151)
        Me.btn_Advanced.Name = "btn_Advanced"
        Me.btn_Advanced.Size = New System.Drawing.Size(132, 33)
        Me.btn_Advanced.TabIndex = 6
        Me.btn_Advanced.Text = "Advanced"
        Me.btn_Advanced.UseVisualStyleBackColor = True
        Me.btn_Advanced.Visible = False
        '
        'cbx_Column
        '
        Me.cbx_Column.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.cbx_Column.FormattingEnabled = True
        Me.cbx_Column.Items.AddRange(New Object() {"Name", "Email Address"})
        Me.cbx_Column.Location = New System.Drawing.Point(730, 12)
        Me.cbx_Column.Name = "cbx_Column"
        Me.cbx_Column.Size = New System.Drawing.Size(192, 33)
        Me.cbx_Column.TabIndex = 7
        '
        'txt_NameSearch
        '
        Me.txt_NameSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txt_NameSearch.Location = New System.Drawing.Point(24, 60)
        Me.txt_NameSearch.Name = "txt_NameSearch"
        Me.txt_NameSearch.Size = New System.Drawing.Size(356, 31)
        Me.txt_NameSearch.TabIndex = 8
        '
        'txt_EmailSearch
        '
        Me.txt_EmailSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txt_EmailSearch.Location = New System.Drawing.Point(24, 140)
        Me.txt_EmailSearch.Name = "txt_EmailSearch"
        Me.txt_EmailSearch.Size = New System.Drawing.Size(356, 31)
        Me.txt_EmailSearch.TabIndex = 9
        '
        'lbl_NameSearch
        '
        Me.lbl_NameSearch.AutoSize = True
        Me.lbl_NameSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_NameSearch.Location = New System.Drawing.Point(19, 32)
        Me.lbl_NameSearch.Name = "lbl_NameSearch"
        Me.lbl_NameSearch.Size = New System.Drawing.Size(79, 25)
        Me.lbl_NameSearch.TabIndex = 10
        Me.lbl_NameSearch.Text = "Name:"
        '
        'lbl_EmailSearch
        '
        Me.lbl_EmailSearch.AutoSize = True
        Me.lbl_EmailSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_EmailSearch.Location = New System.Drawing.Point(19, 112)
        Me.lbl_EmailSearch.Name = "lbl_EmailSearch"
        Me.lbl_EmailSearch.Size = New System.Drawing.Size(170, 25)
        Me.lbl_EmailSearch.TabIndex = 11
        Me.lbl_EmailSearch.Text = "Email Address:"
        '
        'gbx_AdvancedSearch
        '
        Me.gbx_AdvancedSearch.BackColor = System.Drawing.Color.Gray
        Me.gbx_AdvancedSearch.Controls.Add(Me.btn_AdvancedSearch)
        Me.gbx_AdvancedSearch.Controls.Add(Me.btn_AdvancedCancel)
        Me.gbx_AdvancedSearch.Controls.Add(Me.txt_EmailSearch)
        Me.gbx_AdvancedSearch.Controls.Add(Me.lbl_EmailSearch)
        Me.gbx_AdvancedSearch.Controls.Add(Me.txt_NameSearch)
        Me.gbx_AdvancedSearch.Controls.Add(Me.lbl_NameSearch)
        Me.gbx_AdvancedSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.gbx_AdvancedSearch.Location = New System.Drawing.Point(968, 63)
        Me.gbx_AdvancedSearch.Name = "gbx_AdvancedSearch"
        Me.gbx_AdvancedSearch.Size = New System.Drawing.Size(386, 243)
        Me.gbx_AdvancedSearch.TabIndex = 12
        Me.gbx_AdvancedSearch.TabStop = False
        Me.gbx_AdvancedSearch.Text = "Advanced Search"
        Me.gbx_AdvancedSearch.Visible = False
        '
        'btn_AdvancedSearch
        '
        Me.btn_AdvancedSearch.Location = New System.Drawing.Point(231, 187)
        Me.btn_AdvancedSearch.Name = "btn_AdvancedSearch"
        Me.btn_AdvancedSearch.Size = New System.Drawing.Size(95, 35)
        Me.btn_AdvancedSearch.TabIndex = 13
        Me.btn_AdvancedSearch.Text = "Search"
        Me.btn_AdvancedSearch.UseVisualStyleBackColor = True
        '
        'btn_AdvancedCancel
        '
        Me.btn_AdvancedCancel.Location = New System.Drawing.Point(74, 187)
        Me.btn_AdvancedCancel.Name = "btn_AdvancedCancel"
        Me.btn_AdvancedCancel.Size = New System.Drawing.Size(99, 35)
        Me.btn_AdvancedCancel.TabIndex = 12
        Me.btn_AdvancedCancel.Text = "Cancel"
        Me.btn_AdvancedCancel.UseVisualStyleBackColor = True
        '
        'frm_ViewListeners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Media_Ministry.My.Resources.Resources.Media_Ministry_Manage_Image
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(998, 450)
        Me.Controls.Add(Me.cbx_Column)
        Me.Controls.Add(Me.btn_Advanced)
        Me.Controls.Add(Me.txt_SearchBox)
        Me.Controls.Add(Me.lbl_SearchLabel)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.dgv_Listeners)
        Me.Controls.Add(Me.gbx_AdvancedSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_ViewListeners"
        Me.Text = "Media Ministry Manager"
        CType(Me.dgv_Listeners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_AdvancedSearch.ResumeLayout(False)
        Me.gbx_AdvancedSearch.PerformLayout()
        CType(Me.EMAILLISTENERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Media_MinistryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_AdvancedSearch.ResumeLayout(False)
        Me.gbx_AdvancedSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Add As Button
    Friend WithEvents dgv_Listeners As DataGridView
    Friend WithEvents Media_MinistryDataSet As Media_MinistryDataSet
    Friend WithEvents EMAILLISTENERSBindingSource As BindingSource
    Friend WithEvents EMAIL_LISTENERSTableAdapter As Media_MinistryDataSetTableAdapters.EMAIL_LISTENERSTableAdapter
    Friend WithEvents NAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lbl_Total As Label
    Friend WithEvents btn_Search As Button
    Friend WithEvents lbl_SearchLabel As Label
    Friend WithEvents txt_SearchBox As TextBox
    Friend WithEvents btn_Advanced As Button
    Friend WithEvents cbx_Column As ComboBox
    Friend WithEvents txt_NameSearch As TextBox
    Friend WithEvents txt_EmailSearch As TextBox
    Friend WithEvents lbl_NameSearch As Label
    Friend WithEvents lbl_EmailSearch As Label
    Friend WithEvents gbx_AdvancedSearch As GroupBox
    Friend WithEvents btn_AdvancedSearch As Button
    Friend WithEvents btn_AdvancedCancel As Button
End Class
