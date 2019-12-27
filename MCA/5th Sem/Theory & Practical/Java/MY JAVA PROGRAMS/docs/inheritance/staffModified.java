/*Program for staff hierarchy with error handling/error trapping mechanism*/
import java.util.*;
class staff
{
	private int code;
	private String name;
	public int getCode()//getter method for private field code
	{
		return this.code;
	}
	public void setCode(int code)//setter method for private field code
	{
		this.code=code;
	}
	public String getName()
	{
		return name;
	}
	public void setName(String name)
	{
		this.name=name;
	}
	public double compute_allowances(int emp_type,String emp_grade)//Compute allowances of different employees
	{
		double allowances=0.0;
		if(emp_type==1)
		{
			allowances=15000;
		}
		else if(emp_type==2 && emp_grade.equals("A"))
		{
			allowances=20000;
		}
		else if(emp_type==2 && emp_grade.equals("B"))
		{
			allowances=18000;
		}
		else
		{
			allowances=8000;
		}
		return allowances;
	}
	
}
interface staffSalary
{
	public void compute_sal(int type,double basic_salary);
	public void display();
}
class teacher  extends staff implements staffSalary
{
	private String subject;
	double salary;
	teacher(staff st)//Object of class staff is a parameter here in order to access staff's private fields
	{
		System.out.println("-------------------------------------------------------------------------------");
		System.out.println();
		System.out.println("\t\t\t\tTeacher's Details\t\t\t\t");
		System.out.println("\t\t\t\tEmployee code="+st.getCode());//Accessing getter method of staff class
		System.out.println("\t\t\t\tEmployee name="+st.getName());
	}
	public String getSubject()
	{
		return subject;
	}
	public void setSubject(String subject)
	{
		this.subject=subject;
	}
	public void compute_sal(int type,double basic_salary)
	{
		/*Error trapping*/
		try
		{
			this.salary=basic_salary+super.compute_allowances(type,null);//example of super keyword to access superclass method
		}
		catch(Exception e)
		{
			System.out.println("Error in Compute salary of Teacher's class"+e);
		}
	}
	public void display()
	{
		System.out.println("\t\t\t\tSalary=Rs "+salary);
		System.out.println("\t\t\t\tSubject="+subject);
		System.out.println();
		System.out.println("--------------------------------------------------------------------------------");
		
	}
}
class officer  extends staff implements staffSalary
{
	private String grade;
	double salary;
	officer(staff st)
	{
		System.out.println("-------------------------------------------------------------------------------");
		System.out.println();
		System.out.println("\t\t\t\tOfficer's Details\t\t\t\t");
		System.out.println("\t\t\t\tEmployee code="+st.getCode());
		System.out.println("\t\t\t\tEmployee name="+st.getName());
	}
	public String getGrade()
	{
		return grade;
	}
	public void setGrade(String grade)
	{
		this.grade=grade;
	}
	public void compute_sal(int type,double basic_salary)
	{
		
		try
		{
			this.salary=basic_salary+super.compute_allowances(type,grade);
		}
		catch(Exception e)
		{
			System.out.println("Error in Compute salary of Officer's class"+e);
		}
	}
	public void display()
	{
		System.out.println("\t\t\t\tGrade="+grade);
		System.out.println("\t\t\t\tSalary=Rs "+salary);
		System.out.println();
		System.out.println("--------------------------------------------------------------------------------");
		
	}
}
class regulartypist  extends staff implements staffSalary
{
	private double speed;
	double salary;
	regulartypist(staff st)
	{
		System.out.println("-------------------------------------------------------------------------------");
		System.out.println();
		System.out.println("\t\t\t\tRegular Typist's Details\t\t\t\t");
		System.out.println("\t\t\t\tEmployee code="+st.getCode());
		System.out.println("\t\t\t\tEmployee name="+st.getName());
	}
	public double getSpeed()
	{
		return speed;
	}
	public void setSpeed(double speed)
	{
		this.speed=speed;
	}
	public void compute_sal(int type,double basic_salary)
	{
		try
		{
			this.salary=basic_salary+super.compute_allowances(type,null);
		}
		catch(Exception e)
		{
			System.out.println("Error in Compute salary of Regular Typist's class"+e);
		}
	}
	public void display()
	{
		System.out.println("\t\t\t\tSalary=Rs "+salary);
		System.out.println("\t\t\t\tSpeed="+speed+" words per minute");
		System.out.println();
		System.out.println("--------------------------------------------------------------------------------");
		
	}
}
class casualtypist  extends staff implements staffSalary
{
	private double speed;
	double salary;
	double no_of_working_days;
	double rate;
	casualtypist(staff st)
	{
		System.out.println("-------------------------------------------------------------------------------");
		System.out.println();
		System.out.println("\t\t\t\tRegular Typist's Details\t\t\t\t");
		System.out.println("\t\t\t\tEmployee code="+st.getCode());
		System.out.println("\t\t\t\tEmployee name="+st.getName());
	}
	public double getSpeed()
	{
		return speed;
	}
	public void setSpeed(double speed)
	{
		this.speed=speed;
	}
	public double getRate()
	{
		return rate;
	}
	public void setRate(double rate)
	{
		this.rate=rate;
	}
	public double getNo_of_working_days()
	{
		return no_of_working_days;
	}
	public void setNo_of_working_days(double no_of_working_days)
	{
		this.no_of_working_days=no_of_working_days;
	}
	public void compute_sal(int type,double basic_salary)
	{
		try
		{
			this.salary=rate*no_of_working_days;
		}
		catch(Exception e)
		{
			System.out.println("Error in Compute salary of Casual Typist's class"+e);
		}
	}
	public void display()
	{
		System.out.println("\t\t\t\tSalary=Rs "+salary);
		System.out.println("\t\t\t\tSpeed="+speed+" words per minute");
		System.out.println();
		System.out.println("--------------------------------------------------------------------------------");
		
	}
}

