//Given an array of integers, where all elements but one occur twice, find the unique element.

class Result
{

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int lonelyinteger(List<int> a)
    {
       return a.GroupBy(x => x).Where(gr=>gr.Count()==1).Select(gr=>gr.Key).FirstOrDefault();
    }

}