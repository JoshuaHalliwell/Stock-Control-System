Public Class SuppliersOrders
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnSortSupplierOrders.Click
        GrpSearch.Hide()
        GrpSort.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles BtnAddOrder.Click

    End Sub

    Private Sub SuppliersOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub radName_CheckedChanged(sender As Object, e As EventArgs) Handles RadSuppliersName.CheckedChanged

    End Sub

    Private Sub BtnSearchSupplyOrders_Click(sender As Object, e As EventArgs) Handles BtnSearchSupplyOrders.Click
        GrpSearch.Show()
        GrpSort.Hide()
    End Sub
End Class