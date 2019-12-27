import java.io.*;			
import java.net.*;
import java.util.Date;

public class client
		{
	public static void main(String[] args) throws IOException
	{
		Socket dateSocket = null;				// Socket 
		BufferedReader dateIn = null;		// Input Stream
		BufferedReader stdin = new BufferedReader(new InputStreamReader(System.in));	//Input from keybord
		PrintWriter out=null ;				// Write to Stream
		
		System.out.println ("Attemping to connect to host  on port 12345.");
		try 
		{
			dateSocket = new Socket(InetAddress.getByName("127.0.0.1"), 12345);   			// Create a client socket connected to the server and port and get a stream from it.			
		    dateIn = new BufferedReader(new InputStreamReader(dateSocket.getInputStream()));			
			out = new PrintWriter(dateSocket.getOutputStream(), true);
		} 
		catch (UnknownHostException e)
 		{
			System.err.println("Server 'localhost' is unknown.");
			System.exit(1); 
		}
		catch (IOException e) 
		{
			System.err.println("Error during connection to 'localhost'.");
			System.exit(1);
		}
		try 
		{
			System.out.println("Enter a File Name:");
			String fileName=stdin.readLine();
			
			out.println(fileName);				// Writing file name to Stream			
			System.out.println("Writing....");
			String serverDate = dateIn.readLine();	// 3.- Read and print the answer from the server.						
			System.out.println ("Content " + serverDate);
		} 
		catch (Exception e) 
		{
			System.err.println ("Not a Date object returned.");
			System.exit(1);
		}
		dateIn.close();		 // 4.- Close streams and sockets used.
		dateSocket.close();
	}
}