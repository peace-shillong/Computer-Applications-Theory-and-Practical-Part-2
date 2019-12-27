import java.util.*;
interface Stack
{
	void push(int s);
	int pop();
}
class MyStack extends ArrayList implements Stack 
{
	int tos;
	int arr[];
	MyStack(int size)
	{
		tos=-1;
		arr=new int[size];
	}
	public boolean isEmpty()
	{
		if(tos==-1)
			return true;
		else
			return false;
	}
	int getSize()
	{
		return tos;
	}
	public void push(int s)
	{
		arr[++tos]=s;
	}
	public int pop()
	{
		return arr[tos--];
	}
	int search(int val)
	{
		for(int i=0;i<tos;i++)
		{
			if(arr[i]==val)
				return tos;
			
		}
			return -1;
	}
	public String toString()
	{
		return ""+arr[tos--];
	}
}

class Q7
{
	public static void main(String args[])
	{
		MyStack s=new MyStack(3);
		s.push(1);
		s.push(2);
		s.push(3);
		int i=s.search(2);
		System.out.println("Position="+i);
		ArrayList<String> list=new ArrayList<String>();
		while(!s.isEmpty())
			System.out.println("Contents of the list are"+s.toString());
		list=s;
		s.push(1);
		s.push(22);
		while(!list.isEmpty())
			System.out.println("Contents of the list are"+list.toString());
				
	}
}
