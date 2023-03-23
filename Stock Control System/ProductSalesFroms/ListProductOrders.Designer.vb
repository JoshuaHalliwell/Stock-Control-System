<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListProductOrders
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
        Me.TbxCustomerID = New System.Windows.Forms.TextBox()
        Me.TbxStaffID = New System.Windows.Forms.TextBox()
        Me.TbxSalesID = New System.Windows.Forms.TextBox()
        Me.CbxStockID = New System.Windows.Forms.ComboBox()
        Me.TbxQuantity = New System.Windows.Forms.TextBox()
        Me.TbxPricePerItem = New System.Windows.Forms.TextBox()
        Me.TbxTotalPrice = New System.Windows.Forms.TextBox()
        Me.LblCustomerID = New System.Windows.Forms.Label()
        Me.LblStaffID = New System.Windows.Forms.Label()
        Me.LblSalesID = New System.Windows.Forms.Label()
        Me.LblStockID = New System.Windows.Forms.Label()
        Me.LblPricePerItem = New System.Windows.Forms.Label()
        Me.LblTotalPrice = New System.Windows.Forms.Label()
        Me.LbxOrder = New System.Windows.Forms.ListBox()
        Me.BtnAddItem = New System.Windows.Forms.Button()
        Me.BtnDeleteItem = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TbxCustomerID
        '
        Me.TbxCustomerID.Location = New System.Drawing.Point(156, 38)
        Me.TbxCustomerID.Name = "TbxCustomerID"
        Me.TbxCustomerID.Size = New System.Drawing.Size(224, 20)
        Me.TbxCustomerID.TabIndex = 0
        Me.TbxCustomerID.Text = "TbxStockID"
        '
        'TbxStaffID
        '
        Me.TbxStaffID.Location = New System.Drawing.Point(156, 73)
        Me.TbxStaffID.Name = "TbxStaffID"
        Me.TbxStaffID.Size = New System.Drawing.Size(224, 20)
        Me.TbxStaffID.TabIndex = 1
        Me.TbxStaffID.Text = "TbxStaffID"
        '
        'TbxSalesID
        '
        Me.TbxSalesID.Location = New System.Drawing.Point(156, 108)
        Me.TbxSalesID.Name = "TbxSalesID"
        Me.TbxSalesID.Size = New System.Drawing.Size(224, 20)
        Me.TbxSalesID.TabIndex = 2
        Me.TbxSalesID.Text = "TbxSalesID"
        '
        'CbxStockID
        '
        Me.CbxStockID.FormattingEnabled = True
        Me.CbxStockID.Location = New System.Drawing.Point(156, 139)
        Me.CbxStockID.Name = "CbxStockID"
        Me.CbxStockID.Size = New System.Drawing.Size(224, 21)
        Me.CbxStockID.TabIndex = 3
        '
        'TbxQuantity
        '
        Me.TbxQuantity.Location = New System.Drawing.Point(156, 177)
        Me.TbxQuantity.Name = "TbxQuantity"
        Me.TbxQuantity.Size = New System.Drawing.Size(224, 20)
        Me.TbxQuantity.TabIndex = 4
        Me.TbxQuantity.Text = "TbxQuantity"
        '
        'TbxPricePerItem
        '
        Me.TbxPricePerItem.Location = New System.Drawing.Point(156, 207)
        Me.TbxPricePerItem.Name = "TbxPricePerItem"
        Me.TbxPricePerItem.Size = New System.Drawing.Size(224, 20)
        Me.TbxPricePerItem.TabIndex = 5
        Me.TbxPricePerItem.Text = "TbxPricePerItem"
        '
        'TbxTotalPrice
        '
        Me.TbxTotalPrice.Location = New System.Drawing.Point(156, 236)
        Me.TbxTotalPrice.Name = "TbxTotalPrice"
        Me.TbxTotalPrice.Size = New System.Drawing.Size(224, 20)
        Me.TbxTotalPrice.TabIndex = 6
        Me.TbxTotalPrice.Text = "TbxTotalPrice"
        '
        'LblCustomerID
        '
        Me.LblCustomerID.AutoSize = True
        Me.LblCustomerID.Location = New System.Drawing.Point(37, 41)
        Me.LblCustomerID.Name = "LblCustomerID"
        Me.LblCustomerID.Size = New System.Drawing.Size(62, 13)
        Me.LblCustomerID.TabIndex = 7
        Me.LblCustomerID.Text = "CustomerID"
        '
        'LblStaffID
        '
        Me.LblStaffID.AutoSize = True
        Me.LblStaffID.Location = New System.Drawing.Point(37, 80)
        Me.LblStaffID.Name = "LblStaffID"
        Me.LblStaffID.Size = New System.Drawing.Size(40, 13)
        Me.LblStaffID.TabIndex = 8
        Me.LblStaffID.Text = "StaffID"
        '
        'LblSalesID
        '
        Me.LblSalesID.AutoSize = True
        Me.LblSalesID.Location = New System.Drawing.Point(37, 115)
        Me.LblSalesID.Name = "LblSalesID"
        Me.LblSalesID.Size = New System.Drawing.Size(44, 13)
        Me.LblSalesID.TabIndex = 9
        Me.LblSalesID.Text = "SalesID"
        '
        'LblStockID
        '
        Me.LblStockID.AutoSize = True
        Me.LblStockID.Location = New System.Drawing.Point(37, 147)
        Me.LblStockID.Name = "LblStockID"
        Me.LblStockID.Size = New System.Drawing.Size(46, 13)
        Me.LblStockID.TabIndex = 10
        Me.LblStockID.Text = "StockID"
        '
        'LblPricePerItem
        '
        Me.LblPricePerItem.AutoSize = True
        Me.LblPricePerItem.Location = New System.Drawing.Point(32, 210)
        Me.LblPricePerItem.Name = "LblPricePerItem"
        Me.LblPricePerItem.Size = New System.Drawing.Size(67, 13)
        Me.LblPricePerItem.TabIndex = 12
        Me.LblPricePerItem.Text = "PricePerItem"
        '
        'LblTotalPrice
        '
        Me.LblTotalPrice.AutoSize = True
        Me.LblTotalPrice.Location = New System.Drawing.Point(37, 243)
        Me.LblTotalPrice.Name = "LblTotalPrice"
        Me.LblTotalPrice.Size = New System.Drawing.Size(55, 13)
        Me.LblTotalPrice.TabIndex = 13
        Me.LblTotalPrice.Text = "TotalPrice"
        '
        'LbxOrder
        '
        Me.LbxOrder.FormattingEnabled = True
        Me.LbxOrder.Location = New System.Drawing.Point(406, 39)
        Me.LbxOrder.Name = "LbxOrder"
        Me.LbxOrder.Size = New System.Drawing.Size(235, 277)
        Me.LbxOrder.TabIndex = 14
        '
        'BtnAddItem
        '
        Me.BtnAddItem.Location = New System.Drawing.Point(12, 262)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(178, 37)
        Me.BtnAddItem.TabIndex = 15
        Me.BtnAddItem.Text = "Add Item"
        Me.BtnAddItem.UseVisualStyleBackColor = True
        '
        'BtnDeleteItem
        '
        Me.BtnDeleteItem.Location = New System.Drawing.Point(202, 262)
        Me.BtnDeleteItem.Name = "BtnDeleteItem"
        Me.BtnDeleteItem.Size = New System.Drawing.Size(178, 37)
        Me.BtnDeleteItem.TabIndex = 16
        Me.BtnDeleteItem.Text = "Delete Item"
        Me.BtnDeleteItem.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(89, 305)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(213, 34)
        Me.BtnSubmit.TabIndex = 17
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'LblQuantity
        '
        Me.LblQuantity.AutoSize = True
        Me.LblQuantity.Location = New System.Drawing.Point(37, 180)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.LblQuantity.TabIndex = 11
        Me.LblQuantity.Text = "Quantity"
        '
        'ListProductOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(667, 349)
        Me.Controls.Add(Me.TbxPricePerItem)
        Me.Controls.Add(Me.LblPricePerItem)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.BtnDeleteItem)
        Me.Controls.Add(Me.BtnAddItem)
        Me.Controls.Add(Me.LbxOrder)
        Me.Controls.Add(Me.LblTotalPrice)
        Me.Controls.Add(Me.LblQuantity)
        Me.Controls.Add(Me.LblStockID)
        Me.Controls.Add(Me.LblSalesID)
        Me.Controls.Add(Me.LblStaffID)
        Me.Controls.Add(Me.LblCustomerID)
        Me.Controls.Add(Me.TbxTotalPrice)
        Me.Controls.Add(Me.TbxQuantity)
        Me.Controls.Add(Me.CbxStockID)
        Me.Controls.Add(Me.TbxSalesID)
        Me.Controls.Add(Me.TbxStaffID)
        Me.Controls.Add(Me.TbxCustomerID)
        Me.Name = "ListProductOrders"
        Me.Text = "ListProductOrders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbxCustomerID As TextBox
    Friend WithEvents TbxStaffID As TextBox
    Friend WithEvents TbxSalesID As TextBox
    Friend WithEvents CbxStockID As ComboBox
    Friend WithEvents TbxQuantity As TextBox
    Friend WithEvents TbxPricePerItem As TextBox
    Friend WithEvents TbxTotalPrice As TextBox
    Friend WithEvents LblCustomerID As Label
    Friend WithEvents LblStaffID As Label
    Friend WithEvents LblSalesID As Label
    Friend WithEvents LblStockID As Label
    Friend WithEvents LblPricePerItem As Label
    Friend WithEvents LblTotalPrice As Label
    Friend WithEvents LbxOrder As ListBox
    Friend WithEvents BtnAddItem As Button
    Friend WithEvents BtnDeleteItem As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents LblQuantity As Label
End Class
