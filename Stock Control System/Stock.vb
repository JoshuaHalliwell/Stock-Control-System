Public Class Stock
    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataBase_copyDataSet1.TblStocks' table. You can move, or remove it, as needed.
        Me.TblStocksTableAdapter.Fill(Me.StockDataBase_copyDataSet1.TblStocks)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSortByStorageStock.Click

    End Sub
End Class