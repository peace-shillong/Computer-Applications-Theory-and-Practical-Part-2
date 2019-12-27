import java.sql.*;
import sun.jdbc.odbc.*;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class delete_form extends JFrame implements ActionListener
{
	JLabel lb1;
	JLabel lb2;
	JLabel lb3;
	JLabel lb4;
	JLabel lb5;
	JLabel lb6;
	JLabel lb7;
	JTextField tx1;
	JTextField tx2;
	JTextField tx3;
	JTextField tx4;
	

	JButton b1;
	JButton b2;
	public delete_form()
	{
		super("Course Information.");
		JFrame p=new JFrame();
		p.setLayout(new FlowLayout(FlowLayout.LEFT));
		p.setSize(400,500);
		p.setVisible(true);
		p.setDefaultCloseOperation(this.DISPOSE_ON_CLOSE);
		
		
		lb1=new JLabel("Course Id: ");
		tx1=new JTextField(25);
		//tx1.setEditable(false);
		b1=new JButton("VIEW DETAILS");
		lb2=new JLabel("Course Name: ");
		tx2=new JTextField(20);
		lb3=new JLabel("Course Credits: ");
		tx3=new JTextField(20);
		lb4=new JLabel("Course Hours: ");
		tx4=new JTextField(20);
		lb5=new JLabel("								                        			 ");
		b2=new JButton("DELETE");
		lb6=new JLabel("		                           									 ");
		lb7=new JLabel("									                        		 ");
		p.add(lb1);
		p.add(tx1);
		p.add(b1);
		p.add(lb2);
		p.add(tx2);
		p.add(lb5);
		p.add(lb3);
		p.add(tx3);
		p.add(lb6);
		p.add(lb4);
		p.add(tx4);
		p.add(lb7);
		p.add(b2);
		
		b1.addActionListener(this);
		b2.addActionListener(this);

	}
	public void actionPerformed(ActionEvent ae)
	{
		String user="";
		String paswd="";
		String myDb="jdbc:odbc:course1";
		Connection con;
		try
		{
			Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
			con=DriverManager.getConnection(myDb,user,paswd);
			Statement stmt=con.createStatement();
			String id1=tx1.getText();
			int id=Integer.parseInt(id1);
		if(ae.getActionCommand()=="VIEW DETAILS"){
//SET VISIBLE THE INSERT FORM
			
			int credit;
		String name;
		int hr;
		
         String status;
			String sqlQuery="Select cname,credit,hr From course1 where cid="+id+"";
			ResultSet rs=stmt.executeQuery(sqlQuery);
			while(rs.next())
			{
				String result1=" ";
				String result2=" ";
				String result3=" ";
				name=rs.getString(1);
				credit=rs.getInt(2);
				hr=rs.getInt(3);
				//tx2.getselectedItem()=name;
				//tx3.setText(credit);
				//tx4.setText(hr);
				//tx2=rs.getString(1);
				//tx3=rs.getInt(2);
				//tx4=rs.getInt(3);
				//result1="CNAME: "+name.toString()+" , CREDIT: "+result.valueOf(credit)+" , HOUR"+result.valueOf(hr);
				
				result1=name.toString();
				result2=result2.valueOf(credit);
				result3=result3.valueOf(hr);
				tx2.setText(result1);
				tx3.setText(result2);
				tx4.setText(result3);
				//System.out.println(result);
			}
			}
if(ae.getActionCommand()=="DELETE"){

//SET VISIBLE THE UPDATE FORM
		
		String c_name=tx2.getText();
		if (!c_name.matches("[a-zA-Z]+$")){
		JOptionPane.showConfirmDialog(null, "Please enter string only", "Error", JOptionPane.CANCEL_OPTION);
		}
		try
		{
			
			
			/*
			String c=tx3.getText();
			int credits=Integer.parseInt(c);
			String h=tx4.getText();
			int hours=Integer.parseInt(h);
			*/
			String query="delete from course1 where cid="+id+"";
			//String query1="update course1 set credit='"+credits+"' where cid="+id+"";
			//String query2="update course1 set hr='"+hours+"' where cid="+id+"";
			stmt.executeUpdate(query);
			/*stmt.executeUpdate(query1);
			stmt.executeUpdate(query2);*/
			JOptionPane.showMessageDialog(null, "Data deleted", "Congrats", JOptionPane.CANCEL_OPTION);
			con.close();
		}
		catch(NumberFormatException ne){
		JOptionPane.showConfirmDialog(null, "Please enter numbers only", "Error", JOptionPane.CANCEL_OPTION);
		}
		}
	}
		catch(Exception e)
		{
			System.out.println(e.getMessage());
		}
		
	}
	public static void main(String args[])
	{
		new delete_form();
	}
}
