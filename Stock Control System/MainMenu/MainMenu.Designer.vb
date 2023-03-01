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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblWelcomemessage = New System.Windows.Forms.Label()
        Me.PanelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLeft.SuspendLayout()
        Me.PanelMain.SuspendLayout()
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
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(800, 63)
        Me.PanelTop.TabIndex = 0
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblUsername.Location = New System.Drawing.Point(422, 21)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(77, 25)
        Me.LblUsername.TabIndex = 38
        Me.LblUsername.Text = "Label1"
        '
        'LblFormName
        '
        Me.LblFormName.AutoSize = True
        Me.LblFormName.BackColor = System.Drawing.Color.SteelBlue
        Me.LblFormName.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFormName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblFormName.Location = New System.Drawing.Point(131, 9)
        Me.LblFormName.Name = "LblFormName"
        Me.LblFormName.Size = New System.Drawing.Size(238, 39)
        Me.LblFormName.TabIndex = 4
        Me.LblFormName.Text = "LblFormName"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Stock_Control_System.My.Resources.Resources.SJR_white_logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
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
        Me.PanelLeft.Location = New System.Drawing.Point(0, 63)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(115, 387)
        Me.PanelLeft.TabIndex = 1
        '
        'BtnLogoff
        '
        Me.BtnLogoff.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLogoff.Location = New System.Drawing.Point(0, 339)
        Me.BtnLogoff.Name = "BtnLogoff"
        Me.BtnLogoff.Size = New System.Drawing.Size(115, 48)
        Me.BtnLogoff.TabIndex = 7
        Me.BtnLogoff.Text = "Log Off"
        Me.BtnLogoff.UseVisualStyleBackColor = True
        '
        'BtnReports
        '
        Me.BtnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReports.Location = New System.Drawing.Point(0, 291)
        Me.BtnReports.Name = "BtnReports"
        Me.BtnReports.Size = New System.Drawing.Size(115, 48)
        Me.BtnReports.TabIndex = 6
        Me.BtnReports.Text = "Reports"
        Me.BtnReports.UseVisualStyleBackColor = True
        '
        'BtnProductSales
        '
        Me.BtnProductSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProductSales.Location = New System.Drawing.Point(0, 243)
        Me.BtnProductSales.Name = "BtnProductSales"
        Me.BtnProductSales.Size = New System.Drawing.Size(115, 48)
        Me.BtnProductSales.TabIndex = 5
        Me.BtnProductSales.Text = "Product Sales "
        Me.BtnProductSales.UseVisualStyleBackColor = True
        '
        'BtnSuppliersOrders
        '
        Me.BtnSuppliersOrders.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSuppliersOrders.Location = New System.Drawing.Point(0, 195)
        Me.BtnSuppliersOrders.Name = "BtnSuppliersOrders"
        Me.BtnSuppliersOrders.Size = New System.Drawing.Size(115, 48)
        Me.BtnSuppliersOrders.TabIndex = 4
        Me.BtnSuppliersOrders.Text = "Suppliers Orders "
        Me.BtnSuppliersOrders.UseVisualStyleBackColor = True
        '
        'BtnCustomers
        '
        Me.BtnCustomers.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCustomers.Location = New System.Drawing.Point(0, 147)
        Me.BtnCustomers.Name = "BtnCustomers"
        Me.BtnCustomers.Size = New System.Drawing.Size(115, 48)
        Me.BtnCustomers.TabIndex = 3
        Me.BtnCustomers.Text = "Customers"
        Me.BtnCustomers.UseVisualStyleBackColor = True
        '
        'BtnStaff
        '
        Me.BtnStaff.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnStaff.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnStaff.Location = New System.Drawing.Point(0, 99)
        Me.BtnStaff.Name = "BtnStaff"
        Me.BtnStaff.Size = New System.Drawing.Size(115, 48)
        Me.BtnStaff.TabIndex = 2
        Me.BtnStaff.Text = "Staff"
        Me.BtnStaff.UseVisualStyleBackColor = False
        '
        'BtnStock
        '
        Me.BtnStock.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnStock.Location = New System.Drawing.Point(0, 51)
        Me.BtnStock.Name = "BtnStock"
        Me.BtnStock.Size = New System.Drawing.Size(115, 48)
        Me.BtnStock.TabIndex = 1
        Me.BtnStock.Text = "Stock"
        Me.BtnStock.UseVisualStyleBackColor = False
        '
        'BtnHome
        '
        Me.BtnHome.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHome.Location = New System.Drawing.Point(0, 0)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(115, 51)
        Me.BtnHome.TabIndex = 0
        Me.BtnHome.Text = "Home"
        Me.BtnHome.UseVisualStyleBackColor = False
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelMain.Controls.Add(Me.LblWelcomemessage)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(115, 63)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(685, 387)
        Me.PanelMain.TabIndex = 2
        '
        'LblWelcomemessage
        '
        Me.LblWelcomemessage.AutoSize = True
        Me.LblWelcomemessage.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblWelcomemessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWelcomemessage.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblWelcomemessage.Location = New System.Drawing.Point(264, 156)
        Me.LblWelcomemessage.Name = "LblWelcomemessage"
        Me.LblWelcomemessage.Size = New System.Drawing.Size(198, 39)
        Me.LblWelcomemessage.TabIndex = 39
        Me.LblWelcomemessage.Text = "lblWelcome"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.PanelTop)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
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
