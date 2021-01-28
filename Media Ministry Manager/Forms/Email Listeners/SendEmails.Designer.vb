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
        Me.lbl_FileLocation = New System.Windows.Forms.Label()
        Me.lbl_Folder = New System.Windows.Forms.Label()
        Me.cbx_Folders = New System.Windows.Forms.ComboBox()
        Me.ss_Feedback = New System.Windows.Forms.StatusStrip()
        Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsp_Progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.cbx_Files = New System.Windows.Forms.ComboBox()
        Me.btn_AddFolder = New System.Windows.Forms.Button()
        Me.btn_UploadFile = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_SendEmails = New System.Windows.Forms.Button()
        Me.chk_DefaultMessage = New System.Windows.Forms.CheckBox()
        Me.bw_LoadListeners = New System.ComponentModel.BackgroundWorker()
        Me.bw_SendEmails = New System.ComponentModel.BackgroundWorker()
        Me.bw_GetFileID = New System.ComponentModel.BackgroundWorker()
        Me.ss_Feedback.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_FileLocation
        '
        Me.lbl_FileLocation.AutoSize = True
        Me.lbl_FileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FileLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_FileLocation.Location = New System.Drawing.Point(58, 132)
        Me.lbl_FileLocation.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
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
        Me.lbl_Folder.Location = New System.Drawing.Point(58, 34)
        Me.lbl_Folder.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
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
        Me.cbx_Folders.Location = New System.Drawing.Point(68, 64)
        Me.cbx_Folders.Margin = New System.Windows.Forms.Padding(6)
        Me.cbx_Folders.Name = "cbx_Folders"
        Me.cbx_Folders.Size = New System.Drawing.Size(480, 33)
        Me.cbx_Folders.TabIndex = 7
        '
        'ss_Feedback
        '
        Me.ss_Feedback.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback, Me.tsp_Progress})
        Me.ss_Feedback.Location = New System.Drawing.Point(0, 382)
        Me.ss_Feedback.Name = "ss_Feedback"
        Me.ss_Feedback.Padding = New System.Windows.Forms.Padding(2, 0, 28, 0)
        Me.ss_Feedback.Size = New System.Drawing.Size(846, 22)
        Me.ss_Feedback.TabIndex = 14
        Me.ss_Feedback.Text = "StatusStrip1"
        '
        'tss_Feedback
        '
        Me.tss_Feedback.Name = "tss_Feedback"
        Me.tss_Feedback.Size = New System.Drawing.Size(104, 17)
        Me.tss_Feedback.Text = "Please select a file."
        '
        'tsp_Progress
        '
        Me.tsp_Progress.Margin = New System.Windows.Forms.Padding(650, 3, 1, 3)
        Me.tsp_Progress.Name = "tsp_Progress"
        Me.tsp_Progress.Size = New System.Drawing.Size(100, 16)
        Me.tsp_Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'cbx_Files
        '
        Me.cbx_Files.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_Files.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbx_Files.FormattingEnabled = True
        Me.cbx_Files.Location = New System.Drawing.Point(68, 163)
        Me.cbx_Files.Margin = New System.Windows.Forms.Padding(6)
        Me.cbx_Files.Name = "cbx_Files"
        Me.cbx_Files.Size = New System.Drawing.Size(480, 33)
        Me.cbx_Files.TabIndex = 15
        '
        'btn_AddFolder
        '
        Me.btn_AddFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_AddFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_AddFolder.Location = New System.Drawing.Point(54, 82)
        Me.btn_AddFolder.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_AddFolder.Name = "btn_AddFolder"
        Me.btn_AddFolder.Size = New System.Drawing.Size(154, 80)
        Me.btn_AddFolder.TabIndex = 12
        Me.btn_AddFolder.Text = "Create New Folder"
        Me.btn_AddFolder.UseVisualStyleBackColor = True
        '
        'btn_UploadFile
        '
        Me.btn_UploadFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_UploadFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_UploadFile.Location = New System.Drawing.Point(54, 242)
        Me.btn_UploadFile.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_UploadFile.Name = "btn_UploadFile"
        Me.btn_UploadFile.Size = New System.Drawing.Size(154, 80)
        Me.btn_UploadFile.TabIndex = 16
        Me.btn_UploadFile.Text = "Upload New File"
        Me.btn_UploadFile.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_SendEmails)
        Me.Panel1.Controls.Add(Me.chk_DefaultMessage)
        Me.Panel1.Controls.Add(Me.cbx_Files)
        Me.Panel1.Controls.Add(Me.cbx_Folders)
        Me.Panel1.Controls.Add(Me.lbl_Folder)
        Me.Panel1.Controls.Add(Me.lbl_FileLocation)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(240, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 382)
        Me.Panel1.TabIndex = 17
        '
        'btn_SendEmails
        '
        Me.btn_SendEmails.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SendEmails.Location = New System.Drawing.Point(177, 303)
        Me.btn_SendEmails.Name = "btn_SendEmails"
        Me.btn_SendEmails.Size = New System.Drawing.Size(252, 45)
        Me.btn_SendEmails.TabIndex = 17
        Me.btn_SendEmails.Text = "Send Message"
        Me.btn_SendEmails.UseVisualStyleBackColor = True
        '
        'chk_DefaultMessage
        '
        Me.chk_DefaultMessage.AutoSize = True
        Me.chk_DefaultMessage.Location = New System.Drawing.Point(181, 226)
        Me.chk_DefaultMessage.Margin = New System.Windows.Forms.Padding(6)
        Me.chk_DefaultMessage.Name = "chk_DefaultMessage"
        Me.chk_DefaultMessage.Size = New System.Drawing.Size(237, 29)
        Me.chk_DefaultMessage.TabIndex = 16
        Me.chk_DefaultMessage.Text = "Use Default Message"
        Me.chk_DefaultMessage.UseVisualStyleBackColor = True
        '
        'bw_LoadListeners
        '
        '
        'bw_SendEmails
        '
        Me.bw_SendEmails.WorkerReportsProgress = True
        Me.bw_SendEmails.WorkerSupportsCancellation = True
        '
        'bw_GetFileID
        '
        '
        'frm_SendEmails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 404)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_UploadFile)
        Me.Controls.Add(Me.ss_Feedback)
        Me.Controls.Add(Me.btn_AddFolder)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "frm_SendEmails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "emails"
        Me.Text = "Media Ministry Manager"
        Me.ss_Feedback.ResumeLayout(False)
        Me.ss_Feedback.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_FileLocation As Label
    Friend WithEvents lbl_Folder As Label
    Friend WithEvents cbx_Folders As ComboBox
    Friend WithEvents ss_Feedback As StatusStrip
    Friend WithEvents tss_Feedback As ToolStripStatusLabel
    Friend WithEvents cbx_Files As ComboBox
    Friend WithEvents btn_AddFolder As Button
    Friend WithEvents btn_UploadFile As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chk_DefaultMessage As CheckBox
    Friend WithEvents btn_SendEmails As Button
    Friend WithEvents bw_LoadListeners As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_SendEmails As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_GetFileID As System.ComponentModel.BackgroundWorker
    Friend WithEvents tsp_Progress As ToolStripProgressBar
End Class
