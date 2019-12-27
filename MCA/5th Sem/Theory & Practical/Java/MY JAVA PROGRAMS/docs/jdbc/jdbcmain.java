import java.sql.DriverManager;
import java.sql.Connection;
import java.sql.Statement;
import java.sql.SQLException;
import java.sql.ResultSet;
public class jdbcmain
{
	public static void main(String args[])
	{
		Connection con=null;
		Statement stmt=null;
		ResultSet rs=null;
		
		try
		{
			//Register or load the driver
			Class.forName("oracle.jdbc.driver.OracleDriver");	
		}
		catch (ClassNotFoundException ce) 
		{
				System.out.println("Driver could not be loaded: " + ce);
		}
		try
		{
			//create connection to the database. Here, database xe
			con=DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:xe","system","system");
			//create query statement
			stmt=con.createStatement();
			//Select query
			rs=stmt.executeQuery("SELECT * FROM user");
			System.out.println("----------");
			System.out.println("USERID \tUSERNAME");
			System.out.println("----------");
			//Display rows of emp
			while(rs.next())
			{
				System.out.println(rs.getInt(1)+".\t"+rs.getString(2));
			}
			
		}
		catch(SQLException se)
		{
			se.printStackTrace();
		}
		finally
		{
			if(con!=null)
			{
				try
				{
					rs.close();
					stmt.close();
					con.close();
				} 
				catch ( Exception exception )
				{
					exception.printStackTrace();
				} 
			}
		}
	}
}