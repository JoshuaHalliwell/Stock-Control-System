<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockAdd
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BtnBackToStockPage = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.LblStockID = New System.Windows.Forms.Label()
        Me.LblProductName = New System.Windows.Forms.Label()
        Me.LblQuantityOfDisplayStock = New System.Windows.Forms.Label()
        Me.LblQuantityOfStorageStock = New System.Windows.Forms.Label()
        Me.LblPricePerItem = New System.Windows.Forms.Label()
        Me.LblTotalStock = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnBackToStockPage
        '
        Me.BtnBackToStockPage.Location = New System.Drawing.Point(138, 277)
        Me.BtnBackToStockPage.Name = "BtnBackToStockPage"
        Me.BtnBackToStockPage.Size = New System.Drawing.Size(132, 59)
        Me.BtnBackToStockPage.TabIndex = 8
        Me.BtnBackToStockPage.Text = "Back to stock page"
        Me.BtnBackToStockPage.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(403, 277)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(132, 59)
        Me.BtnSubmit.TabIndex = 9
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'LblStockID
        '
        Me.LblStockID.AutoSize = True
        Me.LblStockID.Location = New System.Drawing.Point(175, 56)
        Me.LblStockID.Name = "LblStockID"
        Me.LblStockID.Size = New System.Drawing.Size(46, 13)
        Me.LblStockID.TabIndex = 10
        Me.LblStockID.Text = "StockID"
        '
        'LblProductName
        '
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Location = New System.Drawing.Point(175, 90)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.Size = New System.Drawing.Size(73, 13)
        Me.LblProductName.TabIndex = 11
        Me.LblProductName.Text = "Product name"
        '
        'LblQuantityOfDisplayStock
        '
        Me.LblQuantityOfDisplayStock.AutoSize = True
        Me.LblQuantityOfDisplayStock.Location = New System.Drawing.Point(175, 131)
        Me.LblQuantityOfDisplayStock.Name = "LblQuantityOfDisplayStock"
        Me.LblQuantityOfDisplayStock.Size = New System.Drawing.Size(122, 13)
        Me.LblQuantityOfDisplayStock.TabIndex = 12
        Me.LblQuantityOfDisplayStock.Text = "Quantity of display stock"
        '
        'LblQuantityOfStorageStock
        '
        Me.LblQuantityOfStorageStock.AutoSize = True
        Me.LblQuantityOfStorageStock.Location = New System.Drawing.Point(175, 169)
        Me.LblQuantityOfStorageStock.Name = "LblQuantityOfStorageStock"
        Me.LblQuantityOfStorageStock.Size = New System.Drawing.Size(125, 13)
        Me.LblQuantityOfStorageStock.TabIndex = 13
        Me.LblQuantityOfStorageStock.Text = "Quantity of storage stock"
        '
        'LblPricePerItem
        '
        Me.LblPricePerItem.AutoSize = True
        Me.LblPricePerItem.Location = New System.Drawing.Point(175, 208)
        Me.LblPricePerItem.Name = "LblPricePerItem"
        Me.LblPricePerItem.Size = New System.Drawing.Size(73, 13)
        Me.LblPricePerItem.TabIndex = 14
        Me.LblPricePerItem.Text = "Price Per Item"
        '
        'LblTotalStock
        '
        Me.LblTotalStock.AutoSize = True
        Me.LblTotalStock.Location = New System.Drawing.Point(175, 248)
        Me.LblTotalStock.Name = "LblTotalStock"
        Me.LblTotalStock.Size = New System.Drawing.Size(62, 13)
        Me.LblTotalStock.TabIndex = 15
        Me.LblTotalStock.Text = "Total Stock"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(366, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(134, 20)
        Me.TextBox1.TabIndex = 16
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(366, 87)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(134, 20)
        Me.TextBox2.TabIndex = 17
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(366, 124)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(134, 20)
        Me.TextBox3.TabIndex = 18
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(366, 162)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(134, 20)
        Me.TextBox4.TabIndex = 19
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(366, 201)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(134, 20)
        Me.TextBox5.TabIndex = 20
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(366, 241)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(134, 20)
        Me.TextBox6.TabIndex = 21
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(669, 348)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LblTotalStock)
        Me.Controls.Add(Me.LblPricePerItem)
        Me.Controls.Add(Me.LblQuantityOfStorageStock)
        Me.Controls.Add(Me.LblQuantityOfDisplayStock)
        Me.Controls.Add(Me.LblProductName)
        Me.Controls.Add(Me.LblStockID)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.BtnBackToStockPage)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnBackToStockPage As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents LblStockID As Label
    Friend WithEvents LblProductName As Label
    Friend WithEvents LblQuantityOfDisplayStock As Label
    Friend WithEvents LblQuantityOfStorageStock As Label
    Friend WithEvents LblPricePerItem As Label
    Friend WithEvents LblTotalStock As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
End Class
