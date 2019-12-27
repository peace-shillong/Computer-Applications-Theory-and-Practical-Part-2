// Server Side Program
// Importing the net package for accessing networking Classes(like Socket and ServerSocket) 
// Importing the io package for the classes : BufferedReader ,InputStreamReader .
import java.net.*;
import java.io.*;

class Server{

	public static void main(String args[]) throws Exception{
		System.out.println("Server Side");
		
		ServerSocket ss= new ServerSocket(8080); //Creates a ServerSocket with the Port Number 8080
		System.out.println("Waiting for Client Side"); //Waits for Client to Connect to the Server through the Port 8080

		Socket s=ss.accept(); //Accepts a Single Client Request

		//Creates a buffer br for receiving input from the Client
		BufferedReader br=new BufferedReader(new InputStreamReader(s.getInputStream())); 

		String line;
		//Checks the Input from Client and Displays it until the clients quits
		while((line=br.readLine())!=null){ 
			System.out.print("Client Said: ");
			System.out.println(line);
		}
	
		s.close();//The Socket is now Closed and The Client Cannot Connect
	}
}