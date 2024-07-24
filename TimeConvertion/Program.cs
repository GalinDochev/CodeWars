//Given a time in -hour AM/PM format, convert it to military (24-hour) time.

//Note: -12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
//- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

class Result
{


    public static string timeConversion(string s)
    {
        TimeSpan time = DateTime.Parse(s).TimeOfDay;
        string times = $"{time.Hours:D2}:{time.Minutes:D2}:{time.Seconds:D2}";
        return times;
    }

}

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Result.timeConversion("07:05:05PM"));
    }
}