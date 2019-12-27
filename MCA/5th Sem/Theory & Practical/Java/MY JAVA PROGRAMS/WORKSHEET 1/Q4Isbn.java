import java.util.*;

class Q4Isbn{
public static void main(String args[])
{
	Scanner sc=new Scanner(System.in);
	int digits[]=new int[9];
	int sum=0,r;
	System.out.println("Enter the 9 digits of ISBN:");
	
	for(int i=0;i<9;i++)
		digits[i]=sc.nextInt();
	
	for(int i=1;i<=9;i++)
	{
		sum=sum+(digits[i-1]*i);
	}
	
	r=sum%11;
	
	for(int i=0;i<9;i++)
		{
			System.out.print(digits[i]);
		}
		
	if(r==10)
	{		
		System.out.print("X");
	}
	else
	{		
		System.out.print(r);
	}
}
}
	