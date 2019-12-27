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
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLar = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtArray = New System.Windows.Forms.TextBox
        Me.txtNo = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnNext = New System.Windows.Forms.Button
        Me.Label_A = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSize = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSrch = New System.Windows.Forms.TextBox
        Me.btnFind = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtLar)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtArray)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 286)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(457, 180)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Output"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "The entered element is "
        '
        'txtLar
        '
        Me.txtLar.Enabled = False
        Me.txtLar.Location = New System.Drawing.Point(149, 121)
        Me.txtLar.Name = "txtLar"
        Me.txtLar.Size = New System.Drawing.Size(128, 20)
        Me.txtLar.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(376, 126)
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
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Array  is :"
        '
        'txtArray
        '
        Me.txtArray.Location = New System.Drawing.Point(113, 32)
        Me.txtArray.Multiline = True
        Me.txtArray.Name = "txtArray"
        Me.txtArray.Size = New System.Drawing.Size(234, 64)
        Me.txtArray.TabIndex = 5
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
        Me.GroupBox2.Controls.Add(Me.txtNo)
        Me.GroupBox2.Controls.Add(Me.btnNext)
        Me.GroupBox2.Controls.Add(Me.Label_A)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(457, 73)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input Elements of Array"
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
        Me.Label_A.Size = New System.Drawing.Size(86, 13)
        Me.Label_A.TabIndex = 1
        Me.Label_A.Text = "Enter Array  (0) : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter The size of the Array : "
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(325, 25)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSize)
        Me.GroupBox1.Controls.Add(Me.btnOK)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 83)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Size of Array"
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(167, 30)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(128, 20)
        Me.txtSize.TabIndex = 2
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.txtSrch)
        Me.GroupBox5.Controls.Add(Me.btnFind)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 180)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(457, 100)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Input Elements to Search in Array"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Controls.Add(Me.Button3)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 106)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(457, 100)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Input Elements of Array"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(167, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(325, 35)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Enter Array  (0,0) : "
        '
        'txtSrch
        '
        Me.txtSrch.Enabled = False
        Me.txtSrch.Location = New System.Drawing.Point(167, 40)
        Me.txtSrch.Name = "txtSrch"
        Me.txtSrch.Size = New System.Drawing.Size(128, 20)
        Me.txtSrch.TabIndex = 4
        '
        'btnFind
        '
        Me.btnFind.Enabled = False
        Me.btnFind.Location = New System.Drawing.Point(325, 35)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 3
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Enter Element  : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 467)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Find Largest And Smallest in Array"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLar As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtArray As System.Windows.Forms.TextBox
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label_A As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSrch As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
