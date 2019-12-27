import java.util.Scanner;

public class sum1{
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("Enter how many terms");
		int n=input.nextInt();
		double i=2,j=9;
		double s=0;
		for(int k=1;k<=n;k++){
			if(k%2==0)
				s=s-(i/j);
			else
				s=s+(i/j);
			i=i+3;
			j=j+4;
			}
		System.out.println("the sum is:"+s);
		}
	}	