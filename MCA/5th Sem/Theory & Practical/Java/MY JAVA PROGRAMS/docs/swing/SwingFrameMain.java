import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class SwingFrameMain extends JFrame 
{
    
   
     public SwingFrameMain(String AppTitle)
     {
  
        super(AppTitle);
	final Panel panel=new Panel();
	final RadioPanel radiopanel=new RadioPanel();
	final JTextField textField = new JTextField(20);
	JButton button = new JButton("Click here!"); 
	Container c = getContentPane();
	c.add(textField,BorderLayout.NORTH);
	c.add(button,BorderLayout.SOUTH);
	c.add(panel,BorderLayout.EAST);
	c.add(radiopanel,BorderLayout.WEST);
	button.addActionListener(new ActionListener() 
	{

		@Override
		public void actionPerformed(ActionEvent e) 
		{
			textField.setText("WELCOME ALL!!!!");
		}
	});
    }
}