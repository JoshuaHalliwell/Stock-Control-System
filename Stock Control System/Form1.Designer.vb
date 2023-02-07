<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.Login = New System.Windows.Forms.Button()
        Me.Admin = New System.Windows.Forms.Button()
        Me.Password = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.LoginPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(397, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(304, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Forgot Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(364, 278)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(370, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(364, 324)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(370, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(283, 281)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(75, 17)
        Me.Username.TabIndex = 5
        Me.Username.Text = "Username"
        '
        'Login
        '
        Me.Login.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(582, 393)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(282, 51)
        Me.Login.TabIndex = 6
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.Admin.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin.Location = New System.Drawing.Point(234, 393)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(282, 51)
        Me.Admin.TabIndex = 7
        Me.Admin.Text = "Admin"
        Me.Admin.UseVisualStyleBackColor = True
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(283, 324)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(72, 17)
        Me.Password.TabIndex = 8
        Me.Password.Text = "Password"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.Stock_Control_System.My.Resources.Resources.SJR_white_logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(871, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(172, 222)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 9
        Me.LogoPictureBox.TabStop = False
        '
        'LoginPictureBox
        '
        Me.LoginPictureBox.Image = Global.Stock_Control_System.My.Resources.Resources.Login_PNG
        Me.LoginPictureBox.Location = New System.Drawing.Point(320, 28)
        Me.LoginPictureBox.Name = "LoginPictureBox"
        Me.LoginPictureBox.Size = New System.Drawing.Size(414, 159)
        Me.LoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoginPictureBox.TabIndex = 10
        Me.LoginPictureBox.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(141, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1229, 646)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LoginPictureBox)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Admin)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "    "
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents Login As Button
    Friend WithEvents Admin As Button
    Friend WithEvents Password As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents LoginPictureBox As PictureBox
    Friend WithEvents Button2 As Button
End Class
