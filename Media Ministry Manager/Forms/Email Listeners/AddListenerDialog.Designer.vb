<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddListenerDialog
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddListenerDialog))
        Me.gbx_Options = New System.Windows.Forms.GroupBox()
        Me.rdo_Single = New System.Windows.Forms.RadioButton()
        Me.rdo_Multiple = New System.Windows.Forms.RadioButton()
        Me.ofd_ListenerList = New System.Windows.Forms.OpenFileDialog()
        Me.txt_FirstName = New System.Windows.Forms.TextBox()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.lbl_FirstName = New System.Windows.Forms.Label()
        Me.lbl_LastName = New System.Windows.Forms.Label()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.lbl_FilePath = New System.Windows.Forms.Label()
        Me.txt_FilePath = New System.Windows.Forms.TextBox()
        Me.txt_LastName = New System.Windows.Forms.TextBox()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Browse = New System.Windows.Forms.Button()
        Me.ss_FeedbackStrip = New System.Windows.Forms.StatusStrip()
        Me.tss_Feedback = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ep_Required = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.chk_Headers = New System.Windows.Forms.CheckBox()
        Me.bw_AddListeners = New System.ComponentModel.BackgroundWorker()
        Me.gbx_Options.SuspendLayout()
        Me.ss_FeedbackStrip.SuspendLayout()
        CType(Me.ep_Required, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Options
        '
        Me.gbx_Options.Controls.Add(Me.rdo_Single)
        Me.gbx_Options.Controls.Add(Me.rdo_Multiple)
        Me.gbx_Options.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.gbx_Options.Location = New System.Drawing.Point(27, 51)
        Me.gbx_Options.Name = "gbx_Options"
        Me.gbx_Options.Size = New System.Drawing.Size(244, 147)
        Me.gbx_Options.TabIndex = 0
        Me.gbx_Options.TabStop = False
        Me.gbx_Options.Text = "Options"
        '
        'rdo_Single
        '
        Me.rdo_Single.AutoSize = True
        Me.rdo_Single.Checked = True
        Me.rdo_Single.Location = New System.Drawing.Point(28, 37)
        Me.rdo_Single.Name = "rdo_Single"
        Me.rdo_Single.Size = New System.Drawing.Size(156, 30)
        Me.rdo_Single.TabIndex = 1
        Me.rdo_Single.TabStop = True
        Me.rdo_Single.Text = "One Person"
        Me.rdo_Single.UseVisualStyleBackColor = True
        '
        'rdo_Multiple
        '
        Me.rdo_Multiple.AutoSize = True
        Me.rdo_Multiple.Location = New System.Drawing.Point(28, 88)
        Me.rdo_Multiple.Name = "rdo_Multiple"
        Me.rdo_Multiple.Size = New System.Drawing.Size(194, 30)
        Me.rdo_Multiple.TabIndex = 2
        Me.rdo_Multiple.Text = "Multiple People"
        Me.rdo_Multiple.UseVisualStyleBackColor = True
        '
        'ofd_ListenerList
        '
        Me.ofd_ListenerList.Filter = "List (*.csv)|*.csv"
        Me.ofd_ListenerList.Title = "List of Listeners (.csv)"
        '
        'txt_FirstName
        '
        Me.txt_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txt_FirstName.Location = New System.Drawing.Point(304, 70)
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.Size = New System.Drawing.Size(249, 32)
        Me.txt_FirstName.TabIndex = 1
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Email.Location = New System.Drawing.Point(347, 183)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(449, 32)
        Me.txt_Email.TabIndex = 2
        '
        'lbl_FirstName
        '
        Me.lbl_FirstName.AutoSize = True
        Me.lbl_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_FirstName.Location = New System.Drawing.Point(299, 41)
        Me.lbl_FirstName.Name = "lbl_FirstName"
        Me.lbl_FirstName.Size = New System.Drawing.Size(136, 26)
        Me.lbl_FirstName.TabIndex = 3
        Me.lbl_FirstName.Text = "First Name:"
        '
        'lbl_LastName
        '
        Me.lbl_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LastName.Location = New System.Drawing.Point(602, 44)
        Me.lbl_LastName.Name = "lbl_LastName"
        Me.lbl_LastName.Size = New System.Drawing.Size(136, 26)
        Me.lbl_LastName.TabIndex = 12
        Me.lbl_LastName.Text = "Last Name:"
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Email.Location = New System.Drawing.Point(342, 154)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(174, 26)
        Me.lbl_Email.TabIndex = 4
        Me.lbl_Email.Text = "Email Address:"
        '
        'lbl_FilePath
        '
        Me.lbl_FilePath.AutoSize = True
        Me.lbl_FilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_FilePath.Location = New System.Drawing.Point(363, 75)
        Me.lbl_FilePath.Name = "lbl_FilePath"
        Me.lbl_FilePath.Size = New System.Drawing.Size(114, 26)
        Me.lbl_FilePath.TabIndex = 5
        Me.lbl_FilePath.Text = "File Path:"
        '
        'txt_FilePath
        '
        Me.txt_FilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txt_FilePath.Location = New System.Drawing.Point(368, 101)
        Me.txt_FilePath.Name = "txt_FilePath"
        Me.txt_FilePath.ReadOnly = True
        Me.txt_FilePath.Size = New System.Drawing.Size(417, 32)
        Me.txt_FilePath.TabIndex = 6
        '
        'txt_LastName
        '
        Me.txt_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LastName.Location = New System.Drawing.Point(605, 70)
        Me.txt_LastName.Name = "txt_LastName"
        Me.txt_LastName.Size = New System.Drawing.Size(249, 31)
        Me.txt_LastName.TabIndex = 13
        '
        'btn_Add
        '
        Me.btn_Add.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Add.Location = New System.Drawing.Point(500, 240)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(187, 53)
        Me.btn_Add.TabIndex = 7
        Me.btn_Add.Text = "Add Listener"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Cancel.Location = New System.Drawing.Point(230, 240)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(187, 53)
        Me.btn_Cancel.TabIndex = 8
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Browse
        '
        Me.btn_Browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Browse.Location = New System.Drawing.Point(792, 101)
        Me.btn_Browse.Name = "btn_Browse"
        Me.btn_Browse.Size = New System.Drawing.Size(43, 32)
        Me.btn_Browse.TabIndex = 9
        Me.btn_Browse.Text = "..."
        Me.btn_Browse.UseVisualStyleBackColor = True
        '
        'ss_FeedbackStrip
        '
        Me.ss_FeedbackStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_Feedback})
        Me.ss_FeedbackStrip.Location = New System.Drawing.Point(0, 312)
        Me.ss_FeedbackStrip.Name = "ss_FeedbackStrip"
        Me.ss_FeedbackStrip.Size = New System.Drawing.Size(880, 22)
        Me.ss_FeedbackStrip.TabIndex = 10
        Me.ss_FeedbackStrip.Text = "StatusStrip1"
        '
        'tss_Feedback
        '
        Me.tss_Feedback.Name = "tss_Feedback"
        Me.tss_Feedback.Size = New System.Drawing.Size(242, 17)
        Me.tss_Feedback.Text = "Enter the name and email of the new listener"
        '
        'ep_Required
        '
        Me.ep_Required.ContainerControl = Me
        '
        'chk_Headers
        '
        Me.chk_Headers.AutoSize = True
        Me.chk_Headers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Headers.Location = New System.Drawing.Point(514, 151)
        Me.chk_Headers.Name = "chk_Headers"
        Me.chk_Headers.Size = New System.Drawing.Size(219, 29)
        Me.chk_Headers.TabIndex = 11
        Me.chk_Headers.Text = "Contains Headers"
        Me.chk_Headers.UseVisualStyleBackColor = True
        Me.chk_Headers.Visible = False
        '
        'bw_AddListeners
        '
        '
        'AddListenerDialog
        '
        Me.AcceptButton = Me.btn_Add
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(880, 334)
        Me.Controls.Add(Me.chk_Headers)
        Me.Controls.Add(Me.ss_FeedbackStrip)
        Me.Controls.Add(Me.btn_Browse)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.txt_FilePath)
        Me.Controls.Add(Me.lbl_FilePath)
        Me.Controls.Add(Me.lbl_Email)
        Me.Controls.Add(Me.lbl_LastName)
        Me.Controls.Add(Me.lbl_FirstName)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.txt_LastName)
        Me.Controls.Add(Me.txt_FirstName)
        Me.Controls.Add(Me.gbx_Options)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AddListenerDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry Manager"
        Me.gbx_Options.ResumeLayout(False)
        Me.gbx_Options.PerformLayout()
        Me.ss_FeedbackStrip.ResumeLayout(False)
        Me.ss_FeedbackStrip.PerformLayout()
        CType(Me.ep_Required, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbx_Options As GroupBox
    Friend WithEvents rdo_Multiple As RadioButton
    Friend WithEvents rdo_Single As RadioButton
    Friend WithEvents ofd_ListenerList As OpenFileDialog
    Friend WithEvents txt_FirstName As TextBox
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents lbl_FirstName As Label
    Friend WithEvents lbl_Email As Label
    Friend WithEvents lbl_FilePath As Label
    Friend WithEvents txt_FilePath As TextBox
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Browse As Button
    Friend WithEvents ss_FeedbackStrip As StatusStrip
    Friend WithEvents tss_Feedback As ToolStripStatusLabel
    Friend WithEvents txt_LastName As TextBox
    Friend WithEvents lbl_LastName As Label
    Friend WithEvents ep_Required As ErrorProvider
    Friend WithEvents chk_Headers As CheckBox
    Friend WithEvents bw_AddListeners As System.ComponentModel.BackgroundWorker
End Class
