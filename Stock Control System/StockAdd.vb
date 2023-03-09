Public Class StockAdd
    Private Sub StockAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblStockID.Text = "" 'Hides the on screen error messages by making the text to be empty so that they only appear when needed

        Lblproductnameerror.Text = ""

        Lblstoragestockerror.Text = ""

        Lbltotalstockerror.Text = ""

        Lblpriceperitemerror.Text = ""

        RoundCornerButton(Btnbacktomenu) 'Makes all button elements to have a rounded effect on them

        RoundCornerButton(BtnBackToStockPage)

        RoundCornerButton(Btnupdatestock)

        RoundCornerButton(Btncancel)

        RoundCornerButton(Btnclear)

        RoundCornerButton(Btnfirststockdetails)

        RoundCornerButton(Btnnextstock)

        RoundCornerButton(Btnprevioustock)

        RoundCornerButton(Btnlaststock)

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

    Private Sub BtnBackToStockPage_Click(sender As Object, e As EventArgs) Handles BtnBackToStockPage.Click
        If curRow <> -1 Then 'If the variable doesn't equal to -1 the execute the below

            Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable

            Dim dsNewRow As DataRow 'declares variable

            dsNewRow = ds.Tables("TblCustomer").NewRow()

            dsNewRow.Item("CustomerID") = Txtstockid.Text

            dsNewRow.Item("CustomerFirstname") = Txtquantitystock.Text

            dsNewRow.Item("CustomerSurname") = Txtquantitystock.Text

            dsNewRow.Item("CustomerEmail") = Txtquantityofstorage.Text

            dsNewRow.Item("CustomerPhoneNumber") = Txtpriceperitem.Text

            dsNewRow.Item("CustomerPostcode") = Txtproductname.Text

            ds.Tables("TblCustomer").Rows.Add(dsNewRow)

            cb.QuotePrefix = "["

            cb.QuoteSuffix = "]"

            Try

                da.Update(ds, "TblCustomer") 'Updates the database with the new row

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

            MsgBox("The customer data has been delete successfully")

        End If

    End Sub

    Private Sub Btnbacktomenu_Click(sender As Object, e As EventArgs) Handles Btnbacktomenu.Click

    End Sub
End Class