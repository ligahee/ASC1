namespace Exercise03;

public class FizzBuzz
{
    public void PlayGame()
    {   
        Console.Write("It's FizzBuzz Game!\n");
        int max = 100;
        for (int i = 1; i <= max; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("fizzbuzz ");
            }
            else if (i % 3 == 0)
            {
                Console.Write("fizz ");
            }
            else if (i % 5 == 0)
            {
                Console.Write("buzz ");
            }
            else
            {
                Console.Write($"{i} ");
            }
        }
    }
}