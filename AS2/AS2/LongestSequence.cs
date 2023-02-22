namespace AS2;

public class LongestSequence
{
    public void LQ()
    {
        Console.Write("Read the input array\n ");
        int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int start = 0, len = 1, maxStart = 0, maxLen = 1;
        for (int i = 1; i < array.Length; i++) {
            if (array[i] == array[i-1]) {
                len++;
                if (len > maxLen) {
                    maxStart = start;
                    maxLen = len;
                }
            } else {
                start = i;
                len = 1;
            }
        }
        int[] longest = new int[maxLen];
        Array.Copy(array, maxStart, longest, 0, maxLen);
        Console.WriteLine(string.Join(" ", longest));
    }
}