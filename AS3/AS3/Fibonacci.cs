namespace AS3;

public class Fibonacci
{
    public int Fib(int n)
    {
        if (n < 0)
            throw new Exception("Please input valid number");
        int result = 0;
        int f0 = 0;
        int f1 = 1;
        if (n == 1)
            return 1;
        while (n > 1)
        {
            result = f0 + f1;
            f0 = f1;
            f1 = result;
            n--;
        }

        return result;
    }

    public void printTenNum()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{Fib(i)}\t");
        }
    }
}