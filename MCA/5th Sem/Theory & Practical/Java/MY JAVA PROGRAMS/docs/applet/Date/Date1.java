import java.awt.Graphics;
import javax.swing.JApplet;
import javax.swing.JOptionPane;
import java.math.*;


import java.text.SimpleDateFormat;

import java.util.Date;
public class Date1 extends JApplet
{
        Date date = new Date();
        SimpleDateFormat sdf;
        
        String temp;
        int current_day;
        int current_month;
        int current_year;
        
        int input_day;
        int input_month;
        int input_year;
        
        int result_days;
        int result_months;
        int result_years;
        
        String temp_month;
        String temp_day;
        String temp_year;
        
        String message;
        
    public void init() {      
        temp_month=JOptionPane.showInputDialog("Month");
        temp_day=JOptionPane.showInputDialog("Day");
        temp_year=JOptionPane.showInputDialog("Year");
        

        input_month=Integer.parseInt(temp_month);
        input_day=Integer.parseInt(temp_day);
        input_year=Integer.parseInt(temp_year);
                
        
        sdf = new SimpleDateFormat("MM dd yyyy");
        temp=sdf.format(date); 
     
        temp_day=temp.substring(3,5); 
        temp_month=temp.substring(0,2); 
        temp_year=temp.substring(6,10);
        
        current_day=Integer.parseInt(temp_day);
        current_month=Integer.parseInt(temp_month);
        current_year=Integer.parseInt(temp_year);
    
        if(current_day < input_day){
         current_day+=30;
         current_month-=1;         
     }         
     if(current_month<input_month){
         current_month+=12;
         current_year-=1;
     }    
     result_days=current_day-input_day;
     result_months=current_month-input_month;
     result_years=current_year-input_year;  

      message="Difference is: "+result_years+"years, "+result_months+"months and "+result_days+"days.";  
      
    }
    public void paint(Graphics g) {
        super.paint(g);    
        g.drawString(message, 25, 25);
  }
}
