Imports System.Text.RegularExpressions
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ReportDatabaseTable
    Dim Tablename As String
    Private Sub ReportDatabaseTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundCornerButton(BtnBackToMenu)
        RoundCornerButton(BtnBackupTable)
        RoundCornerButton(BtnClearTable)
        RoundCornerButton(BtnSaveToPDF)
        RoundCornerButton(BtnShareByEmail)
    End Sub

    Private Sub ClbGraphData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClbGraphData.SelectedIndexChanged
        con.Open()
        If ClbGraphData.SelectedItem = "Staff Table" Then
            sql = "SELECT * FROM TblStaff"
            Tablename = "TblStaff"
        ElseIf ClbGraphData.SelectedItem = "Customer Table" Then
            sql = "SELECT * FROM TblCustomer "
            Tablename = "TblCustomer"
        ElseIf ClbGraphData.SelectedItem = "Suppliers Orders Table" Then
            sql = "SELECT * FROM TblOrders "
            Tablename = "TblOrders"
        ElseIf ClbGraphData.SelectedItem = "Sales Table" Then
            sql = "SELECT * FROM QrySales"
            Tablename = "TblSales"
        ElseIf ClbGraphData.SelectedItem = "Stocks Table" Then
            sql = "SELECT * FROM TblStocks "
            Tablename = "TblStocks"
        ElseIf ClbGraphData.SelectedItem = "Suppliers Table" Then
            sql = "SELECT * FROM TblSuppliers "
            Tablename = "TblSuppliers"
        End If
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, Tablename) 'Fill whatever is in the data adapter to the DataSet'
        DGVDataTable.DataSource = ds
        con.Close()
    End Sub

    Private Sub BtnClearTable_Click(sender As Object, e As EventArgs) Handles BtnClearTable.Click
        DGVDataTable.ClearSelection()
    End Sub

    Private Sub BtnBackupTable_Click(sender As Object, e As EventArgs) Handles BtnBackupTable.Click
        Dim excelApp As New Excel.Application                                               'Backup the current selected data information 
        Dim excelWorkbook As Excel.Workbook
        Dim excelWorksheet As Excel.Worksheet
        Dim missingValue As Object = Reflection.Missing.Value
        Dim saveFileDialog As New SaveFileDialog()                             ' Create a new SaveFileDialog object           

        saveFileDialog.FileName = "MyExcelWorksheet"                            ' Set the default file name and extension
        saveFileDialog.DefaultExt = ".xlsx"
        saveFileDialog.Filter = "Excel Worksheet (*.xlsx)|*.xlsx"               ' Set the file filter

        If saveFileDialog.ShowDialog() = DialogResult.OK Then                   ' Show the dialog box to the user
            Dim backupPath As String = saveFileDialog.FileName                   ' User has selected a valid file name and clicked OK
            excelApp = New Excel.Application
            excelWorkbook = excelApp.Workbooks.Add(missingValue)
            excelWorksheet = excelWorkbook.Sheets("Sheet1")

            For i = 0 To ds.Tables(Tablename).Rows.Count - 1                    ' Loops through the data table for the information 
                For j = 0 To ds.Tables(Tablename).Columns.Count - 1
                    excelWorksheet.Cells(i + 1, j + 1) = ds.Tables(Tablename).Rows(i).Item(j)
                Next
            Next

            excelWorksheet.SaveAs(backupPath)                                   ' save and make the new excel doucment with the selected backup path
            excelWorkbook.Close()
            excelApp.Quit()
            MsgBox("This Record has been added to StudentBackup")
        End If
    End Sub

    Private Sub BtnSaveToPDF_Click(sender As Object, e As EventArgs) Handles BtnSaveToPDF.Click
        ExportDataGridToPDF(DGVDataTable)
    End Sub

    Private Sub BtnBackToMenu_Click(sender As Object, e As EventArgs) Handles BtnBackToMenu.Click
        OpenChildForm(New ReportMenu)
    End Sub

    Private Sub BtnShareByEmail_Click(sender As Object, e As EventArgs) Handles BtnShareByEmail.Click
        Dim recpientemail As String = InputBox("Please enter recipient email address:", "Email Recipient")      ' Check if user clicked cancel or entered empty input
        Dim emailPattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"                     ' Validate the email address using regular expression pattern

        If String.IsNullOrWhiteSpace(recpientemail) Then
            MessageBox.Show("No email recipient entered.")
            Return

        ElseIf Not Regex.IsMatch(recpientemail, emailPattern) Then
            MessageBox.Show("Invalid email address entered.")
            Return
        Else
            Try
                SendEmailWithDataGrid(DGVDataTable, recpientemail, "Data from DataGridView", "Here is the data from the DataGridView.", "C:\path\to\attachment.csv")
            Catch ex As Exception
                SendEmailWithDataGrid(DGVDataTable, recpientemail, "Data from DataGridView", "Here is the data from the DataGridView.", "")
            End Try
        End If
    End Sub
End Class