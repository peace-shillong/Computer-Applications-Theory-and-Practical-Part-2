import java.io.*;
import java.net.*;
import java.util.*;
public class ServerChat implements Runnable
{
			int port=8090;
			ServerSocket server;
			Socket socket;
			InputStreamReader in;
			PrintWriter out;			
			BufferedReader br,ibr;
			Thread t;			
			String str;			
	
	ServerChat()
	{
		
			try{
				str="";
				br=new BufferedReader(new InputStreamReader(System.in));
					server=new ServerSocket(port);
					socket=server.accept();
			}catch(IOException e){
				System.out.println("Error : "+e);
			}
			t=new Thread(this);
			t.start();
			while(!str.equalsIgnoreCase("bye")){
				try{
				System.out.print("Enter Data: ");				
				str=br.readLine();
				out = new PrintWriter(socket.getOutputStream());
				out.println(str);
				out.flush();
			}catch(Exception e){}
			}
			
	}
	
	public void run()
	{
		while(!str.equalsIgnoreCase("bye"))
		{		
			try{
					ibr = new BufferedReader(new InputStreamReader(socket.getInputStream()));
					str=ibr.readLine();
			}catch(IOException e){}			
			if(str!=null)
			System.out.println("\nClient: "+str);
			
		}	
	}
		
	public static void main(String args[])
	{
			new ServerChat();
	}
	
}