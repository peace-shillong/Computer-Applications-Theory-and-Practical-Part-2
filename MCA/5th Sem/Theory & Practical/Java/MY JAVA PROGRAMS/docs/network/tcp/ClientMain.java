import javax.swing.JFrame;
public class ClientMain
{
	public static void main( String args[] )
	{
		Client application; // declare client application
		 // if no command line args
		if ( args.length == 0 )
		application = new Client( "127.0.0.1" );
		else
		application = new Client( args[ 0 ] );
		application.setDefaultCloseOperation( JFrame.EXIT_ON_CLOSE );
		application.runClient(); // run client application
	 } // end main
 } // end class ClientTest