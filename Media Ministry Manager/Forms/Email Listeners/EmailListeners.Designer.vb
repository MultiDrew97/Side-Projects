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
        Me.btn_SendEmail = New System.Windows.Forms.Button()
        Me.ofd_SelectAudio = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btn_SendEmail
        '
        Me.btn_SendEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_SendEmail.Location = New System.Drawing.Point(76, 57)
        Me.btn_SendEmail.Name = "btn_SendEmail"
        Me.btn_SendEmail.Size = New System.Drawing.Size(122, 79)
        Me.btn_SendEmail.TabIndex = 0
        Me.btn_SendEmail.Text = "Send Email"
        Me.btn_SendEmail.UseVisualStyleBackColor = True
        '
        'ofd_SelectAudio
        '
        Me.ofd_SelectAudio.Multiselect = True
        Me.ofd_SelectAudio.Title = "Choose the file for sending"
        '
        'frm_EmailListeners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 192)
        Me.Controls.Add(Me.btn_SendEmail)
        Me.MaximizeBox = False
        Me.Name = "frm_EmailListeners"
        Me.Text = "Media Ministry Manager"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_SendEmail As Button
    Friend WithEvents ofd_SelectAudio As OpenFileDialog
End Class
