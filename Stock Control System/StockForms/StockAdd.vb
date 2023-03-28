Imports Org.BouncyCastle.Crypto.Engines

Public Class StockAdd
    Private Sub StockAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hides the on screen error messages by making the text to be empty so that they only appear when needed
        ErrorClear()

        RoundCornerButton(Btnbacktomenu) 'Makes all button elements to have a rounded effect on them

        RoundCornerButton(BtnAddToStock)

        RoundCornerButton(Btnupdatestock)

        RoundCornerButton(Btncancel)

        RoundCornerButton(Btnclear)

        RoundCornerButton(Btnfirststockdetails)

        RoundCornerButton(Btnnextstock)

        RoundCornerButton(Btnprevioustock)

        RoundCornerButton(Btnlaststock)

        RoundCornerButton(BtnAddToStock)

        RoundCornerButton(Btndeletestockpage)

        con.Open()

        sql = "SELECT * FROM TblStocks"

        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)'

        da.Fill(ds, "TblStocks") 'Fill whatever is in the data adapter to the DataSet'

        con.Close() 'Close the connection with the database(leavering it open can cause errors such as lag)'

        MaxRows = ds.Tables("TblStocks").Rows.Count 'Gets how many rows there are currently in the DataSet'

        curRow = 1 ' Selctes the second row of data from the database

        NavigateRecords()

    End Sub
    Sub NavigateRecords()
        Txtpriceperitem.Text = ds.Tables("TblStocks").Rows(curRow).Item(0)
        Txtproductname.Text = ds.Tables("TblStocks").Rows(curRow).Item(1)
        Txtquantityofstorage.Text = ds.Tables("TblStocks").Rows(curRow).Item(2)
        Txtquantitystock.Text = ds.Tables("TblStocks").Rows(curRow).Item(3)
        Txtstockid.Text = ds.Tables("TblStocks").Rows(curRow).Item(4)
        Txttotalstock.Text = ds.Tables("TblStocks").Rows(curRow).Item(5)
    End Sub
    Private Sub ErrorClear()

        Lblproductnameerror.Text = ""

        Lblstoragestockerror.Text = ""

        Lbltotalstockerror.Text = ""

        Lblpriceperitemerror.Text = ""

        LblstockError.Text = ""

        Lbldisplaystockerror.Text = ""
    End Sub
    Private Sub BtnBackToStockPage_Click(sender As Object, e As EventArgs) Handles BtnAddToStock.Click
        If Txtstockid.Text = "" Then
            LblstockError.Text = "A stock id must be present and be in the format of SOK111"

        End If
        If curRow <> -1 Then 'If the variable doesn't equal to -1 the execute the below

            Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable

            Dim dsNewRow As DataRow 'declares variable

            dsNewRow = ds.Tables("TblStocks").NewRow()

            dsNewRow.Item("StockID") = Txtstockid.Text

            dsNewRow.Item("ProductName") = Txtproductname.Text

            dsNewRow.Item("QuantityofDisplayStock") = Txtquantitystock.Text

            dsNewRow.Item("QuantityofStorageStock") = Txtquantityofstorage.Text

            dsNewRow.Item("PricePerItem") = Txtpriceperitem.Text

            dsNewRow.Item("TotalStock") = Txttotalstock.Text

            ds.Tables("TblStocks").Rows.Add(dsNewRow)

            cb.QuotePrefix = "["

            cb.QuoteSuffix = "]"

            Try

                da.Update(ds, "TblStocks") 'Updates the database with the new row

            Catch ex As Exception

                MsgBox("This set of data is already in the database therefor can not be added")

                Exit Sub

            End Try

            MsgBox("New customer has been added to the Database") 'display a message box with the following message

        Else

            MsgBox("Data can not be added to the database, please ensure that all the information is correct")

        End If
    End Sub

    Private Sub Btndeletestockpage_Click(sender As Object, e As EventArgs) Handles Btndeletestockpage.Click
        MsgBox("Do you really want to Delete this stock's data?", MsgBoxStyle.YesNo, MessageBoxIcon.Warning) ' MessageBoxButtons creats buttons fro the user to click on'

                If DialogResult.No Then 'if the user clicks no, it will just end the process of deleting

            MsgBox("Delete cancel")

            Exit Sub

        ElseIf DialogResult.Yes Then

            'SQL code funcation, always needed'

            Try

                cb.QuotePrefix = "["

                cb.QuoteSuffix = "]"

                ds.Tables("TblStocks").Rows(curRow).Delete()

                MaxRows = MaxRows - 1 'Set the MaxRow as a new vaule as there is now les rows in the table'

                curRow = 0

                NavigateRecords()

                da.Update(ds, "TblStocks")

            Catch ex As Exception

                MsgBox("Delation was unsuccessful, make sure all data selected is correct and in the right format")

            End Try

            MsgBox("The stock data has been deleted successfully")

        End If

    End Sub

    Private Sub Btnbacktomenu_Click(sender As Object, e As EventArgs) Handles Btnbacktomenu.Click

    End Sub

    Private Sub LblstockError_Click(sender As Object, e As EventArgs) Handles LblstockError.Click

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles Btnnextstock.Click
        If curRow <> MaxRows - 1 Then 'if the curRow isn't equal to MaxRow - 1 then execute the below '
            curRow = curRow + 1 'Sets CurRow  to its own vaulue + 1' 
            NavigateRecords() 'calls database funcation'
        Else 'if the above doesn't apply then execute the below,
            MsgBox("No More Customer's data ") 'display a message box with the following message of there is no data byoned that point' 
        End If 'end if statement,
    End Sub
    Private Sub btnprev_Click(sender As Object, e As EventArgs) Handles Btnprevioustock.Click
        If curRow > 0 Then 'if the variable is more than 0 then execute the below 
            curRow = curRow - 1 'Sets value to a variable
            NavigateRecords() 'calls function
        ElseIf curRow = -1 Then 'if the variable is equal to -1, execute the below 
            MsgBox("No new Customer data") 'display a message box with the following message 
        ElseIf curRow = 0 Then 'if the variable is equal to 0 then execute the below 
            MsgBox("First Customer data") 'display a message box with the following message 
        End If 'end if statement
    End Sub



    Private Sub btnlastcustomer_Click(sender As Object, e As EventArgs) Handles Btnlaststock.Click
        curRow = MaxRows - 1 'sets a new value to the variable so that the system know the current row is just one away from the max row value which holds no data.
        NavigateRecords()
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        Txtpriceperitem.Text = ""
        Txtproductname.Text = ""
        Txtquantityofstorage.Text = ""
        Txtquantitystock.Text = ""
        Txtstockid.Text = ""
        Txttotalstock.Text = ""
    End Sub
End Class