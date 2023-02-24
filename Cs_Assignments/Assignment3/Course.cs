using Assignment3;
using Assignment3.Interfaces;

public class Course: ICourseService
{
    public string CourseName;
    public List<Student> StudentList;

    public Course(string name, List<Student> Students)
    {
        CourseName = name;
        StudentList = Students;
    }
    public void ListEnrollment()
    {
        Console.WriteLine("Students in " + CourseName + ":");
        foreach(Student stu in StudentList)
        {
            Console.WriteLine(stu.Name);
        }
    }
    public void EnrollStudent(Student student) 
    {
        StudentList.Add(student);
    }
}