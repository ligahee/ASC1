using System.Text;

namespace AS2;

public class Website
{
    public void Covert()
    {
        Console.Write("Enter a string: ");
        string inputUrl = Console.ReadLine();
        // Parse the URL and extract its parts
        string protocol = "", server = "", resource = "";
        StringBuilder sb = new StringBuilder(inputUrl);
        int serverStartIndex = sb.ToString().IndexOf("://");
        if (serverStartIndex > 0) {
            protocol = sb.ToString(0, serverStartIndex);
            sb.Remove(0, serverStartIndex + 3);
        }
        int resourceStartIndex = sb.ToString().IndexOf("/");
        if (resourceStartIndex >= 0) {
            server = sb.ToString(0, resourceStartIndex);
            resource = sb.ToString(resourceStartIndex + 1, sb.Length - resourceStartIndex - 1);
        } else {
            server = sb.ToString();
        }

        // Print the extracted URL parts
        Console.WriteLine("[protocol] = \"" + protocol + "\"");
        Console.WriteLine("[server] = \"" + server + "\"");
        Console.WriteLine("[resource] = \"" + resource + "\"");
    }
}