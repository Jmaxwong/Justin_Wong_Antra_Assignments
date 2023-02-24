
namespace Assignment4;

public class MyList <T>
{
    public T[] LS;
    public int Size;
    public int Cap;

    public MyList(int cap = 10)
    {
        Cap = cap;
        LS= new T[cap];
        Size= 0;
    }
    public void AddSpace()
    {
        T[] newLS = new T[Cap];
        for (int i = 0;i < LS.Length; i++)
        {
            newLS[i] = LS[i];
        }
        Cap = Cap + 10;
    }

    public void Add(T element)
    {

        if(Size == Cap)
        {
            AddSpace();
        }
        LS[Size] = element;
        Size++;

    }
    public T Remove(int index)
    {
        T res = LS[index];
        for (int i = index; i <= Size - 2; i++)
        {
            LS[i] = LS[i + 1];
        }

        LS[Size - 1] = default(T);
        Size--;
        return res;
    }
    public bool Contains(T element)
    {
        for(int i = 0 ; i < Size ; i++) { 
            if(element.Equals(LS[i]))//== operator does not work on Generic values
            {
                return true;
            }
        }
        return false;
    }
    public void Clear()
    {
        Cap = 10;
        LS = new T[Cap];
        Size = 0;
    }
    public void InsertAt(T element, int index)
    {
        if (Size == Cap)
        {
            AddSpace();
        }
        if(index >= Size)
        {
            throw new Exception("Index Out of Bounds.");
        }

        for (int i = Size; i > index; i--)
        {
            LS[i] = LS[i - 1];
        }
        LS[index] = element;
        Size++;

    }
    public void DeleteAt(int index)
    {
        for(int i = index; i <= Size-2; i++)
        {
            LS[i] = LS[i + 1];
        }

        LS[Size - 1] = default(T);
        Size--;
    }
    public T Find(int index)
    {
        if(index < 0 || index > Size)
        {
            throw new Exception("Out of Range");
        }
        return LS[index];
    }



}
