import java.util.*;
class BMI
{
	public static void main(String srgs[])
	{
		Scanner sc=new Scanner(System.in);
		double wt,ht,bmi,w,h;
		System.out.println("Enter the weight in pound:");
		wt=sc.nextInt();
		System.out.println("Enter the height in inches:");
		ht=sc.nextInt();
		w=wt*0.45359237;
		h=ht*0.0254;
		System.out.println("Weight in kilogram is "+w);
		System.out.println("Height in meters is "+h);
		bmi=w/(h*h);
		if(bmi<18.5)
			System.out.println("Underweight");
		else if(bmi>=18.8 && bmi<25.0)
			System.out.println("Normal");
		else if(bmi>=25.0 && bmi<30.0)
			System.out.println("Overweight");
		else if(bmi>=30.0)
			System.out.println("Obese");
	}
}