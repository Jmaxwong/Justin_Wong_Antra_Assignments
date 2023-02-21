namespace Assignment1;

public class FizzBuzz
{
    public void fizzBuzz()
    {
        for(int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0) 
            {
                Console.Write("/FizzBuzz/ ");
            }
            else
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();
    }
}