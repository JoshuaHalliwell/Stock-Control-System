Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Org.BouncyCastle.Math

Public Class ListProductOrders
    ' Dim regexPattern As String = "^SOK\d{3}$"
    Dim TotalOrderPrice As Decimal
    Dim count As Integer = 0
    Dim staffid As String = MainMenu.LblUsername.Text


    Private Sub ListProductOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataBaseDataSetCustomerName.TblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.StockDataBaseDataSetCustomerName.TblCustomer)
        'TODO: This line of code loads data into the 'StockDataBaseDSProductName.QryProductNameSale' table. You can move, or remove it, as needed.
        Me.QryProductNameSaleTableAdapter.Fill(Me.StockDataBaseDSProductName.QryProductNameSale)

        LbxOrder.ClearSelected()
        Try
            con.Open()
            sql = "SELECT StaffID FROM TblStaff WHERE StaffUsername = '" & staffid & "'"
            da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
            da.Fill(ds, "TblStaff") 'Fill whatever is in the data adapter to the DataSet'
            con.Close() 'Close the connection with the database(leavering it open can cause errors such as lag)'
            TbxStaffID.Text = ds.Tables("TblStaff").Rows(1)("StaffID").ToString()
        Catch ex As Exception
            MsgBox("StaffID is needed")
        End Try
        ' Get the last sales ID from the table
        Dim LastID As String = GetLastSalesID()

        ' Extract the numeric part of the last ID and increment it by 1 
        Dim newNumber As Integer = Integer.Parse(LastID.Substring(3)) + 1

        ' Generate the new ID and formats the new number as a 3-digit string
        Dim newID As String = "SAL" + newNumber.ToString("000")

        ' Set the new ID as the text of the TextBox
        TbxSalesID.Text = newID

        TbxCustomerID.Text = ""
        TbxQuantity.Text = ""
        TbxPricePerItem.Text = ""
        TbxTotalPrice.Text = ""
        TbxStockID.Text = ""
        CbxProductName.Text = ""

        ' Set the current date and time in the saleday and saletime controls
        TbxSaleDay.Text = DateTime.Now.ToShortDateString()
        TbxSaleTime.Text = DateTime.Now.ToLongTimeString()

        con.Open()
        sql = "SELECT StockID, ProductName, PricePerItem FROM TblStocks"
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, "TblStocks") 'Fill whatever is in the data adapter to the DataSet'
        con.Close()

        CbxProductName.DataSource = ds.Tables("TblStocks")
        CbxProductName.DisplayMember = "ProductName"
        CbxProductName.ValueMember = "StockID"


    End Sub
    Private Function GetLastSalesID() As String
        ' This function retrieves the last sales ID from the table and returns it as a string
        Dim lastID As String = ""
        con.Open()
        sql = "SELECT TOP 1 SaleID FROM TblSales ORDER BY SaleID DESC "
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, "TblSales") 'Fill whatever is in the data adapter to the DataSet'
        con.Close() 'Close the connection with the database(leavering it open can cause errors such as lag)'

        If ds.Tables("TblSales").Rows.Count > 0 Then
            lastID = ds.Tables("TblSales").Rows(0)("SaleID").ToString()
        End If

        Return lastID
    End Function


    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Try

            da.Update(ds, "TblSalesLine") 'Updates the database with the new row
        Catch ex As Exception
            'MsgBox("This set of data is already in the database therefor can not be added")
            'Exit Sub
        End Try
        MsgBox("New sale data has been added to the Database") 'display a message box with the following message 

        ' Display a SaveFileDialog to allow the user to choose where to save the file
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Create a new StreamWriter object to write the receipt text to the file
            Using writer As New StreamWriter(saveFileDialog.FileName)
                ' Write the receipt text to the file
                writer.Write(GetReceiptText())
            End Using
        End If

    End Sub

    Private Sub CbxStockID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxProductName.SelectedIndexChanged
        'Get the selected item And update the other text box controls
        Dim selectedRow As DataRowView = CbxProductName.SelectedItem
        If CbxProductName.SelectedIndex <> -1 Then 'Check if an item is selected in the ComboBox'
            TbxStockID.Text = selectedRow("StockID").ToString()
            TbxPricePerItem.Text = String.Format("£{0:0.00}", (selectedRow("PricePerItem")))
        End If

    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click
        PresenceCheck()
        If count < 1 Then
            SalesDetail()
            SalesLine()
        Else
            SalesLine()
        End If
        Try
            Dim productName As String = CbxProductName.Text
            Dim quantity As Integer = CInt(TbxQuantity.Text)
            Dim pricePerItem As Decimal = CDec(TbxPricePerItem.Text)
            Dim price As Decimal = quantity * pricePerItem
            Dim item As String = productName & " - " & quantity.ToString() & " x " & pricePerItem.ToString() & " = " & price.ToString()


            LbxOrder.Items.Add(item) 'Add the item to the ListBox'

            If LbxOrder.Items.Count = 1 Then 'If this is the first item added, add the headings'
                LbxOrder.Items.Insert(0, "Product Name| Quantity  Price per Item")
                LbxOrder.Items.Insert(1, New String("-"c, 50))
            End If

            ''Dim totalPrice As Decimal = 0
            'For i As Integer = 2 To LbxOrder.Items.Count - 1 'Skip the first two items (headings)'
            '    'Dim listItem As String = LbxOrder.Items(i).ToString()
            '    'Dim itemPrice As Decimal
            '    'Dim parts As String() = listItem.Split("-"c)
            '    'Dim priceString As String = parts(1).Trim()
            '    'If Decimal.TryParse(priceString, NumberStyles.Currency, CultureInfo.CurrentCulture, itemPrice) Then
            '    '    'TotalOrderPrice += itemPrice * quantity 'Add up the prices'
            '    TotalOrderPrice = TotalOrderPrice + price

            '    End If
            'Next
            TotalOrderPrice = TotalOrderPrice + price
            TbxTotalPrice.Text = String.Format("£{0:0.00}", TotalOrderPrice) 'Set the total price in the TextBox'
        Catch ex As Exception
            MsgBox("Data must be in each field")
        End Try
    End Sub

    Private Sub BtnDeleteItem_Click(sender As Object, e As EventArgs) Handles BtnDeleteItem.Click
        If LbxOrder.SelectedIndex <> -1 Then 'Check if an item is selected'
            ' Get the price of the selected item
            Dim priceText As String = String.Join("=", LbxOrder.SelectedItem.ToString().Split("=").Skip(1)).Trim()
            If priceText.Length >= 2 Then ' Check if the split result contains at least 2 elements
                Dim price As Double = CDbl(priceText(1).ToString().Trim().Split("$")(1))

                ' Remove the selected item from the ListBox
                LbxOrder.Items.RemoveAt(LbxOrder.SelectedIndex)

                ' Subtract the price of the selected item from the current total
                Dim currentTotal As Double = CDbl(TbxTotalPrice.Text.Replace("$", ""))
                currentTotal -= price
                TbxTotalPrice.Text = String.Format("${0:0.00}", currentTotal)
            Else
                ' Display an error message if the item does not contain a valid price
                MessageBox.Show("The selected item does not contain a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' Display an error message if no item is selected
            MessageBox.Show("Please select an item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SalesDetail()
        con.Open()
        sql = "SELECT * FROM TblSales"
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, "TblSales") 'Fill whatever is in the data adapter to the DataSet'
        cb = New OleDb.OleDbCommandBuilder(da)
        con.Close() 'Close the connection with the database(leavering it open can cause errors such as lag)'
        Dim dsNewRow As DataRow 'declares variable
        If curRow <> -1 Then 'If the variable doesn't equal to -1 the execute the below 

            dsNewRow = ds.Tables("TblSales").NewRow()

            dsNewRow.Item("SaleID") = TbxSalesID.Text
            dsNewRow.Item("SaleTime") = TbxSaleTime.Text
            dsNewRow.Item("SaleDay") = TbxSaleDay.Text
            dsNewRow.Item("StaffID") = TbxStaffID.Text
            dsNewRow.Item("CustomerID") = TbxCustomerID.Text

            ds.Tables("TblSales").Rows.Add(dsNewRow)
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            Try
                da.Update(ds, "TblSales") 'Updates the database with the new row
            Catch ex As Exception
                ' MsgBox("This set of data is already in the database therefor can not be added")
                Exit Sub
            End Try
            '  MsgBox("New sale data has been added to the Database") 'display a message box with the following message 
            count = 1
        Else
            '  MsgBox("Data can not be added to the database, please ensure that all the information is correct")
        End If
    End Sub
    Private Sub SalesLine()
        con.Open()
        sql = "SELECT * FROM TblSalesLine"
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, "TblSalesLine") 'Fill whatever is in the data adapter to the DataSet'
        cb = New OleDb.OleDbCommandBuilder(da)
        con.Close() 'Close the connection with the database(leavering it open can cause errors such as lag)'
        Dim dsNewRow As DataRow 'declares variable
        Try
            dsNewRow = ds.Tables("TblSalesLine").NewRow()

            dsNewRow.Item("StockID") = TbxStockID.Text
            dsNewRow.Item("SaleID") = TbxSalesID.Text
            dsNewRow.Item("SaleQuantity") = TbxQuantity.Text
            ds.Tables("TblSalesLine").Rows.Add(dsNewRow)
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
        Catch ex As Exception
            MsgBox(ex)
        End Try
        '
    End Sub
    Private Sub PresenceCheck()
        If TbxQuantity.Text = "" Then
            MsgBox("There must be a qunatity amount for each iteam")
        End If
    End Sub

    Private Sub CbCustomerName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxCustomerName.SelectedIndexChanged
        Dim selectedRow As DataRowView = CbxCustomerName.SelectedItem
        If CbxCustomerName.SelectedIndex <> -1 Then 'Check if an item is selected in the ComboBox'
            TbxCustomerID.Text = selectedRow("CustomerID").ToString()
        End If
    End Sub
    Private Function GetReceiptText() As String
        ' Get the sales details from the form controls
        Dim saleID As String = TbxSalesID.Text
        Dim saleTime As String = TbxSaleTime.Text
        Dim saleDay As String = TbxSaleDay.Text
        Dim customerID As String = TbxCustomerID.Text
        Dim customerName As String = CbxCustomerName.Text
        Dim staffID As String = TbxStaffID.Text
        Dim StockID As String = TbxStockID.Text

        ' Create a StringBuilder object to build the receipt text
        Dim receiptText As New StringBuilder()

        ' Add the header information to the receipt
        receiptText.AppendLine("Sale Receipt")
        receiptText.AppendLine("===============================")
        receiptText.AppendLine($"Sale ID: {saleID}")
        receiptText.AppendLine($"Sale Time: {saleTime}")
        receiptText.AppendLine($"Sale Day: {saleDay}")
        receiptText.AppendLine($"Customer ID: {customerID}")
        receiptText.AppendLine($"Customer Name: {customerName}")
        receiptText.AppendLine($"Staff ID: {staffID}")
        receiptText.AppendLine($"Stock ID: {StockID}")
        receiptText.AppendLine("===============================")

        For Each item As String In LbxOrder.Items
            ' Parse the item details from the string
            'Dim parts As String() = item.Split("-")
            'Dim productName As String = parts(0).Trim()
            'Dim quantity As Integer = Integer.Parse(parts(1).Trim().Split(" ")(0))
            'Dim pricePerItem As Decimal = Decimal.Parse(parts(2).Trim().Split(" ")(0))
            'Dim price As Decimal = Decimal.Parse(parts(3).Trim())

            Dim parts() As String = item.ToString().Split(","c)
            Dim productName As String = parts(0)
            Dim quantity As Integer = Integer.Parse(parts(1))
            Dim pricePerItem As Decimal = Decimal.Parse(parts(2))
            Dim price As Decimal = Decimal.Parse(parts(3))

            ' Add the item details to the receipt
            receiptText.AppendLine(productName)
            receiptText.AppendLine(String.Format("Quantity: {0}", quantity))
            receiptText.AppendLine(String.Format("Price per item: £{0:0.00}", pricePerItem))
            receiptText.AppendLine(String.Format("Total price of items: £{0:0.00}", price))
            receiptText.AppendLine("-----------------------------")

            'receiptText.AppendLine($"{productName} x {quantity} @ {pricePerItem.ToString("C")} = {price.ToString("C")}")
        Next

        ' Add the total price to the receipt
        Dim totalPrice As Decimal = CDec(TbxTotalPrice.Text)
        receiptText.AppendLine("===============================")
        receiptText.AppendLine(String.Format("Total Price: £{0:0.00}", totalPrice))

        ' Return the receipt text
        Return receiptText.ToString()
    End Function


End Class