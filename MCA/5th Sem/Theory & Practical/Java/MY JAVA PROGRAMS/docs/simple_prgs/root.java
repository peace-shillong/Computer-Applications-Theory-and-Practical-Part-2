import java.util.Scanner;

public class root{
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("please enter an integer value for a");
		int a=input.nextInt();
		System.out.println("please enter an integer value for b");
		int b=input.nextInt();
		System.out.println("please enter an integer value for c");
		int c=input.nextInt();
		
		long d=(b*b)-4*a*c;
		
		if(d==0){
			double x=-b/(2*a);
			System.out.println("the root of the equation is:"+x);
			}
		else if(d>0){
			double x=(-b+Math.sqrt(d))/(2*a);
			double y=(-b-Math.sqrt(d))/(2*a);
			System.out.println("the roots of the equation are:"+x+"and"+y);
			}
		else
			System.out.println("The roots are imaginary");
		}
	}