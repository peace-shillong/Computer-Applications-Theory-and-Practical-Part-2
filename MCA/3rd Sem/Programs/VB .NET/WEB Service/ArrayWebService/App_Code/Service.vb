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
    Public Function FactorsOfNo(ByVal no As Integer) As Integer()
        Dim factors(0), j As Integer
        Dim size As Integer = 0
        j = 0
        For i = 1 To no
            If no Mod i = 0 Then
                ReDim Preserve factors(size)
                factors(j) = i
                j += 1
                size += 1
            End If
        Next i
        Return factors
    End Function

End Class
