<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customers
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
        Me.BtnSearchCustomer = New System.Windows.Forms.Button()
        Me.DGVCustomers = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerFirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerSurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPostcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataBase_copyDataSet = New Stock_Control_System.StockDataBase_copyDataSet()
        Me.GrpSort = New System.Windows.Forms.GroupBox()
        Me.Llbchange = New System.Windows.Forms.Label()
        Me.cbproductchange = New System.Windows.Forms.ComboBox()
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.RadCustomerEmail = New System.Windows.Forms.RadioButton()
        Me.txbname = New System.Windows.Forms.TextBox()
        Me.txbID = New System.Windows.Forms.TextBox()
        Me.radID = New System.Windows.Forms.RadioButton()
        Me.radName = New System.Windows.Forms.RadioButton()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSortCustomers = New System.Windows.Forms.Button()
        Me.TblCustomerTableAdapter = New Stock_Control_System.StockDataBase_copyDataSetTableAdapters.TblCustomerTableAdapter()
        CType(Me.DGVCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataBase_copyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSort.SuspendLayout()
        Me.GrpSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSearchCustomer
        '
        Me.BtnSearchCustomer.Location = New System.Drawing.Point(292, 298)
        Me.BtnSearchCustomer.Name = "BtnSearchCustomer"
        Me.BtnSearchCustomer.Size = New System.Drawing.Size(141, 42)
        Me.BtnSearchCustomer.TabIndex = 3
        Me.BtnSearchCustomer.Text = "Search customer"
        Me.BtnSearchCustomer.UseVisualStyleBackColor = True
        '
        'DGVCustomers
        '
        Me.DGVCustomers.AutoGenerateColumns = False
        Me.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.CustomerFirstnameDataGridViewTextBoxColumn, Me.CustomerSurnameDataGridViewTextBoxColumn, Me.CustomerEmailDataGridViewTextBoxColumn, Me.CustomerPhoneNumberDataGridViewTextBoxColumn, Me.CustomerPostcodeDataGridViewTextBoxColumn})
        Me.DGVCustomers.DataSource = Me.TblCustomerBindingSource
        Me.DGVCustomers.Location = New System.Drawing.Point(0, 12)
        Me.DGVCustomers.Name = "DGVCustomers"
        Me.DGVCustomers.Size = New System.Drawing.Size(433, 217)
        Me.DGVCustomers.TabIndex = 7
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'CustomerFirstnameDataGridViewTextBoxColumn
        '
        Me.CustomerFirstnameDataGridViewTextBoxColumn.DataPropertyName = "CustomerFirstname"
        Me.CustomerFirstnameDataGridViewTextBoxColumn.HeaderText = "CustomerFirstname"
        Me.CustomerFirstnameDataGridViewTextBoxColumn.Name = "CustomerFirstnameDataGridViewTextBoxColumn"
        '
        'CustomerSurnameDataGridViewTextBoxColumn
        '
        Me.CustomerSurnameDataGridViewTextBoxColumn.DataPropertyName = "CustomerSurname"
        Me.CustomerSurnameDataGridViewTextBoxColumn.HeaderText = "CustomerSurname"
        Me.CustomerSurnameDataGridViewTextBoxColumn.Name = "CustomerSurnameDataGridViewTextBoxColumn"
        '
        'CustomerEmailDataGridViewTextBoxColumn
        '
        Me.CustomerEmailDataGridViewTextBoxColumn.DataPropertyName = "CustomerEmail"
        Me.CustomerEmailDataGridViewTextBoxColumn.HeaderText = "CustomerEmail"
        Me.CustomerEmailDataGridViewTextBoxColumn.Name = "CustomerEmailDataGridViewTextBoxColumn"
        '
        'CustomerPhoneNumberDataGridViewTextBoxColumn
        '
        Me.CustomerPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhoneNumber"
        Me.CustomerPhoneNumberDataGridViewTextBoxColumn.HeaderText = "CustomerPhoneNumber"
        Me.CustomerPhoneNumberDataGridViewTextBoxColumn.Name = "CustomerPhoneNumberDataGridViewTextBoxColumn"
        '
        'CustomerPostcodeDataGridViewTextBoxColumn
        '
        Me.CustomerPostcodeDataGridViewTextBoxColumn.DataPropertyName = "CustomerPostcode"
        Me.CustomerPostcodeDataGridViewTextBoxColumn.HeaderText = "CustomerPostcode"
        Me.CustomerPostcodeDataGridViewTextBoxColumn.Name = "CustomerPostcodeDataGridViewTextBoxColumn"
        '
        'TblCustomerBindingSource
        '
        Me.TblCustomerBindingSource.DataMember = "TblCustomer"
        Me.TblCustomerBindingSource.DataSource = Me.StockDataBase_copyDataSet
        '
        'StockDataBase_copyDataSet
        '
        Me.StockDataBase_copyDataSet.DataSetName = "StockDataBase_copyDataSet"
        Me.StockDataBase_copyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GrpSort
        '
        Me.GrpSort.Controls.Add(Me.Llbchange)
        Me.GrpSort.Controls.Add(Me.cbproductchange)
        Me.GrpSort.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSort.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrpSort.Location = New System.Drawing.Point(439, 12)
        Me.GrpSort.Name = "GrpSort"
        Me.GrpSort.Size = New System.Drawing.Size(232, 126)
        Me.GrpSort.TabIndex = 64
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
        Me.cbproductchange.Location = New System.Drawing.Point(10, 88)
        Me.cbproductchange.Name = "cbproductchange"
        Me.cbproductchange.Size = New System.Drawing.Size(216, 32)
        Me.cbproductchange.TabIndex = 58
        '
        'GrpSearch
        '
        Me.GrpSearch.Controls.Add(Me.txbEmail)
        Me.GrpSearch.Controls.Add(Me.RadCustomerEmail)
        Me.GrpSearch.Controls.Add(Me.txbname)
        Me.GrpSearch.Controls.Add(Me.txbID)
        Me.GrpSearch.Controls.Add(Me.radID)
        Me.GrpSearch.Controls.Add(Me.radName)
        Me.GrpSearch.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSearch.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrpSearch.Location = New System.Drawing.Point(439, 144)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Size = New System.Drawing.Size(232, 210)
        Me.GrpSearch.TabIndex = 69
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
        'RadCustomerEmail
        '
        Me.RadCustomerEmail.AutoSize = True
        Me.RadCustomerEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadCustomerEmail.Location = New System.Drawing.Point(6, 154)
        Me.RadCustomerEmail.Name = "RadCustomerEmail"
        Me.RadCustomerEmail.Size = New System.Drawing.Size(138, 22)
        Me.RadCustomerEmail.TabIndex = 61
        Me.RadCustomerEmail.TabStop = True
        Me.RadCustomerEmail.Text = "Customer Email"
        Me.RadCustomerEmail.UseVisualStyleBackColor = True
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
        Me.radID.Size = New System.Drawing.Size(113, 22)
        Me.radID.TabIndex = 0
        Me.radID.TabStop = True
        Me.radID.Text = "Customer ID"
        Me.radID.UseVisualStyleBackColor = True
        '
        'radName
        '
        Me.radName.AutoSize = True
        Me.radName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radName.Location = New System.Drawing.Point(6, 97)
        Me.radName.Name = "radName"
        Me.radName.Size = New System.Drawing.Size(140, 22)
        Me.radName.TabIndex = 0
        Me.radName.TabStop = True
        Me.radName.Text = "Customer Name"
        Me.radName.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(292, 242)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(141, 42)
        Me.BtnDelete.TabIndex = 72
        Me.BtnDelete.Text = "Delete Customer"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(145, 241)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(141, 42)
        Me.BtnEdit.TabIndex = 73
        Me.BtnEdit.Text = "Edit Customer "
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(0, 242)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(141, 42)
        Me.BtnAdd.TabIndex = 74
        Me.BtnAdd.Text = "Add Customer"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnSortCustomers
        '
        Me.BtnSortCustomers.Location = New System.Drawing.Point(0, 298)
        Me.BtnSortCustomers.Name = "BtnSortCustomers"
        Me.BtnSortCustomers.Size = New System.Drawing.Size(141, 42)
        Me.BtnSortCustomers.TabIndex = 75
        Me.BtnSortCustomers.Text = "Sort Customers"
        Me.BtnSortCustomers.UseVisualStyleBackColor = True
        '
        'TblCustomerTableAdapter
        '
        Me.TblCustomerTableAdapter.ClearBeforeFill = True
        '
        'Customers
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
        Me.Controls.Add(Me.BtnSearchCustomer)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Customers"
        Me.Text = "Customer"
        CType(Me.DGVCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataBase_copyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSort.ResumeLayout(False)
        Me.GrpSort.PerformLayout()
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSearchCustomer As Button
    Friend WithEvents DGVCustomers As DataGridView
    Friend WithEvents GrpSort As GroupBox
    Friend WithEvents Llbchange As Label
    Friend WithEvents cbproductchange As ComboBox
    Friend WithEvents GrpSearch As GroupBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents RadCustomerEmail As RadioButton
    Friend WithEvents txbname As TextBox
    Friend WithEvents txbID As TextBox
    Friend WithEvents radID As RadioButton
    Friend WithEvents radName As RadioButton
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSortCustomers As Button
    Friend WithEvents StockDataBase_copyDataSet As StockDataBase_copyDataSet
    Friend WithEvents TblCustomerBindingSource As BindingSource
    Friend WithEvents TblCustomerTableAdapter As StockDataBase_copyDataSetTableAdapters.TblCustomerTableAdapter
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerFirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerSurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerPhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerPostcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
