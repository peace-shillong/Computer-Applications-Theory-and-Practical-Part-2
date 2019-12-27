import java.util.*;
interface Payable
{
	public abstract double getPaymentAmount();
}
class Invoice implements Payable
{
	private int partNumber;
	private int Quantity;
	private int priceperItem;
	Invoice()
	{
			partNumber=0;
			priceperItem=0;
			Quantity=0;
	}
	Invoice(int n,int p,int q)
	{
			partNumber=n;
			priceperItem=p;
			Quantity=q;
	}
	void setpartNumber(int pn)
	{
		partNumber=pn;
	}
	void setQuantity(int q)
	{
		Quantity=q;
	}
	void setpriceperItem(int p)
	{
		priceperItem=p;
	}
	int getpartNumber()
	{
		return partNumber;
	}
	int getQuantity()
	{
		return Quantity;
	}
	int getpriceperItem()
	{
		return priceperItem;
	}
	public double getPaymentAmount()
	{
		return Quantity*priceperItem;
	}
}
abstract class Employee implements Payable
{
	private String Ename;
	private int Jobid;
	void setEname(String name)
	{
		Ename=name;
	}
	void setJobid(int id)
	{
		Jobid=id;
	}
		
	String getEname()
	{
		return Ename;
	}
	int getJobid()
	{
		return Jobid;
	}
}
class SalariedEmployee extends Employee
{
	private double monthSalary;
	SalariedEmployee()
	{
		monthSalary=0;
	}
	SalariedEmployee(String e,int i,double m)
	{
			super.setEname(e);
			super.setJobid(i);
			monthSalary=m;
	}
	void setmonthSalary(double sal)
	{
		monthSalary=sal;
	}
	double getmonthSalary()
	{
		return monthSalary;
	}
	public double getPaymentAmount()
	{
		return monthSalary;
	}
}
class Qstn1_2015
{
	public static void main(String args[])
	{
		Scanner sc=new Scanner(System.in);
		Payable pay;
		Invoice in=new Invoice();
		System.out.println("For Invoice class");
		System.out.println("enter part number:");
		int pn=sc.nextInt();
		System.out.println("enter quantity:");
		int q=sc.nextInt();
		System.out.println("enter price per item:");
		int p=sc.nextInt();
		pay=in;
		System.out.println("Payable amount="+pay.getPaymentAmount());
		Invoice i1=new Invoice(pn,p,q);
		pay=i1;
		System.out.println("Displaying Invoice class");
		System.out.println("Payable amount="+pay.getPaymentAmount());
		System.out.println("For Salaried Employee class");
		System.out.println("enter employee name:");
		String name=sc.next();
		System.out.println("enter job id:");
		int jid=sc.nextInt();
		System.out.println("enter monthly salary:");
		double sal=sc.nextDouble();
		SalariedEmployee se=new SalariedEmployee(name,jid,sal);
		pay=se;
		System.out.println("Displaying Salaried Employee class");
		System.out.print("Payable amount="+pay.getPaymentAmount());
	}
}
		
		
		
		
	
	