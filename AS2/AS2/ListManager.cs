namespace AS2;

public class ListManager
{
    public void Program()
    {
        List<string> items = new List<string>();

        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");

            string input = Console.ReadLine();

            if (input.StartsWith("+"))
            {
                string item = input.Substring(1).Trim();
                items.Add(item);
            }
            else if (input.StartsWith("-"))
            {
                string item = input.Substring(1).Trim();
                items.Remove(item);
            }
            else if (input == "--")
            {
                items.Clear();
            }
            else
            {
                Console.WriteLine("Invalid command");
            }

            Console.WriteLine("Current items:");
            foreach (string item in items)
            {
                Console.WriteLine("- " + item);
            }
        }
    }
}