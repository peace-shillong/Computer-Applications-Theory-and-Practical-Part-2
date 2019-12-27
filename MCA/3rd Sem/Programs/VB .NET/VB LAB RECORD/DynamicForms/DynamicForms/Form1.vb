Public Class Form1
    Public root, root2 As Integer
    Public flag As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, D As Integer
        
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text

        D = (b * b) - (4 * a * c)

        If D = 0 Then
            'roots equal
            root = ((-b) ^ 2 + Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
            root2 = root
            flag = 0
           
            FrmOutput.Show()

        ElseIf D > 0 Then
            'real
            root = ((-b) ^ 2 + Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
            root2 = ((-b) ^ 2 - Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
            flag = 1
            
            FrmOutput.Show()

        Else
            'img
            flag = 2
            FrmOutput.ShowDialog()
        End If
    End Sub

End Class
