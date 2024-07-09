using System;
using System.Collections.Generic;
using System.Linq;

//Given a list and a number, create a new list that contains each number of list at most N times, without reordering.
//For example if the input number is 2, and the input list is [1,2,3,1,2,1,2,3],
//you take [1,2,3,1,2], drop the next [1,2] since this would lead to 1 and 2 being in the result 3 times, and then take 3, which leads to [1,2,3,1,2,3].
//With list [20,37,20,21] and number 1, the result would be [20,37,21].Given a list and a number,
//create a new list that contains each number of list at most N times, without reordering.
//For example if the input number is 2, and the input list is [1,2,3,1,2,1,2,3],
//you take [1,2,3,1,2], drop the next [1,2] since this would lead to 1 and 2 being in the result 3 times, and then take 3, which leads to [1,2,3,1,2,3].
//With list [20,37,20,21] and number 1, the result would be [20,37,21].
public class Kata
{
    public static int[] DeleteNth(int[] arr, int x)
    {
        Dictionary<int, int> countDict = new Dictionary<int, int>();
        List<int> filteredList = new List<int>();

        foreach (var item in arr)
        {
            if (!countDict.ContainsKey(item))
            {
                countDict[item] = 0;
            }

            if (countDict[item] < x)
            {
                filteredList.Add(item);
                countDict[item]++;
            }
        }

        return filteredList.ToArray();
    }
}