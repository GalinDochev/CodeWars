using System;
using System.Linq;

public static class Kata
{
    public static string PigIt(string str)
    {
        string[] splitString = str.Split(new Char[] { ' ' });
        List<string> sentence = new List<string>();
        foreach (var strg in splitString)
        {
            if (strg.Length > 1)
            {
                string newWord = string.Empty;
                newWord += strg.Substring(1) + strg.Substring(0, 1) + "ay";
                sentence.Add(newWord);
            }
            else
            {
                sentence.Add(strg);
            }
        }
        return String.Join(" ", sentence);
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.PigIt("Hello world !"));
    }
}