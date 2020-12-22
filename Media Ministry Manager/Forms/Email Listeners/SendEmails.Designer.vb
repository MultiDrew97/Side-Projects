<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_SendEmails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SendEmails))
        Me.btn_AddFolder = New System.Windows.Forms.Button()
        Me.btn_Browse = New System.Windows.Forms.Button()
        Me.txt_FileLocation = New System.Windows.Forms.TextBox()
        Me.lbl_FileLocation = New System.Windows.Forms.Label()
        Me.lbl_Folder = New System.Windows.Forms.Label()
        Me.cbx_Folders = New System.Windows.Forms.ComboBox()
        Me.bw_Upload = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_AddFolder
        '
        Me.btn_AddFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_AddFolder.Location = New System.Drawing.Point(576, 46)
        Me.btn_AddFolder.Name = "btn_AddFolder"
        Me.btn_AddFolder.Size = New System.Drawing.Size(44, 31)
        Me.btn_AddFolder.TabIndex = 12
        Me.btn_AddFolder.Text = "+"
        Me.btn_AddFolder.UseVisualStyleBackColor = True
        '
        'btn_Browse
        '
        Me.btn_Browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Browse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Browse.Location = New System.Drawing.Point(576, 118)
        Me.btn_Browse.Name = "btn_Browse"
        Me.btn_Browse.Size = New System.Drawing.Size(44, 31)
        Me.btn_Browse.TabIndex = 11
        Me.btn_Browse.Text = "..."
        Me.btn_Browse.UseVisualStyleBackColor = True
        '
        'txt_FileLocation
        '
        Me.txt_FileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FileLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_FileLocation.Location = New System.Drawing.Point(203, 118)
        Me.txt_FileLocation.Name = "txt_FileLocation"
        Me.txt_FileLocation.ReadOnly = True
        Me.txt_FileLocation.Size = New System.Drawing.Size(367, 32)
        Me.txt_FileLocation.TabIndex = 10
        '
        'lbl_FileLocation
        '
        Me.lbl_FileLocation.AutoSize = True
        Me.lbl_FileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FileLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_FileLocation.Location = New System.Drawing.Point(128, 118)
        Me.lbl_FileLocation.Name = "lbl_FileLocation"
        Me.lbl_FileLocation.Size = New System.Drawing.Size(58, 26)
        Me.lbl_FileLocation.TabIndex = 9
        Me.lbl_FileLocation.Text = "File:"
        '
        'lbl_Folder
        '
        Me.lbl_Folder.AutoSize = True
        Me.lbl_Folder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Folder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Folder.Location = New System.Drawing.Point(107, 44)
        Me.lbl_Folder.Name = "lbl_Folder"
        Me.lbl_Folder.Size = New System.Drawing.Size(79, 26)
        Me.lbl_Folder.TabIndex = 8
        Me.lbl_Folder.Text = "Folder"
        '
        'cbx_Folders
        '
        Me.cbx_Folders.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_Folders.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbx_Folders.FormattingEnabled = True
        Me.cbx_Folders.Location = New System.Drawing.Point(203, 44)
        Me.cbx_Folders.Name = "cbx_Folders"
        Me.cbx_Folders.Size = New System.Drawing.Size(367, 33)
        Me.cbx_Folders.TabIndex = 7
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tss_Feedback
        '
        Me.tss_Feedback.Name = "tss_Feedback"
        Me.tss_Feedback.Size = New System.Drawing.Size(36, 17)
        Me.tss_Feedback.Text = "Temp"
        '
        'frm_SendEmails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_AddFolder)
        Me.Controls.Add(Me.btn_Browse)
        Me.Controls.Add(Me.txt_FileLocation)
        Me.Controls.Add(Me.lbl_FileLocation)
        Me.Controls.Add(Me.lbl_Folder)
        Me.Controls.Add(Me.cbx_Folders)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_SendEmails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "emails"
        Me.Text = "Media Ministry Manager"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_AddFolder As Button
    Friend WithEvents btn_Browse As Button
    Friend WithEvents txt_FileLocation As TextBox
    Friend WithEvents lbl_FileLocation As Label
    Friend WithEvents lbl_Folder As Label
    Friend WithEvents cbx_Folders As ComboBox
    Friend WithEvents bw_Upload As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tss_Feedback As ToolStripStatusLabel
End Class
