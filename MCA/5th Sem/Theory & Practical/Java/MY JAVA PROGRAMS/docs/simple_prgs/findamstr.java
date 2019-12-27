import java.util.Scanner;

public class findamstr{
	public static void main(String[] args){
		Scanner inp=new Scanner(System.in);
		System.out.println("the amstrong numbers between 111 ang 511 are:");
		long n=111;
		for(;n<=511;n++){
		long s=0;
		long r=n;
		long m=n;
		while(r>0){
			long p=r%10;
			s=s+(p*p*p);
			r=r/10;
			}
		if(s==m)	
			System.out.println(+m);
		}
		}
	}