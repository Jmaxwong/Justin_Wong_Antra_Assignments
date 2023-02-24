namespace Assignment3;
public class Department: IDepartmentService
{
    public Instructor DepartmentHead;
    public string DepartmentName;
    public decimal Budget;
    public List<Course> Courses= new List<Course>();

    public Department(Instructor departmenthead, string name, decimal budget)
    {
        DepartmentHead = departmenthead;
        DepartmentName = name;
        Budget = budget;
    }
    public void AddCourse(Course c)
    {
        Courses.Add(c);
    }

    public void ListCourses()
    {
        Console.WriteLine("All courses in department " + DepartmentName + ": ");
        foreach (Course c in Courses)
        {
            Console.WriteLine(c.CourseName);
        }
    }
}