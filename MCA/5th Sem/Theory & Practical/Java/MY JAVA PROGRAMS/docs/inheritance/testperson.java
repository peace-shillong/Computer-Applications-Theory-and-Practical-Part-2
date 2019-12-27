import java.util.*;

class person{
	private String name;
	private String add;
	private int phn;
	private String email;
	public person(String n,String a,int p,String e){
		name=n;
		add=a;
		phn=p;
		email=a;
		}
		public String getname(){
			return name;
			}
		public String getadd(){
			return add;
			}
		public int getphn(){
			return phn;
			}
		public String getemail(){
			return email;
			}
		
	public String toString(){
		return "class name: person and person name: "+name;
		}
	}

class student extends person{
	private String status;
	public student(String n,String a,int p,String e,String s){
		super(n,a,p,e);
		status=s;
		}
	public String getstatus(){
			return status;
			}
	public String toString(){
		return "class name: student and person name: "+getname();
		}
	}
class employee extends person{
	private String off;
	private String date;
	private int sal;
	public employee(String n,String a,int p,String e,String o,String d,int sl){
		super(n,a,p,e);
		off=o;
		date=d;
		sal=sl;
		}
	public String getoff(){
			return off;
			}
	public String getdate(){
			return date;
			}
	public int getsal(){
			return sal;
			}	

	public String toString(){
		return "class name: employee and person name: "+getname();
		}	

	}

class faculty extends employee{
	private int hour;
	private int rank;
	public faculty(String n,String a,int p,String e,String o,String d,int sl,int h,int r){
		super(n,a,p,e,o,d,sl);
		hour=h;
		rank=r;
		}

	public int gethour(){
			return hour;
			}
	public int getrank(){
			return rank;
			}
	public String toString(){
		return "class name: faculty and person name: "+getname();
		}
	}
class staff extends employee{
	private String tit;
	public staff(String n,String a,int p,String e,String o,String d,int sl,String t){
		super(n,a,p,e,o,d,sl);
		tit=t;
		}
	public String gettitle(){
			return tit;
			}
	public String toString(){
		return "class name: staff and person name: "+getname();
		}	
	}

class MyDate{
	private int year;
	private String month;
	private int date;
	public MyDate(int y,String m,int d){
		year=y;
		month=m;
		date=d;
		}
	public String toString(){
		return "date is: "+date+"/"+month+"/"+year;
		}
	}

public class testperson{
	public static void main(String[] args){
		System.out.println();
		person pr=new person("basu","barpeta",9823,"mailantra@gmail.com");
		System.out.println(pr.toString());
		System.out.println("address: "+pr.getadd());
		System.out.println("phone no: "+pr.getphn());
		System.out.println("email address: "+pr.getemail());
		System.out.println();
		student std=new student("basavi","nagao",98676,"obghj@gmail.com","2nd year");
		System.out.println(std.toString());
		System.out.println("address: "+std.getadd());
		System.out.println("phone no: "+std.getphn());
		System.out.println("email address: "+std.getemail()); 
		System.out.println("class status: "+std.getstatus());
		System.out.println();
		employee em=new employee("devi","shillong",8345,"dddddd@gmail.com","pwd","12-11-2011",3000);
		System.out.println(em.toString());
		System.out.println("address: "+em.getadd());
		System.out.println("phone no: "+em.getphn());
		System.out.println("email address: "+em.getemail()); 
		System.out.println("office: "+em.getoff());
		System.out.println("date: "+em.getdate());
		System.out.println("salary: "+em.getsal());
		System.out.println();
		faculty fa=new faculty("nita","delhi",674,"hjvhdwj@gmail.com","ppp","11-10-1211",4000,4,2);
		System.out.println(fa.toString());
		System.out.println("address: "+fa.getadd());
		System.out.println("phone no: "+fa.getphn());
		System.out.println("email address: "+fa.getemail()); 
		System.out.println("office: "+fa.getoff());
		System.out.println("date: "+fa.getdate());
		System.out.println("salary: "+fa.getsal());
		System.out.println("hour: "+fa.gethour());
		System.out.println("rank: "+fa.getrank());
		System.out.println();
		staff st=new staff("rola","delhi",6748,"hjvhj@gmail.com","sss","11-09-1999",3200,"das");
		System.out.println(st.toString());
		System.out.println("address: "+st.getadd());
		System.out.println("phone no: "+st.getphn());
		System.out.println("email address: "+st.getemail()); 
		System.out.println("office: "+st.getoff());
		System.out.println("date: "+st.getdate());
		System.out.println("salary: "+st.getsal());
		System.out.println("title: "+st.gettitle());
		System.out.println();
		MyDate md=new MyDate(23,"FEB",1999);
		System.out.println(md.toString());

		}
	}