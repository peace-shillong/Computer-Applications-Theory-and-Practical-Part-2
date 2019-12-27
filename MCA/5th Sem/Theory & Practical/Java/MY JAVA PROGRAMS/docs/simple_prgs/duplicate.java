import java.util.Scanner;

public class duplicate{
	public static void main(String[] args){
		Scanner in=new Scanner(System.in);
		System.out.println("Enter the limit of the array");
		int n=in.nextInt();
		System.out.println();
		System.out.println("Enter the values:");
		int a[]=new int[20];
		for(int i=0;i<n;i++)
			a[i]=in.nextInt();
		System.out.println();
		System.out.println("The array list u have entered is :");
		System.out.println();
		for(int i=0;i<n;i++)
			System.out.print(a[i]+"  ");
		System.out.println();
		System.out.println();
		int c=0;
		for(int i=0;i<n;i++){
			int s=a[i];
			for(int j=i+1;j<n;j++){
				if(s==a[j]){
					for(int k=j;k<n-1;k++)
						a[k]=a[k+1];
					n=n-1;
					c++;
					j--;
					}
				}
			}
		if(c==0)
			System.out.println("HEY...The list has no duplicate numbers....");
		else{
			System.out.println("after removing all the duplicates the lst is:");
			System.out.println();
			for(int i=0;i<n;i++)
				System.out.print(a[i]+"  ");
			}	
		}
	}					