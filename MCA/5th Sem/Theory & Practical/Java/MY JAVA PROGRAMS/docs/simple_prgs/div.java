import java.util.Scanner;

public class div{
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("Please enter a number");
		long n=input.nextLong();
		System.out.println("All the divisor of the given number "+n+" are:");
		System.out.println("----------------------------------------------");
		for(long k=1;k<=n;k++){
			if(n%k==0)
				System.out.println(+k);
			}
		}
	}