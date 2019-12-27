#!/usr/bin/perl
print"Enter a file nhame:\t";
chomp($a=<STDIN>);
open(IN,"$a");
print"Enter the word\n";
chomp($w=<STDIN>);

open(OUT,">b.txt");

while($file=<IN>)
{
	if(!($file=~ m/$w/))
	{
		print OUT $file;
	}
}
unlink $a;
rename "b.txt", $a;
unlink "b.txt";

