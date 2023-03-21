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
        Me.BtnBackMenu = New System.Windows.Forms.Button()
        Me.LblCustomerEmail = New System.Windows.Forms.Label()
        Me.LblCustomerSurname = New System.Windows.Forms.Label()
        Me.LblCustomerFirstName = New System.Windows.Forms.Label()
        Me.LblAddressError = New System.Windows.Forms.Label()
        Me.lblSuppliersEmailError = New System.Windows.Forms.Label()
        Me.LblSupplierNameError = New System.Windows.Forms.Label()
        Me.LblSuppliersIDError = New System.Windows.Forms.Label()
        Me.TxbSuppliersEmail = New System.Windows.Forms.TextBox()
        Me.TxbSuppliersAddress = New System.Windows.Forms.TextBox()
        Me.TxbSuppliersName = New System.Windows.Forms.TextBox()
        Me.btnlastsupplier = New System.Windows.Forms.Button()
        Me.btnfirstsupplier = New System.Windows.Forms.Button()
        Me.btndeletesupplier = New System.Windows.Forms.Button()
        Me.btnprevsupplier = New System.Windows.Forms.Button()
        Me.btnaddsupplier = New System.Windows.Forms.Button()
        Me.btnnextsupplier = New System.Windows.Forms.Button()
        Me.btnupdatesupplier = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.TxbSuppliersID = New System.Windows.Forms.TextBox()
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
        'BtnBackMenu
        '
        Me.BtnBackMenu.AutoSize = True
        Me.BtnBackMenu.Location = New System.Drawing.Point(509, 297)
        Me.BtnBackMenu.Name = "BtnBackMenu"
        Me.BtnBackMenu.Size = New System.Drawing.Size(144, 41)
        Me.BtnBackMenu.TabIndex = 118
        Me.BtnBackMenu.Text = "Back to menu "
        Me.BtnBackMenu.UseVisualStyleBackColor = True
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
        'lblSuppliersEmailError
        '
        Me.lblSuppliersEmailError.AutoSize = True
        Me.lblSuppliersEmailError.ForeColor = System.Drawing.Color.Red
        Me.lblSuppliersEmailError.Location = New System.Drawing.Point(125, 161)
        Me.lblSuppliersEmailError.Name = "lblSuppliersEmailError"
        Me.lblSuppliersEmailError.Size = New System.Drawing.Size(54, 13)
        Me.lblSuppliersEmailError.TabIndex = 109
        Me.lblSuppliersEmailError.Text = "EmailError"
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
        'TxbSuppliersEmail
        '
        Me.TxbSuppliersEmail.Location = New System.Drawing.Point(125, 177)
        Me.TxbSuppliersEmail.Name = "TxbSuppliersEmail"
        Me.TxbSuppliersEmail.Size = New System.Drawing.Size(356, 20)
        Me.TxbSuppliersEmail.TabIndex = 104
        Me.TxbSuppliersEmail.Text = "SuppliersEmail"
        '
        'TxbSuppliersAddress
        '
        Me.TxbSuppliersAddress.Location = New System.Drawing.Point(125, 240)
        Me.TxbSuppliersAddress.Name = "TxbSuppliersAddress"
        Me.TxbSuppliersAddress.Size = New System.Drawing.Size(356, 20)
        Me.TxbSuppliersAddress.TabIndex = 103
        Me.TxbSuppliersAddress.Text = "SuppliersAddress"
        '
        'TxbSuppliersName
        '
        Me.TxbSuppliersName.Location = New System.Drawing.Point(124, 119)
        Me.TxbSuppliersName.Name = "TxbSuppliersName"
        Me.TxbSuppliersName.Size = New System.Drawing.Size(356, 20)
        Me.TxbSuppliersName.TabIndex = 102
        Me.TxbSuppliersName.Text = "SuppliersName"
        '
        'btnlastsupplier
        '
        Me.btnlastsupplier.AutoSize = True
        Me.btnlastsupplier.Location = New System.Drawing.Point(509, 250)
        Me.btnlastsupplier.Name = "btnlastsupplier"
        Me.btnlastsupplier.Size = New System.Drawing.Size(144, 41)
        Me.btnlastsupplier.TabIndex = 101
        Me.btnlastsupplier.Text = "Last Supplier Detalis"
        Me.btnlastsupplier.UseVisualStyleBackColor = True
        '
        'btnfirstsupplier
        '
        Me.btnfirstsupplier.Location = New System.Drawing.Point(509, 108)
        Me.btnfirstsupplier.Name = "btnfirstsupplier"
        Me.btnfirstsupplier.Size = New System.Drawing.Size(144, 41)
        Me.btnfirstsupplier.TabIndex = 100
        Me.btnfirstsupplier.Text = "First Supplier Details"
        Me.btnfirstsupplier.UseVisualStyleBackColor = True
        '
        'btndeletesupplier
        '
        Me.btndeletesupplier.Location = New System.Drawing.Point(177, 299)
        Me.btndeletesupplier.Name = "btndeletesupplier"
        Me.btndeletesupplier.Size = New System.Drawing.Size(144, 41)
        Me.btndeletesupplier.TabIndex = 99
        Me.btndeletesupplier.Text = "Delete Supplier Detalis"
        Me.btndeletesupplier.UseVisualStyleBackColor = True
        '
        'btnprevsupplier
        '
        Me.btnprevsupplier.Location = New System.Drawing.Point(509, 203)
        Me.btnprevsupplier.Name = "btnprevsupplier"
        Me.btnprevsupplier.Size = New System.Drawing.Size(144, 41)
        Me.btnprevsupplier.TabIndex = 98
        Me.btnprevsupplier.Text = "Prev Supplier"
        Me.btnprevsupplier.UseVisualStyleBackColor = True
        '
        'btnaddsupplier
        '
        Me.btnaddsupplier.Location = New System.Drawing.Point(14, 299)
        Me.btnaddsupplier.Name = "btnaddsupplier"
        Me.btnaddsupplier.Size = New System.Drawing.Size(144, 41)
        Me.btnaddsupplier.TabIndex = 97
        Me.btnaddsupplier.Text = "Add Supplier Details "
        Me.btnaddsupplier.UseVisualStyleBackColor = True
        '
        'btnnextsupplier
        '
        Me.btnnextsupplier.Location = New System.Drawing.Point(509, 156)
        Me.btnnextsupplier.Name = "btnnextsupplier"
        Me.btnnextsupplier.Size = New System.Drawing.Size(144, 41)
        Me.btnnextsupplier.TabIndex = 96
        Me.btnnextsupplier.Text = "Next Supplier"
        Me.btnnextsupplier.UseVisualStyleBackColor = True
        '
        'btnupdatesupplier
        '
        Me.btnupdatesupplier.Location = New System.Drawing.Point(336, 299)
        Me.btnupdatesupplier.Name = "btnupdatesupplier"
        Me.btnupdatesupplier.Size = New System.Drawing.Size(144, 41)
        Me.btnupdatesupplier.TabIndex = 95
        Me.btnupdatesupplier.Text = "Update Supplier Details"
        Me.btnupdatesupplier.UseVisualStyleBackColor = True
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
        'TxbSuppliersID
        '
        Me.TxbSuppliersID.Location = New System.Drawing.Point(124, 60)
        Me.TxbSuppliersID.Name = "TxbSuppliersID"
        Me.TxbSuppliersID.Size = New System.Drawing.Size(356, 20)
        Me.TxbSuppliersID.TabIndex = 92
        Me.TxbSuppliersID.Text = "SuppliersID"
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
        Me.Controls.Add(Me.BtnBackMenu)
        Me.Controls.Add(Me.LblCustomerEmail)
        Me.Controls.Add(Me.LblCustomerSurname)
        Me.Controls.Add(Me.LblCustomerFirstName)
        Me.Controls.Add(Me.LblAddressError)
        Me.Controls.Add(Me.lblSuppliersEmailError)
        Me.Controls.Add(Me.LblSupplierNameError)
        Me.Controls.Add(Me.LblSuppliersIDError)
        Me.Controls.Add(Me.TxbSuppliersEmail)
        Me.Controls.Add(Me.TxbSuppliersAddress)
        Me.Controls.Add(Me.TxbSuppliersName)
        Me.Controls.Add(Me.btnlastsupplier)
        Me.Controls.Add(Me.btnfirstsupplier)
        Me.Controls.Add(Me.btndeletesupplier)
        Me.Controls.Add(Me.btnprevsupplier)
        Me.Controls.Add(Me.btnaddsupplier)
        Me.Controls.Add(Me.btnnextsupplier)
        Me.Controls.Add(Me.btnupdatesupplier)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.TxbSuppliersID)
        Me.Controls.Add(Me.LblCustomerID)
        Me.Controls.Add(Me.Label5)
        Me.Name = "SuppliersData"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnBackMenu As Button
    Friend WithEvents LblCustomerEmail As Label
    Friend WithEvents LblCustomerSurname As Label
    Friend WithEvents LblCustomerFirstName As Label
    Friend WithEvents LblAddressError As Label
    Friend WithEvents lblSuppliersEmailError As Label
    Friend WithEvents LblSupplierNameError As Label
    Friend WithEvents LblSuppliersIDError As Label
    Friend WithEvents TxbSuppliersEmail As TextBox
    Friend WithEvents TxbSuppliersAddress As TextBox
    Friend WithEvents TxbSuppliersName As TextBox
    Friend WithEvents btnlastsupplier As Button
    Friend WithEvents btnfirstsupplier As Button
    Friend WithEvents btndeletesupplier As Button
    Friend WithEvents btnprevsupplier As Button
    Friend WithEvents btnaddsupplier As Button
    Friend WithEvents btnnextsupplier As Button
    Friend WithEvents btnupdatesupplier As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents TxbSuppliersID As TextBox
    Friend WithEvents LblCustomerID As Label
End Class
