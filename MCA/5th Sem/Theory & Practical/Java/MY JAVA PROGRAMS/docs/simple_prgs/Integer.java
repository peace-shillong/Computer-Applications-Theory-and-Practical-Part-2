//5.Create a class IntegerSet. Each IntegerSet object can hold integers in the range 0-100. The set is represented by an 
//array of Booleans. Array element a[i] is true if integer I is present in the set and false otherwise. The no argument
//constructor initializes the array to the empty set. Provide methods for union, intersection to create a new set.
//Also provide method insertElement and deleteElement to insert and delete elements from the set.
import java.util.*; 
class IntegerSet
{
	private  boolean [] arr;

	IntegerSet()
	{    
		arr=new boolean[100];
		for(int i=0;i<arr.length;i++)
			arr[i]=false;
	}
	public void setInteger()
	{
	   int index,num;
	   System.out.println("\n\nEnter the size of array\n\n\t");
	   Scanner in=new Scanner(System.in);
	   index=in.nextInt();
	   for(int i=0;i<index;i++)
		 {
			 System.out.println("\n\nEnter the elements one by one\n\n\t");
			 num=in.nextInt();
			 if(num>0 && num<100)
			   arr[num]=true;
		 }	 
	}
	public void display()
	{
	  for(int i=0;i<arr.length; i++)
	   {
			if(arr[i]==true)
				System.out.printf("\n\n arr[%s]=%s",i,arr[i]);
	   }
	}
	public IntegerSet union(IntegerSet I1)
	{
	  IntegerSet I3=new IntegerSet();
	  for(int i=0;i<100;i++)
	   {
	     if(this.arr[i]==true||I1.arr[i]==true)
		  		   I3.arr[i]=true;
		  else
					I3.arr[i]=false;
            			
	   } 
	      return I3;

	}
	public IntegerSet intersection(IntegerSet I1)
	{
      IntegerSet I2=new IntegerSet();
	  for(int i=0;i<100;i++)
	   {
	     if(this.arr[i]==true && I1.arr[i]==true)
		       I2.arr[i]=true;
		 else
                I2.arr[i]=false;		 
	   }
	      return I2;
	}
	public void insertElement()
	{
		System.out.printf("\n\nEnter the position you want to insert element: ");
		Scanner in = new Scanner(System.in);
		int a = in.nextInt();
		if(a>=0 && a<=100)
		{
			arr[a]=true;
		}
	}
	public void deleteElement()
	{
		System.out.printf("\n\nEnter the position you want to delete element: ");
		Scanner in = new Scanner(System.in);
		int a = in.nextInt();
		if(a>=0 && a<=100)
		{
			arr[a]=false;
		}
	}
}

public class Integer
{
	public static void main(String args[])
	{	
	    IntegerSet i1 = new IntegerSet();
		IntegerSet u = new IntegerSet();
		IntegerSet i3 = new IntegerSet();
		IntegerSet In = new IntegerSet();
		System.out.println("\n\nEnter the first set of the Number:\n\n ");
		i3.setInteger();
		i3.display();
		System.out.println("\n\nEnter the second set of the Number: \n\n");
		i1.setInteger();
		i1.display();
		System.out.println("\n\nUnion of two set");
		u=i3.union(i1);
		u.display();
		System.out.println("\n\nIntersection of two set");
		In=i3.intersection(i1);
		In.display();
		System.out.println("\n\nInserting");
		i3.insertElement();
		i3.display();		
		System.out.println("\n\nDeleting");
		i3.deleteElement();
		i3.display();
	}
}
