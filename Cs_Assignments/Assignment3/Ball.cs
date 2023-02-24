namespace Assignment3;

public class Ball
{
    public Color color { get; set; }
    public int size { get; set; }
    private int timesthrown;

    public Ball(Color color, int size)
    {
        this.color= color;
        this.size = size;
        timesthrown = 0;
    }

    public void Pop()
    {
        size = 0;
        Console.WriteLine("The ball popped!");
    }
    public void Throw()
    {
        if (size == 0)
        {
            Console.WriteLine("Ball has been popped, cannot throw.");
        }
        else
        {
            timesthrown++;
            Console.WriteLine("Ball has been thrown");
        }
    }
    public int GetTimesThrown()
    {
        return timesthrown;
    }



}
