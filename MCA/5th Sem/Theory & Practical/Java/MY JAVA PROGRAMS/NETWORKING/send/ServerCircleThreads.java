import java.io.*;
import java.net.*;
import java.util.*;
public class ServerCircleThreads implements Runnable
{
			int port=8090;
			ServerSocket server;
			Socket socket;
			DataInputStream in;
			DataOutputStream out;
			Scanner sc = new Scanner(System.in);
			Thread t;
			double r,area;
	
	ServerCircleThreads()
	{
		
			try{
					server=new ServerSocket(port);
					socket=server.accept();
			}catch(IOException e){
				System.out.println("Error : "+e);
			}
			t=new Thread(this);
			t.start();
			while(true){
				try{
				System.out.print("Enter Data: ");
				r=sc.nextDouble();
				out = new DataOutputStream(socket.getOutputStream());
				out.writeDouble(r);
			}catch(Exception e){}
			}
			
	}
	
	public void run()
	{
		while(true)
		{		
			try{
					in = new DataInputStream(socket.getInputStream());
					r=in.readDouble();
			}catch(IOException e){}
			if(r>0)
			System.out.println("\nReceive '"+r+"' from client");
			
		}	
	}
		
	public static void main(String args[])
	{
			new ServerCircleThreads();
	}
	
}