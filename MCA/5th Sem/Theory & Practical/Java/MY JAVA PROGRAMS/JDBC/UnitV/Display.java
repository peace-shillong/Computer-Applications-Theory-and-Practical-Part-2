import java.sql.*;

public class Display{
static final String JDBC_DRIVER="sun.jdbc.odbc.JdbcOdbcDriver";
static final String D_URL="jdbc:odbc:Library"; //stds is the system DSN

private Connection con;
private Statement st;
public Display()
{
try{

Class.forName(JDBC_DRIVER);


//loads the class for the database driver and returns the class object for the specified name
//throws ClassNotFoundException if the class loader cannot locate the driver class

con=DriverManager.getConnection(D_URL);
//using the loaded driver to establish the connection to the database 


st=con.createStatement();
//creates a statement object for sending SQL statements to the database

//ResultSet res=st.executeQuery("select FirstName, LastName, AuthorISBN.ISBN, Title from Authors inner join AuthorISBN on Authors.AuthorID=AuthorISBN.AuthorID order by Lastname, FirstName ");
ResultSet res=st.executeQuery("select FirstName, LastName, B.ISBN, Title from Author A, AuthorISBN B, Title T where A.AuthorID=B.AuthorID and T.ISBN=B.ISBN order by Lastname, FirstName ");

while(res.next())
{
    
    
    System.out.print(res.getString(1)+"\t" + res.getString(2)+"\t" + res.getString(3)+"\t"+ res.getString(4)+"\t");

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
    Display ft=new Display();
}
}
