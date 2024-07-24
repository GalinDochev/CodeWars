//Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.
//Print the decimal value of each fraction on a new line with  places after the decimal.

//Note: This challenge introduces precision problems.
//The test cases are scaled to six decimal places, though answers with absolute error of up to  are acceptable.

class Result
{
    public static void plusMinus(List<int> arr)
    {
        int positiveNumberCount = 0;
        int negativeNumberCount = 0;
        int zeroNumCount = 0;
        foreach (var num in arr)
        {
            if (num > 0)
            {
                positiveNumberCount++;
            }
            else if (num < 0)
            {
                negativeNumberCount++;
            }
            else 
            {
                zeroNumCount++; 
            }
        }
        Console.WriteLine((positiveNumberCount / (double)arr.Count).ToString("F6"));
        Console.WriteLine((negativeNumberCount / (double)arr.Count).ToString("F6"));
        Console.WriteLine((zeroNumCount / (double)arr.Count).ToString("F6"));
    }

}

public class Program
{
    public static void Main()
    {
        Result.plusMinus([-4, 3, -9, 0, 4, 1]);
    }
}