import java.sql.*;

public class DisplayDetails{
static final String JDBC_DRIVER="sun.jdbc.odbc.JdbcOdbcDriver";
static final String D_URL="jdbc:odbc:library"; //books is the system DSN

private Connection con;
private Statement st;
public DisplayDetails()
{
try{

Class.forName(JDBC_DRIVER);


//loads the class for the database driver and returns the class object for the specified name
//throws ClassNotFoundException if the class loader cannot locate the driver class

con=DriverManager.getConnection(D_URL);
//using the loaded driver to establish the connection to the database 


st=con.createStatement();
//creates a statement object for sending SQL statements to the database

ResultSet res=st.executeQuery("select * from Titles");
ResultSetMetaData metaData=res.getMetaData();
int n=metaData.getColumnCount();

for(int i=1;i<=n;i++)
    System.out.print(metaData.getColumnName(i)+"\t");

System.out.println();
//initially the cursor is before the first row

while(res.next())
{
    
    for(int i=1;i<=n;i++)
        System.out.print(res.getObject(i)+"\t");

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
    st.close();
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
    DisplayDetails ft=new DisplayDetails();
}
}
