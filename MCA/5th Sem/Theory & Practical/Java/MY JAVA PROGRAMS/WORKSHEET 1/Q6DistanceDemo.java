import java.util.*;
class Distance
{
	double x;
	double y;
	Distance()
	{
		x=1;
		y=2;
	}
	Distance(double x1,double y1)
	{
		x=x1;
		y=y1;
	}
	double calculate(Distance b)
	{		
		return (Math.sqrt((Math.pow(b.x-x,2))+(Math.pow(b.y-y,2))));
	}
	void display()
	{
		System.out.println(x+ ","+y);
	}
}
class Q6DistanceDemo
{
	public static void main(String args[])
	{
		int x1,x2,y1,y2;
		Scanner sc=new Scanner(System.in);
		System.out.println("Enter The Point P1(x1,y1)");
		x1=sc.nextInt();
		y1=sc.nextInt();
		System.out.println("Enter The Point P2(x2,y2)");
		x2=sc.nextInt();
		y2=sc.nextInt();
		Distance p1=new Distance(x1,y1);
		Distance p2=new Distance(x2,y2);
		System.out.print("P1=");
		p1.display();
		System.out.print("P2=");
		p2.display();
		double d=p1.calculate(p2);
		System.out.println("Distance between P1 and P2=" + d);
	}
}