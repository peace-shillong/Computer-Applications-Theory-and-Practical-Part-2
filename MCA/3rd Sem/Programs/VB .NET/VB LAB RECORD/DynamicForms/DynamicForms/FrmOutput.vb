Public Class FrmOutput

    Private Sub FrmOutput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim label As New System.Windows.Forms.Label
        Dim txtbox1 As New System.Windows.Forms.TextBox
        Dim txtbox2 As New System.Windows.Forms.TextBox

        If Form1.flag = 0 Then
            With label
                .Text = "The Roots are equal"
                .Left = 30
                .Top = 30
            End With
            Me.Controls.Add(label)

            Me.Text = "Equal Roots"

            With txtbox1
                .Text = Form1.root
                .Top = 70
                .Left = 30
            End With
            With txtbox2
                .Text = Form1.root2
                .Top = 90
                .Left = 30
            End With

            Me.Controls.Add(txtbox1)
            Me.Controls.Add(txtbox2)
        ElseIf Form1.flag = 1 Then
            With label
                .Text = "The Roots are Real :"
                .Left = 30
                .Top = 30
            End With

            Me.Controls.Add(label)

            Me.Text = "Real Roots"

            With txtbox1
                .Text = Form1.root
                .Top = 70
                .Left = 30
            End With
            With txtbox2
                .Text = Form1.root2
                .Top = 90
                .Left = 30
            End With

            Me.Controls.Add(txtbox1)
            Me.Controls.Add(txtbox2)

        Else
            With label
                .Text = "Imaginary roots"
                .Left = 20
                .Top = 30
            End With
            Me.Controls.Add(label)
            Me.Text = "Imaginary Roots"
        End If
    End Sub
End Class