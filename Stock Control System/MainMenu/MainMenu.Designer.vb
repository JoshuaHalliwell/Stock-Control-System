<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblFormName = New System.Windows.Forms.Label()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.BtnLogoff = New System.Windows.Forms.Button()
        Me.BtnReports = New System.Windows.Forms.Button()
        Me.BtnProductSales = New System.Windows.Forms.Button()
        Me.BtnSuppliersOrders = New System.Windows.Forms.Button()
        Me.BtnCustomers = New System.Windows.Forms.Button()
        Me.BtnStaff = New System.Windows.Forms.Button()
        Me.BtnStock = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.LblWelcomemessage = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelTop.SuspendLayout()
        Me.PanelLeft.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelTop.Controls.Add(Me.LblUsername)
        Me.PanelTop.Controls.Add(Me.LblFormName)
        Me.PanelTop.Controls.Add(Me.PictureBox1)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1067, 78)
        Me.PanelTop.TabIndex = 0
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblUsername.Location = New System.Drawing.Point(563, 26)
        Me.LblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(95, 31)
        Me.LblUsername.TabIndex = 38
        Me.LblUsername.Text = "Label1"
        '
        'LblFormName
        '
        Me.LblFormName.AutoSize = True
        Me.LblFormName.BackColor = System.Drawing.Color.SteelBlue
        Me.LblFormName.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFormName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblFormName.Location = New System.Drawing.Point(175, 11)
        Me.LblFormName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFormName.Name = "LblFormName"
        Me.LblFormName.Size = New System.Drawing.Size(300, 52)
        Me.LblFormName.TabIndex = 4
        Me.LblFormName.Text = "LblFormName"
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelLeft.Controls.Add(Me.BtnLogoff)
        Me.PanelLeft.Controls.Add(Me.BtnReports)
        Me.PanelLeft.Controls.Add(Me.BtnProductSales)
        Me.PanelLeft.Controls.Add(Me.BtnSuppliersOrders)
        Me.PanelLeft.Controls.Add(Me.BtnCustomers)
        Me.PanelLeft.Controls.Add(Me.BtnStaff)
        Me.PanelLeft.Controls.Add(Me.BtnStock)
        Me.PanelLeft.Controls.Add(Me.BtnHome)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 78)
        Me.PanelLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(153, 476)
        Me.PanelLeft.TabIndex = 1
        '
        'BtnLogoff
        '
        Me.BtnLogoff.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogoff.Location = New System.Drawing.Point(0, 417)
        Me.BtnLogoff.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLogoff.Name = "BtnLogoff"
        Me.BtnLogoff.Size = New System.Drawing.Size(153, 59)
        Me.BtnLogoff.TabIndex = 7
        Me.BtnLogoff.Text = "Log Off"
        Me.BtnLogoff.UseVisualStyleBackColor = True
        '
        'BtnReports
        '
        Me.BtnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReports.Location = New System.Drawing.Point(0, 358)
        Me.BtnReports.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReports.Name = "BtnReports"
        Me.BtnReports.Size = New System.Drawing.Size(153, 59)
        Me.BtnReports.TabIndex = 6
        Me.BtnReports.Text = "Reports"
        Me.BtnReports.UseVisualStyleBackColor = True
        '
        'BtnProductSales
        '
        Me.BtnProductSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProductSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductSales.Location = New System.Drawing.Point(0, 299)
        Me.BtnProductSales.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnProductSales.Name = "BtnProductSales"
        Me.BtnProductSales.Size = New System.Drawing.Size(153, 59)
        Me.BtnProductSales.TabIndex = 5
        Me.BtnProductSales.Text = "Product Sales "
        Me.BtnProductSales.UseVisualStyleBackColor = True
        '
        'BtnSuppliersOrders
        '
        Me.BtnSuppliersOrders.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSuppliersOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSuppliersOrders.Location = New System.Drawing.Point(0, 240)
        Me.BtnSuppliersOrders.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSuppliersOrders.Name = "BtnSuppliersOrders"
        Me.BtnSuppliersOrders.Size = New System.Drawing.Size(153, 59)
        Me.BtnSuppliersOrders.TabIndex = 4
        Me.BtnSuppliersOrders.Text = "Suppliers Orders "
        Me.BtnSuppliersOrders.UseVisualStyleBackColor = True
        '
        'BtnCustomers
        '
        Me.BtnCustomers.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCustomers.Location = New System.Drawing.Point(0, 181)
        Me.BtnCustomers.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCustomers.Name = "BtnCustomers"
        Me.BtnCustomers.Size = New System.Drawing.Size(153, 59)
        Me.BtnCustomers.TabIndex = 3
        Me.BtnCustomers.Text = "Customers"
        Me.BtnCustomers.UseVisualStyleBackColor = True
        '
        'BtnStaff
        '
        Me.BtnStaff.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnStaff.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStaff.Location = New System.Drawing.Point(0, 122)
        Me.BtnStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnStaff.Name = "BtnStaff"
        Me.BtnStaff.Size = New System.Drawing.Size(153, 59)
        Me.BtnStaff.TabIndex = 2
        Me.BtnStaff.Text = "Staff"
        Me.BtnStaff.UseVisualStyleBackColor = False
        '
        'BtnStock
        '
        Me.BtnStock.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnStock.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStock.Location = New System.Drawing.Point(0, 63)
        Me.BtnStock.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnStock.Name = "BtnStock"
        Me.BtnStock.Size = New System.Drawing.Size(153, 59)
        Me.BtnStock.TabIndex = 1
        Me.BtnStock.Text = "Stock"
        Me.BtnStock.UseVisualStyleBackColor = False
        '
        'BtnHome
        '
        Me.BtnHome.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHome.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHome.Location = New System.Drawing.Point(0, 0)
        Me.BtnHome.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(153, 63)
        Me.BtnHome.TabIndex = 0
        Me.BtnHome.Text = "Home"
        Me.BtnHome.UseVisualStyleBackColor = False
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelMain.Controls.Add(Me.LblWelcomemessage)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(153, 78)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(914, 476)
        Me.PanelMain.TabIndex = 2
        '
        'LblWelcomemessage
        '
        Me.LblWelcomemessage.AutoSize = True
        Me.LblWelcomemessage.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblWelcomemessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWelcomemessage.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblWelcomemessage.Location = New System.Drawing.Point(352, 192)
        Me.LblWelcomemessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblWelcomemessage.Name = "LblWelcomemessage"
        Me.LblWelcomemessage.Size = New System.Drawing.Size(249, 52)
        Me.LblWelcomemessage.TabIndex = 39
        Me.LblWelcomemessage.Text = "lblWelcome"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Stock_Control_System.My.Resources.Resources.SJR_white_logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.PanelTop)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents LblFormName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents BtnLogoff As Button
    Friend WithEvents BtnReports As Button
    Friend WithEvents BtnProductSales As Button
    Friend WithEvents BtnSuppliersOrders As Button
    Friend WithEvents BtnCustomers As Button
    Friend WithEvents BtnStaff As Button
    Friend WithEvents BtnStock As Button
    Friend WithEvents BtnHome As Button
    Friend WithEvents PanelMain As Panel
    Friend WithEvents LblUsername As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblWelcomemessage As Label
End Class
