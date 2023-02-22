namespace Exercise03;

public class TwentyFour
{
    public void Add()
    {
        for (int i = 1; i < 5; i++)
        {
            for (int j = 0; j <= 24; j += i)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}