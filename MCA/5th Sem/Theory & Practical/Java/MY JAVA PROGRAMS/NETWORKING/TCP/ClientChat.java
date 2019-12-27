import java.io.*;
import java.net.*;
import java.util.*;
public class ClientChat implements Runnable
{
			int port=8090;
			InputStreamReader in;
			PrintWriter out;			
			BufferedReader br,ibr;
			Socket socket;
			String str;
			Thread t;
			
			
	ClientChat()
	{
			try{	
				str="";
				br=new BufferedReader(new InputStreamReader(System.in));
					socket=new Socket(InetAddress.getLocalHost(),port);
			}catch(IOException e){System.out.println("Error : "+e);}
			t=new Thread(this);
			t.start();
			while(!str.equalsIgnoreCase("bye")){
				try{
						System.out.print("Enter Data: ");
						//r=sc.nextDouble();
						str=br.readLine();
						out = new PrintWriter(socket.getOutputStream());
						out.println(str);
						out.flush();
				}catch(IOException e){ System.out.println("Error : "+e); }
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
			System.out.println("\nServer: "+str);

		}	
	}
		
	public static void main(String args[])
	{
			new ClientChat();
	}
	
}