//4.Create a class called complex for performing arithmetic with complex numbers of the form – real + imaginary * i, where i = v-1
//Write a program to test your class. Use floating point variables to represent the private date of the class. Provide a constructor that enables an object of this class to be initialized when created. Provide a no- argument constructor with default values in case no initializers are provided. Provide public methods that perform the following operations.
//a)	Add two complex numbers. (a+bi) + (c+di)=(a+c) + (b +d) i
//b)	Subtract two complex numbers. (a+bi) - (c+di)=(a-c) + (b -d) i
//c)	Multiple complex numbers (a+bi) * (c+di)=(a*c –b*d) + (a*d+b*c) i
//d)	Print complex numbers.

import java.util.*;
class Complex
{
  private double real,img;
		  
Complex()
{
real=0;
img=0;
}
Complex(double r, double i)
{
  real=r;
  img=i;
}
Complex addComplex(Complex c)
{
  Complex t=new Complex();
  t.real=real+c.real;
  t.img=img+c.img;
  return(t);
}
Complex subComplex(Complex c)
{
 Complex t=new Complex();
 t.real=real-c.real;
 t.img=img-c.img;
  return(t);

}
Complex  mulComplex(Complex c1 , Complex c2)
{
  Complex t=new Complex();
  t.real=c1.real*c2.real;
  t.img=c1.img*c2.img;
  return(t);
}
void printComplex()
{
 System.out.printf("The Complex number is %f+%fi",real,img);
}  
}
 public class Comp
{
  public static void main(String args[ ])
    { 
      
       
	   Scanner in=new Scanner(System.in);
	   double a,b,a1,b2;
       System.out.println("\nPROGRAM TO IMPLEMENT THE COMPLEX NUMBER\n\n");
       System.out.println("\n\n Enter the real number and imaganery number: \n\n");
       a=in.nextDouble();
	   b=in.nextDouble();
	   System.out.printf("%f %f",a,b);
	   System.out.println("\n\n Enter the real and imaginery  number: \n\n");
	   a1=in.nextDouble();
	   b2=in.nextDouble();
	   System.out.printf("%f %f",a1,b2);
       Complex com1=new Complex();
	   Complex com2=new Complex();
	   Complex c5=new Complex(a,b);
	   Complex c6=new Complex(a1,b2);	   
	   System.out.println("\n After entering the value");
	   System.out.println("\n After adding the value ");
	   com1=c6.addComplex(c5);
	   com1.printComplex();
	   System.out.println("\n After Subtracting the value ");
	   com1=c5.subComplex(c6);
	   com1.printComplex();
	   System.out.println("\n After Multiplying  the value ");
	   com2=com1.mulComplex(c5,c6);
	   com2.printComplex();	   	   
    }         
}
	   