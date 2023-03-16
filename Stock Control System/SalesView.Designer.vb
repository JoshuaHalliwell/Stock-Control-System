<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesView
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
        Me.BtnSortCustomers = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.RadQuantity = New System.Windows.Forms.RadioButton()
        Me.txbname = New System.Windows.Forms.TextBox()
        Me.txbID = New System.Windows.Forms.TextBox()
        Me.radID = New System.Windows.Forms.RadioButton()
        Me.radName = New System.Windows.Forms.RadioButton()
        Me.GrpSort = New System.Windows.Forms.GroupBox()
        Me.Llbchange = New System.Windows.Forms.Label()
        Me.cbproductchange = New System.Windows.Forms.ComboBox()
        Me.DGVCustomers = New System.Windows.Forms.DataGridView()
        Me.BtnSearchSalesLine = New System.Windows.Forms.Button()
        Me.GrpSearch.SuspendLayout()
        Me.GrpSort.SuspendLayout()
        CType(Me.DGVCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSortCustomers
        '
        Me.BtnSortCustomers.Location = New System.Drawing.Point(-1, 289)
        Me.BtnSortCustomers.Name = "BtnSortCustomers"
        Me.BtnSortCustomers.Size = New System.Drawing.Size(141, 42)
        Me.BtnSortCustomers.TabIndex = 83
        Me.BtnSortCustomers.Text = "Sort Product Sales"
        Me.BtnSortCustomers.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(-1, 233)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(141, 42)
        Me.BtnAdd.TabIndex = 82
        Me.BtnAdd.Text = "Add Product Sales"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(144, 232)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(141, 42)
        Me.BtnEdit.TabIndex = 81
        Me.BtnEdit.Text = "Edit Product Sales"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(291, 233)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(141, 42)
        Me.BtnDelete.TabIndex = 80
        Me.BtnDelete.Text = "Delete Product Sales"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'GrpSearch
        '
        Me.GrpSearch.Controls.Add(Me.txbEmail)
        Me.GrpSearch.Controls.Add(Me.RadQuantity)
        Me.GrpSearch.Controls.Add(Me.txbname)
        Me.GrpSearch.Controls.Add(Me.txbID)
        Me.GrpSearch.Controls.Add(Me.radID)
        Me.GrpSearch.Controls.Add(Me.radName)
        Me.GrpSearch.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSearch.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrpSearch.Location = New System.Drawing.Point(438, 135)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Size = New System.Drawing.Size(232, 210)
        Me.GrpSearch.TabIndex = 79
        Me.GrpSearch.TabStop = False
        Me.GrpSearch.Text = "Search For:"
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(6, 176)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(216, 32)
        Me.txbEmail.TabIndex = 62
        '
        'RadQuantity
        '
        Me.RadQuantity.AutoSize = True
        Me.RadQuantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadQuantity.Location = New System.Drawing.Point(6, 154)
        Me.RadQuantity.Name = "RadQuantity"
        Me.RadQuantity.Size = New System.Drawing.Size(82, 22)
        Me.RadQuantity.TabIndex = 61
        Me.RadQuantity.TabStop = True
        Me.RadQuantity.Text = "Quantity"
        Me.RadQuantity.UseVisualStyleBackColor = True
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
        Me.radID.Size = New System.Drawing.Size(73, 22)
        Me.radID.TabIndex = 0
        Me.radID.TabStop = True
        Me.radID.Text = "SaleID"
        Me.radID.UseVisualStyleBackColor = True
        '
        'radName
        '
        Me.radName.AutoSize = True
        Me.radName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radName.Location = New System.Drawing.Point(6, 97)
        Me.radName.Name = "radName"
        Me.radName.Size = New System.Drawing.Size(81, 22)
        Me.radName.TabIndex = 0
        Me.radName.TabStop = True
        Me.radName.Text = "StockID"
        Me.radName.UseVisualStyleBackColor = True
        '
        'GrpSort
        '
        Me.GrpSort.Controls.Add(Me.Llbchange)
        Me.GrpSort.Controls.Add(Me.cbproductchange)
        Me.GrpSort.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSort.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrpSort.Location = New System.Drawing.Point(438, 3)
        Me.GrpSort.Name = "GrpSort"
        Me.GrpSort.Size = New System.Drawing.Size(232, 126)
        Me.GrpSort.TabIndex = 78
        Me.GrpSort.TabStop = False
        Me.GrpSort.Text = "Sort By:"
        '
        'Llbchange
        '
        Me.Llbchange.AutoSize = True
        Me.Llbchange.Location = New System.Drawing.Point(32, 46)
        Me.Llbchange.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Llbchange.Name = "Llbchange"
        Me.Llbchange.Size = New System.Drawing.Size(130, 24)
        Me.Llbchange.TabIndex = 59
        Me.Llbchange.Text = "Date or Time"
        '
        'cbproductchange
        '
        Me.cbproductchange.FormattingEnabled = True
        Me.cbproductchange.Location = New System.Drawing.Point(10, 88)
        Me.cbproductchange.Name = "cbproductchange"
        Me.cbproductchange.Size = New System.Drawing.Size(216, 32)
        Me.cbproductchange.TabIndex = 58
        '
        'DGVCustomers
        '
        Me.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCustomers.Location = New System.Drawing.Point(-1, 3)
        Me.DGVCustomers.Name = "DGVCustomers"
        Me.DGVCustomers.Size = New System.Drawing.Size(433, 217)
        Me.DGVCustomers.TabIndex = 77
        '
        'BtnSearchSalesLine
        '
        Me.BtnSearchSalesLine.Location = New System.Drawing.Point(291, 289)
        Me.BtnSearchSalesLine.Name = "BtnSearchSalesLine"
        Me.BtnSearchSalesLine.Size = New System.Drawing.Size(141, 42)
        Me.BtnSearchSalesLine.TabIndex = 76
        Me.BtnSearchSalesLine.Text = "Search Product Sales"
        Me.BtnSearchSalesLine.UseVisualStyleBackColor = True
        '
        'SalesView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(669, 348)
        Me.Controls.Add(Me.BtnSortCustomers)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.GrpSearch)
        Me.Controls.Add(Me.GrpSort)
        Me.Controls.Add(Me.DGVCustomers)
        Me.Controls.Add(Me.BtnSearchSalesLine)
        Me.Name = "SalesView"
        Me.Text = "SalesView"
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        Me.GrpSort.ResumeLayout(False)
        Me.GrpSort.PerformLayout()
        CType(Me.DGVCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSortCustomers As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents GrpSearch As GroupBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents RadQuantity As RadioButton
    Friend WithEvents txbname As TextBox
    Friend WithEvents txbID As TextBox
    Friend WithEvents radID As RadioButton
    Friend WithEvents radName As RadioButton
    Friend WithEvents GrpSort As GroupBox
    Friend WithEvents Llbchange As Label
    Friend WithEvents cbproductchange As ComboBox
    Friend WithEvents DGVCustomers As DataGridView
    Friend WithEvents BtnSearchSalesLine As Button
End Class
