class Distance
{
	double x;
	double y;
	Distance()
	{
		x=y=1;
	}
	Distance(double a,double b)
	{
		x=a;
		y=b;
	}
	Distance(double l)
	{
		x=y=l;
	}
	double dist2Points(Distance d)
	{
		return (Math.pow((((this.x-d.x)*(this.x-d.x))+((this.y-d.y)*(this.y-d.y))),0.5));
	}
	void displayPoints()
	{
		System.out.println("x="+x);
		System.out.println("y="+y);
	}
}
class DistanceDemo
{
	public static void main(String args[])
	{
			Distance d1=new Distance(2,2);
			Distance d2=new Distance(4,4);
			d1.displayPoints();
			d2.displayPoints();
			System.out.println("The distance between the two points are "+d1.dist2Points(d2));
	}
}