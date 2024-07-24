//There is a collection of input strings and a collection of query strings.
//For each query string, determine how many times it occurs in the list of input strings.
//Return an array of the results.
class Result
{

    /*
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY strings
     *  2. STRING_ARRAY queries
     */

    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        List<int> occurences =new List<int>();
        foreach (var query in queries)
        {
         occurences.Add(strings.Where(s => s == query).Count());
        }
        return occurences;
    }

}