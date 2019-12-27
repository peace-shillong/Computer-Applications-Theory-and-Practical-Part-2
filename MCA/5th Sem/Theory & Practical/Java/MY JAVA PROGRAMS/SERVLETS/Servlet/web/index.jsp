<%-- 
    Document   : index
    Created on : 9 Nov, 2017, 1:27:25 PM
    Author     : kyrsh01
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
   "http://www.w3.org/TR/html4/loose.dtd">

<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>Hello World!</h1>
        <a href="/WebApplication/First" >First Servlet</a>
        <form method="POST" action="/Servlet/First">
            <table>
            <tr>
                <td>Name:</td>
             <td><input type="text" name="uname"/></td>
             </tr>
             <tr>
                <td>Phone:</td>
             <td><input type="text" name="ph"/></td>
             </tr>
             <tr>
                <td>Email:</td>
             <td><input type="text" name="email"/></td>
             </tr>
             <tr>
                <td>Gender:</td>
             <td><input type="radio" name="gender" value="Male"/>Male <input type="radio" name="gender" value="Female"/> Female</td>
             </tr>
             <tr>
                <td>Class:</td>
             <td><select name="class">
                     <option value="MCA">MCA</option>
                     <option value="BCA">BCA</option>
             </select>
             </td>
             </tr>
             <tr>
                <td></td>
             <td><input type="submit" name="s" value="Submit"/></td>
             </tr>
            </table>
        </form>
    </body>
</html>
