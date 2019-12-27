import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

class EventDemo1()
{
	JButton jbtnAlpha;
	JButton jbtnBeta;
	JLabel jlab;

	EventDemo1()
	{
		JFrame J=new JFrame();
		
		j.setSize(200,200);
		j.setLayout(new FlowLayout());
		j.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
				
		jbtnAlpha = new JButton("Alpha");
		jbtnBeta = new JButton("Beta");
		
		jbtnAlpha.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent ae) {
			jlab.setText("Alpha was pressed.");
		}
		});
		
		// Add action listener for Beta.
		jbtnBeta.addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent ae) {
			jlab.setText("Beta was pressed.");
			}
		});
		
		j.add(jbtnAlpha);
		j.add(jbtnBeta);
		
		jlab = new JLabel("Press a button.");
		jlab.setText("Hello");
		j.add(jlab);
		
		j.setVisible(true);

	}
	
	public static void main()
	{
		SwingUtilities.invokeLater(
			new Runnable(){
				public void run() {
				new EventDemo();
			}
		}
		);
	}
}