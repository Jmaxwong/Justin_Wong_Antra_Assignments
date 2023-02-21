namespace Assignment1;
public class DaysOld
{
    public DateTime current_date;
    DateTime birthdate;
    public void daysOld(int month, int day, int year)
    {
        birthdate = new DateTime(year,month,day);
        current_date = DateTime.Now;
        TimeSpan date_diff = current_date.Subtract(birthdate);
        Console.WriteLine($"Total Days Since Birthday: {Math.Round(date_diff.TotalDays)}");
    }
}