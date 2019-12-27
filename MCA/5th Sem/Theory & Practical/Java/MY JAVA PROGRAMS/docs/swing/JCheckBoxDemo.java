import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class JCheckBoxDemo extends JApplet implements ItemListener 
{
	JTextField jtf;
	public void init()
	{
		// Get content pane
		Container contentPane = getContentPane();
		contentPane.setLayout(new GridLayout());
		// Create icons
		ImageIcon normal = new ImageIcon("s1.jpg");
		ImageIcon rollover = new ImageIcon("s2.jpg");
		ImageIcon selected = new ImageIcon("s4.jpg");
		// Add check boxes to the content pane
		JCheckBox cb = new JCheckBox("C");
		cb.setRolloverIcon(rollover);
		cb.setSelectedIcon(selected);
		cb.addItemListener(this);
		contentPane.add(cb);
		cb = new JCheckBox("C++", normal);
		cb.setRolloverIcon(rollover);
		cb.setSelectedIcon(selected);
		cb.addItemListener(this);
		contentPane.add(cb);
		cb = new JCheckBox("Java", normal);
		cb.setRolloverIcon(rollover);
		cb.setSelectedIcon(selected);
		cb.addItemListener(this);
		contentPane.add(cb);
		cb = new JCheckBox("Perl", normal);
		cb.setRolloverIcon(rollover);
		cb.setSelectedIcon(selected);
		cb.addItemListener(this);
		contentPane.add(cb);
		// Add text field to the content pane
		jtf = new JTextField(15);
		contentPane.add(jtf);
}
	public void itemStateChanged(ItemEvent ie)
	{
		JCheckBox cb = (JCheckBox)ie.getItem();
		jtf.setText(cb.getText());
	}
}