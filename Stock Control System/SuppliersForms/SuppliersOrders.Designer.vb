<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SuppliersOrders
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
        Me.BtnUpdateOrders = New System.Windows.Forms.Button()
        Me.BtnDeleteOrder = New System.Windows.Forms.Button()
        Me.BtnAddOrder = New System.Windows.Forms.Button()
        Me.BtnSortSupplierOrders = New System.Windows.Forms.Button()
        Me.BtnSearchSupplyOrders = New System.Windows.Forms.Button()
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.RadSuppliersEmail = New System.Windows.Forms.RadioButton()
        Me.txbname = New System.Windows.Forms.TextBox()
        Me.txbID = New System.Windows.Forms.TextBox()
        Me.RadSuppliersId = New System.Windows.Forms.RadioButton()
        Me.RadSuppliersName = New System.Windows.Forms.RadioButton()
        Me.GrpSort = New System.Windows.Forms.GroupBox()
        Me.LblChange = New System.Windows.Forms.Label()
        Me.cbproductchange = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GrpSearch.SuspendLayout()
        Me.GrpSort.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUpdateOrders
        '
        Me.BtnUpdateOrders.Location = New System.Drawing.Point(29, 270)
        Me.BtnUpdateOrders.Name = "BtnUpdateOrders"
        Me.BtnUpdateOrders.Size = New System.Drawing.Size(110, 46)
        Me.BtnUpdateOrders.TabIndex = 9
        Me.BtnUpdateOrders.Text = "Update Orders"
        Me.BtnUpdateOrders.UseVisualStyleBackColor = True
        '
        'BtnDeleteOrder
        '
        Me.BtnDeleteOrder.Location = New System.Drawing.Point(138, 224)
        Me.BtnDeleteOrder.Name = "BtnDeleteOrder"
        Me.BtnDeleteOrder.Size = New System.Drawing.Size(113, 47)
        Me.BtnDeleteOrder.TabIndex = 10
        Me.BtnDeleteOrder.Text = "Delete Order"
        Me.BtnDeleteOrder.UseVisualStyleBackColor = True
        '
        'BtnAddOrder
        '
        Me.BtnAddOrder.Location = New System.Drawing.Point(29, 224)
        Me.BtnAddOrder.Name = "BtnAddOrder"
        Me.BtnAddOrder.Size = New System.Drawing.Size(110, 47)
        Me.BtnAddOrder.TabIndex = 11
        Me.BtnAddOrder.Text = "Add Order"
        Me.BtnAddOrder.UseVisualStyleBackColor = True
        '
        'BtnSortSupplierOrders
        '
        Me.BtnSortSupplierOrders.Location = New System.Drawing.Point(245, 224)
        Me.BtnSortSupplierOrders.Name = "BtnSortSupplierOrders"
        Me.BtnSortSupplierOrders.Size = New System.Drawing.Size(123, 46)
        Me.BtnSortSupplierOrders.TabIndex = 12
        Me.BtnSortSupplierOrders.Text = "Sort Supply Orders"
        Me.BtnSortSupplierOrders.UseVisualStyleBackColor = True
        '
        'BtnSearchSupplyOrders
        '
        Me.BtnSearchSupplyOrders.Location = New System.Drawing.Point(245, 269)
        Me.BtnSearchSupplyOrders.Name = "BtnSearchSupplyOrders"
        Me.BtnSearchSupplyOrders.Size = New System.Drawing.Size(123, 48)
        Me.BtnSearchSupplyOrders.TabIndex = 13
        Me.BtnSearchSupplyOrders.Text = "Search Supply Orders"
        Me.BtnSearchSupplyOrders.UseVisualStyleBackColor = True
        '
        'GrpSearch
        '
        Me.GrpSearch.Controls.Add(Me.txbEmail)
        Me.GrpSearch.Controls.Add(Me.RadSuppliersEmail)
        Me.GrpSearch.Controls.Add(Me.txbname)
        Me.GrpSearch.Controls.Add(Me.txbID)
        Me.GrpSearch.Controls.Add(Me.RadSuppliersId)
        Me.GrpSearch.Controls.Add(Me.RadSuppliersName)
        Me.GrpSearch.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSearch.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrpSearch.Location = New System.Drawing.Point(403, 127)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Size = New System.Drawing.Size(232, 210)
        Me.GrpSearch.TabIndex = 70
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
        'RadSuppliersEmail
        '
        Me.RadSuppliersEmail.AutoSize = True
        Me.RadSuppliersEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadSuppliersEmail.Location = New System.Drawing.Point(6, 154)
        Me.RadSuppliersEmail.Name = "RadSuppliersEmail"
        Me.RadSuppliersEmail.Size = New System.Drawing.Size(136, 22)
        Me.RadSuppliersEmail.TabIndex = 61
        Me.RadSuppliersEmail.TabStop = True
        Me.RadSuppliersEmail.Text = "Suppliers Email"
        Me.RadSuppliersEmail.UseVisualStyleBackColor = True
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
        'RadSuppliersId
        '
        Me.RadSuppliersId.AutoSize = True
        Me.RadSuppliersId.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadSuppliersId.Location = New System.Drawing.Point(6, 31)
        Me.RadSuppliersId.Name = "RadSuppliersId"
        Me.RadSuppliersId.Size = New System.Drawing.Size(111, 22)
        Me.RadSuppliersId.TabIndex = 0
        Me.RadSuppliersId.TabStop = True
        Me.RadSuppliersId.Text = "Suppliers ID"
        Me.RadSuppliersId.UseVisualStyleBackColor = True
        '
        'RadSuppliersName
        '
        Me.RadSuppliersName.AutoSize = True
        Me.RadSuppliersName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadSuppliersName.Location = New System.Drawing.Point(6, 97)
        Me.RadSuppliersName.Name = "RadSuppliersName"
        Me.RadSuppliersName.Size = New System.Drawing.Size(138, 22)
        Me.RadSuppliersName.TabIndex = 0
        Me.RadSuppliersName.TabStop = True
        Me.RadSuppliersName.Text = "Suppliers Name"
        Me.RadSuppliersName.UseVisualStyleBackColor = True
        '
        'GrpSort
        '
        Me.GrpSort.Controls.Add(Me.LblChange)
        Me.GrpSort.Controls.Add(Me.cbproductchange)
        Me.GrpSort.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSort.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrpSort.Location = New System.Drawing.Point(403, -4)
        Me.GrpSort.Name = "GrpSort"
        Me.GrpSort.Size = New System.Drawing.Size(232, 125)
        Me.GrpSort.TabIndex = 71
        Me.GrpSort.TabStop = False
        Me.GrpSort.Text = "Sort By:"
        '
        'LblChange
        '
        Me.LblChange.AutoSize = True
        Me.LblChange.Location = New System.Drawing.Point(32, 46)
        Me.LblChange.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblChange.Name = "LblChange"
        Me.LblChange.Size = New System.Drawing.Size(73, 24)
        Me.LblChange.TabIndex = 59
        Me.LblChange.Text = "Label1"
        '
        'cbproductchange
        '
        Me.cbproductchange.FormattingEnabled = True
        Me.cbproductchange.Location = New System.Drawing.Point(10, 88)
        Me.cbproductchange.Name = "cbproductchange"
        Me.cbproductchange.Size = New System.Drawing.Size(216, 32)
        Me.cbproductchange.TabIndex = 58
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(339, 186)
        Me.DataGridView1.TabIndex = 72
        '
        'SuppliersOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(667, 349)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GrpSort)
        Me.Controls.Add(Me.GrpSearch)
        Me.Controls.Add(Me.BtnSearchSupplyOrders)
        Me.Controls.Add(Me.BtnSortSupplierOrders)
        Me.Controls.Add(Me.BtnAddOrder)
        Me.Controls.Add(Me.BtnDeleteOrder)
        Me.Controls.Add(Me.BtnUpdateOrders)
        Me.Name = "SuppliersOrders"
        Me.Text = "Form2"
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        Me.GrpSort.ResumeLayout(False)
        Me.GrpSort.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnUpdateOrders As Button
    Friend WithEvents BtnDeleteOrder As Button
    Friend WithEvents BtnAddOrder As Button
    Friend WithEvents BtnSortSupplierOrders As Button
    Friend WithEvents BtnSearchSupplyOrders As Button
    Friend WithEvents GrpSearch As GroupBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents RadSuppliersEmail As RadioButton
    Friend WithEvents txbname As TextBox
    Friend WithEvents txbID As TextBox
    Friend WithEvents RadSuppliersId As RadioButton
    Friend WithEvents RadSuppliersName As RadioButton
    Friend WithEvents GrpSort As GroupBox
    Friend WithEvents LblChange As Label
    Friend WithEvents cbproductchange As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
