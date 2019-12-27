import java.applet.*;
import java.awt.*;
import java.awt.event.*;
/*
<applet code="Qstn5_2015.class" width="200" height="200">
</applet>
*/
public class Qstn5_2015 extends Applet implements ActionListener
{
	TextField fno,sno;
	Label flab,slab;
	Button b;
	int f,s,hcf,lcm;
	
	public Qstn5_2015()
	{
		setLayout(new FlowLayout(FlowLayout.LEFT));
		flab=new Label("enter first no:");
		add(flab);
		fno=new TextField(15);
		add(fno);
		slab=new Label("enter second no:");
		add(slab);
		sno=new TextField(15);
		add(sno);
		b=new Button("Find");
		add(b);
		b.addActionListener(this);
	}
	public void actionPerformed(ActionEvent ae)
	{
		f=Integer.parseInt(fno.getText());
		s=Integer.parseInt(sno.getText());
		int min=Math.min(f,s);
		for(int i=min;i>=1;i--)
		{
			if(f%i==0 && s%i==0)
			{
				hcf=i;
				break;
			}
		}
		lcm=(f*s)/hcf;
		showStatus("HCF="+hcf+" LCM="+lcm);
		//showStatus();
	}	
	
	public void init()
	{
		setBackground(Color.cyan);
		
	}
	
	
}
		
	