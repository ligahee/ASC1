namespace AS2;

public class ReverseString
{
    public void Reverse()
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();
        // Convert the string to char array, reverse it and convert it back to string
        char[] charArray = inputString.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
        Console.WriteLine("Reversed String: " + reversedString);
    }
}