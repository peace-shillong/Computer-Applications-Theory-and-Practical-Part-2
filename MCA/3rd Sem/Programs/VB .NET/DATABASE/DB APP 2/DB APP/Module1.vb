Imports System.Data.OleDb

Module Module1
    Dim conn As New OleDbConnection ' Connection Object
    Dim cmd As New OleDbCommand

    Public da As New OleDbDataAdapter
    Public ds As New DataSet("MyStudent")

    Public Sub ConnectDB()
        'Connection
        conn.ConnectionString = "PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=Management.accdb"
        conn.Open()

        cmd.CommandText = "Select * from Vehicle"
        cmd.Connection = conn

        'data
        da.SelectCommand = cmd
        da.Fill(ds, "Vehicle") 'Fill DataSet 

    End Sub

    Public Sub Update(ByVal dt As DataTable)
        Dim obj As New OleDbCommandBuilder(da)
        Dim Table_With_ONLY_Changes As DataTable

        Table_With_ONLY_Changes = dt.GetChanges
        dt.AcceptChanges() ' We make a commit in the dt after getting the changes to the db
        da.Update(Table_With_ONLY_Changes)
    End Sub
End Module
