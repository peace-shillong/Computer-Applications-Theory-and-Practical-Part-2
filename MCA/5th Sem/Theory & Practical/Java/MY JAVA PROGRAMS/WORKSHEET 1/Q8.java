//inch to cm - Multiply
//inch to meter /

//pound to kg - /

import java.util.*; 
class Q8{
	
	public static void main(String args[])
	{
		double bmi,wp,hi,hm,wk;

		Scanner sc=new Scanner(System.in);

		System.out.print("Enter Your Height in inches :");
		hi=sc.nextDouble();
		System.out.print("Enter Your Weight in pounds :");
		wp=sc.nextDouble();

		hm=hi*0.0254;
		wk=wp*0.45359237;

		System.out.println("Your Height in meters is :"+hm);
		System.out.println("Your Weight in kilograms is :"+wk);
		
		bmi=wk/(hm*hm);

		if(bmi<18.5)
			System.out.println(" Underweight");
		else if(bmi<25.0)
			System.out.println(" Normal");	
		else if(bmi<30.0)
			System.out.println(" Overweight");
		else 
			System.out.println(" Obese");
		
	}
}