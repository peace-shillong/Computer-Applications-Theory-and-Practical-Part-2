import java.io.*;
public class TestStreamFile{
	public static void main(String[] args) throws IOException{
		FileOutputStream out=new FileOutputStream(new File("D:/JAVA/file/workshhet/trial.txt"));
		for(int i=0;i<100;i++)
			out.write(i);
		out.close();
		FileInputStream in=new FileInputStream(new File("D:/JAVA/file/workshhet/trial.txt"));
		int val;
		val=in.read();
		while(val!=-1)		{
			System.out.printf("%d\t",val);
			val=in.read();
		}
		in.close();
	}
}
