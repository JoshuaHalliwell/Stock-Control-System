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
        Me.components = New System.ComponentModel.Container()
        Me.TbxStaffID = New System.Windows.Forms.TextBox()
        Me.TbxSalesID = New System.Windows.Forms.TextBox()
        Me.CbxProductName = New System.Windows.Forms.ComboBox()
        Me.TbxQuantity = New System.Windows.Forms.TextBox()
        Me.TbxPricePerItem = New System.Windows.Forms.TextBox()
        Me.TbxTotalPrice = New System.Windows.Forms.TextBox()
        Me.LblCustomerName = New System.Windows.Forms.Label()
        Me.LblStaffID = New System.Windows.Forms.Label()
        Me.LblSalesID = New System.Windows.Forms.Label()
        Me.LblProductName = New System.Windows.Forms.Label()
        Me.LblPricePerItem = New System.Windows.Forms.Label()
        Me.LblTotalPrice = New System.Windows.Forms.Label()
        Me.LbxOrder = New System.Windows.Forms.ListBox()
        Me.BtnAddItem = New System.Windows.Forms.Button()
        Me.BtnDeleteItem = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.StockDataBaseDSProductName = New Stock_Control_System.StockDataBaseDSProductName()
        Me.QryProductNameSaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QryProductNameSaleTableAdapter = New Stock_Control_System.StockDataBaseDSProductNameTableAdapters.QryProductNameSaleTableAdapter()
        Me.TbxStockID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblSaleTime = New System.Windows.Forms.Label()
        Me.TbxSaleTime = New System.Windows.Forms.TextBox()
        Me.LblSaleDay = New System.Windows.Forms.Label()
        Me.TbxSaleDay = New System.Windows.Forms.TextBox()
        Me.CbxCustomerName = New System.Windows.Forms.ComboBox()
        Me.TblCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataBaseDataSetCustomerName = New Stock_Control_System.StockDataBaseDataSetCustomerName()
        Me.TblCustomerTableAdapter = New Stock_Control_System.StockDataBaseDataSetCustomerNameTableAdapters.TblCustomerTableAdapter()
        Me.LblCustomerID = New System.Windows.Forms.Label()
        Me.TbxCustomerID = New System.Windows.Forms.TextBox()
        CType(Me.StockDataBaseDSProductName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryProductNameSaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataBaseDataSetCustomerName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbxStaffID
        '
        Me.TbxStaffID.Location = New System.Drawing.Point(158, 58)
        Me.TbxStaffID.Name = "TbxStaffID"
        Me.TbxStaffID.Size = New System.Drawing.Size(224, 20)
        Me.TbxStaffID.TabIndex = 1
        Me.TbxStaffID.Text = "TbxStaffID"
        '
        'TbxSalesID
        '
        Me.TbxSalesID.Location = New System.Drawing.Point(157, 84)
        Me.TbxSalesID.Name = "TbxSalesID"
        Me.TbxSalesID.Size = New System.Drawing.Size(224, 20)
        Me.TbxSalesID.TabIndex = 2
        Me.TbxSalesID.Text = "TbxSalesID"
        '
        'CbxProductName
        '
        Me.CbxProductName.FormattingEnabled = True
        Me.CbxProductName.Location = New System.Drawing.Point(157, 158)
        Me.CbxProductName.Name = "CbxProductName"
        Me.CbxProductName.Size = New System.Drawing.Size(224, 21)
        Me.CbxProductName.TabIndex = 3
        '
        'TbxQuantity
        '
        Me.TbxQuantity.Location = New System.Drawing.Point(157, 208)
        Me.TbxQuantity.Name = "TbxQuantity"
        Me.TbxQuantity.Size = New System.Drawing.Size(224, 20)
        Me.TbxQuantity.TabIndex = 4
        Me.TbxQuantity.Text = "TbxQuantity"
        '
        'TbxPricePerItem
        '
        Me.TbxPricePerItem.Location = New System.Drawing.Point(157, 236)
        Me.TbxPricePerItem.Name = "TbxPricePerItem"
        Me.TbxPricePerItem.Size = New System.Drawing.Size(224, 20)
        Me.TbxPricePerItem.TabIndex = 5
        Me.TbxPricePerItem.Text = "TbxPricePerItem"
        '
        'TbxTotalPrice
        '
        Me.TbxTotalPrice.Location = New System.Drawing.Point(157, 261)
        Me.TbxTotalPrice.Name = "TbxTotalPrice"
        Me.TbxTotalPrice.Size = New System.Drawing.Size(224, 20)
        Me.TbxTotalPrice.TabIndex = 6
        Me.TbxTotalPrice.Text = "TbxTotalPrice"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Location = New System.Drawing.Point(46, 5)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(79, 13)
        Me.LblCustomerName.TabIndex = 7
        Me.LblCustomerName.Text = "CustomerName"
        '
        'LblStaffID
        '
        Me.LblStaffID.AutoSize = True
        Me.LblStaffID.Location = New System.Drawing.Point(51, 60)
        Me.LblStaffID.Name = "LblStaffID"
        Me.LblStaffID.Size = New System.Drawing.Size(40, 13)
        Me.LblStaffID.TabIndex = 8
        Me.LblStaffID.Text = "StaffID"
        '
        'LblSalesID
        '
        Me.LblSalesID.AutoSize = True
        Me.LblSalesID.Location = New System.Drawing.Point(51, 87)
        Me.LblSalesID.Name = "LblSalesID"
        Me.LblSalesID.Size = New System.Drawing.Size(44, 13)
        Me.LblSalesID.TabIndex = 9
        Me.LblSalesID.Text = "SalesID"
        '
        'LblProductName
        '
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Location = New System.Drawing.Point(44, 160)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.Size = New System.Drawing.Size(72, 13)
        Me.LblProductName.TabIndex = 10
        Me.LblProductName.Text = "ProductName"
        '
        'LblPricePerItem
        '
        Me.LblPricePerItem.AutoSize = True
        Me.LblPricePerItem.Location = New System.Drawing.Point(51, 240)
        Me.LblPricePerItem.Name = "LblPricePerItem"
        Me.LblPricePerItem.Size = New System.Drawing.Size(67, 13)
        Me.LblPricePerItem.TabIndex = 12
        Me.LblPricePerItem.Text = "PricePerItem"
        '
        'LblTotalPrice
        '
        Me.LblTotalPrice.AutoSize = True
        Me.LblTotalPrice.Location = New System.Drawing.Point(51, 266)
        Me.LblTotalPrice.Name = "LblTotalPrice"
        Me.LblTotalPrice.Size = New System.Drawing.Size(55, 13)
        Me.LblTotalPrice.TabIndex = 13
        Me.LblTotalPrice.Text = "TotalPrice"
        '
        'LbxOrder
        '
        Me.LbxOrder.FormattingEnabled = True
        Me.LbxOrder.Location = New System.Drawing.Point(403, 11)
        Me.LbxOrder.Name = "LbxOrder"
        Me.LbxOrder.Size = New System.Drawing.Size(235, 277)
        Me.LbxOrder.TabIndex = 14
        '
        'BtnAddItem
        '
        Me.BtnAddItem.Location = New System.Drawing.Point(10, 288)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(178, 28)
        Me.BtnAddItem.TabIndex = 15
        Me.BtnAddItem.Text = "Add Item"
        Me.BtnAddItem.UseVisualStyleBackColor = True
        '
        'BtnDeleteItem
        '
        Me.BtnDeleteItem.Location = New System.Drawing.Point(202, 288)
        Me.BtnDeleteItem.Name = "BtnDeleteItem"
        Me.BtnDeleteItem.Size = New System.Drawing.Size(178, 28)
        Me.BtnDeleteItem.TabIndex = 16
        Me.BtnDeleteItem.Text = "Delete Item"
        Me.BtnDeleteItem.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(113, 322)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(178, 28)
        Me.BtnSubmit.TabIndex = 17
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'LblQuantity
        '
        Me.LblQuantity.AutoSize = True
        Me.LblQuantity.Location = New System.Drawing.Point(51, 213)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.LblQuantity.TabIndex = 11
        Me.LblQuantity.Text = "Quantity"
        '
        'StockDataBaseDSProductName
        '
        Me.StockDataBaseDSProductName.DataSetName = "StockDataBaseDSProductName"
        Me.StockDataBaseDSProductName.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QryProductNameSaleBindingSource
        '
        Me.QryProductNameSaleBindingSource.DataMember = "QryProductNameSale"
        Me.QryProductNameSaleBindingSource.DataSource = Me.StockDataBaseDSProductName
        '
        'QryProductNameSaleTableAdapter
        '
        Me.QryProductNameSaleTableAdapter.ClearBeforeFill = True
        '
        'TbxStockID
        '
        Me.TbxStockID.Location = New System.Drawing.Point(157, 184)
        Me.TbxStockID.Name = "TbxStockID"
        Me.TbxStockID.Size = New System.Drawing.Size(224, 20)
        Me.TbxStockID.TabIndex = 18
        Me.TbxStockID.Text = "TbxStockID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "StockID"
        '
        'LblSaleTime
        '
        Me.LblSaleTime.AutoSize = True
        Me.LblSaleTime.Location = New System.Drawing.Point(46, 136)
        Me.LblSaleTime.Name = "LblSaleTime"
        Me.LblSaleTime.Size = New System.Drawing.Size(51, 13)
        Me.LblSaleTime.TabIndex = 142
        Me.LblSaleTime.Text = "SaleTime"
        '
        'TbxSaleTime
        '
        Me.TbxSaleTime.Location = New System.Drawing.Point(158, 133)
        Me.TbxSaleTime.Name = "TbxSaleTime"
        Me.TbxSaleTime.Size = New System.Drawing.Size(224, 20)
        Me.TbxSaleTime.TabIndex = 143
        Me.TbxSaleTime.Text = "SaleTime"
        '
        'LblSaleDay
        '
        Me.LblSaleDay.AutoSize = True
        Me.LblSaleDay.Location = New System.Drawing.Point(51, 109)
        Me.LblSaleDay.Name = "LblSaleDay"
        Me.LblSaleDay.Size = New System.Drawing.Size(47, 13)
        Me.LblSaleDay.TabIndex = 144
        Me.LblSaleDay.Text = "SaleDay"
        '
        'TbxSaleDay
        '
        Me.TbxSaleDay.Location = New System.Drawing.Point(158, 109)
        Me.TbxSaleDay.Name = "TbxSaleDay"
        Me.TbxSaleDay.Size = New System.Drawing.Size(224, 20)
        Me.TbxSaleDay.TabIndex = 145
        Me.TbxSaleDay.Text = "SaleDay"
        '
        'CbxCustomerName
        '
        Me.CbxCustomerName.DataSource = Me.TblCustomerBindingSource
        Me.CbxCustomerName.DisplayMember = "CustomerFirstname"
        Me.CbxCustomerName.FormattingEnabled = True
        Me.CbxCustomerName.Location = New System.Drawing.Point(157, 5)
        Me.CbxCustomerName.Name = "CbxCustomerName"
        Me.CbxCustomerName.Size = New System.Drawing.Size(224, 21)
        Me.CbxCustomerName.TabIndex = 146
        Me.CbxCustomerName.ValueMember = "CustomerID"
        '
        'TblCustomerBindingSource
        '
        Me.TblCustomerBindingSource.DataMember = "TblCustomer"
        Me.TblCustomerBindingSource.DataSource = Me.StockDataBaseDataSetCustomerName
        '
        'StockDataBaseDataSetCustomerName
        '
        Me.StockDataBaseDataSetCustomerName.DataSetName = "StockDataBaseDataSetCustomerName"
        Me.StockDataBaseDataSetCustomerName.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCustomerTableAdapter
        '
        Me.TblCustomerTableAdapter.ClearBeforeFill = True
        '
        'LblCustomerID
        '
        Me.LblCustomerID.AutoSize = True
        Me.LblCustomerID.Location = New System.Drawing.Point(46, 32)
        Me.LblCustomerID.Name = "LblCustomerID"
        Me.LblCustomerID.Size = New System.Drawing.Size(62, 13)
        Me.LblCustomerID.TabIndex = 147
        Me.LblCustomerID.Text = "CustomerID"
        '
        'TbxCustomerID
        '
        Me.TbxCustomerID.Location = New System.Drawing.Point(157, 30)
        Me.TbxCustomerID.Name = "TbxCustomerID"
        Me.TbxCustomerID.Size = New System.Drawing.Size(224, 20)
        Me.TbxCustomerID.TabIndex = 148
        Me.TbxCustomerID.Text = "TxbCustomerID"
        '
        'ListProductOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(667, 349)
        Me.Controls.Add(Me.TbxCustomerID)
        Me.Controls.Add(Me.LblCustomerID)
        Me.Controls.Add(Me.CbxCustomerName)
        Me.Controls.Add(Me.TbxSaleDay)
        Me.Controls.Add(Me.LblSaleDay)
        Me.Controls.Add(Me.TbxSaleTime)
        Me.Controls.Add(Me.LblSaleTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbxStockID)
        Me.Controls.Add(Me.TbxPricePerItem)
        Me.Controls.Add(Me.LblPricePerItem)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.BtnDeleteItem)
        Me.Controls.Add(Me.BtnAddItem)
        Me.Controls.Add(Me.LbxOrder)
        Me.Controls.Add(Me.LblTotalPrice)
        Me.Controls.Add(Me.LblQuantity)
        Me.Controls.Add(Me.LblProductName)
        Me.Controls.Add(Me.LblSalesID)
        Me.Controls.Add(Me.LblStaffID)
        Me.Controls.Add(Me.LblCustomerName)
        Me.Controls.Add(Me.TbxTotalPrice)
        Me.Controls.Add(Me.TbxQuantity)
        Me.Controls.Add(Me.CbxProductName)
        Me.Controls.Add(Me.TbxSalesID)
        Me.Controls.Add(Me.TbxStaffID)
        Me.Name = "ListProductOrders"
        Me.Text = "ListProductOrders"
        CType(Me.StockDataBaseDSProductName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryProductNameSaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataBaseDataSetCustomerName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbxStaffID As TextBox
    Friend WithEvents TbxSalesID As TextBox
    Friend WithEvents CbxProductName As ComboBox
    Friend WithEvents TbxQuantity As TextBox
    Friend WithEvents TbxPricePerItem As TextBox
    Friend WithEvents TbxTotalPrice As TextBox
    Friend WithEvents LblCustomerName As Label
    Friend WithEvents LblStaffID As Label
    Friend WithEvents LblSalesID As Label
    Friend WithEvents LblProductName As Label
    Friend WithEvents LblPricePerItem As Label
    Friend WithEvents LblTotalPrice As Label
    Friend WithEvents LbxOrder As ListBox
    Friend WithEvents BtnAddItem As Button
    Friend WithEvents BtnDeleteItem As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents LblQuantity As Label
    Friend WithEvents StockDataBaseDSProductName As StockDataBaseDSProductName
    Friend WithEvents QryProductNameSaleBindingSource As BindingSource
    Friend WithEvents QryProductNameSaleTableAdapter As StockDataBaseDSProductNameTableAdapters.QryProductNameSaleTableAdapter
    Friend WithEvents TbxStockID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblSaleTime As Label
    Friend WithEvents TbxSaleTime As TextBox
    Friend WithEvents LblSaleDay As Label
    Friend WithEvents TbxSaleDay As TextBox
    Friend WithEvents CbxCustomerName As ComboBox
    Friend WithEvents StockDataBaseDataSetCustomerName As StockDataBaseDataSetCustomerName
    Friend WithEvents TblCustomerBindingSource As BindingSource
    Friend WithEvents TblCustomerTableAdapter As StockDataBaseDataSetCustomerNameTableAdapters.TblCustomerTableAdapter
    Friend WithEvents LblCustomerID As Label
    Friend WithEvents TbxCustomerID As TextBox
End Class
