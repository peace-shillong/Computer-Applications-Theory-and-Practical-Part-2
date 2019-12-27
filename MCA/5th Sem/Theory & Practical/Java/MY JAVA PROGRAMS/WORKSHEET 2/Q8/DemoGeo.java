abstract class GeometricObject
{
	String color;
	boolean filled;
	String dateCreated;
	
	String getColor()
	{
		return(color);
	}
	void setColor(String col)
	{
		color=col;
	}
	boolean isFilled()
	{
		return(filled);
	}
	void setFilled(boolean fill)
	{
		filled=fill;
	}
	String getDate()
	{
		return(dateCreated);
	}
	public String toString()
	{
		return (color+" "+filled+" "+dateCreated);
	}
	abstract double getArea();
	abstract double getPerimeter();
	
}
class Circle extends GeometricObject
{
	double radius;
	Circle()
	{
	super();
	radius=0;
	}
	Circle(String col, Boolean fill, String dat,double rad)
	{
	super(col,fill,dat);
	radius=rad;
	}
	double getRadius()
	{
	return radius;
	}	
	void setRadius(double rad)
	{
		radius=rad;
	}
	double getDiameter()
	{
		return(2*radius);
	}
	public String toString()
	{
	return "Circle object with "+color+" "+filled+" "+dateCreated+" "+radius;
	}
	double getArea()
	{
	return((22*radius*radius)/7);
	}
	double getPerimeter()
	{
	return((2*22*radius)/7);
	}
}
class Rectangle extends GeometricObject
{
	double width;
	double height;
	Rectangle()
	{
	super();
	width=0;
	height=0;
	}
	Rectangle(String col, Boolean fill, String dat,double wid,double hei)
	{
		super(col,fill,dat);
		width=wid;
		height=hei;
	}
	double getWidth()
	{
		return width;
	}
	void setWidth(double wid)
	{
		width=wid;
	}
	double getHeight()
	{
		return height;
	}
	void setHeight(double hei)
	{
		height=hei;
	}
	double getArea()
	{
	return(width*height);
	}
	double getPerimeter()
	{
	return(width*2+height*2);
	}
	public String toString()
	{
	return "Rectangle object with "+" "+color+" "+filled+" "+dateCreated+" "+width+" "+height;
	}
}
class DemoGeo
{
	public static void main(String args[])
	{
	
		Circle cir=new Circle();
		Circle cir2=new Circle("red",true,"01/03/2017",4);
		double car,cp;
		car=cir2.getArea();
		cp=cir2.getPerimeter();
		System.out.println("Area="+car);
		System.out.println("Perimeter="+cp);
		System.out.println(cir2.toString());	
	}
}

