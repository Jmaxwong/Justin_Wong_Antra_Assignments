namespace Assignment1;

public class GuessingGame
{
   public void guessingGame()
    {
        Random rand = new Random();

        Console.WriteLine("Guess the number between 1-3 : ");
        int guessed_number = int.Parse(Console.ReadLine());
        int rand_number = rand.Next(1, 4);
        if (guessed_number == rand_number)
        {
            Console.WriteLine($"You Guessed Wrong! The Number Was {rand_number}");
        }
        else if(guessed_number > 3 || guessed_number < 1)
        {
            Console.WriteLine("Input Out Of Bounds");
        }
        else
        {
            Console.WriteLine("You Guessed Right!");
        }

    }
}