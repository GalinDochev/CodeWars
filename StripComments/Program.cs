using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FrequentlyUsedWords
{
    public static class StripCommentsSolution
    {
        public static List<string> Top3(string s)
        {
            return s.Split(new char[] { '/', '\\', '.', ',', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .GroupBy(word => word.ToLower())
                               .OrderByDescending(g => g.Count())
                               .Take(Math.Min(3, s.Split(new char[] { '/', '\\', '.', ',', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Where(word => !string.IsNullOrWhiteSpace(word))
                               .GroupBy(word => word.ToLower()).Count()))
                               .Select(g => g.Key)
                               .ToList();
        }
    }
       

    public static class Program
    {
        public static void Main()
        {
            var list = StripCommentsSolution.Top3("  //wont won't won't");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

}