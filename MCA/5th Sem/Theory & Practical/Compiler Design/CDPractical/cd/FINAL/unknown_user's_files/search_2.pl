print("Enter item into array \t [-1 to stop]\n");
while(($i=<STDIN>)!=-1)
{
	chomp($i);
	push (@a, $i);
}

print"ARRAY:: @a\n\n";
print"Enter item to be searched\n";
$n=<STDIN>;
chomp($n);
for($j=0; $j<=$#a; $j++)
{
	if($n == @a[$j])
	{
		$found=1;
		print"Item is found\n";
	}
}

if($found==0)
{
	print ("Item doesnot found\n");
}
