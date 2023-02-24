// See https://aka.ms/new-console-template for more information

using Assignment3;

////1
//NumberOne.PrintNumbers();

////2
//for (int i = 1;i <= 10; i++)
//NumberTwo.PrintFibonacci(i);


////1-6
List<string> add1= new List<string>();
add1.Add("2 Cornwall Lane");
add1.Add("1 Mountaintop Drive");
Instructor ins1 = new Instructor("Art", new DateTime(2015, 12, 10), "Bob Odenkirk", 27, 1000, add1);
Console.WriteLine(ins1.Name + "'s Years of Experience: " + ins1.CalculateYearsOfExperience());

List<string> add2= new List<string>();
add2.Add("19 Rivertown Road");

List<(string,char)> coursegradelist1 = new List<(string,char)>();
coursegradelist1.Add(("Intro to Surrealism", 'A'));
coursegradelist1.Add(("Music History", 'C'));
coursegradelist1.Add(("Poetry History", 'B'));


Student s1 = new Student(coursegradelist1, "Bennet Leblanc", 19, 0m, add2);
Console.WriteLine("GPA of " + s1.Name + ": " + s1.CalculateGPA());

List<(string, char)> coursegradelist2 = new List<(string, char)>();
coursegradelist2.Add(("Intro to Surrealism", 'B'));
Student s2 = new Student(coursegradelist2, "Rene Leblanc", 20, 0m, add2);


Course c1 = new Course("Poetry History", new List<Student> {s1,s2});
c1.ListEnrollment();
Course c2 = new Course("Intro to Surrealism", new List<Student> {s2});


Department d1 = new Department(ins1, "Art", 90000m);
d1.AddCourse(c1);
d1.AddCourse(c2);
d1.ListCourses();


//7
Color col = new Color(125,125,125);
col.Alpha = 15;
Console.WriteLine("Alpha Number: " + col.Alpha);
Console.WriteLine("Greyscale: " + col.GetGrayscale());

Ball ball = new Ball(col, 10);
Console.WriteLine(ball.GetTimesThrown());
ball.Throw();
ball.Throw();
Console.WriteLine("The Ball has been thrown " + ball.GetTimesThrown() + " times.");
ball.Pop();
ball.Throw();

