import javax.swing.*; 
import java.awt.*;
import javax.swing.ActionListener; 
import javax.swing.JLabel; 
import java.swing.event; 


class MyFrame extends JFrame implements ActionListener{
	JButton btn1; 	JLabel label1;
	public MyFrame(){
		super("Using Buttons");
		setLayout(new FlowLayout());
		btn1=new JButton("Click Me");
		label1=new JLabel();
		add(btn1);
		add(label1);
		btn1.addActionListener(this);
}
	public void actionPerformed(ActionEvent e){
		label1.setText("You have pressed : " + e.getActionCommand());
	}
}

public class Button
{
	public static void main(String args[])
	{
		MyFrame frame=new MyFrame();		
		frame.setSize( 500,500 );
		frame.setDefaultCloseOperation( JFrame.EXIT_ON_CLOSE );
		frame.setVisible( true );
	}
}