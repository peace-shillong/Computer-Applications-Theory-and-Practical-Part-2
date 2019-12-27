#!/usr/bin/perl
%hash=(1=>2,3=>"k");
foreach $k(keys %hash)
{
	print"value of $k is $hash{$k}\n";
}
