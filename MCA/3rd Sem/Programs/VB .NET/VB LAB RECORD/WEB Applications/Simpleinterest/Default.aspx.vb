
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p, r, a, si As Integer
        p = txtP.Text
        r = txtR.Text
        a = txtA.Text
        si = p * r * a

        Label1.Text = si
    End Sub
End Class
