namespace AS2;

public class ReverseWord
{
    public void RW()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        // Split the text into words
        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

        // Find all palindromes in the words
        var palindromes = words.Where(w => w.SequenceEqual(w.Reverse())).Distinct();

        // Print the palindromes on a single line, separated by comma and space
        Console.WriteLine(string.Join(", ", palindromes));
    }
}