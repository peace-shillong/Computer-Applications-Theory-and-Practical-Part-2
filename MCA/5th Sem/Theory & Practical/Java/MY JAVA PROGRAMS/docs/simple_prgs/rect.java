//1.Create a sophisticated Rectangle class that stores only the Cartesian coordinates of the four corners of the rectangle.The constructor calls a set method 
//that accepts four sets of coordinates and verifies that each of these is in the first quadrant with no single x- or y-coordinate larger than 20.0. The 
//set method also verifies that the supplied coordinates do,in fact,specify a rectangle. Provide methods to calculate the length,width, perimeter and area.
// The length is the larger of the two dimensions. Include a predicate method isSquare which determines whether the rectangle is a square. Write a program to 
//test class Rectangle.
import java.util.*;
class Rectangle
{
	double x1,y1;
	double x2,y2;
	double x3,y3;
	double x4,y4;
	Rectangle(double cx1,double cy1,double cx2,double cy2,double cx3,double cy3,double cx4,double cy4)
	 {
		set(cx1,cy1,cx2,cy2,cx3,cy3,cx4,cy4);
	   
	 }
	 
   public void set(double cx1,double cy1,double cx2,double cy2,double cx3,double cy3,double cx4,double cy4)
		{
		   if((cx1>=0&&cy1>=0&&cx2>=0&&cy2>=0&&cx3>=0&&cy3>=0&&cx4>=0&&cy4>=0)||(cx1<20.0&&cy1<20.0&&cx2<20.0&&cy2<20.0&&cx3<20.0&&cy3<20.0&&cx4<20.0&&cy4<20.0))
		   {
			  x1=cx1;
			  x2=cx2;
			  x3=cx3;
			  x4=cx4;
			  y1=cy1;
			  y2=cy2;
			  y3=cy3;
			  y4=cy4;
			  double ln1,ln2,ln3,ln4;
			  ln1=Math.sqrt(Math.pow((x2-x1),2)+Math.pow((y2-y1),2));
			  ln2=Math.sqrt(Math.pow((x3-x2),2)+Math.pow((y3-y2),2));
			  ln3=Math.sqrt(Math.pow((x4-x3),2)+Math.pow((y4-y3),2));
			  ln4=Math.sqrt(Math.pow((x1-x4),2)+Math.pow((y1-y4),2));
			  if((ln1==ln3)&&(ln2==ln4))
				System.out.println("\nThe sides entered can represent a rectangle\n\n");	
			  else
			     System.out.println("\nThe sides entered cannot represent a rectangle\n\n");
			}
			else                                                                                                                                                 
				System.out.println("\nThe Co-ordinates entered are invalid\n\n");
		}
		

public double findLength()
{
	double ln1,ln2,ln3,ln4;
	ln1=Math.sqrt(Math.pow((x2-x1),2)+Math.pow((y2-y1),2));
	ln2=Math.sqrt(Math.pow((x3-x2),2)+Math.pow((y3-y2),2));
	ln3=Math.sqrt(Math.pow((x4-x3),2)+Math.pow((y4-y3),2));
	ln4=Math.sqrt(Math.pow((x1-x4),2)+Math.pow((y1-y4),2));     
	if(ln1>ln2)
	
		return(ln1);
	else
		return(ln2);
}

public double findWidth()
{
	double ln1,ln2,ln3,ln4;
	ln1=Math.sqrt(Math.pow((x2-x1),2)+Math.pow((y2-y1),2));
	ln2=Math.sqrt(Math.pow((x3-x2),2)+Math.pow((y3-y2),2));
	ln3=Math.sqrt(Math.pow((x4-x3),2)+Math.pow((y4-y3),2));
	ln4=Math.sqrt(Math.pow((x1-x4),2)+Math.pow((y1-y4),2));
	if(ln1>ln2)
		return(ln2);
	else
		return(ln1);
}

public double findPerimeter()
{
	double ln1,ln2,ln3,ln4;
	ln1=Math.sqrt(Math.pow((x2-x1),2)+Math.pow((y2-y1),2));
	ln2=Math.sqrt(Math.pow((x3-x2),2)+Math.pow((y3-y2),2));
	ln3=Math.sqrt(Math.pow((x4-x3),2)+Math.pow((y4-y3),2));
	ln4=Math.sqrt(Math.pow((x1-x4),2)+Math.pow((y1-y4),2));
	return(2*(ln1+ln2));
}

 public double findArea()
{
	double ln1,ln2,ln3,ln4;
	ln1=Math.sqrt(Math.pow((x2-x1),2)+Math.pow((y2-y1),2));
	ln2=Math.sqrt(Math.pow((x3-x2),2)+Math.pow((y3-y2),2));
	ln3=Math.sqrt(Math.pow((x4-x3),2)+Math.pow((y4-y3),2));
	ln4=Math.sqrt(Math.pow((x1-x4),2)+Math.pow((y1-y4),2));
	return(ln1*ln2);
}

public void isSquare()
{
		  double ln1,ln2,ln3,ln4;
		  ln1=Math.sqrt(Math.pow((x2-x1),2)+Math.pow((y2-y1),2));
		  ln2=Math.sqrt(Math.pow((x3-x2),2)+Math.pow((y3-y2),2));
		  ln3=Math.sqrt(Math.pow((x4-x3),2)+Math.pow((y4-y3),2));
		  ln4=Math.sqrt(Math.pow((x1-x4),2)+Math.pow((y1-y4),2));
		  if(ln1==ln2)
			System.out.println("The sides entered represents a square\n\n");
		   else
			System.out.println("\nThe sides entered does not represent a square\n\n");
}
}

public class rect
{
  public static void main(String args[ ])
    {
      
	  Scanner in=new Scanner(System.in);
      double cx1,cy1,cx2,cy2,cx3,cy3,cx4,cy4;
      System.out.println("\nPROGRAM TO IMPLEMENT A RECTANGLE CLASS USING CARTESIAN CO-ORDINATES\n\n");
	  System.out.println("\n\n Enter the coordinates for (x1,y1): \n\n");
	  cx1=in.nextDouble();
	  cy1=in.nextDouble();
	  System.out.printf("%f, %f",cx1,cy1);      	 
	  System.out.printf("\n\nEnter the coordinates for (x2,y2):\n\n ");
	  cx2=in.nextDouble();
	  cy2=in.nextDouble();
      System.out.printf("%f, %f",cx2,cy2); 	
	  System.out.println("\n\nEnter the coordinates for (x3,y3):\n\n ");
	  cx3=in.nextDouble();
	  cy3=in.nextDouble();
	  System.out.printf("%f, %f",cx3,cy3);	
	  System.out.println("\n\nEnter the coordinates for (x4,y4):\n\n ");
	  cx4=in.nextDouble();
	  cy4=in.nextDouble();
	  System.out.printf("%f, %f",cx4,cy4);
	  Rectangle r1=new Rectangle(cx1,cy1,cx2,cy2,cx3,cy3,cx4,cy4);
	  System.out.println("\n\nRECTANGLE:\n\n ");
	  System.out.println("\n\nLength(greatest side):\n\n " +r1.findLength());
	
	  System.out.println("\n\nWidth(shortest side):\n\n " +r1.findWidth());
	  
	  System.out.println("\n\nPerimeter:\n\n " +r1.findPerimeter());
	 
	  System.out.println("\n\nArea of the rectangle:\n\n " +r1.findArea());
	  
	  r1.isSquare();
	  System.out.println();
    }
}


