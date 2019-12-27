import java.io.*;			
import java.net.*;
import java.util.Date;
public class DateClient {
	public static void main(String[] args) throws IOException {
		Socket dateSocket = null;
		ObjectInputStream dateIn = null;
		try {
		                dateSocket = new Socket(InetAddress.getByName("localhost"), 12345);   
// 2.- Create a client socket connected to the server and port and get a stream from it.
		               dateIn = new ObjectInputStream(dateSocket.getInputStream());
		} catch (UnknownHostException e) {
			System.err.println("Server 'localhost' is unknown.");
			System.exit(1); 
}
catch (IOException e) {
			System.err.println("Error during connection to 'localhost'.");
			System.exit(1);
		}
		try {
			Date serverDate = (Date) dateIn.readObject();	
			// 3.- Read and print the answer from the server.
			System.out.println ("Current server time: " + serverDate);
		} catch (ClassNotFoundException e) {
			System.err.println ("Not a Date object returned.");
			System.exit(1);
		}
		dateIn.close();		 // 4.- Close streams and sockets used.
		dateSocket.close();
	}
}
