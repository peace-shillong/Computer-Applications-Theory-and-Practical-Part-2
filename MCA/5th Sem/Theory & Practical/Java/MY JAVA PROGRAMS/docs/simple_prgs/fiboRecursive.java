import java.util.Scanner;

public class fiboRecursive{
	public static void main(String[] args){
		Scanner in=new Scanner(System.in);
		System.out.println("Enter which term in the fibonacci series u want to get");
		long n=in.nextInt();
		long a=0,b=1,i=0;
		if(n<=0)
			System.out.println("please enter a value greater than 0");
		else
			System.out.println("The "+n+"th term number in the series is:"+fibo(a,b,n,++i));
		}
	public static long fibo(long a,long b,long n,long i){
		if(n==i)
			return a;
		else{
			long c=a+b;
			return fibo(b,c,n,++i);
			}
		}
	}