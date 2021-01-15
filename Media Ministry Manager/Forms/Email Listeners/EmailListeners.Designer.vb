<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EmailListeners
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_EmailListeners))
        Me.ofd_SelectAudio = New System.Windows.Forms.OpenFileDialog()
        Me.cbx_Folders = New System.Windows.Forms.ComboBox()
        Me.FoldersSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_Folder = New System.Windows.Forms.Label()
        Me.lbl_FileLocation = New System.Windows.Forms.Label()
        Me.txt_FileLocation = New System.Windows.Forms.TextBox()
        Me.btn_Browse = New System.Windows.Forms.Button()
        Me.bw_Upload = New System.ComponentModel.BackgroundWorker()
        Me.btn_AddFolder = New System.Windows.Forms.Button()
        Me.ss_Feedback = New System.Windows.Forms.StatusStrip()
        Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_SendEmails = New System.Windows.Forms.Button()
        Me.btn_ViewListeners = New System.Windows.Forms.Button()
        Me.bw_SendEmails = New System.ComponentModel.BackgroundWorker()
        Me.rdo_GoingLive = New System.Windows.Forms.RadioButton()
        Me.rdo_EmailMinistry = New System.Windows.Forms.RadioButton()
        Me.cbx_Files = New System.Windows.Forms.ComboBox()
        Me.FilesSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bw_GetFolders = New System.ComponentModel.BackgroundWorker()
        CType(Me.FoldersSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ss_Feedback.SuspendLayout()
        CType(Me.FilesSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofd_SelectAudio
        '
        Me.ofd_SelectAudio.Multiselect = True
        Me.ofd_SelectAudio.Title = "Email Ministry"
        '
        'cbx_Folders
        '
        Me.cbx_Folders.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_Folders.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbx_Folders.FormattingEnabled = True
        Me.cbx_Folders.Location = New System.Drawing.Point(388, 51)
        Me.cbx_Folders.Name = "cbx_Folders"
        Me.cbx_Folders.Size = New System.Drawing.Size(367, 33)
        Me.cbx_Folders.TabIndex = 1
        '
        'lbl_Folder
        '
        Me.lbl_Folder.AutoSize = True
        Me.lbl_Folder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Folder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Folder.Location = New System.Drawing.Point(292, 51)
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
        Me.lbl_FileLocation.Location = New System.Drawing.Point(313, 110)
        Me.lbl_FileLocation.Name = "lbl_FileLocation"
        Me.lbl_FileLocation.Size = New System.Drawing.Size(58, 26)
        Me.lbl_FileLocation.TabIndex = 3
        Me.lbl_FileLocation.Text = "File:"
        '
        'txt_FileLocation
        '
        Me.txt_FileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FileLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_FileLocation.Location = New System.Drawing.Point(388, 110)
        Me.txt_FileLocation.Name = "txt_FileLocation"
        Me.txt_FileLocation.ReadOnly = True
        Me.txt_FileLocation.Size = New System.Drawing.Size(367, 32)
        Me.txt_FileLocation.TabIndex = 4
        Me.txt_FileLocation.Visible = False
        '
        'btn_Browse
        '
        Me.btn_Browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Browse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Browse.Location = New System.Drawing.Point(761, 112)
        Me.btn_Browse.Name = "btn_Browse"
        Me.btn_Browse.Size = New System.Drawing.Size(44, 31)
        Me.btn_Browse.TabIndex = 5
        Me.btn_Browse.Text = "+"
        Me.btn_Browse.UseVisualStyleBackColor = True
        '
        'bw_Upload
        '
        '
        'btn_AddFolder
        '
        Me.btn_AddFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_AddFolder.Location = New System.Drawing.Point(761, 51)
        Me.btn_AddFolder.Name = "btn_AddFolder"
        Me.btn_AddFolder.Size = New System.Drawing.Size(44, 31)
        Me.btn_AddFolder.TabIndex = 6
        Me.btn_AddFolder.Text = "+"
        Me.btn_AddFolder.UseVisualStyleBackColor = True
        '
        'ss_Feedback
        '
        Me.ss_Feedback.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback})
        Me.ss_Feedback.Location = New System.Drawing.Point(0, 179)
        Me.ss_Feedback.Name = "ss_Feedback"
        Me.ss_Feedback.Size = New System.Drawing.Size(826, 22)
        Me.ss_Feedback.TabIndex = 7
        Me.ss_Feedback.Text = "ss_Feedback"
        '
        'tss_Feedback
        '
        Me.tss_Feedback.Name = "tss_Feedback"
        Me.tss_Feedback.Size = New System.Drawing.Size(340, 17)
        Me.tss_Feedback.Text = "Please select the file to be uploaded and the folder to upload to"
        '
        'btn_SendEmails
        '
        Me.btn_SendEmails.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_SendEmails.Location = New System.Drawing.Point(21, 53)
        Me.btn_SendEmails.Name = "btn_SendEmails"
        Me.btn_SendEmails.Size = New System.Drawing.Size(238, 36)
        Me.btn_SendEmails.TabIndex = 8
        Me.btn_SendEmails.Text = "Send Emails"
        Me.btn_SendEmails.UseVisualStyleBackColor = True
        '
        'btn_ViewListeners
        '
        Me.btn_ViewListeners.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ViewListeners.Location = New System.Drawing.Point(21, 111)
        Me.btn_ViewListeners.Name = "btn_ViewListeners"
        Me.btn_ViewListeners.Size = New System.Drawing.Size(238, 36)
        Me.btn_ViewListeners.TabIndex = 10
        Me.btn_ViewListeners.Text = "Current Listeners"
        Me.btn_ViewListeners.UseVisualStyleBackColor = True
        '
        'rdo_GoingLive
        '
        Me.rdo_GoingLive.Location = New System.Drawing.Point(0, 0)
        Me.rdo_GoingLive.Name = "rdo_GoingLive"
        Me.rdo_GoingLive.Size = New System.Drawing.Size(104, 24)
        Me.rdo_GoingLive.TabIndex = 0
        '
        'rdo_EmailMinistry
        '
        Me.rdo_EmailMinistry.Location = New System.Drawing.Point(0, 0)
        Me.rdo_EmailMinistry.Name = "rdo_EmailMinistry"
        Me.rdo_EmailMinistry.Size = New System.Drawing.Size(104, 24)
        Me.rdo_EmailMinistry.TabIndex = 0
        '
        'cbx_Files
        '
        Me.cbx_Files.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_Files.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbx_Files.FormattingEnabled = True
        Me.cbx_Files.Location = New System.Drawing.Point(388, 110)
        Me.cbx_Files.Name = "cbx_Files"
        Me.cbx_Files.Size = New System.Drawing.Size(367, 33)
        Me.cbx_Files.TabIndex = 1
        '
        'bw_GetFolders
        '
        '
        'Frm_EmailListeners
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 201)
        Me.Controls.Add(Me.btn_ViewListeners)
        Me.Controls.Add(Me.btn_SendEmails)
        Me.Controls.Add(Me.ss_Feedback)
        Me.Controls.Add(Me.btn_AddFolder)
        Me.Controls.Add(Me.btn_Browse)
        Me.Controls.Add(Me.lbl_FileLocation)
        Me.Controls.Add(Me.lbl_Folder)
        Me.Controls.Add(Me.cbx_Files)
        Me.Controls.Add(Me.cbx_Folders)
        Me.Controls.Add(Me.txt_FileLocation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_EmailListeners"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        CType(Me.FoldersSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ss_Feedback.ResumeLayout(False)
        Me.ss_Feedback.PerformLayout()
        CType(Me.FilesSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents btn_SendEmails As Button
    Friend WithEvents btn_ViewListeners As Button
    Friend WithEvents bw_SendEmails As System.ComponentModel.BackgroundWorker
    Friend WithEvents rdo_GoingLive As RadioButton
    Friend WithEvents rdo_EmailMinistry As RadioButton
    Friend WithEvents cbx_Files As ComboBox
    Friend WithEvents bw_GetFolders As System.ComponentModel.BackgroundWorker
    Friend WithEvents FoldersSource As BindingSource
    Friend WithEvents FilesSource As BindingSource
End Class
