namespace _02UnderstandingTypes;

public class CovertTime
{   public void CovertCentury()
    {
        const int CENTURY_IN_YEARS = 100;
        const int YEAR_IN_DAYS = 365;
        const int DAY_IN_HOURS = 24;
        const int HOUR_IN_MINUTES = 60;
        const int MINUTE_IN_SECONDS = 60;
        const long SECOND_IN_MILLISECONDS = 1000;
        const long MILLISECOND_IN_MICROSECONDS = 1000;
        const long MICROSECOND_IN_NANOSECONDS = 1000;

        Console.Write("Enter a number of centuries: ");
        int centuries = int.Parse(Console.ReadLine());

        long years = (long)centuries * CENTURY_IN_YEARS;
        long days = years * YEAR_IN_DAYS;
        long hours = days * DAY_IN_HOURS;
        long minutes = hours * HOUR_IN_MINUTES;
        long seconds = minutes * MINUTE_IN_SECONDS;
        long milliseconds = seconds * SECOND_IN_MILLISECONDS;
        long microseconds = milliseconds * MILLISECOND_IN_MICROSECONDS;
        long nanoseconds = microseconds * MICROSECOND_IN_NANOSECONDS;

        Console.WriteLine("{0} centuries = {1} years", centuries, years);
        Console.WriteLine("{0} centuries = {1} days", centuries, days);
        Console.WriteLine("{0} centuries = {1} hours", centuries, hours);
        Console.WriteLine("{0} centuries = {1} minutes", centuries, minutes);
        Console.WriteLine("{0} centuries = {1} seconds", centuries, seconds);
        Console.WriteLine("{0} centuries = {1} milliseconds", centuries, milliseconds);
        Console.WriteLine("{0} centuries = {1} microseconds", centuries, microseconds);
        Console.WriteLine("{0} centuries = {1} nanoseconds", centuries, nanoseconds);
        Console.ReadKey();
    }
}