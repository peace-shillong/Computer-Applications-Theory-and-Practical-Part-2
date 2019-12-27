/*Program to book tickets of a movie theater.Synchronised keywords have been used on functions bookSeats() and setValues()*/

class Booking implements Runnable
{
	int seat[]=new int[101];//Store the status of a seat in a theater(Total no of seats=100.)
	private int available=seat.length;
	private int count=available;
	int seatNos;
	boolean bookingStatus;
	private int seatOccupied=1;
	public void run() 
	{
		try
		{
			Customer ct = (Customer) Thread.currentThread();
			boolean bookingStatus = this.bookSeats(ct.getNo_of_seats(),ct.getName());
			if(bookingStatus==true)
			{
			
				System.out.println();
				System.out.println("\tCONGRATS!!!! "+Thread.currentThread().getName()+", your tickets have been booked successfully.");
				System.out.println("-------------------------------------------------------------------------");
				
			}
			else
			{
				System.out.println();
				System.out.println("Sorry "+Thread.currentThread().getName()+ ", unable to book your tickets as there is no ticket available for you");	
				System.out.println("-------------------------------------------------------------------------");
			}
		}
		catch(Exception e)
		{
			System.out.println("Error in Booking thread..."+e);
		}
	}
	
	public synchronized boolean bookSeats(int no_of_seats,String name)
	{
		boolean status=false;
		try
		{
			if (no_of_seats>this.getAvailable()) 
			{
				return status;
			}
			else 
			{
				available = available-no_of_seats;
				seatNos=count-available;
				status=true;
				setValues(seatNos,name);
			}
		}
		catch(Exception e)
		{
			System.out.println("Error in bookSeats()..."+e);
		}
		return status;
	
	}

	/*The seats occupied are set to 1*/

	public synchronized void setValues(int seatNos,String name)
	{
		try 
		{
			Thread.sleep(1000);//Thread.sleep(time) should always be included within a try-catch block
		} 
		catch (InterruptedException e) 
		{
			System.out.println("Interrupted in setValues()"+e);
		}
		System.out.println("-------------------------------------------------------------------------");
		System.out.print("\tBooking Seat number.....");
	
		for(int i=seatOccupied;i<=seatNos;i++)
		{
			seat[i]=1;
			this.seatOccupied=this.seatOccupied+1;
			System.out.print(" "+i+", ");
			if(seatOccupied==101)
			{
				break;
			}
		}
		try 
		{
			Thread.sleep(1000);
		} 
		catch (InterruptedException e) 
		{
			System.out.println("Interrupted exception in setValues() "+e);
		}
		System.out.print(" for Customer "+name+"......");
		System.out.println();
		
	}
	private int getAvailable()
	{
		return available;
	}
	private int getSeatOccupied()
	{
		return seatOccupied;
	}
	
}

public class MultiThread
{
	public static void main(String[] args)
	{
			try
			{
				Booking b = new Booking();
				//Each customer is a thread....cust1,cust2 and cust3 are threads
				Customer cust1 = new Customer(3,b,"Ridahunlin");
				Customer cust2 = new Customer(2, b, "Phibarisha");
				Customer cust3 = new Customer(4, b, "Puja");
				cust1.start();
				cust2.start();
				cust3.start();
			}
			catch(Exception e)
			{
				System.out.println("Error in main"+e);
			}

	}
}
class Customer extends Thread
{
	
		private int no_of_seats;
		public Customer(int no_of_seats,Runnable target,String name)
		{
			super(target,name);//invoke constructor of Thread class i.e Thread(Runnable r,String name). r is the target thread object
			this.no_of_seats = no_of_seats;
		}
		public int getNo_of_seats()
		{
			return no_of_seats;
		}

}

