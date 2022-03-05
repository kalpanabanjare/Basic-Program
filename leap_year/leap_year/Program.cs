
Console.WriteLine("Enter Year :"); // to take input from user
int Year = int.Parse(Console.ReadLine()); // to pass the input and dubble check

//method 1
//if(((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) // to check the comdition
//{
//    Console.WriteLine("{0} is a leap Year", Year);
//}
//else
//{
//    Console.WriteLine("{0} is not a leap Year", Year);
//}

// method 2
if(DateTime.IsLeapYear(Year))
{
    Console.WriteLine("This is a leap year");
}
else
{
    Console.WriteLine("This is not a leap year");
}