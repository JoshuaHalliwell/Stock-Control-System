Public Class StaffView
    Private Sub BtnAddStaff_Click(sender As Object, e As EventArgs) Handles BtnAddStaff.Click
        OpenChildForm(New CustomerData)  ' opends the form in the open child form layout and closes this main form
    End Sub

    Private Sub BtnEditStaff_Click(sender As Object, e As EventArgs) Handles BtnEditStaff.Click
        OpenChildForm(New CustomerData)  ' opends the form in the open child form layout and closes this main form
    End Sub

    Private Sub BtnDeleteStaff_Click(sender As Object, e As EventArgs) Handles BtnDeleteStaff.Click
        OpenChildForm(New CustomerData) ' opends the form in the open child form layout and closes this main form
    End Sub

    Private Sub BtnSearchStaff_Click(sender As Object, e As EventArgs) Handles BtnSearchStaff.Click
        GrpSearch.Show()
        GrpSort.Hide()
    End Sub

    Private Sub BtnSortStaff_Click(sender As Object, e As EventArgs) Handles BtnSortStaff.Click
        GrpSearch.Hide()
        GrpSort.Show()
    End Sub

    Private Sub StaffView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        sql = "SELECT * FROM TblStaff"
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, "TblStaff") 'Fill whatever is in the data adapter to the DataSet'
        DGVCustomers.DataSource = ds
        DGVCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        con.Close() 'Close the connection with the database(leavering it open can cause errors such as lag)'

        GrpSearch.Hide()
        GrpSort.Hide()
        If radID.Checked = False Then
            txbID.Enabled = False
        End If

        If radName.Checked = False Then
            txbname.Enabled = False
        End If

        If RadCustomerEmail.Checked = False Then
            txbEmail.Enabled = False
        End If
        RoundCornerButton(BtnAddStaff)
        RoundCornerButton(BtnDeleteStaff)  'calls the roundCornerButton module
        RoundCornerButton(BtnEditStaff)
        RoundCornerButton(BtnSearchStaff)
        RoundCornerButton(BtnSortStaff)

        Llbchange.Hide()
        cbproductchange.Hide()

        Tablename = "TblStaff"
    End Sub

    Private Sub DGVCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCustomers.CellContentClick

    End Sub
End Class