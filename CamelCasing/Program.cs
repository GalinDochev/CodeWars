public class Kata
{
    public static string BreakCamelCase(string str)
    {
        string strWithoutCamelCasing = string.Empty;
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsUpper(str[i]))
            {
                strWithoutCamelCasing += " ";
            }
            strWithoutCamelCasing += str[i];
        }
        return strWithoutCamelCasing;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine(Kata.BreakCamelCase(""));
    }
}