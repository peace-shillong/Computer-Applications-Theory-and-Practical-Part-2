import java.awt.*;
import javax.swing.*;
import java.awt.event.*;
/*
<applet code="Qstn3_2016" width="200" height="200">
</applet>
*/
public class Qstn3_2016 extends JApplet implements ActionListener
{
	String msg="";
	JButton jbtn1,jbtn2,jbtn3;
	public void init()
	{
		try
		{
			SwingUtilities.invokeAndWait(new Runnable()
			{
				public void run()
				{
					makeGui();
				}
			});
		}
		catch(Exception e)
		{
		}
	}
	private void makeGui()
	{
		setLayout(new FlowLayout());
		jbtn1=new JButton("Oval");
		jbtn1.setActionCommand("Oval");
		jbtn1.addActionListener(this);
		
		jbtn2=new JButton("Ellipse");
		jbtn2.setActionCommand("Ellipse");
		jbtn2.addActionListener(this);
		
		jbtn3=new JButton("Arc");
		jbtn3.setActionCommand("Arc");
		jbtn3.addActionListener(this);
		add(jbtn1);
		add(jbtn2);
		add(jbtn3);
	}
	public void actionPerformed(ActionEvent ae)
	{
		msg=ae.getActionCommand();
		repaint();
	}
	public void paint(Graphics g)
	{
		if(msg.equals("Oval"))
		{
			Color c=Color.RED;
			g.setColor(c);
			g.fillOval(50,50,100,100);
		}
		if(msg.equals("Ellipse"))
			g.fillOval(70,70,100,50);
		if(msg.equals("Oval"))
			g.fillArc(80,80,100,100,0,60);
	}
}
		
