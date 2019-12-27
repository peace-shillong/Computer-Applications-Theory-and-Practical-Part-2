import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Qstn5_2016 extends JFrame implements ActionListener
{
	JFrame jfrm;
	JLabel jlab,jlab1;
	JTextField jtf;
	JRadioButton r1,r2;
	ButtonGroup bg;
	int num,i,sum=0;
	public Qstn5_2016()
	{
		jfrm=new JFrame("Swing application");
		jfrm.setLayout(new FlowLayout());
		jfrm.setSize(200,200);
		jfrm.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		jfrm.setVisible(true);
		jlab=new JLabel("Enter a number:");
		jfrm.add(jlab);
		jtf=new JTextField(15);
		jfrm.add(jtf);
		r1=new JRadioButton("On");
		r1.setActionCommand("On");
		r1.addActionListener(this);
		jfrm.add(r1);
		r2=new JRadioButton("Off");
		r2.setActionCommand("Off");
		r2.addActionListener(this);
		jfrm.add(r2);
		jlab1=new JLabel();
		jfrm.add(jlab1);
		bg=new ButtonGroup();
		bg.add(r1);
		bg.add(r2);
	}
	public void actionPerformed(ActionEvent ae)
	{
		if(ae.getActionCommand()=="On")
		{
			jlab1.setText("");
			sum=0;
			num=Integer.parseInt(jtf.getText());
			for(i=1;i<num;i++)
			{
				if(num%i==0)
					sum=sum+i;
			}
			if(sum>=num)
				jlab1.setText("The number "+num+" is a Perfect number");
			else
				jlab1.setText("The number "+num+" is not a Perfect number");
		}
		if(ae.getActionCommand()=="Off")
			jlab1.setText("Do nothing");
	
	}
	public static void main(String args[])
	{
		SwingUtilities.invokeLater(new Runnable()
		{
			public void run()
			{
				new Qstn5_2016();
			}
		});
	}
}
	