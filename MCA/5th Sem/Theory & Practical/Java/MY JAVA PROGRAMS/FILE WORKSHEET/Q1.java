
import java.io.*;

class Q1
{
	public static void main(String args[])
	{
		char ch;
		InputStreamReader in = new InputStreamReader(System.in);
		BufferedReader br=new BufferedReader(in);
		
		FileOutputStream fis=null;

		
		try{
			fis=new FileOutputStream("Numbers.txt");
			
			System.out.println("Enter Numbers");
			//ch=sc.nextInt();
			
			do
			{				
				ch=(char)br.read();
				if(ch!='q')
					fis.write(ch);				
			}
			while(ch!='q');
		}
		catch(Exception e){}
		finally{
			if(fis!=null)
			try{
				fis.close();
			}
			catch(Exception e)
			{}
		}
	}
}