Public Class PrintPreview

  
    Private Sub PrintPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.Text = "                               TEST "
        RichTextBox1.Text = RichTextBox1.Text & vbNewLine & "HELLO"
    End Sub
End Class