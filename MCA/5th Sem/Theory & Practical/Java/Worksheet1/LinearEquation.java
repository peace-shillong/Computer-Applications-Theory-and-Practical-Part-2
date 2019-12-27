class LinearEquation
{
	public static void main(String args[])
	{
		double a,b,c,d,e,f;
		a=3.4;
		b=50.2;
		e=44.5;
		c=2.1;
		d=0.55;
		f=5.9;
		System.out.println("x="+(((e*d)-(b*f))/((a*d)-(b*c))));
		System.out.println("y="+(((a*f)-(e*c))/((a*d)-(b*c))));
	}
}