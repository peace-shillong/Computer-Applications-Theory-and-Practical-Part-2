#!/user/bin/perl
print "Enter the 1st number::";
$a=<STDIN>;
chomp($a);
print "Enter the 2nd number::";
$b=<STDIN>;
chomp($b);
print "Enter the 3rd number::";
$c=<STDIN>;
chomp($c);
if($a>$b && $a>$c)
{
	print "\n\t$a is greater than $b and $c";
}
elsif($b>$a && $b>$c)
{
	print "\n\t$b is greater than $a and $c";
}
else
{
        print "\n\t$c is greater than $a and $b";
}
if($a<$b && $a<$c)
{
        print "\n\t$a is smaller than $b and $c";
}
if($b<$a && $b<$c)
{
        print "\n\t$b is smaller than $a and $c";
}
if($c<$b && $c<$b)
{
        print "\n\t$c is smaller than $a and $b";
}