public class staffModified
{
	public static void main(String a[])
	{
		int choice;
		double speed;
		int code=0;
		String name=null;
		String subject=null;
		double basic_salary=0.0;
		String grade=null;
		double rate=0.0;
		double no_of_working_days=0.0;
		Scanner sc=new Scanner(System.in);
		do
		{
			System.out.println();
			System.out.println("----Please select the type of employee for which details are to be entered----");
			System.out.println();
			System.out.println("-----------------------Enter 1 for Teacher------------------------------------");
			System.out.println("-----------------------Enter 2 for Officer------------------------------------");
			System.out.println("-----------------------Enter 3 for Regular Typist-----------------------------");
			System.out.println("-----------------------Enter 4 for Casual Typist------------------------------");
			System.out.println("-----------------------Enter 5 for EXIT---------------------------------------");
			System.out.println();
			System.out.println("---------------------xxxxxxxxxxxxxxxxxxxxxxxx---------------------------------");
			System.out.println();
			choice=sc.nextInt();
			staff st=new staff();
			switch(choice)
			{
				case 1:
						try
						{
							//try to read input for code of an employee.. 
							//If other non-integer value(s) is(are) entered....
							//Catch Exception(here InputMismatchException)
							System.out.println("Enter code and name of the teacher");
							code=sc.nextInt();
						}
						catch(InputMismatchException e)
						{
							System.out.println("\t\t\tInput code for Teacher's Details");
							System.out.println("\t\t\tInvalid code!!PLease enter a valid code");
							sc.nextLine();
							break;
						}
						sc.nextLine();
						while(!sc.hasNext("[A-Za-z]+"))//Allow only Uppercase or Lowercase letters for name of an employee
						{
							System.out.println("Error!!!Please enter a valid name");
							sc.nextLine();
						}
						name=sc.nextLine();
						System.out.println("Enter the teacher's subject");
						while(!sc.hasNext("[A-Za-z]+"))
						{
							System.out.println("Error!!!Please enter a valid subject");
							sc.next();
						}
						subject=sc.nextLine();
						try
						{
							System.out.println("Enter the teacher's basic salary");
							basic_salary=sc.nextDouble();
						}
						catch(InputMismatchException e)
						{
							System.out.println("\tInput basic salary for Teacher's Details");
							System.out.println("\tInvalid value for basic salary!!PLease enter a valid value for salary");
							sc.nextLine();
							break;
						}								
						st.setCode(code);
						st.setName(name);
						teacher t=new teacher(st);
						t.setSubject(subject);
						t.compute_sal(choice,basic_salary);
						t.display();
						break;
				case 2:
						try
						{
							System.out.println("Enter code and name of the officer"); 
							code=sc.nextInt();
						}
						catch(InputMismatchException e)
						{
							System.out.println("\t\t\tInput code for Officer's Details");
							System.out.println("\t\t\tInvalid code!!PLease enter a valid code");
							sc.nextLine();
							break;
						}
						sc.nextLine();
						while(!sc.hasNext("[A-Za-z]+"))
						{
							System.out.println("Error!!!Please enter a valid name");
							sc.nextLine();
						}
						name=sc.nextLine();
						System.out.println("Enter the Officer's grade: A or B");
						while(!sc.hasNext("[A]|[B]"))//Allow only input A or B for Officer's Grade
						{
							System.out.println("Error!!!PLease enter only A or B for grade");
							sc.nextLine();
						}
						grade=sc.nextLine();
						try
						{
							System.out.println("Enter the Officer's basic salary");
							basic_salary=sc.nextDouble();
						}
						catch(InputMismatchException e)
						{
							System.out.println("\tInput basic salary for Officer's Details");
							System.out.println("\tInvalid value for basic salary!!PLease enter a valid value for salary");
							sc.nextLine();
							break;
						}
						st.setCode(code);
						st.setName(name);
						officer off=new officer(st);
						off.setGrade(grade);
						off.compute_sal(choice,basic_salary);
						off.display();
						break;
				case 3:
						try
						{
							System.out.println("Enter code and name of the regular typist");
							code=sc.nextInt();
						}
						catch(InputMismatchException e)
						{
							System.out.println("\tInput employee's basic salary for Regular Typist's Details");
							System.out.println("\tInvalid employee's code!!PLease enter a valid value for employee code");
							sc.nextLine();
							break;	
						}
						sc.nextLine();
						while(!sc.hasNext("[A-Za-z]+"))
						{
							System.out.println("Error!!!Please enter a valid name");
							sc.nextLine();
						}
						name=sc.nextLine();
						try
						{
							System.out.println("Enter the tyist's speed");
							speed=sc.nextDouble();
						}
						catch(InputMismatchException e)
						{
							System.out.println("\tInput speed for Regular Typist's Details");
							System.out.println("\tInvalid value for speed!!PLease enter a valid value for speed");
							sc.nextLine();
							break;
						}
						try
						{
							System.out.println("Enter the typist's basic salary");
							basic_salary=sc.nextDouble();
						}
						catch(InputMismatchException e)
						{
							System.out.println("\tInput  basic salary for Regular Typist's Details");
							System.out.println("\tInvalid value for basic salary!!PLease enter a valid value for salary");
							sc.nextLine();
							break;
						}
						st.setCode(code);
						st.setName(name);
						regulartypist rt=new regulartypist(st);
						rt.setSpeed(speed);
						rt.compute_sal(choice,basic_salary);
						rt.display();
						break;
				case 4:
						try
						{
							System.out.println("Enter code and name of the Casual typist");
							code=sc.nextInt();
						}
						catch(InputMismatchException e)
						{
							System.out.println("\tInput code for Casual Typist's Details");
							System.out.println("\tInvalid value for code!!PLease enter a valid value for code");
							sc.nextLine();
							break;
						}
						sc.nextLine();
						while(!sc.hasNext("[A-Za-z]+"))
						{
							System.out.println("Error!!!Please enter a valid name");
							sc.nextLine();
						}
						name=sc.nextLine();
						try
						{
							System.out.println("Enter the tyist's speed");
							speed=sc.nextDouble();
						}
						catch(InputMismatchException e)
						{
							System.out.println("\tInput speed for Casual Typist's Details");
							System.out.println("\tInvalid value for speed!!PLease enter a valid value for speed");
							sc.nextLine();
							break;
						}
						try
						{
							System.out.println("Enter the typist's rate of salary per day");
							rate=sc.nextDouble();
						}
						catch(InputMismatchException e)
						{
							System.out.println("\tInput salary's rate for Casual Typist's Details");
							System.out.println("\tInvalid value for salary's rate!!PLease enter a valid value for salary's rate");
							sc.nextLine();
							break;
						}
						try
						{
							System.out.println("Enter the typist's no of working days");
							no_of_working_days=sc.nextDouble();
						}
						catch(InputMismatchException e)
						{
							System.out.println("\tInput No of working days for Casual Typist's Details");
							System.out.println("\tInvalid value for no_of_working_days!!PLease enter a valid value for no_of_working_days");
							sc.nextLine();
							break;
						}
						st.setCode(code);
						st.setName(name);
						casualtypist ct=new casualtypist(st);
						ct.setSpeed(speed);
						ct.setRate(rate);
						ct.setNo_of_working_days(no_of_working_days);
						ct.compute_sal(choice,basic_salary);
						ct.display();
						break;
			}
		}while(choice!=5);
	}
}