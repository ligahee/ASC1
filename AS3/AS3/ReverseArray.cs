namespace AS3;

public class ReverseArray
{
    public void ReverseArr()
    {
        Console.WriteLine("Input the length of array:");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = GenerateNumbers(length);
        Reverse(numbers);
        Console.WriteLine("The reversed array:");
        PrintNumbers(numbers);
    }

    private static int[] GenerateNumbers(int length)
    {
        int[] arr = new int[length];
        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            arr[i] = random.Next(1, 101);
        }

        return arr;
    }

    private static void Reverse(int[] number)
    {
        int n = number.Length;
        for (int left = 0, right = n-1; left < right; left++,right--)
        {
            int temp = number[left];
            number[left] = number[right];
            number[right] = temp;
        }
    }

    private static void PrintNumbers(int[] number)
    {
        foreach (int num in number)
        {
            Console.Write($"{num},");
        }
    }
}