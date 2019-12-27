#!/usr/bin/perl

print "Enter radius: ";
$r=<STDIN>;
chomp($r);

$d=$r*$r;
$c=2*3.14*$r*$r;
print "Diameter is $d \nCircumference is $c \n";

