import java.util.Scanner;
import java.io.*;
public class Text1{
	public static void main(String[] args) throws IOException
	{
		Scanner in = new Scanner(new File("trial.txt"));
		System.out.println(in.nextLine());
		System.out.println(in.nextLine());
		in.close();
	}
}	
