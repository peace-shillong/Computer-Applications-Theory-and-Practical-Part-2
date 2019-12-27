import java.awt.*;
import javax.swing.*;

public class JLabelDemo extends JApplet 
{
	public void init() 
	{
		// Get content pane
		Container contentPane = getContentPane();
		// Create an icon
		//ImageIcon i =new ImageIcon("click.jpg");
		ImageIcon i = new ImageIcon((new ImageIcon("click.jpg").getImage().getScaledInstance(20, 20, Image.SCALE_DEFAULT)));
		// Create a label
		JLabel jl = new JLabel("Click", i, JLabel.LEFT);
		// Add label to the content pane
		contentPane.add(jl);
	}
}