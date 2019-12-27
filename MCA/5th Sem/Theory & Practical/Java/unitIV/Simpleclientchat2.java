import java.net.*;
import java.io.*;
import java.util.*;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Simpleclientchat2 
{
	JTextArea incomming;
	JTextField outgoing;
	BufferedReader reader;
	PrintWriter writer;
	Socket sock;
	String username;

	public static void main(String args[]) 
	{
		
		Simpleclientchat1 cl = new Simpleclientchat1();
                cl.go(args[0]);
	}
	public void go(String name)
	{	
		username=name;
		JFrame frame =new JFrame("Simple clientchat");
		JPanel mainPanel = new JPanel();

		incomming = new JTextArea(15,50);
        	incomming.setLineWrap(true);
		incomming.setWrapStyleWord(true);
		incomming.setEditable(false);

		JScrollPane qScroller = new JScrollPane(incomming);
		qScroller.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);
		qScroller.setHorizontalScrollBarPolicy(ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);

		outgoing = new JTextField(20);
		JButton sendButton = new JButton("Send");
		sendButton.addActionListener(new SendButtonListener());

		mainPanel.add(qScroller);
		mainPanel.add(outgoing);
		mainPanel.add(sendButton);
 
		setupnetworking();
		
		Thread readerThread = new Thread(new IncommingReader());
		readerThread.start();
	
		frame.getContentPane().add(BorderLayout.CENTER,mainPanel);
		frame.setSize(700,400);
		frame.setVisible(true);
	}
	

    
	private void setupnetworking()
	{
       
       		try
        	{
            		//sock = new Socket(InetAddress.getByName("ws216.cs.sac.local"),5000);  //connect to server
			sock = new Socket("127.0.0.1",5000);
            		InputStreamReader streamReader= new InputStreamReader(sock.getInputStream());
            		reader = new BufferedReader(streamReader);    //reading messages coming from server
            		writer = new PrintWriter(sock.getOutputStream());  //writing messages to the server

            		System.out.println("network established");
        	}
        	catch(IOException ex)
        	{
            		ex.printStackTrace();
        	}
    	}
    	public class IncommingReader implements Runnable
	{
    		public void run ()
    		{
        		String message;
        		try
        		{
		
           			while((message = reader.readLine()) != null)
            			{
                			System.out.println("read" + message);
                			incomming.append(message +"\n");
				}
            		}
        		
        		catch(Exception ex)
        		{
           		 	ex.printStackTrace();
        		}
		}
	}



	public class SendButtonListener implements ActionListener
	{
		public void actionPerformed(ActionEvent ev)
		{                                        
        		try
            		{
                		writer.println(username+">>"+outgoing.getText());
                		writer.flush();
           		}		
            		catch(Exception ex)
            		{
                		ex.printStackTrace();
            		}
            		outgoing.setText("");
            		outgoing.requestFocus();
		}
	}
}