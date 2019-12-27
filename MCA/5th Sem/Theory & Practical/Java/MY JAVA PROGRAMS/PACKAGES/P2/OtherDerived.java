package P2;
import P1.Protect;
class OtherDerived extends Protect{

	OtherDerived()
	{
		System.out.println("OtherDerived");
		//System.out.println("Normal"+p.n);
		System.out.println("Protected"+np);
		//System.out.println(p.pn);
		System.out.println("Public"+pub);
	}
}