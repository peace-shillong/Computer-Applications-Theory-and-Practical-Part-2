// Client Side Program
// Importing the net package for accessing networking Class Socket)
// Importing the io package for the classes : BufferedReader ,InputStreamReader. 

import java.net.*;
import java.io.*;

class Client{

	public static void main(String args[]) throws Exception{
		System.out.println("Client Side");
		
		Socket s= new Socket(InetAddress.getLocalHost(),8080);  //Creates a Socket that access the localhost Server using the loopback ip address with the Port Number 8080
		System.out.println("Connected to Server Side");

		PrintWriter pw=new PrintWriter(s.getOutputStream()); ////Creates a pw for Sending input from the Client to the Server through the OutputStream
		BufferedReader br=new BufferedReader(new InputStreamReader(System.in)); //Creates a buffer br for receiving input from the user

		String line;
		do{
			System.out.println("Client: Enter Your Message:");
			line=br.readLine();//get user input
			//sends the input to the Server
			pw.println(line); 
			pw.flush();
		}while(!line.equals("bye")); //Keeop asking the user to input a Message to the Server until the Client/User inputs "bye" 

		s.close();
	}
}