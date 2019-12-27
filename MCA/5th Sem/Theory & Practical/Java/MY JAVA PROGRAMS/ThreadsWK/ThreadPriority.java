class Print implements Runnable
{
	public void run()
	{
		int i=0;
		while(i<10)
			System.out.println(Thread.currentThread()+" "+i++);
	}
}

class ThreadPriority
{
	public static void main(String args[]){
	Print p=new Print();
	Thread t1,t2,t3;
	
	t1=new Thread(p,"First");
	t2=new Thread(p,"Second");
	t3=new Thread(p,"Third");
	
	t1.setPriority(10);
	t2.setPriority(1);
	t3.setPriority(5);
	
	t3.start();
	t1.start();
	t2.start();
	
	}
}