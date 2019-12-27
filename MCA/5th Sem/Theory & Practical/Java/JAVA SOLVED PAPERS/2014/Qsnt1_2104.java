class Rational
{
	private int num;
	private int deno;
	Rational()
	{
		num=1;
		deno=2;
	}
	Rational(int n,int d)
	{
		int i=1,n1,d1;
		int hcf=find_hcf(n,d);
		n1=n/hcf;
		d1=d/hcf;
		num=n1;
		deno=d1;
	}
	Rational(Rational r)
	{
		int n1,d1;
		int hcf=find_hcf(r.num,r.deno);
		n1=r.num/hcf;
		d1=r.deno/hcf;
		num=n1;
		deno=d1;
	}
	int find_hcf(int n,int d)
	{
		int min=Math.min(n,d);
		int hcf=0;
		for(int i=min;i>=1;i--)
		{
			if(n%i==0 && d%i==0)
			{
				hcf=i;
				break;
			}
		}
		return hcf;
	}
	void add(Rational a,Rational b)
	{
		int lcm=0,hcf=0;
		hcf=find_hcf(a.deno,b.deno);
		lcm=(a.deno*b.deno)/hcf;
		num=((lcm/a.deno)*a.num)+((lcm/b.deno)*b.num);
		deno=lcm;
	}
	void subtract(Rational a,Rational b)
	{
		int lcm=0,hcf=0;
		hcf=find_hcf(a.deno,b.deno);
		lcm=(a.deno*b.deno)/hcf;
		num=((lcm/a.deno)*a.num)-((lcm/b.deno)*b.num);
		deno=lcm;
	}
	void mult(Rational a,Rational b)
	{
		num=a.num*b.num;
		deno=a.deno*b.deno;
	}
	void mult_scalar(Rational a)
	{
		num=a.num*2;
		deno=a.deno;
	}
	void div(Rational a,Rational b)
	{
		num=a.num*b.deno;
		deno=a.deno*b.num;
	}
	
	void display()
	{	
		int n1,d1;
		int hcf=find_hcf(num,deno);
		n1=num/hcf;
		d1=deno/hcf;
		num=n1;
		deno=d1;
		System.out.println("Rational Number="+num+"/"+deno);
	}
}
class Qsnt1_2104
{
	public static void main(String args[])
	{
		Rational r1=new Rational();
		r1.display();
		Rational r2=new Rational(5,6);
		r2.display();
		Rational r3=new Rational(r1);
		/*r3.add(r2,r3);
		System.out.println("After addition");
		r3.display();
		
		r3.subtract(r2,r3);
		System.out.println("After subtraction");
		r3.display();
		*/
		r3.mult(r2,r3);
		System.out.println("After multiplication");
		r3.display();
		/*
		r3.mult_scalar(r2);
		System.out.println("After scalar multiplication");
		r3.display();
		r3.div(r2,r3);
		System.out.println("After division");
		r3.display();*/
	}
}
		