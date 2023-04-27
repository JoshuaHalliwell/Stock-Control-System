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
        Me.ClbGraphData = New System.Windows.Forms.CheckedListBox()
        Me.CbxGraphType = New System.Windows.Forms.ComboBox()
        Me.BtnClearGraph = New System.Windows.Forms.Button()
        Me.BtnEmailShare = New System.Windows.Forms.Button()
        Me.BtnPdfShare = New System.Windows.Forms.Button()
        Me.LblGraphData = New System.Windows.Forms.Label()
        Me.LblGraphType = New System.Windows.Forms.Label()
        Me.BtnBackToMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ClbGraphData
        '
        Me.ClbGraphData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClbGraphData.FormattingEnabled = True
        Me.ClbGraphData.Items.AddRange(New Object() {"Product sales for the shop ", "Over all stock", "Active Suppliers "})
        Me.ClbGraphData.Location = New System.Drawing.Point(600, 62)
        Me.ClbGraphData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClbGraphData.Name = "ClbGraphData"
        Me.ClbGraphData.Size = New System.Drawing.Size(280, 79)
        Me.ClbGraphData.TabIndex = 2
        '
        'CbxGraphType
        '
        Me.CbxGraphType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxGraphType.FormattingEnabled = True
        Me.CbxGraphType.Items.AddRange(New Object() {"Pie Chart", "Bar Chart"})
        Me.CbxGraphType.Location = New System.Drawing.Point(603, 207)
        Me.CbxGraphType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CbxGraphType.Name = "CbxGraphType"
        Me.CbxGraphType.Size = New System.Drawing.Size(257, 33)
        Me.CbxGraphType.TabIndex = 4
        '
        'BtnClearGraph
        '
        Me.BtnClearGraph.Location = New System.Drawing.Point(12, 336)
        Me.BtnClearGraph.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClearGraph.Name = "BtnClearGraph"
        Me.BtnClearGraph.Size = New System.Drawing.Size(172, 81)
        Me.BtnClearGraph.TabIndex = 5
        Me.BtnClearGraph.Text = "Clear Graph"
        Me.BtnClearGraph.UseVisualStyleBackColor = True
        '
        'BtnEmailShare
        '
        Me.BtnEmailShare.Location = New System.Drawing.Point(245, 336)
        Me.BtnEmailShare.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEmailShare.Name = "BtnEmailShare"
        Me.BtnEmailShare.Size = New System.Drawing.Size(172, 81)
        Me.BtnEmailShare.TabIndex = 6
        Me.BtnEmailShare.Text = "Share graph to email"
        Me.BtnEmailShare.UseVisualStyleBackColor = True
        '
        'BtnPdfShare
        '
        Me.BtnPdfShare.Location = New System.Drawing.Point(477, 336)
        Me.BtnPdfShare.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPdfShare.Name = "BtnPdfShare"
        Me.BtnPdfShare.Size = New System.Drawing.Size(172, 81)
        Me.BtnPdfShare.TabIndex = 7
        Me.BtnPdfShare.Text = "Save graph as PDF"
        Me.BtnPdfShare.UseVisualStyleBackColor = True
        '
        'LblGraphData
        '
        Me.LblGraphData.AutoSize = True
        Me.LblGraphData.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGraphData.Location = New System.Drawing.Point(619, 18)
        Me.LblGraphData.Name = "LblGraphData"
        Me.LblGraphData.Size = New System.Drawing.Size(140, 29)
        Me.LblGraphData.TabIndex = 8
        Me.LblGraphData.Text = "Graph Data:"
        '
        'LblGraphType
        '
        Me.LblGraphType.AutoSize = True
        Me.LblGraphType.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGraphType.Location = New System.Drawing.Point(619, 175)
        Me.LblGraphType.Name = "LblGraphType"
        Me.LblGraphType.Size = New System.Drawing.Size(146, 29)
        Me.LblGraphType.TabIndex = 9
        Me.LblGraphType.Text = "Graph Type:"
        '
        'BtnBackToMenu
        '
        Me.BtnBackToMenu.Location = New System.Drawing.Point(712, 336)
        Me.BtnBackToMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBackToMenu.Name = "BtnBackToMenu"
        Me.BtnBackToMenu.Size = New System.Drawing.Size(172, 81)
        Me.BtnBackToMenu.TabIndex = 10
        Me.BtnBackToMenu.Text = "Back to graph menu"
        Me.BtnBackToMenu.UseVisualStyleBackColor = True
        '
        'ReportGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(896, 430)
        Me.Controls.Add(Me.BtnBackToMenu)
        Me.Controls.Add(Me.LblGraphType)
        Me.Controls.Add(Me.LblGraphData)
        Me.Controls.Add(Me.BtnPdfShare)
        Me.Controls.Add(Me.BtnEmailShare)
        Me.Controls.Add(Me.BtnClearGraph)
        Me.Controls.Add(Me.CbxGraphType)
        Me.Controls.Add(Me.ClbGraphData)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ReportGraph"
        Me.Text = "GraphReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClbGraphData As CheckedListBox
    Friend WithEvents CbxGraphType As ComboBox
    Friend WithEvents BtnClearGraph As Button
    Friend WithEvents BtnEmailShare As Button
    Friend WithEvents BtnPdfShare As Button
    Friend WithEvents LblGraphData As Label
    Friend WithEvents LblGraphType As Label
    Friend WithEvents BtnBackToMenu As Button
End Class
