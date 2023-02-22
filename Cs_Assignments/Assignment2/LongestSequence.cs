namespace Assignment2;

public class LongestSequence
{
    public void longestSequence()
    {
        Console.WriteLine("Enter your Array To Calculate Longest Equal Sequence: ");
        string[] strarr = (Console.ReadLine()).Split(" ");
        int[] intarr = Array.ConvertAll(strarr, s => int.Parse(s));
        int maxcount = 1;
        int count = 1;
        int maxint = intarr[0];
        for (int i = 1; i < intarr.Length; i++)
        {

            if (intarr[i-1] == intarr[i] )
            {
                count++;
                if (count > maxcount)
                {
                    maxcount = count;
                    maxint = intarr[i];
                }
                
            }
            else
            {
                count = 1;
                if (count > maxcount)
                {
                    maxcount = count;
                    maxint = intarr[i];
                }
            }
        }

        //Console.WriteLine($"Max Count: {maxcount}");
        //Console.WriteLine($"Max Int: {maxint}");

        Console.WriteLine("Longest Equal Sequence: ");

        for(int c = 0; c < maxcount; c++)
        {
            Console.Write($"{maxint} ");
        }
        Console.WriteLine();


        
    }
}