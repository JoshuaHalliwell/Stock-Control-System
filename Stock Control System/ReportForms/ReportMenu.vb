Public Class ReportMenu
    Private Sub ReportMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundCornerButton(BtnBackupData)
        RoundCornerButton(BtnGraphReport)
    End Sub

    Private Sub BtnGraphReport_Click(sender As Object, e As EventArgs) Handles BtnGraphReport.Click
        OpenChildForm(New ReportGraph)
    End Sub

    Private Sub BtnBackupData_Click(sender As Object, e As EventArgs) Handles BtnBackupData.Click
        OpenChildForm(New ReportDatabaseTable)
    End Sub
End Class