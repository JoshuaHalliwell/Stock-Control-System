Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ListProductOrders
    Dim regexPattern As String = "^SOK\d{3}$"
    Dim TotalOrderPrice As Decimal
    Private Sub ListProductOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataBaseDSProductName.QryProductNameSale' table. You can move, or remove it, as needed.
        Me.QryProductNameSaleTableAdapter.Fill(Me.StockDataBaseDSProductName.QryProductNameSale)
        LbxOrder.ClearSelected()

        TbxCustomerID.Text = SaleCustomerID
        TbxStaffID.Text = SaleStaffID

        ' Get the last sales ID from the table
        Dim LastID As String = GetLastSalesID()

        ' Extract the numeric part of the last ID and increment it by 1 
        Dim newNumber As Integer = Integer.Parse(LastID.Substring(3)) + 1

        ' Generate the new ID and formats the new number as a 3-digit string
        Dim newID As String = "SAL" + newNumber.ToString("000")

        ' Set the new ID as the text of the TextBox
        TbxSalesID.Text = newID

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
    Private Sub TbxSalesID_TextChanged(sender As Object, e As EventArgs) Handles TbxSalesID.TextChanged

    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If Regex.IsMatch(TbxSalesID.Text, regexPattern) Then
            ' Input matches the format "SOK001"
        Else
            ' Input does not match the format "SOK001"
        End If
    End Sub

    Private Sub CbxStockID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxProductName.SelectedIndexChanged
        'Get the selected item And update the other text box controls
        Dim selectedRow As DataRowView = CbxProductName.SelectedItem
        If CbxProductName.SelectedIndex <> -1 Then 'Check if an item is selected in the ComboBox'
            TbxStockID.Text = selectedRow("StockID").ToString()
            TbxPricePerItem.Text = selectedRow("PricePerItem").ToString()
        End If '

    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click
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
            TbxTotalPrice.Text = TotalOrderPrice 'Set the total price in the TextBox'
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

    Private Sub LbxOrder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbxOrder.SelectedIndexChanged

    End Sub
End Class