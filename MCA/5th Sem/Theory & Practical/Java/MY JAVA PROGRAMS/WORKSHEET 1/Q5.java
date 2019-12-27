import java.util.*;

class Q5{
	public static void main(String args[])
	{
		int a,b,c;
		double d;
		Scanner sc=new Scanner(System.in);
		System.out.print("Enter value of a =");
		a=sc.nextInt();
		System.out.print("Enter value of b =");
		b=sc.nextInt();
		System.out.print("Enter value of c =");
		c=sc.nextInt();
		
		d=b*b-4*a*c;
		
		if(d==0)
		{
			double r=(-b+Math.sqrt(d))/2*a;
			System.out.println("The root is = "+r);
		}
		else if(d>0)
		{
			double r1=(-b+Math.sqrt(d))/2*a;
			double r2=(-b-Math.sqrt(d))/2*a;
			System.out.println("The two roots are = "+r1+" and "+r2);
		}
		else
		{
				
			System.out.println("The equation has no real roots");
		}
	}
}