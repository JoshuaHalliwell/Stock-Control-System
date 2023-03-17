Imports iText.Kernel.Colors
Imports iText.Kernel.Pdf
Imports iText.Layout.Element
Imports iText.Layout.Properties
Imports iText.Layout
Imports Microsoft.Office.Interop.Excel

Module ExportToPDF
    Public Sub ExportDataGridToPDF(ByVal dataGridView As DataGridView)
        ' Create a new SaveFileDialog object
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.FileName = "MyDataGridView"
        saveFileDialog.DefaultExt = ".pdf"
        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
        ' Prompt the user to choose a filename and location for the PDF file
        If saveFileDialog.ShowDialog() = DialogResult.OK Then

            ' Create a new PDF document
            Dim pdfDoc As New PdfDocument(New PdfWriter(saveFileDialog.FileName))

            ' Add a new page to the document
            Dim document As New Document(pdfDoc)

            ' Create a table and add it to the document
            Dim table As New Table(dataGridView.ColumnCount)
            table.SetWidth(UnitValue.CreatePercentValue(100))


            ' Add table headers
            For i As Integer = 0 To dataGridView.ColumnCount - 1
                table.AddHeaderCell(dataGridView.Columns(i).HeaderText)
                table.SetBackgroundColor(ColorConstants.LIGHT_GRAY)
            Next

            ' Add table rows
            For i As Integer = 0 To dataGridView.RowCount - 1
                For j As Integer = 0 To dataGridView.ColumnCount - 1
                    ' Add null check
                    If Not dataGridView(j, i) Is Nothing AndAlso Not dataGridView(j, i).Value Is Nothing Then
                        table.AddCell(dataGridView(j, i).Value.ToString())
                    Else
                        table.AddCell("")
                    End If
                Next
            Next
            ' Add table to the document
            document.Add(table)

            ' Close the document
            document.Close()

            MessageBox.Show("PDF file has been exported successfully!")
        End If
    End Sub
    Public Sub ExportGraphToPDF(ByVal chart As Chart, Optional ByVal filename As String = "")
        Dim pdfDoc As New PdfDocument(New PdfWriter(filename))
        Dim document As New Document(pdfDoc)

        ' document.Add()
        document.Close()

        If filename = "" Then
            ' If no filename was provided, show a save dialog
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
            saveFileDialog.Title = "Save Graph As PDF"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                filename = saveFileDialog.FileName
            End If
        ElseIf filename <> "" Then
            ' Save the PDF to the specified file
            ' pdfDoc.Save(filename)
            pdfDoc.Close()
            MessageBox.Show("Graph exported to PDF successfully!")
        End If
    End Sub
End Module
