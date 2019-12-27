
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub next_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles [next].Click
        Session("name") = txtName.Text
        Dim cookie As New HttpCookie("No")
        cookie.Value = txtNo.Text
        Response.Cookies.Add(cookie)
        Response.Redirect("Default2.aspx")
    End Sub
End Class
