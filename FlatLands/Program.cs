public static class FairRations
{


    public static string FairRation(List<int> B)
    {
        int bread_given = 0;
        for (int i = 0; i <= B.Count - 2; i++)
        {
            if (B[i] % 2 != 0)
            {
                B[i]++;
                B[i + 1]++;
                bread_given += 2;
            }

        }
        if (B[B.Count - 1] % 2 == 0)
        {
            return bread_given.ToString();
        }
        else
        {
            return "NO";
        }
    }
}
    class Program
    {
        static void Main()
        {
            Console.WriteLine(FairRations.FairRation(new List<int> { 1, 2 }));
        }
    }
