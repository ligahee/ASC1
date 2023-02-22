namespace AS2;

public class CopyArray
{
    public void CopyArr()
    {
        int[] originalArray = {2, 4, 7, 9, 5, 6, 7, 8, 9, 10};
        int[] newArray = new int[originalArray.Length];

        for (int i = 0; i < originalArray.Length; i++)
        {
            newArray[i] = originalArray[i];
        }

        // print out both arrays
        Console.WriteLine("Original array: ");
        foreach (int element in originalArray)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        Console.WriteLine("New array: ");
        foreach (int element in newArray)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

    }
}