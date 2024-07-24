//Check if a string is a pangram or not
public class Result
{
    public static string pangrams(string s)
    {
        List<char> alphabet = new List<char>();

        for (char c = 'a'; c <= 'z'; c++)
        {
            alphabet.Add(c);
        }

        bool containsAll = alphabet.All(ch=> s.ToLower().Contains(ch));
        if (containsAll==true)
        {
            return "pangram";
        }
        else
        {
            return "not pangram";
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Result.pangrams("We promptly judged antique ivory buckles for the next prize"));
    }
}

