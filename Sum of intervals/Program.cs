using System;
using System.Collections;
using Interval = System.ValueTuple<int, int>;
public class Intervals
{
    public static int SumIntervals((int, int)[] intervals)
    {
        if (intervals == null || intervals.Length == 0)
        {
            return 0; // Return 0 if intervals array is empty or null
        }

        // Sort intervals by the first element and then by the second
        var sorted = intervals.OrderBy(interval => interval.Item1)
                              .ThenBy(interval => interval.Item2)
                              .ToArray();

        if (sorted.Length == 0)
        {
            return 0; // Return 0 if sorted array is empty after sorting
        }
        int totalSum = 0;
        int currentStart = sorted[0].Item1;
        int currentEnd = sorted[0].Item2;
       
        if (intervals.Count()>0)
        {
        foreach (var interval in sorted)
        {
            if (interval.Item1 <= currentEnd) // Overlapping or contiguous intervals
            {
                currentEnd = Math.Max(currentEnd, interval.Item2); // Merge intervals
            }
            else
            {
                totalSum += currentEnd - currentStart; // Sum the non-overlapping interval
                currentStart = interval.Item1;
                currentEnd = interval.Item2;
            }
        }
        totalSum += currentEnd - currentStart;
        }

        // Add the last interval

        return totalSum;
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Intervals.SumIntervals(new Interval[] { (1,4), (7,10), (3, 5) }));
    }
}