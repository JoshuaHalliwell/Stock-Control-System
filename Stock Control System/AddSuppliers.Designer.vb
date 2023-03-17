<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuppliersData
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.LblCustomerEmail = New System.Windows.Forms.Label()
        Me.LblCustomerSurname = New System.Windows.Forms.Label()
        Me.LblCustomerFirstName = New System.Windows.Forms.Label()
        Me.LblAddressError = New System.Windows.Forms.Label()
        Me.lblSuppliersAddressError = New System.Windows.Forms.Label()
        Me.LblSupplierNameError = New System.Windows.Forms.Label()
        Me.LblSuppliersIDError = New System.Windows.Forms.Label()
        Me.TxbSurname = New System.Windows.Forms.TextBox()
        Me.TxbEmail = New System.Windows.Forms.TextBox()
        Me.TxbFirstname = New System.Windows.Forms.TextBox()
        Me.btnlastcustomer = New System.Windows.Forms.Button()
        Me.btnfirstcustomer = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.TxbCustomerID = New System.Windows.Forms.TextBox()
        Me.LblCustomerID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(309, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 22
        '
        'BtnBack
        '
        Me.BtnBack.AutoSize = True
        Me.BtnBack.Location = New System.Drawing.Point(509, 297)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(144, 41)
        Me.BtnBack.TabIndex = 118
        Me.BtnBack.Text = "Back to menu "
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'LblCustomerEmail
        '
        Me.LblCustomerEmail.AutoSize = True
        Me.LblCustomerEmail.Location = New System.Drawing.Point(28, 243)
        Me.LblCustomerEmail.Name = "LblCustomerEmail"
        Me.LblCustomerEmail.Size = New System.Drawing.Size(91, 13)
        Me.LblCustomerEmail.TabIndex = 115
        Me.LblCustomerEmail.Text = "Suppliers Address"
        '
        'LblCustomerSurname
        '
        Me.LblCustomerSurname.AutoSize = True
        Me.LblCustomerSurname.Location = New System.Drawing.Point(40, 180)
        Me.LblCustomerSurname.Name = "LblCustomerSurname"
        Me.LblCustomerSurname.Size = New System.Drawing.Size(78, 13)
        Me.LblCustomerSurname.TabIndex = 114
        Me.LblCustomerSurname.Text = "Suppliers Email"
        '
        'LblCustomerFirstName
        '
        Me.LblCustomerFirstName.AutoSize = True
        Me.LblCustomerFirstName.Location = New System.Drawing.Point(37, 126)
        Me.LblCustomerFirstName.Name = "LblCustomerFirstName"
        Me.LblCustomerFirstName.Size = New System.Drawing.Size(81, 13)
        Me.LblCustomerFirstName.TabIndex = 113
        Me.LblCustomerFirstName.Text = "Suppliers Name"
        '
        'LblAddressError
        '
        Me.LblAddressError.AutoSize = True
        Me.LblAddressError.ForeColor = System.Drawing.Color.Red
        Me.LblAddressError.Location = New System.Drawing.Point(125, 224)
        Me.LblAddressError.Name = "LblAddressError"
        Me.LblAddressError.Size = New System.Drawing.Size(67, 13)
        Me.LblAddressError.TabIndex = 110
        Me.LblAddressError.Text = "AddressError"
        '
        'lblSuppliersAddressError
        '
        Me.lblSuppliersAddressError.AutoSize = True
        Me.lblSuppliersAddressError.ForeColor = System.Drawing.Color.Red
        Me.lblSuppliersAddressError.Location = New System.Drawing.Point(125, 161)
        Me.lblSuppliersAddressError.Name = "lblSuppliersAddressError"
        Me.lblSuppliersAddressError.Size = New System.Drawing.Size(54, 13)
        Me.lblSuppliersAddressError.TabIndex = 109
        Me.lblSuppliersAddressError.Text = "EmailError"
        '
        'LblSupplierNameError
        '
        Me.LblSupplierNameError.AutoSize = True
        Me.LblSupplierNameError.ForeColor = System.Drawing.Color.Red
        Me.LblSupplierNameError.Location = New System.Drawing.Point(125, 103)
        Me.LblSupplierNameError.Name = "LblSupplierNameError"
        Me.LblSupplierNameError.Size = New System.Drawing.Size(57, 13)
        Me.LblSupplierNameError.TabIndex = 108
        Me.LblSupplierNameError.Text = "NameError"
        '
        'LblSuppliersIDError
        '
        Me.LblSuppliersIDError.AutoSize = True
        Me.LblSuppliersIDError.ForeColor = System.Drawing.Color.Red
        Me.LblSuppliersIDError.Location = New System.Drawing.Point(122, 41)
        Me.LblSuppliersIDError.Name = "LblSuppliersIDError"
        Me.LblSuppliersIDError.Size = New System.Drawing.Size(78, 13)
        Me.LblSuppliersIDError.TabIndex = 107
        Me.LblSuppliersIDError.Text = "SupplierIDError"
        '
        'TxbSurname
        '
        Me.TxbSurname.Location = New System.Drawing.Point(125, 177)
        Me.TxbSurname.Name = "TxbSurname"
        Me.TxbSurname.Size = New System.Drawing.Size(356, 20)
        Me.TxbSurname.TabIndex = 104
        Me.TxbSurname.Text = "SuppliersEmail"
        '
        'TxbEmail
        '
        Me.TxbEmail.Location = New System.Drawing.Point(125, 240)
        Me.TxbEmail.Name = "TxbEmail"
        Me.TxbEmail.Size = New System.Drawing.Size(356, 20)
        Me.TxbEmail.TabIndex = 103
        Me.TxbEmail.Text = "SuppliersAddress"
        '
        'TxbFirstname
        '
        Me.TxbFirstname.Location = New System.Drawing.Point(124, 119)
        Me.TxbFirstname.Name = "TxbFirstname"
        Me.TxbFirstname.Size = New System.Drawing.Size(356, 20)
        Me.TxbFirstname.TabIndex = 102
        Me.TxbFirstname.Text = "SuppliersName"
        '
        'btnlastcustomer
        '
        Me.btnlastcustomer.AutoSize = True
        Me.btnlastcustomer.Location = New System.Drawing.Point(509, 250)
        Me.btnlastcustomer.Name = "btnlastcustomer"
        Me.btnlastcustomer.Size = New System.Drawing.Size(144, 41)
        Me.btnlastcustomer.TabIndex = 101
        Me.btnlastcustomer.Text = "Last Supplier Detalis"
        Me.btnlastcustomer.UseVisualStyleBackColor = True
        '
        'btnfirstcustomer
        '
        Me.btnfirstcustomer.Location = New System.Drawing.Point(509, 108)
        Me.btnfirstcustomer.Name = "btnfirstcustomer"
        Me.btnfirstcustomer.Size = New System.Drawing.Size(144, 41)
        Me.btnfirstcustomer.TabIndex = 100
        Me.btnfirstcustomer.Text = "First Supplier Details"
        Me.btnfirstcustomer.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(177, 299)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(144, 41)
        Me.btndelete.TabIndex = 99
        Me.btndelete.Text = "Delete Supplier Detalis"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Location = New System.Drawing.Point(509, 203)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(144, 41)
        Me.btnprev.TabIndex = 98
        Me.btnprev.Text = "Prev Supplier"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(14, 299)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(144, 41)
        Me.btnadd.TabIndex = 97
        Me.btnadd.Text = "Add Supplier Details "
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(509, 156)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(144, 41)
        Me.btnnext.TabIndex = 96
        Me.btnnext.Text = "Next Supplier"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(336, 299)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(144, 41)
        Me.btnupdate.TabIndex = 95
        Me.btnupdate.Text = "Update Supplier Details"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(509, 60)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(144, 41)
        Me.btnclear.TabIndex = 94
        Me.btnclear.Text = "Clear Supplier Details"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(509, 13)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(144, 41)
        Me.btncancel.TabIndex = 93
        Me.btncancel.Text = "Cancel Process "
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'TxbCustomerID
        '
        Me.TxbCustomerID.Location = New System.Drawing.Point(124, 60)
        Me.TxbCustomerID.Name = "TxbCustomerID"
        Me.TxbCustomerID.Size = New System.Drawing.Size(356, 20)
        Me.TxbCustomerID.TabIndex = 92
        Me.TxbCustomerID.Text = "SuppliersID"
        '
        'LblCustomerID
        '
        Me.LblCustomerID.AutoSize = True
        Me.LblCustomerID.Location = New System.Drawing.Point(57, 63)
        Me.LblCustomerID.Name = "LblCustomerID"
        Me.LblCustomerID.Size = New System.Drawing.Size(61, 13)
        Me.LblCustomerID.TabIndex = 91
        Me.LblCustomerID.Text = "SuppliersID"
        '
        'SuppliersData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(667, 349)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.LblCustomerEmail)
        Me.Controls.Add(Me.LblCustomerSurname)
        Me.Controls.Add(Me.LblCustomerFirstName)
        Me.Controls.Add(Me.LblAddressError)
        Me.Controls.Add(Me.lblSuppliersAddressError)
        Me.Controls.Add(Me.LblSupplierNameError)
        Me.Controls.Add(Me.LblSuppliersIDError)
        Me.Controls.Add(Me.TxbSurname)
        Me.Controls.Add(Me.TxbEmail)
        Me.Controls.Add(Me.TxbFirstname)
        Me.Controls.Add(Me.btnlastcustomer)
        Me.Controls.Add(Me.btnfirstcustomer)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.TxbCustomerID)
        Me.Controls.Add(Me.LblCustomerID)
        Me.Controls.Add(Me.Label5)
        Me.Name = "SuppliersData"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents LblCustomerEmail As Label
    Friend WithEvents LblCustomerSurname As Label
    Friend WithEvents LblCustomerFirstName As Label
    Friend WithEvents LblAddressError As Label
    Friend WithEvents lblSuppliersAddressError As Label
    Friend WithEvents LblSupplierNameError As Label
    Friend WithEvents LblSuppliersIDError As Label
    Friend WithEvents TxbSurname As TextBox
    Friend WithEvents TxbEmail As TextBox
    Friend WithEvents TxbFirstname As TextBox
    Friend WithEvents btnlastcustomer As Button
    Friend WithEvents btnfirstcustomer As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnprev As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents TxbCustomerID As TextBox
    Friend WithEvents LblCustomerID As Label
End Class
