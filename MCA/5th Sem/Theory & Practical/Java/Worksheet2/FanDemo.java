import java.util.*;
class Fan
{
	final int SLOW=1;
	final int MEDIUM=2;
	final int FAST=3;
	int speed=SLOW;
	boolean on=false;
	double radius=5;
	String color="blue";
	
	Fan()
	{
		speed=SLOW;
		on=false;
		radius=5;
		color="blue";
	}
	void setSpeed(int s)
	{
		speed=s;
	}
	void setOn(boolean o)
	{
		on=o;
	}
	void setRadius(double r)
	{
		radius=r;
	}
	void setColor(String c)
	{
		color=c;
	}
	int getSpeed()
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
			return ("Speed="+speed+"\nColor="+color+"\nRadius="+radius);
		else
			return ("Color="+color+"\nRadius="+radius+"\nfan is off");
	}
}
class FanDemo
{
	public static void main(String args[])
	{
			String c;
			boolean o;
			double r;
			int s;
			Scanner sc=new Scanner(System.in);
			Fan f=new Fan();
			f.setColor("red");
			f.setOn(true);
			f.setRadius(10);
			f.setSpeed(100);
			System.out.println(f.toString());
			
			Fan f2=new Fan();
			System.out.println("Enter color of the fan:");
			c=sc.nextLine();
			System.out.println("Enter radius of the fan:");
			r=sc.nextDouble();
			System.out.println("Enter speed of the fan:");
			s=sc.nextInt();
			System.out.println("Would you like to switch on the fan? (true/false):");
			o=sc.nextBoolean();
			f2.setColor(c);
			f2.setOn(o);
			f2.setRadius(r);
			f2.setSpeed(s);
			System.out.println(f2.toString());
	}
}