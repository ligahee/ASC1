namespace AS2;

public class FindPrimesInRange
{
    public void FindInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();

        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }

        foreach (int element in primes)
        {
            Console.Write(element + " ");
        }
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

}