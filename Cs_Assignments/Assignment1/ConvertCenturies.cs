using System;
namespace Assignment1;

public class ConvertCenturies
{
	public void convertCenturies(uint centuries)
	{
		uint years = centuries * 100;
		uint months = years * 12;
		uint days = months * 31;
		uint hours = days * 24;
		uint minutes = hours * 60;
		uint seconds = minutes * 60;
		ulong milliseconds = seconds * 1000;
		ulong microseconds = milliseconds * 100;
		ulong nanoseconds = microseconds * 100;

		string str = $"{centuries} centuries = {years} years ={months} months = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds";
        Console.WriteLine(str);
		return;
    }
}
