#!/bin/perl

#Enter Value
print "Enter A Number: ";

$no=<STDIN>;

chomp($no);
print "Enter The Second Number: ";

$no2=<STDIN>;

chomp($no2);

$sum=$no+$no2;
$diff=$no-$no2;
$mul=$no*$no2;
$div=$no/$no2;

print "Sum is $sum \n";
print "Difference is $diff \n";
print "Multiplication is $mul \n";
print "Quotient is $div \n";

