package P1;

class Others{
	Others()
	{
		Protect p= new Protect();//Object
		System.out.println("Others");
		System.out.println(p.n);
		System.out.println(p.np);
		//System.out.println(p.pn);
		System.out.println(p.pub);
	}
}