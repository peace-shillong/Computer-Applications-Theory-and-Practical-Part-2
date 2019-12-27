import java.util.*;

class Dog{
	private String sex;
	private String  breed;
	private int weight;
	private String dob;
	public Dog(String s,String b,int w,String d){
		sex=s;
		breed=b;
		weight=w;
		dob=d;
		}
	public void setSex(String s){
		sex=s;
		}
	public void setBreed(String b){
		breed=b;
		}
	public void setWeight(int w){
		weight=w;
		}
	public void setDate(String d){
		dob=d;
		}
	public String getSex(){
		return sex;
		}
	
	public String getBreed(){
		return breed;
		}

	public int getWeight(){
		return weight;
		}

	public String getDate(){
		return dob;
		}
	public String toString(){
		return "sex: "+sex+", breed: "+breed+", weight: "+weight+", date of birth: "+dob;	
		}
	}

class petDog extends Dog{
	private String add;
	private String own;
	public petDog(String s,String b,int w,String d,String a,String o){
		super(s,b,w,d);
		add=a;
		own=o;
		}
	public void setAddress(String a){
		add=a;
		}
	public void setOwner(String o){
		own=o;
		}
	public String getAddress(){
		return add;
		}
	
	public String getOwner(){
		return own;	
		}
	}
	
class WorkingDog extends Dog{
	private String bn;
	private String ba;
	private String wk;
	public WorkingDog(String s,String b,int w,String d,String n,String a,String k){
		super(s,b,w,n);
		bn=n;
		ba=a;
		wk=k;
		}
	public void setBName(String n){
		bn=n;
		}
	public void setBAdd(String a){
		ba=a;
		}
	public void setWKind(String k){
		wk=k;
		}
	public String getBName(){
		return bn;
		}
	
	public String getBAdd(){
		return ba;
		}

	public String getWKind(){
		return wk;
		}
	}
	
public class testDog{
	public static void main(String[] args){
		Scanner a=new Scanner(System.in);
		Dog obj=new Dog("male","local",30,"12-02-2010");
		petDog obj1=new petDog("female","local",28,"11-12-2010","shillong","basavi");
		WorkingDog obj2=new WorkingDog("male","local",28,"10-11-2010","lll","poolice force","detective");
		System.out.println();
		System.out.println("fields of class Dog are: ");
		System.out.println(obj.toString());
		System.out.println();
		System.out.println("fields of class petDog are: ");
		System.out.println("sex: "+obj1.getSex()+", breed: "+obj1.getBreed()+", weight: "+obj1.getWeight()+", dob: "+obj1.getDate()+", Dog owner: "+obj1.getOwner()+", Dog address: "+obj1.getAddress());
		System.out.println();
		System.out.println("the fields of class workingDog are: ");
		System.out.println("sex: "+obj2.getSex()+", breed: "+obj2.getBreed()+", weight: "+obj2.getWeight()+", dob: "+obj2.getDate()+", working name: "+obj2.getBName()+", working address: "+obj2.getBAdd()+", work kind: "+obj2.getWKind());
		System.out.println();
		
		System.out.println("\n\nEnter Dog's new Business name: ");
		String bn=a.nextLine();
		System.out.println("\nEnter Dog's new Business address: ");
		String ba=a.nextLine();
		System.out.println("\nEnter Dog's new Work type: ");
		String wrk=a.nextLine();
		System.out.println("\nEnter Dog's new sex: ");
		String s=a.nextLine();
		System.out.println("\nEnter Dog's new breed: ");
		String b=a.nextLine();
		System.out.println("\nEnter Dog's new weight: ");
		int w=a.nextInt();
		System.out.print("\nEnter Dog's new date of birth: ");
		String db=a.next();
		obj2.setSex(s);
		obj2.setBreed(b);
		obj2.setWeight(w);
		obj2.setDate(db);
		obj2.setBName(bn);
		obj2.setBAdd(ba);
		obj2.setWKind(wrk);
		System.out.println();
		System.out.println("sex: "+obj2.getSex()+", breed: "+obj2.getBreed()+", weight: "+obj2.getWeight()+", dob: "+obj2.getDate()+", working name: "+obj2.getBName()+", working address: "+obj2.getBAdd()+", work kind: "+obj2.getWKind());
		}
	}