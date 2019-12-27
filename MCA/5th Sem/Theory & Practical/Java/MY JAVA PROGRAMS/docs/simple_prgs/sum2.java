import java.util.Scanner;

public class sum2{
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("Enter till how many terms we have to make addition in the series given");
		int n=input.nextInt();
		double i=1;
		double s=1;
		while(i<n){
			double j=i;
			double f=1;
			for( ;j>0;j--)
				f=(f*j);
			s=s+(1/f);
			i=i+1;
			}
		System.out.println("The result is:"+s);
		}
	}