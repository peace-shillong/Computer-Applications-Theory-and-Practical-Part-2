Public Class Form1

    Dim Sentence As New LongShortlib.LongShort

  
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Sentence.getvalue = CStr(txtin.Text)
        txtShort.Text = Sentence.getshortestword
        txtLong.Text = Sentence.getlongestword

    End Sub
End Class
