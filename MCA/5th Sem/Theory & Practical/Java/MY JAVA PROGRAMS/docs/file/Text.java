import java.io.*;

public class Text{
	public static void main(String[] args)  throws IOException
	{
		PrintWriter out= new PrintWriter(new File("trial.txt"));
		out.println("Hello World");
		out.println("This is a sample text file");
		out.close();
	}
}	
