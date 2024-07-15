//You are given an integer array nums. In one operation, you can add or subtract 1 from any element of nums.

//Return the minimum number of operations to make all elements of nums divisible by 3.

public static class Solution
{
    public static int MinimumOperations(int[] nums)
    {
        int operations = 0;
        foreach (var number in nums)
        {
            if (number%3!=0)
            {
                operations++;
            }
            else
            {
                continue;
            }

        }
        return operations;
    }
}


public  class Program
{
    public  static void Main()
    {
        Console.WriteLine(Solution.MinimumOperations(new int[] { 3, 6, 9 }));
    }
}