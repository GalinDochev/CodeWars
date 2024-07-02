
public class Kata
{
    public static bool Narcissistic(int number)
    {
        if (number==0)
        {
            return true;
        }
        int copyOfNumber = number;
        char [] charArray = number.ToString().ToCharArray();
        int digitCount = 0;
        double sumResult = 0;
        while (number != 0) 
        {
            number/=10;
            digitCount++;
        }
        foreach (var num in charArray)
        {
            int intValue = num - '0';
            double upperValue = Math.Pow(intValue,digitCount);
            sumResult += upperValue;
        }
        if (sumResult==copyOfNumber)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class Program
{
    static void Main ()
    {
        Console.WriteLine(Kata.Narcissistic(0)); ///True;
        Console.WriteLine(Kata.Narcissistic(153)); ///True;
        Console.WriteLine(Kata.Narcissistic(1652)); ///False;
    }
}