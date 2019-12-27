import java.io.*;
import java.util.Scanner;
public class intStoreBin{
	public static void main(String[] args) throws IOException{
		FileOutputStream out=new FileOutputStream(new File("D:/JAVA/file/workshhet/Numbers.dat"));
		Scanner input=new Scanner(System.in);
		System.out.println("Enter how many integers you want to store:");
		int n=input.nextInt();
		System.out.println();
		System.out.println("Enter the integers:");
		System.out.println();
		int i;
		for(i=1;i<=n;i++){
			int val=input.nextInt();
			out.write(val);
			}
		out.close();
		FileInputStream in=new FileInputStream(new File("D:/JAVA/file/workshhet/Numbers.dat"));
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
	 