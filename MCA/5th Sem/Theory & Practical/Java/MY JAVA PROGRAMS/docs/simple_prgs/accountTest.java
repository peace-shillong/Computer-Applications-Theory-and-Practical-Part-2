import java.util.Scanner;

class savingAccount{
	static double annualInterestRate=24.0;
	double savingBalance;
	savingAccount(double s){
		savingBalance=s;
		}
	public void calculateMonthlyInterest(){
		double monthInterestRate=(annualInterestRate/12)*savingBalance;
		System.out.println("the monthly interest is: "+monthInterestRate);
		savingBalance=savingBalance+monthInterestRate;
		}
	static void modifyInterestRate(double a){
		annualInterestRate=a;
		}
	public void display(){
		System.out.println("the annual interest is: "+annualInterestRate);
		System.out.println("the balance of the current saver is: "+savingBalance);
		}
}

public class accountTest{
	public static void main(String[] args){
		savingAccount s=new savingAccount(20000.0);
		System.out.println();
		s.display();
		s.calculateMonthlyInterest();
		System.out.println();
		System.out.println("enter a new value for the annual interest");
		Scanner in=new Scanner(System.in);
		double n=in.nextDouble();
		System.out.println();
		s.modifyInterestRate(n);
		s.display();
		s.calculateMonthlyInterest();
	}
}