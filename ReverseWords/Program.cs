using System;

public static class Kata
{
    public static string ReverseWords(string str)
    {
        //Splitting the sentence into words
        string[] split=str.Split(" ");
        //Making a new empty array where we will store the reversed words
        string[] reversedWords = new string[split.Length];
        //Iterating through the sentence 
        for (int i = 0; i < split.Length; i++)
        {
            //Reverse the word using the Reverse() method
            string reversedWord = new string(split[i].Reverse().ToArray());
            //Adding the reversed words in the array we made for storing
            reversedWords[i] = reversedWord;
        }
        //Joining the array by an empty space
        string joinedString = string.Join(" ", reversedWords);
        return joinedString;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(Kata.ReverseWords("This is an example!"));
    }
}