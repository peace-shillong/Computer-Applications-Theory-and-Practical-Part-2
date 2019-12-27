import java.util.*;
class Fan{
	final int SLOW=1;
	final int MEDIUM=2;
	final int FAST=3;
	int speed;
	boolean on;
	double radius;
	String color;
	Fan()
	{
		speed=SLOW;
		on=false;
		radius=5;
		color="blue";
	}
	Fan(int f,boolean o,double r,String s)
	{
		speed=f;
		on=o;
		radius=r;
		color=s;
	}
	void setspeed(int f)
	{
		speed=f;
	}
	void setOn(boolean o)
	{
		on=o;
	}
	void setRadius(double r)
	{
		radius=r;
	}
	void setColor(String s)
	{
		color=s;
	}
	int getspeed()
	{
		return speed;
	}
	boolean getOn()
	{
		return on;
	}
	double getRadius()
	{
		return radius;
	}
	String getColor()
	{
		return color;
	}
	
	public String toString()
	{
		if(on==true)
			return "Fan Speed= "+speed+" color= "+color+" radius= "+radius;
		else
			return "Fan color= "+color+" radius= "+radius+" fan is off ";
	}
}
class TestFan{
public static void main(String args[])
{
	Scanner sc=new Scanner(System.in);
	Fan f=new Fan();
	//Using default constructor
	System.out.println("Using default constructor");
	System.out.println("speed="+f.getspeed());
	System.out.println("Fan status="+f.getOn());
	System.out.println("Radius="+f.getRadius());
	System.out.println("Color="+f.getColor());
	System.out.println(f.toString());
	//Using parameterized constructor
	System.out.println("Using parameterized constructor");
	Fan f1=new Fan(2,true,3.5,"Black");
	System.out.println(f1.toString());
	//setting values
	System.out.println("After setting new values \n");
	System.out.print("Enter speed (Number)");
	int c=sc.nextInt();
	System.out.print("Enter status (true/false)");
	boolean s=sc.nextBoolean();
	System.out.print("Enter radius (Number)");
	double r=sc.nextDouble();
	System.out.print("Enter color (String)");
	String co=sc.next();
	f1.setspeed(c);
	f1.setOn(s);
	f1.setRadius(r);
	f1.setColor(co);
	System.out.println(f1.toString());
}
}
	
	
	