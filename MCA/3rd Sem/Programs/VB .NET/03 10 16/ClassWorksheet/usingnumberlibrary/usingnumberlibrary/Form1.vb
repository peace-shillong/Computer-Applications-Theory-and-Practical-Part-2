Imports System.Text.RegularExpressions
Public Class Form1
    Dim n As Integer
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrev.Click
        If txtnum.Text <> "" And Regex.IsMatch(txtnum.Text, "[^a-zA-Z]") = True Then
            n = CInt(txtnum.Text)
            Dim obj As New numberlibrary.Number(n)
            txt.Text = obj.reverse()
        End If
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtnum.Clear()
        txt.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSum.Click
        If txtnum.Text <> "" And Regex.IsMatch(txtnum.Text, "[^a-zA-Z]") = True Then
            n = CInt(txtnum.Text)
            Dim obj As New numberlibrary.Number(n)
            txt.Text = obj.sumDigits()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        If txtnum.Text <> "" And Regex.IsMatch(txtnum.Text, "[^a-zA-Z]") = True Then
            n = CInt(txtnum.Text)
            Dim obj As New numberlibrary.Number(n)
            txt.Text = obj.noOfDigits()
        End If
    End Sub
End Class
