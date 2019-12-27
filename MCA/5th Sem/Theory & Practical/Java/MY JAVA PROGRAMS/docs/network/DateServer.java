import java.net.*;	
import java.io.*;
import java.util.Date;
import java.awt.*;
public class DateServer 
{	
	 public static void main(String [] args) {
		ServerSocket server = null;
		Socket client;
		try {
		server = new ServerSocket(12345);    // 2.- Create a server socket in a “well-known” port
 		} catch (IOException ie) {
			 System.out.println("Cannot open socket.");
			 System.exit(1);
 		}
		while(true) {
		try {
			client = server.accept();	
			//  3.- Create a new client socket upon acceptance.
			ObjectOutputStream dateOut = null;
			dateOut = new ObjectOutputStream(client.getOutputStream());    
			dateOut.writeObject(new Date());		
		//4.- Get a stream from the socket and send answer to the client.
			dateOut.close();
			client.close();
			server.close();
		// 5.- Close streams and sockets used.
		} catch (IOException ie) {}
	}
}
}