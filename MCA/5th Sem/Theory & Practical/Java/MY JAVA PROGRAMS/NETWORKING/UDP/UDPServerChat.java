import java.net.*;
import java.util.*;
import java.io.*;

public class UDPServerChat implements Runnable {
    
    DatagramSocket serverSocket=null;
	String message="";
	byte[] receiveData;
	byte[] sendData;
	public static boolean flag=false;
	Scanner sc = new Scanner(System.in);
	public static DatagramPacket receivePacket;
	public static DatagramPacket sendPacket;
	InetAddress IPAddress;
	int port,c=0;
	Thread t;
  
    UDPServerChat()throws Exception
	{
        serverSocket = new DatagramSocket(9090);
        receiveData = new byte[1024];
		sendData = new byte[1024];
		
		t=new Thread(this);
		t.start();
                    
		while(true){
				System.out.print("");
			if(flag==true)
			{
				System.out.println("Enter Data: ");
				message=sc.next();
				sendData=message.getBytes();
				sendPacket=new DatagramPacket( sendData,sendData.length,IPAddress,port);
				serverSocket.send(sendPacket);
			}
		}
    }
	
	public void run()
	{
		 while(true){
				System.out.println("sdsd");
              try{
					receivePacket = new DatagramPacket(receiveData,receiveData.length);
					serverSocket.receive(receivePacket);
					IPAddress=receivePacket.getAddress();
					port=receivePacket.getPort();
					flag=true;
					message = new String(receivePacket.getData());
					System.out.println("From client: "+message);
				}
				catch(IOException t){}
        }
	}
    
    public static void main(String[] args) {
        
        try{
            new UDPServerChat();
        }catch(Exception ee){}
    }
}