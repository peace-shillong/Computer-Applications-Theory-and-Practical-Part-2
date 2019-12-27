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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnOK1 = New System.Windows.Forms.Button
        Me.txtC = New System.Windows.Forms.TextBox
        Me.txtR = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnOK2 = New System.Windows.Forms.Button
        Me.txtIn = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtSumDia = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtOut = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Row"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Column"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter Elements in row wise"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOK1)
        Me.GroupBox1.Controls.Add(Me.txtC)
        Me.GroupBox1.Controls.Add(Me.txtR)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 164)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Size of Array"
        '
        'btnOK1
        '
        Me.btnOK1.Location = New System.Drawing.Point(39, 135)
        Me.btnOK1.Name = "btnOK1"
        Me.btnOK1.Size = New System.Drawing.Size(75, 23)
        Me.btnOK1.TabIndex = 4
        Me.btnOK1.Text = "OK"
        Me.btnOK1.UseVisualStyleBackColor = True
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(76, 65)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(50, 20)
        Me.txtC.TabIndex = 3
        '
        'txtR
        '
        Me.txtR.Location = New System.Drawing.Point(76, 19)
        Me.txtR.Name = "txtR"
        Me.txtR.Size = New System.Drawing.Size(52, 20)
        Me.txtR.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnOK2)
        Me.GroupBox2.Controls.Add(Me.txtIn)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(186, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 176)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Insert To 2D Array"
        '
        'btnOK2
        '
        Me.btnOK2.Enabled = False
        Me.btnOK2.Location = New System.Drawing.Point(9, 148)
        Me.btnOK2.Name = "btnOK2"
        Me.btnOK2.Size = New System.Drawing.Size(114, 23)
        Me.btnOK2.TabIndex = 5
        Me.btnOK2.Text = "Show Output"
        Me.btnOK2.UseVisualStyleBackColor = True
        '
        'txtIn
        '
        Me.txtIn.Enabled = False
        Me.txtIn.Location = New System.Drawing.Point(7, 44)
        Me.txtIn.Multiline = True
        Me.txtIn.Name = "txtIn"
        Me.txtIn.Size = New System.Drawing.Size(119, 98)
        Me.txtIn.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSumDia)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtOut)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 194)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(326, 204)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OUTPUT"
        '
        'txtSumDia
        '
        Me.txtSumDia.Enabled = False
        Me.txtSumDia.Location = New System.Drawing.Point(193, 162)
        Me.txtSumDia.Name = "txtSumDia"
        Me.txtSumDia.Size = New System.Drawing.Size(100, 20)
        Me.txtSumDia.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "The Sum of the Diagonal Elements is"
        '
        'txtOut
        '
        Me.txtOut.Enabled = False
        Me.txtOut.Location = New System.Drawing.Point(7, 44)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(119, 98)
        Me.txtOut.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "The Matrix is "
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(138, 405)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "RESET"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 440)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "2D Array Program"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents txtR As System.Windows.Forms.TextBox
    Friend WithEvents btnOK1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOK2 As System.Windows.Forms.Button
    Friend WithEvents txtIn As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOut As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSumDia As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
