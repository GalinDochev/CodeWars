//There are two n-element arrays of integers, A and B. Permute them into some A and B such that the relation A[i]+B[i] >= k holds for all i  where 0<=i<n .

//There will be q queries consisting of A, B, and k. For each query, return YES if some permutation A. B., satisfying the relation exists. Otherwise, return NO.

class Result
{

    /*
     * Complete the 'twoArrays' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY A
     *  3. INTEGER_ARRAY B
     */

    public static string twoArrays(int k, List<int> A, List<int> B)
    {
        var listA=A.OrderBy(x => x).ToList();
        var listB=B.OrderBy(x => x).ToList();
        for (int i = 0; i < A.Count; i++)
        {
            if (listA[i] + listB[i]>=k)
            {
                return "YES";
            }
        }
        return "NO";
    }

}

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Result.twoArrays(10, new List<int> { 2, 1, 3 }, new List<int> { 7,8,9 }));
    }
}