<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportDatabaseTable
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
        Me.LblGraphData = New System.Windows.Forms.Label()
        Me.BtnClearTable = New System.Windows.Forms.Button()
        Me.BtnBackupTable = New System.Windows.Forms.Button()
        Me.BtnShareByEmail = New System.Windows.Forms.Button()
        Me.BtnBackToMenu = New System.Windows.Forms.Button()
        Me.BtnSaveToPDF = New System.Windows.Forms.Button()
        Me.DGVDataTable = New System.Windows.Forms.DataGridView()
        CType(Me.DGVDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClbGraphData
        '
        Me.ClbGraphData.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClbGraphData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClbGraphData.FormattingEnabled = True
        Me.ClbGraphData.Items.AddRange(New Object() {"Staff Table  ", "Customer Table ", "Suppliers Orders Table", "Sales Table", "Stocks Table", "Suppliers Table"})
        Me.ClbGraphData.Location = New System.Drawing.Point(590, 84)
        Me.ClbGraphData.Name = "ClbGraphData"
        Me.ClbGraphData.Size = New System.Drawing.Size(257, 179)
        Me.ClbGraphData.TabIndex = 3
        '
        'LblGraphData
        '
        Me.LblGraphData.AutoSize = True
        Me.LblGraphData.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGraphData.Location = New System.Drawing.Point(622, 24)
        Me.LblGraphData.Name = "LblGraphData"
        Me.LblGraphData.Size = New System.Drawing.Size(140, 29)
        Me.LblGraphData.TabIndex = 9
        Me.LblGraphData.Text = "Graph Data:"
        '
        'BtnClearTable
        '
        Me.BtnClearTable.Location = New System.Drawing.Point(12, 326)
        Me.BtnClearTable.Name = "BtnClearTable"
        Me.BtnClearTable.Size = New System.Drawing.Size(132, 81)
        Me.BtnClearTable.TabIndex = 10
        Me.BtnClearTable.Text = "Clear Table View"
        Me.BtnClearTable.UseVisualStyleBackColor = True
        '
        'BtnBackupTable
        '
        Me.BtnBackupTable.Location = New System.Drawing.Point(188, 326)
        Me.BtnBackupTable.Name = "BtnBackupTable"
        Me.BtnBackupTable.Size = New System.Drawing.Size(132, 81)
        Me.BtnBackupTable.TabIndex = 11
        Me.BtnBackupTable.Text = "Backup Data To Excel"
        Me.BtnBackupTable.UseVisualStyleBackColor = True
        '
        'BtnShareByEmail
        '
        Me.BtnShareByEmail.Location = New System.Drawing.Point(361, 326)
        Me.BtnShareByEmail.Name = "BtnShareByEmail"
        Me.BtnShareByEmail.Size = New System.Drawing.Size(132, 81)
        Me.BtnShareByEmail.TabIndex = 12
        Me.BtnShareByEmail.Text = "Share data table vial Email"
        Me.BtnShareByEmail.UseVisualStyleBackColor = True
        '
        'BtnBackToMenu
        '
        Me.BtnBackToMenu.Location = New System.Drawing.Point(715, 326)
        Me.BtnBackToMenu.Name = "BtnBackToMenu"
        Me.BtnBackToMenu.Size = New System.Drawing.Size(132, 81)
        Me.BtnBackToMenu.TabIndex = 13
        Me.BtnBackToMenu.Text = "Back To Report Menu"
        Me.BtnBackToMenu.UseVisualStyleBackColor = True
        '
        'BtnSaveToPDF
        '
        Me.BtnSaveToPDF.Location = New System.Drawing.Point(537, 326)
        Me.BtnSaveToPDF.Name = "BtnSaveToPDF"
        Me.BtnSaveToPDF.Size = New System.Drawing.Size(132, 81)
        Me.BtnSaveToPDF.TabIndex = 14
        Me.BtnSaveToPDF.Text = "Save Coby Of Data To PDF"
        Me.BtnSaveToPDF.UseVisualStyleBackColor = True
        '
        'DGVDataTable
        '
        Me.DGVDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDataTable.Location = New System.Drawing.Point(12, 24)
        Me.DGVDataTable.Name = "DGVDataTable"
        Me.DGVDataTable.RowHeadersWidth = 51
        Me.DGVDataTable.RowTemplate.Height = 24
        Me.DGVDataTable.Size = New System.Drawing.Size(567, 268)
        Me.DGVDataTable.TabIndex = 15
        '
        'ReportDatabaseTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(892, 428)
        Me.Controls.Add(Me.DGVDataTable)
        Me.Controls.Add(Me.BtnSaveToPDF)
        Me.Controls.Add(Me.BtnBackToMenu)
        Me.Controls.Add(Me.BtnShareByEmail)
        Me.Controls.Add(Me.BtnBackupTable)
        Me.Controls.Add(Me.BtnClearTable)
        Me.Controls.Add(Me.LblGraphData)
        Me.Controls.Add(Me.ClbGraphData)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ReportDatabaseTable"
        Me.Text = "DatabaseTableReport"
        CType(Me.DGVDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClbGraphData As CheckedListBox
    Friend WithEvents LblGraphData As Label
    Friend WithEvents BtnClearTable As Button
    Friend WithEvents BtnBackupTable As Button
    Friend WithEvents BtnShareByEmail As Button
    Friend WithEvents BtnBackToMenu As Button
    Friend WithEvents BtnSaveToPDF As Button
    Friend WithEvents DGVDataTable As DataGridView
End Class
