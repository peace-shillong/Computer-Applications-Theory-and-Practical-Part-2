import java.applet.*;
import java.awt.*;
import java.net.*;
public class AnimationDemo extends Applet {
   Image pic;
   public void init() {
      String imageURL = "b1.jpg"; // path to the image
      // get the URL of the document in which this applet is embedded
      URL docURL = getDocumentBase();
      pic = getImage(docURL, imageURL);
   }
   public void paint(Graphics g) {
      int i = 0, j = 0;
      boolean moveCar = true;
      while(moveCar) { // move the car from left to right
         g.drawImage(pic, i, 30, 200, 150, this);
         i++;
         if ((i % 400) == 0) {
            i = 0; j++;
         }
         if ( j > 3) {
            moveCar = false; // stop the moving car
         }
         try {
            Thread.sleep(7);
         } catch(Exception e) { }
      }
   }
}