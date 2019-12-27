import java.util.*;
class Person
{
	String name;
	String address;
	long phoneNo;
	String email;
	Person(String n,String ad,long pn,String em)
	{
		name=n;
		address=ad;
		phoneNo=pn;
		email=em;
	}
	public String toString()
	{
		return "**class Person**\n name="+name;
	}
	void show()
	{
		System.out.println("\nAddress="+address);
		System.out.println("Phone number="+phoneNo);
		System.out.println("Email="+email);
	}
}
class Student extends Person
{
	String status;
	Student(String n,String ad,long pn,String em,final String st)
	{
		super(n,ad,pn,em);
		status=st;
	}
	public String toString()
	{
		return "**class Student**\n name="+name;
	}
	void show()
	{
		super.show();
		System.out.println("Status="+status);
	}
}
class Employee extends Person
{
	String office;
	double salary;
	String dateHired;
	Employee(String n,String ad,long pn,String em,String of,double sal,String dh)
	{
		super(n,ad,pn,em);
		office=of;
		salary=sal;
		dateHired=dh;
	}
	public String toString()
	{
		return "**class Employee**\n name="+name;
	}
	void show()
	{
		super.show();
		System.out.println("Office="+office);
		System.out.println("Salary="+salary);
		System.out.println("Date Hired="+dateHired);
	}
}
class Faculty extends Employee
{
	double hours;
	int rank;
	Faculty(final String n,String ad,long pn,String em,String of,double sal,String dh,double hr,int rk)
	{
		super(n,ad,pn,em,of,sal,dh);
		hours=hr;
		rank=rk;
	}
	public String toString()
	{
		return "**class Faculty**\n name="+name;
	}
	void show()
	{
		super.show();
		System.out.println("Hours="+hours);
		System.out.println("Rank="+rank);
	}
}
class Staff extends Employee
{
	String title;
	Staff(final String n,String ad,long pn,String em,String of,double sal,String dh,String t)
	{
		super(n,ad,pn,em,of,sal,dh);
		title=t;
	}
	public String toString()
	{
		return "**class Staff**\n name="+name;
	}
	void show()
	{
		super.show();
		System.out.println("Title="+title);
	}
}
class MyDate
{
	int year;
	int month;
	int day;
	MyDate(int y,int m,int d)
	{
		year=y;
		month=m;
		day=d;
	}
	public String toString()
	{
		return "**class MyDate**\n Year="+year+" Month="+month+" Day="+day;
	}
}
class ArrayListDemo
{
	public static void main(String args[])
	{
		Person p=new Person("Mel","mawlai",1234567890,"are@hm.com");
		
		Student s=new Student("Almo","mawlai",1234567890,"are@hm.com","sophomore");
	
		Employee e=new Employee("Sheak","mawlai",1234567890,"are@hm.com","office1",5000.0,"10-04-2107");
		
		Faculty f=new Faculty("Evan","mawlai",1234567890,"aewre@hm.com","office1",6000.0,"10-04-2107",8.2,8);
	
		Staff st=new Staff("Lucy","mawlai",1234567890,"are@hm.com","office1",5000.0,"10-04-2107","clerk");
		
		MyDate md=new MyDate(2018,8,8);
		
		ArrayList<Object> al=new ArrayList<Object>();
		al.add(p);
		al.add(s);
		al.add(e);
		al.add(f);
		al.add(st);
		al.add(md);
		
		Object ar[]=new Object[al.size()];
		ar=al.toArray();
		for(int i=0;i<ar.length;i++)
		{
			System.out.println(ar[i].toString());
		}
	}
}