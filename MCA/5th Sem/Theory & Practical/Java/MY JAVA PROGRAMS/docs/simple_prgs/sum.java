import java.util.Scanner;

public class sum{
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("Enter till how many terms u want to perform addition in the given series:");
		int n=input.nextInt();
		double s=0;
		double i=1;
		for(;i<=n;i++){
			if(i%2==0)
				s=s-(1/i);
			else
				s=s+(1/i);
			}
		System.out.println("The summation of the series is:"+s);
		}
	}