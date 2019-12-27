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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnOK1 = New System.Windows.Forms.Button
        Me.txtCol = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRow = New System.Windows.Forms.TextBox
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
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtArray)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 224)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(457, 136)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Output"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(325, 100)
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
        Me.txtArray.Size = New System.Drawing.Size(144, 80)
        Me.txtArray.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOK1)
        Me.GroupBox1.Controls.Add(Me.txtCol)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRow)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Size of Array"
        '
        'btnOK1
        '
        Me.btnOK1.Location = New System.Drawing.Point(325, 57)
        Me.btnOK1.Name = "btnOK1"
        Me.btnOK1.Size = New System.Drawing.Size(75, 23)
        Me.btnOK1.TabIndex = 5
        Me.btnOK1.Text = "OK"
        Me.btnOK1.UseVisualStyleBackColor = True
        '
        'txtCol
        '
        Me.txtCol.Location = New System.Drawing.Point(182, 60)
        Me.txtCol.Name = "txtCol"
        Me.txtCol.Size = New System.Drawing.Size(128, 20)
        Me.txtCol.TabIndex = 4
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
        Me.GroupBox2.Size = New System.Drawing.Size(457, 100)
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
        Me.Label_A.Size = New System.Drawing.Size(95, 13)
        Me.Label_A.TabIndex = 1
        Me.Label_A.Text = "Enter Array  (0,0) : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 384)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "2D Array"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtArray As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRow As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label_A As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOK1 As System.Windows.Forms.Button
    Friend WithEvents txtCol As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
