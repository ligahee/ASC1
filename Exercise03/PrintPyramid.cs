namespace Exercise03;

public class PrintPyramid
{
    public void Pyramid()
    {
        int size = 5; // pyramid size
        
        // outer loop to iterate over each row of the pyramid
        for (int i = 1; i <= size; i++)
        {
            // inner loop to print the spaces before the stars
            for (int j = 1; j <= size - i; j++)
            {
                Console.Write(" ");
            }

            // inner loop to print the stars
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            // move to next line
            Console.WriteLine();
        }
    }
}