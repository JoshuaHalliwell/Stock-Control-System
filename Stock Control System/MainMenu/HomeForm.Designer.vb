<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Me.LblWelcomemessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblWelcomemessage
        '
        Me.LblWelcomemessage.AutoSize = True
        Me.LblWelcomemessage.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblWelcomemessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWelcomemessage.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblWelcomemessage.Location = New System.Drawing.Point(177, 143)
        Me.LblWelcomemessage.Name = "LblWelcomemessage"
        Me.LblWelcomemessage.Size = New System.Drawing.Size(380, 39)
        Me.LblWelcomemessage.TabIndex = 40
        Me.LblWelcomemessage.Text = "Welcome to the system"
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(672, 349)
        Me.Controls.Add(Me.LblWelcomemessage)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "HomeForm"
        Me.Text = "HomeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblWelcomemessage As Label
End Class
