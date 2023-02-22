namespace Exercise03;

public class TimeofDay
{
    public void Greet()
    {
        DateTime now = DateTime.Now;
        if (now.Hour >= 6 && now.Hour < 12)
        {
            Console.WriteLine("Good Morning");
        }
        else if (now.Hour >= 12 && now.Hour < 18)
        {
            Console.WriteLine("Good Afternoon");
        }
        else if (now.Hour >= 18 && now.Hour < 21)
        {
            Console.WriteLine("Good Evening");
        }
        else
        {
            Console.WriteLine("Good Night, Sweetie ^^");
        }
    }
}