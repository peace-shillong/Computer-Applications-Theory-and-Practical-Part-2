import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import javax.sql.rowset.JdbcRowSet;
import com.sun.rowset.JdbcRowSetImpl;
public class jdbcmain1
{
	public static void main(String args[])
	{

		
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
			JdbcRowSet rowSet = new JdbcRowSetImpl();
			rowSet.setUrl("jdbc:oracle:thin:@localhost:1521:xe");
			rowSet.setUsername("system");
			rowSet.setPassword("system");
			rowSet.setCommand("SELECT * FROM emp");
			rowSet.execute();
			ResultSetMetaData mData=rowSet.getMetaData();
			System.out.println("----------");
			int ncols=mData.getColumnCount();
			System.out.println("USERID \tUSERNAME");
			System.out.println("----------");
			//Display rows of emp
			while(rowSet.next())
			{
				 for ( int i = 1; i <= ncols; i++ )
				 System.out.printf( "%-8s", rowSet.getObject( i ));
				 System.out.println();
			 } //
			 rowSet.close();
			
		}
		catch(SQLException se)
		{
			se.printStackTrace();
		}
		
	}
}