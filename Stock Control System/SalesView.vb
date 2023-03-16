Public Class SalesView
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

    End Sub

    Private Sub SalesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblCustomerTableAdapter.Fill(Me.StockDataBase_copyDataSet.TblSalesLine)
        DGVSalesLine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        GrpSearch.Hide()
        GrpSort.Hide()
        If radID.Checked = False Then
            txbID.Enabled = False
        End If

        If radName.Checked = False Then
            txbname.Enabled = False
        End If

        If RadSaleID.Checked = False Then
            txbEmail.Enabled = False
        End If
        RoundCornerButton(BtnAdd)
        RoundCornerButton(BtnDelete)                                   'calls the roundCornerButton module
        RoundCornerButton(BtnEdit)
        RoundCornerButton(BtnSearchProductSales)
        RoundCornerButton(BtnSortProductSales)

        Llbchange.Hide()
        cbproductchange.Hide()

        Tablename = "TblSalesLine"
    End Sub

    Private Sub txbID_TextChanged(sender As Object, e As EventArgs) Handles txbID.TextChanged
        On.Open()
        sql = "SELECT * FROM TblSalesLine WHERE SalesID LIKE '%" & txbID.Text & "%'"             ' Sql checks to find a simular result in the database  
        SandSconnection(DGVSalesLine)
    End Sub

    Private Sub BtnSearchSalesLine_Click(sender As Object, e As EventArgs) Handles BtnSearchSalesLine.Click
        GrpSearch.Show()
        GrpSort.Hide()
    End Sub

    Private Sub BtnSortSalesLine_Click(sender As Object, e As EventArgs) Handles BtnSortSalesLine.Click
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

    Private Sub RadQuantity_CheckedChanged(sender As Object, e As EventArgs) Handles RadQuantity.CheckedChanged
        If RadQuantity.Checked = True Then                                                                                                                                                                                                                                                                                                                                                        ' Selection to determine whether to disable field
            txbQuantity.Enabled = True
        Else txbQuantity.Enabled = False : txbEmail.Text = ""                                                                                                                                                                                                                                                                                                                                        ' ^
        End If
    End Sub

    Private Sub txbname_TextChanged(sender As Object, e As EventArgs) Handles txbname.TextChanged
        con.Open()
        sql = "SELECT * FROM TblSalesLine WHERE StockID LIKE '%" & txbname.Text & "%' OR WHERE SaleID LIKE '%" & txbname.Text & "%' "            ' Sql checks to find a simular result in the database  
        SandSconnection(DGVSalesLine)
    End Sub
End Class