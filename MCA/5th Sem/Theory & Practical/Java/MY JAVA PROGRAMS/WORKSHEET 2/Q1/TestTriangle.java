import java.util.*;
class Triangle
{	
	double side1,side2,side3;
	Triangle()
	{	
		side1=side2=side3=1;
	}
	
	Triangle(double a,double b,double c)
	{
		side1=a;
		side2=b;
		side3=c;
	}
	
	void setSide1(double a)
	{	
		side1=a;	
	}
	double getSide1()
	{
		return side1;
	}
	void setSide2(double b)
	{	
		side2=b;
	}
	double getSide2()
	{
		return side2;
	}	

	void setSide3(double c)
	{	
		side3=c;
	}
	double getSide3()
	{	
		return side3;
	}

	double getArea()	
	{
		double s,a;
		s=(side1+side2+side3)/2;
		a=s*(s-side1)*(s-side2)*(s-side3);
		return Math.sqrt(a);
	}
	double getPerimeter()
	{	
		return(side1+side2+side3);
	}

}

class TestTriangle
{

	public static void main(String args[])
	{	
		Scanner sc=new Scanner(System.in);
		Triangle t1=new Triangle();
		System.out.println("Default Triangle:");
		System.out.println("Area:"+t1.getArea());
		System.out.println("Perimeter:"+t1.getPerimeter());
		System.out.print("Enter side 1:");
		double a=sc.nextDouble();
		System.out.print("Enter side 2:");
		double b=sc.nextDouble();
		System.out.print("Enter side 3:");
		double c=sc.nextDouble();
		Triangle t2=new Triangle(a,b,c);
		System.out.println("Area of a triangle is:"+t2.getArea());
		System.out.println("Perimeter of a triangle is:"+t2.getPerimeter());	
	}
}
