import java.util.*;

class bicycle{
	private int gear;
	private int speed;
	private String brand;
	public bicycle(int g,int s,String b){
		gear=g;
		speed=s;
		brand=b;
		}
	public void setg(int g){
		gear=g;
		}
	public void sets(int s){
		speed=s;
		}
	public void setb(String b){ 
		brand=b;
		}
	public int getg(){
		return gear;
		}
	public int gets(){
		return speed;
		}
	public String getb(){
		return brand;
		}
	public void speedup(int in){
		speed=speed+in;
		}
	public void applybrake(int de){
		speed=speed-de;
		}
	public String toString(){
		System.out.println();
		return " gear: "+gear+", speed: "+speed+", brand: "+brand;
		}
	}

class MountainBike extends bicycle{
	private int seatHeight;
	public MountainBike(int g,int s,String b,int h){
		super(g,s,b);
		seatHeight=h;
		}
		public void seth(int h){
			seatHeight=h;
			}
		public int geth(){
			return seatHeight;
			}
		}
	
public class testBicycle{
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		bicycle obj=new bicycle(40,20,"omeka");
		System.out.println();
		System.out.println("fields of the class bicycle are:");
		System.out.println(obj.toString());
		MountainBike obj1=new MountainBike(30,22,"bilder",6);
		System.out.println();
		System.out.println("fields of the class MuntainBike are: ");
		System.out.println();
		System.out.println("gear: "+obj1.getg()+", speed: "+obj1.gets()+", brand: "+obj1.getb()+" and seat height: "+obj1.geth());
		
		System.out.println("enter a new value for gear");
		int g=input.nextInt();
		System.out.println("enter a new value for speed");
		int s=input.nextInt();
		
		System.out.println("enter a new value for seat height");
		int h=input.nextInt();
		System.out.println("enter a new value for brand");
		String b=input.next();
		
		obj1.setg(g);
		obj1.sets(s);
		obj1.setb(b);
		obj1.seth(h);
		System.out.println();
		System.out.println("after setting new values,all the fields are: ");
		System.out.println();
		System.out.println("gear: "+obj1.getg()+", speed: "+obj1.gets()+", brand: "+obj1.getb()+" and seat height: "+obj1.geth());
		System.out.println();
		System.out.println("enter the integer by which u want to increase the speed");
		int in=input.nextInt();
		obj1.speedup(in);
		System.out.println("the speed after incrementing by "+in+" is: "+obj1.gets());
		System.out.println();
		System.out.println("enter the integer by which u want to decrease the speed");
		int de=input.nextInt();
		obj1.applybrake(de);
		System.out.println("the speed after decrementing by "+de+" is: "+obj1.gets());
		}
	}