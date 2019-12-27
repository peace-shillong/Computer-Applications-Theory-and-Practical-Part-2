import java.util.Scanner;

public class reverse{
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("Enter the number");
		long n=input.nextLong();
		long r=0;
		while(n>0){
			long p=n%10;
			r=r*10+p;
			n=n/10;
			}
		System.out.println("the reverse of the given number is:"+r);
	}

}