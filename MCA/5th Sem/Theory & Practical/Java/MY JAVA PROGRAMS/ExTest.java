class ExTest
{
	public static void main(String args[])
	{
		try{
			//Obj a=new Obj();
		int a[] = new int[2];
		a[0]=1;
		a[1]=2;
		a[2]=3;
		a[3]=2;
		for(int i=0;i<10;i++)
		System.out.println(" s"+a[i]);
		}
		catch(Exception e){}
		
	}
}
class Obj{
	private Obj(){}
}