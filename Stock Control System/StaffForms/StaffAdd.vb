Public Class StaffAdd
    Private Sub StaffAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblSurnameError.Text = "" 'Hides the on screen error messages by making the text to be empty so that they only appear when needed'
        LblStaffIDError.Text = ""
        LblFirstnameError.Text = ""
        LblSurnameError.Text = ""
        LblStaffEmailError.Text = ""
        LblTelephoneError.Text = ""
        LblStaffUsernameError.Text = ""
        LblStaffPasswordError.Text = ""
        LblAccessLevelError.Text = ""

        RoundCornerButton(BtnAddStaffDetails) 'Makes all button elements to have a rounded effect on them'
        RoundCornerButton(BtnDeleteStaffDetails)
        RoundCornerButton(BtnUpdateStaffDetails)
        RoundCornerButton(BtnBackToMenu)
        RoundCornerButton(BtnLastStaffDetails)
        RoundCornerButton(BtnPreviousStaff)
        RoundCornerButton(BtnNextStaff)
        RoundCornerButton(BtnFirstStaffDetails)
        RoundCornerButton(BtnClearStaffDetails)
        RoundCornerButton(BtnCancelProcess)

        con.Open()
        sql = "SELECT * FROM TblStaff"
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql command to the connection (database)'
        da.Fill(ds, "TblStaff") 'Fill whatever is in the data adapter to the DataSet'
        con.Close() 'Close the connection with the database (this is because leaving it open could cause it to lag)'
        MaxRows = ds.Tables("TblStaff").Rows.Count 'Gets how many rows there are currently in the DataSet'
        curRow = 1 'Selects the second row of data from the database'
        NavigateRecords()
    End Sub
    Private Sub NavigateRecords()
        TbxStaffID.Text = ds.Tables("TblStaff").Rows(curRow).Item(0)
        TbxStaffFirstName.Text = ds.Tables("TblStaff").Rows(curRow).Item(1)
        TbxStaffSurname.Text = ds.Tables("TblStaff").Rows(curRow).Item(2)
        TbxStaffEmail.Text = ds.Tables("TblStaff").Rows(curRow).Item(3)
        TbxStaffTelephone.Text = ds.Tables("TblStaff").Rows(curRow).Item(4)
        TbxStaffUsername.Text = ds.Tables("TblStaff").Rows(curRow).Item(5)
        TbxStaffPassword.Text = ds.Tables("TblStaff").Rows(curRow).Item(6)
        TbxAccessLevel.Text = ds.Tables("TblStaff").Rows(curRow).Item(7)
    End Sub
    Private Sub PresenceCheck()
        Try
            If TbxStaffID.Text = ds.Tables("TblStaff").Rows(curRow).Item(0) Then   ' Checks to see if there is any data in the textboxes
                LblStaffIDError.Text = "Staff ID field must be filled in with data"  ' if there is none then the realtive error text will
            ElseIf TbxStaffFirstName.Text = ds.Tables("TblStaff").Rows(curRow).Item(1) Then '  appear next to the relative textbox
                LblFirstnameError.Text = "Staff firstname field must be filled in with data"

            ElseIf TbxStaffUsername.Text = ds.Tables("TblStaff").Rows(curRow).Item(2) Then
                LblSurnameError.Text = "Staff surname field must be filled in with data"

            ElseIf TbxStaffEmail.Text = ds.Tables("TblStaff").Rows(curRow).Item(3) Then
                LblStaffEmailError.Text = "Staff email field must be filled in with data"

            ElseIf TbxStaffTelephone.Text = ds.Tables("TblStaff").Rows(curRow).Item(4) Then
                LblTelephoneError.Text = "Staff telephone field must be fille with data"

            ElseIf TbxStaffUsername.Text = ds.Tables("TblStaff").Rows(curRow).Item(5) Then
                LblStaffUsernameError.Text = "Staff username field must be filled with data"

            ElseIf TbxStaffPassword.Text = ds.Tables("TblStaff").Rows(curRow).Item(6) Then
                LblStaffPasswordError.Text = "Staff password field must be filled with data"

            ElseIf TbxAccessLevel.Text = ds.Tables("TblStaff").Rows(curRow).Item(7) Then
                LblAccessLevelError.Text = "Staff access level field must be filled with data"
            End If
        Catch ex As Exception

        End Try
        LblStaffIDError.Text = ""
        LblFirstnameError.Text = ""
        LblSurnameError.Text = ""
        LblStaffEmailError.Text = ""
        LblTelephoneError.Text = ""
        LblStaffUsernameError.Text = ""
        LblStaffPasswordError.Text = ""
        LblAccessLevelError.Text = ""
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles BtnClearStaffDetails.Click
        TbxStaffID.Clear() 'clears off any data in the textboxes'
        TbxStaffFirstName.Clear()
        TbxStaffSurname.Clear()
        TbxStaffEmail.Clear()
        TbxStaffTelephone.Clear()
        TbxStaffUsername.Clear()
        TbxStaffPassword.Clear()
        TbxAccessLevel.Clear()
    End Sub

    Private Sub btnFirstStaffDetails_Click(sender As Object, e As EventArgs) Handles BtnFirstStaffDetails.Click
        curRow = 0  'sets the viewing of the records to the first record which is set at 2'
        NavigateRecords()
    End Sub


    Private Sub BtnNextStaff_Click(sender As Object, e As EventArgs) Handles BtnNextStaff.Click
        If curRow <> MaxRows - 1 Then 'if the curRow isn't equal to MaxRow - 1 then execute the below '
            curRow = curRow + 1 'Sets CurRow  to its own vaulue + 1' 
            NavigateRecords() 'calls database funcation'
        Else 'if the above doesn't apply then execute the below,
            MsgBox("No More Staff data ") 'display a message box with the following message of there is no data byoned that point' 
        End If 'end if statement,
    End Sub

    Private Sub BtnPreviousStaff_Click(sender As Object, e As EventArgs) Handles BtnPreviousStaff.Click
        If curRow > 0 Then 'if the variable is more than 0 then execute the below 
            curRow = curRow - 1 'Sets value to a variable
            NavigateRecords() 'calls function
        ElseIf curRow = -1 Then 'if the variable is equal to -1, execute the below 
            MsgBox("No new Staff data") 'display a message box with the following message 
        ElseIf curRow = 0 Then 'if the variable is equal to 0 then execute the below 
            MsgBox("First Staff data") 'display a message box with the following message 
        End If 'end if statement
    End Sub

    Private Sub BtnLastStaffDetails_Click(sender As Object, e As EventArgs) Handles BtnLastStaffDetails.Click
        curRow = MaxRows - 1 'sets a new value to the variable so that the system know the current row is just one away from the max row value which holds no data.
        NavigateRecords()
    End Sub

    Private Sub BtnAddStaffDetails_Click(sender As Object, e As EventArgs) Handles BtnAddStaffDetails.Click
        PresenceCheck()

        If curRow <> -1 Then 'If the variable doesn't equal to -1 the execute the below 
            Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable
            Dim dsNewRow As DataRow 'declares variable

            dsNewRow = ds.Tables("TblStaff").NewRow()

            dsNewRow.Item("StaffID") = TbxStaffID.Text
            dsNewRow.Item("StaffFirstName") = TbxStaffFirstName.Text
            dsNewRow.Item("StaffSurname") = TbxStaffSurname.Text
            dsNewRow.Item("StaffEmail") = TbxStaffEmail.Text
            dsNewRow.Item("StaffTelephone") = TbxStaffTelephone.Text
            dsNewRow.Item("StaffUsername") = TbxStaffUsername.Text
            dsNewRow.Item("StaffPassword") = TbxStaffPassword.Text
            dsNewRow.Item("AccessLevel") = TbxAccessLevel.Text

            ds.Tables("TblStaff").Rows.Add(dsNewRow)

            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"

            Try
                da.Update(ds, "TblStaff") 'Updates the database with the new row
            Catch ex As Exception
                MsgBox("This set of data is already in the database therefor can not be added")
                Exit Sub
            End Try
            MsgBox("New Staff has been added to the Database") 'display a message box with the following message 
        Else
            MsgBox("Data can not be added to the database, please ensure that all the information is correct")
        End If
    End Sub

    Private Sub BtnDeleteStaffDetails_Click(sender As Object, e As EventArgs) Handles BtnDeleteStaffDetails.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable 
        PresenceCheck()
        MsgBox("Do you really want to Delete this staff data?", MsgBoxStyle.YesNo, MessageBoxIcon.Warning) ' MessageBoxButtons creats buttons fro the user to click on'
        If DialogResult.No Then 'if the user clicks no, it will just end the process of deleting
            MsgBox("Delete cancel")
            Exit Sub
        ElseIf DialogResult.Yes Then
            'SQL code funcation, always needed'
            Try
                cb.QuotePrefix = "["
                cb.QuoteSuffix = "]"
                ds.Tables("TblStaff").Rows(curRow).Delete()
                MaxRows = MaxRows - 1 'Set the MaxRow as a new vaule as there is now les rows in the table'

                curRow = 0
                NavigateRecords()
                da.Update(ds, "TblStaff")
            Catch ex As Exception
                MsgBox("Deletion was unsuccessful, make sure all data selected is correct and in the right format")
            End Try
            MsgBox("The staff data has been deleted successfully")
        End If
    End Sub

    Private Sub BtnUpdateStaffDetails_Click(sender As Object, e As EventArgs) Handles BtnUpdateStaffDetails.Click
        PresenceCheck()
        Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        'The system goes throught each row, and change/ upadate any data which doesn't equal the imput data' 
        ds.Tables("TblStaff").Rows(curRow).Item(0) = TbxStaffID.Text 'fields called items 
        ds.Tables("TblStaff").Rows(curRow).Item(1) = TbxStaffFirstName.Text 'ceells are just fields
        ds.Tables("TblStaff").Rows(curRow).Item(2) = TbxStaffSurname.Text
        ds.Tables("TblStaff").Rows(curRow).Item(3) = TbxStaffEmail.Text
        ds.Tables("TblStaff").Rows(curRow).Item(4) = TbxStaffTelephone.Text
        ds.Tables("TblStaff").Rows(curRow).Item(5) = TbxStaffUsername.Text
        ds.Tables("TblStaff").Rows(curRow).Item(6) = TbxStaffPassword.Text
        ds.Tables("TblStaff").Rows(curRow).Item(7) = TbxAccessLevel.Text

        da.Update(ds, "TblStaff") 'Updates the database with new set of student data
        MsgBox("Data Base has been Updated!")
    End Sub

    Private Sub BtnCancelProcess_Click(sender As Object, e As EventArgs) Handles BtnCancelProcess.Click

    End Sub

    Private Sub BtnBackToMenu_Click(sender As Object, e As EventArgs) Handles BtnBackToMenu.Click
        'OpenChildForm(New staffview)
    End Sub
End Class