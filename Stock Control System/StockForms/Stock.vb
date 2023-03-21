Public Class Stock
    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        sql = "SELECT * FROM TblStock"
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, "TblStock") 'Fill whatever is in the data adapter to the DataSet'
        con.Close() 'Close the connection with the database(leavering it open can cause errors such as lag)'
        DGVStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        GrpSearch.Hide()
        GrpSort.Hide()

        If radID.Checked = False Then
            txbID.Enabled = False
        End If

        If radName.Checked = False Then
            txbname.Enabled = False
        End If

        RoundCornerButton(BtnSearchStock)
        RoundCornerButton(BtnSortByDisplayStock)                                   'calls the roundCornerButton module
        RoundCornerButton(BtnSortByStorageStock)
        RoundCornerButton(BtnAddStock)
        RoundCornerButton(BtnDeleteStock)
        RoundCornerButton(BtnUpdateStock)
        Llbchange.Hide()
        cbproductchange.Hide()

        Tablename = "TblStock"
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnAddStock.Click
        OpenChildForm(New StockAdd)                                                         ' opends the form in the open child form layout and closes this main form

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnDeleteStock.Click
        OpenChildForm(New StockAdd)                                                         ' opends the form in the open child form layout and closes this main form

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnUpdateStock.Click
        OpenChildForm(New StockAdd)                                                         ' opends the form in the open child form layout and closes this main form
    End Sub


End Class