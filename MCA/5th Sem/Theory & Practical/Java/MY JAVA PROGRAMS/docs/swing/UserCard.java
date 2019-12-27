import java.awt.*;
import java.applet.*;
import java.awt.event.*;
import javax.swing.*;

public class UserCard extends JApplet implements ActionListener
{
		TextField t1, t2;
		Label l1=new Label("Enter two numbers:");
		Button button;
		int a=0,b=0,c=0,h=1,l;
        String str1,str2;
		String strHcf=null,strLcm=null;
		Container cn=getContentPane(); 
		public void init()
        {
                cn.setLayout(new CardLayout(40,30)); 
				t1 = new TextField(10);
                t2 = new TextField(10);
				button= new Button("View answer");
				//cn.add(l1);
                cn.add(t1);
                cn.add(t2);
				cn.add(button);
				button.addActionListener(this);
                t1.setText("0");
                t2.setText("0");
        }
		public void actionPerformed(ActionEvent e1)
		{  
			try
                {
                        str1=t1.getText();
                        a=Integer.parseInt(str1);

                        str2=t2.getText();
                        b=Integer.parseInt(str2);
                }
                catch(Exception e)
                {	
						showStatus("Error");
                }
				c=Math.min(a,b);
				for(int i=2;i<=c;i++)
				{
					if((a%i==0)&&(b%i==0))
					{
						h=i;
					}
				}
				l=(a*b)/h;
				strHcf=String.valueOf(h);
				strLcm=String.valueOf(l);
				showStatus("HCF="+strHcf+" and LCM="+strLcm);

		} 
 	
}

