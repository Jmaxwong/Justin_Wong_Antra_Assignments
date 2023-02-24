namespace Assignment3;

public class Student: Person, IStudentInterface
{
    public List<(string, char)> CourseList;
    public Student(List<(string, char)> courselist, string name, int age, decimal salary, List<string> addresses) : base(name, age, salary, addresses)
    {
        CourseList= courselist;
    }

    public void AttendClass()
    {
        Console.WriteLine("Student is Taking Class");
    }

    public decimal CalculateGPA()
    {
        string course;
        char grade;
        decimal res = 0m;
        foreach (var com in CourseList)
        {
            (course, grade) = com;
            switch (grade)
            {
                case 'A':
                    {
                        res = res + 4.0m;
                        break;
                    }
                case 'B':
                    {
                        res = res + 3.0m;
                        break;
                    }
                case 'C':
                    {
                        res = res + 2.0m;
                        break;
                    }
                case 'D':
                    {
                        res = res + 1.0m;
                        break;
                    }
                case 'F':
                    {
                        res = res + 0.0m;
                        break;
                    }
                default:
                    {
                        break;
                    }
                    
            }
        }
        return res/Convert.ToDecimal(CourseList.Count());
    }

}
