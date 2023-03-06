Imports System.Security.Cryptography.X509Certificates

Public Class CustomerData
    Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable

    Private Sub CustomerData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSurnameError.Text = ""    'Hides the on screen error messages by making the text to be empty so that they only appear when needed 
        LblCustomerIDError.Text = ""
        LblEmailError.Text = ""
        LblFirstnameError.Text = ""
        LblMobilenumberError.Text = ""
        LblPostcodeError.Text = ""

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
        sql = "SELECT * FROM TblCustomer"
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, "TblCustomer") 'Fill whatever is in the data adapter to the DataSet'
        con.Close() 'Close the connection with the database(leavering it open can cause errors such as lag)'
        MaxRows = ds.Tables("TblCustomer").Rows.Count 'Gets how many rows there are currently in the DataSet'
        curRow = 1   ' Selctes the second row of data from the database 
        NavigateRecords()
    End Sub
    Private Sub NavigateRecords()
        TxbCustomerID.Text = ds.Tables("TblCustomer").Rows(curRow).Item(0)            'goes throght the table in the database to pick out all the data in the set current row
        TxbFirstname.Text = ds.Tables("TblCustomer").Rows(curRow).Item(1)
        TxbSurname.Text = ds.Tables("TblCustomer").Rows(curRow).Item(2)
        TxbEmail.Text = ds.Tables("TblCustomer").Rows(curRow).Item(3)
        TxbMobileNumber.Text = ds.Tables("TblCustomer").Rows(curRow).Item(4)
        TxbPostcode.Text = ds.Tables("TblCustomer").Rows(curRow).Item(5)
    End Sub
    Private Sub PresenceCheck()
        Try
            If TxbCustomerID.Text = ds.Tables("TblCustomer").Rows(curRow).Item(0) Then          ' Checks to see if there is any data in the textboxes 
                LblCustomerIDError.Text = "Customer ID field must be filled in with data"        ' if there is none then the realtive error text will
            ElseIf TxbFirstname.Text = ds.Tables("TblCustomer").Rows(curRow).Item(1) Then        '  appear next to the relative textbox
                LblCustomerFirstName.Text = "Customer firstname field must be filled in with data"

            ElseIf TxbSurname.Text = ds.Tables("TblCustomer").Rows(curRow).Item(2) Then
                lblSurnameError.Text = "Customer Surname field must be filled in with data"

            ElseIf TxbEmail.Text = ds.Tables("TblCustomer").Rows(curRow).Item(3) Then
                LblEmailError.Text = "Customer email field must be filled in with data"

            ElseIf TxbMobileNumber.Text = ds.Tables("TblCustomer").Rows(curRow).Item(4) Then
                Lblphonenumber.Text = "Customer phone number field must be filled in with data"
                'A try and catch statement is used to picked up the error  
                'so that the application can break away from the sub processe
            ElseIf TxbPostcode.Text = ds.Tables("TblCustomer").Rows(curRow).Item(5) Then
                LblPostcodeError.Text = "Customer postcode field must be filled in with data"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
        LblCustomerIDError.Text = ""     ' reclears the textboxes in case of the error text stays.
        LblFirstnameError.Text = ""
        lblSurnameError.Text = ""
        LblEmailError.Text = ""
        LblMobilenumberError.Text = ""
        LblPostcodeError.Text = ""
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        TxbCustomerID.Clear()          ' cllears off any data in the textboxes 
        TxbEmail.Clear()
        TxbFirstname.Clear()
        TxbMobileNumber.Clear()
        TxbPostcode.Clear()
        TxbSurname.Clear()
    End Sub

    Private Sub btnfirstcustomer_Click(sender As Object, e As EventArgs) Handles btnfirstcustomer.Click
        curRow = 0              'Sets the viewing of the recoreds to the first record which is set at 2 
        NavigateRecords()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        If curRow <> MaxRows - 1 Then 'if the curRow isn't equal to MaxRow - 1 then execute the below '
            curRow = curRow + 1 'Sets CurRow  to its own vaulue + 1' 
            NavigateRecords() 'calls database funcation'
        Else 'if the above doesn't apply then execute the below,
            MsgBox("No More Customer's data ") 'display a message box with the following message of there is no data byoned that point' 
        End If 'end if statement,
    End Sub

    Private Sub btnprev_Click(sender As Object, e As EventArgs) Handles btnprev.Click
        If curRow > 0 Then 'if the variable is more than 0 then execute the below 
            curRow = curRow - 1 'Sets value to a variable
            NavigateRecords() 'calls function
        ElseIf curRow = -1 Then 'if the variable is equal to -1, execute the below 
            MsgBox("No new Customer data") 'display a message box with the following message 
        ElseIf curRow = 0 Then 'if the variable is equal to 0 then execute the below 
            MsgBox("First Customer data") 'display a message box with the following message 
        End If 'end if statement
    End Sub

    Private Sub btnlastcustomer_Click(sender As Object, e As EventArgs) Handles btnlastcustomer.Click
        curRow = MaxRows - 1 'sets a new value to the variable so that the system know the current row is just one away from the max row value which holds no data.
        NavigateRecords()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        PresenceCheck()

        If curRow <> -1 Then 'If the variable doesn't equal to -1 the execute the below 
            Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable
            Dim dsNewRow As DataRow 'declares variable

            dsNewRow = ds.Tables("TblCustomer").NewRow()

            dsNewRow.Item("CustomerID") = TxbCustomerID.Text
            dsNewRow.Item("CustomerFirstname") = TxbFirstname.Text
            dsNewRow.Item("CustomerSurname") = TxbSurname.Text
            dsNewRow.Item("CustomerEmail") = TxbEmail.Text
            dsNewRow.Item("CustomerPhoneNumber") = TxbMobileNumber.Text
            dsNewRow.Item("CustomerPostcode") = TxbPostcode.Text

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

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        PresenceCheck()
        MsgBox("Do you really want to Delete this sutdent's data?", MsgBoxStyle.YesNo, MessageBoxIcon.Warning) ' MessageBoxButtons creats buttons fro the user to click on'
        If DialogResult.No Then 'if the user clicks no, it will just end the process of deleting
            MsgBox("Delete cancel")
            Exit Sub
        ElseIf DialogResult.Yes Then
            'SQL code funcation, always needed'
            Try
                cb.QuotePrefix = "["
                cb.QuoteSuffix = "]"
                ds.Tables("TblCustomer").Rows(curRow).Delete()
                MaxRows = MaxRows - 1 'Set the MaxRow as a new vaule as there is now les rows in the table'

                curRow = 0
                NavigateRecords()
                da.Update(ds, "TblCustomer")
            Catch ex As Exception
                MsgBox("Delation was unsuccessful, make sure all data selected is correct and in the right format")
            End Try
            MsgBox("The customer data has been delete successfully")
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        PresenceCheck()
        Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        'The system goes throught each row, and change/ upadate any data which doesn't equal the imput data' 
        ds.Tables("TblCustomer").Rows(curRow).Item(0) = TxbCustomerID.Text 'fields called items 
        ds.Tables("TblCustomer").Rows(curRow).Item(1) = TxbFirstname.Text 'ceells are just fields
        ds.Tables("TblCustomer").Rows(curRow).Item(2) = TxbSurname.Text
        ds.Tables("TblCustomer").Rows(curRow).Item(3) = TxbEmail.Text
        ds.Tables("TblCustomer").Rows(curRow).Item(4) = TxbMobileNumber.Text
        ds.Tables("TblCustomer").Rows(curRow).Item(5) = TxbPostcode.Text

        da.Update(ds, "TblCustomer") 'Updates the database with new set of student data
        MsgBox("Data Base has been Updated!")
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        OpenChildForm(New Customers)                                                         ' opends the form in the open child form layout and closes this main form
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Exit Sub
    End Sub
End Class