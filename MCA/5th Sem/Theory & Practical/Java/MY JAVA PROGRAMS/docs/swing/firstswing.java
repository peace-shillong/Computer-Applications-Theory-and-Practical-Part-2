import javax.swing.JFrame;
import java.awt.*;
class welcome extends JFrame
{
	public welcome()
	{
		super("Welcome To Swing");
		setLayout(new FlowLayout());
	
	}
}
public class firstswing
{
	public static void main(String args[])
	{
		welcome frame=new welcome();
		frame.setSize(200,200);
		frame.setDefaultCloseOperation( JFrame.EXIT_ON_CLOSE );
		frame.setVisible( true );

	}
}
