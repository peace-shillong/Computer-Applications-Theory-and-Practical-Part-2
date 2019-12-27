import java.util.*;
abstract class GeometricObject
{
	String color;
	boolean filled;
	Date dateCreated=new Date();
	
	void geometricObject()
	{
		color="red";
		filled=false;
		//dateCreated=new Date();
	}
	String getColor()
	{
		return color;
	}
	void setColor(String c)
	{
		color=c;
	}
	boolean isFilled()
	{
		return filled;
	}
	void setFilled(boolean f)
	{
		filled=f;
	}
	Date getDateCreated()
	{
		return dateCreated;
	}
	public String toString()
	{
		return "Color="+color+"\nFilled="+filled+"\nDate Created="+dateCreated;
	}
	abstract double getArea();
	abstract double getPerimeter();
}
class Circle extends GeometricObject
{
	double radius;
	Circle()
	{
		radius=0;
	}
	Circle(double r)
	{
		radius=r;
	}
	double getRadius()
	{
		return radius;
	}
	void setRadius(double r)
	{
		radius=r;
	}
	double getDiameter()
	{
		return (2*radius);
	}
	double getArea()
	{
		return (2*3.14*radius*radius);
	}
	double getPerimeter()
	{
		return (2*3.14*radius);
	}
}
class Rectangle extends GeometricObject
{
	double width;
	double height;
	Rectangle()
	{
		width=0;
		height=0;
	}
	Rectangle(double w,double h)
	{
		width=w;
		height=h;
	}
	double getWidth()
	{
		return width;
	}
	void setWidth(double w)
	{
		width=w;
	}
	double getHeight()
	{
		return height;
	}
	void setHeight(double h)
	{
		height=h;
	}
	double getArea()
	{
		return (width*height);
	}
	double getPerimeter()
	{
		return (2*(width+height));
	}
}
class AbstractDemo
{
	public static void main(String args[])
	{
		Circle c=new Circle();
		c.setRadius(7);
		c.setColor("blue");
		c.setFilled(true);
		System.out.println("*CIRCLE*");
		System.out.println(c.toString());
		System.out.println("Area of circle="+c.getArea());
		System.out.println("Perimeter of circle="+c.getPerimeter());
		
		Rectangle r=new Rectangle();
		r.setWidth(4);
		r.setHeight(5);
		r.setColor("green");
		r.setFilled(true);
		System.out.println("\n*RECTANGLE*");
		System.out.println(r.toString());
		System.out.println("Area of rectangle="+r.getArea());
		System.out.println("Perimeter of rectangle="+r.getPerimeter());
	}
}