class Person
{
	public String name;
	public String add;
	public String phone_no;
	public String em;
	Person(String n,String ad,String phone,String e)
	{
		name=n;
		add=ad;
		phone_no=phone;
		em=e;
	}
	public String toString()
	{
		return "\nName: "+name+"\nAddress: "+add+"\nPhone No. : "+phone_no+"\nEmail ID : "+em; 
	
	}	
	
}
class Student extends Person
{
	
	final String status="Sophomore";
	Student(String n, String ad,String phone,String e) 
	{
		super(n,ad,phone,e);
	}
	public String toString()
	{
		return "\nName: "+name+"\nAddress: "+add+"\nPhone No. : "+phone_no+"\nEmail ID : "+em+" Status :"+status; 
	
	}	
}

class Employee extends Person
{
	String office;
	double salary;
	MyDate date;
	Employee(String n, String ad,String phone,String e,String of,double s,MyDate dt) 
	{
		super(n,ad,phone,e);
		office=of;
		salary=s;
		date=new MyDate(dt);
	}
	
	public String toString()
	{
		return "\nName: "+name+"\nAddress: "+add+"\nPhone No. : "+phone_no+"\nEmail ID : "+em+"\nOffice :"+office+"\nSalary :"+salary+"\nDate :"+date.test(); 
	}	
	
}
class Faculty extends Employee
{
	int hours;
	String rank;
	Faculty(String n, String ad,String phone,String e,String of,double s,MyDate dt,int hr,String rnk) 
	{
		super(n,ad,phone,e,of,s,dt);
		hours=hr;
		rank=rnk;	
	}
	
	public String toString()
	{
		return "\nName: "+name+"\nAddress: "+add+"\nPhone No. : "+phone_no+"\nEmail ID : "+em+"\nOffice :"+office+"\nSalary :"+salary+"\nDate :"+date.test()+"\n Hours :"+hours+" Rank :"+rank; 
	}	
}
class Staff extends Employee
{

	String title;
	Staff(String n, String ad,String phone,String e,String of,double s,MyDate dt,String t) 
	{
		super(n,ad,phone,e,of,s,dt);
		title=t;
	}
	public String toString()
	{
		return "\nName: "+name+"\nAddress: "+add+"\nPhone No. : "+phone_no+"\nEmail ID : "+em+"\nOffice :"+office+"\nSalary :"+salary+"\nDate :"+date.test()+" \nTitle : "+title; 
	}	
}
class MyDate{
	int year,month,day;
	static int da,mon,yr;
	MyDate()
	{
		year=1990;
		month=1;
		day=1;
		da=1;
		mon=1;
		yr=1991;
	}
	MyDate(MyDate dt)
	{
		year=dt.year;
		month=dt.month;
		day=dt.day;
		da=day;
		mon=month;
		yr=year;
	}
	MyDate(int y,int m,int d)
	{
		year=y;
		month=m;
		day=d;
		da=day;
		yr=year;
		mon=month;
	}
	public String toSring()
	{
		return (da+"/"+mon+"/"+yr);
	}
	public static String test()
	{
		return ""+da+"/"+mon+"/"+yr;
	}
}

class Poly
{
	public static void main(String args[])
	{
		Person p1=new Person("James","jaiaw","+918575498754","james_l@gmail.com");
		System.out.println("\nPerson Class:"+p1.toString());
		
		Student s1=new Student("James","jaiaw","+918575498754","james_l@gmail.com");
		Person p=s1;
		System.out.println("\nPerson Class:"+p.toString());
		
		MyDate md=new MyDate(2001,12,22);
		System.out.println(MyDate.test());
		Employee e2;
		Employee e= new Employee("James","jaiaw","+918575498754","james_l@gmail.com","SHILLONG",10000,md);
		p=e;
		System.out.println("\nEmployee Class:"+p.toString());
		Faculty f= new Faculty("James","jaiaw","+918575498754","james_l@gmail.com","SHILLONG",10000,md,8,"Officer");
		e2=f;
		System.out.println("\nFaculty Class:"+e2.toString());
		Staff st= new Staff("James","jaiaw","+918575498754","james_l@gmail.com","SHILLONG",10000,md,"Clerk");
		e2=st;
		System.out.println("\nStaff Class:"+e2.toString());
	
	}
}