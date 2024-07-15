public static class Solution
{
    public static int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0) return 0;
        var charSet = new HashSet<char>();
        int left = 0, right = 0, maxLength = 0;
        while (right < s.Length)
        {
            if (!charSet.Contains(s[right]))
            {
                charSet.Add(s[right]);
                right++;
                maxLength = Math.Max(maxLength, charSet.Count);
            }
            else
            {
                charSet.Remove(s[left]);
                left++;
            }
        }
        return maxLength;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Solution.LengthOfLongestSubstring("abcabcbb"));
    }
}