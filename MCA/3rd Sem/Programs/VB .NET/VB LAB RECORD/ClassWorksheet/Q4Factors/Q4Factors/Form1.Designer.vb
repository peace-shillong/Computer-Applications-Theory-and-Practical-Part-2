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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblPNo = New System.Windows.Forms.Label
        Me.LblANo = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblPrime = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(131, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Find"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter A  Number: "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(131, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(108, 19)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(180, 66)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Factors are"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(236, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPrime)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblPNo)
        Me.GroupBox1.Controls.Add(Me.LblANo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 198)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Output"
        '
        'lblPNo
        '
        Me.lblPNo.AutoSize = True
        Me.lblPNo.Location = New System.Drawing.Point(133, 165)
        Me.lblPNo.Name = "lblPNo"
        Me.lblPNo.Size = New System.Drawing.Size(10, 13)
        Me.lblPNo.TabIndex = 8
        Me.lblPNo.Text = " "
        '
        'LblANo
        '
        Me.LblANo.AutoSize = True
        Me.LblANo.Location = New System.Drawing.Point(130, 131)
        Me.LblANo.Name = "LblANo"
        Me.LblANo.Size = New System.Drawing.Size(10, 13)
        Me.LblANo.TabIndex = 7
        Me.LblANo.Text = " "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Perfect Number : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Abundant Number :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Prime Number : "
        '
        'lblPrime
        '
        Me.lblPrime.AutoSize = True
        Me.lblPrime.Location = New System.Drawing.Point(113, 100)
        Me.lblPrime.Name = "lblPrime"
        Me.lblPrime.Size = New System.Drawing.Size(0, 13)
        Me.lblPrime.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 321)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Application to Find Factors OF A Number"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPNo As System.Windows.Forms.Label
    Friend WithEvents LblANo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPrime As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
