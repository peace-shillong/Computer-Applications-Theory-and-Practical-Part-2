<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAllStudents
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
        Me.DGVS = New System.Windows.Forms.DataGridView
        CType(Me.DGVS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVS
        '
        Me.DGVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVS.Location = New System.Drawing.Point(0, 0)
        Me.DGVS.Name = "DGVS"
        Me.DGVS.Size = New System.Drawing.Size(371, 309)
        Me.DGVS.TabIndex = 0
        '
        'ViewAllStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 309)
        Me.Controls.Add(Me.DGVS)
        Me.Name = "ViewAllStudents"
        Me.Text = "ViewAllStudents"
        CType(Me.DGVS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVS As System.Windows.Forms.DataGridView
End Class
