namespace AS2;
public class Program
{
    static void Main(String[] args)
    {
        Console.Write("1.CopyArray\n 2.ListManager\n 3.FindPrimesInRange\n " +
                      "4.Rotation and Add\n 5.Longest sequence of equal\n 6.Most frequent number\n" +
                      "7.ReverseString\n 8.ReverseWord\n 9.Palindromes\n  10.Website\n Enter a number of question: \n");
        int ques = int.Parse(Console.ReadLine());
        if (ques == 1)
        {
            Console.Write("Enter start Num for Prime\n ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end Num for Prime\n ");
            int end = int.Parse(Console.ReadLine());
            FindPrimesInRange q3 = new FindPrimesInRange();
            q3.FindInRange(start, end);
        } else if (ques == 4)
        {
            RotateAdd q3 = new RotateAdd();
            q3.RotateNum();
        }else if (ques == 5)
        {
            LongestSequence q5 = new LongestSequence();
            q5.LQ();
        }else if (ques == 6)
        {
            MostFreq q6 = new MostFreq();
            q6.MF();
        }else if (ques == 7)
        {
            ReverseString q7 = new ReverseString();
            q7.Reverse();
        }else if (ques == 8)
        {
            ReverseWord q8 = new ReverseWord();
            q8.RW();
        } else if (ques == 8)
        {
            ReverseWord q8 = new ReverseWord();
            q8.RW();
        }else if (ques == 9)
        {
            Palindromes q9 = new Palindromes();
            q9.dup();
        }else
        {
            Console.WriteLine("Invalid question number.\n ");
        }
        

    }
}