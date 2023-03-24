Imports Microsoft.Office.Interop.Excel
Imports System.Windows.Forms.DataVisualization.Charting
Imports ChartArea = System.Windows.Forms.DataVisualization.Charting.ChartArea

Public Class ReportGraph
    Dim Mychart As New DataVisualization.Charting.Chart()                                ' Define a new chart object

    Private Sub ClbGraphData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClbGraphData.SelectedIndexChanged
        con.Open()
        If ClbGraphData.SelectedItem = "Product sales for the shop " Then
            sql = "SELECT * FROM QrySales"
            Tablename = "QrySales"
        End If
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, Tablename) 'Fill whatever is in the data adapter to the DataSet'
        con.Close()
    End Sub

    Private Sub CbxGraphType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxGraphType.SelectedIndexChanged
        If CbxGraphType.SelectedText = "Pie Chart" Then
            Dim chartData As New Dictionary(Of String, Integer)         ' Create a dictionary to hold the chart data
            For Each row As DataRow In ds.Tables(Tablename).Rows
                chartData.Add(row("ProductName").ToString(), CInt(row("SaleQuantity")))
            Next
            Dim chart As New DataVisualization.Charting.Chart()                                        ' Create a new Chart object and set its properties
            chart.Size = New Size(500, 500)
            chart.ChartAreas.Add(ChartArea())

            For Each pair As KeyValuePair(Of String, Integer) In chartData
                chart.Series(0).Points.AddXY(pair.Key, pair.Value)
            Next
            chart.Series(0).ChartType = SeriesChartType.Pie
            chart.Series(0)("PieLabelStyle") = "Disabled"

            chart.Series.Add("series")
            chart.Legends.Add("legend")
            chart.SaveImage("Piechart.png", ChartImageFormat.Png)

        ElseIf CbxGraphType.SelectedText = "Bar Chart" Then
            Mychart.Titles.Add("Sales by Product")                    ' Set the chart title

            Dim chartArea As New ChartArea()                        ' Define the chart area
            chartArea.AxisX.Title = "Product Name"
            chartArea.AxisY.Title = "Sales Quantity"
            Mychart.ChartAreas.Add(chartArea)

            Dim series As New DataVisualization.Charting.Series()                              ' Define the series data
            series.ChartType = SeriesChartType.Bar
            series.XValueMember = "ProductName"
            series.YValueMembers = "SalesQuantity"
            series.IsValueShownAsLabel = True

            Mychart.DataSource = ds                                   ' Bind the data to the chart
            Mychart.Series.Add(series)

            Me.Controls.Add(Mychart)                                ' Add the chart to the form
            Mychart.Dock = DockStyle.Fill
            Mychart.SaveImage("Barchart.png", ChartImageFormat.Png)

        End If
        con.Close()
    End Sub

    Private Function ChartArea() As String
        Throw New NotImplementedException()
    End Function

    Private Sub BtnPdfShare_Click(sender As Object, e As EventArgs) Handles BtnPdfShare.Click
        ExportGraphToPDF(Mychart, "chart.pdf")

    End Sub

    Private Sub BtnClearGraph_Click(sender As Object, e As EventArgs) Handles BtnClearGraph.Click
        Mychart.Series.Clear()
        Mychart.ChartAreas.Clear()
        Mychart.Series("series").Points.Clear()
    End Sub

    Private Sub BtnEmailShare_Click(sender As Object, e As EventArgs) Handles BtnEmailShare.Click

    End Sub
End Class