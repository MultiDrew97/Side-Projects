<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileSelectionDialog
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
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Ok = New System.Windows.Forms.Button()
        Me.lbl_File = New System.Windows.Forms.Label()
        Me.lbl_Folder = New System.Windows.Forms.Label()
        Me.cbx_File = New System.Windows.Forms.ComboBox()
        Me.cbx_Folder = New System.Windows.Forms.ComboBox()
        Me.tcl_Options = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbl_FileLocation = New System.Windows.Forms.Label()
        Me.flf_FileSelection = New MediaMinistry.FileLocationField()
        Me.tcl_Options.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AutoSize = True
        Me.btn_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Location = New System.Drawing.Point(115, 234)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(89, 35)
        Me.btn_Cancel.TabIndex = 29
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Ok
        '
        Me.btn_Ok.AutoSize = True
        Me.btn_Ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Ok.Location = New System.Drawing.Point(351, 234)
        Me.btn_Ok.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_Ok.Name = "btn_Ok"
        Me.btn_Ok.Size = New System.Drawing.Size(82, 35)
        Me.btn_Ok.TabIndex = 28
        Me.btn_Ok.Text = "Select"
        Me.btn_Ok.UseVisualStyleBackColor = True
        '
        'lbl_File
        '
        Me.lbl_File.AutoSize = True
        Me.lbl_File.Location = New System.Drawing.Point(30, 96)
        Me.lbl_File.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_File.Name = "lbl_File"
        Me.lbl_File.Size = New System.Drawing.Size(53, 25)
        Me.lbl_File.TabIndex = 27
        Me.lbl_File.Text = "File:"
        '
        'lbl_Folder
        '
        Me.lbl_Folder.AutoSize = True
        Me.lbl_Folder.Location = New System.Drawing.Point(30, 7)
        Me.lbl_Folder.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_Folder.Name = "lbl_Folder"
        Me.lbl_Folder.Size = New System.Drawing.Size(79, 25)
        Me.lbl_Folder.TabIndex = 26
        Me.lbl_Folder.Text = "Folder:"
        '
        'cbx_File
        '
        Me.cbx_File.FormattingEnabled = True
        Me.cbx_File.Location = New System.Drawing.Point(30, 121)
        Me.cbx_File.Margin = New System.Windows.Forms.Padding(12)
        Me.cbx_File.Name = "cbx_File"
        Me.cbx_File.Size = New System.Drawing.Size(494, 33)
        Me.cbx_File.TabIndex = 25
        '
        'cbx_Folder
        '
        Me.cbx_Folder.FormattingEnabled = True
        Me.cbx_Folder.Location = New System.Drawing.Point(30, 33)
        Me.cbx_Folder.Margin = New System.Windows.Forms.Padding(12)
        Me.cbx_Folder.Name = "cbx_Folder"
        Me.cbx_Folder.Size = New System.Drawing.Size(494, 33)
        Me.cbx_Folder.TabIndex = 24
        '
        'tcl_Options
        '
        Me.tcl_Options.Controls.Add(Me.TabPage1)
        Me.tcl_Options.Controls.Add(Me.TabPage2)
        Me.tcl_Options.Dock = System.Windows.Forms.DockStyle.Top
        Me.tcl_Options.Location = New System.Drawing.Point(0, 0)
        Me.tcl_Options.Name = "tcl_Options"
        Me.tcl_Options.SelectedIndex = 0
        Me.tcl_Options.Size = New System.Drawing.Size(549, 225)
        Me.tcl_Options.TabIndex = 30
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cbx_Folder)
        Me.TabPage1.Controls.Add(Me.cbx_File)
        Me.TabPage1.Controls.Add(Me.lbl_File)
        Me.TabPage1.Controls.Add(Me.lbl_Folder)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(541, 187)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Google Drive"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lbl_FileLocation)
        Me.TabPage2.Controls.Add(Me.flf_FileSelection)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(541, 187)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Local File"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lbl_FileLocation
        '
        Me.lbl_FileLocation.AutoSize = True
        Me.lbl_FileLocation.Location = New System.Drawing.Point(19, 54)
        Me.lbl_FileLocation.Name = "lbl_FileLocation"
        Me.lbl_FileLocation.Size = New System.Drawing.Size(115, 25)
        Me.lbl_FileLocation.TabIndex = 1
        Me.lbl_FileLocation.Text = "File Name:"
        '
        'flf_FileSelection
        '
        Me.flf_FileSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.flf_FileSelection.Location = New System.Drawing.Point(19, 82)
        Me.flf_FileSelection.Name = "flf_FileSelection"
        Me.flf_FileSelection.Size = New System.Drawing.Size(503, 32)
        Me.flf_FileSelection.TabIndex = 0
        '
        'FileSelectionDialog
        '
        Me.AcceptButton = Me.btn_Ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(549, 284)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Ok)
        Me.Controls.Add(Me.tcl_Options)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FileSelectionDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select the File..."
        Me.tcl_Options.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Ok As Button
    Friend WithEvents lbl_File As Label
    Friend WithEvents lbl_Folder As Label
    Friend WithEvents cbx_File As ComboBox
    Friend WithEvents cbx_Folder As ComboBox
    Friend WithEvents tcl_Options As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lbl_FileLocation As Label
    Friend WithEvents flf_FileSelection As FileLocationField
End Class
