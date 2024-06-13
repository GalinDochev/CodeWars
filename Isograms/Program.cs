using System;

public class Kata
{
    /// <summary>
    /// Determines whether the given string is an isogram.
    /// An isogram is a word or phrase without a repeating letter.
    /// </summary>
    /// <param name="str">The input string to check.</param>
    /// <returns>True if the input string is an isogram, otherwise false.</returns>
    public static bool IsIsogram(string str)
    {
        List<char> word = new List<char>();
        foreach (var character in str.ToLower())
        {
            if (word.Contains(character))
            {
                return false;
            }
            else
            {
                word.Add(character);
            }
        }
        return true;
    }
    public static bool IsIsogramWithHash(string str)
    {
        HashSet<char> uniqueChars = new HashSet<char>();

        // Convert the input string to lowercase to make the check case-insensitive
        str = str.ToLower();

        // Iterate through each character in the string
        foreach (var character in str)
        {
            // If the character is already in the set, it's not an isogram
            if (uniqueChars.Contains(character))
            {
                return false;
            }
            else
            {
                // Add the character to the set
                uniqueChars.Add(character);
            }
        }

        // If no repeating characters were found, it's an isogram
        return true;
    }

    public static bool IsIsogramDistinct(string str)
    {
        // Convert the input string to lowercase to make the check case-insensitive
        str = str.ToLower();

        // Check if str with only unique characters is as long as str
        return str.Distinct().Count() == str.Length;
    }
}



class Program
{
    static void Main()
    {
        Console.WriteLine(Kata.IsIsogram("Dermatoglyphics")); // True
        Console.WriteLine(Kata.IsIsogram("aba"));             // False
        Console.WriteLine(Kata.IsIsogram("moOse"));           // False
        Console.WriteLine(Kata.IsIsogram("isogram"));         // True
        Console.WriteLine(Kata.IsIsogram("Snimka"));          // True
    }
}