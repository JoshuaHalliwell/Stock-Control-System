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
        DGVCustomers.DataMember = "TblStaff" 'Specify the table to be displayed in the DataGridView
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

        If radEmail.Checked = False Then
            txbEmail.Enabled = False
        End If
        RoundCornerButton(BtnAddStaff)
        RoundCornerButton(BtnDeleteStaff)  'calls the roundCornerButton module
        RoundCornerButton(BtnEditStaff)
        RoundCornerButton(BtnSearchStaff)
        RoundCornerButton(BtnSortStaff)

        Llbchange.Hide()
        cbSaffsales.Hide()

        Tablename = "TblStaff"
    End Sub



    Private Sub txbID_TextChanged(sender As Object, e As EventArgs) Handles txbID.TextChanged
        con.Open()
        sql = "SELECT * FROM TblStaff WHERE CustomerID LIKE '%" & txbID.Text & "%'"             ' Sql checks to find a simular result in the database  
        SandSconnection(DGVCustomers, sql)                                                               'Sends the data grid to the connection opration 
    End Sub

    Private Sub txbname_TextChanged(sender As Object, e As EventArgs) Handles txbname.TextChanged
        con.Open()
        sql = "SELECT * FROM TblStaff WHERE StaffFirstname LIKE '%" & txbname.Text & "%' OR WHERE StaffSurname LIKE '%" & txbname.Text & "%' "            ' Sql checks to find a simular result in the database  
        SandSconnection(DGVCustomers, sql)                                                               'Sends the data grid to the connection opration 
    End Sub

    Private Sub txbEmail_TextChanged(sender As Object, e As EventArgs) Handles txbEmail.TextChanged
        con.Open()
        sql = "SELECT * FROM TblStaff WHERE StaffEmail LIKE '%" & txbEmail.Text & "%'"             ' Sql checks to find a simular result in the database  
        SandSconnection(DGVCustomers, sql)                                                               'Sends the data grid to the connection opration 
    End Sub

    Private Sub radID_CheckedChanged(sender As Object, e As EventArgs) Handles radID.CheckedChanged
        If radID.Checked = True Then                  'It enables Or disables the textbox depending On whether the radio button Is checked.
            txbID.Enabled = True                      'If the radio button Is checked,the textbox Is enabled,
        Else txbID.Enabled = False : txbID.Text = ""  'Otherwise, it Is disabled And its text value Is cleared.                                                                                                                                                                                                                                                                                                                                     ' ^
        End If
    End Sub

    Private Sub radName_CheckedChanged(sender As Object, e As EventArgs) Handles radName.CheckedChanged
        If radName.Checked = True Then                      'It enables Or disables the textbox depending On whether the radio button Is checked.                                                                                                                                                                                                                                                                                                                                                       ' Selection to determine whether to disable field
            txbname.Enabled = True                          'If the radio button Is checked,the textbox Is enabled,
        Else txbname.Enabled = False : txbname.Text = ""    'Otherwise, it Is disabled And its text value Is cleared.                                                                                                                                                                                                                                                                                                                                   ' ^
        End If
    End Sub

    Private Sub RadCustomerEmail_CheckedChanged(sender As Object, e As EventArgs) Handles radEmail.CheckedChanged
        If radEmail.Checked = True Then                     'It enables Or disables the textbox depending On whether the radio button Is checked.                                                                                                                                                                                                                                                                                                                                                         ' Selection to determine whether to disable field
            txbEmail.Enabled = True                        'If the radio button Is checked,the textbox Is enabled,
        Else txbEmail.Enabled = False : txbEmail.Text = "" 'Otherwise, it Is disabled And its text value Is cleared.                                                                                                                                                                                                                                                                                                                                       ' ^
        End If
    End Sub

    Private Sub cbproductchange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSaffsales.SelectedIndexChanged
        If cbSaffsales.SelectedItem = "Made Sales" Then
            sql = "SELECT TblSales.StaffID, TblStaff.StaffFirstname, TblStaff.StaffSurname, TblStaff.StaffEmail, TblSales.SaleID FROM TblStaff INNER JOIN TblSales ON TblStaff.StaffID = TblSales.StaffID ORDER BY TblSales.StaffID"
            Tablename = "QryStaffSales"
            SandSconnection(DGVCustomers, sql)                                                               'Sends the data grid to the connection opration 

        ElseIf cbSaffsales.SelectedItem = "No Sales" Then
            sql = "SELECT TblStaff.StaffID, TblStaff.StaffFirstname, TblStaff.StaffSurname, TblStaff.StaffEmail FROM TblStaff INNER JOIN TblSales ON TblStaff.StaffID = TblSales.StaffID WHERE (((TblSales.SaleID) Is Null))"
            Tablename = "QryNoStaffSales"
            SandSconnection(DGVCustomers, sql)                                                               'Sends the data grid to the connection opration 
        End If
    End Sub
End Class