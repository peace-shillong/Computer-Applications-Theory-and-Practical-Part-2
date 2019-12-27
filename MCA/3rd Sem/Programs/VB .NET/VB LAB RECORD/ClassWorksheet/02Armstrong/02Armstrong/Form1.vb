Public Class Form1
    Dim Arm As New Armstrong
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Arm.data = TextBox1.Text
        Label3.Text = ""
        Label3.Text = "Result:"
        If Arm.Check() Then
            Label3.Text = Label3.Text & Arm.data & " is an Armstrong Number"
        Else
            Label3.Text = Label3.Text & Arm.data & " is not an Armstrong Number"
        End If
    End Sub
End Class
