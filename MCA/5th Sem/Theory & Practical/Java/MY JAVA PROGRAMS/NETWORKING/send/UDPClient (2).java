import java.io.*;
import java.net.*;

class UDPClient
{
	public static void main(String args[]) throws Exception
	{
		byte[] sendData = new byte[1024];
		byte[] receiveData = new byte[1024];
		
	
		DatagramSocket clientSocket = new DatagramSocket();
		DatagramPacket receivePacket = new DatagramPacket(receiveData, receiveData.length);
		BufferedReader br =new BufferedReader(new InputStreamReader(System.in));
			
		InetAddress IPAddress = InetAddress.getByName("localhost");
		System.out.println("Client is Running...");
		System.out.println("Type QUIT to Stop.");

		while(true)
		{
			String sentence = br.readLine();
			sendData = sentence.getBytes();
			if(sentence.equals("QUIT"))
			{
				System.out.println("Terminated.");
				clientSocket.send(new DatagramPacket(sendData, sendData.length, IPAddress, 8000));
				break;
			}
			DatagramPacket sendPacket = new DatagramPacket(sendData, sendData.length, IPAddress, 8000);
			clientSocket.send(sendPacket);
			clientSocket.receive(receivePacket);
			String str = new String(receivePacket.getData());
			System.out.println("Server Side:" + str);    
		}
	}
}