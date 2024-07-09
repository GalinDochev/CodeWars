public static class Result
{
    //Given a 6x6 2D Array
    //An hourglass is a subset of values with indices falling in a pattern 3x1x3
    //There are 16 hourglasses in the 6x6 array.
    //An hourglass sum is the sum of an hourglass' values.
    //Calculate the hourglass sum for every hourglass in , then print the maximum hourglass sum. The array will always be 6x6.

    public static int hourglassSum(List<List<int>> arr)
    {
        int sum = int.MinValue;
        for (int i = 0; i < arr.Count - 2; i++)
        {
            for (int j = 0; j < arr.Count - 2; j++)
            {
                int currentSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                if (sum < currentSum)
                {
                    sum = currentSum;
                }

            }
        }
        return sum;
    }
}


public static class Program
{
    public static void Main()
    {
        List<List<int>> matrix = new List<List<int>>
{
   new List<int> {-9, -9, -9,  1, 1, 1},
            new List<int> { 0, -9,  0,  4, 3, 2},
            new List<int> {-9, -9, -9,  1, 2, 3},
            new List<int> { 0,  0,  8,  6, 6, 0},
            new List<int> { 0,  0,  0, -2, 0, 0},
            new List<int> { 0,  0,  1,  2, 4, 0}
};
        Console.WriteLine(Result.hourglassSum(matrix));
    }
}