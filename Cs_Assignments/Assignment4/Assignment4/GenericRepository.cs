using System.Security.Cryptography.X509Certificates;

namespace Assignment4;

public class GenericRepository: IRepository<Student>
{
    private List<Student> students = new List<Student>();

    public void Add(Student item)
    {
        foreach(var student in students)
        {
            if (item.Id == student.Id)
            {
                throw new Exception("No duplicate ID's allowed.");
            }
        }
        students.Add(item);
        
    }

    public IEnumerable<Student> GetAll()
    {
        return students;
    }

    public Student GetById(int id)
    {
        foreach(Student student in students)
        {
            if(student.Id == id) return student;
        }

        throw new Exception("No Student by that ID");
    }

    public void Remove(Student item)
    {
        foreach(Student student in students)
        {
            if (DeepEquals(item, student))
            {
                students.Remove(student);
                return;
            }
        }
        throw new Exception("No Such Element Exists");
    }

    public bool DeepEquals(Student item1, Student item2)
    {
        return (item1.Name == item2.Name && item1.Id == item2.Id);
    }

    public void Save()
    {
        throw new NotImplementedException();
    }
}
