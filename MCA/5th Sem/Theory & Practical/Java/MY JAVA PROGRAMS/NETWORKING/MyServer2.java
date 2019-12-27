import java.io.*;
import java.net.*;
public class MyServer2
{
	double radius;
	int port=8000;
		
	//final DataOutputStream out;
	ServerSocket server;
	Socket socket;
	double area;
	DataInputStream in;				
	
	
	MyServer2()
	{
		try
		{
			server=new ServerSocket(port);
			System.out.println("Waiting For Client");
			
			socket=server.accept();
						
			class InputThread implements Runnable {
				Thread t;
				Socket sc;
				
				
				InputThread(Socket s)
				{
					t=new Thread(this);
					sc=s;
					try{
					in=new DataInputStream(sc.getInputStream());
					}catch(Exception e){}
					t.start();
				}
				public void run()
				{
					while(true){
						try{
						radius=in.readDouble();
						}catch(Exception e){}
						System.out.println("Radius is :"+radius);
						
					}
				}
			}
			InputThread it=new InputThread(socket);
		}catch(Exception e)	{}
	}
	
	public static void main(String[] args)
	{
		
		
		
		//double radius;
		try
		{
			
			new MyServer2();
			//out=new DataOutputStream(socket.getOutputStream());
			//area=(22*radius*radius)/7;
			//System.out.println(area);
			//out.writeDouble(area);
			//in=new DataInputStream(socket.getInputStream());
			
			//radius=in.readDouble();
			
		}catch(Exception e)
		{
			System.out.println(e);
		}
	}
	
	
}