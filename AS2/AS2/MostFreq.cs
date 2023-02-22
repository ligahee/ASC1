namespace AS2;

public class MostFreq
{
    public void MF()
    {
        Console.Write("Read the input array\n ");
        int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        List<int> same = new List<int>();
        int n = arr.Length;
        int maxcount = 0;
        int element_having_max_freq = 0;
        Dictionary<int, int> map = new Dictionary<int, int>();
        Dictionary<int, int> loc = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            
            if (!map.ContainsKey(arr[i]))
            {
                map.Add(arr[i],1);
                loc.Add(arr[i], i);
            }
            else
            {
                int count = map[arr[i]];
                count++;
                map[arr[i]] = count;
            }

            
        }

        foreach(var ele in map.OrderByDescending(key=>key.Value))
        {
            int count = ele.Value;
            int element = ele.Key;
            int idx = loc[element];
            if (count > maxcount) {
                maxcount = count;
                element_having_max_freq = element;
                same.Add(element);
            } else if (count == maxcount &&　maxcount > 0)
            {
                same.Add(element);
            }
            else
            {
                break;
            }
        }

        if (same.Count == 1)
        {
            Console.WriteLine($"The number {element_having_max_freq} is the most frequent (occurs {maxcount} times)");
        }
        else
        {
            Console.Write("The numbers");
            foreach (int element in same)
            {
                Console.Write(element + " ");
            }
            Console.Write($"have the same maximal frequence (each occurs {maxcount} times). The leftmost of them is {element_having_max_freq}.");
        }
        
    }
}