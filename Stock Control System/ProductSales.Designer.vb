﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductSales
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
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.LblCustomerID = New System.Windows.Forms.Label()
        Me.LblStaffID = New System.Windows.Forms.Label()
        Me.LblSaleDay = New System.Windows.Forms.Label()
        Me.LblSaleTime = New System.Windows.Forms.Label()
        Me.LblCustomerIDError = New System.Windows.Forms.Label()
        Me.LblStaffError = New System.Windows.Forms.Label()
        Me.lblSaleDayError = New System.Windows.Forms.Label()
        Me.LblSaleTimeError = New System.Windows.Forms.Label()
        Me.LblSaleIDError = New System.Windows.Forms.Label()
        Me.TxbCustomerID = New System.Windows.Forms.TextBox()
        Me.TxtSaleDay = New System.Windows.Forms.TextBox()
        Me.TxbStaffID = New System.Windows.Forms.TextBox()
        Me.TxbSaleTime = New System.Windows.Forms.TextBox()
        Me.btnlastStock = New System.Windows.Forms.Button()
        Me.btnfirstStock = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.TxbSaleID = New System.Windows.Forms.TextBox()
        Me.LblSaleID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.AutoSize = True
        Me.BtnBack.Location = New System.Drawing.Point(580, 301)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(144, 41)
        Me.BtnBack.TabIndex = 146
        Me.BtnBack.Text = "Back to menu "
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'LblCustomerID
        '
        Me.LblCustomerID.AutoSize = True
        Me.LblCustomerID.Location = New System.Drawing.Point(116, 268)
        Me.LblCustomerID.Name = "LblCustomerID"
        Me.LblCustomerID.Size = New System.Drawing.Size(62, 13)
        Me.LblCustomerID.TabIndex = 144
        Me.LblCustomerID.Text = "CustomerID"
        '
        'LblStaffID
        '
        Me.LblStaffID.AutoSize = True
        Me.LblStaffID.Location = New System.Drawing.Point(118, 215)
        Me.LblStaffID.Name = "LblStaffID"
        Me.LblStaffID.Size = New System.Drawing.Size(40, 13)
        Me.LblStaffID.TabIndex = 143
        Me.LblStaffID.Text = "StaffID"
        '
        'LblSaleDay
        '
        Me.LblSaleDay.AutoSize = True
        Me.LblSaleDay.Location = New System.Drawing.Point(107, 170)
        Me.LblSaleDay.Name = "LblSaleDay"
        Me.LblSaleDay.Size = New System.Drawing.Size(47, 13)
        Me.LblSaleDay.TabIndex = 142
        Me.LblSaleDay.Text = "SaleDay"
        '
        'LblSaleTime
        '
        Me.LblSaleTime.AutoSize = True
        Me.LblSaleTime.Location = New System.Drawing.Point(107, 128)
        Me.LblSaleTime.Name = "LblSaleTime"
        Me.LblSaleTime.Size = New System.Drawing.Size(51, 13)
        Me.LblSaleTime.TabIndex = 141
        Me.LblSaleTime.Text = "SaleTime"
        '
        'LblCustomerIDError
        '
        Me.LblCustomerIDError.AutoSize = True
        Me.LblCustomerIDError.ForeColor = System.Drawing.Color.Red
        Me.LblCustomerIDError.Location = New System.Drawing.Point(215, 246)
        Me.LblCustomerIDError.Name = "LblCustomerIDError"
        Me.LblCustomerIDError.Size = New System.Drawing.Size(84, 13)
        Me.LblCustomerIDError.TabIndex = 139
        Me.LblCustomerIDError.Text = "CustomerIDError"
        '
        'LblStaffError
        '
        Me.LblStaffError.AutoSize = True
        Me.LblStaffError.ForeColor = System.Drawing.Color.Red
        Me.LblStaffError.Location = New System.Drawing.Point(215, 195)
        Me.LblStaffError.Name = "LblStaffError"
        Me.LblStaffError.Size = New System.Drawing.Size(62, 13)
        Me.LblStaffError.TabIndex = 138
        Me.LblStaffError.Text = "StaffIDError"
        '
        'lblSaleDayError
        '
        Me.lblSaleDayError.AutoSize = True
        Me.lblSaleDayError.ForeColor = System.Drawing.Color.Red
        Me.lblSaleDayError.Location = New System.Drawing.Point(215, 151)
        Me.lblSaleDayError.Name = "lblSaleDayError"
        Me.lblSaleDayError.Size = New System.Drawing.Size(69, 13)
        Me.lblSaleDayError.TabIndex = 137
        Me.lblSaleDayError.Text = "SaleDayError"
        '
        'LblSaleTimeError
        '
        Me.LblSaleTimeError.AutoSize = True
        Me.LblSaleTimeError.ForeColor = System.Drawing.Color.Red
        Me.LblSaleTimeError.Location = New System.Drawing.Point(215, 107)
        Me.LblSaleTimeError.Name = "LblSaleTimeError"
        Me.LblSaleTimeError.Size = New System.Drawing.Size(73, 13)
        Me.LblSaleTimeError.TabIndex = 136
        Me.LblSaleTimeError.Text = "SaleTimeError"
        '
        'LblSaleIDError
        '
        Me.LblSaleIDError.AutoSize = True
        Me.LblSaleIDError.ForeColor = System.Drawing.Color.Red
        Me.LblSaleIDError.Location = New System.Drawing.Point(215, 61)
        Me.LblSaleIDError.Name = "LblSaleIDError"
        Me.LblSaleIDError.Size = New System.Drawing.Size(68, 13)
        Me.LblSaleIDError.TabIndex = 135
        Me.LblSaleIDError.Text = "StockIDError"
        '
        'TxbCustomerID
        '
        Me.TxbCustomerID.Location = New System.Drawing.Point(218, 262)
        Me.TxbCustomerID.Name = "TxbCustomerID"
        Me.TxbCustomerID.Size = New System.Drawing.Size(356, 20)
        Me.TxbCustomerID.TabIndex = 133
        Me.TxbCustomerID.Text = "CustomerID"
        '
        'TxtSaleDay
        '
        Me.TxtSaleDay.Location = New System.Drawing.Point(218, 167)
        Me.TxtSaleDay.Name = "TxtSaleDay"
        Me.TxtSaleDay.Size = New System.Drawing.Size(356, 20)
        Me.TxtSaleDay.TabIndex = 132
        Me.TxtSaleDay.Text = "SaleDay"
        '
        'TxbStaffID
        '
        Me.TxbStaffID.Location = New System.Drawing.Point(218, 212)
        Me.TxbStaffID.Name = "TxbStaffID"
        Me.TxbStaffID.Size = New System.Drawing.Size(356, 20)
        Me.TxbStaffID.TabIndex = 131
        Me.TxbStaffID.Text = "StaffID"
        '
        'TxbSaleTime
        '
        Me.TxbSaleTime.Location = New System.Drawing.Point(218, 123)
        Me.TxbSaleTime.Name = "TxbSaleTime"
        Me.TxbSaleTime.Size = New System.Drawing.Size(356, 20)
        Me.TxbSaleTime.TabIndex = 130
        Me.TxbSaleTime.Text = "SaleTime"
        '
        'btnlastStock
        '
        Me.btnlastStock.AutoSize = True
        Me.btnlastStock.Location = New System.Drawing.Point(580, 251)
        Me.btnlastStock.Name = "btnlastStock"
        Me.btnlastStock.Size = New System.Drawing.Size(144, 41)
        Me.btnlastStock.TabIndex = 129
        Me.btnlastStock.Text = "Last Stock Detalis"
        Me.btnlastStock.UseVisualStyleBackColor = True
        '
        'btnfirstStock
        '
        Me.btnfirstStock.Location = New System.Drawing.Point(580, 114)
        Me.btnfirstStock.Name = "btnfirstStock"
        Me.btnfirstStock.Size = New System.Drawing.Size(144, 41)
        Me.btnfirstStock.TabIndex = 128
        Me.btnfirstStock.Text = "First Stock Details"
        Me.btnfirstStock.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(218, 301)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(144, 41)
        Me.btndelete.TabIndex = 127
        Me.btndelete.Text = "Delete Stock Detalis"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Location = New System.Drawing.Point(580, 208)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(144, 41)
        Me.btnprev.TabIndex = 126
        Me.btnprev.Text = "Prev Stock"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(59, 301)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(144, 41)
        Me.btnadd.TabIndex = 125
        Me.btnadd.Text = "Add Stock Details "
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(580, 161)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(144, 41)
        Me.btnnext.TabIndex = 124
        Me.btnnext.Text = "Next Stock"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(383, 301)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(144, 41)
        Me.btnupdate.TabIndex = 123
        Me.btnupdate.Text = "Update Stock Details"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(580, 67)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(144, 41)
        Me.btnclear.TabIndex = 122
        Me.btnclear.Text = "Clear Stock Details"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(581, 12)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(144, 41)
        Me.btncancel.TabIndex = 121
        Me.btncancel.Text = "Cancel Process "
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'TxbSaleID
        '
        Me.TxbSaleID.Location = New System.Drawing.Point(218, 78)
        Me.TxbSaleID.Name = "TxbSaleID"
        Me.TxbSaleID.Size = New System.Drawing.Size(356, 20)
        Me.TxbSaleID.TabIndex = 120
        Me.TxbSaleID.Text = "SaleID"
        '
        'LblSaleID
        '
        Me.LblSaleID.AutoSize = True
        Me.LblSaleID.Location = New System.Drawing.Point(116, 83)
        Me.LblSaleID.Name = "LblSaleID"
        Me.LblSaleID.Size = New System.Drawing.Size(39, 13)
        Me.LblSaleID.TabIndex = 119
        Me.LblSaleID.Text = "SaleID"
        '
        'ProductSalesDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.LblCustomerID)
        Me.Controls.Add(Me.LblStaffID)
        Me.Controls.Add(Me.LblSaleDay)
        Me.Controls.Add(Me.LblSaleTime)
        Me.Controls.Add(Me.LblCustomerIDError)
        Me.Controls.Add(Me.LblStaffError)
        Me.Controls.Add(Me.lblSaleDayError)
        Me.Controls.Add(Me.LblSaleTimeError)
        Me.Controls.Add(Me.LblSaleIDError)
        Me.Controls.Add(Me.TxbCustomerID)
        Me.Controls.Add(Me.TxtSaleDay)
        Me.Controls.Add(Me.TxbStaffID)
        Me.Controls.Add(Me.TxbSaleTime)
        Me.Controls.Add(Me.btnlastStock)
        Me.Controls.Add(Me.btnfirstStock)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.TxbSaleID)
        Me.Controls.Add(Me.LblSaleID)
        Me.Name = "ProductSalesDesign"
        Me.Text = "ProductSalesDesign"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents LblCustomerID As Label
    Friend WithEvents LblStaffID As Label
    Friend WithEvents LblSaleDay As Label
    Friend WithEvents LblSaleTime As Label
    Friend WithEvents LblCustomerIDError As Label
    Friend WithEvents LblStaffError As Label
    Friend WithEvents lblSaleDayError As Label
    Friend WithEvents LblSaleTimeError As Label
    Friend WithEvents LblSaleIDError As Label
    Friend WithEvents TxbCustomerID As TextBox
    Friend WithEvents TxtSaleDay As TextBox
    Friend WithEvents TxbStaffID As TextBox
    Friend WithEvents TxbSaleTime As TextBox
    Friend WithEvents btnlastStock As Button
    Friend WithEvents btnfirstStock As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnprev As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents TxbSaleID As TextBox
    Friend WithEvents LblSaleID As Label
End Class
