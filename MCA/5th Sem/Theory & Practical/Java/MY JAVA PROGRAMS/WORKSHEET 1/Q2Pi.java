class Q2Pi{
	
	public static void main(String args[])
	{
		double a,p,pi;
		p=0;
		int flag=0;
		for(a=1;a<=13;a=a+2)
		{
			if(flag==0)
			{
				p=p+(1.0/a);
				flag=1;
			}
			else
			{
				p=p-(1.0/a);
				flag=0;
			}
		}
		pi=4.0*p;
		System.out.println("PI : "+pi);
	}
}