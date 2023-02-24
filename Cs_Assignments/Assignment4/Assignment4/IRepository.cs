namespace Assignment4;

public interface IRepository<T> where T: class
{
    public void Add(T item);
    public void Remove(T item);
    public void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);
}
