<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.BtnForgottenPassword = New System.Windows.Forms.Button()
        Me.TxbUsername = New System.Windows.Forms.TextBox()
        Me.TxbPassword = New System.Windows.Forms.TextBox()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.LoginPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnForgottenPassword
        '
        Me.BtnForgottenPassword.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnForgottenPassword.Location = New System.Drawing.Point(12, 393)
        Me.BtnForgottenPassword.Name = "BtnForgottenPassword"
        Me.BtnForgottenPassword.Size = New System.Drawing.Size(304, 54)
        Me.BtnForgottenPassword.TabIndex = 0
        Me.BtnForgottenPassword.Text = "Forgotten Password"
        Me.BtnForgottenPassword.UseVisualStyleBackColor = True
        '
        'TxbUsername
        '
        Me.TxbUsername.Location = New System.Drawing.Point(167, 278)
        Me.TxbUsername.Name = "TxbUsername"
        Me.TxbUsername.Size = New System.Drawing.Size(370, 20)
        Me.TxbUsername.TabIndex = 3
        '
        'TxbPassword
        '
        Me.TxbPassword.Location = New System.Drawing.Point(167, 324)
        Me.TxbPassword.Name = "TxbPassword"
        Me.TxbPassword.Size = New System.Drawing.Size(370, 20)
        Me.TxbPassword.TabIndex = 4
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Location = New System.Drawing.Point(86, 281)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(75, 17)
        Me.LblUsername.TabIndex = 5
        Me.LblUsername.Text = "Username"
        '
        'BtnLogin
        '
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(385, 393)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(282, 51)
        Me.BtnLogin.TabIndex = 6
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(86, 324)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(72, 17)
        Me.LblPassword.TabIndex = 8
        Me.LblPassword.Text = "Password"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.Stock_Control_System.My.Resources.Resources.SJR_white_logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(509, 28)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(158, 175)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 9
        Me.LogoPictureBox.TabStop = False
        '
        'LoginPictureBox
        '
        Me.LoginPictureBox.Image = Global.Stock_Control_System.My.Resources.Resources.Login_PNG
        Me.LoginPictureBox.Location = New System.Drawing.Point(63, 28)
        Me.LoginPictureBox.Name = "LoginPictureBox"
        Me.LoginPictureBox.Size = New System.Drawing.Size(414, 159)
        Me.LoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoginPictureBox.TabIndex = 10
        Me.LoginPictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(693, 474)
        Me.Controls.Add(Me.LoginPictureBox)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.TxbPassword)
        Me.Controls.Add(Me.TxbUsername)
        Me.Controls.Add(Me.BtnForgottenPassword)
        Me.Name = "Form1"
        Me.Text = "    "
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnForgottenPassword As Button
    Friend WithEvents TxbUsername As TextBox
    Friend WithEvents TxbPassword As TextBox
    Friend WithEvents LblUsername As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents LblPassword As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents LoginPictureBox As PictureBox
End Class
