<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportGraph
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
        Me.CbxTableSelection = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'CbxTableSelection
        '
        Me.CbxTableSelection.FormattingEnabled = True
        Me.CbxTableSelection.Items.AddRange(New Object() {"Customer Tabel", "Orders Table", "Sales Table", "SaleLine Table", "Staff Table ", "Stocks Table ", "Suppliers Table "})
        Me.CbxTableSelection.Location = New System.Drawing.Point(419, 54)
        Me.CbxTableSelection.Name = "CbxTableSelection"
        Me.CbxTableSelection.Size = New System.Drawing.Size(121, 21)
        Me.CbxTableSelection.TabIndex = 1
        '
        'ReportGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(669, 348)
        Me.Controls.Add(Me.CbxTableSelection)
        Me.Name = "ReportGraph"
        Me.Text = "GraphReport"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CbxTableSelection As ComboBox
End Class
