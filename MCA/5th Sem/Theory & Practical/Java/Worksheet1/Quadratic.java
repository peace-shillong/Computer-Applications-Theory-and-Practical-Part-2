class Quad
{
	double a;
	double b;
	double c;
	
	Quad()
	{
		a=b=c=1;
	}
	Quad(double x,double y,double z)
	{
		a=x;
		b=y;
		c=z;
	}
	void displayRoots()
	{
		System.out.println(a+"x2 + "+b+"x + "+c);
	}
	void roots()
	{
		double d,r1,r2;
		d=(b*b)-(4*a*c);
		if(d<0)
		{
			System.out.println("The equation has two real roots");
			r1=(-b+Math.pow(d,0.5))/2*a;
			r2=(-b-Math.pow(d,0.5))/2*a;
			System.out.println("The two roots are "+r1+" and "+r2);
		}
		else if(d==0)
		{
			System.out.println("The equation has one root");
			r1=(-b+Math.pow(d,0.5))/2*a;
			System.out.println("The root is "+r1);
		}
		else
		{
			System.out.println("The equation has no real roots");
		}
	}
}
class Quadratic
{
	public static void main(String args[])
	{
		Quad q=new Quad(1,4,4);
		q.displayRoots();
		q.roots();
		
		Quad q2=new Quad(2,4,5);
		q2.displayRoots();
		q2.roots();
	}
}