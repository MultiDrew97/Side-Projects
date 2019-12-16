<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_AddNewCustomer
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
        Me.btn_AddNewCustomer = New System.Windows.Forms.Button()
        Me.txt_FirstName = New System.Windows.Forms.TextBox()
        Me.txt_LastName = New System.Windows.Forms.TextBox()
        Me.txt_Street = New System.Windows.Forms.TextBox()
        Me.txt_PhoneNumber = New System.Windows.Forms.TextBox()
        Me.ss_Status = New System.Windows.Forms.StatusStrip()
        Me.tss_AddCustomer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_FirstName = New System.Windows.Forms.Label()
        Me.lbl_LastName = New System.Windows.Forms.Label()
        Me.lbl_Street = New System.Windows.Forms.Label()
        Me.lbl_PhoneNumber = New System.Windows.Forms.Label()
        Me.cbx_PaymentType = New System.Windows.Forms.ComboBox()
        Me.lbl_PaymentType = New System.Windows.Forms.Label()
        Me.ep_EmptyFields = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txt_City = New System.Windows.Forms.TextBox()
        Me.lbl_City = New System.Windows.Forms.Label()
        Me.txt_Zip = New System.Windows.Forms.TextBox()
        Me.lbl_Zip = New System.Windows.Forms.Label()
        Me.cbx_State = New System.Windows.Forms.ComboBox()
        Me.lbl_State = New System.Windows.Forms.Label()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.lbl_Required = New System.Windows.Forms.Label()
        Me.ss_Status.SuspendLayout()
        CType(Me.ep_EmptyFields, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_AddNewCustomer
        '
        Me.btn_AddNewCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddNewCustomer.Location = New System.Drawing.Point(330, 322)
        Me.btn_AddNewCustomer.Name = "btn_AddNewCustomer"
        Me.btn_AddNewCustomer.Size = New System.Drawing.Size(169, 63)
        Me.btn_AddNewCustomer.TabIndex = 18
        Me.btn_AddNewCustomer.Text = "Add New Customer"
        Me.btn_AddNewCustomer.UseVisualStyleBackColor = True
        '
        'txt_FirstName
        '
        Me.txt_FirstName.BackColor = System.Drawing.SystemColors.Window
        Me.txt_FirstName.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FirstName.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_FirstName.Location = New System.Drawing.Point(187, 40)
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.Size = New System.Drawing.Size(213, 31)
        Me.txt_FirstName.TabIndex = 1
        Me.txt_FirstName.Text = "First Name"
        '
        'txt_LastName
        '
        Me.txt_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LastName.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_LastName.Location = New System.Drawing.Point(428, 40)
        Me.txt_LastName.Name = "txt_LastName"
        Me.txt_LastName.Size = New System.Drawing.Size(213, 31)
        Me.txt_LastName.TabIndex = 3
        Me.txt_LastName.Text = "Last Name"
        '
        'txt_Street
        '
        Me.txt_Street.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Street.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_Street.Location = New System.Drawing.Point(43, 115)
        Me.txt_Street.Name = "txt_Street"
        Me.txt_Street.Size = New System.Drawing.Size(213, 31)
        Me.txt_Street.TabIndex = 5
        Me.txt_Street.Text = "Street"
        '
        'txt_PhoneNumber
        '
        Me.txt_PhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PhoneNumber.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_PhoneNumber.Location = New System.Drawing.Point(113, 194)
        Me.txt_PhoneNumber.Name = "txt_PhoneNumber"
        Me.txt_PhoneNumber.Size = New System.Drawing.Size(156, 31)
        Me.txt_PhoneNumber.TabIndex = 13
        Me.txt_PhoneNumber.Text = "Phone Number"
        '
        'ss_Status
        '
        Me.ss_Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_AddCustomer})
        Me.ss_Status.Location = New System.Drawing.Point(0, 410)
        Me.ss_Status.Name = "ss_Status"
        Me.ss_Status.Size = New System.Drawing.Size(828, 22)
        Me.ss_Status.TabIndex = 19
        Me.ss_Status.Text = "Please Enter the Buyers Info"
        '
        'tss_AddCustomer
        '
        Me.tss_AddCustomer.Name = "tss_AddCustomer"
        Me.tss_AddCustomer.Size = New System.Drawing.Size(164, 17)
        Me.tss_AddCustomer.Text = "Enter the persons information"
        '
        'lbl_FirstName
        '
        Me.lbl_FirstName.AutoSize = True
        Me.lbl_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FirstName.Location = New System.Drawing.Point(177, 22)
        Me.lbl_FirstName.Name = "lbl_FirstName"
        Me.lbl_FirstName.Size = New System.Drawing.Size(75, 15)
        Me.lbl_FirstName.TabIndex = 0
        Me.lbl_FirstName.Text = "* First Name"
        '
        'lbl_LastName
        '
        Me.lbl_LastName.AutoSize = True
        Me.lbl_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LastName.Location = New System.Drawing.Point(417, 22)
        Me.lbl_LastName.Name = "lbl_LastName"
        Me.lbl_LastName.Size = New System.Drawing.Size(75, 15)
        Me.lbl_LastName.TabIndex = 2
        Me.lbl_LastName.Text = "* Last Name"
        '
        'lbl_Street
        '
        Me.lbl_Street.AutoSize = True
        Me.lbl_Street.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Street.Location = New System.Drawing.Point(40, 98)
        Me.lbl_Street.Name = "lbl_Street"
        Me.lbl_Street.Size = New System.Drawing.Size(39, 15)
        Me.lbl_Street.TabIndex = 4
        Me.lbl_Street.Text = "Street"
        '
        'lbl_PhoneNumber
        '
        Me.lbl_PhoneNumber.AutoSize = True
        Me.lbl_PhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PhoneNumber.Location = New System.Drawing.Point(103, 176)
        Me.lbl_PhoneNumber.Name = "lbl_PhoneNumber"
        Me.lbl_PhoneNumber.Size = New System.Drawing.Size(99, 15)
        Me.lbl_PhoneNumber.TabIndex = 12
        Me.lbl_PhoneNumber.Text = "* Phone Number"
        '
        'cbx_PaymentType
        '
        Me.cbx_PaymentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbx_PaymentType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_PaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbx_PaymentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cbx_PaymentType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbx_PaymentType.FormattingEnabled = True
        Me.cbx_PaymentType.Items.AddRange(New Object() {"Cash", "Card"})
        Me.cbx_PaymentType.Location = New System.Drawing.Point(339, 265)
        Me.cbx_PaymentType.Name = "cbx_PaymentType"
        Me.cbx_PaymentType.Size = New System.Drawing.Size(150, 33)
        Me.cbx_PaymentType.TabIndex = 17
        '
        'lbl_PaymentType
        '
        Me.lbl_PaymentType.AutoSize = True
        Me.lbl_PaymentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_PaymentType.Location = New System.Drawing.Point(339, 247)
        Me.lbl_PaymentType.Name = "lbl_PaymentType"
        Me.lbl_PaymentType.Size = New System.Drawing.Size(100, 15)
        Me.lbl_PaymentType.TabIndex = 16
        Me.lbl_PaymentType.Text = "Payment Method"
        '
        'ep_EmptyFields
        '
        Me.ep_EmptyFields.ContainerControl = Me
        '
        'txt_City
        '
        Me.txt_City.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_City.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_City.Location = New System.Drawing.Point(262, 115)
        Me.txt_City.Name = "txt_City"
        Me.txt_City.Size = New System.Drawing.Size(213, 31)
        Me.txt_City.TabIndex = 7
        Me.txt_City.Text = "City"
        '
        'lbl_City
        '
        Me.lbl_City.AutoSize = True
        Me.lbl_City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_City.Location = New System.Drawing.Point(262, 98)
        Me.lbl_City.Name = "lbl_City"
        Me.lbl_City.Size = New System.Drawing.Size(26, 15)
        Me.lbl_City.TabIndex = 6
        Me.lbl_City.Text = "City"
        '
        'txt_Zip
        '
        Me.txt_Zip.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Zip.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_Zip.Location = New System.Drawing.Point(572, 115)
        Me.txt_Zip.Name = "txt_Zip"
        Me.txt_Zip.Size = New System.Drawing.Size(213, 31)
        Me.txt_Zip.TabIndex = 11
        Me.txt_Zip.Text = "Zip"
        '
        'lbl_Zip
        '
        Me.lbl_Zip.AutoSize = True
        Me.lbl_Zip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Zip.Location = New System.Drawing.Point(572, 98)
        Me.lbl_Zip.Name = "lbl_Zip"
        Me.lbl_Zip.Size = New System.Drawing.Size(24, 15)
        Me.lbl_Zip.TabIndex = 10
        Me.lbl_Zip.Text = "Zip"
        '
        'cbx_State
        '
        Me.cbx_State.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbx_State.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbx_State.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cbx_State.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbx_State.FormattingEnabled = True
        Me.cbx_State.Items.AddRange(New Object() {"AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY"})
        Me.cbx_State.Location = New System.Drawing.Point(491, 114)
        Me.cbx_State.MaxLength = 2
        Me.cbx_State.Name = "cbx_State"
        Me.cbx_State.Size = New System.Drawing.Size(64, 33)
        Me.cbx_State.Sorted = True
        Me.cbx_State.TabIndex = 9
        '
        'lbl_State
        '
        Me.lbl_State.AutoSize = True
        Me.lbl_State.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_State.Location = New System.Drawing.Point(488, 96)
        Me.lbl_State.Name = "lbl_State"
        Me.lbl_State.Size = New System.Drawing.Size(35, 15)
        Me.lbl_State.TabIndex = 8
        Me.lbl_State.Text = "State"
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_Email.Location = New System.Drawing.Point(329, 194)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(389, 31)
        Me.txt_Email.TabIndex = 15
        Me.txt_Email.Text = "E-Mail"
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Email.Location = New System.Drawing.Point(326, 176)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(43, 15)
        Me.lbl_Email.TabIndex = 14
        Me.lbl_Email.Text = "E-Mail"
        '
        'lbl_Required
        '
        Me.lbl_Required.AutoSize = True
        Me.lbl_Required.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_Required.Location = New System.Drawing.Point(686, 9)
        Me.lbl_Required.Name = "lbl_Required"
        Me.lbl_Required.Size = New System.Drawing.Size(130, 15)
        Me.lbl_Required.TabIndex = 20
        Me.lbl_Required.Text = "* Marks required fields"
        '
        'frm_AddNewCustomer
        '
        Me.AcceptButton = Me.btn_AddNewCustomer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(828, 432)
        Me.Controls.Add(Me.lbl_Required)
        Me.Controls.Add(Me.lbl_State)
        Me.Controls.Add(Me.lbl_PaymentType)
        Me.Controls.Add(Me.cbx_State)
        Me.Controls.Add(Me.cbx_PaymentType)
        Me.Controls.Add(Me.lbl_Email)
        Me.Controls.Add(Me.lbl_PhoneNumber)
        Me.Controls.Add(Me.lbl_Zip)
        Me.Controls.Add(Me.lbl_City)
        Me.Controls.Add(Me.lbl_Street)
        Me.Controls.Add(Me.lbl_LastName)
        Me.Controls.Add(Me.lbl_FirstName)
        Me.Controls.Add(Me.ss_Status)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.txt_PhoneNumber)
        Me.Controls.Add(Me.txt_Zip)
        Me.Controls.Add(Me.txt_City)
        Me.Controls.Add(Me.txt_Street)
        Me.Controls.Add(Me.txt_LastName)
        Me.Controls.Add(Me.txt_FirstName)
        Me.Controls.Add(Me.btn_AddNewCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_AddNewCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Ministry"
        Me.ss_Status.ResumeLayout(False)
        Me.ss_Status.PerformLayout()
        CType(Me.ep_EmptyFields, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_AddNewCustomer As Button
    Friend WithEvents txt_FirstName As TextBox
    Friend WithEvents txt_LastName As TextBox
    Friend WithEvents txt_Street As TextBox
    Friend WithEvents txt_PhoneNumber As TextBox
    Friend WithEvents ss_Status As StatusStrip
    Friend WithEvents lbl_FirstName As Label
    Friend WithEvents lbl_LastName As Label
    Friend WithEvents lbl_Street As Label
    Friend WithEvents lbl_PhoneNumber As Label
    Friend WithEvents cbx_PaymentType As ComboBox
    Friend WithEvents lbl_PaymentType As Label
    Friend WithEvents ep_EmptyFields As ErrorProvider
    Friend WithEvents lbl_State As Label
    Friend WithEvents cbx_State As ComboBox
    Friend WithEvents lbl_Zip As Label
    Friend WithEvents lbl_City As Label
    Friend WithEvents txt_Zip As TextBox
    Friend WithEvents txt_City As TextBox
    Friend WithEvents lbl_Email As Label
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents lbl_Required As Label
    Friend WithEvents tss_AddCustomer As ToolStripStatusLabel
End Class
