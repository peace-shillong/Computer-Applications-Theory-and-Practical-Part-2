import java.util.*;

interface Comparable{
		boolean isEqual(String arg);
}

class Car implements Comparable{
	
	String l_no;
	Car(){
		l_no="01";
	}
	Car(String s){
		l_no = s;
	}	
	public boolean isEqual(String ss){	
		if(l_no.equalsIgnoreCase(ss))
			return true;
		else
			return false;
	}
}

class Employee implements Comparable{
	
	String name;
	
	Employee(String ee){
		name=ee;
	}
	
	public boolean isEqual(String ss){	
		if(name.equalsIgnoreCase(ss))
			return true;
		else
			return false;
	}
	
}

class Tester {

	public static void main(String args[])
	{
		Scanner ss=new Scanner(System.in);
		Car c = new Car("2017");
		Employee em = new Employee("Albert");
		
		System.out.println("Enter Lisence No:");
		String a=ss.next();
		System.out.println("Enter Name:");
		String ba=ss.next();
		System.out.println("Comparing License Plate : T/F" + c.isEqual(a));
		System.out.println("Comparing Employee : T/F" + em.isEqual(ba));
	}
	
}