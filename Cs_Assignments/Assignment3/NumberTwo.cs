namespace Assignment3;

public static class NumberTwo
{
    public static int Fibonacci(int seq)
    {
        if (seq == 0) return 0;
        if(seq == 1) return 1;
        if (seq == 2) return 1;
        return Fibonacci(seq-2) + Fibonacci(seq-1);
    }
    
    public static void PrintFibonacci(int seq)
    {
        Console.WriteLine($"Fibonacci for sequence {seq}: {Fibonacci(seq)}");
    }
}
