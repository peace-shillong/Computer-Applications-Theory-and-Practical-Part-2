import java.util.Scanner;

class Rational{
	private int num;
	private int deno;
	public Rational(){
		num=0;
		deno=0;
		}
	public Rational(int r,int d){
		num=r;
		deno=d;
		if(num<=deno){
			for(int k=num;k>1;k--){
				if(num%k==0 && deno%k==0){
					num=num/k;
					deno=deno/k;
					}
				}
			System.out.println("the reduced form of the fraction is: "+num+"/"+deno);
			}
		if(deno<=num){
			for(int k=deno;k>1;k--){
				if(num%k==0 && deno%k==0){
					num=num/k;
					deno=deno/k;
					}
				}
			System.out.println("the reduced form of the fraction is: "+num+"/"+deno);
			}
		}
	public Rational add(Rational s){
		Rational r=new Rational();
		r.deno=deno*s.deno;
		r.num=(s.deno*num)+(deno*s.num);
		return r;
		}
	public Rational sub(Rational s){
		Rational r=new Rational();
		r.deno=deno*s.deno;
		r.num=s.deno*num-deno*s.num;
		return r;
		}
	public Rational mul(Rational s){
		Rational r=new Rational();
		r.deno=deno*s.deno;
		r.num=num*s.num;
		return r;
		}
	public Rational div(Rational s){
		Rational r=new Rational();
		r.deno=deno*s.num;
		r.num=num*s.deno;
		return r;
		}
	public void display(){
		if(num<=deno){
			for(int k=num;k>1;k--){
				if(num%k==0 && deno%k==0){
					num=num/k;
					deno=deno/k;
					}
				}
			}
		if(deno<=num){
			for(int k=deno;k>1;k--){
				if(num%k==0 && deno%k==0){
					num=num/k;
					deno=deno/k;
					}
				}
			}
		System.out.println("the resultent fraction is: "+num+"/"+deno);
		}
	}
	
public class testRational{
	public static void main(String[] args){
		Scanner in=new Scanner(System.in);
		System.out.println("Enter the numerator for the first fraction:");
		int num1=in.nextInt();
		System.out.println("Enter the denomurator for the first fraction:");
		int deno1=in.nextInt();
		Rational r1=new Rational(num1,deno1);
		System.out.println();
		System.out.println("Enter the numerator for the second fraction:");
		int num2=in.nextInt();
		System.out.println("Enter the denomurator for the second fraction:");
		int deno2=in.nextInt();
		
		Rational r2=new Rational(num2,deno2);
		System.out.println();
		System.out.println("ADDITION:");
		Rational r3=r1.add(r2);
		r3.display();
		System.out.println();
		System.out.println("SUBTRACTION");
		Rational r4=r1.sub(r2);
		r4.display();
		System.out.println();
		System.out.println("MULTIPLICATION:");
		Rational r5=r1.mul(r2);
		r5.display();
		System.out.println();
		System.out.println("DIVISION:");
		Rational r6=r1.div(r2);
		r6.display();
		}
	}