<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgottenPassword
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
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblConfirmPassword = New System.Windows.Forms.Label()
        Me.LblNewPassword = New System.Windows.Forms.Label()
        Me.TxbConfirmPassword = New System.Windows.Forms.TextBox()
        Me.TxbNewPassword = New System.Windows.Forms.TextBox()
        Me.TxbUsername = New System.Windows.Forms.TextBox()
        Me.BtnSetNewPassword = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblUsername.Location = New System.Drawing.Point(61, 124)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(102, 27)
        Me.LblUsername.TabIndex = 0
        Me.LblUsername.Text = "Username:"
        '
        'LblConfirmPassword
        '
        Me.LblConfirmPassword.AutoSize = True
        Me.LblConfirmPassword.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConfirmPassword.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblConfirmPassword.Location = New System.Drawing.Point(38, 220)
        Me.LblConfirmPassword.Name = "LblConfirmPassword"
        Me.LblConfirmPassword.Size = New System.Drawing.Size(168, 27)
        Me.LblConfirmPassword.TabIndex = 1
        Me.LblConfirmPassword.Text = "Confirm Password:"
        '
        'LblNewPassword
        '
        Me.LblNewPassword.AutoSize = True
        Me.LblNewPassword.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNewPassword.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblNewPassword.Location = New System.Drawing.Point(38, 175)
        Me.LblNewPassword.Name = "LblNewPassword"
        Me.LblNewPassword.Size = New System.Drawing.Size(141, 27)
        Me.LblNewPassword.TabIndex = 2
        Me.LblNewPassword.Text = "New Password:"
        '
        'TxbConfirmPassword
        '
        Me.TxbConfirmPassword.Location = New System.Drawing.Point(231, 225)
        Me.TxbConfirmPassword.Name = "TxbConfirmPassword"
        Me.TxbConfirmPassword.Size = New System.Drawing.Size(273, 22)
        Me.TxbConfirmPassword.TabIndex = 3
        '
        'TxbNewPassword
        '
        Me.TxbNewPassword.Location = New System.Drawing.Point(231, 175)
        Me.TxbNewPassword.Name = "TxbNewPassword"
        Me.TxbNewPassword.Size = New System.Drawing.Size(273, 22)
        Me.TxbNewPassword.TabIndex = 4
        '
        'TxbUsername
        '
        Me.TxbUsername.Location = New System.Drawing.Point(231, 124)
        Me.TxbUsername.Name = "TxbUsername"
        Me.TxbUsername.Size = New System.Drawing.Size(273, 22)
        Me.TxbUsername.TabIndex = 5
        '
        'BtnSetNewPassword
        '
        Me.BtnSetNewPassword.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetNewPassword.Location = New System.Drawing.Point(13, 273)
        Me.BtnSetNewPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSetNewPassword.Name = "BtnSetNewPassword"
        Me.BtnSetNewPassword.Size = New System.Drawing.Size(238, 66)
        Me.BtnSetNewPassword.TabIndex = 6
        Me.BtnSetNewPassword.Text = "Set New Password"
        Me.BtnSetNewPassword.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(301, 273)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(238, 66)
        Me.BtnBack.TabIndex = 7
        Me.BtnBack.Text = "Back To Login"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Stock_Control_System.My.Resources.Resources.SJR_white_logo
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(225, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 35)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Reset Password Page"
        '
        'ForgottenPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(565, 372)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnSetNewPassword)
        Me.Controls.Add(Me.TxbUsername)
        Me.Controls.Add(Me.TxbNewPassword)
        Me.Controls.Add(Me.TxbConfirmPassword)
        Me.Controls.Add(Me.LblNewPassword)
        Me.Controls.Add(Me.LblConfirmPassword)
        Me.Controls.Add(Me.LblUsername)
        Me.Name = "ForgottenPassword"
        Me.Text = "ForgottenPassword"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUsername As Label
    Friend WithEvents LblConfirmPassword As Label
    Friend WithEvents LblNewPassword As Label
    Friend WithEvents TxbConfirmPassword As TextBox
    Friend WithEvents TxbNewPassword As TextBox
    Friend WithEvents TxbUsername As TextBox
    Friend WithEvents BtnSetNewPassword As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
