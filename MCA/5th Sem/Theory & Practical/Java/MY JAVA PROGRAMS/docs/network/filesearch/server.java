//Server PROGRAM
import java.net.*;	
import java.io.*;
import java.util.Scanner;

public class server 
{	
	public static void main(String [] args) 
	{
		ServerSocket Server = null;
		Socket client=null;
		
		BufferedReader in =null;
		PrintWriter dateOut=null ;
		
		try 
		{
			Server = new ServerSocket(12345);		    // 2.- Create a Server socket in a “well-known” port
 		} 
		catch (IOException ie) 
		{
			 System.out.println("Cannot open socket.");
			 System.exit(1);
 		}
		System.out.println ("Waiting for connection.....");
		while(true) 
		{
			try 
			{
			client = Server.accept();					//  3.- Create a new client socket upon acceptance.
			System.out.println ("Connection successful");
			System.out.println ("Waiting for input.....");
		
			in = new BufferedReader( new InputStreamReader( client.getInputStream())); 
			
			String fileName=in.readLine();	//4.- Get a stream from the socket and send answer to the client.
			File f=new File(fileName);
			String content="";
			String c;
			dateOut=new PrintWriter(client.getOutputStream(), true);
			if(f.exists())
				{
				 content="File  Exist !!!";
				 	try{
						Scanner fileIn=new Scanner(f);
						while(fileIn.hasNextLine())
						{
							c=fileIn.nextLine();
							content+=c;
						}
					fileIn.close();
					}
				catch(IOException e){}
				}
			else
				content="File Does Not Exist !!!";
				
			dateOut.println(content);				
				
			dateOut.close();
			client.close();						// 5.- Close streams and sockets used.
			} 
			catch (IOException ie) 
			{
			}
		}
	}
}
