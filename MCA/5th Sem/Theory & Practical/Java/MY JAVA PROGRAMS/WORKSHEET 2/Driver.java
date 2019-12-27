import java.util.*;
class Bicycle
{
	int gear,speed;
	String brand;
	Bicycle()
	{
		gear=0;
		speed=0;
		brand="";
	}
	Bicycle(int a,int b,String c)
	{
		gear=a;
		speed=b;
		brand=c;
	}
	//set
	void setGear(int x)
	{
		gear=x;
	}
	void setSpeed(int y)
	{
		speed=y;
	}
	void setBrand(String z)
	{
		brand=z;
	}
	//get
	int getGear()
	{
		return gear;
	}
	int getSpeed()
	{
		return speed;
	}
	String getBrand()
	{
		return brand;
	}
	
	int speedUp(int x)
	{
		return (speed+x);
	}
	int applyBrake(int x)
	{
		return (speed-x);
	}
	public String toString()
	{
		String s;
		s=("gear="+gear+"speed="+speed+"brand="+brand);
		return s;
	}
}
	
class MountainBike extends Bicycle
{
	double seatheight;
	MountainBike()
	{
		super();
		seatheight=0;
	}
	MountainBike(int x,int y,String a,double z)
	{
		super(x,y,a);
		seatheight=z;
	}
	//set
	void setHeight(double z)
	{
		seatheight=z;
	}
	//get
	double getHeight()
	{
		return seatheight;
	}
	public String toString()
	{
		String s;
		s=("height"+seatheight);
		return s;
	}
}
class Driver
{
	public static void main(String args[])
	{
		Bicycle b= new Bicycle();//default base constructor call
		System.out.println(" after base DEFAULT cons call");
		System.out.println(b.toString());
		
		System.out.println("after base PARAMETERIZED cons call");
		Bicycle d= new Bicycle(1,2,"yahama");
		System.out.println(d.toString());
		
		System.out.println("now using SET of base class");
		Scanner sc=new Scanner(System.in);
		System.out.println("enter gear");
		int x=sc.nextInt();
		System.out.println("enter speed");
		int y=sc.nextInt();
		System.out.println("enter Brand name");
		String a=sc.next();
		Bicycle c= new Bicycle();
		c.setGear(x);
		c.setSpeed(y);
		c.setBrand(a);
		
		System.out.println(" displaying using GET from base class");
		System.out.println("gear="+c.getGear()+"speed="+c.getSpeed()+"brand="+c.getBrand());
		
		System.out.println("inherited CONSTRUCTOR Class call");
		MountainBike m=new MountainBike(1,10,"suzuki",5);
		System.out.println(m.toString());
		
		System.out.println("calling MOUNTAIN BIKE set method");
		double x4=sc.nextDouble();
		m.setHeight(x4);
		
		System.out.println("calling MOUNTAIN BIKE get method");
		System.out.println(m.getHeight());
	}
}
	