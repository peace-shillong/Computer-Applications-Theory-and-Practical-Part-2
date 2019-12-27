
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ColourList1.Items.Add("Red")
            ColourList1.Items.Add("Yellow")
            ColourList1.Items.Add("Orange")
            ColourList1.Items.Add("Brown")
            ColourList1.Items.Add("Blue")
            ColourList1.Items.Add("Dark Green")
        End If


    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        color.Text = ColourList1.SelectedValue

    End Sub
End Class
