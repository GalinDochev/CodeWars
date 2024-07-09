//Greed is a dice game played with five six-sided dice.
//Your mission, should you choose to accept it, is to score a throw according to these rules.
//You will always be given an array with five six-sided dice values.
//A single die can only be counted once in each roll.
//For example, a given "5" can only count as part of a triplet (contributing to the 500 points) or as a single 50 points, but not both in the same roll.

public static class Kata
{
    public static int Score(int[] dice)
    {
        return dice
          .GroupBy(d => d)
          .Select(g => Points(g.Key, g.Count()))
          .Sum();
    }

    private static int Points(int die, int count)
    {
        switch (die)
        {
            case 1:
                return (count / 3) * 1000 + (count % 3) * 100;
            case 5:
                return (count / 3) * 500 + (count % 3) * 50;
            default:
                return (count / 3) * die * 100;
        }
    }
}


public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.Score(new int[] { 5, 5, 5, 5, 6 }));
    }
}