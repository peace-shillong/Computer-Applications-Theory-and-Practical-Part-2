import java.util.Scanner;

public class prime{
	public static void main(String[] args){
		System.out.println("hi!!!the first 20 prime numbers are:");
		System.out.println("-------------------------------------");
		int c=0;
		for(int n=1;c<20;n++){
			int p=0;
			for(int k=1;k<=n;k++){
				if(n%k==0)
					p++;
				}
			if(p==2){
				System.out.println(+n);
				c++;
				}
			}	
		}
	}