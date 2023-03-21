Imports iText.Kernel.Pdf.Colorspace.PdfShading

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
        OpenChildForm(SuppliersData)
    End Sub

    Private Sub SuppliersOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        sql = "SELECT * FROM TblSuppliers"
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, "TblSuppliers") 'Fill whatever is in the data adapter to the DataSet'
        DGVSuppliers.DataSource = ds
        DGVSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        con.Close() 'Close the connection with the database(leavering it open can cause errors such as lag)'

        GrpSearch.Hide()
        GrpSort.Hide()

        RoundCornerButton(BtnAddOrder)
        RoundCornerButton(BtnDeleteOrder)
        RoundCornerButton(BtnUpdateOrders)
        RoundCornerButton(BtnSearchSupplyOrders)
        RoundCornerButton(BtnSortSupplierOrders)

        If RadSuppliersId.Checked = False Then
            txbID.Enabled = False
        End If

        If RadSuppliersName.Checked = False Then
            txbname.Enabled = False
        End If


        If RadSuppliersEmail.Checked = False Then
            txbEmail.Enabled = False
        End If

        Tablename = "TblSuppliers"
    End Sub

    Private Sub radName_CheckedChanged(sender As Object, e As EventArgs) Handles RadSuppliersName.CheckedChanged
        If RadSuppliersName.Checked = True Then                                                                                                                                                                                                                                                                                                                                                        ' Selection to determine whether to disable field
            txbname.Enabled = True
        Else txbname.Enabled = False : txbname.Text = ""                                                                                                                                                                                                                                                                                                                                        ' ^
        End If
    End Sub

    Private Sub BtnSearchSupplyOrders_Click(sender As Object, e As EventArgs) Handles BtnSearchSupplyOrders.Click
        GrpSearch.Show()
        GrpSort.Hide()
    End Sub

    Private Sub RadSuppliersId_CheckedChanged(sender As Object, e As EventArgs) Handles RadSuppliersId.CheckedChanged
        If RadSuppliersId.Checked = True Then                                                                                                                                                                                                                                                                                                                                                        ' Selection to determine whether to disable field
            txbID.Enabled = True
        Else txbID.Enabled = False : txbID.Text = ""                                                                                                                                                                                                                                                                                                                                        ' ^
        End If
    End Sub

    Private Sub RadSuppliersEmail_CheckedChanged(sender As Object, e As EventArgs) Handles RadSuppliersEmail.CheckedChanged
        If RadSuppliersEmail.Checked = True Then                                                                                                                                                                                                                                                                                                                                                        ' Selection to determine whether to disable field
            txbEmail.Enabled = True
        Else txbEmail.Enabled = False : txbEmail.Text = ""                                                                                                                                                                                                                                                                                                                                        ' ^
        End If
    End Sub

    Private Sub txbID_TextChanged(sender As Object, e As EventArgs) Handles txbID.TextChanged
        con.Open()
        sql = "SELECT * FROM TblSuppliers WHERE SupplierID LIKE '%" & txbID.Text & "%'"             ' Sql checks to find a simular result in the database  
        SandSconnection(DGVSuppliers, sql)                                                               'Sends the data grid to the connection opration 
    End Sub

    Private Sub txbname_TextChanged(sender As Object, e As EventArgs) Handles txbname.TextChanged
        con.Open()
        sql = "SELECT * FROM TblSuppliers WHERE SuppliersName LIKE '%" & txbname.Text & "%'"             ' Sql checks to find a simular result in the database  
        SandSconnection(DGVSuppliers, sql)                                                               'Sends the data grid to the connection opration 
    End Sub

    Private Sub txbEmail_TextChanged(sender As Object, e As EventArgs) Handles txbEmail.TextChanged
        con.Open()
        sql = "SELECT * FROM TblSuppliers WHERE SuppliersEmail LIKE '%" & txbEmail.Text & "%'"             ' Sql checks to find a simular result in the database  
        SandSconnection(DGVSuppliers, sql)                                                               'Sends the data grid to the connection opration 
    End Sub

    Private Sub cbSupplierActivity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSupplierActivity.SelectedIndexChanged
        con.Open()
        If cbSupplierActivity.SelectedItem = "Active" Then
            sql = "SELECT * FROM TblSuppliers WHERE SupplierActivity = -1"
            SandSconnection(DGVSuppliers, sql)
        ElseIf cbSupplierActivity.SelectedItem = "Non Active" Then
            sql = "SELECT * FROM TblSuppliers WHERE SupplierActivity = 0"
            SandSconnection(DGVSuppliers, sql)
        End If
    End Sub

    Private Sub BtnDeleteOrder_Click(sender As Object, e As EventArgs) Handles BtnDeleteOrder.Click
        OpenChildForm(SuppliersData)

    End Sub

    Private Sub BtnUpdateOrders_Click(sender As Object, e As EventArgs) Handles BtnUpdateOrders.Click
        OpenChildForm(SuppliersData)
    End Sub
End Class