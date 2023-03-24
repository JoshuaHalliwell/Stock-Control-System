Imports System.Diagnostics.Eventing.Reader

Public Class Stock
    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        sql = "SELECT * FROM TblStocks"
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, "TblStocks") 'Fill whatever is in the data adapter to the DataSet'
        DGVStock.DataSource = ds
        DGVStock.DataMember = "TblStocks" 'Specify the table to be displayed in the DataGridView
        DGVStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        con.Close() 'Close the connection with the database(leavering it open can cause errors such as lag)'

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
        RoundCornerButton(BtnSortByCatgory)
        Llbchange.Hide()
        CbStockCategory.Hide()

        Tablename = "TblStocks"
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

    Private Sub txbID_TextChanged(sender As Object, e As EventArgs) Handles txbID.TextChanged
        sql = "SELECT * FROM TblStocks WHERE (((TblStocks.StockID)LIKE'%" & txbID.Text & "%'))"
        SortAndSearchConnection()
    End Sub

    Private Sub BtnSortByCatgory_Click(sender As Object, e As EventArgs) Handles BtnSortByCatgory.Click
        GrpSort.Show()
        GrpSearch.Hide()

    End Sub

    Private Sub BtnSearchStock_Click(sender As Object, e As EventArgs) Handles BtnSearchStock.Click
        GrpSort.Hide()
        GrpSearch.Show()
    End Sub

    Private Sub cbproductchange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbStockCategory.SelectedIndexChanged
        con.Open()
        If CbStockCategory.SelectedItem = "Sweets" Then
            sql = "SELECT * FROM TblStocks WHERE CategoryType = '" & CbStockCategory.SelectedItem & "'"
            SortAndSearchConnection()
        ElseIf CbStockCategory.SelectedItem = "Crisps" Then
            sql = "SELECT * FROM TblStocks WHERE CategoryType = '" & CbStockCategory.SelectedItem & "'"
            SortAndSearchConnection()
        ElseIf CbStockCategory.SelectedItem = "Chocolate" Then
            sql = "SELECT * FROM TblStocks WHERE CategoryType = '" & CbStockCategory.SelectedItem & "'"
            SortAndSearchConnection()
        ElseIf CbStockCategory.SelectedItem = "Drink" Then
            sql = "SELECT * FROM TblStocks WHERE CategoryType = '" & CbStockCategory.SelectedItem & "'"
            SortAndSearchConnection()
        ElseIf CbStockCategory.SelectedItem = "Biscuit" Then
            sql = "SELECT * FROM TblStocks WHERE CategoryType = '" & CbStockCategory.SelectedItem & "'"
            SortAndSearchConnection()
        End If
    End Sub

    Private Sub SortAndSearchConnection()

        Dim Results As New DataTable                                                                                                                                                                                                                                                                                                                                                        ' Declare data table
        ' Declare and populate varaible
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(Results) 'Fill whatever is in the data adapter to the DataSet'
        DGVStock.DataSource = Results                                                                                                                                                                                                                                                                                                                                                      ' Populate data grid using data table
        DGVStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        con.Close() 'Sends the data grid to the connection opration 

    End Sub

    Private Sub radID_CheckedChanged(sender As Object, e As EventArgs) Handles radID.CheckedChanged
        If radID.Checked = True Then                                                                                                                                                                                                                                                                                                                                                        ' Selection to determine whether to disable field
            txbID.Enabled = True
        Else txbID.Enabled = False : txbID.Text = ""
        End If
    End Sub

    Private Sub radName_CheckedChanged(sender As Object, e As EventArgs) Handles radName.CheckedChanged
        If radName.Checked = True Then                                                                                                                                                                                                                                                                                                                                                        ' Selection to determine whether to disable field
            txbname.Enabled = True
        Else txbname.Enabled = False : txbname.Text = ""
        End If
    End Sub

    Private Sub txbname_TextChanged(sender As Object, e As EventArgs) Handles txbname.TextChanged
        sql = "SELECT * FROM TblStocks WHERE ProductName LIKE '%" & txbname.Text & "%'"
        SortAndSearchConnection()
    End Sub

    Private Sub BtnSortByDisplayStock_Click(sender As Object, e As EventArgs) Handles BtnSortByDisplayStock.Click
        GrpSort.Show()
        GrpSearch.Hide()
        sql = "SELECT ProductName QuantityOfDisplayStock FROM TblStocks"
        SortAndSearchConnection()
    End Sub

    Private Sub BtnSortByStorageStock_Click(sender As Object, e As EventArgs) Handles BtnSortByStorageStock.Click
        GrpSort.Show()
        GrpSearch.Hide()
        sql = "SELECT ProductName QuantityOfStorageStock FROM TblStocks"
        SortAndSearchConnection()

    End Sub
End Class