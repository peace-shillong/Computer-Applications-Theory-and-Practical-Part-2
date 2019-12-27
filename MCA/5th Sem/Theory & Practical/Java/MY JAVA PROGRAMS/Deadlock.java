class A
{
	synchronized void foo(B b)
	{
		String name=Thread.currentThread().getName();
		System.out.println(name + "Entered A' Foo");
		//currentThread is inside A's monitor
		try{
			Thread.sleep(1000);
		}catch(Exception e){}
		System.out.println(name + "Attempting to Enter b's class");
		//
		b.last(); //try to enter B's Monitor
		
	}
	//Resource inside A's monitor
	synchronized void last(){
		System.out.println("inside A's last method");
	}
}

class B
{
	synchronized void bar(A a)
	{
		String name=Thread.currentThread().getName();
		System.out.println(name + "Entered B' bar");
		//currentThread is inside B's monitor
		try{
			Thread.sleep(1000);
		}catch(Exception e){}
		System.out.println(name + "Attempting to Enter a's class");
		a.last(); //try to enter A's Monitor
		
	}

	synchronized void last(){
		System.out.println("inside B's last method");
	}
}

class Deadlock implements Runnable
{
	A a=new A();//Printer
	B b=new B();//Scanner
	
	Deadlock()
	{
		Thread.currentThread().setName("Main Thread");
		new Thread(this,"Racing Thread").start();//spawns child thread - this - the task that implements runnable
		a.foo(b); //main thread calls foo
	}
	
	public void run()
	{
		b.bar(a);//racing thread calls bar
	}
	//Resource a and b are shared
	
	public static void main(String args[])
	{
		new Deadlock();
	}
}