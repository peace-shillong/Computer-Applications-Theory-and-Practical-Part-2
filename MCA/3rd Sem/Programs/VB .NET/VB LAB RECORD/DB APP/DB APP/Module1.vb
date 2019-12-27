Imports System.Data.OleDb

Module Module1
    Dim conn As New OleDbConnection ' Connection Object
    Dim cmd, cmdC, cmdJ As New OleDbCommand

    Public da As New OleDbDataAdapter  ' For Student
    Public daC, daJ As New OleDbDataAdapter ' For Courses
    Public ds As New DataSet("MyStudent")


    Public Sub ConnectDB()
        'Connection
        conn.ConnectionString = "PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=StudentManagement.accdb"
        conn.Open()

        cmd.CommandText = "Select * from Student"
        cmd.Connection = conn

        'data
        da.SelectCommand = cmd
        da.Fill(ds, "Student") 'Fill DataSet 

        cmdC.CommandText = "Select * from Courses"
        cmdC.Connection = conn

        'data
        daC.SelectCommand = cmdC
        daC.Fill(ds, "Courses") 'Fill DataSet 
        'joingin tables and bringing data into one single table
        cmdJ.CommandText = "Select S.StudentID,StudentName,Gender,c.CourseID,CourseName From Student S, Courses c,Student_Course sc Where S.StudentID=sc.StudentID and C.CourseID=sc.CourseID"
        cmdJ.Connection = conn
        daJ.SelectCommand = cmdJ
        daJ.Fill(ds, "Enrollment")

    End Sub

    Public Sub Update(ByVal dt As DataTable)
        Dim obj As New OleDbCommandBuilder(da)
        Dim Table_With_ONLY_Changes As DataTable

        Table_With_ONLY_Changes = dt.GetChanges
        dt.AcceptChanges() ' We make a commit in the dt after getting the changes to the db
        da.Update(Table_With_ONLY_Changes)
    End Sub

    Public Sub UpdateC(ByVal dt As DataTable, ByVal da As OleDbDataAdapter)
        Dim obj As New OleDbCommandBuilder(da)
        Dim Table_New As DataTable

        Table_New = dt.GetChanges
        dt.AcceptChanges()
        da.Update(Table_New)
    End Sub

End Module
