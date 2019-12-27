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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModifyExistingRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveRecordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewRecordsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CoursesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchAStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem, Me.CoursesToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewStudentToolStripMenuItem, Me.ModifyToolStripMenuItem, Me.RemoveRecordToolStripMenuItem, Me.ViewRecordsToolStripMenuItem})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.StudentToolStripMenuItem.Text = "File"
        '
        'AddNewStudentToolStripMenuItem
        '
        Me.AddNewStudentToolStripMenuItem.Name = "AddNewStudentToolStripMenuItem"
        Me.AddNewStudentToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AddNewStudentToolStripMenuItem.Text = "Add New Entry"
        '
        'ModifyToolStripMenuItem
        '
        Me.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem"
        Me.ModifyToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ModifyToolStripMenuItem.Text = "Modify Existing Record"
        '
        'RemoveRecordToolStripMenuItem
        '
        Me.RemoveRecordToolStripMenuItem.Name = "RemoveRecordToolStripMenuItem"
        Me.RemoveRecordToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.RemoveRecordToolStripMenuItem.Text = "Remove Record"
        '
        'ViewRecordsToolStripMenuItem
        '
        Me.ViewRecordsToolStripMenuItem.Name = "ViewRecordsToolStripMenuItem"
        Me.ViewRecordsToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ViewRecordsToolStripMenuItem.Text = "View All Records"
        '
        'CoursesToolStripMenuItem
        '
        Me.CoursesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewCourseToolStripMenuItem, Me.ModifyExistingRecordToolStripMenuItem, Me.RemoveRecordToolStripMenuItem1, Me.ViewRecordsToolStripMenuItem1})
        Me.CoursesToolStripMenuItem.Name = "CoursesToolStripMenuItem"
        Me.CoursesToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.CoursesToolStripMenuItem.Text = "Courses"
        '
        'AddNewCourseToolStripMenuItem
        '
        Me.AddNewCourseToolStripMenuItem.Name = "AddNewCourseToolStripMenuItem"
        Me.AddNewCourseToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AddNewCourseToolStripMenuItem.Text = "Add New Course"
        '
        'ModifyExistingRecordToolStripMenuItem
        '
        Me.ModifyExistingRecordToolStripMenuItem.Name = "ModifyExistingRecordToolStripMenuItem"
        Me.ModifyExistingRecordToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ModifyExistingRecordToolStripMenuItem.Text = "Modify Existing Record"
        '
        'RemoveRecordToolStripMenuItem1
        '
        Me.RemoveRecordToolStripMenuItem1.Name = "RemoveRecordToolStripMenuItem1"
        Me.RemoveRecordToolStripMenuItem1.Size = New System.Drawing.Size(194, 22)
        Me.RemoveRecordToolStripMenuItem1.Text = "Remove Record"
        '
        'ViewRecordsToolStripMenuItem1
        '
        Me.ViewRecordsToolStripMenuItem1.Name = "ViewRecordsToolStripMenuItem1"
        Me.ViewRecordsToolStripMenuItem1.Size = New System.Drawing.Size(194, 22)
        Me.ViewRecordsToolStripMenuItem1.Text = "View Records"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoursesToolStripMenuItem1, Me.SearchAStudentToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'CoursesToolStripMenuItem1
        '
        Me.CoursesToolStripMenuItem1.Name = "CoursesToolStripMenuItem1"
        Me.CoursesToolStripMenuItem1.Size = New System.Drawing.Size(194, 22)
        Me.CoursesToolStripMenuItem1.Text = "Enrollment of Students"
        '
        'SearchAStudentToolStripMenuItem
        '
        Me.SearchAStudentToolStripMenuItem.Name = "SearchAStudentToolStripMenuItem"
        Me.SearchAStudentToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.SearchAStudentToolStripMenuItem.Text = "Search a Student"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "DB APP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoursesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewCourseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyExistingRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveRecordToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewRecordsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoursesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchAStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
