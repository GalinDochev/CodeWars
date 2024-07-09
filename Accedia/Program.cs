using System.Text.RegularExpressions;

public static class FlatLand
{
    //Flatland is a country with a number of cities, some of which have space stations.
    //Cities are numbered consecutively and each has a road of  length connecting it to the next city.
    //It is not a circular route, so the first city doesn't connect with the last city.
    //Determine the maximum distance from any city to its nearest space station.
    public static int FlatlandSpaceStations(int n, int[] c)
    {
        if (c.Length == n)
        {
            return 0;
        }

        Array.Sort(c);

        int maxDistance = 0;

        maxDistance = Math.Max(maxDistance, c[0]);

        for (int i = 1; i < c.Length; i++)
        {
            int distance = (c[i] - c[i - 1]) / 2;
            maxDistance = Math.Max(maxDistance, distance);
        }

        maxDistance = Math.Max(maxDistance, n - 1 - c[c.Length - 1]);

        return maxDistance;
    }
   

    class Program
    {
        static void Main()
        {
            
        }
    }
}