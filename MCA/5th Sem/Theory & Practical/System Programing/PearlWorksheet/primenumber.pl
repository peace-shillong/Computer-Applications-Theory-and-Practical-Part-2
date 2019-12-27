#!/usr/bin/perl
print "Enter the number::\t";
$num=<STDIN>;
chomp($num);
$n=2;
$c=0;
while($n>($num-1))
{
	if($num%$n==0)
	{
		$c=1;
		break;
	}
	$n++;
}
if($c==1)
{
	print "$num is not a Prime number";
}
else
{
	print "$num is a prime number";
}		
