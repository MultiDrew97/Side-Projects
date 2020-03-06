<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EmailListeners
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
        Me.btn_Upload = New System.Windows.Forms.Button()
        Me.ofd_SelectAudio = New System.Windows.Forms.OpenFileDialog()
        Me.cbx_Folders = New System.Windows.Forms.ComboBox()
        Me.lbl_Folder = New System.Windows.Forms.Label()
        Me.lbl_FileLocation = New System.Windows.Forms.Label()
        Me.txt_FileLocation = New System.Windows.Forms.TextBox()
        Me.btn_Browse = New System.Windows.Forms.Button()
        Me.bw_Upload = New System.ComponentModel.BackgroundWorker()
        Me.btn_AddFolder = New System.Windows.Forms.Button()
        Me.ss_Feedback = New System.Windows.Forms.StatusStrip()
        Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ss_Feedback.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Upload
        '
        Me.btn_Upload.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Upload.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Upload.Location = New System.Drawing.Point(146, 144)
        Me.btn_Upload.Name = "btn_Upload"
        Me.btn_Upload.Size = New System.Drawing.Size(238, 36)
        Me.btn_Upload.TabIndex = 0
        Me.btn_Upload.Text = "Upload to Drive"
        Me.btn_Upload.UseVisualStyleBackColor = True
        '
        'ofd_SelectAudio
        '
        Me.ofd_SelectAudio.Multiselect = True
        Me.ofd_SelectAudio.Title = "Choose the file for sending"
        '
        'cbx_Folders
        '
        Me.cbx_Folders.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_Folders.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbx_Folders.FormattingEnabled = True
        Me.cbx_Folders.Location = New System.Drawing.Point(103, 32)
        Me.cbx_Folders.Name = "cbx_Folders"
        Me.cbx_Folders.Size = New System.Drawing.Size(367, 33)
        Me.cbx_Folders.TabIndex = 1
        '
        'lbl_Folder
        '
        Me.lbl_Folder.AutoSize = True
        Me.lbl_Folder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Folder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Folder.Location = New System.Drawing.Point(7, 32)
        Me.lbl_Folder.Name = "lbl_Folder"
        Me.lbl_Folder.Size = New System.Drawing.Size(79, 26)
        Me.lbl_Folder.TabIndex = 2
        Me.lbl_Folder.Text = "Folder"
        '
        'lbl_FileLocation
        '
        Me.lbl_FileLocation.AutoSize = True
        Me.lbl_FileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FileLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_FileLocation.Location = New System.Drawing.Point(28, 91)
        Me.lbl_FileLocation.Name = "lbl_FileLocation"
        Me.lbl_FileLocation.Size = New System.Drawing.Size(58, 26)
        Me.lbl_FileLocation.TabIndex = 3
        Me.lbl_FileLocation.Text = "File:"
        '
        'txt_FileLocation
        '
        Me.txt_FileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FileLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_FileLocation.Location = New System.Drawing.Point(103, 91)
        Me.txt_FileLocation.Name = "txt_FileLocation"
        Me.txt_FileLocation.Size = New System.Drawing.Size(367, 32)
        Me.txt_FileLocation.TabIndex = 4
        '
        'btn_Browse
        '
        Me.btn_Browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Browse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Browse.Location = New System.Drawing.Point(476, 91)
        Me.btn_Browse.Name = "btn_Browse"
        Me.btn_Browse.Size = New System.Drawing.Size(44, 31)
        Me.btn_Browse.TabIndex = 5
        Me.btn_Browse.Text = "..."
        Me.btn_Browse.UseVisualStyleBackColor = True
        '
        'bw_Upload
        '
        '
        'btn_AddFolder
        '
        Me.btn_AddFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_AddFolder.Location = New System.Drawing.Point(476, 34)
        Me.btn_AddFolder.Name = "btn_AddFolder"
        Me.btn_AddFolder.Size = New System.Drawing.Size(44, 31)
        Me.btn_AddFolder.TabIndex = 6
        Me.btn_AddFolder.Text = "+"
        Me.btn_AddFolder.UseVisualStyleBackColor = True
        '
        'ss_Feedback
        '
        Me.ss_Feedback.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback})
        Me.ss_Feedback.Location = New System.Drawing.Point(0, 190)
        Me.ss_Feedback.Name = "ss_Feedback"
        Me.ss_Feedback.Size = New System.Drawing.Size(532, 22)
        Me.ss_Feedback.TabIndex = 7
        Me.ss_Feedback.Text = "ss_Feedback"
        '
        'tss_Feedback
        '
        Me.tss_Feedback.Name = "tss_Feedback"
        Me.tss_Feedback.Size = New System.Drawing.Size(340, 17)
        Me.tss_Feedback.Text = "Please select the file to be uploaded and the folder to upload to"
        '
        'frm_EmailListeners
        '
        Me.AcceptButton = Me.btn_Upload
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 212)
        Me.Controls.Add(Me.ss_Feedback)
        Me.Controls.Add(Me.btn_AddFolder)
        Me.Controls.Add(Me.btn_Browse)
        Me.Controls.Add(Me.txt_FileLocation)
        Me.Controls.Add(Me.lbl_FileLocation)
        Me.Controls.Add(Me.lbl_Folder)
        Me.Controls.Add(Me.cbx_Folders)
        Me.Controls.Add(Me.btn_Upload)
        Me.MaximizeBox = False
        Me.Name = "frm_EmailListeners"
        Me.Text = "Media Ministry Manager"
        Me.ss_Feedback.ResumeLayout(False)
        Me.ss_Feedback.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Upload As Button
    Friend WithEvents ofd_SelectAudio As OpenFileDialog
    Friend WithEvents cbx_Folders As ComboBox
    Friend WithEvents lbl_Folder As Label
    Friend WithEvents lbl_FileLocation As Label
    Friend WithEvents txt_FileLocation As TextBox
    Friend WithEvents btn_Browse As Button
    Friend WithEvents bw_Upload As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_AddFolder As Button
    Friend WithEvents ss_Feedback As StatusStrip
    Friend WithEvents tss_Feedback As ToolStripStatusLabel
End Class
