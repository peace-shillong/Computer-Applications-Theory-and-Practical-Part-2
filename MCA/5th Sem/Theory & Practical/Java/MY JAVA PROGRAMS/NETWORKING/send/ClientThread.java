import java.io.*;
import java.net.*;
import java.util.*;
public class ClientThread implements Runnable
{
			int port=8090;
			DataInputStream in;
			DataOutputStream out;
			Scanner sc = new Scanner(System.in);
			Socket socket;
			double r;
			Thread t;
			
	ClientThread()
	{
			try{
					socket=new Socket(InetAddress.getLocalHost(),port);
			}catch(IOException e){System.out.println("Error : "+e);}
			t=new Thread(this);
			t.start();
			while(true){
				try{
						System.out.print("Enter Data: ");
						r=sc.nextDouble();
						out = new DataOutputStream(socket.getOutputStream());
						out.writeDouble(r);
				}catch(IOException e){ System.out.println("Error : "+e); }
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
			{
			System.out.println("\nReceive '"+r+"' from server");
			}
		}	
	}
		
	public static void main(String args[])
	{
			new ClientThread();
	}
	
}