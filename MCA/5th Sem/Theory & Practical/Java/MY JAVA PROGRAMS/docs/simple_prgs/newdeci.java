import java.util.Scanner;

public class newdeci{
	public static void main(String[] args){
		Scanner in=new Scanner(System.in);
		System.out.println();
		System.out.println("Enter the decimal number");
		int n=in.nextInt();
		System.out.println();
		System.out.println("Binary equivalent is:");
		System.out.println();
		bin(n);
		System.out.println();
		System.out.println();
		System.out.println("Hexadecimal equivalent is:");
		System.out.println();
		hex(n);
		System.out.println();
		System.out.println();
		System.out.println("octal equivalent is:");
		System.out.println();
		oct(n);
		System.out.println();
		}
		public static void bin(int n)
		{
			if(n!=1)
			   bin(n/2);	
			System.out.printf("%d",n%2);
		}
		
		public static void hex(int n)
		{	
			if(n>=16)
			   hex(n/16);
			
			switch(n%16)
			{case 10:{
				System.out.print("A");
				break;	
				}
			case 11:{
				System.out.print("B");
				break;
				}
			case 12:{
				System.out.print("C");
				break;	
				}
			case 13:{
				System.out.print("D");
				break;
				}
			case 14:{
				System.out.print("E");
				break;	
				}
			case 15:{
				System.out.print("F");
				break;
				}
			default:{
				System.out.print(+(n%16));
				break;		
				}
			}
		}
		public static void oct(int n){
			if(n>=8)
				oct(n/8);
			System.out.printf("%d",n%8);
			}
		
	}	