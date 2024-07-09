using System.Collections.Generic;

public static class Result
{

    /*
     * Complete the 'cavityMap' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static List<string> CavityMap(List<string> grid)
    {
        int rows = grid.Count;
        int cols = grid[0].Length;
        
        char[,] array = new char[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = grid[i][j];
            }
        }

        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int g = 0; g < array.GetLength(1); g++)
            {
                if (k-1<0 || k+1==grid.Count||g-1<0||g+1==grid.Count)
                {
                    continue;
                }
                int currentNumber = array[k, g]-'0';
                int numberLeft = array[k - 1, g] - '0';
                int numberRight = array[k + 1, g] - '0';
                int numberTop = array[k, g - 1] - '0';
                int numberBot = array[k, g + 1] - '0';
               
                List<int> numbers = new List<int> { numberBot, numberTop, numberLeft, numberRight };
                if (currentNumber>numbers.Max())
                {
                    int gridPosition = k + g;
                    array[k, g] = 'X';
                }

            }
        }
        List<string> result = new List<string>();
        for (int i = 0; i < rows; i++)
        {
            char[] row = new char[cols];
            for (int j = 0; j < cols; j++)
            {
                row[j] = array[i, j];
            }
            result.Add(new string(row));
        }

        return result;
    }

}

public static class Program
{
    public static void Main ()
    {
        Console.WriteLine(Result.CavityMap(new List<string>{"1112", "1912", "1892", "1234"}));
    }
}