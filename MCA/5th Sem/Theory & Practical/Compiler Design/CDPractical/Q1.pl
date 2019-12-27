#!/usr/bin/perl

print "\n ********** PROGRAM TO CHECK FOR PALINDROME ********** \n";
do 
{
	print "\n Enter the string : ";
	$str = <STDIN>;
	chomp($str);
	$lenstr = length($str);

	for($i=$lenstr;$i>=0;$i--)
	{
		$palindrome = $palindrome.substr($str,$i,1);
	}
	
	print "\n The generated string is : $palindrome \n";

	if($str eq $palindrome)
	{
		print "\n The string is a Palindrome \n\n";	
	}
	else
	{
		print "\n The string in NOT a Palindrome \n\n";
	}
	
		
	$palindrome="";	
	print "\n Do u still want to continue? [Y/N]: ";
	chomp($ch = <STDIN>);
	
	if($ch eq 'N' or $ch eq 'n')
	{
		exit();
	}
	
}while($ch ne 'Y' or $ch ne 'y');
