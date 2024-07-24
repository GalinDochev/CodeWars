
class Result
{

    /*
     * Complete the 'findMedian' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int findMedian(List<int> arr)
    {
        arr.Sort();
        return arr[arr.Count/2];
    }

}

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Result.findMedian(new List<int> { 0,1,2,4,6,5,3 }));
    }
}