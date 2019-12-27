import java.util.Scanner;

public class rcrcvfact{
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("Enter the number");
		long n=input.nextInt();
		long s=fact(n);
		System.out.println("the factorial of the number is :"+s);
		}
	public long fact(long n){
			
		long f=n*fact(n-1);
		return f;
		}
	}