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
        Me.cbSaffsales = New System.Windows.Forms.ComboBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.radEmail = New System.Windows.Forms.RadioButton()
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
        Me.BtnSearchStaff.Location = New System.Drawing.Point(387, 356)
        Me.BtnSearchStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSearchStaff.Name = "BtnSearchStaff"
        Me.BtnSearchStaff.Size = New System.Drawing.Size(188, 52)
        Me.BtnSearchStaff.TabIndex = 84
        Me.BtnSearchStaff.Text = "Search Staff"
        Me.BtnSearchStaff.UseVisualStyleBackColor = True
        '
        'Llbchange
        '
        Me.Llbchange.AutoSize = True
        Me.Llbchange.Location = New System.Drawing.Point(43, 57)
        Me.Llbchange.Name = "Llbchange"
        Me.Llbchange.Size = New System.Drawing.Size(137, 32)
        Me.Llbchange.TabIndex = 59
        Me.Llbchange.Text = "StaffSales"
        '
        'GrpSort
        '
        Me.GrpSort.Controls.Add(Me.Llbchange)
        Me.GrpSort.Controls.Add(Me.cbSaffsales)
        Me.GrpSort.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSort.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrpSort.Location = New System.Drawing.Point(583, 4)
        Me.GrpSort.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpSort.Name = "GrpSort"
        Me.GrpSort.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpSort.Size = New System.Drawing.Size(309, 155)
        Me.GrpSort.TabIndex = 86
        Me.GrpSort.TabStop = False
        Me.GrpSort.Text = "Sort By:"
        '
        'cbSaffsales
        '
        Me.cbSaffsales.FormattingEnabled = True
        Me.cbSaffsales.Items.AddRange(New Object() {"Made Sales ", "No Sales"})
        Me.cbSaffsales.Location = New System.Drawing.Point(13, 108)
        Me.cbSaffsales.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSaffsales.Name = "cbSaffsales"
        Me.cbSaffsales.Size = New System.Drawing.Size(287, 39)
        Me.cbSaffsales.TabIndex = 58
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(8, 217)
        Me.txbEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(287, 38)
        Me.txbEmail.TabIndex = 62
        '
        'radEmail
        '
        Me.radEmail.AutoSize = True
        Me.radEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEmail.Location = New System.Drawing.Point(8, 190)
        Me.radEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.radEmail.Name = "radEmail"
        Me.radEmail.Size = New System.Drawing.Size(127, 27)
        Me.radEmail.TabIndex = 61
        Me.radEmail.TabStop = True
        Me.radEmail.Text = "Staff Email"
        Me.radEmail.UseVisualStyleBackColor = True
        '
        'txbname
        '
        Me.txbname.Location = New System.Drawing.Point(8, 149)
        Me.txbname.Margin = New System.Windows.Forms.Padding(4)
        Me.txbname.Name = "txbname"
        Me.txbname.Size = New System.Drawing.Size(287, 38)
        Me.txbname.TabIndex = 60
        '
        'txbID
        '
        Me.txbID.Location = New System.Drawing.Point(12, 73)
        Me.txbID.Margin = New System.Windows.Forms.Padding(4)
        Me.txbID.Name = "txbID"
        Me.txbID.Size = New System.Drawing.Size(283, 38)
        Me.txbID.TabIndex = 59
        '
        'radID
        '
        Me.radID.AutoSize = True
        Me.radID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radID.Location = New System.Drawing.Point(8, 38)
        Me.radID.Margin = New System.Windows.Forms.Padding(4)
        Me.radID.Name = "radID"
        Me.radID.Size = New System.Drawing.Size(99, 27)
        Me.radID.TabIndex = 0
        Me.radID.TabStop = True
        Me.radID.Text = "Staff ID"
        Me.radID.UseVisualStyleBackColor = True
        '
        'radName
        '
        Me.radName.AutoSize = True
        Me.radName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radName.Location = New System.Drawing.Point(8, 119)
        Me.radName.Margin = New System.Windows.Forms.Padding(4)
        Me.radName.Name = "radName"
        Me.radName.Size = New System.Drawing.Size(130, 27)
        Me.radName.TabIndex = 0
        Me.radName.TabStop = True
        Me.radName.Text = "Staff Name"
        Me.radName.UseVisualStyleBackColor = True
        '
        'BtnSortStaff
        '
        Me.BtnSortStaff.Location = New System.Drawing.Point(-3, 356)
        Me.BtnSortStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSortStaff.Name = "BtnSortStaff"
        Me.BtnSortStaff.Size = New System.Drawing.Size(188, 52)
        Me.BtnSortStaff.TabIndex = 91
        Me.BtnSortStaff.Text = "Sort Staff"
        Me.BtnSortStaff.UseVisualStyleBackColor = True
        '
        'BtnEditStaff
        '
        Me.BtnEditStaff.Location = New System.Drawing.Point(191, 286)
        Me.BtnEditStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEditStaff.Name = "BtnEditStaff"
        Me.BtnEditStaff.Size = New System.Drawing.Size(188, 52)
        Me.BtnEditStaff.TabIndex = 89
        Me.BtnEditStaff.Text = "Edit Staff"
        Me.BtnEditStaff.UseVisualStyleBackColor = True
        '
        'BtnDeleteStaff
        '
        Me.BtnDeleteStaff.Location = New System.Drawing.Point(387, 287)
        Me.BtnDeleteStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDeleteStaff.Name = "BtnDeleteStaff"
        Me.BtnDeleteStaff.Size = New System.Drawing.Size(188, 52)
        Me.BtnDeleteStaff.TabIndex = 88
        Me.BtnDeleteStaff.Text = "Delete Staff"
        Me.BtnDeleteStaff.UseVisualStyleBackColor = True
        '
        'GrpSearch
        '
        Me.GrpSearch.Controls.Add(Me.txbEmail)
        Me.GrpSearch.Controls.Add(Me.radEmail)
        Me.GrpSearch.Controls.Add(Me.txbname)
        Me.GrpSearch.Controls.Add(Me.txbID)
        Me.GrpSearch.Controls.Add(Me.radID)
        Me.GrpSearch.Controls.Add(Me.radName)
        Me.GrpSearch.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSearch.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GrpSearch.Location = New System.Drawing.Point(583, 166)
        Me.GrpSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpSearch.Size = New System.Drawing.Size(309, 258)
        Me.GrpSearch.TabIndex = 87
        Me.GrpSearch.TabStop = False
        Me.GrpSearch.Text = "Search For:"
        '
        'DGVCustomers
        '
        Me.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCustomers.Location = New System.Drawing.Point(-3, 4)
        Me.DGVCustomers.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVCustomers.Name = "DGVCustomers"
        Me.DGVCustomers.RowHeadersWidth = 51
        Me.DGVCustomers.Size = New System.Drawing.Size(577, 267)
        Me.DGVCustomers.TabIndex = 85
        '
        'BtnAddStaff
        '
        Me.BtnAddStaff.Location = New System.Drawing.Point(-3, 287)
        Me.BtnAddStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddStaff.Name = "BtnAddStaff"
        Me.BtnAddStaff.Size = New System.Drawing.Size(188, 52)
        Me.BtnAddStaff.TabIndex = 90
        Me.BtnAddStaff.Text = "Add Staff"
        Me.BtnAddStaff.UseVisualStyleBackColor = True
        '
        'StaffView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(889, 430)
        Me.Controls.Add(Me.BtnSearchStaff)
        Me.Controls.Add(Me.GrpSort)
        Me.Controls.Add(Me.BtnSortStaff)
        Me.Controls.Add(Me.BtnEditStaff)
        Me.Controls.Add(Me.BtnDeleteStaff)
        Me.Controls.Add(Me.GrpSearch)
        Me.Controls.Add(Me.DGVCustomers)
        Me.Controls.Add(Me.BtnAddStaff)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents cbSaffsales As ComboBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents radEmail As RadioButton
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
