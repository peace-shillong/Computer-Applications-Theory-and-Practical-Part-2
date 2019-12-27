import java.util.Scanner;

public class amstrong{
	public static void main(String[] args){
		Scanner inp=new Scanner(System.in);
		System.out.println("Can u please enter a number?");
		long n=inp.nextLong();
		long r=n;
		long s=0;
		
		while(n>0){
			long p=n%10;
			s=s+(p*p*p);
			n=n/10;
			}
		if(s==r)	
			System.out.println("Congratulation..!!! The given number is an amstrong number");
		else
			System.out.println("Sorry...!!! the given number is not an amstrong number");
		}
	}