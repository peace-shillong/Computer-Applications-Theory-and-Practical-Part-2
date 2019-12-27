class Q
{
	int n;	
	boolean valueSet=false;
	synchronized void put(int val)
	{
		while(valueSet)
		{
			try{
					wait();
				}catch(InterruptedException e){}
		}
		this.n=val;
		System.out.println("Produced "+n);
		valueSet=true;
		notify();
	}
	 
	 synchronized int get()
	 {
		while(!valueSet)
		{
			try{
					wait();
				}catch(InterruptedException e){}
		
		}
		System.out.println("Consumed "+n);
		valueSet=false;
		notify();
		return n;
	 }
}

class Producer implements Runnable
{
		Q q;
		int i=0;
		Producer(Q q)
		{
			this.q=q;
			new Thread(this,"Producer").start();
		}
		public void run() //Producing 0-100
		{			
			while(i<=100)
			{
				q.put(i);
				/*try{
				Thread.sleep(1);
				}catch(Exception e){}
				*/
				i++;
			}
		}
}

class Consumer implements Runnable
{
	Q q;
	int i=0;
	Consumer(Q q)
	{
		this.q=q;
		new Thread(this,"Consumer").start();
	}
	
	public void run() //Consuming 0-100
	{
		
		while(i<=100)
		{
			int n=q.get();
			/*try{
				Thread.sleep(1);
				}catch(Exception e){}*/
			i++;
		}
	}
}


class PeoducerComsumer
{
	public static void main(String args[])
	{
		Q q = new Q();
		new Producer(q);
		new Consumer(q);
	}
}