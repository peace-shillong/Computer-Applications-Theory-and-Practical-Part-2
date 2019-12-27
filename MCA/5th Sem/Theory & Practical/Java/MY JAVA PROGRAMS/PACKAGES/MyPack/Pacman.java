package MyPack;
//default package current directory
//Save file in Package Folder
//Compile as javac PackageName\JavaFile
//To compile From anywhere
//use 
//javac -classpath Z:\MCA5\Java\Packages Filenames
//Run 
//java -classpath Z:\MCA5\Java\Packages Filenames -- no need for path
//-classpath is an option of java
//CLASSPATH env var

public class Pacman{
	int lives;
	public Pacman()
	{
		lives=3;
	}
	public String toString()
	{
		return ("\nYou have "+lives+" Lives left.");
	}
}