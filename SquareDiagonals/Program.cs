//Given a square matrix, calculate the absolute difference between the sums of its diagonals.

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int rightDiagonalSum = 0, leftDiagonalSum = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            rightDiagonalSum += arr[i][i];
            leftDiagonalSum += arr[i][arr.Count-1-i];
        }
        return Math.Abs(rightDiagonalSum-leftDiagonalSum);
    }

}

public class  Program
{
    public static void Main()
    {
        var matrix = new List<List<int>>
        {
            new List<int> { 11, 2, 4 },
            new List<int> { 4, 5, 6 },
            new List<int> { 10, 8, -12 }
        };
        int result = Result.diagonalDifference(matrix);
        Console.WriteLine(result);
    }
}