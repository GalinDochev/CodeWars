using System;

public class Number
{
    public static int DigitalRoot(long n)
    {
        string numbers = n.ToString();
        while (numbers.Length > 1)
        {
            long accumulatedNumber = 0;
            foreach (var number in numbers)
            {
                accumulatedNumber += number - '0'; ;
            }
            if (accumulatedNumber >=10)
            {
                numbers=accumulatedNumber.ToString();
                continue;
            }
            else
            {
                numbers = accumulatedNumber.ToString();
                return int.Parse(numbers);
            }
            
        }
        return int.Parse(numbers);
    }
}

public class Program
{
    static void Main ()
    {
        Console.WriteLine(Number.DigitalRoot(493193));
    }
}