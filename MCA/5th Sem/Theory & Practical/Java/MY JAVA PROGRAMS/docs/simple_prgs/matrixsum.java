import java.util.Scanner;

public class matrixsum{
	public static void main(String[] args){
		Scanner in=new Scanner(System.in);
		System.out.println("Enter the size of the first matrix");
		int m=in.nextInt();
		int n=in.nextInt();
		System.out.println("Enter the size of the second matrix");
		int p=in.nextInt();
		int q=in.nextInt();
		int a[][]=new int[20][20];
		int b[][]=new int[20][20];
		System.out.println("Enter the values for the first matrix:");
		for(int i=0;i<m;i++){
			for(int j=0;j<n;j++)
				a[i][j]=in.nextInt();
			}
		System.out.println("Enter the values for yhe second matrix:");
		for(int i=0;i<p;i++){
			for(int j=0;j<q;j++)
				b[i][j]=in.nextInt();
			}
		System.out.println();
		System.out.println("The first matrix u entered is:");
		for(int i=0;i<m;i++){
			for(int j=0;j<n;j++)
				System.out.print(a[i][j]+"   ");
			System.out.println();
			}
		System.out.println();
		System.out.println("the second matrix u entered is:");
		for(int i=0;i<p;i++){
			for(int j=0;j<q;j++)
				System.out.print(b[i][j]+"   ");
			System.out.println();
			}
		System.out.println();
		System.out.println();
		System.out.println(":--------------ADDITION--------------:");
		System.out.println();
		if(m==p && n==q){
			int add[][]=new int[20][20];
			for(int i=0;i<m;i++){
				for(int j=0;j<n;j++)
					add[i][j]=a[i][j]+b[i][j];
				}
			
			System.out.println("the addition matrix is:");
			for(int i=0;i<m;i++){
				for(int j=0;j<n;j++)
					System.out.print(add[i][j]+"   ");
				System.out.println();
				}
			}
		else
			System.out.println(" Sorry..!!!..The matrices can not be added because their size are not equal");
		System.out.println();
		System.out.println();
		System.out.println(":---------------MULTIPLICATION---------------:");
		System.out.println();
		if(n==p){
			int mul[][]=new int[20][20];
			for(int i=0;i<m;i++){
				for(int j=0;j<q;j++){
					mul[i][j]=0;
					for(int k=0;k<n;k++)
						mul[i][j]=mul[i][j]+a[i][k]*b[k][j];
					}
				}
			System.out.println("The multiplication matrix is:");
			for(int i=0;i<m;i++){
				for(int j=0;j<n;j++)
					System.out.print(mul[i][j]+"   ");
				System.out.println();
				}
			}
		else
			System.out.println("Sorry..!!!..The matrices u entered can not be multiplied because their size does not satisfy the condition for multiplication");
		System.out.println();		
		System.out.println();
		System.out.println(":----------------Subtraction---------------:");
		System.out.println();
		if(m==p && n==q){
			int sub[][]=new int[20][20];
			for(int i=0;i<m;i++){
				for(int j=0;j<n;j++)
					sub[i][j]=a[i][j]-b[i][j];
				}
			System.out.println("the subtraction matrix is:");
			for(int i=0;i<m;i++){
				for(int j=0;j<n;j++)
					System.out.print(sub[i][j]+"   ");
				System.out.println();
				}
			}
		else
			System.out.println(" Sorry..!!!..The secend matrix can not be subtracted from the first matrix because their size are not equal");
		}
	}