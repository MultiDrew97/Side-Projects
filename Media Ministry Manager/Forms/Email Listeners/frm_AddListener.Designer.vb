<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AddListener
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AddListener))
        Me.gbx_Options = New System.Windows.Forms.GroupBox()
        Me.rdo_Single = New System.Windows.Forms.RadioButton()
        Me.rdo_Multiple = New System.Windows.Forms.RadioButton()
        Me.ofd_ListenerList = New System.Windows.Forms.OpenFileDialog()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.lbl_FilePath = New System.Windows.Forms.Label()
        Me.txt_FilePath = New System.Windows.Forms.TextBox()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gbx_Options.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Options
        '
        Me.gbx_Options.Controls.Add(Me.rdo_Single)
        Me.gbx_Options.Controls.Add(Me.rdo_Multiple)
        Me.gbx_Options.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.gbx_Options.Location = New System.Drawing.Point(22, 43)
        Me.gbx_Options.Name = "gbx_Options"
        Me.gbx_Options.Size = New System.Drawing.Size(244, 147)
        Me.gbx_Options.TabIndex = 0
        Me.gbx_Options.TabStop = False
        Me.gbx_Options.Text = "Options"
        '
        'rdo_Single
        '
        Me.rdo_Single.AutoSize = True
        Me.rdo_Single.Checked = True
        Me.rdo_Single.Location = New System.Drawing.Point(28, 37)
        Me.rdo_Single.Name = "rdo_Single"
        Me.rdo_Single.Size = New System.Drawing.Size(156, 30)
        Me.rdo_Single.TabIndex = 1
        Me.rdo_Single.TabStop = True
        Me.rdo_Single.Text = "One Person"
        Me.rdo_Single.UseVisualStyleBackColor = True
        '
        'rdo_Multiple
        '
        Me.rdo_Multiple.AutoSize = True
        Me.rdo_Multiple.Location = New System.Drawing.Point(28, 88)
        Me.rdo_Multiple.Name = "rdo_Multiple"
        Me.rdo_Multiple.Size = New System.Drawing.Size(194, 30)
        Me.rdo_Multiple.TabIndex = 2
        Me.rdo_Multiple.Text = "Multiple People"
        Me.rdo_Multiple.UseVisualStyleBackColor = True
        '
        'ofd_ListenerList
        '
        Me.ofd_ListenerList.Filter = "List (*.csv)|*.csv"
        Me.ofd_ListenerList.Title = "List of Listeners (.csv)"
        '
        'txt_Name
        '
        Me.txt_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Name.Location = New System.Drawing.Point(371, 81)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(449, 32)
        Me.txt_Name.TabIndex = 1
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Email.Location = New System.Drawing.Point(371, 129)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(449, 32)
        Me.txt_Email.TabIndex = 2
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Name.Location = New System.Drawing.Point(282, 81)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(82, 26)
        Me.lbl_Name.TabIndex = 3
        Me.lbl_Name.Text = "Name:"
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Email.Location = New System.Drawing.Point(282, 129)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(80, 26)
        Me.lbl_Email.TabIndex = 4
        Me.lbl_Email.Text = "Email:"
        '
        'lbl_FilePath
        '
        Me.lbl_FilePath.AutoSize = True
        Me.lbl_FilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_FilePath.Location = New System.Drawing.Point(276, 114)
        Me.lbl_FilePath.Name = "lbl_FilePath"
        Me.lbl_FilePath.Size = New System.Drawing.Size(114, 26)
        Me.lbl_FilePath.TabIndex = 5
        Me.lbl_FilePath.Text = "File Path:"
        '
        'txt_FilePath
        '
        Me.txt_FilePath.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_FilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txt_FilePath.Location = New System.Drawing.Point(396, 110)
        Me.txt_FilePath.Name = "txt_FilePath"
        Me.txt_FilePath.ReadOnly = True
        Me.txt_FilePath.Size = New System.Drawing.Size(417, 32)
        Me.txt_FilePath.TabIndex = 6
        '
        'btn_Add
        '
        Me.btn_Add.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Add.Location = New System.Drawing.Point(503, 223)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(187, 53)
        Me.btn_Add.TabIndex = 7
        Me.btn_Add.Text = "Add Listener"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Cancel.Location = New System.Drawing.Point(233, 223)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(187, 53)
        Me.btn_Cancel.TabIndex = 8
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Search
        '
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Search.Location = New System.Drawing.Point(819, 110)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(43, 32)
        Me.btn_Search.TabIndex = 9
        Me.btn_Search.Text = "..."
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 312)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(880, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tss_Feedback
        '
        Me.tss_Feedback.Name = "tss_Feedback"
        Me.tss_Feedback.Size = New System.Drawing.Size(242, 17)
        Me.tss_Feedback.Text = "Enter the name and email of the new listener"
        '
        'frm_AddListener
        '
        Me.AcceptButton = Me.btn_Add
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(880, 334)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.txt_FilePath)
        Me.Controls.Add(Me.lbl_FilePath)
        Me.Controls.Add(Me.lbl_Email)
        Me.Controls.Add(Me.lbl_Name)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.gbx_Options)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_AddListener"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.gbx_Options.ResumeLayout(False)
        Me.gbx_Options.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbx_Options As GroupBox
    Friend WithEvents rdo_Multiple As RadioButton
    Friend WithEvents rdo_Single As RadioButton
    Friend WithEvents ofd_ListenerList As OpenFileDialog
    Friend WithEvents txt_Name As TextBox
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents lbl_Name As Label
    Friend WithEvents lbl_Email As Label
    Friend WithEvents lbl_FilePath As Label
    Friend WithEvents txt_FilePath As TextBox
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Search As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tss_Feedback As ToolStripStatusLabel
End Class
