Public Class Stock
    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataBaseStockViewing.TblStocks' table. You can move, or remove it, as needed.
        Me.TblStocksTableAdapter1.Fill(Me.StockDataBaseStockViewing.TblStocks)
        DGVCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenChildForm(New StockAdd)                                                         ' opends the form in the open child form layout and closes this main form

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenChildForm(New StockAdd)                                                         ' opends the form in the open child form layout and closes this main form

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenChildForm(New StockAdd)                                                         ' opends the form in the open child form layout and closes this main form
    End Sub
End Class