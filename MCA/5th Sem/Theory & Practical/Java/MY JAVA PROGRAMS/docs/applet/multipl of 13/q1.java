//1.	Write an applet program to display the multiplication table of 13.

import java.applet.Applet;
import java.awt.*;
public class q1 extends Applet
{
	int result;
	String buffer;
	int y=25;
	public void paint(Graphics g)
	{
		super.paint(g);
		for(int i=1;i<=10;i++)
		{
			result=13*i;	
			buffer="13*"+i+"="+result;	
			g.drawString(buffer, 25, y+=20);
			
		}
		
	}
}