import java.util.*;
class PrintChar implements Runnable{
	char ch;
	
	public void run()
	{
			int i,f,s,next;
			f=0;s=1;next=1;
			System.out.println(f+" "+s);
			try{
			for(i=0;i<10;i++){
				System.out.print(" "+next);		
				next=f+s;
				f=s;
				s=next;
				Thread.sleep(1000);
			}
			}catch(Exception e)
			{}
	}
}

class MainThreadProgram2{
	public static void main(String args[])
	{
		int i,r,rev,temp;
		PrintChar taska=new PrintChar();
			
		Thread t=new Thread(taska);
				
		t.start();
		
		System.out.println("Current Thread"+Thread.currentThread());
		System.out.println("Enter a Number");
		Scanner sc=new Scanner(System.in);
		i=sc.nextInt();
		temp=i;
		rev=0;
		try{
		while(temp>0){
			r=temp%10;
			rev=rev*10+r;
			temp=temp/10;
			Thread.sleep(1);
		}
		if(rev==i)
		{
			System.out.println("Palindrome Number");			
		}
		else{
			System.out.println("Not a Palindrome Number");
			
		}
		}
		catch(Exception e)
		{
			System.out.println(e);
		}
		
	}
}