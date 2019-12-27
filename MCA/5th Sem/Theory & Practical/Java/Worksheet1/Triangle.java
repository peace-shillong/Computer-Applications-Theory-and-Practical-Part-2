class Point
{
	double x;
	double y;
	Point()
	{
		x=y=1;
	}
	Point(double a,double b)
	{
		x=a;
		y=b;
	}
	Point(double l)
	{
		x=y=l;
	}
	void display()
	{
		System.out.println("x="+x);
		System.out.println("y="+y);
	}
	double area(Point p1,Point p2)
	{
		double s1,s2,s3,s,ar;
		s1=Math.pow((((p1.x-this.x)*(p1.x-this.x))+((p1.y-this.y)*(p1.y-this.y))),0.5);
		s2=Math.pow((((p2.x-this.x)*(p2.x-this.x))+((p2.y-this.y)*(p2.y-this.y))),0.5);
		s3=Math.pow((((p1.x-p2.x)*(p1.x-p2.x))+((p1.y-p2.y)*(p1.y-p2.y))),0.5);
		s=(s1+s2+s3)/2;
		ar=Math.sqrt(s*(s-s1)*(s-s2)*(s-s3));
		return ar;
	}
}
class Triangle
{
	public static void main(String args[])
	{
		Point a=new Point(1,1);
		a.display();
		Point b=new Point(6,2);
		b.display();
		Point c=new Point(3,7);
		c.display();
		//double areaTri=a.area(b,c);
		System.out.println("The area of the triangle is "+(a.area(b,c)));
	}
}