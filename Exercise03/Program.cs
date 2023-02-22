namespace Exercise03;

public class Program
{
    static void Main(String[] args)
    {
        Console.Write("Enter a number of question: \n 1.FizzBuzz\n 2.preceding code\n 3.Make a guess between 1-3\n 4.PrintPyramid\n  5.GuessNum\n 6.ToNextAnniversary\n 7.Time ofDay\n 8.TwentyFour.\n ");
        int ques = int.Parse(Console.ReadLine());
        if (ques == 1)
        {
            FizzBuzz q1 = new FizzBuzz();
            q1.PlayGame();
        } else if (ques == 2)
        {
            PrecedingCode q2 = new PrecedingCode();
            q2.CorretedCode();
        } else if (ques == 3)
        {
            RandomNum q3 = new RandomNum();
            q3.GuessNum();
        } else if (ques == 4)
        {
            PrintPyramid q4 = new PrintPyramid();
            q4.Pyramid();
        } else if (ques == 5)
        {
            GuessNum q5 = new GuessNum();
            q5.Guess();
        } else if (ques == 6)
        {
            Console.Write("Enter year: \n");
            int year = int.Parse(Console.ReadLine());
            
            Console.Write("Enter month: \n ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter day: \n ");
            int day = int.Parse(Console.ReadLine());
            
            ToNextAnniversary q6 = new ToNextAnniversary();
            q6.BirthdayCalculator(year, month, day);
        } else if (ques == 7)
        {
            TimeofDay q7 = new TimeofDay();
            q7.Greet();
        } else if (ques == 8)
        {
            TwentyFour q8 = new TwentyFour();
            q8.Add();
        }else
        {
            Console.WriteLine("Invalid question number.\n ");
        }
        

    }
}