<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtdob = New System.Windows.Forms.TextBox
        Me.txtid = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtrl = New System.Windows.Forms.TextBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.txtdoj = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ADD = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "S NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ROLL NO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "GENDER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DOB"
        '
        'txtdob
        '
        Me.txtdob.Location = New System.Drawing.Point(128, 268)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(100, 20)
        Me.txtdob.TabIndex = 6
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(128, 106)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 7
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(128, 142)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 8
        '
        'txtrl
        '
        Me.txtrl.Location = New System.Drawing.Point(128, 186)
        Me.txtrl.Name = "txtrl"
        Me.txtrl.Size = New System.Drawing.Size(100, 20)
        Me.txtrl.TabIndex = 9
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(128, 233)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "MALE"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(262, 233)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(67, 17)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "FEMALE"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'txtdoj
        '
        Me.txtdoj.Location = New System.Drawing.Point(128, 305)
        Me.txtdoj.Name = "txtdoj"
        Me.txtdoj.Size = New System.Drawing.Size(100, 20)
        Me.txtdoj.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "DOJ"
        '
        'ADD
        '
        Me.ADD.Location = New System.Drawing.Point(160, 391)
        Me.ADD.Name = "ADD"
        Me.ADD.Size = New System.Drawing.Size(75, 23)
        Me.ADD.TabIndex = 14
        Me.ADD.Text = "ADD"
        Me.ADD.UseVisualStyleBackColor = True
        '
        'AddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 435)
        Me.Controls.Add(Me.ADD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtdoj)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.txtrl)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txtdob)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddStudent"
        Me.Text = "AddStudent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdob As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtrl As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtdoj As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ADD As System.Windows.Forms.Button
End Class
