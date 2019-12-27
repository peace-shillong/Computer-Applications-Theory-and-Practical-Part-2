import java.util.Scanner;

public class add{
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("enter the first integer");
		int a=input.nextInt();
		System.out.println("enter the 2nd Integer");
		int b=input.nextInt();
		int c=a+b;
		System.out.println("the sum is:"+c);
		}
	}