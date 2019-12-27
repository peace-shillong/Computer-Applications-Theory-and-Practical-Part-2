import java.util.*;
class MyStack extends ArrayList
{
	ArrayList<Object> al=new ArrayList<Object>();
	
	public boolean isStackEmpty()
	{
		if(al.size()==0)
			return true;
		else
			return false;
	}
	int getSize()
	{
		return al.size();
	}
	Object pop()
	{
		int s=al.size()-1;
		Object ob=al.get(s);
		al.remove(ob);
		return ob;
	}
	void push(Object o)
	{
		al.add(o);
	}
	int search(Object o)
	{
		return al.lastIndexOf(o);
	}
	public String toString()
	{
		return "\nElements of stack: "+al;
	}
}
class MyStackDemo
{
	public static void main(String args[])
	{
		MyStack m=new MyStack();
		m.push(1);
		m.push(20);
		m.push("hey");
		m.push(2.45);
		m.push("abc");
		System.out.println("Current size of stack: "+m.getSize());
		System.out.println(m.toString());
		System.out.println("\nElement popped: "+m.pop());
		System.out.println("Element popped: "+m.pop());
		System.out.println("\n20 is present in index: "+m.search(20));
		System.out.println(m.toString());
	}
}