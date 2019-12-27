import java.util.*;
interface Comparable
{
	boolean isEqual(String s); 
}
class Car implements Comparable
{
	String licencePlateNo;
	Car()
	{
		licencePlateNo="ML05 0000"; 
	}
	Car(String lpn)
	{
		licencePlateNo=lpn;
	}
	void setLicencePlateNo(String lpn)
	{
		licencePlateNo=lpn;
	}
	String getLicencePlateNo()
	{
		return licencePlateNo;
	}
	public boolean isEqual(String s)
	{
		if(licencePlateNo.equals(s))
			return true;
		else
			return false;
	}
}
class Employee implements Comparable
{
	String name;
	Employee()
	{
		name="";
	}
	Employee(String n)
	{
		name=n;
	}
	void setName(String n)
	{
		name=n;
	}
	String getName()
	{
		return name;
	}
	public boolean isEqual(String s)
	{
		if(name.equals(s))
			return true;
		else
			return false;
	}
}
class ComparableDemo
{
	public static void main(String args[])
	{
		String lcn,nm,s1,s2;
		Scanner sc=new Scanner(System.in);
		Car c=new Car();
		System.out.println("**Enter details for Car**");
		System.out.println("Enter Licence plate number for car:");
		lcn=sc.nextLine();
		c.setLicencePlateNo(lcn);
		System.out.println("Enter String to compare:");
		s1=sc.nextLine();
		System.out.println(lcn+"=="+s1+"::"+c.isEqual(s1));
		
		Employee e=new Employee();
		System.out.println("**Enter details for Employee**");
		System.out.println("Enter any name:");
		nm=sc.nextLine();
		e.setName(nm);
		System.out.println("Enter String to compare:");
		s2=sc.nextLine();
		System.out.println(nm+"=="+s2+"::"+e.isEqual(s2));
	}
}