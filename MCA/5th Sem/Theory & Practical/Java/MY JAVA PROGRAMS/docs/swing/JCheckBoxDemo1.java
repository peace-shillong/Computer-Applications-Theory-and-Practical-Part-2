import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class JCheckBoxDemo1 extends JApplet implements ItemListener 
{
	JTextField tf;
	public void init() 
	{
		// Get content pane
		Container contentPane = getContentPane();
		contentPane.setLayout(new FlowLayout());
		// Add radio buttons to content pane
		JCheckBox b1 = new JCheckBox("A");
		b1.addItemListener(this);
		contentPane.add(b1);
		JCheckBox b2 = new JCheckBox("B");
		b2.addItemListener(this);
		contentPane.add(b2);
		JCheckBox b3 = new JCheckBox("C");
		b3.addItemListener(this);
		contentPane.add(b3);
		// Define a button group
		ButtonGroup bg = new ButtonGroup();
		bg.add(b1);
		bg.add(b2);
		bg.add(b3);
		// Create a text field and add it
		// to the content pane
		tf = new JTextField(5);
		contentPane.add(tf);
	}	
	public void itemStateChanged(ItemEvent ie)
	{
		JCheckBox cb = (JCheckBox)ie.getItem();
		tf.setText(cb.getText());
	}
}