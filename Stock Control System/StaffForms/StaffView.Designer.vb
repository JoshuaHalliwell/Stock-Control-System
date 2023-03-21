<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffView
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
        Me.TblCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnSearchStaff = New System.Windows.Forms.Button()
        Me.Llbchange = New System.Windows.Forms.Label()
        Me.GrpSort = New System.Windows.Forms.GroupBox()
        Me.cbproductchange = New System.Windows.Forms.ComboBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.RadCustomerEmail = New System.Windows.Forms.RadioButton()
        Me.txbname = New System.Windows.Forms.TextBox()
        Me.txbID = New System.Windows.Forms.TextBox()
        Me.radID = New System.Windows.Forms.RadioButton()
        Me.radName = New System.Windows.Forms.RadioButton()
        Me.BtnSortStaff = New System.Windows.Forms.Button()
        Me.BtnEditStaff = New System.Windows.Forms.Button()
        Me.BtnDeleteStaff = New System.Windows.Forms.Button()
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.DGVCustomers = New System.Windows.Forms.DataGridView()
        Me.BtnAddStaff = New System.Windows.Forms.Button()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSort.SuspendLayout()
        Me.GrpSearch.SuspendLayout()
        CType(Me.DGVCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblCustomerBindingSource
        '
        Me.TblCustomerBindingSource.DataMember = "TblCustomer"
        '
        'BtnSearchStaff
        '
        Me.BtnSearchStaff.Location = New System.Drawing.Point(290, 289)
        Me.BtnSearchStaff.Name = "BtnSearchStaff"
        Me.BtnSearchStaff.Size = New System.Drawing.Size(141, 42)
        Me.BtnSearchStaff.TabIndex = 84
        Me.BtnSearchStaff.Text = "Search Staff"
        Me.BtnSearchStaff.UseVisualStyleBackColor = True
        '
        'Llbchange
        '
        Me.Llbchange.AutoSize = True
        Me.Llbchange.Location = New System.Drawing.Point(32, 46)
        Me.Llbchange.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Llbchange.Name = "Llbchange"
        Me.Llbchange.Size = New System.Drawing.Size(75, 24)
        Me.Llbchange.TabIndex = 59
        Me.Llbchange.Text = "StaffID"
        '
        'GrpSort
        '
        Me.GrpSort.Controls.Add(Me.Llbchange)
        Me.GrpSort.Controls.Add(Me.cbproductchange)
        Me.GrpSort.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSort.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrpSort.Location = New System.Drawing.Point(437, 3)
        Me.GrpSort.Name = "GrpSort"
        Me.GrpSort.Size = New System.Drawing.Size(232, 126)
        Me.GrpSort.TabIndex = 86
        Me.GrpSort.TabStop = False
        Me.GrpSort.Text = "Sort By:"
        '
        'cbproductchange
        '
        Me.cbproductchange.FormattingEnabled = True
        Me.cbproductchange.Location = New System.Drawing.Point(10, 88)
        Me.cbproductchange.Name = "cbproductchange"
        Me.cbproductchange.Size = New System.Drawing.Size(216, 32)
        Me.cbproductchange.TabIndex = 58
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
        Me.RadCustomerEmail.Size = New System.Drawing.Size(102, 22)
        Me.RadCustomerEmail.TabIndex = 61
        Me.RadCustomerEmail.TabStop = True
        Me.RadCustomerEmail.Text = "Staff Email"
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
        Me.radID.Size = New System.Drawing.Size(77, 22)
        Me.radID.TabIndex = 0
        Me.radID.TabStop = True
        Me.radID.Text = "Staff ID"
        Me.radID.UseVisualStyleBackColor = True
        '
        'radName
        '
        Me.radName.AutoSize = True
        Me.radName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radName.Location = New System.Drawing.Point(6, 97)
        Me.radName.Name = "radName"
        Me.radName.Size = New System.Drawing.Size(104, 22)
        Me.radName.TabIndex = 0
        Me.radName.TabStop = True
        Me.radName.Text = "Staff Name"
        Me.radName.UseVisualStyleBackColor = True
        '
        'BtnSortStaff
        '
        Me.BtnSortStaff.Location = New System.Drawing.Point(-2, 289)
        Me.BtnSortStaff.Name = "BtnSortStaff"
        Me.BtnSortStaff.Size = New System.Drawing.Size(141, 42)
        Me.BtnSortStaff.TabIndex = 91
        Me.BtnSortStaff.Text = "Sort Staff"
        Me.BtnSortStaff.UseVisualStyleBackColor = True
        '
        'BtnEditStaff
        '
        Me.BtnEditStaff.Location = New System.Drawing.Point(143, 232)
        Me.BtnEditStaff.Name = "BtnEditStaff"
        Me.BtnEditStaff.Size = New System.Drawing.Size(141, 42)
        Me.BtnEditStaff.TabIndex = 89
        Me.BtnEditStaff.Text = "Edit Staff"
        Me.BtnEditStaff.UseVisualStyleBackColor = True
        '
        'BtnDeleteStaff
        '
        Me.BtnDeleteStaff.Location = New System.Drawing.Point(290, 233)
        Me.BtnDeleteStaff.Name = "BtnDeleteStaff"
        Me.BtnDeleteStaff.Size = New System.Drawing.Size(141, 42)
        Me.BtnDeleteStaff.TabIndex = 88
        Me.BtnDeleteStaff.Text = "Delete Staff"
        Me.BtnDeleteStaff.UseVisualStyleBackColor = True
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
        Me.GrpSearch.Location = New System.Drawing.Point(437, 135)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Size = New System.Drawing.Size(232, 210)
        Me.GrpSearch.TabIndex = 87
        Me.GrpSearch.TabStop = False
        Me.GrpSearch.Text = "Search For:"
        '
        'DGVCustomers
        '
        Me.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCustomers.Location = New System.Drawing.Point(-2, 3)
        Me.DGVCustomers.Name = "DGVCustomers"
        Me.DGVCustomers.Size = New System.Drawing.Size(433, 217)
        Me.DGVCustomers.TabIndex = 85
        '
        'BtnAddStaff
        '
        Me.BtnAddStaff.Location = New System.Drawing.Point(-2, 233)
        Me.BtnAddStaff.Name = "BtnAddStaff"
        Me.BtnAddStaff.Size = New System.Drawing.Size(141, 42)
        Me.BtnAddStaff.TabIndex = 90
        Me.BtnAddStaff.Text = "Add Staff"
        Me.BtnAddStaff.UseVisualStyleBackColor = True
        '
        'StaffView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(667, 349)
        Me.Controls.Add(Me.BtnSearchStaff)
        Me.Controls.Add(Me.GrpSort)
        Me.Controls.Add(Me.BtnSortStaff)
        Me.Controls.Add(Me.BtnEditStaff)
        Me.Controls.Add(Me.BtnDeleteStaff)
        Me.Controls.Add(Me.GrpSearch)
        Me.Controls.Add(Me.DGVCustomers)
        Me.Controls.Add(Me.BtnAddStaff)
        Me.Name = "StaffView"
        Me.Text = "StaffView"
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSort.ResumeLayout(False)
        Me.GrpSort.PerformLayout()
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        CType(Me.DGVCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TblCustomerBindingSource As BindingSource
    Friend WithEvents BtnSearchStaff As Button
    Friend WithEvents Llbchange As Label
    Friend WithEvents GrpSort As GroupBox
    Friend WithEvents cbproductchange As ComboBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents RadCustomerEmail As RadioButton
    Friend WithEvents txbname As TextBox
    Friend WithEvents txbID As TextBox
    Friend WithEvents radID As RadioButton
    Friend WithEvents radName As RadioButton
    Friend WithEvents BtnSortStaff As Button
    Friend WithEvents BtnEditStaff As Button
    Friend WithEvents BtnDeleteStaff As Button
    Friend WithEvents GrpSearch As GroupBox
    Friend WithEvents DGVCustomers As DataGridView
    Friend WithEvents BtnAddStaff As Button
End Class
