//Leap year calculator

void calculateLeapYear (int year)
{
    Console.WriteLine(year % 400 == 0 ? "EOC Leap year" : year % 4 == 0 ? year + " LEAP YEAR" : year + " STANDARD YEAR");
};

calculateLeapYear(1990);