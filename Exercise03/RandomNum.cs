namespace Exercise03;

public class RandomNum
{
    public void GuessNum()
    {
        Console.WriteLine("Make a guess from 1-3, and I will tell you guess low, high, or get the correct answer\n ");
        int correctNumber = new Random().Next(3) + 1;
        int guessedNumber;
        if (!int.TryParse(Console.ReadLine(), out guessedNumber))
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
            return;
        }
        switch (guessedNumber)
        {
            case 1:
                if (guessedNumber == correctNumber)
                {
                    Console.WriteLine($"You guessed correctly! The correctNumber is {correctNumber}.");
                }
                else if (guessedNumber < correctNumber)
                {
                    Console.WriteLine($"You guessed low.The correctNumber is {correctNumber}.");
                }
                else
                {
                    Console.WriteLine($"You guessed high.The correctNumber is {correctNumber}.");
                }
                break;
            case 2:
                if (guessedNumber == correctNumber)
                {
                    Console.WriteLine($"You guessed correctly!The correctNumber is {correctNumber}.");
                }
                else if (guessedNumber < correctNumber)
                {
                    Console.WriteLine($"You guessed low.The correctNumber is {correctNumber}.");
                }
                else
                {
                    Console.WriteLine($"You guessed high.The correctNumber is {correctNumber}.");
                }
                break;
            case 3:
                if (guessedNumber == correctNumber)
                {
                    Console.WriteLine($"You guessed correctly!The correctNumber is {correctNumber}.");
                }
                else if (guessedNumber < correctNumber)
                {
                    Console.WriteLine($"You guessed low.The correctNumber is {correctNumber}.");
                }
                else
                {
                    Console.WriteLine($"You guessed high.The correctNumber is {correctNumber}.");
                }
                break;
            default:
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                break;
        }
    }
    
}