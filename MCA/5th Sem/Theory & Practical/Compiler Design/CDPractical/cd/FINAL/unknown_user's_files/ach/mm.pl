   #!/usr/bin/perl
   print("How many lines do you want to enter");
   $num=<STDIN>;
  #chomp($num);

for($i=0;$i<$num;$i++)
{
 print("Line $i:Enter the string");
 $str=<STDIN>;
#chomp($str);
 $org[$i]=$str;
#print("\n");
}
print("Enter the line number to print");
$num1=<STDIN>;
chomp($num1);

for($i=0;$i<=$num;$i++)
{
 if($num1==$i)
  {
   print("The string in $i:$org[$i]");
  }

}

