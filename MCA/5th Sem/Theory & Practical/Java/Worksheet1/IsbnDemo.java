import java.util.*;
class Isbn{
	int arr[]=new int[10];
	int tos=-1;
	void insert(int val)
	{
		tos=tos+1;	
		arr[tos]=val;
	}
	void display()
	{
		arr[9]=((arr[0]*1)+(arr[1]*2)+(arr[2]*3)+(arr[3]*4)+(arr[4]*5)+(arr[5]*6)+(arr[6]*7)+(arr[7]*8)+(arr[8]*9))%11;
		if(arr[9]==10)
		{
			
			System.out.println("The 10-digit ISBN are ");
			for(int i=0;i<9;i++)
			{
				System.out.print(arr[i]+" ");
			}
			System.out.print("X");
		}
		else
		{
			System.out.println("The 10-digit ISBN are ");
			for(int i=0;i<=9;i++)
			{
				System.out.print(arr[i]+" ");
			}
			
		}
	}
}

class IsbnDemo
{
	public static void main(String args[])
	{
		int i;
		Isbn obj = new Isbn();
		
		for(i=0;i<10;i++)
		{
			System.out.println("Please enter number : ");
			Scanner sc = new Scanner(System.in);
			i=sc.nextInt();
			obj.insert(i);
		}
		
		obj.display();
	}
}