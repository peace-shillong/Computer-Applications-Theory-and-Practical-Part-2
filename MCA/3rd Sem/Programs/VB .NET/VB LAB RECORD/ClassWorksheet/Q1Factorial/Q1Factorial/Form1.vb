Public Class Form1
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim n As New Factorial, fact As Long
        n.data = txtNo.Text
        fact = 1
        If n.data < 1 Or n.data >= 20 Then
            'txtFact.Text = "Number is too Large"
            MsgBox("Invalid number entered. Number range: 1-20")
            txtFact.Clear()
            txtNo.Clear()
        Else
            fact = n.Findfactorial()
            txtFact.Text = fact
        End If
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNo.Clear()
        txtFact.Clear()
    End Sub
End Class
