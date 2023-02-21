public class TimeGreeting
{
    TimeSpan morning = new TimeSpan(5, 0, 0);
    TimeSpan afternoon = new TimeSpan(12, 0, 0);    
    TimeSpan evening = new TimeSpan(18, 0, 0);
    TimeSpan night = new TimeSpan(21, 0, 0);
    public void timeGreeting()
    {
        TimeSpan current_time = DateTime.Now.TimeOfDay;
        Console.WriteLine($"Current Time: {current_time}");

        if(morning <= current_time && current_time < afternoon) //morning
        {
            Console.WriteLine("Good Morning!");
        }
        else if (afternoon <= current_time && current_time < evening) //afternoon
        {
            Console.WriteLine("Good Afternoon!");
        }
        else if (evening <= current_time && current_time < night) //evening
        {
            Console.WriteLine("Good Evening!");
        }
        else //if (night <= current_time && current_time < morning) //night
        {
            Console.WriteLine("Good Night!");
        }
    }
}