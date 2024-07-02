public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]==0)
            {
                int nextNum = arr[i + 1];
                arr[i] = nextNum;
                for (int j = i+1; j < arr.Length; j++)
                {
                    arr[j] = arr[j+1];
                }
            }
        }
        return arr;
    }

    public class Program
    {
        static void Main()
        {
            Console.WriteLine(Kata.MoveZeroes([1, 2, 0, 1, 0, 1, 0, 3, 0, 1]));
        }
    }
}