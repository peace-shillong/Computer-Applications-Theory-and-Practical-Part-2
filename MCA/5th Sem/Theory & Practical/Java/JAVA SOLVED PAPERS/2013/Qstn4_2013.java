import java.io.*;
class Qstn4_2013
{
	public static void main(String args[])
	{
		int size;
		byte b1[];
		String str;
		try(FileInputStream fin=new FileInputStream("a.txt");)
		{
			
			//FileInputStream fout=new FileInputStream("b.txt");
			size=fin.available();
			System.out.println("Size="+size);
			b1=new byte[size];
			fin.read(b1,0,size);
			str=b1.toString();
			System.out.println(str);
		
		}
		catch(IOException e)
		{
			
		}
	}
}