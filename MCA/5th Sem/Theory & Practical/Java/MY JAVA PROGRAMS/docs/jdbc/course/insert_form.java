import java.sql.*;
import sun.jdbc.odbc.*;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class insert_form extends JFrame implements ActionListener
{
	JLabel lb1;
	JLabel lb2;
	JLabel lb3;
	JLabel lb5;
	
	JTextField tx1;
	JTextField tx2;
	JTextField tx3;
	JButton b1;
	
	public insert_form()
	{
		super("Course Information.");
		JFrame p=new JFrame();
		p.setLayout(new FlowLayout(FlowLayout.LEFT));
		p.setSize(500,600);
		p.setVisible(true);
		p.setDefaultCloseOperation(this.DISPOSE_ON_CLOSE);
		
		lb1=new JLabel("Course Name:");
		lb2=new JLabel("Course Credits:");
		lb3=new JLabel("Course Hours:");
		lb5=new JLabel("                                              ");
		tx1=new JTextField(20);
		tx2=new JTextField(10);
		tx3=new JTextField(10);
		b1=new JButton("INSERT");
		
		
		p.add(lb1);
		p.add(tx1);
		p.add(lb5);
		p.add(lb2);
		p.add(tx2);
		
		p.add(lb3);
		p.add(tx3);
		
		
		p.add(b1);
		
		b1.addActionListener(this);
	}
	public void actionPerformed(ActionEvent ae)
	{
		String user="";
		String paswd="";
		String myDb="jdbc:odbc:course1";
		Connection con;
		String c_name=tx1.getText();
		if (!c_name.matches("[a-zA-Z]+$")){
		JOptionPane.showConfirmDialog(null, "Please enter string only", "Error", JOptionPane.CANCEL_OPTION);
		}
		try
		{
			Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
			con=DriverManager.getConnection(myDb,user,paswd);
			Statement stmt=con.createStatement();
			
			
			
			int c_credit=Integer.parseInt(tx2.getText());
			int c_hour=Integer.parseInt(tx3.getText());
			String query="insert into course1(cname,credit,hr) values('"+c_name+"','"+c_credit+"','"+c_hour+"')";
			stmt.executeUpdate(query);
			JOptionPane.showMessageDialog(null, "Data inserted", "Congrats", JOptionPane.CANCEL_OPTION);
			con.close();
		}catch(NumberFormatException ne){
		JOptionPane.showConfirmDialog(null, "Please enter numbers only", "Error", JOptionPane.CANCEL_OPTION);
		}
		catch(Exception e)
		{
			System.out.println(e.getMessage());
		}
	}
	public static void main(String args[])
	{
		new insert_form();
	}
}
