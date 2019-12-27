class PrintChar implements Runnable{
	char ch;
	PrintChar(char c){
		ch =c;
	}
	public void run()
	{
			int i;
			for(i=0;i<10;i++)
			System.out.println(ch);		
	}
}

class MainThreadProgram{
	public static void main(String args[])
	{
		int i;
		PrintChar taska=new PrintChar('A');
		PrintChar taskb = new PrintChar('b');
		
		Thread t=new Thread(taska);
		Thread t2=new Thread(taskb);
		
		t.start();
		t2.start();
		System.out.println("Current Thread"+Thread.currentThread());
		try{
		for(i=0;i<=10;i++){			
			System.out.println(i);
			Thread.sleep(1000);
		}
		}
		catch(InterruptedException e)
		{
			System.out.println(e);
		}
		
	}
}