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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtArray = New System.Windows.Forms.TextBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNo = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnNext = New System.Windows.Forms.Button
        Me.Label_A = New System.Windows.Forms.Label
        Me.txtCol = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRow = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.sumr = New System.Windows.Forms.TextBox
        Me.suml = New System.Windows.Forms.TextBox
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.suml)
        Me.GroupBox3.Controls.Add(Me.sumr)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtArray)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 214)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(457, 165)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Output"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(325, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Matrix is"
        '
        'txtArray
        '
        Me.txtArray.Location = New System.Drawing.Point(113, 32)
        Me.txtArray.Multiline = True
        Me.txtArray.Name = "txtArray"
        Me.txtArray.Size = New System.Drawing.Size(144, 80)
        Me.txtArray.TabIndex = 5
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(325, 57)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter The column of the Array : "
        '
        'txtNo
        '
        Me.txtNo.Enabled = False
        Me.txtNo.Location = New System.Drawing.Point(167, 40)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(128, 20)
        Me.txtNo.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.txtNo)
        Me.GroupBox2.Controls.Add(Me.btnNext)
        Me.GroupBox2.Controls.Add(Me.Label_A)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(457, 100)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input Elements of Array"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 106)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(457, 100)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Input Elements of Array"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(167, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(325, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Next"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Enter Array  (0,0) : "
        '
        'btnNext
        '
        Me.btnNext.Enabled = False
        Me.btnNext.Location = New System.Drawing.Point(325, 35)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label_A
        '
        Me.Label_A.AutoSize = True
        Me.Label_A.Location = New System.Drawing.Point(19, 43)
        Me.Label_A.Name = "Label_A"
        Me.Label_A.Size = New System.Drawing.Size(95, 13)
        Me.Label_A.TabIndex = 1
        Me.Label_A.Text = "Enter Array  (0,0) : "
        '
        'txtCol
        '
        Me.txtCol.Location = New System.Drawing.Point(182, 60)
        Me.txtCol.Name = "txtCol"
        Me.txtCol.Size = New System.Drawing.Size(128, 20)
        Me.txtCol.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOK)
        Me.GroupBox1.Controls.Add(Me.txtCol)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRow)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Size of Array"
        '
        'txtRow
        '
        Me.txtRow.Location = New System.Drawing.Point(182, 30)
        Me.txtRow.Name = "txtRow"
        Me.txtRow.Size = New System.Drawing.Size(128, 20)
        Me.txtRow.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter The row of the Array : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sum of Right Diagonal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Sum of Left Diagonal"
        '
        'sumr
        '
        Me.sumr.Location = New System.Drawing.Point(141, 116)
        Me.sumr.Name = "sumr"
        Me.sumr.Size = New System.Drawing.Size(100, 20)
        Me.sumr.TabIndex = 9
        '
        'suml
        '
        Me.suml.Location = New System.Drawing.Point(141, 139)
        Me.suml.Name = "suml"
        Me.suml.Size = New System.Drawing.Size(100, 20)
        Me.suml.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 488)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Matrix Application"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtArray As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label_A As System.Windows.Forms.Label
    Friend WithEvents txtCol As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRow As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents suml As System.Windows.Forms.TextBox
    Friend WithEvents sumr As System.Windows.Forms.TextBox

End Class
