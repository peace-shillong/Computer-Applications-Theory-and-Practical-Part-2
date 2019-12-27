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
        Me.txtFact = New System.Windows.Forms.TextBox
        Me.btnFind = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFact
        '
        Me.txtFact.Location = New System.Drawing.Point(122, 37)
        Me.txtFact.Name = "txtFact"
        Me.txtFact.Size = New System.Drawing.Size(139, 20)
        Me.txtFact.TabIndex = 3
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(29, 102)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(150, 23)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "Find Factorial"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(166, 102)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(15, 102)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtFact)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(312, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(299, 259)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output Section"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "The Factorial is : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFind)
        Me.GroupBox1.Controls.Add(Me.txtNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 259)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Section"
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(123, 38)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(139, 20)
        Me.txtNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a Number : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 302)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Factorial"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFact As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
