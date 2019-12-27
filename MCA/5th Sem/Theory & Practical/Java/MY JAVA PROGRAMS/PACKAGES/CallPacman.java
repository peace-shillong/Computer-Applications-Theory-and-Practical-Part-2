import MyPack.*;
import MyPack.SubPack.*;
class CallPacman{
	public static void main(String args[])
	{
		Pacman p=new Pacman();
		System.out.println(p.toString());
		Pacwoman w=new Pacwoman();
		System.out.println(w.toString());
	}
}