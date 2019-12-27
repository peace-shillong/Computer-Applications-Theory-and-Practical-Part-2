import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
public class main extends JFrame implements ActionListener{
JMenu m1;
//JMenu m2;
public main(){
JFrame frame=new JFrame("Student Information System");
frame.setVisible(true);
frame.setSize(500,500);
frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

JMenuBar mb=new JMenuBar();
frame.setJMenuBar(mb);

m1=new JMenu("Operation");
//m2=new JMenu("Exit");
JMenuItem item1=new JMenuItem("INSERT");
JMenuItem item2=new JMenuItem("UPDATE");
JMenuItem item3=new JMenuItem("DELETE");
mb.add(m1);
//mb.add(m2);
m1.add(item1);
m1.add(item2);
m1.add(item3);




item1.addActionListener(this);//add to perform action
item2.addActionListener(this);
item3.addActionListener(this);
//m2.addActionListener(this);
}

public void actionPerformed(ActionEvent ae){
if(ae.getActionCommand()=="INSERT"){
//SET VISIBLE THE INSERT FORM
new insert_form();
this.setVisible(false);
}
if(ae.getActionCommand()=="UPDATE"){

//SET VISIBLE THE UPDATE FORM
new update_form();
this.setVisible(false);
}
if(ae.getActionCommand()=="DELETE"){
//SET VISIBLE THE INSERT FORM
new delete_form();
this.setVisible(false);
}
/*if(ae.getActionCommand()=="Exit"){
//SET VISIBLE THE INSERT FORM

this.setVisible(false);
}*/
}

public static void main(String args[]){
new main();
}
}

	