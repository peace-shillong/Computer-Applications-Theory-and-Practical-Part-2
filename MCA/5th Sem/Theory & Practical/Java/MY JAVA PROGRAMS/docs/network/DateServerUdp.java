import java.io.*;	
import java.net.*;
import java.util.Date;
public class DateServerUdp {
	public static void main(String args[]) throws IOException {
		DatagramSocket socket = null;
		socket = new DatagramSocket(1313);  
			
		for (int i = 0; i < 10; i++) {
		       byte[] buf = new byte[256];
		      DatagramPacket packet = new DatagramPacket(buf, buf.length);      
				
		     socket.receive(packet);	
 buf = new Date().toString().getBytes();	
						
		InetAddress address = packet.getAddress();	
					
		int port = packet.getPort();
	packet = new DatagramPacket(buf, buf.length, address, port);	
		socket.send(packet);		
	} 
	socket.close();				
	}
}
