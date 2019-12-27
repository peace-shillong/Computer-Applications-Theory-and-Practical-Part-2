<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnOk = New System.Windows.Forms.Button
        Me.txtbx2 = New System.Windows.Forms.TextBox
        Me.txtbx1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbltxt = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(12, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(205, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(12, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "The result is"
        '
        'btnOk
        '
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.Location = New System.Drawing.Point(108, 113)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtbx2
        '
        Me.txtbx2.BackColor = System.Drawing.Color.White
        Me.txtbx2.ForeColor = System.Drawing.Color.Blue
        Me.txtbx2.Location = New System.Drawing.Point(158, 72)
        Me.txtbx2.Name = "txtbx2"
        Me.txtbx2.Size = New System.Drawing.Size(100, 20)
        Me.txtbx2.TabIndex = 1
        '
        'txtbx1
        '
        Me.txtbx1.BackColor = System.Drawing.Color.White
        Me.txtbx1.ForeColor = System.Drawing.Color.Blue
        Me.txtbx1.Location = New System.Drawing.Point(158, 23)
        Me.txtbx1.Name = "txtbx1"
        Me.txtbx1.Size = New System.Drawing.Size(100, 20)
        Me.txtbx1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter the send number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Enter the first number"
        '
        'lbltxt
        '
        Me.lbltxt.AutoSize = True
        Me.lbltxt.BackColor = System.Drawing.Color.White
        Me.lbltxt.ForeColor = System.Drawing.Color.Blue
        Me.lbltxt.Location = New System.Drawing.Point(155, 180)
        Me.lbltxt.Name = "lbltxt"
        Me.lbltxt.Size = New System.Drawing.Size(37, 13)
        Me.lbltxt.TabIndex = 13
        Me.lbltxt.Text = ".........."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(292, 268)
        Me.Controls.Add(Me.lbltxt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtbx2)
        Me.Controls.Add(Me.txtbx1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents txtbx2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbx1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbltxt As System.Windows.Forms.Label

End Class
