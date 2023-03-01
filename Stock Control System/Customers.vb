Public Class Customers
    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataBase_copyDataSet.TblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.StockDataBase_copyDataSet.TblCustomer)
        DGVCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
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
        RoundCornerButton(BtnNext)
        RoundCornerButton(BtnPrevious)
        RoundCornerButton(BtnSearchCustomer)
        RoundCornerButton(BtnSortCustomers)

        Llbchange.Hide()
        cbproductchange.Hide()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        'OpenChildForm(New AddAppliance)                                                         ' opends the form in the open child form layout and closes this main form
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        'OpenChildForm(New AddAppliance)                                                         ' opends the form in the open child form layout and closes this main form

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'OpenChildForm(New AddAppliance)                                                         ' opends the form in the open child form layout and closes this main form

    End Sub

    Private Sub txbID_TextChanged(sender As Object, e As EventArgs) Handles txbID.TextChanged
        con.Open()
        sql = "SELECT * FROM TblCustomer WHERE CustomerID LIKE '%" & txbID.Text & "%'"
        SandSconnection(DGVCustomers)
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


End Class