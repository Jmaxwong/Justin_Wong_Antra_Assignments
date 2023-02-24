namespace Assignment3;

public static class NumberOne
{
    public static int[] Reverse(int[] arr)
    {

        int[] res = new int[arr.Length];
        for (int i = 0; i <arr.Length; i++)
        {
            res[i] = arr[arr.Length-1-i];
        }
        return res;
    }
    public static int[] GenerateNumbers()
    {
        int[] r = new int[] {1,2,3,4,5,6,7,8,9,10};
        return r;
    }
    public static void PrintNumbers()
    {
        int[] arr = GenerateNumbers();
        int[] reversedarr = Reverse(arr);

        Console.WriteLine("Generated Array: ");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Reversed Array: ");
        foreach (int i in reversedarr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

