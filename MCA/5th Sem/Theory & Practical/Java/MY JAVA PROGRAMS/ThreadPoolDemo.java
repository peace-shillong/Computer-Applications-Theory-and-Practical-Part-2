import java.util.concurrent.*;

class PrintChar implements Runnable
{
	char ch; int n;
	PrintChar(char c,int num)
	{
		ch=c;
		n=num;
	}
	
	public void run()
	{
		for(int i=0;i<n;i++)		
			System.out.print(ch+"\t");
		System.out.println();
		
	}
}

class PrintNum implements Runnable
{
	int n;
	PrintNum(int num)
	{	
		n=num;
	}
	
	public void run()
	{
		for(int i=1;i<=n;i++)		
			System.out.print(i+"\t");
		System.out.println();
		
	}
}

class ThreadPoolDemo
{
	public static void main(String args[])
	{
		//CREATE THREAD POOL
		ExecutorService executor=Executors.newFixedThreadPool(2);
		//ExecutorService executor=Executors.newCachedThreadPool();
		
		
		//Assign Runnable Task - 
		executor.execute(new PrintChar('a',100));
		executor.execute(new PrintChar('b',100));
		executor.execute(new PrintNum(100));
		
		//
		executor.shutdown();
	}	
}