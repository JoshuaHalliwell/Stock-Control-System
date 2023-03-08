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
        Me.LblStockID = New System.Windows.Forms.Label()
        Me.LblProductName = New System.Windows.Forms.Label()
        Me.LblQuantityOfDisplayStock = New System.Windows.Forms.Label()
        Me.LblQuantityOfStorageStock = New System.Windows.Forms.Label()
        Me.LblPricePerItem = New System.Windows.Forms.Label()
        Me.LblTotalStock = New System.Windows.Forms.Label()
        Me.Txtstockid = New System.Windows.Forms.TextBox()
        Me.Txtproductname = New System.Windows.Forms.TextBox()
        Me.Txtquantitystock = New System.Windows.Forms.TextBox()
        Me.Txtquantityofstorage = New System.Windows.Forms.TextBox()
        Me.Txtpriceperitem = New System.Windows.Forms.TextBox()
        Me.Txttotalstock = New System.Windows.Forms.TextBox()
        Me.Btncancel = New System.Windows.Forms.Button()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Btnfirststockdetails = New System.Windows.Forms.Button()
        Me.Btnnextstock = New System.Windows.Forms.Button()
        Me.Btnprevioustock = New System.Windows.Forms.Button()
        Me.Btnlaststock = New System.Windows.Forms.Button()
        Me.Btnbacktomenu = New System.Windows.Forms.Button()
        Me.Btndeletestockpage = New System.Windows.Forms.Button()
        Me.Btnupdatestock = New System.Windows.Forms.Button()
        Me.Lblstock = New System.Windows.Forms.Label()
        Me.Lblproductnameerror = New System.Windows.Forms.Label()
        Me.Lbldisplaystockerror = New System.Windows.Forms.Label()
        Me.Lblstoragestockerror = New System.Windows.Forms.Label()
        Me.Lblpriceperitemerror = New System.Windows.Forms.Label()
        Me.Lbltotalstockerror = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnBackToStockPage
        '
        Me.BtnBackToStockPage.Location = New System.Drawing.Point(155, 292)
        Me.BtnBackToStockPage.Name = "BtnBackToStockPage"
        Me.BtnBackToStockPage.Size = New System.Drawing.Size(111, 28)
        Me.BtnBackToStockPage.TabIndex = 8
        Me.BtnBackToStockPage.Text = "Add stock details"
        Me.BtnBackToStockPage.UseVisualStyleBackColor = True
        '
        'LblStockID
        '
        Me.LblStockID.AutoSize = True
        Me.LblStockID.Location = New System.Drawing.Point(12, 56)
        Me.LblStockID.Name = "LblStockID"
        Me.LblStockID.Size = New System.Drawing.Size(46, 13)
        Me.LblStockID.TabIndex = 10
        Me.LblStockID.Text = "StockID"
        '
        'LblProductName
        '
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Location = New System.Drawing.Point(12, 90)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.Size = New System.Drawing.Size(72, 13)
        Me.LblProductName.TabIndex = 11
        Me.LblProductName.Text = "ProductName"
        '
        'LblQuantityOfDisplayStock
        '
        Me.LblQuantityOfDisplayStock.AutoSize = True
        Me.LblQuantityOfDisplayStock.Location = New System.Drawing.Point(12, 131)
        Me.LblQuantityOfDisplayStock.Name = "LblQuantityOfDisplayStock"
        Me.LblQuantityOfDisplayStock.Size = New System.Drawing.Size(119, 13)
        Me.LblQuantityOfDisplayStock.TabIndex = 12
        Me.LblQuantityOfDisplayStock.Text = "QuantityOfDisplayStock"
        '
        'LblQuantityOfStorageStock
        '
        Me.LblQuantityOfStorageStock.AutoSize = True
        Me.LblQuantityOfStorageStock.Location = New System.Drawing.Point(12, 169)
        Me.LblQuantityOfStorageStock.Name = "LblQuantityOfStorageStock"
        Me.LblQuantityOfStorageStock.Size = New System.Drawing.Size(122, 13)
        Me.LblQuantityOfStorageStock.TabIndex = 13
        Me.LblQuantityOfStorageStock.Text = "QuantityOfStorageStock"
        '
        'LblPricePerItem
        '
        Me.LblPricePerItem.AutoSize = True
        Me.LblPricePerItem.Location = New System.Drawing.Point(12, 208)
        Me.LblPricePerItem.Name = "LblPricePerItem"
        Me.LblPricePerItem.Size = New System.Drawing.Size(67, 13)
        Me.LblPricePerItem.TabIndex = 14
        Me.LblPricePerItem.Text = "PricePerItem"
        '
        'LblTotalStock
        '
        Me.LblTotalStock.AutoSize = True
        Me.LblTotalStock.Location = New System.Drawing.Point(12, 248)
        Me.LblTotalStock.Name = "LblTotalStock"
        Me.LblTotalStock.Size = New System.Drawing.Size(59, 13)
        Me.LblTotalStock.TabIndex = 15
        Me.LblTotalStock.Text = "TotalStock"
        '
        'Txtstockid
        '
        Me.Txtstockid.Location = New System.Drawing.Point(160, 49)
        Me.Txtstockid.Name = "Txtstockid"
        Me.Txtstockid.Size = New System.Drawing.Size(340, 20)
        Me.Txtstockid.TabIndex = 16
        Me.Txtstockid.Text = "StockID"
        '
        'Txtproductname
        '
        Me.Txtproductname.Location = New System.Drawing.Point(160, 87)
        Me.Txtproductname.Name = "Txtproductname"
        Me.Txtproductname.Size = New System.Drawing.Size(340, 20)
        Me.Txtproductname.TabIndex = 17
        Me.Txtproductname.Text = "Product name"
        '
        'Txtquantitystock
        '
        Me.Txtquantitystock.Location = New System.Drawing.Point(160, 124)
        Me.Txtquantitystock.Name = "Txtquantitystock"
        Me.Txtquantitystock.Size = New System.Drawing.Size(340, 20)
        Me.Txtquantitystock.TabIndex = 18
        Me.Txtquantitystock.Text = "QuantityOfDisplayStock"
        '
        'Txtquantityofstorage
        '
        Me.Txtquantityofstorage.Location = New System.Drawing.Point(160, 162)
        Me.Txtquantityofstorage.Name = "Txtquantityofstorage"
        Me.Txtquantityofstorage.Size = New System.Drawing.Size(340, 20)
        Me.Txtquantityofstorage.TabIndex = 19
        Me.Txtquantityofstorage.Text = "QuantityOfStorageStock"
        '
        'Txtpriceperitem
        '
        Me.Txtpriceperitem.Location = New System.Drawing.Point(160, 201)
        Me.Txtpriceperitem.Name = "Txtpriceperitem"
        Me.Txtpriceperitem.Size = New System.Drawing.Size(340, 20)
        Me.Txtpriceperitem.TabIndex = 20
        Me.Txtpriceperitem.Text = "PricePerItem"
        '
        'Txttotalstock
        '
        Me.Txttotalstock.Location = New System.Drawing.Point(160, 241)
        Me.Txttotalstock.Name = "Txttotalstock"
        Me.Txttotalstock.Size = New System.Drawing.Size(340, 20)
        Me.Txttotalstock.TabIndex = 21
        Me.Txttotalstock.Text = "TotalStock"
        '
        'Btncancel
        '
        Me.Btncancel.Location = New System.Drawing.Point(521, 38)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.Size = New System.Drawing.Size(138, 30)
        Me.Btncancel.TabIndex = 22
        Me.Btncancel.Text = "Cancel Process"
        Me.Btncancel.UseVisualStyleBackColor = True
        '
        'Btnclear
        '
        Me.Btnclear.Location = New System.Drawing.Point(521, 74)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(138, 30)
        Me.Btnclear.TabIndex = 23
        Me.Btnclear.Text = "Clear stock details"
        Me.Btnclear.UseVisualStyleBackColor = True
        '
        'Btnfirststockdetails
        '
        Me.Btnfirststockdetails.Location = New System.Drawing.Point(521, 110)
        Me.Btnfirststockdetails.Name = "Btnfirststockdetails"
        Me.Btnfirststockdetails.Size = New System.Drawing.Size(138, 30)
        Me.Btnfirststockdetails.TabIndex = 24
        Me.Btnfirststockdetails.Text = "First stock details"
        Me.Btnfirststockdetails.UseVisualStyleBackColor = True
        '
        'Btnnextstock
        '
        Me.Btnnextstock.Location = New System.Drawing.Point(521, 146)
        Me.Btnnextstock.Name = "Btnnextstock"
        Me.Btnnextstock.Size = New System.Drawing.Size(138, 30)
        Me.Btnnextstock.TabIndex = 25
        Me.Btnnextstock.Text = "Next stock"
        Me.Btnnextstock.UseVisualStyleBackColor = True
        '
        'Btnprevioustock
        '
        Me.Btnprevioustock.Location = New System.Drawing.Point(521, 182)
        Me.Btnprevioustock.Name = "Btnprevioustock"
        Me.Btnprevioustock.Size = New System.Drawing.Size(138, 30)
        Me.Btnprevioustock.TabIndex = 26
        Me.Btnprevioustock.Text = "Prev stock "
        Me.Btnprevioustock.UseVisualStyleBackColor = True
        '
        'Btnlaststock
        '
        Me.Btnlaststock.Location = New System.Drawing.Point(521, 218)
        Me.Btnlaststock.Name = "Btnlaststock"
        Me.Btnlaststock.Size = New System.Drawing.Size(138, 30)
        Me.Btnlaststock.TabIndex = 27
        Me.Btnlaststock.Text = "Last stock details"
        Me.Btnlaststock.UseVisualStyleBackColor = True
        '
        'Btnbacktomenu
        '
        Me.Btnbacktomenu.Location = New System.Drawing.Point(521, 254)
        Me.Btnbacktomenu.Name = "Btnbacktomenu"
        Me.Btnbacktomenu.Size = New System.Drawing.Size(138, 30)
        Me.Btnbacktomenu.TabIndex = 28
        Me.Btnbacktomenu.Text = "Back to menu"
        Me.Btnbacktomenu.UseVisualStyleBackColor = True
        '
        'Btndeletestockpage
        '
        Me.Btndeletestockpage.Location = New System.Drawing.Point(272, 292)
        Me.Btndeletestockpage.Name = "Btndeletestockpage"
        Me.Btndeletestockpage.Size = New System.Drawing.Size(111, 28)
        Me.Btndeletestockpage.TabIndex = 29
        Me.Btndeletestockpage.Text = "Delete stock details"
        Me.Btndeletestockpage.UseVisualStyleBackColor = True
        '
        'Btnupdatestock
        '
        Me.Btnupdatestock.Location = New System.Drawing.Point(389, 292)
        Me.Btnupdatestock.Name = "Btnupdatestock"
        Me.Btnupdatestock.Size = New System.Drawing.Size(125, 28)
        Me.Btnupdatestock.TabIndex = 30
        Me.Btnupdatestock.Text = "Update stock details"
        Me.Btnupdatestock.UseVisualStyleBackColor = True
        '
        'Lblstock
        '
        Me.Lblstock.AutoSize = True
        Me.Lblstock.ForeColor = System.Drawing.Color.Red
        Me.Lblstock.Location = New System.Drawing.Point(157, 33)
        Me.Lblstock.Name = "Lblstock"
        Me.Lblstock.Size = New System.Drawing.Size(68, 13)
        Me.Lblstock.TabIndex = 31
        Me.Lblstock.Text = "StockIDError"
        '
        'Lblproductnameerror
        '
        Me.Lblproductnameerror.AutoSize = True
        Me.Lblproductnameerror.ForeColor = System.Drawing.Color.Red
        Me.Lblproductnameerror.Location = New System.Drawing.Point(157, 71)
        Me.Lblproductnameerror.Name = "Lblproductnameerror"
        Me.Lblproductnameerror.Size = New System.Drawing.Size(94, 13)
        Me.Lblproductnameerror.TabIndex = 32
        Me.Lblproductnameerror.Text = "ProductNameError"
        '
        'Lbldisplaystockerror
        '
        Me.Lbldisplaystockerror.AutoSize = True
        Me.Lbldisplaystockerror.ForeColor = System.Drawing.Color.Red
        Me.Lbldisplaystockerror.Location = New System.Drawing.Point(157, 108)
        Me.Lbldisplaystockerror.Name = "Lbldisplaystockerror"
        Me.Lbldisplaystockerror.Size = New System.Drawing.Size(141, 13)
        Me.Lbldisplaystockerror.TabIndex = 33
        Me.Lbldisplaystockerror.Text = "QuantityOfDisplayStockError"
        '
        'Lblstoragestockerror
        '
        Me.Lblstoragestockerror.AutoSize = True
        Me.Lblstoragestockerror.ForeColor = System.Drawing.Color.Red
        Me.Lblstoragestockerror.Location = New System.Drawing.Point(157, 146)
        Me.Lblstoragestockerror.Name = "Lblstoragestockerror"
        Me.Lblstoragestockerror.Size = New System.Drawing.Size(144, 13)
        Me.Lblstoragestockerror.TabIndex = 34
        Me.Lblstoragestockerror.Text = "QuantityOfStorageStockError"
        '
        'Lblpriceperitemerror
        '
        Me.Lblpriceperitemerror.AutoSize = True
        Me.Lblpriceperitemerror.ForeColor = System.Drawing.Color.Red
        Me.Lblpriceperitemerror.Location = New System.Drawing.Point(157, 185)
        Me.Lblpriceperitemerror.Name = "Lblpriceperitemerror"
        Me.Lblpriceperitemerror.Size = New System.Drawing.Size(89, 13)
        Me.Lblpriceperitemerror.TabIndex = 35
        Me.Lblpriceperitemerror.Text = "PricePerItemError"
        '
        'Lbltotalstockerror
        '
        Me.Lbltotalstockerror.AutoSize = True
        Me.Lbltotalstockerror.ForeColor = System.Drawing.Color.Red
        Me.Lbltotalstockerror.Location = New System.Drawing.Point(157, 227)
        Me.Lbltotalstockerror.Name = "Lbltotalstockerror"
        Me.Lbltotalstockerror.Size = New System.Drawing.Size(81, 13)
        Me.Lbltotalstockerror.TabIndex = 36
        Me.Lbltotalstockerror.Text = "TotalStockError"
        '
        'StockAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(669, 348)
        Me.Controls.Add(Me.Lbltotalstockerror)
        Me.Controls.Add(Me.Lblpriceperitemerror)
        Me.Controls.Add(Me.Lblstoragestockerror)
        Me.Controls.Add(Me.Lbldisplaystockerror)
        Me.Controls.Add(Me.Lblproductnameerror)
        Me.Controls.Add(Me.Lblstock)
        Me.Controls.Add(Me.Btnupdatestock)
        Me.Controls.Add(Me.Btndeletestockpage)
        Me.Controls.Add(Me.Btnbacktomenu)
        Me.Controls.Add(Me.Btnlaststock)
        Me.Controls.Add(Me.Btnprevioustock)
        Me.Controls.Add(Me.Btnnextstock)
        Me.Controls.Add(Me.Btnfirststockdetails)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.Btncancel)
        Me.Controls.Add(Me.Txttotalstock)
        Me.Controls.Add(Me.Txtpriceperitem)
        Me.Controls.Add(Me.Txtquantityofstorage)
        Me.Controls.Add(Me.Txtquantitystock)
        Me.Controls.Add(Me.Txtproductname)
        Me.Controls.Add(Me.Txtstockid)
        Me.Controls.Add(Me.LblTotalStock)
        Me.Controls.Add(Me.LblPricePerItem)
        Me.Controls.Add(Me.LblQuantityOfStorageStock)
        Me.Controls.Add(Me.LblQuantityOfDisplayStock)
        Me.Controls.Add(Me.LblProductName)
        Me.Controls.Add(Me.LblStockID)
        Me.Controls.Add(Me.BtnBackToStockPage)
        Me.Name = "StockAdd"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnBackToStockPage As Button
    Friend WithEvents LblStockID As Label
    Friend WithEvents LblProductName As Label
    Friend WithEvents LblQuantityOfDisplayStock As Label
    Friend WithEvents LblQuantityOfStorageStock As Label
    Friend WithEvents LblPricePerItem As Label
    Friend WithEvents LblTotalStock As Label
    Friend WithEvents Txtstockid As TextBox
    Friend WithEvents Txtproductname As TextBox
    Friend WithEvents Txtquantitystock As TextBox
    Friend WithEvents Txtquantityofstorage As TextBox
    Friend WithEvents Txtpriceperitem As TextBox
    Friend WithEvents Txttotalstock As TextBox
    Friend WithEvents Btncancel As Button
    Friend WithEvents Btnclear As Button
    Friend WithEvents Btnfirststockdetails As Button
    Friend WithEvents Btnnextstock As Button
    Friend WithEvents Btnprevioustock As Button
    Friend WithEvents Btnlaststock As Button
    Friend WithEvents Btnbacktomenu As Button
    Friend WithEvents Btndeletestockpage As Button
    Friend WithEvents Btnupdatestock As Button
    Friend WithEvents Lblstock As Label
    Friend WithEvents Lblproductnameerror As Label
    Friend WithEvents Lbldisplaystockerror As Label
    Friend WithEvents Lblstoragestockerror As Label
    Friend WithEvents Lblpriceperitemerror As Label
    Friend WithEvents Lbltotalstockerror As Label
End Class
