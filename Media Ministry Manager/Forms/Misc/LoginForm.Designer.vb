<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.btn_LogIn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.chk_KeepLoggedIn = New System.Windows.Forms.CheckBox()
        Me.ss_Feedback = New System.Windows.Forms.StatusStrip()
        Me.tss_UserFeedback = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bw_SaveSettings = New System.ComponentModel.BackgroundWorker()
        Me.btn_CreateUser = New System.Windows.Forms.Button()
        Me.btn_ChangePassword = New System.Windows.Forms.Button()
        Me.tt_Info = New System.Windows.Forms.ToolTip(Me.components)
        Me.ss_Feedback.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_LogIn
        '
        Me.btn_LogIn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LogIn.Location = New System.Drawing.Point(111, 226)
        Me.btn_LogIn.Name = "btn_LogIn"
        Me.btn_LogIn.Size = New System.Drawing.Size(76, 27)
        Me.btn_LogIn.TabIndex = 7
        Me.btn_LogIn.Text = "Log In"
        Me.btn_LogIn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(13, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(10, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Password:"
        '
        'txt_Username
        '
        Me.txt_Username.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Username.Location = New System.Drawing.Point(13, 56)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(252, 32)
        Me.txt_Username.TabIndex = 1
        Me.tt_Info.SetToolTip(Me.txt_Username, "Enter your username")
        '
        'txt_Password
        '
        Me.txt_Password.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Password.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Password.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txt_Password.Location = New System.Drawing.Point(10, 135)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(252, 32)
        Me.txt_Password.TabIndex = 3
        Me.tt_Info.SetToolTip(Me.txt_Password, "Enter your password")
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'chk_KeepLoggedIn
        '
        Me.chk_KeepLoggedIn.AutoSize = True
        Me.chk_KeepLoggedIn.BackColor = System.Drawing.Color.Transparent
        Me.chk_KeepLoggedIn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_KeepLoggedIn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk_KeepLoggedIn.Location = New System.Drawing.Point(75, 183)
        Me.chk_KeepLoggedIn.Name = "chk_KeepLoggedIn"
        Me.chk_KeepLoggedIn.Size = New System.Drawing.Size(148, 23)
        Me.chk_KeepLoggedIn.TabIndex = 5
        Me.chk_KeepLoggedIn.TabStop = False
        Me.chk_KeepLoggedIn.Text = "Keep Me Signed In"
        Me.chk_KeepLoggedIn.UseVisualStyleBackColor = False
        '
        'ss_Feedback
        '
        Me.ss_Feedback.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_UserFeedback})
        Me.ss_Feedback.Location = New System.Drawing.Point(0, 265)
        Me.ss_Feedback.Name = "ss_Feedback"
        Me.ss_Feedback.Size = New System.Drawing.Size(297, 22)
        Me.ss_Feedback.TabIndex = 8
        Me.ss_Feedback.Text = "StatusStrip1"
        '
        'tss_UserFeedback
        '
        Me.tss_UserFeedback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tss_UserFeedback.Name = "tss_UserFeedback"
        Me.tss_UserFeedback.Size = New System.Drawing.Size(198, 17)
        Me.tss_UserFeedback.Text = "Please enter your log-in information"
        '
        'bw_SaveSettings
        '
        '
        'btn_CreateUser
        '
        Me.btn_CreateUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CreateUser.Location = New System.Drawing.Point(13, 226)
        Me.btn_CreateUser.Name = "btn_CreateUser"
        Me.btn_CreateUser.Size = New System.Drawing.Size(24, 27)
        Me.btn_CreateUser.TabIndex = 6
        Me.btn_CreateUser.Text = "+"
        Me.tt_Info.SetToolTip(Me.btn_CreateUser, "Create a new user")
        Me.btn_CreateUser.UseVisualStyleBackColor = True
        '
        'btn_ChangePassword
        '
        Me.btn_ChangePassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ChangePassword.Location = New System.Drawing.Point(268, 135)
        Me.btn_ChangePassword.Name = "btn_ChangePassword"
        Me.btn_ChangePassword.Size = New System.Drawing.Size(18, 32)
        Me.btn_ChangePassword.TabIndex = 4
        Me.btn_ChangePassword.Text = ">"
        Me.tt_Info.SetToolTip(Me.btn_ChangePassword, "Change Password")
        Me.btn_ChangePassword.UseVisualStyleBackColor = True
        '
        'frm_Login
        '
        Me.AcceptButton = Me.btn_LogIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(297, 287)
        Me.Controls.Add(Me.btn_ChangePassword)
        Me.Controls.Add(Me.btn_CreateUser)
        Me.Controls.Add(Me.ss_Feedback)
        Me.Controls.Add(Me.chk_KeepLoggedIn)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_LogIn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.ss_Feedback.ResumeLayout(False)
        Me.ss_Feedback.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_LogIn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents chk_KeepLoggedIn As CheckBox
    Friend WithEvents ss_Feedback As StatusStrip
    Friend WithEvents tss_UserFeedback As ToolStripStatusLabel
    Friend WithEvents bw_SaveSettings As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_CreateUser As Button
    Friend WithEvents btn_ChangePassword As Button
    Friend WithEvents tt_Info As ToolTip
End Class
