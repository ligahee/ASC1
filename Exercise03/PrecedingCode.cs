namespace Exercise03;

public class PrecedingCode
{
    public void CorretedCode()
    {
        int max = 500;
        for (byte i = 0; i < max; i++)
        {
            Console.WriteLine(i);
            if (i == byte.MaxValue) break;
        }
    }
}