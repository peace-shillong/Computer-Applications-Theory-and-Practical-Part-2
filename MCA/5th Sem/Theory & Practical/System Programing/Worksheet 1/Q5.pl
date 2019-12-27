#!/bin/perl

#Enter Value
print "Enter A Sentence: ";

$text=<STDIN>;

chomp($text);
$single=q[$text];
$double=qq["$text"];
$backq=qx($text);
$countw=qw($text);

print "Single $single \n";
print "Double $double \n";
print "Backquote $backq \n";
print "Word $countw \n";



