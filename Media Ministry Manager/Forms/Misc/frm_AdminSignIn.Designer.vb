<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AdminSignIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AdminSignIn))
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.btn_ShowPassword = New System.Windows.Forms.Button()
        Me.ss_Info = New System.Windows.Forms.StatusStrip()
        Me.tss_Info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ss_Info.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Submit
        '
        Me.btn_Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Submit.Location = New System.Drawing.Point(178, 120)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(80, 29)
        Me.btn_Submit.TabIndex = 5
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.Location = New System.Drawing.Point(19, 31)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(96, 20)
        Me.lbl_Username.TabIndex = 0
        Me.lbl_Username.Text = "Username:"
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Password.Location = New System.Drawing.Point(24, 70)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(91, 20)
        Me.lbl_Password.TabIndex = 2
        Me.lbl_Password.Text = "Password:"
        '
        'txt_Username
        '
        Me.txt_Username.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.txt_Username.Location = New System.Drawing.Point(121, 26)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(224, 32)
        Me.txt_Username.TabIndex = 1
        '
        'txt_Password
        '
        Me.txt_Password.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.txt_Password.Location = New System.Drawing.Point(121, 65)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(224, 32)
        Me.txt_Password.TabIndex = 3
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'btn_ShowPassword
        '
        Me.btn_ShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ShowPassword.Location = New System.Drawing.Point(351, 68)
        Me.btn_ShowPassword.Name = "btn_ShowPassword"
        Me.btn_ShowPassword.Size = New System.Drawing.Size(67, 27)
        Me.btn_ShowPassword.TabIndex = 4
        Me.btn_ShowPassword.Text = "Show"
        Me.btn_ShowPassword.UseVisualStyleBackColor = True
        '
        'ss_Info
        '
        Me.ss_Info.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Info})
        Me.ss_Info.Location = New System.Drawing.Point(0, 153)
        Me.ss_Info.Name = "ss_Info"
        Me.ss_Info.Size = New System.Drawing.Size(437, 22)
        Me.ss_Info.TabIndex = 6
        '
        'tss_Info
        '
        Me.tss_Info.Name = "tss_Info"
        Me.tss_Info.Size = New System.Drawing.Size(159, 17)
        Me.tss_Info.Text = "Enter the admin's credentials"
        '
        'frm_AdminSignIn
        '
        Me.AcceptButton = Me.btn_Submit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 175)
        Me.Controls.Add(Me.ss_Info)
        Me.Controls.Add(Me.btn_ShowPassword)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.btn_Submit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_AdminSignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.ss_Info.ResumeLayout(False)
        Me.ss_Info.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Submit As Button
    Friend WithEvents lbl_Username As Label
    Friend WithEvents lbl_Password As Label
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents btn_ShowPassword As Button
    Friend WithEvents ss_Info As StatusStrip
    Friend WithEvents tss_Info As ToolStripStatusLabel
End Class
