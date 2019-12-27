Public Class Form1
    Dim No As New factorlib.Factors
    Dim Array() As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            No.data = TextBox1.Text
            Array = No.getarray
            TextBox2.Clear()
            For i = 0 To No.count
                TextBox2.Text = TextBox2.Text & Array(i) & " "
            Next
            TextBox1.Focus()
            If No.isPrime() = True Then
                lblPrime.Text = "It is a Prime Number"
            Else
                lblPrime.Text = "It is not a Prime Number"
            End If
            If No.Abundant() = True Then
                LblANo.Text = "It is an Abundant Number"
            Else
                LblANo.Text = "It is Not an Abundant Number!"
            End If

            If No.PerfectNo() = True Then
                lblPNo.Text = "It is a Perfect Number"
            Else
                lblPNo.Text = "It is Not a Perfect Number!"
            End If


        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        LblANo.Text = ""
        lblPNo.Text = ""
        lblPrime.Text = ""
    End Sub


End Class
