class Bicycle
{
	double gear,speed;
	char brand;
	Bicycle()
	{
		gear=0;
		speed=0;
		brand="";
	}
	//set
	void setgear(double x)
	{
		gear=x;
	}
	void setspeed(double y)
	{
		speed=y;
	}
	void setbrand(char z)
	{
		brand=z;
	}
	//get
	double getgear()
	{
		return gear;
	}
	double getspeed()
	{
		return speed;
	}
	char getbrand()
	{
		return brand;
	}
	
	double speed(double x)
	{
		return speed+x;
	}
	