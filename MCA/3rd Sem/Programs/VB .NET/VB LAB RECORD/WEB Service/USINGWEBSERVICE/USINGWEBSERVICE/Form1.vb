Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim obj As New ServiceReference1.ServiceSoapClient
        Dim n, res As Integer
        n = TextBox1.Text
        res = obj.Square(n)
        Label1.Text = "Sqaure is " & res
        MsgBox("The square = " & res)

    End Sub
End Class
