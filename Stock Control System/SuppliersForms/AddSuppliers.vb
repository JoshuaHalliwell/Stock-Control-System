Public Class SuppliersData
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblSuppliersIDError.Text = ""    'Hides the on screen error messages by making the text to be empty so that they only appear when needed 

        LblSupplierNameError.Text = ""
        lblSuppliersEmailError.Text = ""
        LblAddressError.Text = ""



        RoundCornerButton(btnadd)     'Makes all button elements to have a rounded effect on them 
        RoundCornerButton(btncancel)
        RoundCornerButton(btnclear)
        RoundCornerButton(btndelete)
        RoundCornerButton(btnfirstcustomer)
        RoundCornerButton(btnlastcustomer)
        RoundCornerButton(btnnext)
        RoundCornerButton(btnprev)
        RoundCornerButton(btnupdate)
        RoundCornerButton(BtnBack)

        con.Open()
        sql = "SELECT * FROM TblSuppliers"
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, "TblSuppliers") 'Fill whatever is in the data adapter to the DataSet'
        con.Close() 'Close the connection with the database(leavering it open can cause errors such as lag)'
        MaxRows = ds.Tables("TblSuppliers").Rows.Count 'Gets how many rows there are currently in the DataSet'
        curRow = 1   ' Selctes the second row of data from the database 
        NavigateRecords()
    End Sub
    Private Sub NavigateRecords()
        TxbCustomerID.Text = ds.Tables("TblSuppliers").Rows(curRow).Item(0)            'goes throght the table in the database to pick out all the data in the set current row
        TxbFirstname.Text = ds.Tables("TblSuppliers").Rows(curRow).Item(1)
        TxbSurname.Text = ds.Tables("TblSuppliers").Rows(curRow).Item(2)
        TxbEmail.Text = ds.Tables("TblSuppliers").Rows(curRow).Item(3)

    End Sub

    Private Sub PresenceCheck()
        Try
            If TxbCustomerID.Text = ds.Tables("TblSuppliers").Rows(curRow).Item(0) Then          ' Checks to see if there is any data in the textboxes 
                LblSuppliersIDError.Text = "Suppliers field must be filled in with data"        ' if there is none then the realtive error text will
            ElseIf TxbFirstname.Text = ds.Tables("TblSuppliers").Rows(curRow).Item(1) Then        '  appear next to the relative textbox
                LblCustomerFirstName.Text = "Suppliers firstname field must be filled in with data"

            ElseIf TxbSurname.Text = ds.Tables("TblSuppliers").Rows(curRow).Item(2) Then
                LblSupplierNameError.Text = "Suppliers Surname field must be filled in with data"

            ElseIf TxbEmail.Text = ds.Tables("TblSuppliers").Rows(curRow).Item(3) Then
                lblSuppliersEmailError.Text = "Suppliers email field must be filled in with data"

            End If
        Catch ex As Exception
            Exit Sub
        End Try
        LblSuppliersIDError.Text = ""     ' reclears the textboxes in case of the error text stays.
        LblSupplierNameError.Text = ""
        LblAddressError.Text = ""
        lblSuppliersEmailError.Text = ""


    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GrpSort_Enter(sender As Object, e As EventArgs)

    End Sub
End Class
