using Assignment3.Interfaces;

namespace Assignment3;

public class Instructor: Person, IInstructorService
{
    string DepartmentName { get; set; }
    public DateTime JoinDate { get; set; }

    public Instructor(string departmentname, DateTime joindate, string name,int age, decimal salary, List<string> addresses) : base(name, age, salary, addresses)
    {
        DepartmentName = departmentname;
        JoinDate= joindate;
    }

    //public void Teach()
    //{
    //    Console.WriteLine("Instructor is teaching a class.");
    //}
    //public void TakeAttendance()
    //{
    //    Console.WriteLine("Instructor is taking Attendance for the class.");
    //}

    public int CalculateYearsOfExperience()
    {
        TimeSpan datediff = DateTime.Now.Subtract(JoinDate);
        int years = datediff.Days / 365;
        return years;
    }
}
