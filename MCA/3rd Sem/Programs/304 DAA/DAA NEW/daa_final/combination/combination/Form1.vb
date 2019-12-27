Public Class Form1
    Public m, n As Integer
    Public err As Integer


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Clear()
        txt1.Clear()
        txt2.Clear()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btncal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncal.Click
        n = txt1.Text
        m = txt2.Text
        comb.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
