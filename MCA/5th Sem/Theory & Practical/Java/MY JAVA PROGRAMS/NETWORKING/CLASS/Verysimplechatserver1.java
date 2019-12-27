
import java.io.*;
import java.net.*;
import java.util.*;

public class Verysimplechatserver1
{
       
	PrintWriter clientOutputStreams[]=new PrintWriter[10];
	int i=0;   //no of clients connected

        public class ClientHandler implements Runnable
        {
		BufferedReader reader ;  //reading clients message
           	Socket sock;			//client's socket
           	public ClientHandler(Socket clientSocket)
           	{
                	try
			{
                    		sock = clientSocket;
                   		InputStreamReader isReader = new InputStreamReader(sock.getInputStream());
                    		reader = new BufferedReader(isReader);

                	}
                	catch(Exception ex)
                	{
                   		 ex.printStackTrace();

                	}

            	}
           	public void run()
            	{
                	String message;
                	try
                	{
                    		while((message = reader.readLine()) !=null)
                    		{
                        		System.out.println("read"+ message);
                                	telleveryone(message);
                    		}
                	}
                 	catch(Exception ex)
                	{
                    		ex.printStackTrace();

                	}
	    	 }

    	}
	public static void main(String args[]) 
	{
		new Verysimplechatserver1().go();
	}
        public void go()
	{

		
                try
		{
                    ServerSocket serverSock = new ServerSocket(5000);
                    while(true)
                    {
                        Socket clientSocket = serverSock.accept();

			//extract client's output streams
                   	PrintWriter writer = new PrintWriter(clientSocket.getOutputStream());
                    	clientOutputStreams[i++]=writer;

			//one thread per client
		       	Thread t = new Thread (new ClientHandler(clientSocket));
                    	t.start();
                    	System.out.println("got a connection");
                    }
		}
                catch(Exception ex)
                {
                    ex.printStackTrace();

                }
	}
	public void telleveryone(String message)
        {
        	
        	for(int j=0;j<i;j++)
        	{
            		try
            		{
				clientOutputStreams[j].println(message);
				clientOutputStreams[j].flush();
            		}
                	catch(Exception ex)
                	{
                    		ex.printStackTrace();

               		 }
           	 }
         }
}

	

        