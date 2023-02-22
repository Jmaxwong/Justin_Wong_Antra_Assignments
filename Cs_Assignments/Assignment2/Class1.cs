namespace Assignment2;

public class AllPalindromes
{
    public void allPalindromes()
    {
        string input = "Hi, exe? ABBA! Hog fully a string: ExE.Bob";

        char[] del = { ' ', ',', '.', '!', '?', ':'};
        string[] splt = input.Split(del, StringSplitOptions.RemoveEmptyEntries);

        //foreach (string s in splt)
        //{
        //    if (checkPal(s))
        //    {
        //        Console.Write($"{s}, ");
        //    }
        //}
        for (int i = 0; i < splt.Length; i++)
        {
            if (i == splt.Length - 1)
            {
                Console.Write($"{splt[i]}");
            }
            else
            {
                if (checkPal(splt[i]))
                {
                    Console.Write($"{splt[i]}, ");
                }
            }
        }
    }

    public bool checkPal(string input)
    {
        int l = 0;
        int r = input.Length-1;

        while (l < r)
        {
            if (input[l] != input[r])
            {
                return false;
            }
            else
            {
                l++;
                r--;
            }
        }
        return true;
    }

}