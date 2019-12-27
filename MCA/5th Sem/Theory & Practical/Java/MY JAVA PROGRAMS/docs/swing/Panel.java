import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Panel extends JPanel 
{
       
	public Panel()
	{
        Dimension size = getPreferredSize();
        size.width = 250;
        setPreferredSize(size);
        
        setBorder(BorderFactory.createTitledBorder("Addition of two numbers"));
        
        JLabel no1Label = new JLabel("Enter 1st number: ");
        JLabel no2Label = new JLabel("Enter 2nd number: ");
        JLabel resultLabel = new JLabel("Sum: ");
        final JTextField no1 = new JTextField(10);
        final JTextField no2 = new JTextField(10);
        final JTextField result = new JTextField(10);
        JButton addBtn = new JButton("Add");
        
        setLayout(new GridBagLayout());
        
        GridBagConstraints gbc = new GridBagConstraints();

        gbc.weightx = 0.5;
        gbc.weighty = 0.5;
        
        gbc.gridx = 0;
        gbc.gridy = 0;
        add(no1Label, gbc);
        
        gbc.gridx = 0;
        gbc.gridy = 1;
        add(no2Label, gbc);
 
        gbc.gridx = 0;
        gbc.gridy = 2;
        add(resultLabel, gbc);
        
	gbc.gridx = 1;
        gbc.gridy = 0;
        add(no1, gbc);
        
        gbc.gridx = 1;
        gbc.gridy = 1;
        add(no2, gbc);

        gbc.gridx = 1;
        gbc.gridy = 2;
        add(result, gbc);

 	gbc.weighty = 10; 

        gbc.gridx = 1;
        gbc.gridy = 3;
        add(addBtn, gbc);
     
	addBtn.addActionListener(new ActionListener() 
	{

		@Override
		public void actionPerformed(ActionEvent e) 
		{
			
			result.setText(String.valueOf(Integer.parseInt(no1.getText())+Integer.parseInt(no2.getText())));
		}
	});
        
    }
}