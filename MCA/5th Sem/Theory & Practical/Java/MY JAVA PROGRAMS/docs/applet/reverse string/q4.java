/*4.	Write an applet program which reads a string sent as parameter and displays it in 
the reverse form in the applet.*/

import java.applet.Applet;
import java.awt.*;
import java.awt.event.*;

public class q4 extends Applet implements ActionListener
{
	private Label l1;
	private TextField tx1;
	private Label l2;
	private TextField tx2;
	private Button btn;
	public void init()
	{
		this.l1=new Label("Enter the String: ");
		this.add(l1);
		this.tx1=new TextField(25);
		this.add(tx1);	
		this.btn=new Button("REVERSE");
		this.add(btn);
		this.l2=new Label("The Reverse is: ");
		this.add(l2);	
		this.tx2=new TextField(25);
		this.add(tx2);
		btn.addActionListener(this);
	}
	public void actionPerformed(ActionEvent ae)
	{
		StringBuffer str=new StringBuffer(tx1.getText());
		tx2.setText(""+str.reverse());	
	}	
}