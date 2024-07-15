//You are given an integer array nums. A number x is lonely when it appears only once, and no adjacent numbers (i.e. x + 1 and x - 1) appear in the array.

//Return all lonely numbers in nums. You may return the answer in any order.

public class Solution {
    public IList<int> FindLonely(int[] nums) {

        Dictionary<int, int> numberCount = new Dictionary<int, int>();
        HashSet<int> adjacentNumbers = new HashSet<int>();
        List<int> finalNumbers = new List<int>();

        foreach (int num in nums)
        {
            if (numberCount.ContainsKey(num))
            {
                numberCount[num]++;
            }
            else
            {
                numberCount[num] = 1;
            }
        }

        foreach (int num in nums)
        {
            if (numberCount.ContainsKey(num + 1)|| numberCount.ContainsKey(num - 1))
            {
                adjacentNumbers.Add(num);
            }
        }

        foreach (int num in nums)
        {
            if (numberCount[num] == 1 && !adjacentNumbers.Contains(num))
            {
                finalNumbers.Add(num);
            }
        }

        return finalNumbers;
    }
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        var list= solution.FindLonely([10, 6, 5, 8]);
        foreach (var item in list)
        {
            Console.Write(item);
        }
    }
}