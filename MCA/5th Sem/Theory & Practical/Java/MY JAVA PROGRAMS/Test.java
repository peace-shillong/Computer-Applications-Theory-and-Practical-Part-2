import java.util.*;

class Test{

	public static void main(String args[])
	{
		Scanner sc=new Scanner(System.in);

		int no;
		System.out.println("Enter Some Integers");
		if(sc.hasNextInt())
		{
			no=sc.nextInt();
			System.out.println("Integer:"+no);		
		}
	}
	
}