import java.io.*;
import java.net.*;
public class ServerThread implements Runnable
{
	String str;
	Thread t;
	BufferedReader br,nbr;
	InputStreamReader in;
	PrintWriter out;
	ServerSocket server;
	Socket socket;
	ServerThread()
	{
		try
		{
			br=new BufferedReader(new InputStreamReader(System.in));
			server=new ServerSocket(8000);
			socket=server.accept();
		}
		catch(IOException e)
		{
		}
		t=new Thread(this);
		t.start();
		while(true)
		{
			try
			{
				System.out.print("Type Message here:");
				str=br.readLine();
				out=new PrintWriter(socket.getOutputStream());
				out.println(str);
				out.flush();
			}
			catch(IOException e)
			{
			}
		}
	}
	public void run()
	{
		while(true)
		{
			try
			{
				nbr=new BufferedReader(new InputStreamReader(socket.getInputStream()));
				str=nbr.readLine();
			}
			catch(IOException e)
			{
			}
			if(!str.equals("STOP CONVERSATION"))
				System.out.println("Message From Client:"+str);
			else
			{
				try{
				socket.close();
				}
				catch(IOException e)
				{
				}
			}
		}
	}
	public static void main(String args[])
	{
		new ServerThread();
	}
}
