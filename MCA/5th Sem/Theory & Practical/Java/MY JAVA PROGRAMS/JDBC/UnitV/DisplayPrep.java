import java.sql.*;

public class DisplayPrep{
static final String JDBC_DRIVER="sun.jdbc.odbc.JdbcOdbcDriver";
static final String D_URL="jdbc:odbc:library"; //stds is the system DSN

private Connection con;
private PreparedStatement ps;
public DisplayPrep()
{
try{

Class.forName(JDBC_DRIVER);


//loads the class for the database driver and returns the class object for the specified name
//throws ClassNotFoundException if the class loader cannot locate the driver class

con=DriverManager.getConnection(D_URL);
//using the loaded driver to establish the connection to the database 



ps=con.prepareStatement("select * from Authors where Lastname=? and FirstName=?");

ps.setString(1,"Liang");
ps.setString(2,"Daniel");
ResultSet res=ps.executeQuery();

while(res.next())
{
    
    
    System.out.print(res.getString(1)+"\t" + res.getString(2)+"\t" + res.getString(3)+"\t");

    System.out.println();
}
}
catch(SQLException sqle)
{
    System.out.println("exception "+sqle.getMessage());
    System.exit(0);
}
catch(ClassNotFoundException clse)
{
    System.out.println("exception "+clse.getMessage());
    System.exit(0);
}
finally
{
    try{
      con.close();
    }
    catch(SQLException sqle)
    {
    	System.out.println("exception "+sqle.getMessage());
    	System.exit(0);
    }
}
}

public static void main(String args[])
{
    Display ft=new Display();
}
}
