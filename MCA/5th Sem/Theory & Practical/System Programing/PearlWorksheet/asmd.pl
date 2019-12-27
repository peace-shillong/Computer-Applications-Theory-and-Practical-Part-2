#!/usr/bin/perl
#Program for Addition,Subtraction,Multiplication,Division
print "Enter a number:: \t";
$a=<STDIN>;
chomp($a);
print "Enter b number:: \t";
$b=<STDIN>;
chomp($b);
print "Enter the Arithmatic Operation [+|-|*|/]::";
$st=<STDIN>;
chomp($st);
SWITCH:
{
	if($st eq "+")
	{
		$result=$a+$b;
		print "$a+$b=$result";
	}
	if($st eq "-")
	{
		$result=$a-$b;
		print "$a-$b=$result";
	}
	 if($st eq "*")
        {
                $result=$a*$b;
                print "$a*$b=$result";
        }
	 if($st eq "/")
        {
                $result=$a/$b;
                print "$a/$b=$result";
        }

	DEFAULT:
	{
		exit;
	}
}


