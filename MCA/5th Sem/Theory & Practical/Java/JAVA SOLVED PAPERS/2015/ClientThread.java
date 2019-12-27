import java.io.*;
import java.net.*;
public class ClientThread implements Runnable
{
	String str;
	Thread t;
	BufferedReader br,nbr;
	InputStreamReader in;
	PrintWriter out;
	Socket socket;
	ClientThread()
	{
		try
		{
			br=new BufferedReader(new InputStreamReader(System.in));
			socket=new Socket(InetAddress.getLocalHost(),8000);
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
			System.out.println("Message from server:"+str);
		}
	}
	public static void main(String args[])
	{
		new ClientThread();
	}
}
			