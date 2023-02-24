using Assignment4;
using System.Security.Cryptography;

//1.
MyStack<string> strstack = new MyStack<string>();
strstack.Push("Hello");
strstack.Push("Hi");
strstack.Push("Greetings");

string popped = strstack.Pop();
Console.WriteLine("Popped Element: " + popped);
Console.WriteLine("Stack Count: " + strstack.Count());

//2.
MyList<int> ls = new MyList<int>();
ls.Add(1);
ls.Add(2);
ls.Add(3);
ls.InsertAt(2, 0);
Console.WriteLine(ls.Find(0));
Console.WriteLine(ls.Find(1));

Console.WriteLine(ls.Contains(5));
Console.WriteLine(ls.Contains(1));

Console.WriteLine(ls.Remove(0));
Console.WriteLine(ls.Size);

ls.Clear();
Console.WriteLine(ls.Size);

//3.
GenericRepository gr = new GenericRepository();
gr.Add(new Student(1, "Jared"));
gr.Add(new Student(2, "David"));
gr.Add(new Student(3, "Danielle"));

Console.WriteLine("All Students before a Deletion");
foreach (var x in gr.GetAll())
{
    Console.WriteLine(x.Name);
}


gr.Remove(new Student(1, "Jared"));
Console.WriteLine("All Students after a Deletion");
foreach (var x in gr.GetAll())
{
    Console.WriteLine(x.Name);
}

