<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerData
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
        Me.LblCustomerID = New System.Windows.Forms.Label()
        Me.TxbCustomerID = New System.Windows.Forms.TextBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnfirstcustomer = New System.Windows.Forms.Button()
        Me.btnlastcustomer = New System.Windows.Forms.Button()
        Me.TxbFirstname = New System.Windows.Forms.TextBox()
        Me.TxbEmail = New System.Windows.Forms.TextBox()
        Me.TxbSurname = New System.Windows.Forms.TextBox()
        Me.TxbMobileNumber = New System.Windows.Forms.TextBox()
        Me.TxbPostcode = New System.Windows.Forms.TextBox()
        Me.LblCustomerIDError = New System.Windows.Forms.Label()
        Me.LblFirstnameError = New System.Windows.Forms.Label()
        Me.lblSurnameError = New System.Windows.Forms.Label()
        Me.LblEmailError = New System.Windows.Forms.Label()
        Me.LblMobilenumberError = New System.Windows.Forms.Label()
        Me.LblPostcodeError = New System.Windows.Forms.Label()
        Me.LblCustomerFirstName = New System.Windows.Forms.Label()
        Me.LblCustomerSurname = New System.Windows.Forms.Label()
        Me.LblCustomerEmail = New System.Windows.Forms.Label()
        Me.Lblphonenumber = New System.Windows.Forms.Label()
        Me.Lblpostcode = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblCustomerID
        '
        Me.LblCustomerID.AutoSize = True
        Me.LblCustomerID.Location = New System.Drawing.Point(25, 36)
        Me.LblCustomerID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCustomerID.Name = "LblCustomerID"
        Me.LblCustomerID.Size = New System.Drawing.Size(77, 16)
        Me.LblCustomerID.TabIndex = 63
        Me.LblCustomerID.Text = "CustomerID"
        '
        'TxbCustomerID
        '
        Me.TxbCustomerID.Location = New System.Drawing.Point(161, 29)
        Me.TxbCustomerID.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbCustomerID.Name = "TxbCustomerID"
        Me.TxbCustomerID.Size = New System.Drawing.Size(473, 22)
        Me.TxbCustomerID.TabIndex = 64
        Me.TxbCustomerID.Text = "CustomerID"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(673, 13)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(192, 50)
        Me.btncancel.TabIndex = 65
        Me.btncancel.Text = "Cancel Process "
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(673, 71)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(192, 50)
        Me.btnclear.TabIndex = 66
        Me.btnclear.Text = "Clear Customer Details"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(442, 365)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(192, 50)
        Me.btnupdate.TabIndex = 67
        Me.btnupdate.Text = "Update Customer Details"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(673, 189)
        Me.btnnext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(192, 50)
        Me.btnnext.TabIndex = 68
        Me.btnnext.Text = "Next Customer"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(13, 365)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(192, 50)
        Me.btnadd.TabIndex = 69
        Me.btnadd.Text = "Add Customer Details "
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Location = New System.Drawing.Point(673, 247)
        Me.btnprev.Margin = New System.Windows.Forms.Padding(4)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(192, 50)
        Me.btnprev.TabIndex = 70
        Me.btnprev.Text = "Prev Customer"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(231, 365)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(192, 50)
        Me.btndelete.TabIndex = 71
        Me.btndelete.Text = "Delete Customer Detalis"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnfirstcustomer
        '
        Me.btnfirstcustomer.Location = New System.Drawing.Point(673, 131)
        Me.btnfirstcustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnfirstcustomer.Name = "btnfirstcustomer"
        Me.btnfirstcustomer.Size = New System.Drawing.Size(192, 50)
        Me.btnfirstcustomer.TabIndex = 72
        Me.btnfirstcustomer.Text = "First Customer Details"
        Me.btnfirstcustomer.UseVisualStyleBackColor = True
        '
        'btnlastcustomer
        '
        Me.btnlastcustomer.AutoSize = True
        Me.btnlastcustomer.Location = New System.Drawing.Point(673, 305)
        Me.btnlastcustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlastcustomer.Name = "btnlastcustomer"
        Me.btnlastcustomer.Size = New System.Drawing.Size(192, 50)
        Me.btnlastcustomer.TabIndex = 73
        Me.btnlastcustomer.Text = "Last Customer Detalis"
        Me.btnlastcustomer.UseVisualStyleBackColor = True
        '
        'TxbFirstname
        '
        Me.TxbFirstname.Location = New System.Drawing.Point(161, 85)
        Me.TxbFirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbFirstname.Name = "TxbFirstname"
        Me.TxbFirstname.Size = New System.Drawing.Size(473, 22)
        Me.TxbFirstname.TabIndex = 74
        Me.TxbFirstname.Text = "CustomerFirstname"
        '
        'TxbEmail
        '
        Me.TxbEmail.Location = New System.Drawing.Point(161, 194)
        Me.TxbEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbEmail.Name = "TxbEmail"
        Me.TxbEmail.Size = New System.Drawing.Size(473, 22)
        Me.TxbEmail.TabIndex = 75
        Me.TxbEmail.Text = "CustomerEmail"
        '
        'TxbSurname
        '
        Me.TxbSurname.Location = New System.Drawing.Point(161, 139)
        Me.TxbSurname.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbSurname.Name = "TxbSurname"
        Me.TxbSurname.Size = New System.Drawing.Size(473, 22)
        Me.TxbSurname.TabIndex = 76
        Me.TxbSurname.Text = "CustomerSurname"
        '
        'TxbMobileNumber
        '
        Me.TxbMobileNumber.Location = New System.Drawing.Point(161, 256)
        Me.TxbMobileNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbMobileNumber.Name = "TxbMobileNumber"
        Me.TxbMobileNumber.Size = New System.Drawing.Size(473, 22)
        Me.TxbMobileNumber.TabIndex = 77
        Me.TxbMobileNumber.Text = "CustomerPhoneNumber"
        '
        'TxbPostcode
        '
        Me.TxbPostcode.Location = New System.Drawing.Point(161, 313)
        Me.TxbPostcode.Margin = New System.Windows.Forms.Padding(4)
        Me.TxbPostcode.Name = "TxbPostcode"
        Me.TxbPostcode.Size = New System.Drawing.Size(473, 22)
        Me.TxbPostcode.TabIndex = 78
        Me.TxbPostcode.Text = "CustomerPostcode"
        '
        'LblCustomerIDError
        '
        Me.LblCustomerIDError.AutoSize = True
        Me.LblCustomerIDError.ForeColor = System.Drawing.Color.Red
        Me.LblCustomerIDError.Location = New System.Drawing.Point(158, 9)
        Me.LblCustomerIDError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCustomerIDError.Name = "LblCustomerIDError"
        Me.LblCustomerIDError.Size = New System.Drawing.Size(106, 16)
        Me.LblCustomerIDError.TabIndex = 79
        Me.LblCustomerIDError.Text = "CustomerIDError"
        '
        'LblFirstnameError
        '
        Me.LblFirstnameError.AutoSize = True
        Me.LblFirstnameError.ForeColor = System.Drawing.Color.Red
        Me.LblFirstnameError.Location = New System.Drawing.Point(158, 65)
        Me.LblFirstnameError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFirstnameError.Name = "LblFirstnameError"
        Me.LblFirstnameError.Size = New System.Drawing.Size(95, 16)
        Me.LblFirstnameError.TabIndex = 80
        Me.LblFirstnameError.Text = "FirstnameError"
        '
        'lblSurnameError
        '
        Me.lblSurnameError.AutoSize = True
        Me.lblSurnameError.ForeColor = System.Drawing.Color.Red
        Me.lblSurnameError.Location = New System.Drawing.Point(158, 119)
        Me.lblSurnameError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSurnameError.Name = "lblSurnameError"
        Me.lblSurnameError.Size = New System.Drawing.Size(90, 16)
        Me.lblSurnameError.TabIndex = 81
        Me.lblSurnameError.Text = "SurnameError"
        '
        'LblEmailError
        '
        Me.LblEmailError.AutoSize = True
        Me.LblEmailError.ForeColor = System.Drawing.Color.Red
        Me.LblEmailError.Location = New System.Drawing.Point(158, 174)
        Me.LblEmailError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEmailError.Name = "LblEmailError"
        Me.LblEmailError.Size = New System.Drawing.Size(70, 16)
        Me.LblEmailError.TabIndex = 82
        Me.LblEmailError.Text = "EmailError"
        '
        'LblMobilenumberError
        '
        Me.LblMobilenumberError.AutoSize = True
        Me.LblMobilenumberError.ForeColor = System.Drawing.Color.Red
        Me.LblMobilenumberError.Location = New System.Drawing.Point(158, 236)
        Me.LblMobilenumberError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMobilenumberError.Name = "LblMobilenumberError"
        Me.LblMobilenumberError.Size = New System.Drawing.Size(122, 16)
        Me.LblMobilenumberError.TabIndex = 83
        Me.LblMobilenumberError.Text = "MobilenumberError"
        '
        'LblPostcodeError
        '
        Me.LblPostcodeError.AutoSize = True
        Me.LblPostcodeError.ForeColor = System.Drawing.Color.Red
        Me.LblPostcodeError.Location = New System.Drawing.Point(158, 293)
        Me.LblPostcodeError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPostcodeError.Name = "LblPostcodeError"
        Me.LblPostcodeError.Size = New System.Drawing.Size(94, 16)
        Me.LblPostcodeError.TabIndex = 84
        Me.LblPostcodeError.Text = "PostcodeError"
        '
        'LblCustomerFirstName
        '
        Me.LblCustomerFirstName.AutoSize = True
        Me.LblCustomerFirstName.Location = New System.Drawing.Point(13, 91)
        Me.LblCustomerFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCustomerFirstName.Name = "LblCustomerFirstName"
        Me.LblCustomerFirstName.Size = New System.Drawing.Size(126, 16)
        Me.LblCustomerFirstName.TabIndex = 85
        Me.LblCustomerFirstName.Text = "Customer Firstname"
        '
        'LblCustomerSurname
        '
        Me.LblCustomerSurname.AutoSize = True
        Me.LblCustomerSurname.Location = New System.Drawing.Point(13, 142)
        Me.LblCustomerSurname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCustomerSurname.Name = "LblCustomerSurname"
        Me.LblCustomerSurname.Size = New System.Drawing.Size(121, 16)
        Me.LblCustomerSurname.TabIndex = 86
        Me.LblCustomerSurname.Text = "Customer Surname"
        '
        'LblCustomerEmail
        '
        Me.LblCustomerEmail.AutoSize = True
        Me.LblCustomerEmail.Location = New System.Drawing.Point(49, 200)
        Me.LblCustomerEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCustomerEmail.Name = "LblCustomerEmail"
        Me.LblCustomerEmail.Size = New System.Drawing.Size(41, 16)
        Me.LblCustomerEmail.TabIndex = 87
        Me.LblCustomerEmail.Text = "Email"
        '
        'Lblphonenumber
        '
        Me.Lblphonenumber.AutoSize = True
        Me.Lblphonenumber.Location = New System.Drawing.Point(25, 264)
        Me.Lblphonenumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblphonenumber.Name = "Lblphonenumber"
        Me.Lblphonenumber.Size = New System.Drawing.Size(99, 16)
        Me.Lblphonenumber.TabIndex = 88
        Me.Lblphonenumber.Text = "Mobile number "
        '
        'Lblpostcode
        '
        Me.Lblpostcode.AutoSize = True
        Me.Lblpostcode.Location = New System.Drawing.Point(37, 319)
        Me.Lblpostcode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblpostcode.Name = "Lblpostcode"
        Me.Lblpostcode.Size = New System.Drawing.Size(65, 16)
        Me.Lblpostcode.TabIndex = 89
        Me.Lblpostcode.Text = "Postcode"
        '
        'BtnBack
        '
        Me.BtnBack.AutoSize = True
        Me.BtnBack.Location = New System.Drawing.Point(673, 363)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(192, 50)
        Me.BtnBack.TabIndex = 90
        Me.BtnBack.Text = "Back to menu "
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'CustomerData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(896, 429)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Lblpostcode)
        Me.Controls.Add(Me.Lblphonenumber)
        Me.Controls.Add(Me.LblCustomerEmail)
        Me.Controls.Add(Me.LblCustomerSurname)
        Me.Controls.Add(Me.LblCustomerFirstName)
        Me.Controls.Add(Me.LblPostcodeError)
        Me.Controls.Add(Me.LblMobilenumberError)
        Me.Controls.Add(Me.LblEmailError)
        Me.Controls.Add(Me.lblSurnameError)
        Me.Controls.Add(Me.LblFirstnameError)
        Me.Controls.Add(Me.LblCustomerIDError)
        Me.Controls.Add(Me.TxbPostcode)
        Me.Controls.Add(Me.TxbMobileNumber)
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
        Me.Name = "CustomerData"
        Me.Text = "CustomerData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCustomerID As Label
    Friend WithEvents TxbCustomerID As TextBox
    Friend WithEvents btncancel As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnprev As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnfirstcustomer As Button
    Friend WithEvents btnlastcustomer As Button
    Friend WithEvents TxbFirstname As TextBox
    Friend WithEvents TxbEmail As TextBox
    Friend WithEvents TxbSurname As TextBox
    Friend WithEvents TxbMobileNumber As TextBox
    Friend WithEvents TxbPostcode As TextBox
    Friend WithEvents LblCustomerIDError As Label
    Friend WithEvents LblFirstnameError As Label
    Friend WithEvents lblSurnameError As Label
    Friend WithEvents LblEmailError As Label
    Friend WithEvents LblMobilenumberError As Label
    Friend WithEvents LblPostcodeError As Label
    Friend WithEvents LblCustomerFirstName As Label
    Friend WithEvents LblCustomerSurname As Label
    Friend WithEvents LblCustomerEmail As Label
    Friend WithEvents Lblphonenumber As Label
    Friend WithEvents Lblpostcode As Label
    Friend WithEvents BtnBack As Button
End Class
