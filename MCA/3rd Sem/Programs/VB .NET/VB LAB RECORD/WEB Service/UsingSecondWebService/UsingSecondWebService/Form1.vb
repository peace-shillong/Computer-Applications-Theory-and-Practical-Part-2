Public Class Form1
    Dim obj As New ServiceReference1.ServiceSoapClient
    Dim str As String
    Dim no_vol As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        str = TextBox1.Text
        no_vol = obj.Count_Vowels(str)
        MsgBox("No Of Vowels is " & no_vol)
    End Sub

End Class
