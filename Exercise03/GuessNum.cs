namespace Exercise03;

public class GuessNum
{
    public void Guess()
    {
        int correctNumber = new Random().Next(3) + 1;
        Console.WriteLine("Guess the number between 1 and 3:");
        int guessedNumber = int.Parse(Console.ReadLine());
        if (guessedNumber < 1 || guessedNumber > 3) {
            Console.WriteLine("Invalid guess. The number must be between 1 and 3.");
        } else if (guessedNumber < correctNumber) {
            Console.WriteLine("Your guess is too low.");
        } else if (guessedNumber > correctNumber) {
            Console.WriteLine("Your guess is too high.");
        } else {
            Console.WriteLine("Your guess is correct!");
        }
        
    }
}