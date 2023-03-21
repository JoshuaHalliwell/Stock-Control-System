<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffAdd
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
        Me.LblStaffID = New System.Windows.Forms.Label()
        Me.LblStaffSurname = New System.Windows.Forms.Label()
        Me.LblStaffEmail = New System.Windows.Forms.Label()
        Me.LblStaffPassword = New System.Windows.Forms.Label()
        Me.LblStaffUsername = New System.Windows.Forms.Label()
        Me.LblStaffFirstName = New System.Windows.Forms.Label()
        Me.LblAccessLevel = New System.Windows.Forms.Label()
        Me.LblStaffTelephone = New System.Windows.Forms.Label()
        Me.TbxStaffID = New System.Windows.Forms.TextBox()
        Me.TbxStaffFirstName = New System.Windows.Forms.TextBox()
        Me.TbxStaffTelephone = New System.Windows.Forms.TextBox()
        Me.TbxStaffSurname = New System.Windows.Forms.TextBox()
        Me.TbxStaffEmail = New System.Windows.Forms.TextBox()
        Me.TbxAccessLevel = New System.Windows.Forms.TextBox()
        Me.TbxStaffUsername = New System.Windows.Forms.TextBox()
        Me.TbxStaffPassword = New System.Windows.Forms.TextBox()
        Me.BtnNextStaff = New System.Windows.Forms.Button()
        Me.BtnClearStaffDetails = New System.Windows.Forms.Button()
        Me.BtnFirstStaffDetails = New System.Windows.Forms.Button()
        Me.BtnAddStaffDetails = New System.Windows.Forms.Button()
        Me.BtnDeleteStaffDetails = New System.Windows.Forms.Button()
        Me.BtnUpdateStaffDetails = New System.Windows.Forms.Button()
        Me.BtnBackToMenu = New System.Windows.Forms.Button()
        Me.BtnCancelProcess = New System.Windows.Forms.Button()
        Me.BtnPreviousStaff = New System.Windows.Forms.Button()
        Me.BtnLastStaffDetails = New System.Windows.Forms.Button()
        Me.LblStaffIDError = New System.Windows.Forms.Label()
        Me.LblFirstnameError = New System.Windows.Forms.Label()
        Me.LblSurnameError = New System.Windows.Forms.Label()
        Me.LblStaffEmailError = New System.Windows.Forms.Label()
        Me.LblTelephoneError = New System.Windows.Forms.Label()
        Me.LblStaffUsernameError = New System.Windows.Forms.Label()
        Me.LblStaffPasswordError = New System.Windows.Forms.Label()
        Me.LblAccessLevelError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblStaffID
        '
        Me.LblStaffID.AutoSize = True
        Me.LblStaffID.Location = New System.Drawing.Point(31, 37)
        Me.LblStaffID.Name = "LblStaffID"
        Me.LblStaffID.Size = New System.Drawing.Size(40, 13)
        Me.LblStaffID.TabIndex = 0
        Me.LblStaffID.Text = "StaffID"
        '
        'LblStaffSurname
        '
        Me.LblStaffSurname.AutoSize = True
        Me.LblStaffSurname.Location = New System.Drawing.Point(31, 111)
        Me.LblStaffSurname.Name = "LblStaffSurname"
        Me.LblStaffSurname.Size = New System.Drawing.Size(71, 13)
        Me.LblStaffSurname.TabIndex = 1
        Me.LblStaffSurname.Text = "StaffSurname"
        '
        'LblStaffEmail
        '
        Me.LblStaffEmail.AutoSize = True
        Me.LblStaffEmail.Location = New System.Drawing.Point(31, 147)
        Me.LblStaffEmail.Name = "LblStaffEmail"
        Me.LblStaffEmail.Size = New System.Drawing.Size(54, 13)
        Me.LblStaffEmail.TabIndex = 2
        Me.LblStaffEmail.Text = "StaffEmail"
        '
        'LblStaffPassword
        '
        Me.LblStaffPassword.AutoSize = True
        Me.LblStaffPassword.Location = New System.Drawing.Point(31, 252)
        Me.LblStaffPassword.Name = "LblStaffPassword"
        Me.LblStaffPassword.Size = New System.Drawing.Size(75, 13)
        Me.LblStaffPassword.TabIndex = 3
        Me.LblStaffPassword.Text = "StaffPassword"
        '
        'LblStaffUsername
        '
        Me.LblStaffUsername.AutoSize = True
        Me.LblStaffUsername.Location = New System.Drawing.Point(31, 219)
        Me.LblStaffUsername.Name = "LblStaffUsername"
        Me.LblStaffUsername.Size = New System.Drawing.Size(77, 13)
        Me.LblStaffUsername.TabIndex = 4
        Me.LblStaffUsername.Text = "StaffUsername"
        '
        'LblStaffFirstName
        '
        Me.LblStaffFirstName.AutoSize = True
        Me.LblStaffFirstName.Location = New System.Drawing.Point(31, 75)
        Me.LblStaffFirstName.Name = "LblStaffFirstName"
        Me.LblStaffFirstName.Size = New System.Drawing.Size(76, 13)
        Me.LblStaffFirstName.TabIndex = 9
        Me.LblStaffFirstName.Text = "StaffFirstName"
        '
        'LblAccessLevel
        '
        Me.LblAccessLevel.AutoSize = True
        Me.LblAccessLevel.Location = New System.Drawing.Point(31, 286)
        Me.LblAccessLevel.Name = "LblAccessLevel"
        Me.LblAccessLevel.Size = New System.Drawing.Size(63, 13)
        Me.LblAccessLevel.TabIndex = 10
        Me.LblAccessLevel.Text = "AccesLevel"
        '
        'LblStaffTelephone
        '
        Me.LblStaffTelephone.AutoSize = True
        Me.LblStaffTelephone.Location = New System.Drawing.Point(31, 183)
        Me.LblStaffTelephone.Name = "LblStaffTelephone"
        Me.LblStaffTelephone.Size = New System.Drawing.Size(80, 13)
        Me.LblStaffTelephone.TabIndex = 11
        Me.LblStaffTelephone.Text = "StaffTelephone"
        '
        'TbxStaffID
        '
        Me.TbxStaffID.Location = New System.Drawing.Point(143, 30)
        Me.TbxStaffID.Name = "TbxStaffID"
        Me.TbxStaffID.Size = New System.Drawing.Size(361, 20)
        Me.TbxStaffID.TabIndex = 14
        '
        'TbxStaffFirstName
        '
        Me.TbxStaffFirstName.Location = New System.Drawing.Point(143, 68)
        Me.TbxStaffFirstName.Name = "TbxStaffFirstName"
        Me.TbxStaffFirstName.Size = New System.Drawing.Size(361, 20)
        Me.TbxStaffFirstName.TabIndex = 15
        '
        'TbxStaffTelephone
        '
        Me.TbxStaffTelephone.Location = New System.Drawing.Point(143, 176)
        Me.TbxStaffTelephone.Name = "TbxStaffTelephone"
        Me.TbxStaffTelephone.Size = New System.Drawing.Size(361, 20)
        Me.TbxStaffTelephone.TabIndex = 16
        '
        'TbxStaffSurname
        '
        Me.TbxStaffSurname.Location = New System.Drawing.Point(143, 104)
        Me.TbxStaffSurname.Name = "TbxStaffSurname"
        Me.TbxStaffSurname.Size = New System.Drawing.Size(361, 20)
        Me.TbxStaffSurname.TabIndex = 17
        '
        'TbxStaffEmail
        '
        Me.TbxStaffEmail.Location = New System.Drawing.Point(143, 140)
        Me.TbxStaffEmail.Name = "TbxStaffEmail"
        Me.TbxStaffEmail.Size = New System.Drawing.Size(361, 20)
        Me.TbxStaffEmail.TabIndex = 18
        '
        'TbxAccessLevel
        '
        Me.TbxAccessLevel.Location = New System.Drawing.Point(143, 279)
        Me.TbxAccessLevel.Name = "TbxAccessLevel"
        Me.TbxAccessLevel.Size = New System.Drawing.Size(361, 20)
        Me.TbxAccessLevel.TabIndex = 19
        '
        'TbxStaffUsername
        '
        Me.TbxStaffUsername.Location = New System.Drawing.Point(143, 212)
        Me.TbxStaffUsername.Name = "TbxStaffUsername"
        Me.TbxStaffUsername.Size = New System.Drawing.Size(361, 20)
        Me.TbxStaffUsername.TabIndex = 20
        '
        'TbxStaffPassword
        '
        Me.TbxStaffPassword.Location = New System.Drawing.Point(143, 245)
        Me.TbxStaffPassword.Name = "TbxStaffPassword"
        Me.TbxStaffPassword.Size = New System.Drawing.Size(361, 20)
        Me.TbxStaffPassword.TabIndex = 21
        '
        'BtnNextStaff
        '
        Me.BtnNextStaff.Location = New System.Drawing.Point(524, 152)
        Me.BtnNextStaff.Name = "BtnNextStaff"
        Me.BtnNextStaff.Size = New System.Drawing.Size(133, 42)
        Me.BtnNextStaff.TabIndex = 73
        Me.BtnNextStaff.Text = "Next staff"
        Me.BtnNextStaff.UseVisualStyleBackColor = True
        '
        'BtnClearStaffDetails
        '
        Me.BtnClearStaffDetails.Location = New System.Drawing.Point(524, 56)
        Me.BtnClearStaffDetails.Name = "BtnClearStaffDetails"
        Me.BtnClearStaffDetails.Size = New System.Drawing.Size(133, 42)
        Me.BtnClearStaffDetails.TabIndex = 74
        Me.BtnClearStaffDetails.Text = "Clear staff details"
        Me.BtnClearStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnFirstStaffDetails
        '
        Me.BtnFirstStaffDetails.Location = New System.Drawing.Point(524, 104)
        Me.BtnFirstStaffDetails.Name = "BtnFirstStaffDetails"
        Me.BtnFirstStaffDetails.Size = New System.Drawing.Size(133, 42)
        Me.BtnFirstStaffDetails.TabIndex = 75
        Me.BtnFirstStaffDetails.Text = "First staff details"
        Me.BtnFirstStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnAddStaffDetails
        '
        Me.BtnAddStaffDetails.Location = New System.Drawing.Point(34, 305)
        Me.BtnAddStaffDetails.Name = "BtnAddStaffDetails"
        Me.BtnAddStaffDetails.Size = New System.Drawing.Size(152, 42)
        Me.BtnAddStaffDetails.TabIndex = 76
        Me.BtnAddStaffDetails.Text = "Add staff details"
        Me.BtnAddStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnDeleteStaffDetails
        '
        Me.BtnDeleteStaffDetails.Location = New System.Drawing.Point(192, 305)
        Me.BtnDeleteStaffDetails.Name = "BtnDeleteStaffDetails"
        Me.BtnDeleteStaffDetails.Size = New System.Drawing.Size(152, 42)
        Me.BtnDeleteStaffDetails.TabIndex = 77
        Me.BtnDeleteStaffDetails.Text = "Delete staff details"
        Me.BtnDeleteStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnUpdateStaffDetails
        '
        Me.BtnUpdateStaffDetails.Location = New System.Drawing.Point(352, 305)
        Me.BtnUpdateStaffDetails.Name = "BtnUpdateStaffDetails"
        Me.BtnUpdateStaffDetails.Size = New System.Drawing.Size(152, 42)
        Me.BtnUpdateStaffDetails.TabIndex = 78
        Me.BtnUpdateStaffDetails.Text = "Update staff details"
        Me.BtnUpdateStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnBackToMenu
        '
        Me.BtnBackToMenu.Location = New System.Drawing.Point(524, 305)
        Me.BtnBackToMenu.Name = "BtnBackToMenu"
        Me.BtnBackToMenu.Size = New System.Drawing.Size(133, 42)
        Me.BtnBackToMenu.TabIndex = 79
        Me.BtnBackToMenu.Text = "Back to menu"
        Me.BtnBackToMenu.UseVisualStyleBackColor = True
        '
        'BtnCancelProcess
        '
        Me.BtnCancelProcess.Location = New System.Drawing.Point(524, 8)
        Me.BtnCancelProcess.Name = "BtnCancelProcess"
        Me.BtnCancelProcess.Size = New System.Drawing.Size(133, 42)
        Me.BtnCancelProcess.TabIndex = 80
        Me.BtnCancelProcess.Text = "Cancel process"
        Me.BtnCancelProcess.UseVisualStyleBackColor = True
        '
        'BtnPreviousStaff
        '
        Me.BtnPreviousStaff.Location = New System.Drawing.Point(524, 200)
        Me.BtnPreviousStaff.Name = "BtnPreviousStaff"
        Me.BtnPreviousStaff.Size = New System.Drawing.Size(133, 42)
        Me.BtnPreviousStaff.TabIndex = 81
        Me.BtnPreviousStaff.Text = "Previous staff"
        Me.BtnPreviousStaff.UseVisualStyleBackColor = True
        '
        'BtnLastStaffDetails
        '
        Me.BtnLastStaffDetails.Location = New System.Drawing.Point(524, 250)
        Me.BtnLastStaffDetails.Name = "BtnLastStaffDetails"
        Me.BtnLastStaffDetails.Size = New System.Drawing.Size(133, 42)
        Me.BtnLastStaffDetails.TabIndex = 82
        Me.BtnLastStaffDetails.Text = "Last staff details"
        Me.BtnLastStaffDetails.UseVisualStyleBackColor = True
        '
        'LblStaffIDError
        '
        Me.LblStaffIDError.AutoSize = True
        Me.LblStaffIDError.ForeColor = System.Drawing.Color.Red
        Me.LblStaffIDError.Location = New System.Drawing.Point(140, 14)
        Me.LblStaffIDError.Name = "LblStaffIDError"
        Me.LblStaffIDError.Size = New System.Drawing.Size(62, 13)
        Me.LblStaffIDError.TabIndex = 83
        Me.LblStaffIDError.Text = "StaffIDError"
        '
        'LblFirstnameError
        '
        Me.LblFirstnameError.AutoSize = True
        Me.LblFirstnameError.ForeColor = System.Drawing.Color.Red
        Me.LblFirstnameError.Location = New System.Drawing.Point(140, 53)
        Me.LblFirstnameError.Name = "LblFirstnameError"
        Me.LblFirstnameError.Size = New System.Drawing.Size(74, 13)
        Me.LblFirstnameError.TabIndex = 84
        Me.LblFirstnameError.Text = "FirstnameError"
        '
        'LblSurnameError
        '
        Me.LblSurnameError.AutoSize = True
        Me.LblSurnameError.ForeColor = System.Drawing.Color.Red
        Me.LblSurnameError.Location = New System.Drawing.Point(140, 91)
        Me.LblSurnameError.Name = "LblSurnameError"
        Me.LblSurnameError.Size = New System.Drawing.Size(71, 13)
        Me.LblSurnameError.TabIndex = 85
        Me.LblSurnameError.Text = "SurnameError"
        '
        'LblStaffEmailError
        '
        Me.LblStaffEmailError.AutoSize = True
        Me.LblStaffEmailError.ForeColor = System.Drawing.Color.Red
        Me.LblStaffEmailError.Location = New System.Drawing.Point(140, 127)
        Me.LblStaffEmailError.Name = "LblStaffEmailError"
        Me.LblStaffEmailError.Size = New System.Drawing.Size(76, 13)
        Me.LblStaffEmailError.TabIndex = 86
        Me.LblStaffEmailError.Text = "StaffEmailError"
        '
        'LblTelephoneError
        '
        Me.LblTelephoneError.AutoSize = True
        Me.LblTelephoneError.ForeColor = System.Drawing.Color.Red
        Me.LblTelephoneError.Location = New System.Drawing.Point(140, 163)
        Me.LblTelephoneError.Name = "LblTelephoneError"
        Me.LblTelephoneError.Size = New System.Drawing.Size(80, 13)
        Me.LblTelephoneError.TabIndex = 87
        Me.LblTelephoneError.Text = "TelephoneError"
        '
        'LblStaffUsernameError
        '
        Me.LblStaffUsernameError.AutoSize = True
        Me.LblStaffUsernameError.ForeColor = System.Drawing.Color.Red
        Me.LblStaffUsernameError.Location = New System.Drawing.Point(140, 199)
        Me.LblStaffUsernameError.Name = "LblStaffUsernameError"
        Me.LblStaffUsernameError.Size = New System.Drawing.Size(99, 13)
        Me.LblStaffUsernameError.TabIndex = 88
        Me.LblStaffUsernameError.Text = "StaffUsernameError"
        '
        'LblStaffPasswordError
        '
        Me.LblStaffPasswordError.AutoSize = True
        Me.LblStaffPasswordError.ForeColor = System.Drawing.Color.Red
        Me.LblStaffPasswordError.Location = New System.Drawing.Point(140, 232)
        Me.LblStaffPasswordError.Name = "LblStaffPasswordError"
        Me.LblStaffPasswordError.Size = New System.Drawing.Size(97, 13)
        Me.LblStaffPasswordError.TabIndex = 89
        Me.LblStaffPasswordError.Text = "StaffPasswordError"
        '
        'LblAccessLevelError
        '
        Me.LblAccessLevelError.AutoSize = True
        Me.LblAccessLevelError.ForeColor = System.Drawing.Color.Red
        Me.LblAccessLevelError.Location = New System.Drawing.Point(140, 265)
        Me.LblAccessLevelError.Name = "LblAccessLevelError"
        Me.LblAccessLevelError.Size = New System.Drawing.Size(90, 13)
        Me.LblAccessLevelError.TabIndex = 90
        Me.LblAccessLevelError.Text = "AccessLevelError"
        '
        'StaffAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(669, 348)
        Me.Controls.Add(Me.LblAccessLevelError)
        Me.Controls.Add(Me.LblStaffPasswordError)
        Me.Controls.Add(Me.LblStaffUsernameError)
        Me.Controls.Add(Me.LblTelephoneError)
        Me.Controls.Add(Me.LblStaffEmailError)
        Me.Controls.Add(Me.LblSurnameError)
        Me.Controls.Add(Me.LblFirstnameError)
        Me.Controls.Add(Me.LblStaffIDError)
        Me.Controls.Add(Me.BtnLastStaffDetails)
        Me.Controls.Add(Me.BtnPreviousStaff)
        Me.Controls.Add(Me.BtnCancelProcess)
        Me.Controls.Add(Me.BtnBackToMenu)
        Me.Controls.Add(Me.BtnUpdateStaffDetails)
        Me.Controls.Add(Me.BtnDeleteStaffDetails)
        Me.Controls.Add(Me.BtnAddStaffDetails)
        Me.Controls.Add(Me.BtnFirstStaffDetails)
        Me.Controls.Add(Me.BtnClearStaffDetails)
        Me.Controls.Add(Me.BtnNextStaff)
        Me.Controls.Add(Me.TbxStaffPassword)
        Me.Controls.Add(Me.TbxStaffUsername)
        Me.Controls.Add(Me.TbxAccessLevel)
        Me.Controls.Add(Me.TbxStaffEmail)
        Me.Controls.Add(Me.TbxStaffSurname)
        Me.Controls.Add(Me.TbxStaffTelephone)
        Me.Controls.Add(Me.TbxStaffFirstName)
        Me.Controls.Add(Me.TbxStaffID)
        Me.Controls.Add(Me.LblStaffTelephone)
        Me.Controls.Add(Me.LblAccessLevel)
        Me.Controls.Add(Me.LblStaffFirstName)
        Me.Controls.Add(Me.LblStaffUsername)
        Me.Controls.Add(Me.LblStaffPassword)
        Me.Controls.Add(Me.LblStaffEmail)
        Me.Controls.Add(Me.LblStaffSurname)
        Me.Controls.Add(Me.LblStaffID)
        Me.Name = "StaffAdd"
        Me.Text = "vbcvc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblStaffID As Label
    Friend WithEvents LblStaffSurname As Label
    Friend WithEvents LblStaffEmail As Label
    Friend WithEvents LblStaffPassword As Label
    Friend WithEvents LblStaffUsername As Label
    Friend WithEvents LblStaffFirstName As Label
    Friend WithEvents LblAccessLevel As Label
    Friend WithEvents LblStaffTelephone As Label
    Friend WithEvents TbxStaffID As TextBox
    Friend WithEvents TbxStaffFirstName As TextBox
    Friend WithEvents TbxStaffTelephone As TextBox
    Friend WithEvents TbxStaffSurname As TextBox
    Friend WithEvents TbxStaffEmail As TextBox
    Friend WithEvents TbxAccessLevel As TextBox
    Friend WithEvents TbxStaffUsername As TextBox
    Friend WithEvents TbxStaffPassword As TextBox
    Friend WithEvents BtnNextStaff As Button
    Friend WithEvents BtnClearStaffDetails As Button
    Friend WithEvents BtnFirstStaffDetails As Button
    Friend WithEvents BtnAddStaffDetails As Button
    Friend WithEvents BtnDeleteStaffDetails As Button
    Friend WithEvents BtnUpdateStaffDetails As Button
    Friend WithEvents BtnBackToMenu As Button
    Friend WithEvents BtnCancelProcess As Button
    Friend WithEvents BtnPreviousStaff As Button
    Friend WithEvents BtnLastStaffDetails As Button
    Friend WithEvents LblStaffIDError As Label
    Friend WithEvents LblFirstnameError As Label
    Friend WithEvents LblSurnameError As Label
    Friend WithEvents LblStaffEmailError As Label
    Friend WithEvents LblTelephoneError As Label
    Friend WithEvents LblStaffUsernameError As Label
    Friend WithEvents LblStaffPasswordError As Label
    Friend WithEvents LblAccessLevelError As Label
End Class
