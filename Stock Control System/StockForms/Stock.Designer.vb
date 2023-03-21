<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Me.components = New System.ComponentModel.Container()
        Me.GrpSort = New System.Windows.Forms.GroupBox()
        Me.Llbchange = New System.Windows.Forms.Label()
        Me.cbproductchange = New System.Windows.Forms.ComboBox()
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.txbname = New System.Windows.Forms.TextBox()
        Me.txbID = New System.Windows.Forms.TextBox()
        Me.radID = New System.Windows.Forms.RadioButton()
        Me.radName = New System.Windows.Forms.RadioButton()
        Me.DGVStock = New System.Windows.Forms.DataGridView()
        Me.TblStocksBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnSearchStock = New System.Windows.Forms.Button()
        Me.BtnSortByDisplayStock = New System.Windows.Forms.Button()
        Me.BtnDeleteStock = New System.Windows.Forms.Button()
        Me.BtnAddStock = New System.Windows.Forms.Button()
        Me.BtnUpdateStock = New System.Windows.Forms.Button()
        Me.BtnSortByStorageStock = New System.Windows.Forms.Button()
        Me.GrpSort.SuspendLayout()
        Me.GrpSearch.SuspendLayout()
        CType(Me.DGVStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStocksBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpSort
        '
        Me.GrpSort.Controls.Add(Me.Llbchange)
        Me.GrpSort.Controls.Add(Me.cbproductchange)
        Me.GrpSort.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSort.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrpSort.Location = New System.Drawing.Point(431, 12)
        Me.GrpSort.Name = "GrpSort"
        Me.GrpSort.Size = New System.Drawing.Size(222, 164)
        Me.GrpSort.TabIndex = 65
        Me.GrpSort.TabStop = False
        Me.GrpSort.Text = "Sort By:"
        '
        'Llbchange
        '
        Me.Llbchange.AutoSize = True
        Me.Llbchange.Location = New System.Drawing.Point(32, 46)
        Me.Llbchange.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Llbchange.Name = "Llbchange"
        Me.Llbchange.Size = New System.Drawing.Size(73, 24)
        Me.Llbchange.TabIndex = 59
        Me.Llbchange.Text = "Label1"
        '
        'cbproductchange
        '
        Me.cbproductchange.FormattingEnabled = True
        Me.cbproductchange.Location = New System.Drawing.Point(0, 84)
        Me.cbproductchange.Name = "cbproductchange"
        Me.cbproductchange.Size = New System.Drawing.Size(216, 32)
        Me.cbproductchange.TabIndex = 58
        '
        'GrpSearch
        '
        Me.GrpSearch.Controls.Add(Me.txbname)
        Me.GrpSearch.Controls.Add(Me.txbID)
        Me.GrpSearch.Controls.Add(Me.radID)
        Me.GrpSearch.Controls.Add(Me.radName)
        Me.GrpSearch.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSearch.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrpSearch.Location = New System.Drawing.Point(425, 182)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Size = New System.Drawing.Size(232, 164)
        Me.GrpSearch.TabIndex = 70
        Me.GrpSearch.TabStop = False
        Me.GrpSearch.Text = "Search For:"
        '
        'txbname
        '
        Me.txbname.Location = New System.Drawing.Point(6, 121)
        Me.txbname.Name = "txbname"
        Me.txbname.Size = New System.Drawing.Size(216, 32)
        Me.txbname.TabIndex = 60
        '
        'txbID
        '
        Me.txbID.Location = New System.Drawing.Point(9, 59)
        Me.txbID.Name = "txbID"
        Me.txbID.Size = New System.Drawing.Size(213, 32)
        Me.txbID.TabIndex = 59
        '
        'radID
        '
        Me.radID.AutoSize = True
        Me.radID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radID.Location = New System.Drawing.Point(6, 31)
        Me.radID.Name = "radID"
        Me.radID.Size = New System.Drawing.Size(81, 22)
        Me.radID.TabIndex = 0
        Me.radID.TabStop = True
        Me.radID.Text = "StockID"
        Me.radID.UseVisualStyleBackColor = True
        '
        'radName
        '
        Me.radName.AutoSize = True
        Me.radName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radName.Location = New System.Drawing.Point(6, 97)
        Me.radName.Name = "radName"
        Me.radName.Size = New System.Drawing.Size(122, 22)
        Me.radName.TabIndex = 0
        Me.radName.TabStop = True
        Me.radName.Text = "ProductName"
        Me.radName.UseVisualStyleBackColor = True
        '
        'DGVStock
        '
        Me.DGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVStock.Location = New System.Drawing.Point(-5, 12)
        Me.DGVStock.Name = "DGVStock"
        Me.DGVStock.Size = New System.Drawing.Size(424, 191)
        Me.DGVStock.TabIndex = 63
        '
        'BtnSearchStock
        '
        Me.BtnSearchStock.Location = New System.Drawing.Point(285, 293)
        Me.BtnSearchStock.Name = "BtnSearchStock"
        Me.BtnSearchStock.Size = New System.Drawing.Size(112, 42)
        Me.BtnSearchStock.TabIndex = 75
        Me.BtnSearchStock.Text = "Search Stock"
        Me.BtnSearchStock.UseVisualStyleBackColor = True
        '
        'BtnSortByDisplayStock
        '
        Me.BtnSortByDisplayStock.Location = New System.Drawing.Point(12, 299)
        Me.BtnSortByDisplayStock.Name = "BtnSortByDisplayStock"
        Me.BtnSortByDisplayStock.Size = New System.Drawing.Size(112, 42)
        Me.BtnSortByDisplayStock.TabIndex = 76
        Me.BtnSortByDisplayStock.Text = "Sort By Display Stock"
        Me.BtnSortByDisplayStock.UseVisualStyleBackColor = True
        '
        'BtnDeleteStock
        '
        Me.BtnDeleteStock.Location = New System.Drawing.Point(151, 222)
        Me.BtnDeleteStock.Name = "BtnDeleteStock"
        Me.BtnDeleteStock.Size = New System.Drawing.Size(112, 42)
        Me.BtnDeleteStock.TabIndex = 77
        Me.BtnDeleteStock.Text = "Delete Stock"
        Me.BtnDeleteStock.UseVisualStyleBackColor = True
        '
        'BtnAddStock
        '
        Me.BtnAddStock.Location = New System.Drawing.Point(12, 222)
        Me.BtnAddStock.Name = "BtnAddStock"
        Me.BtnAddStock.Size = New System.Drawing.Size(112, 42)
        Me.BtnAddStock.TabIndex = 78
        Me.BtnAddStock.Text = "Add Stock"
        Me.BtnAddStock.UseVisualStyleBackColor = True
        '
        'BtnUpdateStock
        '
        Me.BtnUpdateStock.Location = New System.Drawing.Point(285, 222)
        Me.BtnUpdateStock.Name = "BtnUpdateStock"
        Me.BtnUpdateStock.Size = New System.Drawing.Size(112, 42)
        Me.BtnUpdateStock.TabIndex = 79
        Me.BtnUpdateStock.Text = "Update Stock"
        Me.BtnUpdateStock.UseVisualStyleBackColor = True
        '
        'BtnSortByStorageStock
        '
        Me.BtnSortByStorageStock.Location = New System.Drawing.Point(151, 293)
        Me.BtnSortByStorageStock.Name = "BtnSortByStorageStock"
        Me.BtnSortByStorageStock.Size = New System.Drawing.Size(112, 42)
        Me.BtnSortByStorageStock.TabIndex = 80
        Me.BtnSortByStorageStock.Text = "Sort by Storage Stock"
        Me.BtnSortByStorageStock.UseVisualStyleBackColor = True
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(669, 348)
        Me.Controls.Add(Me.BtnSortByStorageStock)
        Me.Controls.Add(Me.BtnUpdateStock)
        Me.Controls.Add(Me.BtnAddStock)
        Me.Controls.Add(Me.BtnDeleteStock)
        Me.Controls.Add(Me.BtnSortByDisplayStock)
        Me.Controls.Add(Me.BtnSearchStock)
        Me.Controls.Add(Me.DGVStock)
        Me.Controls.Add(Me.GrpSearch)
        Me.Controls.Add(Me.GrpSort)
        Me.Name = "Stock"
        Me.Text = "Stock"
        Me.GrpSort.ResumeLayout(False)
        Me.GrpSort.PerformLayout()
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        CType(Me.DGVStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStocksBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpSort As GroupBox
    Friend WithEvents Llbchange As Label
    Friend WithEvents cbproductchange As ComboBox
    Friend WithEvents GrpSearch As GroupBox
    Friend WithEvents txbname As TextBox
    Friend WithEvents txbID As TextBox
    Friend WithEvents radID As RadioButton
    Friend WithEvents radName As RadioButton
    Friend WithEvents DGVStock As DataGridView
    Friend WithEvents BtnSearchStock As Button
    Friend WithEvents BtnSortByDisplayStock As Button
    Friend WithEvents BtnDeleteStock As Button
    Friend WithEvents BtnAddStock As Button
    'Friend WithEvents StockDataBase_copyDataSet1 As StockDataBase_copyDataSet1
    'Friend WithEvents TblStocksBindingSource As BindingSource
    'Friend WithEvents TblStocksTableAdapter As StockDataBase_copyDataSet1TableAdapters.TblStocksTableAdapter
    Friend WithEvents StockIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityOfDisplayStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityOfStorageStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PricePerIteamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BtnUpdateStock As Button
    Friend WithEvents BtnSortByStorageStock As Button
    'Friend WithEvents StockDataBaseStockViewing As StockDataBaseStockViewing
    Friend WithEvents TblStocksBindingSource1 As BindingSource
    'Friend WithEvents TblStocksTableAdapter1 As StockDataBaseStockViewingTableAdapters.TblStocksTableAdapter
End Class
