Imports System.Runtime.InteropServices
Imports System.Threading

Public Class MainMenu
    Private CurrentChildForm As Form
    Private currentBtn As Button
    Private leftBorderBtn As Panel
    Private SelecteForm As Form
    Dim Chosentable As String
    Dim BackupData As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()                                           'Starts to fromat the left bolder for the main menu'  
        leftBorderBtn.Size = New Size(7, 60)
        PanelLeft.Controls.Add(leftBorderBtn)
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
    End Sub
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(StudentAccess)
        LblUsername.Text = Form1.Username
        Timer1.Start()                                                          ' starts the timer once the form is loaded
        LblWelcomemessage.Hide()
        LblFormName.Text = "Home"

        BtnCustomers.BackColor = ColourClass.Steelcolour
        BtnHome.BackColor = ColourClass.Steelcolour
        BtnLogoff.BackColor = ColourClass.Steelcolour
        BtnProductSales.BackColor = ColourClass.Steelcolour
        BtnReports.BackColor = ColourClass.Steelcolour
        BtnStaff.BackColor = ColourClass.Steelcolour
        BtnStock.BackColor = ColourClass.Steelcolour
        BtnSuppliersOrders.BackColor = ColourClass.Steelcolour

        With Form1
            'access level 
        End With
    End Sub
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, Button)
            currentBtn.BackColor = Color.FromArgb(95, 158, 160) '  the rgb colour  levles for steelblue in order to inport the colour in the menu format 
            currentBtn.ForeColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage         'Changes what the current selceted panle buttion will look like in order to show the section selectetion
            'left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then                                     'Disbble the panle that is currently selected
            currentBtn.BackColor = Color.FromArgb(70, 130, 180)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub


    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click

        ActivateButton(sender, ColourClass.whitecolour)                    'simple opening the form in the child form loadout  by the active button
        Try
            LblWelcomemessage.Show()
            LblWelcomemessage.Text = ("Welcome to the system")            '" LblUsername  "'")
            Reset()
        Catch ex As Exception
        End Try

        OpenChildForm(New HomeForm)
        LblFormName.Text = "Home Page"
    End Sub
    Private Sub Reset()                                                'Rest just turns all the icon to the home / blank form menu
        DisableButton()
        leftBorderBtn.Visible = False
        LblFormName.Text = "Home Page"
    End Sub

    Private Sub BtnStock_Click(sender As Object, e As EventArgs) Handles BtnStock.Click
        ActivateButton(sender, ColourClass.whitecolour)                    'simple opening the form in the child form loadout  by the active button
        OpenChildForm(New Stock)
        LblFormName.Text = "Stock Page"

    End Sub

    Private Sub BtnStaff_Click(sender As Object, e As EventArgs) Handles BtnStaff.Click
        ActivateButton(sender, ColourClass.whitecolour)                    'simple opening the form in the child form loadout  by the active button
        'OpenChildForm(New GameApplianceListForm)
        LblFormName.Text = "Staff Page"


    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        ActivateButton(sender, ColourClass.whitecolour)                    'simple opening the form in the child form loadout  by the active button
        OpenChildForm(New Customers)
        LblFormName.Text = "Customer Page"

    End Sub

    Private Sub BtnSuppliersOrders_Click(sender As Object, e As EventArgs) Handles BtnSuppliersOrders.Click
        ActivateButton(sender, ColourClass.whitecolour)                    'simple opening the form in the child form loadout  by the active button
        'OpenChildForm(New GameApplianceListForm)
        LblFormName.Text = "Suppliers Order"

    End Sub

    Private Sub BtnProductSales_Click(sender As Object, e As EventArgs) Handles BtnProductSales.Click
        ActivateButton(sender, ColourClass.whitecolour)                    'simple opening the form in the child form loadout  by the active button
        OpenChildForm(New SalesView)
        LblFormName.Text = "Product Sales Page"

    End Sub

    Private Sub BtnReports_Click(sender As Object, e As EventArgs) Handles BtnReports.Click
        ActivateButton(sender, ColourClass.whitecolour)                    'simple opening the form in the child form loadout  by the active button
        'OpenChildForm(New GameApplianceListForm)
        LblFormName.Text = "Report Page"

    End Sub

    Private Sub BtnLogoff_Click(sender As Object, e As EventArgs) Handles BtnLogoff.Click
        ActivateButton(sender, ColourClass.whitecolour)                 'simple opening the form in the child form loadout  by the active button
        Form1.Show()
        Me.Hide()
    End Sub

    'The method to smothly drag forms' 
    <DllImport("User32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub RealeaseCapture()
    End Sub
    <DllImport("User32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Paneltop_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseDown
        RealeaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelMain_Paint(sender As Object, e As PaintEventArgs) Handles PanelMain.Paint

    End Sub
End Class