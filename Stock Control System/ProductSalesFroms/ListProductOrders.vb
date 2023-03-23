Public Class ListProductOrders
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles LblPricePerItem.Click

    End Sub

    Private Sub ListProductOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbxOrder.ClearSelected()

        TbxCustomerID.Text = SaleCustomerID
        TbxStaffID.Text = SaleStaffID
    End Sub

    Private Sub CbxStockID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxStockID.SelectedIndexChanged

    End Sub
End Class