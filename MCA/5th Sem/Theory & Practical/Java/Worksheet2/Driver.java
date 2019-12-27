import java.util.*;
class Bicycle
{
	int gear;
	int speed;
	String brand;
	
	Bicycle()
	{
		gear=1;
		speed=0;
		brand="Hero";
	}
	void setGear(int g)
	{
		gear=g;
	}
	void setSpeed(int s)
	{
		speed=s;
	}
	void setBrand(String b)
	{
		brand=b;
	}
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
	int speedUp(int sp)
	{
		return (speed+sp);
	}
	int applyBrake(int ab)
	{
		return (speed-ab);
	}
	public String toString()
	{
		return ("\nGear="+gear+"\nSpeed="+speed+"\nBrand="+brand);
	}
}
class MountainBike extends Bicycle
{
	int seatHeight;
	MountainBike()
	{
		super();
		seatHeight=10;
	}
	void setSeatHeight(int sh)
	{
		seatHeight=sh;
	}
	int getSeatHeight()
	{
		return seatHeight;
	}
	public String toString()
	{
		
		return (super.toString()+"\nSeat Height="+seatHeight);
	}
}
class Driver
{
	public static void main(String args[])
	{
			int g1,g2,s1,s2,sh;
			String b1,b2;
			Scanner sc=new Scanner(System.in);
			Bicycle bc=new Bicycle();
			bc.setGear(1);
			bc.setBrand("TVS");
			bc.setSpeed(50);
			System.out.println(bc.toString());
			
			MountainBike mb=new MountainBike();
			mb.setGear(2);
			mb.setBrand("Honda");
			mb.setSpeed(50);
			mb.setSeatHeight(10);
			System.out.println(mb.toString());
			
			System.out.println("**Enter details for Bicycle**");
			System.out.println("Enter gear:");
			g1=sc.nextInt();
			System.out.println("Enter brand:");
			b1=sc.next();
			System.out.println("Enter speed:");
			s1=sc.nextInt();
			bc.setGear(g1);
			bc.setBrand(b1);
			bc.setSpeed(s1);
			System.out.println(bc.toString());
			
			System.out.println("**Enter details for MountainBike**");
			System.out.println("Enter gear:");
			g2=sc.nextInt();
			System.out.println("Enter brand:");
			b2=sc.next();
			System.out.println("Enter speed:");
			s2=sc.nextInt();
			System.out.println("Enter Seat Height:");
			sh=sc.nextInt();
			mb.setGear(g2);
			mb.setBrand(b2);
			mb.setSpeed(s2);
			mb.setSeatHeight(sh);
			System.out.println(mb.toString());
	}
}