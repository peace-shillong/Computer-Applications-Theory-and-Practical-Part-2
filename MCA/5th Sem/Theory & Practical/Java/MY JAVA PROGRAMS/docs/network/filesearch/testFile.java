import java.io.*;
import java.util.Scanner;

public class testFile
	{
	 public static void main(String args[])
	 {
	  File f=new File("server.java");
	  String c;
	  if(f.exists()){
	  System.out.println("Exist");
	  	try{
		Scanner in=new Scanner(f);
		
		while(in.hasNextLine()){
		{
		 c=in.nextLine();
		 System.out.printf("%s",c);		 
		 }
		}
		in.close();
		}
		catch(Exception e){
		 System.out.println("error"+e);
		}
		}	
	  else
	  System.out.println("Not Exist");
	 }
	}