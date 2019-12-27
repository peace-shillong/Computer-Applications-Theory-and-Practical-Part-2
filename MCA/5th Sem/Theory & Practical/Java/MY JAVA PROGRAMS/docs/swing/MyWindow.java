import javax.swing.*; 
import javax.swing.JLabel; 
import java.awt.*;
class MyFrame extends JFrame
{
	public MyFrame()
	{
		super("My First Window");
		setLayout(new FlowLayout());
		JLabel label1=new JLabel();
		ImageIcon Ic=new ImageIcon("C:/Users/Public/Pictures/Sample Pictures/Desert.jpg");
        		label1.setIcon(Ic);
		JLabel label2=new JLabel("Label 2");
		JLabel label3=new JLabel("Label 3");
		add(label1);
		add(label2);
		add(label3);
	}
}
public class MyWindow
{
	public static void main(String args[])
	{
		MyFrame frame=new MyFrame();		
		frame.setSize( 200,200 );
		frame.setDefaultCloseOperation( JFrame.EXIT_ON_CLOSE );
		frame.setVisible( true );
	}
}
