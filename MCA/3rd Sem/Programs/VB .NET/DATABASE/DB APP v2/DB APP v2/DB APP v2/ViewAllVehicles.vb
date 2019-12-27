Public Class ViewAllVehicles

    Private Sub ViewAllVehicles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        Dim dt As DataTable

        dt = ds.Tables("Vehicle")

        DGVS.DataSource = dt 'The DataGridView is a control for showing data from a data soutece i.e a data table 
        ' The data displayed is in the form of rows and columns
    End Sub
End Class