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
		s=("Gear="+gear+"\nSpeed="+speed+"\nBrand="+brand);
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
		s=("Gear="+gear+"\nSpeed="+speed+"\nBrand="+brand+"Height"+seatheight);
		return s;
	}
}
class Q3
{
	public static void main(String args[])
	{
		Bicycle b= new Bicycle();//default base constructor call
		System.out.println("DEFAULT object");
		System.out.println(b.toString());
		
		System.out.println("PARAMETERIZED cons called");
		Bicycle d= new Bicycle(1,2,"Yahama");
		System.out.println(d.toString());
		
		System.out.println("Creating an Object using Methods of class");
		Scanner sc=new Scanner(System.in);
		System.out.println("Enter gear");
		int x=sc.nextInt();
		System.out.println("Enter speed");
		int y=sc.nextInt();
		System.out.println("Enter Brand name");
		String a=sc.next();
		Bicycle c= new Bicycle();
		c.setGear(x);
		c.setSpeed(y);
		c.setBrand(a);
		
		System.out.println(" Displaying using GET Methods");
		System.out.println("\nGear="+c.getGear()+"\nSpeed="+c.getSpeed()+"\nBrand="+c.getBrand());
		
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
	