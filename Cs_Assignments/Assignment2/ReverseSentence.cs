namespace Assignment2;
public class ReverseSentence
{
    public void reverseSentence()
    {
        Console.Write("Enter your Sentence To Reverse: ");
        char[] delimiter = { ' ', ',', '.', ':',  '=', '(', ')', '&', '[', ']', '"' , '\\', '/', '!', '?' };
        string[] strarr = (Console.ReadLine()).Split(delimiter);
        Array.Reverse(strarr);
        Console.Write("Reversed Sentence: ");
        foreach (string str in strarr)
        {
            Console.Write($"{str} ");
        }
        Console.WriteLine();
    }
}
