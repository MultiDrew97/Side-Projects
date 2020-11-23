<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Settings))
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.tc_Settings = New System.Windows.Forms.TabControl()
        Me.tp_Fonts = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.fd_FontSelector = New System.Windows.Forms.FontDialog()
        Me.tc_Settings.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Save
        '
        Me.btn_Save.AutoSize = True
        Me.btn_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(319, 400)
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(72, 36)
        Me.btn_Save.TabIndex = 0
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AutoSize = True
        Me.btn_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(68, 400)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(90, 36)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'tc_Settings
        '
        Me.tc_Settings.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tc_Settings.Controls.Add(Me.tp_Fonts)
        Me.tc_Settings.Controls.Add(Me.TabPage2)
        Me.tc_Settings.Location = New System.Drawing.Point(36, 47)
        Me.tc_Settings.Name = "tc_Settings"
        Me.tc_Settings.SelectedIndex = 0
        Me.tc_Settings.Size = New System.Drawing.Size(400, 331)
        Me.tc_Settings.TabIndex = 2
        '
        'tp_Fonts
        '
        Me.tp_Fonts.Location = New System.Drawing.Point(4, 37)
        Me.tp_Fonts.Name = "tp_Fonts"
        Me.tp_Fonts.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_Fonts.Size = New System.Drawing.Size(392, 290)
        Me.tp_Fonts.TabIndex = 0
        Me.tp_Fonts.Text = "Font Selection"
        Me.tp_Fonts.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 37)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(392, 290)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'fd_FontSelector
        '
        Me.fd_FontSelector.AllowVerticalFonts = False
        Me.fd_FontSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fd_FontSelector.FontMustExist = True
        Me.fd_FontSelector.ScriptsOnly = True
        Me.fd_FontSelector.ShowApply = True
        '
        'frm_Settings
        '
        Me.AcceptButton = Me.btn_Save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.tc_Settings)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximumSize = New System.Drawing.Size(800, 800)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "frm_Settings"
        Me.Text = "Media Ministry Manager"
        Me.tc_Settings.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents tc_Settings As TabControl
    Friend WithEvents tp_Fonts As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents fd_FontSelector As FontDialog
End Class
