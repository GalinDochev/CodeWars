public static class Kata
{
    public static bool CheckIfPalindrome(string word)
    {
        return word.ToLower().SequenceEqual(word.ToLower().Reverse());

    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(Kata.CheckIfPalindrome("madam"));
    }
}