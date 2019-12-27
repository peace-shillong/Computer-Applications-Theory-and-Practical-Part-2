abstract class Shape
{
	double var1;
	double var2;
	static double PI=3.142;
	Shape(double v1,double v2)
	{
		var1=v1;
		var2=v2;
	}
	abstract double area();
}
class Rectangle extends Shape
{
	Rectangle(double l,double b)
	{
		super(l,b);
	
	}
	double area()
	{
		return var1*var2;
	}
}
class Triangle extends Shape
{
	Triangle(double h,double b)
	{
		super(b,h);
	
	}
	double area()
	{
		return 0.5*var1*var2;
	}
}
class Circle extends Shape
{
	Circle(double r)
	{
		super(r,r);
	
	}
	double area()
	{
		return Circle.PI*var1*var2;
	}
}
class Qstn1_2016
{
	public static void main(String args[])
	{
		Shape s;
		Rectangle r=new Rectangle(4,5);
		Triangle t=new Triangle(6,5);
		Circle c=new Circle(5);
		System.out.println("For Rectangle Class");
		s=r;
		System.out.println("Area of rectangle="+s.area());
		System.out.println("For Triangle Class");
		s=t;
		System.out.println("Area of Triangle="+s.area());
		System.out.println("For Circle Class");
		s=c;
		System.out.println("Area of Circle="+s.area());
	}
}
