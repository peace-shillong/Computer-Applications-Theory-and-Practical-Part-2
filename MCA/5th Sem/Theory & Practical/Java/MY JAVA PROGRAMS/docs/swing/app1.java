
import java.awt.*;
import java.applet.*;
import java.awt.event.*;
public class app1 extends Applet implements ActionListener
{
		TextField t1, t2;
		Button b1;
		public void init()
        {
                t1 = new TextField(10);
                t2 = new TextField(10);
				b1 =new Button("Click here");

                add(t1);
                add(t2);
				add(b1);
				b1.addActionListener(this);

                t1.setText("0");
                t2.setText("0");
        }
        public void paint(Graphics g)
        {
                int a=0,b=0,c=0;
                String str1,str2,str;

                g.drawString("Enter the number in each box",10,50);

                try
                {
                        str1=t1.getText();
                        a=Integer.parseInt(str1);

                        str2=t2.getText();
                        b=Integer.parseInt(str2);
                }
                catch(Exception e)
                {
                }
                c=a+b;

                str=String.valueOf(c);

                g.drawString("Sum is",10,15);
                g.drawString(str,100,75);
        }
		public void actionPerformed(ActionEvent e)
		{
			t1.setText("yes!!!");
		}
}

