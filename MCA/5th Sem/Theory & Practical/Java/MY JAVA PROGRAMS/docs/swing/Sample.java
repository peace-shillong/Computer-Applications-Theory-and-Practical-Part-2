/* A simple applet that sets the foreground and
background colors and outputs a string. */
import java.awt.*;
import java.applet.Applet;
import javax.swing.*;

public class Sample extends Applet
{
	String msg;
	String param;
// set the foreground and background colors.
	public void init()
	{
		//add(new JLabel("Look ma!  No Menu!"));
		setBackground(Color.gray);
		setForeground(Color.red);
		
        /*Frame[] frames = Frame.getFrames();
        for (Frame frame : frames) {
            frame.setMenuBar(null);
            frame.pack();
        }*/
		msg = "Inside init( ) --";	
	}
// Initialize the string to be displayed.
	public void start() 
	{
		
		param = getParameter("welcome");
		msg += " Inside start( ) --";
	}
// Display msg in applet window.
	public void paint(Graphics g) 
	{
		msg += " Inside paint( ).";
		g.drawString(msg, 10, 30);
		g.drawString(param, 10, 50);
	}
	

}