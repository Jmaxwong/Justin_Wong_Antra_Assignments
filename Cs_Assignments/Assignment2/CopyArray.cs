namespace Assignment2;

public class CopyArray
{
    public int[] copyArray(int[] arr)
    {
        int[] copy = new int[arr.Length];
        for (int i = 0 ; i < arr.Length; i++) 
        {
            copy[i] = arr[i];
        }
        return copy;
    }
}