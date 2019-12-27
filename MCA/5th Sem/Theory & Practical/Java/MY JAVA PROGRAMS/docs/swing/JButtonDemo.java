import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.ImageIcon.*;
import javax.swing.JSeparator;

public class JButtonDemo extends JApplet implements ActionListener

{
	JTextField jtf;
	public void init()
	{
		
	
		// Get content pane
		Container contentPane = getContentPane();
		
		ImageIcon  x=new ImageIcon("s1.jpg");
		JLabel ji=new JLabel();
		JLabel jy=new JLabel();
		ji.setIcon(x);
		
		contentPane.setLayout(new FlowLayout());
		contentPane.add(ji);
		Icon y=ji.getIcon();
		//contentPane.add(jy.setIcon(y));
		// Add buttons to content pane
		ImageIcon france = new ImageIcon("s1.jpg");
		JButton jb = new JButton(france);
		jb.setActionCommand("Smile");
		jb.addActionListener(this);
		contentPane.add(jb);
		ImageIcon germany = new ImageIcon("s2.jpg");
		jb = new JButton(germany);
		jb.setActionCommand("Die");
		jb.addActionListener(this);
		contentPane.add(jb);
		ImageIcon italy = new ImageIcon("s3.png");
		jb = new JButton(italy);
		jb.setActionCommand("Peace");
		jb.addActionListener(this);
		contentPane.add(jb);
		ImageIcon japan = new ImageIcon("s4.jpg");
		jb = new JButton(japan);
		jb.setActionCommand("Hungry");
		jb.addActionListener(this);
		contentPane.add(jb);
		// Add text field to content pane
		jtf = new JTextField(15);
		contentPane.add(jtf);
	}
	public void actionPerformed(ActionEvent ae)
	{
		jtf.setText(ae.getActionCommand());
	}
}
