public static class Solution
{
    public static string ReverseParentheses(string s)
    {
        var charStack = new Stack<char>();
        foreach (var symbol in s)
        {
            if (symbol == ')')
            {
                var reversedString = "";
                var popedSymbol = charStack.Pop();
                while (popedSymbol != '(')
                {
                    reversedString += popedSymbol;
                    popedSymbol = charStack.Pop();
                }

                foreach (var reversedSymbol in reversedString)
                {
                    charStack.Push(reversedSymbol);
                }
            }
            else
            {
                charStack.Push(symbol);
            }
        }

        var result = "";
        while (charStack.Count > 0)
        {
            result += charStack.Pop();
        }

        return new string(result.Reverse().ToArray());
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Solution.ReverseParentheses("(u(love)i)"));
    }
}