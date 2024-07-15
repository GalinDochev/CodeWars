//You are given an n x n integer matrix grid.

//Generate an integer matrix maxLocal of size (n - 2) x (n - 2) such that:

//maxLocal[i][j] is equal to the largest value of the 3 x 3 matrix in grid centered around row i + 1 and column j + 1.
//In other words, we want to find the largest value in every contiguous 3 x 3 matrix in grid.

//Return the generated matrix.

using System.Security.Principal;

public static class Solution
{
    public static int[][] LargestLocal(int[][] grid)
    {
         
        int newRows = grid.Length - 2;
        int newCols = grid[0].Length - 2;

        int[][] maxLocal = new int[newRows][];
        for (int i = 0; i < newRows; i++)
        {
            maxLocal[i] = new int[newCols];
        }

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid.Length; j++)
            {
                List<int> currentNumbers = new();
                if (j + 2 < grid[0].Length && i + 2 < grid[0].Length)
                {
                    currentNumbers.Add(grid[i][j]);
                    currentNumbers.Add(grid[i][j + 1]);
                    currentNumbers.Add(grid[i][j + 2]);
                    currentNumbers.Add(grid[i + 1][j]);
                    currentNumbers.Add(grid[i + 1][j + 1]);
                    currentNumbers.Add(grid[i + 1][j + 2]);
                    currentNumbers.Add(grid[i + 2][j]);
                    currentNumbers.Add(grid[i + 2][j + 1]);
                    currentNumbers.Add(grid[i + 2][j + 2]);
                    maxLocal[i][j] = currentNumbers.Max();
                }
               
            }
            
        }
        return maxLocal;
    }
}

public class Program
{

    public static void Main()
    {
        int[][] grid = Solution.LargestLocal(new int[][] { [1, 1, 1, 1, 1], [1, 1, 1, 1, 1], [1, 1, 2, 1, 1], [1, 1, 1, 1, 1], [1, 1, 1, 1, 1] });
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid.Length; j++)
            {
                Console.Write(grid[i][j]);
            }
            Console.WriteLine();
        }
    }
}

