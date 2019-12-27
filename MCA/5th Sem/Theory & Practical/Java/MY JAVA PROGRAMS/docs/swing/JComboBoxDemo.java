import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class JComboBoxDemo extends JFrame implements ItemListener
{
	JLabel jl;
	ImageIcon france, germany, italy, japan;
	JComboBoxDemo()
	{
		// Get content pane
		Container contentPane = getContentPane();
		contentPane.setLayout(new FlowLayout());
		// Create a combo box and add it
		// to the panel
		JComboBox jc = new JComboBox();
		jc.addItem("France");
		jc.addItem("Germany");
		jc.addItem("Italy");
		jc.addItem("Japan");
		jc.addItemListener(this);
		contentPane.add(jc);
		// Create label
		jl = new JLabel(new ImageIcon("s1.jpg"));
		contentPane.add(jl);
	}
	public void itemStateChanged(ItemEvent ie) 
	{
		String s = (String)ie.getItem();
		jl.setIcon(new ImageIcon(s + ".jpg"));
	}
	public static void main(String[] args) {  
        JComboBoxDemo cl=new JComboBoxDemo();  
        cl.setSize(400,400);  
        cl.setVisible(true);  
        cl.setDefaultCloseOperation(EXIT_ON_CLOSE);  
    }  
}