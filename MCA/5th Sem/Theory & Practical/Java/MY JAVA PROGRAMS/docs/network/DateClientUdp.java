import java.io.*;		
import java.net.*;
import java.util.Date;
public class DateClientUdp 
{
	public static void main(String[] args) throws IOException, InterruptedException {
	    DatagramSocket socket = new DatagramSocket();
	    for (int i = 0; i < 5; i++) {
		byte[] buf = new byte[256];
		InetAddress address = InetAddress.getByName("localhost"); 
			// 2.- Create a datagram socket in an available port
DatagramPacket packet = new DatagramPacket(buf, buf.length, address, 1313);
socket.send(packet);	 
				// 3.- Send an empty packet to the server.
		packet = new DatagramPacket(buf, buf.length);
		socket.receive(packet);	// 4.-Wait for the server answer
		String received = new String(packet.getData());  
				// 5.- Get server response and print it.
		System.out.println("Current server time: " + received);
		Thread.sleep(1700);
	} //end for loop.
	socket.close();	
				// 6.- Close the socket. 
	}
}
