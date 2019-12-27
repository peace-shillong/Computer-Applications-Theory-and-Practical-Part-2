Imports System.Data.OleDb
Public Class Form1
    Public con As New OleDbConnection
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Public ds As New DataSet
    Public dt As DataTable

    Public Sub connect()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student_Details.mdb"
        con.Open()

        cmd.CommandText = "Select * from student"
        cmd.Connection = con

        da.SelectCommand = cmd
        da.Fill(ds, "student")
        dt = ds.Tables.Item("student")
        con.Close()
    End Sub
        
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()


        cmbid.DataSource = dt
        cmbid.ValueMember = "sid"
        cmbid.DisplayMember = "sid"

      
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dr() As DataRow
        Dim dtfound As DataTable
        Dim id As Integer = cmbid.SelectedValue
        dr = dt.Select("sid = " & id)
        dtfound = dr.CopyToDataTable
        dgv.DataSource = dtfound
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dr() As DataRow
        Dim dtfound As DataTable
        Dim id As Integer = cmbid.SelectedIndex + 1
        dr = dt.Select("sid <= " & id)
        dtfound = dr.CopyToDataTable
        dgv.DataSource = dtfound
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dr() As DataRow
        Dim dtfound As DataTable
        'Dim id As Integer = cmbid.SelectedValue
        dr = dt.Select("sname like '%a%'", "sid")
        dtfound = dr.CopyToDataTable
        dgv.DataSource = dtfound
        dgv.Columns(2).Visible = False
    End Sub

End Class
