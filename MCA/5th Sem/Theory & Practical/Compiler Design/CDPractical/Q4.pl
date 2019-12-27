#!/usr/bin/perl

 print "\n ********** PROGRAM TO DELETE AND MODIFY ELEMENTS ********** \n";

	print "\n\t\t MENU \n";
	print "\n\t\t1. DELETE X ELEMENTS \n\t\t2. MODIFY Y ELEMENTS \n\t\t3. EXIT \n";
	print "\n\t\t Please enter your choice : ";
	chomp($ch = <STDIN>);

	SWITCH:
	
		if($ch==1)
		{
			print "\n\t\t Enter the size of the array :";
			$size = <STDIN>;
	
			@array[$size];

			print "\n\t\t Enter the elements : \n";

			for($i=0;$i<$size;$i++)
			{
				print "\t\t\t\t";
				$array[$i] = <STDIN>;
			}

			print "\n\t\t The array contain the following elements :";	

			foreach $i(@array)
			{
				print "\n\t\t\t\t $i";
			}
			print "\n\t\t Enter the total number of elements to delete :";
			$total = <STDIN>;
		
				splice @array,0,$total;	
		
			print "\n\t\t The remaining elements :\n";
			foreach $i(@array)	
			{
				print "\n\t\t\t\t $i";
			}

			if($total==$size)
			{
				print "\n\t\t\t\t No More elements left \n";
			}
			last SWITCH;
		}
		elsif($ch==2)
		{
			
			print "\n\t\t Enter the size of the array :";
			$size = <STDIN>;
	
			@array[$size];

			print "\n\t\t Enter the elements : \n";

			for($i=0;$i<$size;$i++)
			{
				print "\t\t\t\t";
				$array[$i] = <STDIN>;
			}

			print "\n\t\t The array contain the following elements :";	

			foreach $i(@array)
			{
				print "\n\t\t\t\t $i";
			}
			print "\n\t\t Enter the total number of elements to modify :";
			$total = <STDIN>;
			
			print "\n\t\t Enter the elements you want to replace with : \n";
			for($i=1;$i<=$total;$i++)
			{
				print "\t\t\t\t";

				$ele[$i] = <STDIN>;
			}

			 splice @array,0,$total,@ele;	

			print "\n\t\t The modified array :";
			foreach $i(@array)	
			{
				print "\n\t\t\t\t $i";
			}
			
			last SWITCH;
		}
		elsif($ch==3)
		{
			exit();
			last SWITCH;
		}
		DEFAULT:
		{
			print "\n Wrong Choice !!! \n";
			last SWITCH;
		}

