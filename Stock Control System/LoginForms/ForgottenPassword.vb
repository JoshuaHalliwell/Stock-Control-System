Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ForgottenPassword
    Dim errorcount As Integer = 0
    Private Sub ForgottenPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxbConfirmPassword.Text = ""
        TxbNewPassword.Text = ""
        TxbUsername.Text = ""

        RoundCornerButton(BtnBack)
        RoundCornerButton(BtnSetNewPassword)

        TxbConfirmPassword.Hide()
        TxbNewPassword.Hide()
        LblConfirmPassword.Hide()
        LblNewPassword.Hide()
    End Sub

    Private Sub TxbUsername_Leave(sender As Object, e As EventArgs) Handles TxbUsername.Leave
        con.Open()
        sql = "SELECT StaffUsername FROM TblStaff WHERE StaffUsername  = '" & TxbUsername.Text & "'"
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, "TblStaff") 'Fill whatever is in the data adapter to the DataSet'
        con.Close() 'Close the connection with the database(leavering it open can cause errors such as lag)'
        Try
            While errorcount < 4
                If String.IsNullOrEmpty(sql) Then
                    MsgBox("Valid username must be given", MsgBoxStyle.Information, "Valid Username")
                    errorcount = errorcount + 1
                Else
                    TxbConfirmPassword.Show()
                    TxbNewPassword.Show()
                    LblConfirmPassword.Show()
                    LblNewPassword.Show()
                End If
            End While
            MsgBox("Too many attemps made, try again later", MsgBoxStyle.Exclamation, "Block Access")
            Me.Close()
            Form1.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnSetNewPassword_Click(sender As Object, e As EventArgs) Handles BtnSetNewPassword.Click
        Try
            If TxbConfirmPassword.Text = "" Or TxbNewPassword.Text = "" Then
                MsgBox("All textboxes must be filled in", MsgBoxStyle.Information, "Fill Textboxerror")
            ElseIf TxbConfirmPassword.Text <> TxbNewPassword.Text Then
                MsgBox("Bothpasswords must be the same", MsgBoxStyle.Exclamation, "Password Error")
            Else
                MsgBox("Are you sure you wish to update your password?", MsgBoxStyle.YesNo, "Update confirm")
                If MsgBoxResult.Yes Then
                    con.Open()
                    sql = "UPDATE TblStaff SET StaffPassword = '" & TxbConfirmPassword.Text & "' WHERE StaffUsername  = '" & TxbUsername.Text & "'"
                    da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
                    da.Fill(ds, "TblStaff") 'Fill whatever is in the data adapter to the DataSet'
                    con.Close() 'Close the connection with the database(leavering it open can cause errors such as lag)'
                    Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable
                    cb.QuotePrefix = "["
                    cb.QuoteSuffix = "]"
                    'The system goes throught each row, and change/ upadate any data which doesn't equal the imput data' 
                    ds.Tables("TblStaff").Rows(curRow).Item(6) = TxbConfirmPassword.Text 'ceells are just fields
                    da.Update(ds, "TblStaff") 'Updates the database with new set of student data
                    MsgBox("Data Base has been Updated!")
                ElseIf MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox("Password can not be change")
        End Try
    End Sub

    Private Sub TxbUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbUsername.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            ' User has pressed Enter, so execute the desired code here
            con.Open()
            sql = "SELECT StaffUsername FROM TblStaff WHERE StaffUsername  = '" & TxbUsername.Text & "'"
            da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
            da.Fill(ds, "TblStaff") 'Fill whatever is in the data adapter to the DataSet'
            con.Close() 'Close the connection with the database(leavering it open can cause errors such as lag)'
            Try
                While errorcount < 4
                    If String.IsNullOrEmpty(sql) Then
                        MsgBox("Valid username must be given", MsgBoxStyle.Information, "Valid Username")
                        errorcount = errorcount + 1
                    Else
                        TxbConfirmPassword.Show()
                        TxbNewPassword.Show()
                        LblConfirmPassword.Show()
                        LblNewPassword.Show()
                    End If
                End While
                MsgBox("Too many attemps made, try again later", MsgBoxStyle.Exclamation, "Block Access")
                Me.Close()
                Form1.Show()
            Catch ex As Exception
            End Try
            ' Prevent the Enter key from being added to the textbox
            e.Handled = True
        End If
    End Sub
End Class