namespace Assignment3;

public class Color
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }
    public int Alpha { get; set; }

    public Color()
    {
        Red = 0;
        Green = 0;
        Blue = 0;
        Alpha = 0;
    }

    public Color(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = 255;

    }
    public Color(int red, int green, int blue, int alpha)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = 255;
    }
    public double GetGrayscale()
    {
        return (Red + Green + Blue)/3;
    }

}
