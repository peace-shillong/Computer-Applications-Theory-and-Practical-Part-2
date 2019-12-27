import java.awt.*;
import java.awt.event.*;
import java.applet.*;

public class L1 extends Applet implements ActionListener {

   Button N = new Button("NORTH");
   Button S = new Button("SOUTH");
   Button E = new Button("EAST");
   Button W = new Button("WEST");
   Button C = new Button("CENTER");

   public void init() {
      setup_layout();
   }

   private void setup_layout() {
      setLayout(new BorderLayout());
      setBackground(Color.red);
      setForeground(Color.white);

      add("North", N);
      add("South", S);
      add("Center", C);
      add("West", W);
      add("East", E);

      N.addActionListener(this);
      S.addActionListener(this);
      E.addActionListener(this);
      W.addActionListener(this);
      C.addActionListener(this);
   }

   public void actionPerformed(ActionEvent e) {
      if (e.getSource() == N) {
         showStatus("North button pushed");
      }
      else if (e.getSource() == S) {
         showStatus("South button pushed");
      }
      else if (e.getSource() == E) {
         showStatus("East button pushed");
      }
      else if (e.getSource() == W) {
         showStatus("West button pushed");
      }
      else if (e.getSource() == C) {
         showStatus("Center button pushed");
      }
    
   }
}