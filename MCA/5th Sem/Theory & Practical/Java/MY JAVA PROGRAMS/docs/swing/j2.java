import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
 
public class j2
{
  /* static block is executed when a class is loaded into memory 
   * this block loads MySQL's JDBC driver
   */
  static
  {
    try
    {
      // loads com.mysql.jdbc.Driver into memory
      Class.forName("oracle.jdbc.driver.OracleDriver");
    } 
    catch (ClassNotFoundException cnf) 
    {
      System.out.println("Driver could not be loaded: " + cnf);
    }
  }
 
  public static void main(String[] args)
  {
    String connectionUrl = "jdbc:oracle:thin:@localhost:1521:xe";
    String dbUser = "system";
    String dbPwd = "system";
    Connection conn;
    ResultSet rs;
    String queryString = "SELECT * FROM emp";
 
    try
    {
      conn = DriverManager.getConnection(connectionUrl, dbUser, dbPwd);
      Statement stmt = conn.createStatement();
 
      // INSERT A RECORD
      stmt.executeUpdate("INSERT INTO emp VALUES (1,'Ribha')");
 
      // SELECT ALL RECORDS FROM EXPTABLE
      rs = stmt.executeQuery(queryString);
 
      System.out.println("ID \tNAME");
      System.out.println("============");
      while(rs.next())
      {
        System.out.println("HEllo");
		System.out.print(rs.getInt("ID") + ".\t" + rs.getString("NAME"));
        System.out.println();
      }
      if (conn != null)
      {
        conn.close();
        conn = null;
      }
    }
    catch (SQLException sqle) 
    {
      System.out.println("SQL Exception thrown: " + sqle);
    }
  }
} //JDBC_Connection_Demo ends here