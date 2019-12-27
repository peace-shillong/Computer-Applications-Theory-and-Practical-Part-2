#Simple program for pattern matching

#!/usr/local/bin/perl

print ("\n  Enter the filename :");
open(IN,<STDIN>) || die "cannot open : $!";

print ("\n Enter the word you would like to search :");
chomp($word = <STDIN>);

A: while (<IN>) 
{      
	if ($_ =~ /$word/) 
	{
		print ("\n Word found");
		last A;	    
	}
	
		
}
 
close(IN);
print ("\n\n");



#here, the if statement is checking each line for the pattern. 
#if true (found), the =~ operator returns a non zero positive value










