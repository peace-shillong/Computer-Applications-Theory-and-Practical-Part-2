import java.util.Scanner;

public class power{
	public static void main(String[] args){
		Scanner in=new Scanner(System.in);
		System.out.println("Enter the value for x");
		int x=in.nextInt();
		System.out.println();
		System.out.println("Enter the value for y");
		int y=in.nextInt();
		
		System.out.println();
		if(y<0)
			System.out.println("the power is negative...kindly put a positive value");
		else		
			System.out.println("The result is:"+pow(x,y));
		System.out.println();
		}
	public static int pow(int x,int y){
		if(y==0)
			return 1;
		else
			return x*pow(x,y-1);
		}
	}		