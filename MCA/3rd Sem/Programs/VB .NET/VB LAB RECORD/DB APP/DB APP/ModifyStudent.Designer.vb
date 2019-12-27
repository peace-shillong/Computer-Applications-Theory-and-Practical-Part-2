<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyStudent
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
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtDOJ = New System.Windows.Forms.TextBox
        Me.txtDOB = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DisplayBtn = New System.Windows.Forms.Button
        Me.CBRno = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(234, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtDOJ
        '
        Me.txtDOJ.Location = New System.Drawing.Point(116, 164)
        Me.txtDOJ.Name = "txtDOJ"
        Me.txtDOJ.Size = New System.Drawing.Size(100, 20)
        Me.txtDOJ.TabIndex = 8
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(116, 121)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(100, 20)
        Me.txtDOB.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(29, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DisplayBtn)
        Me.GroupBox1.Controls.Add(Me.CBRno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Record"
        '
        'DisplayBtn
        '
        Me.DisplayBtn.Enabled = False
        Me.DisplayBtn.Location = New System.Drawing.Point(29, 71)
        Me.DisplayBtn.Name = "DisplayBtn"
        Me.DisplayBtn.Size = New System.Drawing.Size(75, 23)
        Me.DisplayBtn.TabIndex = 2
        Me.DisplayBtn.Text = "Display"
        Me.DisplayBtn.UseVisualStyleBackColor = True
        '
        'CBRno
        '
        Me.CBRno.FormattingEnabled = True
        Me.CBRno.Location = New System.Drawing.Point(133, 17)
        Me.CBRno.Name = "CBRno"
        Me.CBRno.Size = New System.Drawing.Size(121, 21)
        Me.CBRno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Roll Number "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(116, 56)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(179, 20)
        Me.txtName.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Date of Joining"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "DOB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txtDOJ)
        Me.GroupBox2.Controls.Add(Me.txtDOB)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 229)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Record Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Student ID"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(116, 20)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 11
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(116, 85)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(195, 85)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton2.TabIndex = 13
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'ModifyStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 353)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ModifyStudent"
        Me.Text = "ModifyStudent"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtDOJ As System.Windows.Forms.TextBox
    Friend WithEvents txtDOB As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DisplayBtn As System.Windows.Forms.Button
    Friend WithEvents CBRno As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
