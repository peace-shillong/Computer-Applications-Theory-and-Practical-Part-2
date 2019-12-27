Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service
     Inherits System.Web.Services.WebService


    <WebMethod()> _
   Public Function Count_Vowels(ByVal str As String) As Integer
        Dim count As Integer = 0
        Dim size As Integer = 0
        size = str.Length
        str = str.ToUpper()
        For i = 0 To size - 1
            Select Case str(i)
                Case "A", "E", "I", "O", "U"
                    count += 1
            End Select
        Next i
        Return count
    End Function
End Class
