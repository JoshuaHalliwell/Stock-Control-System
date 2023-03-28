Public Class Customers

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        sql = "SELECT * FROM TblCustomer"
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, "TblCustomer") 'Fill whatever is in the data adapter to the DataSet'
        DGVCustomers.DataSource = ds
        DGVCustomers.DataMember = "TblCustomer"
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
        RoundCornerButton(BtnAdd)
        RoundCornerButton(BtnDelete)                                   'calls the roundCornerButton module
        RoundCornerButton(BtnEdit)
        RoundCornerButton(BtnSearchCustomer)
        RoundCornerButton(BtnSortCustomers)

        Llbchange.Hide()
        cbCustomerID.Hide()

        Tablename = "TblCustomer"
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        OpenChildForm(New CustomerData)                                                         ' opends the form in the open child form layout and closes this main form
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        OpenChildForm(New CustomerData)                                                         ' opends the form in the open child form layout and closes this main form

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        OpenChildForm(New CustomerData)                                                         ' opends the form in the open child form layout and closes this main form

    End Sub

    Private Sub txbID_TextChanged(sender As Object, e As EventArgs) Handles txbID.TextChanged
        con.Open()
        sql = "SELECT * FROM TblCustomer WHERE CustomerID LIKE '%" & txbID.Text & "%'"             ' Sql checks to find a simular result in the database  
        Dim Results As New DataTable                                                                                                                                                                                                                                                                                                                                                        ' Declare data table
        ' Declare and populate varaible
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(Results) 'Fill whatever is in the data adapter to the DataSet'
        DGVCustomers.DataSource = Results                                                                                                                                                                                                                                                                                                                                                      ' Populate data grid using data table
        con.Close() 'Sends the data grid to the connection opration 
        'da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        'da.Fill(ds, Tablename) 'Fill whatever is in the data adapter to the DataSet'
        'DGVCustomers.DataSource = ds
        'DGVCustomers.DataMember = Tablename

    End Sub

    Private Sub BtnSearchCustomer_Click(sender As Object, e As EventArgs) Handles BtnSearchCustomer.Click
        GrpSearch.Show()
        GrpSort.Hide()
    End Sub
    Private Sub BtnSortCustomers_Click(sender As Object, e As EventArgs) Handles BtnSortCustomers.Click
        GrpSearch.Hide()
        GrpSort.Show()
    End Sub
    Private Sub radID_CheckedChanged(sender As Object, e As EventArgs) Handles radID.CheckedChanged
        If radID.Checked = True Then                                                                                                                                                                                                                                                                                                                                                        ' Selection to determine whether to disable field
            txbID.Enabled = True
        Else txbID.Enabled = False : txbID.Text = ""                                                                                                                                                                                                                                                                                                                                        ' ^
        End If
    End Sub

    Private Sub radName_CheckedChanged(sender As Object, e As EventArgs) Handles radName.CheckedChanged
        If radName.Checked = True Then                                                                                                                                                                                                                                                                                                                                                        ' Selection to determine whether to disable field
            txbname.Enabled = True
        Else txbname.Enabled = False : txbname.Text = ""                                                                                                                                                                                                                                                                                                                                        ' ^
        End If
    End Sub

    Private Sub RadCustomerEmail_CheckedChanged(sender As Object, e As EventArgs) Handles RadCustomerEmail.CheckedChanged
        If RadCustomerEmail.Checked = True Then                                                                                                                                                                                                                                                                                                                                                        ' Selection to determine whether to disable field
            txbEmail.Enabled = True
        Else txbEmail.Enabled = False : txbEmail.Text = ""                                                                                                                                                                                                                                                                                                                                        ' ^
        End If
    End Sub

    Private Sub txbname_TextChanged(sender As Object, e As EventArgs) Handles txbname.TextChanged
        Try

            con.Open()
            sql = "SELECT * FROM TblCustomer WHERE (((TblCustomer.CustomerFirstname) LIKE'%" & txbname.Text & "%'))"            ' Sql checks to find a simular result in the database  
            Dim Results As New DataTable                                                                                                                                                                                                                                                                                                                                                        ' Declare data table
            ' Declare and populate varaible
            da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
            da.Fill(Results) 'Fill whatever is in the data adapter to the DataSet'
            DGVCustomers.DataSource = Results                                                                                                                                                                                                                                                                                                                                                      ' Populate data grid using data table
            con.Close() 'Sends the data grid to the connection opration 
            'da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
            'da.Fill(ds, Tablename) 'Fill whatever is in the data adapter to the DataSet'
            'DGVCustomers.DataSource = ds
            'DGVCustomers.DataMember = Tablename
        Catch ex As Exception
            MsgBox(ex)

        End Try
        con.Close()                                                            'Sends the data grid to the connection opration 
    End Sub

    Private Sub txbEmail_TextChanged(sender As Object, e As EventArgs) Handles txbEmail.TextChanged
        con.Open()
        sql = "Select * FROM TblCustomer WHERE CustomerEmail Like '%" & txbEmail.Text & "%'"             ' Sql checks to find a simular result in the database  
        SandSconnection(DGVCustomers, sql)                                                               'Sends the data grid to the connection opration 
    End Sub



    Private Sub cbproductchange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCustomerID.SelectedIndexChanged
        If cbCustomerID.SelectedItem = "Ascending Order" Then
            sql = "SELECT TblCustomer.CustomerID, TblCustomer.CustomerFirstname, TblCustomer.CustomerSurname, TblCustomer.CustomerEmail, TblCustomer.CustomerPhoneNumber, TblCustomer.CustomerPostcode From TblCustomer Order By TblCustomer.CustomerID;"
            SandSconnection(DGVCustomers, sql)                                                               'Sends the data grid to the connection opration 

        ElseIf cbCustomerID.SelectedItem = "Desending Order" Then
            sql = "SELECT TblCustomer.CustomerID, TblCustomer.CustomerFirstname, TblCustomer.CustomerSurname, TblCustomer.CustomerEmail, TblCustomer.CustomerPhoneNumber, TblCustomer.CustomerPostcode FROM TblCustomer ORDER BY TblCustomer.CustomerID DESC;"
            SandSconnection(DGVCustomers, sql)
        End If
    End Sub

End Class