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

class ThreadPoolQ2
{
	public static void main(String args[])
	{
		//CREATE THREAD POOL
		ExecutorService executor=Executors.newFixedThreadPool(1);
		//ExecutorService executor=Executors.newCachedThreadPool();
		
		
		//Assign Runnable Task - 
		executor.execute(new PrintChar('@',100));
		executor.execute(new PrintChar('#',100));
		executor.execute(new PrintChar('Z',100));
		
		//
		executor.shutdown();
	}	
}