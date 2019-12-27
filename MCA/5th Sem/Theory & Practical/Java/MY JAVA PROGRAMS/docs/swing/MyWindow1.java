import javax.swing.*; 
import java.awt.*;
class MyFrame extends JFrame
{
	public MyFrame()
	{
		super("My First Window");
		setLayout(new FlowLayout());
		JTextField text1=new JTextField(20);
		JLabel label2=new JLabel("Label 2");
		add(label2);
		add(text1);
	}
}
public class MyWindow1
{
	public static void main(String args[])
	{
		MyFrame frame=new MyFrame();		
		frame.setSize( 500,500 );
		frame.setDefaultCloseOperation( JFrame.EXIT_ON_CLOSE );
		frame.setVisible( true );
	}
}