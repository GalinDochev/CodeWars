//You are given a 0-indexed integer array nums of even length consisting of an equal number of positive and negative integers.

//You should return the array of nums such that the the array follows the given conditions:

//Every consecutive pair of integers have opposite signs.
//For all integers with the same sign, the order in which they were present in nums is preserved.
//The rearranged array begins with a positive integer.
//Return the modified array after rearranging the elements to satisfy the aforementioned conditions.

public class Solution
{
    public static int[] RearrangeArray(int[] nums)
    {

        int n = nums.Length;
        int[] result = new int[n];
        int posIndex = 0, negIndex = 1;

        for (int i = 0; i < n; i++)
        {
            if (nums[i] > 0)
            {
                result[posIndex] = nums[i];
                posIndex += 2;
            }
            else
            {
                result[negIndex] = nums[i];
                negIndex += 2;
            }
        }

        return result;
    }
}

public class Program
{
    public static void Main()
    {
        Solution.RearrangeArray([3, 1, -2, -5, 2, -4]);
    }
}