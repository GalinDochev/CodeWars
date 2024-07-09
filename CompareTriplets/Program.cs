////Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges,
///awarding points on a scale from 1 to 100 for three categories: problem clarity, originality, and difficulty.

//The rating for Alice's challenge is the triplet a = (a[0], a[1], a[2]), and the rating for Bob's challenge is the triplet b = (b[0], b[1], b[2]).

//The task is to find their comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with b[2].

//Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges,
//awarding points on a scale from 1 to 100 for three categories: problem clarity, originality, and difficulty.

//The rating for Alice's challenge is the triplet a = (a[0], a[1], a[2]), and the rating for Bob's challenge is the triplet b = (b[0], b[1], b[2]).

//The task is to find their comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with b[2].

public static class Result
{

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> CompareTriplets(List<int> a, List<int> b)
    {
         List<int> points= new List<int>();
        int alicePoints=0;
        int bobPoints=0;
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                alicePoints++;
            }
            else if (a[i] < b[i])
            {
                bobPoints++;
            }
            else
            {
                continue;
            }
        }
        points.Add(alicePoints);
        points.Add(bobPoints);
        return points;
    }

}

public static class Program
{
    public static void Main()
    {
        List<int> ponts = Result.CompareTriplets(new List<int> { 5, 6, 7 }, new List<int> { 3, 6, 10 });
        foreach (var point in ponts)
        {
            Console.Write(point);
        }
    }
}