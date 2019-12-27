
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim nm As String
        Dim c As HttpCookie

        lblName.Text = Session("name")

        c = Request.Cookies.Item("No")
        Label1.Text = c.Value.ToString
    End Sub

    Protected Sub home_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles home.Click
        Response.Redirect("Default.aspx")
    End Sub
End Class
