using System.Dynamic;

namespace Assignment4;

public class MyStack<T>
{
    List<T> Stack = new List<T>();

    public MyStack()
    {
        Stack = new List<T>();
    }
    public int Count()
    {
        return Stack.Count;
    }
    public T Pop()
    {
        if (Stack.Count == 0)
        {
            throw new Exception("Empty Stack");
        }
        T res = Stack.Last();
        Stack.RemoveAt(Stack.Count - 1);
        return res;
    }
    public void Push(T item)
    {
        Stack.Add(item);
    }
}
