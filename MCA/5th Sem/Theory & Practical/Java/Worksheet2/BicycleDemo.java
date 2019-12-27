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
		return ("Gear="+gear+"\nSpeed="+speed+"\nBrand="+brand);
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
}
class Driver
{
	public static void main(String args[])
	{
			MountainBike mb=new MountainBike();
			mb.setGear(2);
			mb.setBrand("Honda");
			mb.setSpeed(50);
			mb.setSeatHeight(10);
			System.out.println(toString());
	}
}