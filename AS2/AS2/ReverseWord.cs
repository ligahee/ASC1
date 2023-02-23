using System.Text;

namespace AS2;

public class ReverseWord
{
    public void RW()
    {
        Console.Write("Enter a string: ");
        string sentence = Console.ReadLine();
        string[] parts = sentence.Split(new char[] {' ', ',', '.', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(parts);
        string[] separators = sentence.Split(parts, StringSplitOptions.RemoveEmptyEntries);
        string[] output = new string[parts.Length + separators.Length];
        for (int i = 0, j = 0; i < output.Length; i += 2, j++)
        {
            output[i] = parts[j];
            if (j < separators.Length)
            {
                output[i + 1] = separators[j];
            }
        }
        Console.WriteLine(string.Concat(output));
    }

    
}