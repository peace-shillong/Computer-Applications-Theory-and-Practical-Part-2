class Triangle
{
	double side1;
	double side2;
	double side3;
	
	Triangle()
	{
		side1=side2=side3=1;
	}
	Triangle(double s1,double s2,double s3)
	{
		side1=s1;
		side2=s2;
		side3=s3;
	}
	void setSide1(double s1)
	{
		side1=s1;
	}
	double getSide1()
	{
		return side1;
	}
	void setSide2(double s2)
	{
		side2=s2;
	}
	double getSide2()
	{
		return side2;
	}
	void setSide3(double s3)
	{
		side3=s3;
	}
	double getSide3()
	{
		return side3;
	}
	double getPerimeter()
	{
		return (side1+side2+side3);
	}
	double getArea()
	{
		double s;
		s=(side1+side2+side3)/2;
		return (Math.sqrt(s*(s-side1)*(s-side2)*(s-side3)));
	}
}
class TriangleDemo
{
	public static void main(String args[])
	{
		Triangle t=new Triangle(2,3,4);
		System.out.println("Side1="+t.getSide1());
		System.out.println("Side2="+t.getSide2());
		System.out.println("Side3="+t.getSide3());
		System.out.println("The perimeter of the triangle="+t.getPerimeter());
		System.out.println("The area of the triangle="+t.getArea());
	}
}