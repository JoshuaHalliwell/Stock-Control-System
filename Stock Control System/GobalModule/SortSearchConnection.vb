Imports Org.BouncyCastle.Math.EC

Module SortSearchConnection
    Public Tablename As String
    Public Sub SandSconnection(ByRef DataGridName As DataGridView, sql As String)
        Try

            'da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
            'da.Fill(ds, Tablename) 'Fill whatever is in the data adapter to the DataSet'
            'DataGridName.DataSource = ds
            'DataGridName.DataMember = Tablename

            Dim Results As New DataTable                                                                                                                                                                                                                                                                                                                                                        ' Declare data table
            ' Declare and populate varaible
            da = New OleDb.OleDbDataAdapter(sql, con) 'Pass the sql commad to the connection (database)' 
            da.Fill(Results) 'Fill whatever is in the data adapter to the DataSet'
            DataGridName.DataSource = Results                                                                                                                                                                                                                                                                                                                                                      ' Populate data grid using data table
            con.Close() ' ^   
        Catch ex As Exception
            'MsgBox(ex)

        End Try
        con.Close()
    End Sub
End Module
