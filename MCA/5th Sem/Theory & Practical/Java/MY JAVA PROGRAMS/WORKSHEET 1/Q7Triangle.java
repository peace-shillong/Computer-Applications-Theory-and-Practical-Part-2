import java.util.*;
class Q7Triangle{
	public static void main(String args[])
	{
		Scanner sc=new Scanner(System.in);
		double x1,x2,x3,y1,y2,y3,side1,side2,side3,area,s,a;
		System.out.print("Enter x1,y1");
		x1=sc.nextDouble();		
		y1=sc.nextDouble();
		System.out.print("Enter x2,y2");
		x2=sc.nextDouble();		
		y2=sc.nextDouble();
		System.out.print("Enter x3,y3");
		x3=sc.nextDouble();		
		y3=sc.nextDouble();
		
		side1=Math.sqrt(((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)));
		side2=Math.sqrt(((x1-x3)*(x1-x3)+(y1-y3)*(y1-y3)));
		side3=Math.sqrt(((x3-x2)*(x3-x2)+(y3-y2)*(y3-y2)));
		
		s=(side1+side2+side3)/2;
		a=s*((s-side1)*(s-side2)*(s-side3));
		
		area=Math.pow(a,0.5);
		System.out.println("Area of the Triangle = "+area);
	}
}