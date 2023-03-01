Module ChildForm
    Dim PanelMain = MainMenu.PanelMain
    Dim CurrentChildForm As Form
    Public Sub OpenChildForm(ByRef ChildForm As Form)
        CurrentChildForm = ChildForm
        ChildForm.TopLevel = False
        ChildForm.FormBorderStyle = FormBorderStyle.None
        PanelMain.Controls.Add(CurrentChildForm)
        PanelMain.Tag = ChildForm
        ChildForm.BringToFront()
        ChildForm.Show()
        ChildForm.Dock = DockStyle.Fill
    End Sub
End Module
