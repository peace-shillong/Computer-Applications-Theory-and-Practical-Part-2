import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class RadioPanel extends JPanel 
{
       
	final JTextField no1 = new JTextField(10);
	public RadioPanel()
	{
        Dimension size = getPreferredSize();
        size.width = 150;
        setPreferredSize(size);
        
        setBorder(BorderFactory.createTitledBorder("Radio Buttons"));
        
        final JTextField no1 = new JTextField(10);

	JRadioButton b1 = new JRadioButton("Correct");
	

	JRadioButton b2 = new JRadioButton("Wrong");
	
        setLayout(new GridBagLayout());
        
        GridBagConstraints gbc = new GridBagConstraints();

        gbc.weightx = 0.5;
       	gbc.weighty = 0.5;

	gbc.gridx = 0;
        gbc.gridy = 0;
        add(b1, gbc);

	gbc.gridx = 0;
        gbc.gridy = 1;
        add(b2, gbc);


	}
     
	
        
    
}