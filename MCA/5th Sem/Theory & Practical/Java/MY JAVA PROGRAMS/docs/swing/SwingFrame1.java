import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
public class SwingFrame1
{
		
      
	public static void main(String args[])
	{
		
				final JFrame jframe=new JFrame("Welcome to Java Swing!!");
				jframe.setVisible(true);
				jframe.setSize(600, 600);
				jframe.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
				jframe.setLayout(new BorderLayout());       
				JTextField textField = new JTextField(20);
				JButton button = new JButton("Click me!"); 
				Container c = jframe.getContentPane();
				c.add(textField,BorderLayout.NORTH);
				c.add(button,BorderLayout.SOUTH);
				button.addActionListener(new ActionListener() 
				{

					@Override
					public void actionPerformed(ActionEvent e) 
					{
						textField.setText("Hello Dari");
					}
			   
				});
	
		JFrame jframe1=new JFrame("Welcome to Java Swing!!");
		jframe1.setVisible(true);
		jframe1.setSize(300,300);
		jframe1.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	
	}
	
}