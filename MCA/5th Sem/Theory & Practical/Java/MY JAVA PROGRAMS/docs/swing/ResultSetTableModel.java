import java.sql.Connection;
 import java.sql.Statement;
 import java.sql.DriverManager;
 import java.sql.ResultSet;
 import java.sql.ResultSetMetaData;
 import java.sql.SQLException;
import javax.swing.table.AbstractTableModel;
public class ResultSetTableModel extends AbstractTableModel
{
private Connection connection;
private Statement statement;
private ResultSet resultSet;
private ResultSetMetaData metaData;
private int numberOfRows;
private boolean connectedToDatabase = false;
public ResultSetTableModel( String driver, String url, String username,
 String password, String query )
 throws SQLException, ClassNotFoundException
 {
 Class.forName( driver );