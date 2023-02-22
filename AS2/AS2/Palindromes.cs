namespace AS2;

public class Palindromes
{
    public void dup()
    {
        Console.Write("Enter a string: ");
        string inputText = Console.ReadLine();

        // Extract all palindromes from the input text
        List<string> palindromes = new List<string>();
        string[] words = inputText.Split(new char[] { ' ', ',', '.', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words) {
            string reversedWord = new string(word.Reverse().ToArray());
            if (word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase)) {
                palindromes.Add(word);
            }
        }

        // Remove duplicates and sort the palindromes
        palindromes = palindromes.Distinct().OrderBy(p => p).ToList();

        // Print the palindromes
        Console.WriteLine(string.Join(", ", palindromes));
    }
}