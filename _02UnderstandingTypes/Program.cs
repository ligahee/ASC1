namespace _02UnderstandingTypes;

public class Program
{
    static void Main(String[] args)
    {
        Console.Write("Enter a number of question: 1/2\n");
        int ques = int.Parse(Console.ReadLine());
        if (ques == 1)
        {
            NumofBytes q1 = new NumofBytes();
            q1.question_1();
        } else if (ques == 2)
        {
            CovertTime q2 = new CovertTime();
            q2.CovertCentury();
        }
        else
        {
            Console.Write("Please enter a valid Number for questions");
        }

    }
}