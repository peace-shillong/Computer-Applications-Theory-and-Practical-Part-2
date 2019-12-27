import java.sql.*;  
class OracleCon{  
public static void main(String args[]){  
try{  
//step1 load the driver class  
Class.forName("oracle.jdbc.driver.OracleDriver");  
  
//step2 create  the connection object  
Connection con=DriverManager.getConnection(  
"jdbc:oracle:thin:@localhost:1521:xe","system","system");  
  
//step3 create the statement object  
Statement stmt=con.createStatement( ResultSet.TYPE_FORWARD_ONLY,
    ResultSet.CONCUR_READ_ONLY );  
  
//step4 execute query  
ResultSet rs=stmt.executeQuery("Select * from emp");  
while(rs.next())  
System.out.println(rs.getInt("id")+"  "+rs.getString("name"));  
  
//step5 close the connection object  
con.close();  
  
}catch(Exception e){ System.out.println(e);}  
  
}  
}  