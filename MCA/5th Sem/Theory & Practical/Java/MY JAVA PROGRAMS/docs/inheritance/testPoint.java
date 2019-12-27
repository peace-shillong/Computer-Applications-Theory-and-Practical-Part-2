import java.util.*;

class MyPoint{
	private int x;
	private int y;
	public MyPoint(){
		x=0;
		y=0;
		}
	public MyPoint(int a,int b){
		x=a;
		y=b;
		}
	public int getx(){
		return x;
		}
	public int gety(){
		return y;
		}
	public double distance(MyPoint m){
		double d=Math.sqrt((x-m.x)*(x-m.x)+(y-m.y)*(y-m.y));
		return d;
		}
	public double distance(int a,int b){
		double d=Math.sqrt((x-a)*(x-a)+(y-b)*(y-b));
		return d;
		}
	}
	
class ThreeDPoint extends MyPoint{
	private int z;
	public ThreeDPoint(){
		super();
		z=0;
		}
	public ThreeDPoint(int a,int b,int c){
		super(a,b);
		z=c;
		}
	public int getz(){
		return z;
		}
	public double distance(int a,int b,int c){
		double d=Math.sqrt((super.getx()-a)*(super.getx()-a)+(super.gety()-b)*(super.gety()-b)+(z-c)*(z-c));
		return d;
		}
	}

public class testPoint{
	public static void main(String[] args){
		Scanner in=new Scanner(System.in);
		MyPoint obj1=new MyPoint(2,3);
		MyPoint obj2=new MyPoint(1,4);
		System.out.println();
		System.out.println("the x coordinate of the first point is:  "+obj1.getx());
		System.out.println("the y coordinate of the first point is:  "+obj1.gety());
		System.out.println("the x coordinate of the second point is:  "+obj2.getx());
		System.out.println("the y coordinate of the second point is:  "+obj2.gety());
		System.out.println();
		System.out.println("distance between the two points is: "+obj1.distance(obj2));
		System.out.println();
		System.out.println("enter a new point::");
		System.out.println();
		System.out.println("x-coordinate: ");
		int x=in.nextInt();
		System.out.println("y-coordinate: ");
		int y=in.nextInt();
		System.out.println();
		System.out.println("the distance from first point to this new point is: "+obj1.distance(x,y));
		System.out.println("the distance from second point to this new point is: "+obj2.distance(x,y));
		System.out.println();
		ThreeDPoint obj3=new ThreeDPoint(1,4,6);
		System.out.println("for three dimensional points:");
		System.out.println();
		System.out.println("the x-coordinate: "+obj3.getx());
		System.out.println("the y-coordinate: "+obj3.gety());
		System.out.println("the z-coordinate: "+obj3.getz());
		System.out.println();
		System.out.println("enter a new three dimensional point: ");
		System.out.println();
		System.out.println("x-coordinate:");
		int a=in.nextInt();
		System.out.println("y-coordinate:");
		int b=in.nextInt();
		System.out.println("z-coordinate:");
		int c=in.nextInt();
		System.out.println();
		System.out.println("the distance between these two three dimensional points is: "+obj3.distance(a,b,c));
		}
	}