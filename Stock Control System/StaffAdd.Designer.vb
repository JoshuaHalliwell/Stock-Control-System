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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblStaffID
        '
        Me.LblStaffID.AutoSize = True
        Me.LblStaffID.Location = New System.Drawing.Point(92, 26)
        Me.LblStaffID.Name = "LblStaffID"
        Me.LblStaffID.Size = New System.Drawing.Size(40, 13)
        Me.LblStaffID.TabIndex = 0
        Me.LblStaffID.Text = "StaffID"
        '
        'LblStaffSurname
        '
        Me.LblStaffSurname.AutoSize = True
        Me.LblStaffSurname.Location = New System.Drawing.Point(92, 104)
        Me.LblStaffSurname.Name = "LblStaffSurname"
        Me.LblStaffSurname.Size = New System.Drawing.Size(71, 13)
        Me.LblStaffSurname.TabIndex = 1
        Me.LblStaffSurname.Text = "StaffSurname"
        '
        'LblStaffEmail
        '
        Me.LblStaffEmail.AutoSize = True
        Me.LblStaffEmail.Location = New System.Drawing.Point(92, 139)
        Me.LblStaffEmail.Name = "LblStaffEmail"
        Me.LblStaffEmail.Size = New System.Drawing.Size(54, 13)
        Me.LblStaffEmail.TabIndex = 2
        Me.LblStaffEmail.Text = "StaffEmail"
        '
        'LblStaffPassword
        '
        Me.LblStaffPassword.AutoSize = True
        Me.LblStaffPassword.Location = New System.Drawing.Point(92, 248)
        Me.LblStaffPassword.Name = "LblStaffPassword"
        Me.LblStaffPassword.Size = New System.Drawing.Size(75, 13)
        Me.LblStaffPassword.TabIndex = 3
        Me.LblStaffPassword.Text = "StaffPassword"
        '
        'LblStaffUsername
        '
        Me.LblStaffUsername.AutoSize = True
        Me.LblStaffUsername.Location = New System.Drawing.Point(92, 212)
        Me.LblStaffUsername.Name = "LblStaffUsername"
        Me.LblStaffUsername.Size = New System.Drawing.Size(77, 13)
        Me.LblStaffUsername.TabIndex = 4
        Me.LblStaffUsername.Text = "StaffUsername"
        '
        'LblStaffFirstName
        '
        Me.LblStaffFirstName.AutoSize = True
        Me.LblStaffFirstName.Location = New System.Drawing.Point(92, 64)
        Me.LblStaffFirstName.Name = "LblStaffFirstName"
        Me.LblStaffFirstName.Size = New System.Drawing.Size(76, 13)
        Me.LblStaffFirstName.TabIndex = 9
        Me.LblStaffFirstName.Text = "StaffFirstName"
        '
        'LblAccessLevel
        '
        Me.LblAccessLevel.AutoSize = True
        Me.LblAccessLevel.Location = New System.Drawing.Point(92, 286)
        Me.LblAccessLevel.Name = "LblAccessLevel"
        Me.LblAccessLevel.Size = New System.Drawing.Size(63, 13)
        Me.LblAccessLevel.TabIndex = 10
        Me.LblAccessLevel.Text = "AccesLevel"
        '
        'LblStaffTelephone
        '
        Me.LblStaffTelephone.AutoSize = True
        Me.LblStaffTelephone.Location = New System.Drawing.Point(92, 176)
        Me.LblStaffTelephone.Name = "LblStaffTelephone"
        Me.LblStaffTelephone.Size = New System.Drawing.Size(80, 13)
        Me.LblStaffTelephone.TabIndex = 11
        Me.LblStaffTelephone.Text = "StaffTelephone"
        '
        'TbxStaffID
        '
        Me.TbxStaffID.Location = New System.Drawing.Point(247, 19)
        Me.TbxStaffID.Name = "TbxStaffID"
        Me.TbxStaffID.Size = New System.Drawing.Size(261, 20)
        Me.TbxStaffID.TabIndex = 14
        '
        'TbxStaffFirstName
        '
        Me.TbxStaffFirstName.Location = New System.Drawing.Point(247, 61)
        Me.TbxStaffFirstName.Name = "TbxStaffFirstName"
        Me.TbxStaffFirstName.Size = New System.Drawing.Size(261, 20)
        Me.TbxStaffFirstName.TabIndex = 15
        '
        'TbxStaffTelephone
        '
        Me.TbxStaffTelephone.Location = New System.Drawing.Point(247, 169)
        Me.TbxStaffTelephone.Name = "TbxStaffTelephone"
        Me.TbxStaffTelephone.Size = New System.Drawing.Size(261, 20)
        Me.TbxStaffTelephone.TabIndex = 16
        '
        'TbxStaffSurname
        '
        Me.TbxStaffSurname.Location = New System.Drawing.Point(247, 97)
        Me.TbxStaffSurname.Name = "TbxStaffSurname"
        Me.TbxStaffSurname.Size = New System.Drawing.Size(261, 20)
        Me.TbxStaffSurname.TabIndex = 17
        '
        'TbxStaffEmail
        '
        Me.TbxStaffEmail.Location = New System.Drawing.Point(247, 132)
        Me.TbxStaffEmail.Name = "TbxStaffEmail"
        Me.TbxStaffEmail.Size = New System.Drawing.Size(261, 20)
        Me.TbxStaffEmail.TabIndex = 18
        '
        'TbxAccessLevel
        '
        Me.TbxAccessLevel.Location = New System.Drawing.Point(247, 279)
        Me.TbxAccessLevel.Name = "TbxAccessLevel"
        Me.TbxAccessLevel.Size = New System.Drawing.Size(261, 20)
        Me.TbxAccessLevel.TabIndex = 19
        '
        'TbxStaffUsername
        '
        Me.TbxStaffUsername.Location = New System.Drawing.Point(247, 205)
        Me.TbxStaffUsername.Name = "TbxStaffUsername"
        Me.TbxStaffUsername.Size = New System.Drawing.Size(261, 20)
        Me.TbxStaffUsername.TabIndex = 20
        '
        'TbxStaffPassword
        '
        Me.TbxStaffPassword.Location = New System.Drawing.Point(247, 241)
        Me.TbxStaffPassword.Name = "TbxStaffPassword"
        Me.TbxStaffPassword.Size = New System.Drawing.Size(261, 20)
        Me.TbxStaffPassword.TabIndex = 21
        '
        'BtnUpdateStaffDetails
        '
        Me.BtnUpdateStaffDetails.Location = New System.Drawing.Point(364, 305)
        Me.BtnUpdateStaffDetails.Name = "BtnUpdateStaffDetails"
        Me.BtnUpdateStaffDetails.Size = New System.Drawing.Size(144, 41)
        Me.BtnUpdateStaffDetails.TabIndex = 73
        Me.BtnUpdateStaffDetails.Text = "Update Staff Details"
        Me.BtnUpdateStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnAddStaffDetails
        '
        Me.BtnAddStaffDetails.Location = New System.Drawing.Point(39, 305)
        Me.BtnAddStaffDetails.Name = "BtnAddStaffDetails"
        Me.BtnAddStaffDetails.Size = New System.Drawing.Size(144, 41)
        Me.BtnAddStaffDetails.TabIndex = 74
        Me.BtnAddStaffDetails.Text = "Add Staff Details"
        Me.BtnAddStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnDeleteStaffDetails
        '
        Me.BtnDeleteStaffDetails.Location = New System.Drawing.Point(199, 305)
        Me.BtnDeleteStaffDetails.Name = "BtnDeleteStaffDetails"
        Me.BtnDeleteStaffDetails.Size = New System.Drawing.Size(144, 41)
        Me.BtnDeleteStaffDetails.TabIndex = 75
        Me.BtnDeleteStaffDetails.Text = "Delete Staff Details"
        Me.BtnDeleteStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnBackToMenu
        '
        Me.BtnBackToMenu.Location = New System.Drawing.Point(533, 305)
        Me.BtnBackToMenu.Name = "BtnBackToMenu"
        Me.BtnBackToMenu.Size = New System.Drawing.Size(124, 41)
        Me.BtnBackToMenu.TabIndex = 76
        Me.BtnBackToMenu.Text = "Back To Menu"
        Me.BtnBackToMenu.UseVisualStyleBackColor = True
        '
        'BtnLastStaffDetails
        '
        Me.BtnLastStaffDetails.Location = New System.Drawing.Point(533, 258)
        Me.BtnLastStaffDetails.Name = "BtnLastStaffDetails"
        Me.BtnLastStaffDetails.Size = New System.Drawing.Size(124, 41)
        Me.BtnLastStaffDetails.TabIndex = 77
        Me.BtnLastStaffDetails.Text = "Last Staff Details"
        Me.BtnLastStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnPreviousStaff
        '
        Me.BtnPreviousStaff.Location = New System.Drawing.Point(533, 211)
        Me.BtnPreviousStaff.Name = "BtnPreviousStaff"
        Me.BtnPreviousStaff.Size = New System.Drawing.Size(124, 41)
        Me.BtnPreviousStaff.TabIndex = 78
        Me.BtnPreviousStaff.Text = "Previous Staff"
        Me.BtnPreviousStaff.UseVisualStyleBackColor = True
        '
        'BtnNextStaff
        '
        Me.BtnNextStaff.Location = New System.Drawing.Point(533, 164)
        Me.BtnNextStaff.Name = "BtnNextStaff"
        Me.BtnNextStaff.Size = New System.Drawing.Size(124, 41)
        Me.BtnNextStaff.TabIndex = 79
        Me.BtnNextStaff.Text = "Next Staff"
        Me.BtnNextStaff.UseVisualStyleBackColor = True
        '
        'BtnFirstStaffDetails
        '
        Me.BtnFirstStaffDetails.Location = New System.Drawing.Point(533, 116)
        Me.BtnFirstStaffDetails.Name = "BtnFirstStaffDetails"
        Me.BtnFirstStaffDetails.Size = New System.Drawing.Size(124, 41)
        Me.BtnFirstStaffDetails.TabIndex = 80
        Me.BtnFirstStaffDetails.Text = "First Staff Details"
        Me.BtnFirstStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnClearStaffDetails
        '
        Me.BtnClearStaffDetails.Location = New System.Drawing.Point(533, 69)
        Me.BtnClearStaffDetails.Name = "BtnClearStaffDetails"
        Me.BtnClearStaffDetails.Size = New System.Drawing.Size(124, 41)
        Me.BtnClearStaffDetails.TabIndex = 81
        Me.BtnClearStaffDetails.Text = "Clear Staff Details"
        Me.BtnClearStaffDetails.UseVisualStyleBackColor = True
        '
        'BtnCancelProcess
        '
        Me.BtnCancelProcess.Location = New System.Drawing.Point(533, 22)
        Me.BtnCancelProcess.Name = "BtnCancelProcess"
        Me.BtnCancelProcess.Size = New System.Drawing.Size(124, 41)
        Me.BtnCancelProcess.TabIndex = 82
        Me.BtnCancelProcess.Text = "Cancel Process"
        Me.BtnCancelProcess.UseVisualStyleBackColor = True
        '
        'LblStaffIDError
        '
        Me.LblStaffIDError.AutoSize = True
        Me.LblStaffIDError.ForeColor = System.Drawing.Color.Red
        Me.LblStaffIDError.Location = New System.Drawing.Point(244, 3)
        Me.LblStaffIDError.Name = "LblStaffIDError"
        Me.LblStaffIDError.Size = New System.Drawing.Size(62, 13)
        Me.LblStaffIDError.TabIndex = 83
        Me.LblStaffIDError.Text = "StaffIDError"
        '
        'LblFirstnameError
        '
        Me.LblFirstnameError.AutoSize = True
        Me.LblFirstnameError.ForeColor = System.Drawing.Color.Red
        Me.LblFirstnameError.Location = New System.Drawing.Point(244, 45)
        Me.LblFirstnameError.Name = "LblFirstnameError"
        Me.LblFirstnameError.Size = New System.Drawing.Size(74, 13)
        Me.LblFirstnameError.TabIndex = 84
        Me.LblFirstnameError.Text = "FirstnameError"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(244, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "CustomerIDError"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(244, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "CustomerIDError"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(244, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "CustomerIDError"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(244, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "CustomerIDError"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(244, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "CustomerIDError"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(244, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "CustomerIDError"
        '
        'StaffAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(669, 348)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
