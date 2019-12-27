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
        Me.btnrev = New System.Windows.Forms.Button
        Me.txtnum = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt = New System.Windows.Forms.TextBox
        Me.btnclear = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnNo = New System.Windows.Forms.Button
        Me.btnSum = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number"
        '
        'btnrev
        '
        Me.btnrev.Location = New System.Drawing.Point(6, 20)
        Me.btnrev.Name = "btnrev"
        Me.btnrev.Size = New System.Drawing.Size(75, 44)
        Me.btnrev.TabIndex = 1
        Me.btnrev.Text = "Find Reverse"
        Me.btnrev.UseVisualStyleBackColor = True
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(110, 45)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(107, 20)
        Me.txtnum.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Result"
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(110, 110)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(107, 20)
        Me.txt.TabIndex = 4
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(97, 87)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 44)
        Me.btnclear.TabIndex = 5
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNo)
        Me.GroupBox1.Controls.Add(Me.btnSum)
        Me.GroupBox1.Controls.Add(Me.btnclear)
        Me.GroupBox1.Controls.Add(Me.btnrev)
        Me.GroupBox1.Location = New System.Drawing.Point(242, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 141)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actions"
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(6, 87)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 44)
        Me.btnNo.TabIndex = 7
        Me.btnNo.Text = "Find Number of Digits"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(97, 19)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(75, 44)
        Me.btnSum.TabIndex = 6
        Me.btnSum.Text = "Find Sum of Digits"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(435, 187)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "APLLICATION ON NUMBER"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnrev As System.Windows.Forms.Button
    Friend WithEvents txtnum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt As System.Windows.Forms.TextBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents btnSum As System.Windows.Forms.Button

End Class
