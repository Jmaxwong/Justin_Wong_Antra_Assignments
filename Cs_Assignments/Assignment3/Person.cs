
using Assignment3.Interfaces;

namespace Assignment3;


public abstract class Person : IPersonService
{
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }

    public List<string> Addresses { get; set; }

    public Person(string name, int age, decimal salary, List<string> addresses) 
    {
        Name = name;
        Age = age;
        if (salary < 0.0m) Salary = 0;
        else Salary = salary;
        Addresses = addresses;
    }
    public void AddAddress(string address)
    {
        Console.WriteLine("Added Address to " + Name + ".");
        Addresses.Add(address);
    }

    public int CalculateAge()
    {
        return Age;
    }

    public decimal CalculateSalary()
    {
        return Salary;
    }

    public List<string> GetAddresses()
    {
        return Addresses;
    }
}
