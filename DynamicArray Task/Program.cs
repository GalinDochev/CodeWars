class Result
{

    /*
     * Complete the 'dynamicArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        List<List<int>> seqList = new List<List<int>>(new List<int>[n]);
        for (int i = 0; i < n; i++)
        {
            seqList[i] = new List<int>();
        }

        int lastAnswer = 0;
        List<int> results = new List<int>();

        foreach (var query in queries)
        {
            int t = query[0]; // 't' is assigned the value of the first element of the current query list
            int x = query[1]; // 'x' is assigned the value of the second element of the current query list
            int y = query[2]; // 'y' is assigned the value of the third element of the current query list

            int idx = (x ^ lastAnswer) % n;

            if (t == 1)
            {
                seqList[idx].Add(y);
            }
            else if (t == 2)
            {
                int value = seqList[idx][y % seqList[idx].Count];
                lastAnswer = value;
                results.Add(lastAnswer);
            }
        }

        return results;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int q = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> result = Result.dynamicArray(n, queries);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}