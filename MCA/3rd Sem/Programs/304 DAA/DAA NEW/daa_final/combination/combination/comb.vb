Public Class comb
    Dim table(100, 100) As Long
    Function combination(ByVal n As Integer, ByVal m As Integer) As Long
        If (n = m Or m = 0) Then
            table(n, m) = 1
        Else
            If (m > 0 And m < n) Then
                table(n, m) = table(n - 1, m) + table(n - 1, m - 1)
            End If
        End If
        Return table(n, m)
    End Function
    Private Sub comb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Form1.m > Form1.n) Then
            MsgBox("\nError !! m>n")
            Form1.Show()
            'Form1.txt1.Clear()
            'Form1.txt2.Clear()
            'Form1.n = CStr(Form1.txt1.Text)
            'Form1.m = CStr(Form1.txt2.Text)
            Form1.err = 2
            Form1.Close()
        Else

            table(Form1.n, Form1.m) = combination(Form1.n, Form1.m)
            For i = 0 To Form1.n
                TextBox1.Text = TextBox1.Text + vbCrLf + vbCrLf + "  " + "n=" + CStr(i) + "  "
                'Console.Write("\n\t n=%d\t", i)
                For j = 0 To Form1.m

                    If (j > i) Then
                        TextBox1.Text = TextBox1.Text + "--" + "  "
                        'Console.Write("-\t")
                    Else
                        table(i, j) = combination(i, j)
                        TextBox1.Text = TextBox1.Text + CStr(table(i, j)) + "  "
                        'Console.Write("%d\t", table(i, j))
                    End If
                Next
            Next
            Form1.TextBox1.Text = table(Form1.n, Form1.m)
        End If
        'TextBox1.Text = TextBox1.Text +vbcrlf+vbcrlf CStr(table(i, j)) + " "
        'printf("\n \n (%d C %d) = %d",n,m,table[n][m]);
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.ShowDialog()
    End Sub
End Class