var current = new Date(); //TODO: instead of today's date, get the real date
var day = current.getDay();
var substract = 1;
if (day == 0) // today is sunday
{
	substract = 2;
}
else if (day == 1) // today is monday
{
	substract = 3;
}

current.setDate(current.getDate() - substract);
