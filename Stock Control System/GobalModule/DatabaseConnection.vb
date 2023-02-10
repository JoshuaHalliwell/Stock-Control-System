Module DatabaseConnection
    Public MaxRows As Integer 'The maxuim amount rows of the table'
    Public MaxColumns As Integer 'The maxuim amount columns of the table'
    Public curRow As Integer 'The current row being inseted into the table'
    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "/StockDataBase.accdb") 'Useing a pre- defined Library to connect to the database'
    Public ds As New DataSet 'A table from microsoft access is now refred to as DataSet'
    Public da As OleDb.OleDbDataAdapter 'Used to push data in and out data betweent applictions such as Micrsoft Access and Visual Students   
    Public sql As String 'The current SQL command as a string' 
End Module
