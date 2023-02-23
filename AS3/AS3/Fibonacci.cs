namespace AS3;

public class Fibonacci
{
    public int Fib(int n)
    {
        if (n == 1 || n ==2)
        {
            return 1;
        }
        else
        {
            return Fib(n - 1) + Fib(n - 2);
        }
    }

    public void printTenNum()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{Fib(i)}\t");
        }
    }
}