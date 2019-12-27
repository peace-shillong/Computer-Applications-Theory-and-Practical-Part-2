import java.io.*;
import java.util.Scanner;
public class intdis{
	public static void main(String[] args) throws IOException{
	FileInputStream in=new FileInputStream(new File("D:/JAVA/file/workshhet/Numbers.txt"));
		int v;
		v=in.read();
		System.out.println();
		System.out.println("The integers read from the file are:");
		while(v!=-1){
			System.out.println(+v);
			v=in.read();
			}
		in.close();
		}
	}