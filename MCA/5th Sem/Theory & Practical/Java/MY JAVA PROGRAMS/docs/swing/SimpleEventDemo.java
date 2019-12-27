import javax.swing.*;
import java.awt.event.*;
import java.io.*;

public class SimpleEventDemo extends JFrame implements ActionListener
{
	public double d;
	public SimpleEventDemo(int a,int b,int c){
		String s1=String.valueOf(a);
		String s2=String.valueOf(b);
		String s3=String.valueOf(c);
		JTextField p=new JTextField(s1);
		JTextField r=new JTextField(s2);
		JTextField i=new JTextField(s3);
		JButton jbtOK=new JButton("OK");
		JPanel panel=new JPanel();
		panel.add(p);
		panel.add(r);
		panel.add(i);
		panel.add(jbtOK);
		add(panel);
		s1=p.getText();
		s2=r.getText();
		s3=i.getText();
		System.out.println(a);
		a=Integer.parseInt(s1);
		b=Integer.parseInt(s2);
		c=Integer.parseInt(s3);
		System.out.println(a);
		d=0;
		d=(a*b*c)/100;
		//p.setText=c;
		//ListenerClass listner=new ListenerClass();
		jbtOK.addActionListener(this);
	}
	public void actionPerformed(ActionEvent e)
	{
		System.out.println("The value of interest is"+getd());
	}	
		
	public double getd()
	{
		return d;
	}
	public static void main(String args[]){
		JFrame frame=new SimpleEventDemo(100,1000,2);
		frame.setTitle("Event Handling Example 1");
		frame.setSize(300,300);
		frame.setLocation(200,100);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setVisible(true);
	}
}

