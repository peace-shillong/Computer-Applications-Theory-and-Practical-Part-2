import java.util.Scanner;

public class datecheck{
		public static void main(String[] args){
			Scanner input=new Scanner(System.in);
			System.out.println("enter the date");
			int d=input.nextInt();
			System.out.println("enter the month");
			int m=input.nextInt();
			System.out.println("enter the year");
			int y=input.nextInt();
			if((d>=1 && d<=31) && (m>=1 && m<=12) && (y<=2013))
			{
				System.out.println("the date "+d+"-"+m+"-"+y+" is valid");	
			}
			else
				System.out.println("sorry... date is not valid!!!");
			}
		}