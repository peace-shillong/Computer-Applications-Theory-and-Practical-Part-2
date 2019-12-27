import java.util.*;
class Q6
{
	public static void main(String args[]){
		ArrayList<Person> list = new ArrayList<Person>();
		System.out.println("Initial size of LIST: " +list.size());
		//Create Objects
		Person p=new Person("Person");
		Student s=new Student("Student");
		Employee e=new Employee("Employee");
		Faculty f=new Faculty("Faculty");
		Staff st=new Staff("Staff");
		// Add elements to the array list.
		list.add(p);
		list.add(s);
		list.add(e);
		list.add(f);
		list.add(st);

		System.out.println("Size of al after additions: " +list.size());
		
		System.out.println("Contents of al: " + list.toString());
		System.out.println("\nArray");
		Person parray[] = new Person[list.size()];
		parray = list.toArray(parray);
		for(Person p2 : parray)
			System.out.println(""+p2.toString());
	}
}

class Person extends ArrayList{
	
	String name;	
	Person()
	{
		name="N";		
	}
	Person(String nam){
		name=nam;		
	}
	void setName(String nam)
	{
		name=nam;		
	}
	public String toString()
	{
			return name;		
	}
}

class Student extends Person{
	
	//String name;	
	Student()
	{
		name="No name";		
	}
	Student(String nam){
		name=nam;		
	}
	/*void setName(String nam)
	{
		name=nam;		
	}
	public String toString()
	{
			return name;		
	}*/
}

class Employee extends Person{
	
	//String name;	
	Employee()
	{
		name="No name";
	
	}
	Employee(String nam){
		name=nam;		
	}
	/*void setName(String nam)
	{
		name=nam;		
	}
	public String toString()
	{
			return name;		
	}*/
}

class Faculty extends Person{
	
	//String name;	
	Faculty()
	{
		name="No name";

	}
	Faculty(String nam){
		name=nam;		
	}
	/*void setName(String nam)
	{
		name=nam;		
	}
	public String toString()
	{
			return name;		
	}*/
}
class Staff extends Person{
	
	//String name;	
	Staff()
	{
		name="No name";

	}
	Staff(String nam){
		name=nam;		
	}
	/*void setName(String nam)
	{
		name=nam;		
	}
	public String toString()
	{
			return name;		
	}*/
}