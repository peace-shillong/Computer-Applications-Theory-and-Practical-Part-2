import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
public class SimpleSwingFrame
{
	SimpleSwingFrame()
	{
		Gui();
	}
	private void Gui()
	{
		SwingUtilities.invokeLater(new Runnable()
		{
			public void run()
			{
				JFrame jframe=new SwingFrameMain("Welcome to Java Swing!!");
				jframe.setVisible(true);
				jframe.setSize(600, 600);
				jframe.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
			}
		
			   
		});
	
			
	}
	
      
	public static void main(String args[])
	{
		SimpleSwingFrame s= new SimpleSwingFrame();
	
	}
	
}