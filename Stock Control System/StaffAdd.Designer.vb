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
        Me.BtnUpdateStaffDetails = New System.Windows.Forms.Button()
        Me.BtnAddStaffDetails = New System.Windows.Forms.Button()
        Me.BtnDeleteStaffDetails = New System.Windows.Forms.Button()
        Me.BtnBackToMenu = New System.Windows.Forms.Button()
        Me.BtnLastStaffDetails = New System.Windows.Forms.Button()
        Me.BtnPreviousStaff = New System.Windows.Forms.Button()
        Me.BtnNextStaff = New System.Windows.Forms.Button()
        Me.BtnFirstStaffDetails = New System.Windows.Forms.Button()
        Me.BtnClearStaffDetails = New System.Windows.Forms.Button()
        Me.BtnCancelProcess = New System.Windows.Forms.Button()
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
        Me.LblStaffID.Location = New System.Drawing.Point(123, 32)
        Me.LblStaffID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStaffID.Name = "LblStaffID"
        Me.LblStaffID.Size = New System.Drawing.Size(46, 16)
        Me.LblStaffID.TabIndex = 0
        Me.LblStaffID.Text = "StaffID"
        '
        'LblStaffSurname
        '
        Me.LblStaffSurname.AutoSize = True
        Me.LblStaffSurname.Location = New System.Drawing.Point(123, 128)
        Me.LblStaffSurname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStaffSurname.Name = "LblStaffSurname"
        Me.LblStaffSurname.Size = New System.Drawing.Size(87, 16)
        Me.LblStaffSurname.TabIndex = 1
        Me.LblStaffSurname.Text = "StaffSurname"
        '
        'LblStaffEmail
        '
        Me.LblStaffEmail.AutoSize = True
        Me.LblStaffEmail.Location = New System.Drawing.Point(123, 171)
        Me.LblStaffEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStaffEmail.Name = "LblStaffEmail"
        Me.LblStaffEmail.Size = New System.Drawing.Size(67, 16)
        Me.LblStaffEmail.TabIndex = 2
        Me.LblStaffEmail.Text = "StaffEmail"
        '
        'LblStaffPassword
        '
        Me.LblStaffPassword.AutoSize = True
        Me.LblStaffPassword.Location = New System.Drawing.Point(123, 305)
        Me.LblStaffPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStaffPassword.Name = "LblStaffPassword"
        Me.LblStaffPassword.Size = New System.Drawing.Size(93, 16)
        Me.LblStaffPassword.TabIndex = 3
        Me.LblStaffPassword.Text = "StaffPassword"
        '
        'LblStaffUsername
        '
        Me.LblStaffUsername.AutoSize = True
        Me.LblStaffUsername.Location = New System.Drawing.Point(123, 261)
        Me.LblStaffUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStaffUsername.Name = "LblStaffUsername"
        Me.LblStaffUsername.Size = New System.Drawing.Size(96, 16)
        Me.LblStaffUsername.TabIndex = 4
        Me.LblStaffUsername.Text = "StaffUsername"
        '
        'LblStaffFirstName
        '
        Me.LblStaffFirstName.AutoSize = True
        Me.LblStaffFirstName.Location = New System.Drawing.Point(123, 79)
        Me.LblStaffFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStaffFirstName.Name = "LblStaffFirstName"
        Me.LblStaffFirstName.Size = New System.Drawing.Size(95, 16)
        Me.LblStaffFirstName.TabIndex = 9
        Me.LblStaffFirstName.Text = "StaffFirstName"
        '
        'LblAccessLevel
        '
        Me.LblAccessLevel.AutoSize = True
        Me.LblAccessLevel.Location = New System.Drawing.Point(123, 352)
        Me.LblAccessLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAccessLevel.Name = "LblAccessLevel"
        Me.LblAccessLevel.Size = New System.Drawing.Size(78, 16)
        Me.LblAccessLevel.TabIndex = 10
        Me.LblAccessLevel.Text = "AccesLevel"
        '
        'LblStaffTelephone
        '
        Me.LblStaffTelephone.AutoSize = True
        Me.LblStaffTelephone.Location = New System.Drawing.Point(123, 217)
        Me.LblStaffTelephone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStaffTelephone.Name = "LblStaffTelephone"
        Me.LblStaffTelephone.Size = New System.Drawing.Size(99, 16)
        Me.LblStaffTelephone.TabIndex = 11
        Me.LblStaffTelephone.Text = "StaffTelephone"
        '
        'TbxStaffID
        '
        Me.TbxStaffID.Location = New System.Drawing.Point(329, 23)
        Me.TbxStaffID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbxStaffID.Name = "TbxStaffID"
        Me.TbxStaffID.Size = New System.Drawing.Size(347, 22)
        Me.TbxStaffID.TabIndex = 14
        '
        'TbxStaffFirstName
        '
        Me.TbxStaffFirstName.Location = New System.Drawing.Point(329, 75)
        Me.TbxStaffFirstName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbxStaffFirstName.Name = "TbxStaffFirstName"
        Me.TbxStaffFirstName.Size = New System.Drawing.Size(347, 22)
        Me.TbxStaffFirstName.TabIndex = 15
        '
        'TbxStaffTelephone
        '
        Me.TbxStaffTelephone.Location = New System.Drawing.Point(329, 208)
        Me.TbxStaffTelephone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbxStaffTelephone.Name = "TbxStaffTelephone"
        Me.TbxStaffTelephone.Size = New System.Drawing.Size(347, 22)
        Me.TbxStaffTelephone.TabIndex = 16
        '
        'TbxStaffSurname
        '
        Me.TbxStaffSurname.Location = New System.Drawing.Point(329, 119)
        Me.TbxStaffSurname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbxStaffSurname.Name = "TbxStaffSurname"
        Me.TbxStaffSurname.Size = New System.Drawing.Size(347, 22)
        Me.TbxStaffSurname.TabIndex = 17
        '
        'TbxStaffEmail
        '
        Me.TbxStaffEmail.Location = New System.Drawing.Point(329, 162)
        Me.TbxStaffEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbxStaffEmail.Name = "TbxStaffEmail"
        Me.TbxStaffEmail.Size = New System.Drawing.Size(347, 22)
        Me.TbxStaffEmail.TabIndex = 18
        '
        'TbxAccessLevel
        '
        Me.TbxAccessLevel.Location = New System.Drawing.Point(329, 343)
        Me.TbxAccessLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbxAccessLevel.Name = "TbxAccessLevel"
        Me.TbxAccessLevel.Size = New System.Drawing.Size(347, 22)
        Me.TbxAccessLevel.TabIndex = 19
        '
        'TbxStaffUsername
        '
        Me.TbxStaffUsername.Location = New System.Drawing.Point(329, 252)
        Me.TbxStaffUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbxStaffUsername.Name = "TbxStaffUsername"
        Me.TbxStaffUsername.Size = New System.Drawing.Size(347, 22)
        Me.TbxStaffUsername.TabIndex = 20
        '
        'TbxStaffPassword
        '
        Me.TbxStaffPassword.Location = New System.Drawing.Point(329, 297)
        Me.TbxStaffPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbxStaffPassword.Name = "TbxStaffPassword"
        Me.TbxStaffPassword.Size = New System.Drawing.Size(347, 22)
        Me.TbxStaffPassword.TabIndex = 21
        '
        'BtnUpdateStaffDetails
        '
        Me.BtnUpdateStaffDetails.Location = New System.Drawing.Point(485, 375)
        Me.BtnUpdateStaffDetails.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnUpdateStaffDetails.Name = "BtnUpdateStaffDetails"
        Me.BtnUpdateStaffDetails.Size = New System.Drawing.Size(192, 50)
        Me.BtnUpdateStaffDetails.TabIndex = 73
        Me.BtnUpdateStaffDetails.Text = "Update Staff Details"
        Me.BtnUpdateStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnAddStaffDetails
        '
        Me.BtnAddStaffDetails.Location = New System.Drawing.Point(52, 375)
        Me.BtnAddStaffDetails.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAddStaffDetails.Name = "BtnAddStaffDetails"
        Me.BtnAddStaffDetails.Size = New System.Drawing.Size(192, 50)
        Me.BtnAddStaffDetails.TabIndex = 74
        Me.BtnAddStaffDetails.Text = "Add Staff Details"
        Me.BtnAddStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnDeleteStaffDetails
        '
        Me.BtnDeleteStaffDetails.Location = New System.Drawing.Point(265, 375)
        Me.BtnDeleteStaffDetails.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnDeleteStaffDetails.Name = "BtnDeleteStaffDetails"
        Me.BtnDeleteStaffDetails.Size = New System.Drawing.Size(192, 50)
        Me.BtnDeleteStaffDetails.TabIndex = 75
        Me.BtnDeleteStaffDetails.Text = "Delete Staff Details"
        Me.BtnDeleteStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnBackToMenu
        '
        Me.BtnBackToMenu.Location = New System.Drawing.Point(711, 375)
        Me.BtnBackToMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnBackToMenu.Name = "BtnBackToMenu"
        Me.BtnBackToMenu.Size = New System.Drawing.Size(165, 50)
        Me.BtnBackToMenu.TabIndex = 76
        Me.BtnBackToMenu.Text = "Back To Menu"
        Me.BtnBackToMenu.UseVisualStyleBackColor = True
        '
        'BtnLastStaffDetails
        '
        Me.BtnLastStaffDetails.Location = New System.Drawing.Point(711, 318)
        Me.BtnLastStaffDetails.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLastStaffDetails.Name = "BtnLastStaffDetails"
        Me.BtnLastStaffDetails.Size = New System.Drawing.Size(165, 50)
        Me.BtnLastStaffDetails.TabIndex = 77
        Me.BtnLastStaffDetails.Text = "Last Staff Details"
        Me.BtnLastStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnPreviousStaff
        '
        Me.BtnPreviousStaff.Location = New System.Drawing.Point(711, 260)
        Me.BtnPreviousStaff.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnPreviousStaff.Name = "BtnPreviousStaff"
        Me.BtnPreviousStaff.Size = New System.Drawing.Size(165, 50)
        Me.BtnPreviousStaff.TabIndex = 78
        Me.BtnPreviousStaff.Text = "Previous Staff"
        Me.BtnPreviousStaff.UseVisualStyleBackColor = True
        '
        'BtnNextStaff
        '
        Me.BtnNextStaff.Location = New System.Drawing.Point(711, 202)
        Me.BtnNextStaff.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnNextStaff.Name = "BtnNextStaff"
        Me.BtnNextStaff.Size = New System.Drawing.Size(165, 50)
        Me.BtnNextStaff.TabIndex = 79
        Me.BtnNextStaff.Text = "Next Staff"
        Me.BtnNextStaff.UseVisualStyleBackColor = True
        '
        'BtnFirstStaffDetails
        '
        Me.BtnFirstStaffDetails.Location = New System.Drawing.Point(711, 143)
        Me.BtnFirstStaffDetails.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnFirstStaffDetails.Name = "BtnFirstStaffDetails"
        Me.BtnFirstStaffDetails.Size = New System.Drawing.Size(165, 50)
        Me.BtnFirstStaffDetails.TabIndex = 80
        Me.BtnFirstStaffDetails.Text = "First Staff Details"
        Me.BtnFirstStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnClearStaffDetails
        '
        Me.BtnClearStaffDetails.Location = New System.Drawing.Point(711, 85)
        Me.BtnClearStaffDetails.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnClearStaffDetails.Name = "BtnClearStaffDetails"
        Me.BtnClearStaffDetails.Size = New System.Drawing.Size(165, 50)
        Me.BtnClearStaffDetails.TabIndex = 81
        Me.BtnClearStaffDetails.Text = "Clear Staff Details"
        Me.BtnClearStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnCancelProcess
        '
        Me.BtnCancelProcess.Location = New System.Drawing.Point(711, 27)
        Me.BtnCancelProcess.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCancelProcess.Name = "BtnCancelProcess"
        Me.BtnCancelProcess.Size = New System.Drawing.Size(165, 50)
        Me.BtnCancelProcess.TabIndex = 82
        Me.BtnCancelProcess.Text = "Cancel Process"
        Me.BtnCancelProcess.UseVisualStyleBackColor = True
        '
        'LblStaffIDError
        '
        Me.LblStaffIDError.AutoSize = True
        Me.LblStaffIDError.ForeColor = System.Drawing.Color.Red
        Me.LblStaffIDError.Location = New System.Drawing.Point(325, 4)
        Me.LblStaffIDError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStaffIDError.Name = "LblStaffIDError"
        Me.LblStaffIDError.Size = New System.Drawing.Size(75, 16)
        Me.LblStaffIDError.TabIndex = 83
        Me.LblStaffIDError.Text = "StaffIDError"
        '
        'LblFirstnameError
        '
        Me.LblFirstnameError.AutoSize = True
        Me.LblFirstnameError.ForeColor = System.Drawing.Color.Red
        Me.LblFirstnameError.Location = New System.Drawing.Point(325, 55)
        Me.LblFirstnameError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFirstnameError.Name = "LblFirstnameError"
        Me.LblFirstnameError.Size = New System.Drawing.Size(95, 16)
        Me.LblFirstnameError.TabIndex = 84
        Me.LblFirstnameError.Text = "FirstnameError"
        '
        'LblSurnameError
        '
        Me.LblSurnameError.AutoSize = True
        Me.LblSurnameError.ForeColor = System.Drawing.Color.Red
        Me.LblSurnameError.Location = New System.Drawing.Point(325, 100)
        Me.LblSurnameError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSurnameError.Name = "LblSurnameError"
        Me.LblSurnameError.Size = New System.Drawing.Size(90, 16)
        Me.LblSurnameError.TabIndex = 85
        Me.LblSurnameError.Text = "SurnameError"
        '
        'LblStaffEmailError
        '
        Me.LblStaffEmailError.AutoSize = True
        Me.LblStaffEmailError.ForeColor = System.Drawing.Color.Red
        Me.LblStaffEmailError.Location = New System.Drawing.Point(325, 143)
        Me.LblStaffEmailError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStaffEmailError.Name = "LblStaffEmailError"
        Me.LblStaffEmailError.Size = New System.Drawing.Size(96, 16)
        Me.LblStaffEmailError.TabIndex = 86
        Me.LblStaffEmailError.Text = "StaffEmailError"
        '
        'LblTelephoneError
        '
        Me.LblTelephoneError.AutoSize = True
        Me.LblTelephoneError.ForeColor = System.Drawing.Color.Red
        Me.LblTelephoneError.Location = New System.Drawing.Point(325, 191)
        Me.LblTelephoneError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTelephoneError.Name = "LblTelephoneError"
        Me.LblTelephoneError.Size = New System.Drawing.Size(102, 16)
        Me.LblTelephoneError.TabIndex = 87
        Me.LblTelephoneError.Text = "TelephoneError"
        '
        'LblStaffUsernameError
        '
        Me.LblStaffUsernameError.AutoSize = True
        Me.LblStaffUsernameError.ForeColor = System.Drawing.Color.Red
        Me.LblStaffUsernameError.Location = New System.Drawing.Point(325, 236)
        Me.LblStaffUsernameError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStaffUsernameError.Name = "LblStaffUsernameError"
        Me.LblStaffUsernameError.Size = New System.Drawing.Size(125, 16)
        Me.LblStaffUsernameError.TabIndex = 88
        Me.LblStaffUsernameError.Text = "StaffUsernameError"
        '
        'LblStaffPasswordError
        '
        Me.LblStaffPasswordError.AutoSize = True
        Me.LblStaffPasswordError.ForeColor = System.Drawing.Color.Red
        Me.LblStaffPasswordError.Location = New System.Drawing.Point(325, 277)
        Me.LblStaffPasswordError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStaffPasswordError.Name = "LblStaffPasswordError"
        Me.LblStaffPasswordError.Size = New System.Drawing.Size(122, 16)
        Me.LblStaffPasswordError.TabIndex = 89
        Me.LblStaffPasswordError.Text = "StaffPasswordError"
        '
        'LblAccessLevelError
        '
        Me.LblAccessLevelError.AutoSize = True
        Me.LblAccessLevelError.ForeColor = System.Drawing.Color.Red
        Me.LblAccessLevelError.Location = New System.Drawing.Point(325, 324)
        Me.LblAccessLevelError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAccessLevelError.Name = "LblAccessLevelError"
        Me.LblAccessLevelError.Size = New System.Drawing.Size(114, 16)
        Me.LblAccessLevelError.TabIndex = 90
        Me.LblAccessLevelError.Text = "AccessLevelError"
        '
        'StaffAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(892, 428)
        Me.Controls.Add(Me.LblAccessLevelError)
        Me.Controls.Add(Me.LblStaffPasswordError)
        Me.Controls.Add(Me.LblStaffUsernameError)
        Me.Controls.Add(Me.LblTelephoneError)
        Me.Controls.Add(Me.LblStaffEmailError)
        Me.Controls.Add(Me.LblSurnameError)
        Me.Controls.Add(Me.LblFirstnameError)
        Me.Controls.Add(Me.LblStaffIDError)
        Me.Controls.Add(Me.BtnCancelProcess)
        Me.Controls.Add(Me.BtnClearStaffDetails)
        Me.Controls.Add(Me.BtnFirstStaffDetails)
        Me.Controls.Add(Me.BtnNextStaff)
        Me.Controls.Add(Me.BtnPreviousStaff)
        Me.Controls.Add(Me.BtnLastStaffDetails)
        Me.Controls.Add(Me.BtnBackToMenu)
        Me.Controls.Add(Me.BtnDeleteStaffDetails)
        Me.Controls.Add(Me.BtnAddStaffDetails)
        Me.Controls.Add(Me.BtnUpdateStaffDetails)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "StaffAdd"
        Me.Text = "StaffAdd"
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
    Friend WithEvents BtnUpdateStaffDetails As Button
    Friend WithEvents BtnAddStaffDetails As Button
    Friend WithEvents BtnDeleteStaffDetails As Button
    Friend WithEvents BtnBackToMenu As Button
    Friend WithEvents BtnLastStaffDetails As Button
    Friend WithEvents BtnPreviousStaff As Button
    Friend WithEvents BtnNextStaff As Button
    Friend WithEvents BtnFirstStaffDetails As Button
    Friend WithEvents BtnClearStaffDetails As Button
    Friend WithEvents BtnCancelProcess As Button
    Friend WithEvents LblStaffIDError As Label
    Friend WithEvents LblFirstnameError As Label
    Friend WithEvents LblSurnameError As Label
    Friend WithEvents LblStaffEmailError As Label
    Friend WithEvents LblTelephoneError As Label
    Friend WithEvents LblStaffUsernameError As Label
    Friend WithEvents LblStaffPasswordError As Label
    Friend WithEvents LblAccessLevelError As Label
End Class
