Module SortSearchConnection
    Public Tablename As String
    Public Sub SandSconnection(ByRef DataGridName As DataGridView, sql As String)
        da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
        da.Fill(ds, Tablename) 'Fill whatever is in the data adapter to the DataSet'
        DataGridName.DataSource = ds
        con.Close()
    End Sub
End Module
