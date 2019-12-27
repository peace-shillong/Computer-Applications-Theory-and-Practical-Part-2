#!/usr/bin/perl
#Program for leap year
print "Enter a year:: \t";
$num=<STDIN>;
chomp($num);
if($num%4==0)
{
        print "$num is a leap year\n";
}
        else
{
        print "$num is not a leap year\n";
}

