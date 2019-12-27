import java.io.*;
import java.net.*;

class UDPServer
{
	public static void main(String args[]) throws IOException
    {
        byte[] receiveData = new byte[1024];
        byte[] sendData = new byte[1024];
		
		DatagramSocket serverSocket = new DatagramSocket(8000);
		DatagramPacket receivePacket = new DatagramPacket(receiveData, receiveData.length);
		BufferedReader br =new BufferedReader(new InputStreamReader(System.in));
		System.out.println("Server is Running....");		
       while(true)
		{
			serverSocket.receive(receivePacket);
			String str = new String(receivePacket.getData(),0,recievepacket.getLength());
			if(str.equals("QUIT"))
			{
				System.out.println("Terminated..");
				break;
			}
			System.out.println("Client Side: " + str);
			InetAddress IPAddress = receivePacket.getAddress();
			int port = receivePacket.getPort();
			String sentence = br.readLine();
			sendData = sentence.getBytes();
			DatagramPacket sendPacket =new DatagramPacket(sendData, sendData.length, IPAddress, port);
			serverSocket.send(sendPacket);
		}   
    }
}