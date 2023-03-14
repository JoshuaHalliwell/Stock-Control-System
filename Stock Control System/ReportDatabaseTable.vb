Public Class ReportDatabaseTable
    Dim Tablename As String
    Private Sub ReportDatabaseTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundCornerButton(BtnBackToMenu)
        RoundCornerButton(BtnBackupTable)
        RoundCornerButton(BtnClearTable)
        RoundCornerButton(BtnSaveToPDF)
        RoundCornerButton(BtnShareByEmail)
    End Sub

    Private Sub ClbGraphData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClbGraphData.SelectedIndexChanged
        If ClbGraphData.SelectedItem = "Staff Table" Then
            sql = "SELECT * FROM TblStaff"
            Tablename = "TblStaff"
        ElseIf ClbGraphData.SelectedItem = "Customer Table" Then
            sql = "SELECT * FROM TblCustomer "
            Tablename = "TblCustomer"
        ElseIf ClbGraphData.SelectedItem = "Suppliers Orders Table" Then
            sql = "SELECT * FROM TblOrders "
            Tablename = "TblOrders"
        ElseIf ClbGraphData.SelectedItem = "Sales Table" Then
            sql = "SELECT * FROM TblSales AND TblSalesLine"
            Tablename = "TblSales"
        ElseIf ClbGraphData.SelectedItem = "Stocks Table" Then
            sql = "SELECT * FROM TblStocks "
            Tablename = "TblStocks"
        ElseIf ClbGraphData.SelectedItem = "Suppliers Table" Then
            sql = "SELECT * FROM TblSuppliers "
            Tablename = "TblSuppliers"
        End If
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, Tablename) 'Fill whatever is in the data adapter to the DataSet'
        DGVDataTable.DataSource = ds
    End Sub
End Class