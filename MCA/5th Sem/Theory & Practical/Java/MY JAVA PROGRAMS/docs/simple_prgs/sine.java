import java.util.Scanner;

public class sine{
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("Enter till how many terms we have to make addition in the series given");
		int n=input.nextInt();
		System.out.println("Enter the value of x");
		double x=input.nextDouble();
		
		double s=0;
		for(int i=1;i<=n;i++){
			int j=(2*i)-1;
			int f=1;
			for( ;j>0;j--)
				f=f*j;
			j=(2*i)-1;
			if(i%2==0)
				s=s-(Math.pow(x,j)/f);
			else
				s=s+(Math.pow(x,j)/f);
			}
		System.out.println("The result is:");
		System.out.println("sine(x)="+s);
		}
	}