import java.util.*;
class BankAccount
{
	String account_holder;
	String account_no;
	int balance_amount;
	boolean flag=false;
	BankAccount(String ah,String an,int amt)
	{
		account_holder=ah;
		account_no=an;
		balance_amount=amt;
	}
	synchronized void moneyDeposit(int n)
	{
		while(flag)
		{
			try
			{
				wait();
			}
			catch(InterruptedException e)
			{
			}
		}
		balance_amount=n;
		balance_amount=balance_amount+n;
		flag=true;
		System.out.println("Balance amount="+balance_amount);
		notify();
	}
	synchronized int moneyWithdraw(int n)
	{
		while(!flag)
		{
			try
			{
				wait();
			}
			catch(InterruptedException e)
			{
			}
		}
			if(balance_amount<n)
			{
				System.out.println("Cannot withdraw amount");
			}
			else
			{
				balance_amount=balance_amount-n;
				System.out.println("Balance amount="+balance_amount);
				flag=false;
				notify();
			}
			return balance_amount;
			
	}
}
class DepositMoney implements Runnable
{
	BankAccount bank;
	Scanner sc=new Scanner(System.in);
	DepositMoney(BankAccount b)
	{
		bank=b;
		new Thread(this,"DepositMoney").start();
	}
	public void run()
	{
		while(true)
		{
			System.out.println("Enter money to deposit:");
			int mon=sc.nextInt();
			bank.moneyDeposit(mon);
		}
	}
}
class WithdrawMoney implements Runnable
{
	BankAccount bank;
	Scanner sc=new Scanner(System.in);
	WithdrawMoney(BankAccount b)
	{
		bank=b;
		new Thread(this,"WithdrawMoney").start();
	}
	public void run()
	{
		while(true)
		{
			System.out.println("Enter money to withdraw:");
			int mon=sc.nextInt();
			bank.moneyWithdraw(mon);
		}
	}
}

class Qstn2_2015
{
		public static void main(String args[])
		{
			Scanner sc=new Scanner(System.in);
			System.out.println("Enter name:");
			String name=sc.nextLine();
			System.out.println("Enter account no:");
			String acc=sc.nextLine();
			System.out.println("Enter balance amount:");
			int amt=sc.nextInt();
			BankAccount bank=new BankAccount(name,acc,amt);
			new DepositMoney(bank);
			new WithdrawMoney(bank);
			System.out.println("Press Ctrl+C to exit");
		}
}