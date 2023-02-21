namespace Assignment1;

public class Count24
{
    public void count24()
    {
        for (int mult = 1; mult <= 4; mult++)
        {
            for(int step = 0; step*mult <= 24; step++)
            {
                Console.Write($"{step*mult} ");
            }
            Console.WriteLine();
        }
    }
}