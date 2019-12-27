class Complex
{
	double real;
	double imag;
	Complex()
	{
		real=imag=0;
	}
	Complex(double r,double i)
	{
		real=r;
		imag=i;
	}
	Complex add(Complex a)
	{
		Complex b=new Complex();
		b.real=this.real+a.real;
		b.imag=this.imag+a.imag;
		return b;
	}
	void display()
	{
		System.out.println("The real partis"+ real);
		System.out.println("The imag part is="+ imag);
	}

}
class DemoComplex
{
	public static void main(String args[])
	{
		Complex c= new Complex(2,3);
		Complex a=new Complex(3,4);
		Complex q=new Complex();
		q=c.add(a);
		q.display();
	}
}