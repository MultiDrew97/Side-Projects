<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SendEmailsDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SendEmailsDialog))
        Me.ss_Feedback = New System.Windows.Forms.StatusStrip()
        Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsp_Progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.btn_AddFolder = New System.Windows.Forms.Button()
        Me.btn_UploadFile = New System.Windows.Forms.Button()
        Me.bw_LoadListeners = New System.ComponentModel.BackgroundWorker()
        Me.bw_SendEmails = New System.ComponentModel.BackgroundWorker()
        Me.bw_GetFileID = New System.ComponentModel.BackgroundWorker()
        Me.tcl_EmailOptions = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_SendEmails = New System.Windows.Forms.Button()
        Me.chk_DefaultMessage = New System.Windows.Forms.CheckBox()
        Me.cbx_Files = New System.Windows.Forms.ComboBox()
        Me.cbx_Folders = New System.Windows.Forms.ComboBox()
        Me.lbl_Folder = New System.Windows.Forms.Label()
        Me.lbl_FileLocation = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FileLocationField1 = New MediaMinistry.FileLocationField()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ss_Feedback.SuspendLayout()
        Me.tcl_EmailOptions.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
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
        'btn_AddFolder
        '
        Me.btn_AddFolder.AutoSize = True
        Me.btn_AddFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_AddFolder.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btn_AddFolder.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.btn_AddFolder.Location = New System.Drawing.Point(28, 81)
        Me.btn_AddFolder.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_AddFolder.MaximumSize = New System.Drawing.Size(154, 80)
        Me.btn_AddFolder.MinimumSize = New System.Drawing.Size(154, 80)
        Me.btn_AddFolder.Name = "btn_AddFolder"
        Me.btn_AddFolder.Size = New System.Drawing.Size(154, 80)
        Me.btn_AddFolder.TabIndex = 12
        Me.btn_AddFolder.Text = "Create New Folder"
        Me.btn_AddFolder.UseVisualStyleBackColor = True
        '
        'btn_UploadFile
        '
        Me.btn_UploadFile.AutoSize = True
        Me.btn_UploadFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_UploadFile.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btn_UploadFile.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.btn_UploadFile.Location = New System.Drawing.Point(28, 241)
        Me.btn_UploadFile.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_UploadFile.MaximumSize = New System.Drawing.Size(154, 80)
        Me.btn_UploadFile.MinimumSize = New System.Drawing.Size(154, 80)
        Me.btn_UploadFile.Name = "btn_UploadFile"
        Me.btn_UploadFile.Size = New System.Drawing.Size(154, 80)
        Me.btn_UploadFile.TabIndex = 16
        Me.btn_UploadFile.Text = "Upload New File"
        Me.btn_UploadFile.UseVisualStyleBackColor = True
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
        'tcl_EmailOptions
        '
        Me.tcl_EmailOptions.Controls.Add(Me.TabPage1)
        Me.tcl_EmailOptions.Controls.Add(Me.TabPage2)
        Me.tcl_EmailOptions.Dock = System.Windows.Forms.DockStyle.Right
        Me.tcl_EmailOptions.Location = New System.Drawing.Point(217, 0)
        Me.tcl_EmailOptions.Name = "tcl_EmailOptions"
        Me.tcl_EmailOptions.SelectedIndex = 0
        Me.tcl_EmailOptions.Size = New System.Drawing.Size(629, 382)
        Me.tcl_EmailOptions.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_SendEmails)
        Me.TabPage1.Controls.Add(Me.chk_DefaultMessage)
        Me.TabPage1.Controls.Add(Me.cbx_Files)
        Me.TabPage1.Controls.Add(Me.cbx_Folders)
        Me.TabPage1.Controls.Add(Me.lbl_Folder)
        Me.TabPage1.Controls.Add(Me.lbl_FileLocation)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(621, 344)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_SendEmails
        '
        Me.btn_SendEmails.AutoSize = True
        Me.btn_SendEmails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_SendEmails.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btn_SendEmails.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.btn_SendEmails.Location = New System.Drawing.Point(221, 291)
        Me.btn_SendEmails.Name = "btn_SendEmails"
        Me.btn_SendEmails.Size = New System.Drawing.Size(178, 35)
        Me.btn_SendEmails.TabIndex = 23
        Me.btn_SendEmails.Text = "Send Message"
        Me.btn_SendEmails.UseVisualStyleBackColor = True
        '
        'chk_DefaultMessage
        '
        Me.chk_DefaultMessage.AutoSize = True
        Me.chk_DefaultMessage.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chk_DefaultMessage.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.chk_DefaultMessage.Location = New System.Drawing.Point(188, 210)
        Me.chk_DefaultMessage.Margin = New System.Windows.Forms.Padding(6)
        Me.chk_DefaultMessage.Name = "chk_DefaultMessage"
        Me.chk_DefaultMessage.Size = New System.Drawing.Size(256, 29)
        Me.chk_DefaultMessage.TabIndex = 22
        Me.chk_DefaultMessage.Text = "Use Default Message"
        Me.chk_DefaultMessage.UseVisualStyleBackColor = True
        '
        'cbx_Files
        '
        Me.cbx_Files.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbx_Files.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.cbx_Files.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbx_Files.FormattingEnabled = True
        Me.cbx_Files.Location = New System.Drawing.Point(75, 147)
        Me.cbx_Files.Margin = New System.Windows.Forms.Padding(6)
        Me.cbx_Files.Name = "cbx_Files"
        Me.cbx_Files.Size = New System.Drawing.Size(480, 33)
        Me.cbx_Files.TabIndex = 21
        '
        'cbx_Folders
        '
        Me.cbx_Folders.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbx_Folders.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.cbx_Folders.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbx_Folders.FormattingEnabled = True
        Me.cbx_Folders.Location = New System.Drawing.Point(75, 48)
        Me.cbx_Folders.Margin = New System.Windows.Forms.Padding(6)
        Me.cbx_Folders.Name = "cbx_Folders"
        Me.cbx_Folders.Size = New System.Drawing.Size(480, 33)
        Me.cbx_Folders.TabIndex = 18
        '
        'lbl_Folder
        '
        Me.lbl_Folder.AutoSize = True
        Me.lbl_Folder.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lbl_Folder.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.lbl_Folder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Folder.Location = New System.Drawing.Point(65, 18)
        Me.lbl_Folder.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_Folder.Name = "lbl_Folder"
        Me.lbl_Folder.Size = New System.Drawing.Size(79, 25)
        Me.lbl_Folder.TabIndex = 19
        Me.lbl_Folder.Text = "Folder"
        '
        'lbl_FileLocation
        '
        Me.lbl_FileLocation.AutoSize = True
        Me.lbl_FileLocation.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lbl_FileLocation.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.lbl_FileLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_FileLocation.Location = New System.Drawing.Point(65, 116)
        Me.lbl_FileLocation.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_FileLocation.Name = "lbl_FileLocation"
        Me.lbl_FileLocation.Size = New System.Drawing.Size(58, 25)
        Me.lbl_FileLocation.TabIndex = 20
        Me.lbl_FileLocation.Text = "File:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.FileLocationField1)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.CheckBox1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(621, 344)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FileLocationField1
        '
        Me.FileLocationField1.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FileLocationField1.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.FileLocationField1.Location = New System.Drawing.Point(46, 88)
        Me.FileLocationField1.Name = "FileLocationField1"
        Me.FileLocationField1.Size = New System.Drawing.Size(560, 33)
        Me.FileLocationField1.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button1.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.Button1.Location = New System.Drawing.Point(224, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 35)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Send Message"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.CheckBox1.Location = New System.Drawing.Point(191, 159)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(256, 29)
        Me.CheckBox1.TabIndex = 22
        Me.CheckBox1.Text = "Use Default Message"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label2.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(41, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "File:"
        '
        'SendEmailsDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 404)
        Me.Controls.Add(Me.tcl_EmailOptions)
        Me.Controls.Add(Me.btn_UploadFile)
        Me.Controls.Add(Me.ss_Feedback)
        Me.Controls.Add(Me.btn_AddFolder)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "SendEmailsDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "emails"
        Me.Text = "Media Ministry Manager"
        Me.ss_Feedback.ResumeLayout(False)
        Me.ss_Feedback.PerformLayout()
        Me.tcl_EmailOptions.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ss_Feedback As StatusStrip
    Friend WithEvents tss_Feedback As ToolStripStatusLabel
    Friend WithEvents btn_AddFolder As Button
    Friend WithEvents btn_UploadFile As Button
    Friend WithEvents bw_LoadListeners As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_SendEmails As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_GetFileID As System.ComponentModel.BackgroundWorker
    Friend WithEvents tsp_Progress As ToolStripProgressBar
    Friend WithEvents tcl_EmailOptions As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_SendEmails As Button
    Friend WithEvents chk_DefaultMessage As CheckBox
    Friend WithEvents cbx_Files As ComboBox
    Friend WithEvents cbx_Folders As ComboBox
    Friend WithEvents lbl_Folder As Label
    Friend WithEvents lbl_FileLocation As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FileLocationField1 As FileLocationField
End Class
