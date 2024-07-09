//In this kata you are required to, given a string, replace every letter with its position in the alphabet.

//If anything in the text isn't a letter, ignore it and don't return it.

public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        string positions = string.Empty;
        for (int i = 0; i < text.Length; i++)
        {
            char currentChar=char.ToLower(text[i]);
            if (char.IsLetter(currentChar))
            {
                int position = (int)currentChar-96;
                positions = String.Concat(positions +" "+ position);

            }
        }
        return positions.TrimStart().TrimEnd();
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.AlphabetPosition("The sunset sets at twelve o' clock."));
    }
}