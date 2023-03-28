Public Class SalesView
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        OpenChildForm(New ProductSales)
    End Sub

    Private Sub SalesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        sql = "SELECT TblSales.SaleID, TblStocks.StockID, TblStocks.ProductName, TblSalesLine.SaleQuantity, TblSales.SaleTime, TblSales.SaleDay, TblSales.CustomerID, TblSales.StaffID, [SaleQuantity]*[PricePerItem] AS SalePrice From TblStocks INNER Join (TblSales INNER Join TblSalesLine On TblSales.SaleID = TblSalesLine.SaleID) ON TblStocks.StockID = TblSalesLine.StockID"
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, "QrySales") 'Fill whatever is in the data adapter to the DataSet'
        DGVSales.DataSource = ds
        DGVSales.DataMember = "QrySales"
        DGVSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        con.Close() 'Close the connection with the database(leavering it open can cause errors such as lag)

        GrpSearch.Hide()
        GrpSort.Hide()
        If radID.Checked = False Then
            txbID.Enabled = False
        End If

        If radName.Checked = False Then
            txbname.Enabled = False
        End If

        If RadQuantity.Checked = False Then
            txbquantity.Enabled = False
        End If
        RoundCornerButton(BtnAdd)
        RoundCornerButton(BtnDelete)                                   'calls the roundCornerButton module
        RoundCornerButton(BtnEdit)
        RoundCornerButton(BtnSearchSalesLine)
        RoundCornerButton(BtnSortCustomers)

        Llbchange.Hide()
        cbproductchange.Hide()

        Tablename = "QrySales"
    End Sub

    Private Sub txbID_TextChanged(sender As Object, e As EventArgs) Handles txbID.TextChanged
        con.Open()
        sql = "SELECT * FROM QrySales WHERE SalesID like '%" & txbID.Text & "%'"             ' Sql checks to find a simular result in the database  
        SandSconnection(DGVSales, sql)
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

    Private Sub RadQuantity_CheckedChanged(sender As Object, e As EventArgs) Handles RadQuantity.CheckedChanged
        If RadQuantity.Checked = True Then                                                                                                                                                                                                                                                                                                                                                        ' Selection to determine whether to disable field
            txbquantity.Enabled = True
        Else txbquantity.Enabled = False : txbquantity.Text = ""                                                                                                                                                                                                                                                                                                                                        ' ^
        End If
    End Sub

    Private Sub txbname_TextChanged(sender As Object, e As EventArgs) Handles txbname.TextChanged
        con.Open()
        sql = "SELECT * FROM QrySales WHERE StockID LIKE '%" & txbname.Text & "%' OR WHERE SaleID LIKE '%" & txbname.Text & "%' "            ' Sql checks to find a simular result in the database  
        SandSconnection(DGVSales, sql)
    End Sub

    Private Sub txbquantity_TextChanged(sender As Object, e As EventArgs) Handles txbquantity.TextChanged
        con.Open()
        sql = "SELECT * FROM QrySales WHERE SaleQuantity LIKE '%" & txbquantity.Text & "%'"            ' Sql checks to find a simular result in the database  
        SandSconnection(DGVSales, sql)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        OpenChildForm(New ListProductOrders)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        OpenChildForm(New ProductSales)
    End Sub

    Private Sub BtnSortCustomers_Click(sender As Object, e As EventArgs) Handles BtnSortCustomers.Click
        GrpSort.Show()
        cbproductchange.Show()
    End Sub

    Private Sub cbproductchange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbproductchange.SelectedIndexChanged

    End Sub

    Private Sub BtnSearchSalesLine_Click(sender As Object, e As EventArgs) Handles BtnSearchSalesLine.Click
        GrpSearch.Show()
        GrpSort.Hide()

    End Sub

    Private Sub DGVSales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSales.CellContentClick

    End Sub
End Class