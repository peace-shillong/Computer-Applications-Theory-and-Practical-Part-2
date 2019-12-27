import java.sql.*;

class InsertData
{
public static void main(String args[]) throws Exception
{
	Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
	Connection con=DriverManager.getConnection("jdbc:odbc:library");
	Statement st=con.createStatement();
	String s="insert into Authors values('6','"+fname +"','Liang')";
	st.executeUpdate(s);

	st.close();
	con.close();
}
}

