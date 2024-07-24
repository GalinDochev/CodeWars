
//Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.
//Then print the respective minimum and maximum values as a single line of two space-separated long integers.

using System.Numerics;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void MiniMaxSum(List<int> arr)
    {
        var bigIntArr = arr.Select(x => new BigInteger(x)).ToList();
        BigInteger minNumbers = bigIntArr.OrderBy(x => x).Take(4).Aggregate(BigInteger.Zero, (acc, x) => acc + x);

        BigInteger maxNumbers = bigIntArr.OrderByDescending(x => x).Take(4).Aggregate(BigInteger.Zero, (acc, x) => acc + x);

        Console.Write(minNumbers);
        Console.Write(" ");
        Console.Write(maxNumbers);
    }

}

public class Program
{
    public static void Main()
    {
        Result.MiniMaxSum(new List<int> { 256741038,623958417,467905213,714532089,938071625 } );
    }
}