import java.util.Scanner;

public class bubble{
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("Enter the limit of the list");
		int n=input.nextInt();
		int a[]=new int[20];
		int c=0;
		System.out.println("enter the values:");
		for(int i=0;i<n;i++){
			a[i]=input.nextInt();
			if(i>0){
				if(a[i]<a[i-1])
					c++;
				}	
			}
		if(c>0){
			System.out.println("the unsorted is:");
			for(int i=0;i<n;i++)
				System.out.print(a[i]+" ");
			System.out.println();
			System.out.println("after applying bubble sort the sorted list is:");
			int t;
			for(int i=0;i<n-1;i++){
				for(int j=0;j<n-1-i;j++){
					if(a[j]>a[j+1]){
						t=a[j];
						a[j]=a[j+1];
						a[j+1]=t;
						}
					}
				}
			for(int i=0;i<n;i++)
				System.out.print(a[i]+" ");
			}
		else
			System.out.println("The list of number is already sorted");
		}	

	}	
			