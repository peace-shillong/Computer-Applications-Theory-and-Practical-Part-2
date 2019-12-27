#Armstrong Number
print "Enter the number::\t";
$n=<STDIN>;
chomp($n);
$num=$n;
$arm=0;
while($num>0)
{
	$rem=$num%10;
	$arm=$arm+$rem*$rem*$rem;
	$num=$num/10;
}
if($n==$arm)
{
	print "$arm is an Armstrong Number";
}
else
{
	print "$arm is not an Armstrong Number";
}
