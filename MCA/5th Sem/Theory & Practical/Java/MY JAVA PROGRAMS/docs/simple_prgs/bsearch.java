import java.util.Scanner;

public class bsearch{
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("Enter how many numbers are in the sorted list");
		int n=input.nextInt();
		System.out.println("Enter the values of the list:");
		int a[];
		a=new int[20];
		int c=0,i;
		for(i=0;i<n;i++){
			a[i]=input.nextInt();
			if(i>0){
			if(a[i]<a[i-1])
				c++;
			}
			}
		if(c==0){
		System.out.println("The list is:");
		for(i=0;i<n;i++)
			System.out.print(a[i]+" ");
		System.out.println();
		System.out.println("enter the number to be searched");
		int s=input.nextInt();
		System.out.println("After applying binary search technique-->");
		int r=n-1;
		int l=0;
		
		while(l<=r){
		int k=(r+l)/2;
		if(s==a[k]){	
			System.out.println("the number "+s+" is found in the given list");
			break;
			}
		else if(s>a[k])
			l=k+1;
		else 
			r=k-1;
		}
		if(l>r)
			System.out.println("Sorry...!!!!!!...the number u have put is not found in the given list");
		}
		else
			System.out.println("Sorry the list u have entered just now is not a sorted list...so kindly enter a sorted list to apply binary search technique");	
	}

}