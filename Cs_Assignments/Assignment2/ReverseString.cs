public class ReverseString
{
    public void reverseString()
    {
        Console.WriteLine("Input String to Reverse: ");
        string input = Console.ReadLine();

        char[] charsinput = input.ToCharArray();
        Array.Reverse(charsinput);

        Console.Write("Way 1: ");
        Console.WriteLine(charsinput);

        Console.Write("Way 2: ");
        for(int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
        Console.WriteLine();
    }
}