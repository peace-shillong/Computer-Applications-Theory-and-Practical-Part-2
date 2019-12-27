import java.util.Scanner;

public class fibo{
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("Enter the value for number of term n!!!");
		int n=input.nextInt();
		int a=0;
		int b=1;

		System.out.println("The first "+n+" numbers in fibonacci series are:");
		for(int i=1;i<=n;i++){
			int c=a+b;
			System.out.println(+a);
			a=b;
			b=c;
			}
		}
	}