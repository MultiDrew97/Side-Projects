<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterSettingsDialog
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
        Me.bw_LoadSettings = New System.ComponentModel.BackgroundWorker()
        Me.bw_SaveSettings = New System.ComponentModel.BackgroundWorker()
        Me.tctl_Sections = New System.Windows.Forms.TabControl()
        Me.tp_Database = New System.Windows.Forms.TabPage()
        Me.tp_Font = New System.Windows.Forms.TabPage()
        Me.lbl_Bold = New System.Windows.Forms.Label()
        Me.btn_ChangeFont = New System.Windows.Forms.Button()
        Me.lbl_CurrentFont = New System.Windows.Forms.Label()
        Me.lbl_FontSize = New System.Windows.Forms.Label()
        Me.btn_SaveDatabase = New System.Windows.Forms.Button()
        Me.btn_RevertDatabase = New System.Windows.Forms.Button()
        Me.btn_RevertFont = New System.Windows.Forms.Button()
        Me.fd_FontSelector = New System.Windows.Forms.FontDialog()
        Me.tctl_Sections.SuspendLayout()
        Me.tp_Database.SuspendLayout()
        Me.tp_Font.SuspendLayout()
        Me.SuspendLayout()
        '
        'bw_LoadSettings
        '
        '
        'bw_SaveSettings
        '
        '
        'tctl_Sections
        '
        Me.tctl_Sections.Controls.Add(Me.tp_Database)
        Me.tctl_Sections.Controls.Add(Me.tp_Font)
        Me.tctl_Sections.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.MediaMinistry.MySettings.Default, "CurrentFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tctl_Sections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tctl_Sections.Font = Global.MediaMinistry.MySettings.Default.CurrentFont
        Me.tctl_Sections.Location = New System.Drawing.Point(0, 0)
        Me.tctl_Sections.Name = "tctl_Sections"
        Me.tctl_Sections.SelectedIndex = 0
        Me.tctl_Sections.Size = New System.Drawing.Size(435, 315)
        Me.tctl_Sections.TabIndex = 0
        '
        'tp_Database
        '
        Me.tp_Database.Controls.Add(Me.btn_RevertDatabase)
        Me.tp_Database.Controls.Add(Me.btn_SaveDatabase)
        Me.tp_Database.Location = New System.Drawing.Point(4, 34)
        Me.tp_Database.Name = "tp_Database"
        Me.tp_Database.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_Database.Size = New System.Drawing.Size(427, 277)
        Me.tp_Database.TabIndex = 0
        Me.tp_Database.Text = "Database"
        Me.tp_Database.UseVisualStyleBackColor = True
        '
        'tp_Font
        '
        Me.tp_Font.Controls.Add(Me.btn_RevertFont)
        Me.tp_Font.Controls.Add(Me.lbl_Bold)
        Me.tp_Font.Controls.Add(Me.btn_ChangeFont)
        Me.tp_Font.Controls.Add(Me.lbl_CurrentFont)
        Me.tp_Font.Controls.Add(Me.lbl_FontSize)
        Me.tp_Font.Location = New System.Drawing.Point(4, 34)
        Me.tp_Font.Name = "tp_Font"
        Me.tp_Font.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_Font.Size = New System.Drawing.Size(427, 277)
        Me.tp_Font.TabIndex = 1
        Me.tp_Font.Text = "Font"
        Me.tp_Font.UseVisualStyleBackColor = True
        '
        'lbl_Bold
        '
        Me.lbl_Bold.AutoSize = True
        Me.lbl_Bold.Location = New System.Drawing.Point(288, 118)
        Me.lbl_Bold.Name = "lbl_Bold"
        Me.lbl_Bold.Size = New System.Drawing.Size(98, 25)
        Me.lbl_Bold.TabIndex = 9
        Me.lbl_Bold.Text = "Bolded?"
        '
        'btn_ChangeFont
        '
        Me.btn_ChangeFont.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_ChangeFont.AutoSize = True
        Me.btn_ChangeFont.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_ChangeFont.Location = New System.Drawing.Point(88, 186)
        Me.btn_ChangeFont.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_ChangeFont.Name = "btn_ChangeFont"
        Me.btn_ChangeFont.Size = New System.Drawing.Size(250, 35)
        Me.btn_ChangeFont.TabIndex = 8
        Me.btn_ChangeFont.Text = "Change Font Settings"
        Me.btn_ChangeFont.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ChangeFont.UseVisualStyleBackColor = True
        '
        'lbl_CurrentFont
        '
        Me.lbl_CurrentFont.AutoSize = True
        Me.lbl_CurrentFont.Location = New System.Drawing.Point(41, 29)
        Me.lbl_CurrentFont.Name = "lbl_CurrentFont"
        Me.lbl_CurrentFont.Size = New System.Drawing.Size(66, 25)
        Me.lbl_CurrentFont.TabIndex = 7
        Me.lbl_CurrentFont.Text = "Font:"
        '
        'lbl_FontSize
        '
        Me.lbl_FontSize.AutoSize = True
        Me.lbl_FontSize.Location = New System.Drawing.Point(41, 118)
        Me.lbl_FontSize.Name = "lbl_FontSize"
        Me.lbl_FontSize.Size = New System.Drawing.Size(119, 25)
        Me.lbl_FontSize.TabIndex = 6
        Me.lbl_FontSize.Text = "Font Size:"
        '
        'btn_SaveDatabase
        '
        Me.btn_SaveDatabase.AutoSize = True
        Me.btn_SaveDatabase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_SaveDatabase.Location = New System.Drawing.Point(246, 225)
        Me.btn_SaveDatabase.Name = "btn_SaveDatabase"
        Me.btn_SaveDatabase.Size = New System.Drawing.Size(75, 35)
        Me.btn_SaveDatabase.TabIndex = 0
        Me.btn_SaveDatabase.Text = "Save"
        Me.btn_SaveDatabase.UseVisualStyleBackColor = True
        '
        'btn_RevertDatabase
        '
        Me.btn_RevertDatabase.AutoSize = True
        Me.btn_RevertDatabase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_RevertDatabase.Location = New System.Drawing.Point(105, 225)
        Me.btn_RevertDatabase.Name = "btn_RevertDatabase"
        Me.btn_RevertDatabase.Size = New System.Drawing.Size(91, 35)
        Me.btn_RevertDatabase.TabIndex = 1
        Me.btn_RevertDatabase.Text = "Revert"
        Me.btn_RevertDatabase.UseVisualStyleBackColor = True
        '
        'btn_RevertFont
        '
        Me.btn_RevertFont.AutoSize = True
        Me.btn_RevertFont.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_RevertFont.Location = New System.Drawing.Point(168, 234)
        Me.btn_RevertFont.Name = "btn_RevertFont"
        Me.btn_RevertFont.Size = New System.Drawing.Size(91, 35)
        Me.btn_RevertFont.TabIndex = 10
        Me.btn_RevertFont.Text = "Revert"
        Me.btn_RevertFont.UseVisualStyleBackColor = True
        '
        'fd_FontSelector
        '
        Me.fd_FontSelector.AllowVerticalFonts = False
        Me.fd_FontSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fd_FontSelector.FontMustExist = True
        Me.fd_FontSelector.MaxSize = 24
        Me.fd_FontSelector.MinSize = 12
        Me.fd_FontSelector.ScriptsOnly = True
        '
        'MasterSettingsDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.tctl_Sections)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MasterSettingsDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Media Ministry Manager"
        Me.tctl_Sections.ResumeLayout(False)
        Me.tp_Database.ResumeLayout(False)
        Me.tp_Database.PerformLayout()
        Me.tp_Font.ResumeLayout(False)
        Me.tp_Font.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bw_LoadSettings As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_SaveSettings As System.ComponentModel.BackgroundWorker
    Friend WithEvents tctl_Sections As TabControl
    Friend WithEvents tp_Database As TabPage
    Friend WithEvents tp_Font As TabPage
    Friend WithEvents lbl_Bold As Label
    Friend WithEvents btn_ChangeFont As Button
    Friend WithEvents lbl_CurrentFont As Label
    Friend WithEvents lbl_FontSize As Label
    Friend WithEvents btn_RevertDatabase As Button
    Friend WithEvents btn_SaveDatabase As Button
    Friend WithEvents btn_RevertFont As Button
    Friend WithEvents fd_FontSelector As FontDialog
End Class
