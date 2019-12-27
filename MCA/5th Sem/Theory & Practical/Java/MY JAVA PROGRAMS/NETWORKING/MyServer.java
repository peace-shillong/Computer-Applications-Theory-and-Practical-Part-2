import java.io.*;
import java.net.*;
public class MyServer
{
	public static void main(String[] args)
	{
		int port=8000;
		DataInputStream in;
		DataOutputStream out;
		ServerSocket server;
		Socket socket;
		double radius;
		double area;
		try
		{
			server=new ServerSocket(port);
			System.out.println("Waiting For Client");
			socket=server.accept();
			in=new DataInputStream(socket.getInputStream());
			out=new DataOutputStream(socket.getOutputStream());
			radius=in.readDouble();
			area=(22*radius*radius)/7;
			System.out.println(area);
			out.writeDouble(area);
		}catch(IOException e)
		{
			System.out.println(e);
		}
	}
}