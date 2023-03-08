<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportMenu
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
        Me.BtnGraphReport = New System.Windows.Forms.Button()
        Me.BtnBackupData = New System.Windows.Forms.Button()
        Me.LblReportType = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnGraphReport
        '
        Me.BtnGraphReport.Location = New System.Drawing.Point(29, 67)
        Me.BtnGraphReport.Name = "BtnGraphReport"
        Me.BtnGraphReport.Size = New System.Drawing.Size(608, 120)
        Me.BtnGraphReport.TabIndex = 0
        Me.BtnGraphReport.Text = "Graph Report"
        Me.BtnGraphReport.UseVisualStyleBackColor = True
        '
        'BtnBackupData
        '
        Me.BtnBackupData.Location = New System.Drawing.Point(29, 216)
        Me.BtnBackupData.Name = "BtnBackupData"
        Me.BtnBackupData.Size = New System.Drawing.Size(608, 120)
        Me.BtnBackupData.TabIndex = 1
        Me.BtnBackupData.Text = "Backup/ Database Report"
        Me.BtnBackupData.UseVisualStyleBackColor = True
        '
        'LblReportType
        '
        Me.LblReportType.AutoSize = True
        Me.LblReportType.Location = New System.Drawing.Point(66, 13)
        Me.LblReportType.Name = "LblReportType"
        Me.LblReportType.Size = New System.Drawing.Size(102, 13)
        Me.LblReportType.TabIndex = 2
        Me.LblReportType.Text = "Select a report type:"
        '
        'ReportMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(669, 348)
        Me.Controls.Add(Me.LblReportType)
        Me.Controls.Add(Me.BtnBackupData)
        Me.Controls.Add(Me.BtnGraphReport)
        Me.Name = "ReportMenu"
        Me.Text = "ReportMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGraphReport As Button
    Friend WithEvents BtnBackupData As Button
    Friend WithEvents LblReportType As Label
End Class
