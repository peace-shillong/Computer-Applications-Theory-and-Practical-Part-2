<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCourse
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
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtNm = New System.Windows.Forms.TextBox
        Me.txtD = New System.Windows.Forms.TextBox
        Me.txtF = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Course Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Course Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Duration"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fees"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(127, 72)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 5
        '
        'txtNm
        '
        Me.txtNm.Location = New System.Drawing.Point(127, 116)
        Me.txtNm.Name = "txtNm"
        Me.txtNm.Size = New System.Drawing.Size(100, 20)
        Me.txtNm.TabIndex = 6
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(127, 155)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(100, 20)
        Me.txtD.TabIndex = 7
        '
        'txtF
        '
        Me.txtF.Location = New System.Drawing.Point(127, 200)
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(100, 20)
        Me.txtF.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(127, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(225, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AddCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 321)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtNm)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddCourse"
        Me.Text = "AddCourse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtNm As System.Windows.Forms.TextBox
    Friend WithEvents txtD As System.Windows.Forms.TextBox
    Friend WithEvents txtF As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
