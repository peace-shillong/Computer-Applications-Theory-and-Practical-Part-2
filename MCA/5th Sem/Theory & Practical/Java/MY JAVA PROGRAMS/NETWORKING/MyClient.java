import java.io.*;
import java.util.*;
import java.net.*;
public class MyClient
{
	public static void main(String[] args)
	{
		int port=8000;
		//String host="l92.168.46.44";
		DataInputStream in;
		DataOutputStream out;
		Socket socket;
		double radius=7;
		Scanner sc=new Scanner(System.in);
		try
		{
			socket=new Socket(InetAddress.getLocalHost(),port);
			System.out.println("Enter The radius:");
			radius=sc.nextDouble();
			in=new DataInputStream(socket.getInputStream());
			out=new DataOutputStream(socket.getOutputStream());
			out.writeDouble(radius);
			System.out.println("Area is : "+in.readDouble());
		}catch(UnknownHostException ex)
		{
			System.out.println(ex);
		}
		catch(IOException e)
		{
			System.out.println(e);
		}
		
	}
}