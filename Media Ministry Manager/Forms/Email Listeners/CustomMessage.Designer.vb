<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CustomMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CustomMessage))
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.lbl_MessageSubject = New System.Windows.Forms.Label()
        Me.lbl_MessageBody = New System.Windows.Forms.Label()
        Me.txt_MessageSubject = New System.Windows.Forms.TextBox()
        Me.rtb_MessageBody = New System.Windows.Forms.RichTextBox()
        Me.ms_Menu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tt_HelperInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.ms_Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Save
        '
        Me.btn_Save.AutoSize = True
        Me.btn_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(423, 384)
        Me.btn_Save.MaximumSize = New System.Drawing.Size(200, 200)
        Me.btn_Save.MinimumSize = New System.Drawing.Size(100, 50)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(100, 50)
        Me.btn_Save.TabIndex = 0
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AutoSize = True
        Me.btn_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(136, 384)
        Me.btn_Cancel.MaximumSize = New System.Drawing.Size(200, 200)
        Me.btn_Cancel.MinimumSize = New System.Drawing.Size(100, 50)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(100, 50)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'lbl_MessageSubject
        '
        Me.lbl_MessageSubject.AutoSize = True
        Me.lbl_MessageSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MessageSubject.Location = New System.Drawing.Point(36, 55)
        Me.lbl_MessageSubject.Name = "lbl_MessageSubject"
        Me.lbl_MessageSubject.Size = New System.Drawing.Size(184, 25)
        Me.lbl_MessageSubject.TabIndex = 2
        Me.lbl_MessageSubject.Text = "Message Subject:"
        '
        'lbl_MessageBody
        '
        Me.lbl_MessageBody.AutoSize = True
        Me.lbl_MessageBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MessageBody.Location = New System.Drawing.Point(34, 129)
        Me.lbl_MessageBody.Name = "lbl_MessageBody"
        Me.lbl_MessageBody.Size = New System.Drawing.Size(161, 25)
        Me.lbl_MessageBody.TabIndex = 3
        Me.lbl_MessageBody.Text = "Message Body:"
        '
        'txt_MessageSubject
        '
        Me.txt_MessageSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MessageSubject.Location = New System.Drawing.Point(39, 83)
        Me.txt_MessageSubject.Name = "txt_MessageSubject"
        Me.txt_MessageSubject.Size = New System.Drawing.Size(315, 31)
        Me.txt_MessageSubject.TabIndex = 4
        '
        'rtb_MessageBody
        '
        Me.rtb_MessageBody.AcceptsTab = True
        Me.rtb_MessageBody.EnableAutoDragDrop = True
        Me.rtb_MessageBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_MessageBody.Location = New System.Drawing.Point(37, 157)
        Me.rtb_MessageBody.MinimumSize = New System.Drawing.Size(600, 200)
        Me.rtb_MessageBody.Name = "rtb_MessageBody"
        Me.rtb_MessageBody.Size = New System.Drawing.Size(611, 200)
        Me.rtb_MessageBody.TabIndex = 5
        Me.rtb_MessageBody.Text = ""
        '
        'ms_Menu
        '
        Me.ms_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.ms_Menu.Location = New System.Drawing.Point(0, 0)
        Me.ms_Menu.Name = "ms_Menu"
        Me.ms_Menu.Size = New System.Drawing.Size(684, 24)
        Me.ms_Menu.TabIndex = 6
        Me.ms_Menu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        Me.SaveToolStripMenuItem.ToolTipText = "Save the custom message currently shown"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        Me.ExitToolStripMenuItem.ToolTipText = "Cancel the creation of a custom message"
        '
        'frm_CustomMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.btn_Cancel
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(684, 457)
        Me.Controls.Add(Me.rtb_MessageBody)
        Me.Controls.Add(Me.txt_MessageSubject)
        Me.Controls.Add(Me.lbl_MessageBody)
        Me.Controls.Add(Me.lbl_MessageSubject)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.ms_Menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.ms_Menu
        Me.MaximumSize = New System.Drawing.Size(700, 500)
        Me.MinimumSize = New System.Drawing.Size(100, 100)
        Me.Name = "frm_CustomMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.ms_Menu.ResumeLayout(False)
        Me.ms_Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents lbl_MessageSubject As Label
    Friend WithEvents lbl_MessageBody As Label
    Friend WithEvents txt_MessageSubject As TextBox
    Friend WithEvents rtb_MessageBody As RichTextBox
    Friend WithEvents ms_Menu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tt_HelperInfo As ToolTip
End Class
