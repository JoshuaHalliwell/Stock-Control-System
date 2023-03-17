Public Class StaffAdd
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblStaffID.Click
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
        TbxStaffEmail.Text = ds.Tables("TblStaf").Rows(curRow).Item(3)
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

    Private Sub StaffAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class