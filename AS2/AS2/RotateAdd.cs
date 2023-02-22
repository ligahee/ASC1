namespace AS2;

public class RotateAdd
{
    public void RotateNum() {
        Console.Write("Read the input array\n ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        Console.Write("Read the rotation count\n ");
        int k = int.Parse(Console.ReadLine());
        
        // Calculate the sum for each rotation and output the result
        int n = arr.Length;
        int[] sum = new int[n];
        for (int r = 1; r <= k; r++) {
            // Rotate the array
            int[] rotated = new int[n];
            for (int i = 0; i < n; i++) {
                rotated[(i + r) % n] = arr[i];
            }
            
            // Update the sum
            for (int i = 0; i < n; i++) {
                sum[i] += rotated[i];
            }
            // Update the input array for the next rotation
            arr = rotated;
        }
        // Output the sum array
        Console.WriteLine(string.Join(" ", sum));
    }
}