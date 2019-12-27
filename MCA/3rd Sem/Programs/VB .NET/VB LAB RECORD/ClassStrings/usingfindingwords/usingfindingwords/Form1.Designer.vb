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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnfindword = New System.Windows.Forms.Button
        Me.txtsentence = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lstwords = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnfindword)
        Me.GroupBox1.Controls.Add(Me.txtsentence)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(222, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnfindword
        '
        Me.btnfindword.Location = New System.Drawing.Point(19, 58)
        Me.btnfindword.Name = "btnfindword"
        Me.btnfindword.Size = New System.Drawing.Size(91, 22)
        Me.btnfindword.TabIndex = 2
        Me.btnfindword.Text = "OK"
        Me.btnfindword.UseVisualStyleBackColor = True
        '
        'txtsentence
        '
        Me.txtsentence.Location = New System.Drawing.Point(19, 32)
        Me.txtsentence.Name = "txtsentence"
        Me.txtsentence.Size = New System.Drawing.Size(278, 20)
        Me.txtsentence.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter the sentence"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstwords)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 154)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OUTPUT"
        '
        'lstwords
        '
        Me.lstwords.FormattingEnabled = True
        Me.lstwords.Location = New System.Drawing.Point(6, 19)
        Me.lstwords.Name = "lstwords"
        Me.lstwords.Size = New System.Drawing.Size(291, 134)
        Me.lstwords.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 284)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "APP"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnfindword As System.Windows.Forms.Button
    Friend WithEvents txtsentence As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstwords As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
