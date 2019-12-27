Public Class Form1
    Dim obj As New ServiceReference1.ServiceSoapClient

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim array() As Integer
        array = obj.FactorsOfNo(TextBox1.Text).ToArray()
        ComboBox1.Items.Clear()
        For i = 0 To UBound(array)
            ComboBox1.Items.Add(array(i))
        Next
    End Sub
End Class
