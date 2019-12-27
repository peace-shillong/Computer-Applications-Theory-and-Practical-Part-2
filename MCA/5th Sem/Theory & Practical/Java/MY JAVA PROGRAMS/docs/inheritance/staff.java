import java.util.Scanner;
class staff
{
	private int code;
	private String name;
	public int getCode()
	{
		return this.code;
	}
	public void setCode(int code)
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
	public double compute_allowances(int emp_type,String emp_grade)//Compute allowances for employee
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
	public void compute_sal(int type,double basic_salary);//compute salary of employee
	public void display();
}
class teacher  extends staff implements staffSalary
{
	private String subject;
	double salary;
	teacher()
	{}
	teacher(staff st)
	{
		System.out.println("-------------------------------------------------------------------------------");
		System.out.println();
		System.out.println("\t\t\t\tTeacher's Details\t\t\t\t");
		System.out.println("\t\t\t\tEmployee code="+st.getCode());
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
		this.salary=basic_salary+super.compute_allowances(type,null);
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
		this.salary=basic_salary+super.compute_allowances(type,grade);
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
	private int speed;
	double salary;
	regulartypist(staff st)
	{
		System.out.println("-------------------------------------------------------------------------------");
		System.out.println();
		System.out.println("\t\t\t\tRegular Typist's Details\t\t\t\t");
		System.out.println("\t\t\t\tEmployee code="+st.getCode());
		System.out.println("\t\t\t\tEmployee name="+st.getName());
	}
	public int getSpeed()
	{
		return speed;
	}
	public void setSpeed(int speed)
	{
		this.speed=speed;
	}
	public void compute_sal(int type,double basic_salary)
	{
		this.salary=basic_salary+super.compute_allowances(type,null);
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
	private int speed;
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
	public int getSpeed()
	{
		return speed;
	}
	public void setSpeed(int speed)
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
		this.salary=rate*no_of_working_days;
	}
	public void display()
	{
		System.out.println("\t\t\t\tSalary=Rs "+salary);
		System.out.println("\t\t\t\tSpeed="+speed+" words per minute");
		System.out.println();
		System.out.println("--------------------------------------------------------------------------------");
		
	}
}

class mainClass
{
	public static void main(String a[])
	{
		int choice;
		int speed;
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
						System.out.println("Enter code and name of the teacher");
						code=sc.nextInt();
						sc.nextLine();
						name=sc.nextLine();
						System.out.println("Enter the teacher's subject");
						subject=sc.nextLine();
						System.out.println("Enter the teacher's basic salary");
						basic_salary=sc.nextDouble();
						st.setCode(code);
						st.setName(name);
						teacher t=new teacher(st);
						t.setSubject(subject);
						t.compute_sal(choice,basic_salary);
						t.display();
						/*Demonstration on how to use getter method*/
						System.out.println("Demonstration on how to use getter method...Displaying the subject of a teacher");
						System.out.println("Subject of the teacher is "+t.getSubject());
						break;
				case 2:
						System.out.println("Enter code and name of the officer"); 
						code=sc.nextInt();
						sc.nextLine();
						name=sc.nextLine();
						System.out.println("Enter the Officer's grade: A or B");
						grade=sc.nextLine();
						System.out.println("Enter the Officer's basic salary");
						basic_salary=sc.nextDouble();
						st.setCode(code);
						st.setName(name);
						officer off=new officer(st);
						off.setGrade(grade);
						off.compute_sal(choice,basic_salary);
						off.display();
						
						break;
				case 3:
						System.out.println("Enter code and name of the regular typist");
						code=sc.nextInt();
						sc.nextLine();
						name=sc.nextLine();
						System.out.println("Enter the tyist's speed");
						speed=sc.nextInt();
						System.out.println("Enter the typist's basic salary");
						basic_salary=sc.nextDouble();
						st.setCode(code);
						st.setName(name);
						regulartypist rt=new regulartypist(st);
						rt.setSpeed(speed);
						rt.compute_sal(choice,basic_salary);
						rt.display();
						break;
				case 4:
						System.out.println("Enter code and name of the Casual typist");
						code=sc.nextInt();
						sc.nextLine();
						name=sc.nextLine();
						System.out.println("Enter the tyist's speed");
						speed=sc.nextInt();
						System.out.println("Enter the typist's rate of salary per day");
						rate=sc.nextDouble();
						System.out.println("Enter the typist's no of working days");
						no_of_working_days=sc.nextDouble();
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