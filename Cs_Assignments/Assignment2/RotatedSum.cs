namespace Assignment2;
public class RotatedSum
{
    public int[] rotatedSum()
    {
        Console.Write("Enter your Array To Find Rotated Sum: ");
        string[] strarr = (Console.ReadLine()).Split(" ");

        int[] intarr = Array.ConvertAll(strarr, s => int.Parse(s));

        Console.Write("How many times to Rotate (K): ");
        int k = int.Parse(Console.ReadLine());
        int n = intarr.Length;
        int[] sums = new int[n];
        
        Console.WriteLine("Rotated Sums: ");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= k; j++)
            {
                sums[i] = sums[i] + intarr[(i + j)%n];
            }
        }
        return sums;

    }
}