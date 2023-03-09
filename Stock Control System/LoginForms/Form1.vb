Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Public Username As String
    Public Password As String
    Dim AccountSelected As String
    Dim cmd As New OleDb.OleDbCommand


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundCornerButton(BtnLogin)
        RoundCornerButton(BtnForgottenPassword)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnForgottenPassword.Click
        ForgottenPassword.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxbUsername.TextChanged

    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxbUsername.Text = "" Then
            MsgBox("A username must be entered in")
            If TxbUsername.TextLength > 11 Then
                MsgBox("Usrename must not be then 11 characters")
            End If
        ElseIf TxbPassword.Text = "" Then
            MsgBox("A password must be entered in")
            If TxbPassword.TextLength > 16 Then
                MsgBox(" Password must be less then 16 characters")
            End If
        End If

        Username = TxbUsername.Text
        Password = TxbPassword.Text
        con.Open()
        sql = "SELECT AccessLevel FROM TblStaff WHERE StaffUsername = '" & TxbUsername.Text & "'AND StaffPassword = '" & TxbPassword.Text & "'"
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, "TblStaff") 'Fill whatever is in the data adapter to the DataSet'
        'cmd = New OleDb.OleDbCommand(sql, con) 'Pass the sql commad to the connection (database)'
        'Dim Reader As OleDb.OleDbDataReader = cmd.ExecuteReader

        If ds.Tables("TblStaff").Rows(0).Item(0) = "Admin" Then
            Admin = 1
            Staff = 0
            MsgBox("Welcome to the system ,'" & TxbUsername.Text & "'", MsgBoxStyle.Information, "Login successfully")
            MainMenu.Show()
            OpenChildForm(New HomeForm)                                                         ' opends the form in the open child form layout and closes this main form
            Me.Hide()
            con.Close()
        ElseIf ds.Tables("TblStaff").Rows(0).Item(0) = "Staff" Then
            Admin = 0
            Staff = 1
            MsgBox("Welcome to the system ,'" & TxbUsername.Text & "'", MsgBoxStyle.Information, "Login successfully")
            MainMenu.Show()
            OpenChildForm(New HomeForm)                                                         ' opends the form in the open child form layout and closes this main form
            Me.Hide()
            con.Close()

        Else
            MsgBox("Incorrect username or password")
        End If
        con.Close()
    End Sub
End Class
