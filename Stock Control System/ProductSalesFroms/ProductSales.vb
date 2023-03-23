Public Class ProductSales
    Dim cb As New OleDb.OleDbCommandBuilder(da)

    Private Sub ProductSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSaleDayError.Text = ""    'Hides the on screen error messages by making the text to be empty so that they only appear when needed 
        LblSaleIDError.Text = ""
        LblStaffError.Text = ""
        LblSaleTimeError.Text = ""
        LblCustomerIDError.Text = ""

        RoundCornerButton(btnadd)     'Makes all button elements to have a rounded effect on them 
        RoundCornerButton(btncancel)
        RoundCornerButton(btnclear)
        RoundCornerButton(btndelete)
        RoundCornerButton(btnfirstStock)
        RoundCornerButton(btnlastStock)
        RoundCornerButton(btnnext)
        RoundCornerButton(btnprev)
        RoundCornerButton(btnupdate)
        RoundCornerButton(BtnBack)

        con.Open()
        sql = "SELECT * FROM QrySales"
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, "QrySales") 'Fill whatever is in the data adapter to the DataSet'
        con.Close() 'Close the connection with the database(leavering it open can cause errors such as lag)'
        MaxRows = ds.Tables("QrySales").Rows.Count 'Gets how many rows there are currently in the DataSet'
        curRow = 1   ' Selctes the second row of data from the database 
        NavigateRecords()
    End Sub

    Private Sub NavigateRecords()
        TxbSaleID.Text = ds.Tables("QrySales").Rows(curRow).Item(0)            'goes throght the table in the database to pick out all the data in the set current row
        TxbSaleTime.Text = ds.Tables("QrySales").Rows(curRow).Item(1)
        TxbSaleDay.Text = ds.Tables("QrySales").Rows(curRow).Item(2)
        TxbStaffID.Text = ds.Tables("QrySales").Rows(curRow).Item(3)
        TxbCustomerID.Text = ds.Tables("QrySales").Rows(curRow).Item(4)
    End Sub

    Private Sub PresenceCheck()
        Try
            If TxbSaleID.Text = ds.Tables("QrySales").Rows(curRow).Item(0) Then          ' Checks to see if there is any data in the textboxes 
                LblSaleIDError.Text = "Sale ID field must be filled in with data"        ' if there is none then the realtive error text will
            ElseIf TxbSaleTime.Text = ds.Tables("QrySales").Rows(curRow).Item(1) Then        '  appear next to the relative textbox
                LblSaleTime.Text = "Sale Time field must be filled in with data"

            ElseIf TxbSaleDay.Text = ds.Tables("QrySales").Rows(curRow).Item(2) Then
                lblSaleDayError.Text = "Sale Day field must be filled in with data"

            ElseIf TxbStaffID.Text = ds.Tables("QrySales").Rows(curRow).Item(3) Then
                LblStaffError.Text = "Staff ID field must be filled in with data"

            ElseIf TxbCustomerID.Text = ds.Tables("QrySales").Rows(curRow).Item(4) Then
                LblCustomerID.Text = "CustomerID field must be filled in with data"
                'A try and catch statement is used to picked up the error  
                'so that the application can break away from the sub processe
            End If
        Catch ex As Exception
            Exit Sub
        End Try
        LblSaleIDError.Text = ""     ' reclears the textboxes in case of the error text stays.
        LblSaleTimeError.Text = ""
        lblSaleDayError.Text = ""
        LblStaffError.Text = ""
        LblCustomerIDError.Text = ""
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Exit Sub
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        TxbSaleID.Clear()          ' cllears off any data in the textboxes 
        TxbSaleTime.Clear()
        TxbSaleDay.Clear()
        TxbStaffID.Clear()
        TxbCustomerID.Clear()
    End Sub

    Private Sub btnfirstStock_Click(sender As Object, e As EventArgs) Handles btnfirstStock.Click
        curRow = 0              'Sets the viewing of the recoreds to the first record which is set at 2 
        NavigateRecords()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        If curRow <> MaxRows - 1 Then 'if the curRow isn't equal to MaxRow - 1 then execute the below '
            curRow = curRow + 1 'Sets CurRow  to its own vaulue + 1' 
            NavigateRecords() 'calls database funcation'
        Else 'if the above doesn't apply then execute the below,
            MsgBox("No More Sales data ") 'display a message box with the following message of there is no data byoned that point' 
        End If 'end if statement,
    End Sub

    Private Sub btnprev_Click(sender As Object, e As EventArgs) Handles btnprev.Click
        If curRow > 0 Then 'if the variable is more than 0 then execute the below 
            curRow = curRow - 1 'Sets value to a variable
            NavigateRecords() 'calls function
        ElseIf curRow = -1 Then 'if the variable is equal to -1, execute the below 
            MsgBox("No new Sales data") 'display a message box with the following message 
        ElseIf curRow = 0 Then 'if the variable is equal to 0 then execute the below 
            MsgBox("First Sales data") 'display a message box with the following message 
        End If 'end if statement
    End Sub

    Private Sub btnlastStock_Click(sender As Object, e As EventArgs) Handles btnlastStock.Click
        curRow = MaxRows - 1 'sets a new value to the variable so that the system know the current row is just one away from the max row value which holds no data.
        NavigateRecords()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        PresenceCheck()
        Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        'The system goes throught each row, and change/ upadate any data which doesn't equal the imput data' 
        ds.Tables("QrySales").Rows(curRow).Item(0) = TxbSaleID.Text 'fields called items 
        ds.Tables("QrySales").Rows(curRow).Item(1) = TxbSaleTime.Text 'ceells are just fields
        ds.Tables("QrySales").Rows(curRow).Item(2) = TxbSaleDay.Text
        ds.Tables("QrySales").Rows(curRow).Item(3) = TxbStaffID.Text
        ds.Tables("QrySales").Rows(curRow).Item(4) = TxbCustomerID.Text

        da.Update(ds, "QrySales") 'Updates the database with new set of student data
        MsgBox("Data Base has been Updated!")
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        PresenceCheck()
        MsgBox("Do you really want to Delete this Sales data?", MsgBoxStyle.YesNo, MessageBoxIcon.Warning) ' MessageBoxButtons creats buttons fro the user to click on'
        If DialogResult.No Then 'if the user clicks no, it will just end the process of deleting
            MsgBox("Delete cancel")
            Exit Sub
        ElseIf DialogResult.Yes Then
            'SQL code funcation, always needed'
            Try
                cb.QuotePrefix = "["
                cb.QuoteSuffix = "]"
                ds.Tables("QrySales").Rows(curRow).Delete()
                MaxRows = MaxRows - 1 'Set the MaxRow as a new vaule as there is now les rows in the table'

                curRow = 0
                NavigateRecords()
                da.Update(ds, "QrySales")
            Catch ex As Exception
                MsgBox("Delation was unsuccessful, make sure all data selected is correct and in the right format")
            End Try
            MsgBox("The Sales data has been delete successfully")
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        PresenceCheck()

        If curRow <> -1 Then 'If the variable doesn't equal to -1 the execute the below 
            Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable
            Dim dsNewRow As DataRow 'declares variable

            dsNewRow = ds.Tables("QrySales").NewRow()

            dsNewRow.Item("SaleID") = TxbSaleID.Text
            dsNewRow.Item("SaleTime") = TxbSaleTime.Text
            dsNewRow.Item("SaleDay") = TxbSaleDay.Text
            dsNewRow.Item("StaffID") = TxbStaffID.Text
            dsNewRow.Item("CustomerID") = TxbCustomerID.Text

            ds.Tables("QrySales").Rows.Add(dsNewRow)

            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"

            Try
                da.Update(ds, "QrySales") 'Updates the database with the new row
            Catch ex As Exception
                MsgBox("This set of data is already in the database therefor can not be added")
                Exit Sub
            End Try
            MsgBox("New Sale has been added to the Database") 'display a message box with the following message 
        Else
            MsgBox("Data can not be added to the database, please ensure that all the information is correct")
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        OpenChildForm(New Customers)

    End Sub
End Class