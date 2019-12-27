import java.awt.*;
import javax.swing.*;
import java.awt.event.*;

public class Qstn4_2015 extends JFrame implements ActionListener
{
		JFrame jfrm;
		JLabel lab1,lab2;
		JRadioButton r1,r2;
		JTextArea jtxt1,jtxt2;
		String str,txt1,txt2;
		ButtonGroup bg;
		char ch;
		int count=0;
		Qstn4_2015()
		{
			jfrm=new JFrame("Sentence");
			jfrm.setLayout(new FlowLayout());
			jfrm.setSize(200,200);

			jfrm.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
			lab1=new JLabel("Enter your sentence here:");
			jfrm.add(lab1);
			lab2=new JLabel("The changed sentence is:");
			jfrm.add(lab2);
			jtxt1=new JTextArea(3,10);
			
			jfrm.add(jtxt1);
			jtxt2=new JTextArea(3,10);
			
			jfrm.add(jtxt2);
			
			
			r1=new JRadioButton("On");
			r1.setActionCommand("On");
			r1.addActionListener(this);
			jfrm.add(r1);
			r2=new JRadioButton("Off");
			r2.setActionCommand("Off");
			r2.addActionListener(this);
			jfrm.add(r2);
			bg=new ButtonGroup();
			bg.add(r1);
			bg.add(r2);
			jfrm.setVisible(true);
		
		}
		public void actionPerformed(ActionEvent ae)
		{
			str=ae.getActionCommand();
			txt1=new String(jtxt1.getText());
			String[] spl=txt1.split(" ");
			if(str.equals("On"))
			{
				for(int i=0;i<txt1.length();i++)
				{
					if(txt1.charAt(i)==' ' && txt1.charAt(i+1)!=' ')
						count=count+1;
				}
				jtxt2.setText("No of words="+count);
				count=0;
			}
			if(str.equals("Off"))
			{
				jtxt2.setText("Nothing is typed");
			}
		}
		public static void main(String args[])
		{
			SwingUtilities.invokeLater(new Runnable()
			{
				public void run()
				{
					new Qstn4_2015();
				}
			});
		}
}
			