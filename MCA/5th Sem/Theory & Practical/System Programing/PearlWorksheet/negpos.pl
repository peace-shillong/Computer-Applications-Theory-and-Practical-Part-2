#!/usr/bin/perl
#Program for Negative or Positive number
print "Enter a number:: \t";
$num=<STDIN>;
chomp($num);
if($num>0)
{
        print "Positive number\n";
        }
elsif($num<0)
{
                print "Negative Number\n";
}  
