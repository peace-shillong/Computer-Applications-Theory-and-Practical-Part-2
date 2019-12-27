import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.util.*;
import java.io.*;

 

public class UDPClientChat2 implements Runnable{
	
	public String ip="localhost";
	String message="";
	byte[] receiveData;
	byte[] sendData;
	//Scanner sc = new Scanner(System.in);
	BufferedReader br;
	DatagramSocket clientSocket;
	DatagramPacket receivePacket;
	Thread tt;
	InetAddress local;
	UDPClientChat2()
	{
		receiveData = new byte[1024];
		sendData = new byte[1024];
		int server_port=9090;
		br=new BufferedReader(new InputStreamReader(System.in));
		tt=new Thread(this);
		tt.start();
		try{
		clientSocket = new DatagramSocket(9091);
		local = InetAddress.getByName(ip);
		}catch(Exception e){}
		while(true)
		{
		try{
			
			
			System.out.println("Enter Data: ");
			message=br.readLine();//sc.next();
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
				//System.out.println("sdsd");
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
            new UDPClientChat2();
        }catch(Exception ee){}
    }
	
}
