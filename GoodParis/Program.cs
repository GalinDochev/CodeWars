public static class Solution
{
    public static int NumIdenticalPairs(int[] nums)
    {
        int goodPairs = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    goodPairs++;
                }
            }
        }

        return goodPairs;
    }

    public static int NumIdenticalPairsSecondSolution(int[]  nums)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
            }
            else
            {
                map.Add(nums[i], 1);
            }
        }

        

        return map.Where(kvp=>kvp.Value>1).Sum(kvp=>kvp.Value);
    }
}

public  class Program()
{
    public static void Main()
    {
        Console.WriteLine(Solution.NumIdenticalPairsSecondSolution(new int [] { 1, 2, 3, 1, 1, 3 }));
    }
}