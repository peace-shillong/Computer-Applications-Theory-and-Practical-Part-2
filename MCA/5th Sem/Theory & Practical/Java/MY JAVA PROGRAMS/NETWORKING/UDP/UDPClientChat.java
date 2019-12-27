import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.util.*;
import java.io.*;

 

public class UDPClientChat implements Runnable{
	
	public String ip="127.0.0.1";
	String message="";
	byte[] receiveData;
	byte[] sendData;
	Scanner sc = new Scanner(System.in);
	DatagramSocket clientSocket;
	DatagramPacket receivePacket;
	Thread tt;
	
	UDPClientChat()
	{
		receiveData = new byte[1024];
		sendData = new byte[1024];
		int server_port=9090;
		tt=new Thread(this);
		tt.start();
		
		while(true)
		{
		try{
			clientSocket = new DatagramSocket();
			InetAddress local = InetAddress.getByName(ip);
			System.out.println("Enter Data: ");
			message=sc.next();
			int msg_length=message.length();
			byte[] msg=message.getBytes();
			DatagramPacket p = new DatagramPacket(msg,msg_length,local,server_port);
			clientSocket.send(p);
		}catch(Exception e){System.out.println(e);}
		}
	}
	
	public void run()
	{
		while(true)
		{
				System.out.println("sdsd");
			try{
				receivePacket=new DatagramPacket(receiveData,receiveData.length);
				clientSocket.receive(receivePacket);
				message = new String(receivePacket.getData());
				System.out.println("From Server  "+message);
			}catch(Exception e){}
		}
	}
	
	public static void main(String[] args) {
       
        try{
            new UDPClientChat();
        }catch(Exception ee){}
    }
	
}
