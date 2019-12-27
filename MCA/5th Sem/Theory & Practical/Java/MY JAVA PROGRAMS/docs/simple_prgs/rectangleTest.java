import java.util.Scanner;
class rectangle{
	double len;
	double wid;
	public rectangle(){
		len=1;
		wid=1;
		}
	public double getlength(){
		return len;
		}
	public double getwidth(){
		return wid;
		}
	public void setvalues(double l,double w){
		if(l>0.0 && l<20.0){
			len=l;
			}
		if(w>0.0 && w<20.0){
			wid=w;
			}
		if(l<0.0)
			System.out.println("the length is less than 0.0");
		if(l>20.0)
			System.out.println("the length is greater than 20.0");
		if(w<0.0)
			System.out.println("the width is less than 0.0");
		if(w>20.0)
			System.out.println("the width is greater than 20.0");
		}
	public void perimeter(){
		double p=2+(len*wid);
		System.out.println("the perimeter is: "+p);
		}
	public void area(){
		double a=len*wid;
		System.out.println("the area is: "+a);
		}
}

public class rectangleTest{
	public static void main(String[] args){
		rectangle r=new rectangle();
		Scanner in=new Scanner(System.in);
		System.out.println("the default length is:"+r.getlength());
		System.out.println("the default width is:"+r.getwidth());
		System.out.println("enter the new length\n");
		double l=in.nextDouble();
		System.out.println("enter the new width\n");
		double w=in.nextDouble();
		r.setvalues(l,w);
		System.out.println("after set method the length is:"+r.getlength());
		System.out.println("after set method the width is:"+r.getwidth());
		r.perimeter();
		r.area();
		}
	}