import java.awt.*;
import javax.swing.*;
import java.awt.event.*;
public class MouseEventsDemo extends Frame implements MouseListener, MouseMotionListener 
{
		TextField tf;
		public MouseEventsDemo(String title){
		super(title);
		tf = new TextField(60);
		addMouseListener(this); 	// Register event listener to the event source
}
// Displays GUI
public void launchFrame() 
{
	 add(tf, BorderLayout.SOUTH);
	 setSize(300,300);
	setVisible(true);
}
// Implement methods of event listener interface
public void mouseClicked(MouseEvent me)
 {
	 String msg = "Mouse clicked.";
	 tf.setText(msg);
 }
public void mouseEntered(MouseEvent me)
{
	 String msg = "Mouse entered component.";
	tf.setText(msg);
}
public void mouseExited(MouseEvent me) {
	String msg = "Mouse exited component.";
	 tf.setText(msg);
 }
public void mousePressed(MouseEvent me) {
	 String msg = "Mouse pressed.";
	 tf.setText(msg);
 }
public void mouseReleased(MouseEvent me) 
{
	 String msg = "Mouse released.";
	 tf.setText(msg);
}
public void mouseDragged(MouseEvent me) {
	 String msg = "Mouse dragged at " + me.getX()  + "," + me.getY();
	 tf.setText(msg);
}
public void mouseMoved(MouseEvent me) {
	 String msg = "Mouse moved at " + me.getX() + "," + me.getY();
	 tf.setText(msg);
 }
// Main method
public static void main(String args[]) {
	 MouseEventsDemo med = new MouseEventsDemo("Mouse Events Demo");
	 med.launchFrame();
	}
}

