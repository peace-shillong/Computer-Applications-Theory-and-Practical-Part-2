import java.util.Scanner;

public class decimal{
	public static void main(String[] args){
		Scanner in=new Scanner(System.in);
		System.out.println("Enter the decimal number");
		long n=in.nextInt();
		long m1=n;
		long m2=n;
		long r1=0,r2=0,r3=0,bn=0,hx=0,oc=0;
		long c1=0,c2=0,c3=0;
		System.out.println();
		while(n>=2){
			long p1=n%2;
			r1=r1*10+p1;
			c1++;
			n=n/2;
			}
			r1=r1*10+n;
			c1++;
		while(c1>0){
			long q1=r1%10;
			bn=bn*10+q1;
			r1=r1/10;
			c1--;
			}
		System.out.println("----BINARY EQUIVALENT----");
		System.out.println();
		System.out.printf("%d",bn);
		
		System.out.println();
		while(m1>=16){
			long p2=m1%16;
			r2=r2*10+p2;
			m1=m1/16;
			c2++;
			}
			r2=r2*10+m1;
			c2++;
		while(c2>0){
			long q2=r2%10;
			hx=hx*10+q2;
			r2=r2/10;
			c2--;
			}
		System.out.println("----HEXADECIMAL EQUIVALENT----");
		System.out.println();
		System.out.println(+hx);

		System.out.println();
		while(m2>=8){
			long p3=m2%8;
			r3=r3*10+p3;
			m2=m2/8;
			c3++;
			}
			r3=r3*10+m2;
			c3++;
		while(c3>0){
			long q3=r3%10;
			oc=oc*10+q3;
			r3=r3/10;
			c3--;
			}
		System.out.println("----OCTAL EQUIVALENT----");
		System.out.println();
		System.out.println(+oc);
		}
	}