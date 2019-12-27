import java.awt.*;  
import java.applet.*;  
public class AnimationExample extends Applet {  
  
  Image p1; 
  public void init() 
  {  
    p1 =getImage(getDocumentBase(),"b2.jpg"); 
	
  }  
    
  public void paint(Graphics g) 
  {  
   
			 
			for(int i=500;i>0;i--)
			{
				if(i>60)
				{
				g.drawImage(p1,i+1,i,this);
				try
				{
				
						Thread.sleep(20);
				}
				catch(Exception e){} 
				}
			}		
  }  
}  