import java.io.*;
import java.util.Scanner;
public class intStore{
	public static void main(String[] args)  throws IOException
	{	Scanner in=new Scanner(System.in);
		PrintWriter out= new PrintWriter(new File("Numbers.txt"));
		System.out.println("How many integers?");
		int n=in.nextInt();
		int val;
		System.out.println("Enter the integers:");
		for(int i=1;i<=n;i++){
			val=in.nextInt();
		//out.println();
		out.println(+val);
		}
		out.close();
		Scanner in1 = new Scanner(new File("Numbers.txt"));
		System.out.println("the integers are:");
		for(int i=1;i<=n;i++){
		System.out.println(in1.nextInt());
		
		}
		in1.close();
	}
}	