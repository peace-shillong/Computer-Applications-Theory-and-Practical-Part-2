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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtin = New System.Windows.Forms.TextBox
        Me.btnFind = New System.Windows.Forms.Button
        Me.box = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLong = New System.Windows.Forms.TextBox
        Me.txtShort = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.box.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFind)
        Me.GroupBox1.Controls.Add(Me.txtin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Sentence : "
        '
        'txtin
        '
        Me.txtin.Location = New System.Drawing.Point(6, 36)
        Me.txtin.Name = "txtin"
        Me.txtin.Size = New System.Drawing.Size(255, 20)
        Me.txtin.TabIndex = 1
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(92, 76)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'box
        '
        Me.box.Controls.Add(Me.txtShort)
        Me.box.Controls.Add(Me.txtLong)
        Me.box.Controls.Add(Me.Label3)
        Me.box.Controls.Add(Me.Label2)
        Me.box.Location = New System.Drawing.Point(13, 138)
        Me.box.Name = "box"
        Me.box.Size = New System.Drawing.Size(267, 116)
        Me.box.TabIndex = 1
        Me.box.TabStop = False
        Me.box.Text = "OUTPUT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "The Longest Word is : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "The Shortest Word is : "
        '
        'txtLong
        '
        Me.txtLong.Location = New System.Drawing.Point(132, 20)
        Me.txtLong.Name = "txtLong"
        Me.txtLong.Size = New System.Drawing.Size(129, 20)
        Me.txtLong.TabIndex = 2
        '
        'txtShort
        '
        Me.txtShort.Location = New System.Drawing.Point(132, 60)
        Me.txtShort.Name = "txtShort"
        Me.txtShort.Size = New System.Drawing.Size(129, 20)
        Me.txtShort.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.box)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "App To Find Longest and Shortest Word"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.box.ResumeLayout(False)
        Me.box.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents txtin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents box As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtShort As System.Windows.Forms.TextBox
    Friend WithEvents txtLong As System.Windows.Forms.TextBox

End Class
