Public Class SuppliersData
    Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable



    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblSuppliersIDError.Text = ""    'Hides the on screen error messages by making the text to be empty so that they only appear when needed 

        LblSupplierNameError.Text = ""
        lblSuppliersEmailError.Text = ""
        LblAddressError.Text = ""



        RoundCornerButton(btnaddsupplier)     'Makes all button elements to have a rounded effect on them 
        RoundCornerButton(btnclear)
        RoundCornerButton(btnfirstsupplier)
        RoundCornerButton(btnnextsupplier)
        RoundCornerButton(btnprevsupplier)
        RoundCornerButton(btnlastsupplier)
        RoundCornerButton(BtnBackMenu)
        RoundCornerButton(btnupdatesupplier)
        RoundCornerButton(btndeletesupplier)
        RoundCornerButton(btncancel)

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
        TxbSuppliersID.Text = ds.Tables("TblSuppliers").Rows(curRow).Item(0)            'goes throght the table in the database to pick out all the data in the set current row
        TxbSuppliersName.Text = ds.Tables("TblSuppliers").Rows(curRow).Item(1)
        TxbSuppliersEmail.Text = ds.Tables("TblSuppliers").Rows(curRow).Item(2)
        TxbSuppliersAddress.Text = ds.Tables("TblSuppliers").Rows(curRow).Item(3)

    End Sub

    Private Sub PresenceCheck()
        Try
            If TxbSuppliersID.Text = ds.Tables("TblSuppliers").Rows(curRow).Item(0) Then          ' Checks to see if there is any data in the textboxes 
                LblSuppliersIDError.Text = "Suppliers field must be filled in with data"        ' if there is none then the realtive error text will
            ElseIf TxbSuppliersName.Text = ds.Tables("TblSuppliers").Rows(curRow).Item(1) Then        '  appear next to the relative textbox
                LblCustomerFirstName.Text = "Suppliers firstname field must be filled in with data"

            ElseIf TxbSuppliersEmail.Text = ds.Tables("TblSuppliers").Rows(curRow).Item(2) Then
                LblSupplierNameError.Text = "Suppliers Surname field must be filled in with data"

            ElseIf TxbSuppliersAddress.Text = ds.Tables("TblSuppliers").Rows(curRow).Item(3) Then
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

    Private Sub btnfirstsupplier_Click(sender As Object, e As EventArgs) Handles btnfirstsupplier.Click

        curRow = 0              'Sets the viewing of the recoreds to the first record which is set at 2 
        NavigateRecords()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click

        Exit Sub
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        TxbSuppliersID.Clear()          ' clears off any data in the textboxes 
        TxbSuppliersEmail.Clear()
        TxbSuppliersName.Clear()
        TxbSuppliersAddress.Clear()

    End Sub

    Private Sub btnnextsupplier_Click(sender As Object, e As EventArgs) Handles btnnextsupplier.Click
        If curRow <> MaxRows - 1 Then 'if the curRow isn't equal to MaxRow - 1 then execute the below '
            curRow = curRow + 1 'Sets CurRow  to its own vaulue + 1' 
            NavigateRecords() 'calls database funcation'
        Else 'if the above doesn't apply then execute the below,
            MsgBox("Suppliers' data ") 'display a message box with the following message of there is no data byoned that point' 
        End If 'end if statement,
    End Sub

    Private Sub btnprevsupplier_Click(sender As Object, e As EventArgs) Handles btnprevsupplier.Click
        If curRow > 0 Then 'if the variable is more than 0 then execute the below 
            curRow = curRow - 1 'Sets value to a variable
            NavigateRecords() 'calls function
        ElseIf curRow = -1 Then 'if the variable is equal to -1, execute the below 
            MsgBox("No new Supplier data") 'display a message box with the following message 
        ElseIf curRow = 0 Then 'if the variable is equal to 0 then execute the below 
            MsgBox("First Suppliers data") 'display a message box with the following message 
        End If 'end if statement
    End Sub

    Private Sub btnlastsupplier_Click(sender As Object, e As EventArgs) Handles btnlastsupplier.Click
        curRow = MaxRows - 1 'sets a new value to the variable so that the system know the current row is just one away from the max row value which holds no data.
        NavigateRecords()
    End Sub

    Private Sub BtnBackMenu_Click(sender As Object, e As EventArgs) Handles BtnBackMenu.Click
        OpenChildForm(New Customers)
    End Sub

    Private Sub btnupdatesupplier_Click(sender As Object, e As EventArgs) Handles btnupdatesupplier.Click
        PresenceCheck()
        Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        'The system goes throught each row, and change/ upadate any data which doesn't equal the imput data' 
        ds.Tables("TblSuppliers").Rows(curRow).Item(0) = TxbSuppliersID.Text 'fields called items 
        ds.Tables("TblSuppliers").Rows(curRow).Item(1) = TxbSuppliersName.Text 'cells are just fields
        ds.Tables("TblSuppliers").Rows(curRow).Item(2) = TxbSuppliersEmail.Text
        ds.Tables("TblSuppliers").Rows(curRow).Item(3) = TxbSuppliersAddress.Text


        da.Update(ds, "TblSupplier") 'Updates the database with new set of student data
        MsgBox("Data Base has been Updated!")
    End Sub

    Private Sub btndeletesupplier_Click(sender As Object, e As EventArgs) Handles btndeletesupplier.Click
        PresenceCheck()
        MsgBox("Do you really want to Delete this Suppliers data?", MsgBoxStyle.YesNo, MessageBoxIcon.Warning) ' MessageBoxButtons creats buttons fro the user to click on'
        If DialogResult.No Then 'if the user clicks no, it will just end the process of deleting
            MsgBox("Delete cancel")
            Exit Sub
        ElseIf DialogResult.Yes Then
            'SQL code funcation, always needed'
            Try
                cb.QuotePrefix = "["
                cb.QuoteSuffix = "]"
                ds.Tables("TblSuppliers").Rows(curRow).Delete()
                MaxRows = MaxRows - 1 'Set the MaxRow as a new vaule as there is now les rows in the table'

                curRow = 0
                NavigateRecords()
                da.Update(ds, "TblSuppliers")
            Catch ex As Exception
                MsgBox("Delation was unsuccessful, make sure all data selected is correct and in the right format")
            End Try
            MsgBox("The Suppliers data has been delete successfully")
        End If
    End Sub

    Private Sub btnaddsupplier_Click(sender As Object, e As EventArgs) Handles btnaddsupplier.Click
        PresenceCheck()

        If curRow <> -1 Then 'If the variable doesn't equal to -1 the execute the below 
            Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable
            Dim dsNewRow As DataRow 'declares variable

            dsNewRow = ds.Tables("TblSuppliers").NewRow()

            dsNewRow.Item("SupplierID") = TxbSuppliersID.Text
            dsNewRow.Item("SuppliersName") = TxbSuppliersName.Text
            dsNewRow.Item("SuppliersEmail") = TxbSuppliersEmail.Text
            dsNewRow.Item("SuppliersAddress") = TxbSuppliersAddress.Text


            ds.Tables("TblSuppliers").Rows.Add(dsNewRow)

            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"

            Try
                da.Update(ds, "TblSuppliers") 'Updates the database with the new row
            Catch ex As Exception
                MsgBox(ex)
                Exit Sub
            End Try
            MsgBox("New Supplier has been added to the Database") 'display a message box with the following message 
        Else
            MsgBox("Data can not be added to the database, please ensure that all the information is correct")
        End If
    End Sub
End Class
