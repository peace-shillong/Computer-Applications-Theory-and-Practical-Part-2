
package P2;
import P1.Protect;
class OtherPackage{
	OtherPackage()
	{
		Protect p= new Protect();
		System.out.println("OtherDerived");
		//System.out.println("Normal"+p.n);
		//System.out.println("Protected"+p.np);
		//System.out.println(p.pn);
		System.out.println("Public"+p.pub);
	}
}
