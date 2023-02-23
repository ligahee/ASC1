namespace AS2;

public class Palindromes
{
    public void dup()
    {
        Console.Write("Enter a string: ");
        string inputText = Console.ReadLine();

        // Extract all palindromes from the input text
        HashSet<string> palindromes = new HashSet<string>();
        string[] words = inputText.Split(new char[] { ' ', ',', '.', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words) {
            if (isPalindromes(word)) {
                palindromes.Add(word);
            }
        }
        var orderedpalindromes = palindromes.OrderBy(x => x);
        // Print the palindromes
        Console.WriteLine(string.Join(", ", orderedpalindromes));
    }
    
    private static bool isPalindromes(String word)
    {
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
        if (word.Equals(reversedString))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}