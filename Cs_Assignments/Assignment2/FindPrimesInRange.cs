using System.Globalization;
using System.Text;

namespace Assignment2;

public class FindPrimesInRange
{
    public static int[] findPrimesInRange(int startNum, int endNum)
    {
        List<int> ls = new List<int>();
        
        if (startNum > endNum) 
        {
            return new int[] { };
        }

        //int num;

        for( int i = startNum; i <= endNum; i++)
        {
            int factors = 0;
            for (int j = 2; j <= i/2; j++)
            {
                if(i % j == 0)
                {
                    factors++;
                    break;
                }
            }

            if (i != 1 && factors == 0)
            {
                ls.Add(i);
            }
        }

        return ls.ToArray();
    }
}