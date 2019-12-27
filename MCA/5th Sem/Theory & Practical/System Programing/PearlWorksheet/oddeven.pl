#!/usr/bin/perl
#Program for Odd or Even number
print "Enter a number:: \t";
$num=<STDIN>;
chomp($num);
if($num%2==0)
{
	print "Even Number\n";
}
else
{
	print "Odd Number\n";
}
