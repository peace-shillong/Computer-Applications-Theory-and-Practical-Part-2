{Calculate sum}
read x;{input an integer}
if x>0 then {don't compute if x <= 0}
	sum := 0;
	do
		sum :=sum + x;
		x := x-1;
	while x > 0;
	write sum; {output sum}
end
