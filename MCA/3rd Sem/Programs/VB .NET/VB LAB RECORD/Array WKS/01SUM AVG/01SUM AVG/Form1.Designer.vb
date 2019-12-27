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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAvg = New System.Windows.Forms.TextBox
        Me.txtSum = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtArray = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSize = New System.Windows.Forms.TextBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNo = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnNext = New System.Windows.Forms.Button
        Me.Label_A = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtAvg)
        Me.GroupBox3.Controls.Add(Me.txtSum)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtArray)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 224)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(457, 180)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Output"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Average of the elements : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Sum of the elements : "
        '
        'txtAvg
        '
        Me.txtAvg.Enabled = False
        Me.txtAvg.Location = New System.Drawing.Point(150, 145)
        Me.txtAvg.Name = "txtAvg"
        Me.txtAvg.Size = New System.Drawing.Size(128, 20)
        Me.txtAvg.TabIndex = 7
        '
        'txtSum
        '
        Me.txtSum.Enabled = False
        Me.txtSum.Location = New System.Drawing.Point(150, 119)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.Size = New System.Drawing.Size(128, 20)
        Me.txtSum.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(376, 151)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSize)
        Me.GroupBox1.Controls.Add(Me.btnOK)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 132)
        Me.GroupBox1.TabIndex = 2
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
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(325, 25)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(457, 132)
        Me.GroupBox2.TabIndex = 3
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 427)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "SUM AND AVERAGE OF ARRAY"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAvg As System.Windows.Forms.TextBox
    Friend WithEvents txtSum As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtArray As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label_A As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
